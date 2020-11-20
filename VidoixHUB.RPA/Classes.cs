using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using VidoixHUB.RPA.Properties;

public class Client
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Width { get; set; }
    public string Heigth { get; set; }
}
public class Manage
{
    public static List<Client> GetClients()
    {
        return JsonConvert.DeserializeObject<List<Client>>(Settings.Default.Clients);
    }
    public static Client GetClientById(string id)
    {
        return JsonConvert.DeserializeObject<List<Client>>(Settings.Default.Clients).FirstOrDefault(client => client.Id == id);
    }
    public static string NewClient()
    {
        var clients = GetClients();

        string newId = (++Settings.Default.LastId).ToString();

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
    public static void DeleteClient(string id)
    {
        var clients = GetClients();

        var index = clients.FindIndex(x => x.Id == id);

        clients.RemoveAt(index);

        Settings.Default.Clients = JsonConvert.SerializeObject(clients);

        Settings.Default.Save();

        Settings.Default.Reload();
    }
    public static void SetClient(string id, Client client)
    {
        var clients = GetClients();

        var index = clients.FindIndex(x => x.Id == id);

        clients[index] = client;

        Settings.Default.Clients = JsonConvert.SerializeObject(clients);

        Settings.Default.Save();

        Settings.Default.Reload();
    }
}