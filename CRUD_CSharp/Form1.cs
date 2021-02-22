using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetClients_Click(object sender, EventArgs e)
        {
            ClientController controlador = new ClientController();
            foreach (var item in controlador.GetClient().ToList())
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClientController controlador = new ClientController();
            Client model = new Client
            {
                FullName = "Prueba",
                Email = "prueba@prueba.com",
                PhoneNumber = "2781231"
            };
            controlador.AddClient(model);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClientController controller = new ClientController();
            Client model = new Client
            {
                ClientId = 2
            };
            controller.DelClient(model);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClientController controller = new ClientController();
            Client client = new Client
            {
                ClientId = 1,
                FullName = "Luis Contreras Arroyo"
            };
            controller.UpdateClient(client);
        }
    }
}
