using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Controler;
using Loja.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja.View.Usuario
{
    public partial class TodosOsUsuarios : Form
    {
        public TodosOsUsuarios()
        {
                InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            UsuarioController usuario = new UsuarioController();

            usuarios = usuario.ListarTodosOsUsuario();

            foreach (var us in usuarios)
            {
                ListViewItem list = new ListViewItem(us.Nome);

                listViewUs.Items.Add(list);
            }

            
            
            

        }


    }
}
