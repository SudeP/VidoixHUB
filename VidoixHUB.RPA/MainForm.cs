using System;
using System.Drawing;
using System.Windows.Forms;
using VidoixHUB.RPA.Properties;

namespace VidoixHUB.RPA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            nudErrorWaitTime.Value = (decimal)Settings.Default.ErrorWaitTime;

            foreach (var client in Manage.GetClients())
                Create(client.Id);
        }
        private int count = -1;
        private void Create(int id)
        {
            _ = new UCProccess(id)
            {
                Parent = pList,
                Location = new Point(0, ++count * 75)
            };
        }
        private void BtnAdd_Click(object sender, EventArgs e) => Create(Manage.NewClient());
        private void NudErrorWaitTime_ValueChanged(object sender, EventArgs e) => Settings.Default.ErrorWaitTime = (int)nudErrorWaitTime.Value;
    }
}
