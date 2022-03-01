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
    public partial class F_Equipments : Form
    {
        public F_Equipments()
        {
            InitializeComponent();
        }

        private void F_Equipments_Load(object sender, EventArgs e)
        {
            dgv_equipments.DataSource = DB.consult("SELECT A.IDEQUIPMENT, B.T_NAME, A.T_EQUIPMENTDESCRIPTION " +
                "FROM EQUIPMENTS A LEFT JOIN CLIENTS B ON A.ID_CLIENT = B.IDCLIENT");

        }
    }
}
