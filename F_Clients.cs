using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_VD_Project
{
    public partial class F_Clients : Form
    {
        public F_Clients()
        {
            InitializeComponent();
        }

        private void F_Clients_Load(object sender, EventArgs e)
        {
            dgv_clients.DataSource = DB.consult("SELECT " +
                "T_NAME AS NOME, " +
                "T_CPF AS CPF, " +
                "T_JOBTITLE AS CARGO " +
                "FROM CLIENTS;");
        }
    }
}
