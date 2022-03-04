using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_VD_Project.Entities;
using WF_VD_Project.DataBase;

namespace WF_VD_Project
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = tb_name.Text;
            user.username = tb_username.Text;
            user.password = tb_password.Text;
            user.status = cb_status.Text;
            user.userLevel = Convert.ToInt32(Math.Round(NUpDn_userLevel.Value, 0));
            DBU.NewUser(user);
            btn_Novo_Click(sender, e);
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_password.Clear();
            tb_username.Clear();
            cb_status.Text = "";
            NUpDn_userLevel.Value = 0;
            tb_name.Focus();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_password.Clear();
            tb_username.Clear();
            cb_status.Text = "";
            NUpDn_userLevel.Value = 0;
            tb_name.Focus();
        }
    }
}
