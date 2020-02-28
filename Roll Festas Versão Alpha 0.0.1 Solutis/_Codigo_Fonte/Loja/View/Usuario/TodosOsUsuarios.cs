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

            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            UsuarioController usuario = new UsuarioController();

            usuarios = usuario.ListarTodosOsUsuario();

            foreach (var us in usuarios)
            {
                ListViewItem list = new ListViewItem(us.Nome);
                list.SubItems.Add(us.Email);
                list.SubItems.Add(us.Data_admissao);

                listViewUs.Items.Add(list);
            }





        }


    }
}
