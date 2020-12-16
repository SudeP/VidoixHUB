using System;
using System.Windows.Forms;
using VidoixHUB.RPA.Properties;

namespace VidoixHUB.RPA
{
    public partial class UCProccess : UserControl
    {
        public readonly string id;
        public UCProccess(string id)
        {
            this.id = id;
            InitializeComponent();
            var client = Manage.GetClientById(id);
            tbxUsername.Text = client.Username;
            tbxPassword.Text = client.Password;
            nudWidth.Value = decimal.Parse(client.Width);
            nudHeigth.Value = decimal.Parse(client.Heigth);
        }
        private void TbxUsername_TextChanged(object sender, EventArgs e)
        {
            var client = Manage.GetClientById(id);
            client.Username = tbxUsername.Text;
            Manage.SetClient(id, client);
        }
        private void TbxPassword_TextChanged(object sender, EventArgs e)
        {
            var client = Manage.GetClientById(id);
            client.Password = tbxPassword.Text;
            Manage.SetClient(id, client);
        }
        private void NudWidth_ValueChanged(object sender, EventArgs e)
        {
            var client = Manage.GetClientById(id);
            client.Width = nudWidth.Value.ToString();
            Manage.SetClient(id, client);

            Settings.Default.Width = client.Width;

            Settings.Default.Save();

            Settings.Default.Reload();
        }
        private void NudHeigth_ValueChanged(object sender, EventArgs e)
        {
            var client = Manage.GetClientById(id);
            client.Heigth = nudHeigth.Value.ToString();
            Manage.SetClient(id, client);

            Settings.Default.Heigth = client.Heigth;

            Settings.Default.Save();

            Settings.Default.Reload();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıtlı satır silinsin mi ?", "Dikkat !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Manage.DeleteClient(id);
                MessageBox.Show("Başarılı");
                Dispose();
            }
        }
        private void BtnStart_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("Farmer.exe", $@"""{tbxUsername.Text}"" ""{tbxPassword.Text}"" ""{id}"" ""{nudWidth.Value}"" ""{nudHeigth.Value}"" ""{Settings.Default.ErrorWaitTime}""");
    }
}
