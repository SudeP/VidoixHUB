using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using VidoixHUB.RPA.Properties;

public class Client
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int Width { get; set; }
    public int Heigth { get; set; }
}
public class Manage
{
    public static List<Client> GetClients()
    {
        return JsonConvert.DeserializeObject<List<Client>>(Settings.Default.Clients);
    }
    public static Client GetClientById(int id)
    {
        return JsonConvert.DeserializeObject<List<Client>>(Settings.Default.Clients).FirstOrDefault(client => client.Id == id);
    }
    public static int NewClient()
    {
        var clients = GetClients();

        int newId = Settings.Default.LastId;

        clients.Add(new Client()
        {
            Id = newId,
            Width = Settings.Default.Width,
            Heigth = Settings.Default.Heigth
        });

        Settings.Default.Clients = JsonConvert.SerializeObject(clients);

        Settings.Default.Save();

        Settings.Default.Reload();

        return newId;
    }
    public static void DeleteClient(int id)
    {
        var clients = GetClients();

        var index = clients.FindIndex(x => x.Id == id);

        clients.RemoveAt(index);

        Settings.Default.Clients = JsonConvert.SerializeObject(clients);

        Settings.Default.Save();

        Settings.Default.Reload();
    }
    public static void SetClient(int id, Client client)
    {
        var clients = GetClients();

        var index = clients.FindIndex(x => x.Id == id);

        clients[index] = client;

        Settings.Default.Clients = JsonConvert.SerializeObject(clients);

        Settings.Default.Save();

        Settings.Default.Reload();
    }
}