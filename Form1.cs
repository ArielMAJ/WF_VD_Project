namespace WF_VD_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openClientsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Clients f_clients = new F_Clients();
            f_clients.ShowDialog();
        }

        private void openEquipmentsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Equipments f_equipments = new F_Equipments();
            f_equipments.ShowDialog();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_AddClient form = new F_AddClient();
            form.ShowDialog();
        }
    }
}