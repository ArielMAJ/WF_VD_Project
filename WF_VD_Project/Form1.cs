namespace WF_VD_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
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

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_EditEquipments form = new F_EditEquipments();
            form.ShowDialog();
        }
        ////


        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_Access.Text = "0";
            label_Username.Text = "--";
            Globals.loggedIn = false;
            pictureBox1.Image = Properties.Resources.redlight;
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOffToolStripMenuItem_Click(sender, e);
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.loggedIn)
            {
                if (Globals.userLevel >= 2)
                {

                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.loggedIn)
            {
                if (Globals.userLevel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }

        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Globals.loggedIn)
            {
                if (Globals.userLevel >= 1)
                {

                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Globals.loggedIn)
            {

            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }
    }
}