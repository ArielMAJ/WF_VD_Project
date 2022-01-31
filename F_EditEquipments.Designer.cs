namespace WF_VD_Project
{
    partial class F_EditEquipments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbB_EquipNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_EquipDescription = new System.Windows.Forms.TextBox();
            this.btn_action = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbB_AssociatedClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CkB_associateToClient = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(267, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 27;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_last_action_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(93, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Apagar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descrição do Equipamento";
            // 
            // CbB_EquipNames
            // 
            this.CbB_EquipNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbB_EquipNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbB_EquipNames.Enabled = false;
            this.CbB_EquipNames.FormattingEnabled = true;
            this.CbB_EquipNames.Items.AddRange(new object[] {
            "(Novo equipamento)"});
            this.CbB_EquipNames.Location = new System.Drawing.Point(12, 42);
            this.CbB_EquipNames.Name = "CbB_EquipNames";
            this.CbB_EquipNames.Size = new System.Drawing.Size(330, 23);
            this.CbB_EquipNames.TabIndex = 17;
            this.CbB_EquipNames.Text = "(Novo equipamento)";
            this.CbB_EquipNames.SelectedIndexChanged += new System.EventHandler(this.CbB_EquipNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Equipamento selecionado";
            // 
            // TB_EquipDescription
            // 
            this.TB_EquipDescription.Location = new System.Drawing.Point(12, 96);
            this.TB_EquipDescription.Name = "TB_EquipDescription";
            this.TB_EquipDescription.Size = new System.Drawing.Size(330, 23);
            this.TB_EquipDescription.TabIndex = 15;
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(12, 3);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(75, 23);
            this.btn_action.TabIndex = 14;
            this.btn_action.Text = "Adicionar";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateClientTableToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.addToolStripMenuItem.Text = "Adicionar";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateClientTableToolStripMenuItem
            // 
            this.updateClientTableToolStripMenuItem.Name = "updateClientTableToolStripMenuItem";
            this.updateClientTableToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.updateClientTableToolStripMenuItem.Text = "Atualizar";
            this.updateClientTableToolStripMenuItem.Click += new System.EventHandler(this.updateClientTableToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.deleteToolStripMenuItem.Text = "Deletar";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_action);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 35);
            this.panel1.TabIndex = 28;
            // 
            // CbB_AssociatedClient
            // 
            this.CbB_AssociatedClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbB_AssociatedClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbB_AssociatedClient.Enabled = false;
            this.CbB_AssociatedClient.FormattingEnabled = true;
            this.CbB_AssociatedClient.Items.AddRange(new object[] {
            "(Cliente associado)"});
            this.CbB_AssociatedClient.Location = new System.Drawing.Point(33, 145);
            this.CbB_AssociatedClient.Name = "CbB_AssociatedClient";
            this.CbB_AssociatedClient.Size = new System.Drawing.Size(309, 23);
            this.CbB_AssociatedClient.TabIndex = 30;
            this.CbB_AssociatedClient.Text = "(Cliente associado)";
            this.CbB_AssociatedClient.SelectedIndexChanged += new System.EventHandler(this.CbB_AssociatedClient_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Associar a cliente";
            // 
            // CkB_associateToClient
            // 
            this.CkB_associateToClient.AutoSize = true;
            this.CkB_associateToClient.Location = new System.Drawing.Point(12, 149);
            this.CkB_associateToClient.Name = "CkB_associateToClient";
            this.CkB_associateToClient.Size = new System.Drawing.Size(15, 14);
            this.CkB_associateToClient.TabIndex = 31;
            this.CkB_associateToClient.UseVisualStyleBackColor = true;
            this.CkB_associateToClient.CheckedChanged += new System.EventHandler(this.cb_associateToClient_CheckedChanged);
            // 
            // F_EditEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 213);
            this.Controls.Add(this.CkB_associateToClient);
            this.Controls.Add(this.CbB_AssociatedClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbB_EquipNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_EquipDescription);
            this.Controls.Add(this.menuStrip1);
            this.Name = "F_EditEquipments";
            this.Text = "F_EditEquipments";
            this.Load += new System.EventHandler(this.F_EditEquipments_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_close;
        private Button btn_clear;
        private ComboBox CB_EquipDesc;
        private ListBox LB_AddedEquipmentList;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox CbB_EquipNames;
        private Label label1;
        private TextBox TB_EquipDescription;
        private Button btn_action;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem updateClientTableToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel1;
        private ComboBox CbB_AssociatedClient;
        private CheckBox CkB_associateToClient;
    }
}