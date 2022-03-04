using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_VD_Project.DataBase;

namespace WF_VD_Project
{
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //label_Username.Text  = Directory.GetCurrentDirectory().Substring(60);
            string user = tb_Username.Text, pass = tb_Password.Text;
            if (user == "")
            {
                MessageBox.Show("Please enter an username.");
                tb_Username.Focus();
                return;
            }else if (pass == "")
            {
                MessageBox.Show("Please enter a password.");
                tb_Password.Focus();
                return;
            }
            dt = DBU.consult($"SELECT N_ID, T_USERSTATUS, N_USERLEVEL, T_NAME,T_USERNAME,T_PASSWORD " +
                            $"FROM TB_USERS " +
                            $"WHERE T_USERNAME='{user}' AND T_PASSWORD='{pass}';");
            if (dt.Rows.Count == 1)
            {
                string userStatus = dt.Rows[0].ItemArray[1].ToString();
                
                form1.label_Username.Text = dt.Rows[0].Field<string>("T_NAME");
                Globals.loggedIn = true;                
                form1.pictureBox1.Image = Properties.Resources.greenlight;
                Globals.userLevel = int.Parse(dt.Rows[0].Field<Int32>("N_USERLEVEL").ToString());
                form1.label_Access.Text = $"{Globals.userLevel}";
                this.Close();

            }
            else
            {
                MessageBox.Show("User not found");
                tb_Username.Focus();
                return;
            }

        }
    }
}
