using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;

namespace RollFestas.View.Usuario
{
    public partial class TodosUsuarios : Form
    {
        public TodosUsuarios()
        {
            InitializeComponent();

            //CARREGAR LISTA
            UsuarioController usuarioC = new UsuarioController();
            List<UsuarioModel> ListaUsuarios = usuarioC.ListarTodosOsUsuario();

            foreach (var usuario in ListaUsuarios)
            {
                ListViewItem list = new ListViewItem(usuario.Nome);
                list.SubItems.Add(usuario.Email);
                list.SubItems.Add(usuario.Data_Admissao);

                ListaViewUsuario.Items.Add(list);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._CaminhoArquivoDuvida + @"\Duvida_Usuario.pdf");
        }
    }
}
