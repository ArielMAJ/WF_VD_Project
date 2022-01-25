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
    public partial class F_AddClient : Form
    {
        public DataTable ClientData { get; set; }
        public DataTable EquipmentData { get; set; }

        public F_AddClient()
        {
            InitializeComponent();
            UpdateCB_Equipments();
            UpdateCB_Clients();
        }

        private void UpdateCB_Clients()
        {
            ClientData = DB.consult("SELECT IDCLIENT, T_NAME, T_CPF, T_JOBTITLE FROM CLIENTS");

            CB_ClientNames.DataSource = ClientData;
            CB_ClientNames.ValueMember = "IDCLIENT";
            CB_ClientNames.DisplayMember = "T_NAME";
        }
        private void UpdateCB_Equipments()
        {
            EquipmentData = DB.consult("SELECT IDEQUIPMENT, T_EQUIPMENTDESCRIPTION FROM EQUIPMENTS WHERE ID_CLIENT IS NULL");

            CB_EquipmentDescriptions.DataSource = EquipmentData;
            CB_EquipmentDescriptions.ValueMember = "IDEQUIPMENT";
            CB_EquipmentDescriptions.DisplayMember = "T_EQUIPMENTDESCRIPTION";
        }
        private void F_AddClient_Load(object sender, EventArgs e)
        {
            CB_ClientNames.Text = "(Novo cliente)";
        }

        private void updateClientTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CB_ClientNames.Enabled = true;
            UpdateCB_Clients();
            btn_last_action.Text = "Atualizar";
            btn_add_equipment.Enabled = true;
            btn_RemoveItem.Enabled = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CB_ClientNames.Enabled = true;
            UpdateCB_Clients();
            btn_last_action.Text = "Deletar";
            btn_add_equipment.Enabled = false;
            btn_RemoveItem.Enabled = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CB_ClientNames.Enabled = false;
            btn_last_action.Text = "Finalizar";
            CB_ClientNames.Text = "(Novo cliente)";

            TB_Name.Text = "";
            TB_CPF.Text = "";
            TB_JobTitle.Text = "";


            btn_add_equipment.Enabled = true;
            btn_RemoveItem.Enabled = true;
        }

        private void CB_ClientNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clientID;
            try
            {
                clientID = int.Parse(CB_ClientNames.SelectedValue.ToString());
            }
            catch
            {
                return;
            }

            DataRow client = ClientData.Select($"IDCLIENT={clientID}")[0];
            TB_Name.Text = client.Field<string>("T_NAME");
            TB_CPF.Text = client.Field<string>("T_CPF");
            TB_JobTitle.Text = client.Field<string>("T_JOBTITLE");
        }

        private void btn_add_equipment_Click(object sender, EventArgs e)
        {
            if (!LB_AddedEquipmentList.Items.Contains(CB_EquipmentDescriptions.Text))
                LB_AddedEquipmentList.Items.Add(CB_EquipmentDescriptions.Text);
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            LB_AddedEquipmentList.Items.Remove(LB_AddedEquipmentList.SelectedItem);
        }
    }
}
