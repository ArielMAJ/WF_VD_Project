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
    public partial class F_AddClient : Form
    {
        private DataTable ClientData;
        private DataTable AvailableEquipments;
        //private DataTable UnavailableEquipments;

        int clientID = 0;

        public F_AddClient()
        {
            InitializeComponent();
            UpdateCB_Equipments();
            UpdateCB_Clients();

            CB_ClientNames.ValueMember = "IDCLIENT";
            CB_ClientNames.DisplayMember = "T_NAME";

            CB_EquipDesc.ValueMember = "IDEQUIPMENT";
            CB_EquipDesc.DisplayMember = "T_EQUIPMENTDESCRIPTION";

        }

        private void UpdateCB_Clients()
        {
            ClientData = DB.GetClients();
            CB_ClientNames.DataSource = ClientData;
        }
        private void UpdateCB_Equipments()
        {
            AvailableEquipments = DB.GetEquipments("ID_CLIENT IS NULL");
            CB_EquipDesc.DataSource = AvailableEquipments;
        }
        private void F_AddClient_Load(object sender, EventArgs e)
        {
            CB_ClientNames.Text = "(Novo cliente)";
        }

        private void updateClientTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CB_ClientNames.Enabled = true;
            btn_last_action.Text = "Atualizar";
            btn_add_equipment.Enabled = true;
            btn_RemoveItem.Enabled = true;
            UpdateCB_Clients();
            UpdateCB_Equipments();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CB_ClientNames.Enabled = true;
            btn_last_action.Text = "Deletar";
            btn_add_equipment.Enabled = false;
            btn_RemoveItem.Enabled = false;
            UpdateCB_Clients();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LB_AddedEquipmentList.Items.Clear();
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
            if (btn_last_action.Text == "Finalizar") return;
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
            DataTable thisClientEquipments = DB.consult($"SELECT IDEQUIPMENT, T_EQUIPMENTDESCRIPTION " +
                $"FROM EQUIPMENTS WHERE ID_CLIENT={clientID}");
            LB_AddedEquipmentList.Items.Clear();
            foreach (DataRow row in thisClientEquipments.Rows)
            {
                string txt = row.Field<Int64>("IDEQUIPMENT").ToString() + " - " + row.Field<string>("T_EQUIPMENTDESCRIPTION");
                LB_AddedEquipmentList.Items.Add(txt);
            }
        }

        private void btn_add_equipment_Click(object sender, EventArgs e)
        {
            //UnavailableEquipments.Rows.Add(CB_EquipmentDescriptions.SelectedItem);
            //string txt = CB_EquipmentDescriptions.SelectedValue.ToString() + " - " ;

            //DataTable t = DB.consult("SELECT IDEQUIPMENT, T_EQUIPMENTDESCRIPTION FROM EQUIPMENTS WHERE ID_CLIENT IS NULL");
            //MessageBox.Show(t.Rows[0].Field<string>("T_EQUIPMENTDESCRIPTION"));
            string txt = CB_EquipDesc.SelectedValue.ToString();
            txt += " - " + AvailableEquipments.Select($"IDEQUIPMENT={txt}")[0].Field<string>("T_EQUIPMENTDESCRIPTION");
            if (LB_AddedEquipmentList.Items.Contains(txt)) return;
            LB_AddedEquipmentList.Items.Add(txt);
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            LB_AddedEquipmentList.Items.Remove(LB_AddedEquipmentList.SelectedItem);

        }

        private void btn_last_action_Click(object sender, EventArgs e)
        {
            switch (btn_last_action.Text)
            {
                case "Finalizar":
                    if (!(TB_Name.Text != "" && TB_CPF.Text != ""))
                    {
                        MessageBox.Show("Nome e CPF devem ser preenchidos");
                        return;
                    }

                    DB.consult("INSERT INTO CLIENTS(T_NAME,T_CPF,T_JOBTITLE)" +
                        $"VALUES('{TB_Name.Text}', '{TB_CPF.Text}','{TB_JobTitle.Text}') ");
                    clientID = int.Parse(DB.consult($"SELECT IDCLIENT FROM CLIENTS WHERE " +
                        $"T_NAME='{TB_Name.Text}' AND " +
                        $"T_CPF='{TB_CPF.Text}' AND " +
                        $"T_JOBTITLE='{TB_JobTitle.Text}'").Rows[0].Field<Int64>("IDCLIENT").ToString());
                    foreach (string s in LB_AddedEquipmentList.Items)
                    {
                        DB.consult("UPDATE EQUIPMENTS SET " +
                            $"ID_CLIENT={clientID} " +
                            $"WHERE ID_CLIENT IS NULL AND IDEQUIPMENT={s.Split(" ")[0]}");
                    }

                    TB_Name.Text = "";
                    TB_CPF.Text = "";
                    TB_JobTitle.Text = "";
                    LB_AddedEquipmentList.Items.Clear();
                    break;
                case "Atualizar":
                    if (!(TB_Name.Text != "" && TB_CPF.Text != ""))
                    {
                        MessageBox.Show("Nome e CPF devem ser preenchidos");
                        return;
                    }
                    DB.consult("UPDATE CLIENTS SET " +
                        $"T_NAME = '{TB_Name.Text}', " +
                        $"T_CPF = '{TB_CPF.Text}', " +
                        $"T_JOBTITLE = '{TB_JobTitle.Text}' " +
                        $"WHERE IDCLIENT = {clientID};");

                    DB.consult("UPDATE EQUIPMENTS SET " +
                            $"ID_CLIENT=NULL " +
                            $"WHERE ID_CLIENT = {clientID}");
                    foreach (string s in LB_AddedEquipmentList.Items)
                    {
                        DB.consult("UPDATE EQUIPMENTS SET " +
                            $"ID_CLIENT={clientID} " +
                            $"WHERE ID_CLIENT IS NULL AND IDEQUIPMENT={s.Split(" ")[0]}");
                    }

                    break;
                case "Deletar":
                    DB.consult("DELETE FROM CLIENTS " +
                        $"WHERE IDCLIENT = {clientID};");
                    TB_Name.Text = "";
                    TB_CPF.Text = "";
                    TB_JobTitle.Text = "";
                    foreach (string s in LB_AddedEquipmentList.Items)
                    {
                        DB.consult("UPDATE EQUIPMENTS SET " +
                            "ID_CLIENT=NULL " +
                            $"WHERE ID_CLIENT = {clientID}");
                    }
                    break;
                default:
                    break;
            }

            UpdateCB_Clients();
            if (btn_last_action.Text == "Finalizar")
                CB_ClientNames.Text = "(Novo cliente)";
            UpdateCB_Equipments();
            btn_Load_Click(sender, e);
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
