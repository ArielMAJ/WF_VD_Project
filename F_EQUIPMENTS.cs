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
    public partial class F_Equipments : Form
    {
        public F_Equipments()
        {
            InitializeComponent();
        }

        private void F_Equipments_Load(object sender, EventArgs e)
        {
            dgv_equipments.DataSource = DB.consult("SELECT " +
                "CLIENTS.T_NAME AS NOME, " +
                "EQUIPMENTS.T_EQUIPMENTDESCRIPTION AS EQUIPAMENTO " +
                "FROM CLIENTS, EQUIPMENTS WHERE IDCLIENT=ID_CLIENT;");

        }
    }
}
