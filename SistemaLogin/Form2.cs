using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form2 : Form
    { public static bool Cancelar = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {   
            string nome = txtUsuario.Text;
            string senha = txtsenha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
                txtUsuario.Text = "";
                txtsenha.Text = "";
                txtUsuario.Focus();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

      
    }
}
