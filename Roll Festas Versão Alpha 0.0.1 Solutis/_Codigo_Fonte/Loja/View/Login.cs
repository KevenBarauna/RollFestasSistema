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

namespace Loja
{

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            UsuarioController us = new UsuarioController();
            us.IniciaLogin();

            DAOVENDATEMP daoTemp = new DAOVENDATEMP();
            daoTemp.ZerarTabela();

            MessageBox.Show("ESSE É UM SISTEMA QUE ESTÁ EM SUA VERSÃO DE TESTE, CONTINUE ANOTANDO SUAS VENDAS NO CADERNO AO FINAL DO DIA");
 

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            bool acesso = false;
            UsuarioController usuario = new UsuarioController();
            acesso = usuario.Login(TxtUsuario.Text, TxtSenha.Text);
            if (acesso == true)
            {
                this.Hide();
            }

            
        }
    }
}
