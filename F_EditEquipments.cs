using System;
using System.Data;
using WF_VD_Project.Entities;
using WF_VD_Project.Entities.Exceptions;
using WF_VD_Project.DataBase;

namespace WF_VD_Project
{
    public partial class F_EditEquipments : Form
    {
        DataTable Clients;
        DataTable Equipments;
        public F_EditEquipments()
        {
            InitializeComponent();

        }
        private void F_EditEquipments_Load(object sender, EventArgs e)
        {
            CbB_EquipNames.ValueMember = "IDEQUIPMENT";
            CbB_EquipNames.DisplayMember = "T_EQUIPMENTDESCRIPTION";
            CbB_AssociatedClient.ValueMember = "IDCLIENT";
            CbB_AssociatedClient.DisplayMember = "T_NAME";

            Clients = DB.GetClients();
            CbB_AssociatedClient.DataSource = Clients;
            CbB_AssociatedClient.Text = "(Cliente associado)";
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_EquipDescription.Enabled = true;
            CkB_associateToClient.Enabled = true;
            CbB_EquipNames.Enabled = false;
            btn_clear.Enabled = true;

            btn_action.Text = "Adicionar";
            CbB_EquipNames.Text = "(Novo equipamento)";
            TB_EquipDescription.Clear();
            CkB_associateToClient.Checked = false;
            CbB_AssociatedClient.Text = "(Cliente associado)";
        }

        private void btn_last_action_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_associateToClient_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_action.Text == "Deletar") return;
            CbB_AssociatedClient.Enabled = CkB_associateToClient.Checked;
        }

        private void updateClientTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_EquipDescription.Enabled = true;
            CkB_associateToClient.Enabled = true;
            CbB_EquipNames.Enabled = true;
            btn_clear.Enabled = true;

            btn_action.Text = "Atualizar";
            Equipments = DB.GetEquipments();
            CbB_EquipNames.DataSource = Equipments;
            Clients = DB.GetClients();
            CbB_AssociatedClient.DataSource = Clients;
            CbB_EquipNames.Text = "(Novo equipamento)";
            CbB_AssociatedClient.Text = "(Cliente associado)";
            TB_EquipDescription.Text = "";
            CbB_AssociatedClient.Enabled = CkB_associateToClient.Checked;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_action.Text = "Deletar";

            TB_EquipDescription.Enabled = false;
            CkB_associateToClient.Enabled = false;
            CbB_EquipNames.Enabled = true;
            CbB_AssociatedClient.Enabled = false;
            btn_clear.Enabled = false;

            Equipments = DB.GetEquipments();
            CbB_EquipNames.DataSource = Equipments;
            Clients = DB.GetClients();
            CbB_AssociatedClient.DataSource = Clients;
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            string client_id;
            Equipment equipment;

            if (CkB_associateToClient.Checked) { client_id = CbB_AssociatedClient.SelectedValue.ToString(); }
            else { client_id = "NULL"; }

            try { equipment = new Equipment(TB_EquipDescription.Text, client_id); }
            catch (DomainException ex) { MessageBox.Show(ex.Message); return; }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }


            switch (btn_action.Text)
            {
                case "Adicionar":
                    equipment.SaveToDB();

                    addToolStripMenuItem_Click(sender, e);
                    break;

                case "Atualizar":
                    equipment.UpdateInDB(CbB_EquipNames.SelectedValue.ToString());

                    updateClientTableToolStripMenuItem_Click(sender, e);
                    break;
                case "Deletar":
                    Equipment.DeleteFromDB(CbB_EquipNames.SelectedValue.ToString());

                    deleteToolStripMenuItem_Click(sender, e);
                    break;
                default:
                    break;
            }

            //UpdateCB_Clients();
            //if (btn_last_action.Text == "Finalizar")
            //    CB_ClientNames.Text = "(Novo cliente)";
            //UpdateCB_Equipments();
            //btn_Load_Click(sender, e);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            TB_EquipDescription.Clear();
            CkB_associateToClient.Checked = false;
            CbB_AssociatedClient.Text = "(Cliente associado)";
        }

        private void CbB_AssociatedClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbB_EquipNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int equipID;
            if (btn_action.Text == "Adicionar") return;
            try
            {
                //Sleep(300);
                equipID = int.Parse(CbB_EquipNames.SelectedValue.ToString());
            }
            catch
            {
                return;
            }

            DataRow equipment = Equipments.Select($"IDEQUIPMENT={equipID}")[0];
            int id_client;
            string clientName;
            if (equipment.IsNull("ID_CLIENT"))
            {
                id_client = -1;
                CkB_associateToClient.Checked = false;
                CbB_AssociatedClient.SelectedItem = null;
                CbB_AssociatedClient.Text = "(Cliente associado)";
            }
            else
            {
                id_client = int.Parse(equipment.Field<Int64>("ID_CLIENT").ToString());
                clientName = Clients.Select($"IDCLIENT={id_client}")[0].Field<string>("T_NAME");
                //CbB_AssociatedClient.SelectedIndex = CbB_AssociatedClient.Items.IndexOf();
                CkB_associateToClient.Checked = true;
                CbB_AssociatedClient.SelectedIndex = CbB_AssociatedClient.FindString(clientName);

                //MessageBox.Show(.ToString());

            }

            TB_EquipDescription.Text = equipment.Field<string>("T_EQUIPMENTDESCRIPTION");

            //MessageBox.Show(CbB_AssociatedClient.Items.IndexOf(id_client).ToString());
            //CbB_AssociatedClient.SelectedIndex = CbB_AssociatedClient.Items.IndexOf(clientName);


        }
    }
}
