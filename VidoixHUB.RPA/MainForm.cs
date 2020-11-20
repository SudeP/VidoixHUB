using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidoixHUB.RPA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (var client in Manage.GetClients())
                Create(client.Id);
        }
        private int count = -1;
        private void Create(string id)
        {
            _ = new UCProccess(id)
            {
                Parent = pList,
                Location = new Point(0, ++count * 75)
            };
        }
        private void btnAdd_Click(object sender, EventArgs e) => Create(Manage.NewClient());
    }
}
