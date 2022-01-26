namespace WF_VD_Project
{
    partial class F_AddClient
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
            this.LB_AddedEquipmentList = new System.Windows.Forms.ListBox();
            this.btn_add_equipment = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.CB_ClientNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_CPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_JobTitle = new System.Windows.Forms.TextBox();
            this.CB_EquipDesc = new System.Windows.Forms.ComboBox();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_last_action = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_AddedEquipmentList
            // 
            this.LB_AddedEquipmentList.FormattingEnabled = true;
            this.LB_AddedEquipmentList.ItemHeight = 15;
            this.LB_AddedEquipmentList.Location = new System.Drawing.Point(13, 194);
            this.LB_AddedEquipmentList.Name = "LB_AddedEquipmentList";
            this.LB_AddedEquipmentList.Size = new System.Drawing.Size(248, 79);
            this.LB_AddedEquipmentList.TabIndex = 10;
            // 
            // btn_add_equipment
            // 
            this.btn_add_equipment.Location = new System.Drawing.Point(267, 165);
            this.btn_add_equipment.Name = "btn_add_equipment";
            this.btn_add_equipment.Size = new System.Drawing.Size(75, 23);
            this.btn_add_equipment.TabIndex = 0;
            this.btn_add_equipment.Text = "Adicionar";
            this.btn_add_equipment.UseVisualStyleBackColor = true;
            this.btn_add_equipment.Click += new System.EventHandler(this.btn_add_equipment_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(12, 88);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(330, 23);
            this.TB_Name.TabIndex = 1;
            // 
            // CB_ClientNames
            // 
            this.CB_ClientNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ClientNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ClientNames.Enabled = false;
            this.CB_ClientNames.FormattingEnabled = true;
            this.CB_ClientNames.Items.AddRange(new object[] {
            "(Novo cliente)"});
            this.CB_ClientNames.Location = new System.Drawing.Point(12, 44);
            this.CB_ClientNames.Name = "CB_ClientNames";
            this.CB_ClientNames.Size = new System.Drawing.Size(330, 23);
            this.CB_ClientNames.TabIndex = 3;
            this.CB_ClientNames.Text = "(Novo cliente)";
            this.CB_ClientNames.SelectedIndexChanged += new System.EventHandler(this.CB_ClientNames_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente selecionado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateClientTableToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // TB_CPF
            // 
            this.TB_CPF.Location = new System.Drawing.Point(13, 136);
            this.TB_CPF.Name = "TB_CPF";
            this.TB_CPF.Size = new System.Drawing.Size(121, 23);
            this.TB_CPF.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cargo";
            // 
            // TB_JobTitle
            // 
            this.TB_JobTitle.Location = new System.Drawing.Point(140, 136);
            this.TB_JobTitle.Name = "TB_JobTitle";
            this.TB_JobTitle.Size = new System.Drawing.Size(202, 23);
            this.TB_JobTitle.TabIndex = 8;
            // 
            // CB_EquipDesc
            // 
            this.CB_EquipDesc.FormattingEnabled = true;
            this.CB_EquipDesc.Items.AddRange(new object[] {
            "(Novo cliente)"});
            this.CB_EquipDesc.Location = new System.Drawing.Point(13, 165);
            this.CB_EquipDesc.Name = "CB_EquipDesc";
            this.CB_EquipDesc.Size = new System.Drawing.Size(248, 23);
            this.CB_EquipDesc.TabIndex = 11;
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.Location = new System.Drawing.Point(267, 194);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveItem.TabIndex = 12;
            this.btn_RemoveItem.Text = "Remover";
            this.btn_RemoveItem.UseVisualStyleBackColor = true;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_last_action
            // 
            this.btn_last_action.Location = new System.Drawing.Point(267, 250);
            this.btn_last_action.Name = "btn_last_action";
            this.btn_last_action.Size = new System.Drawing.Size(75, 23);
            this.btn_last_action.TabIndex = 13;
            this.btn_last_action.Text = "Finalizar";
            this.btn_last_action.UseVisualStyleBackColor = true;
            this.btn_last_action.Click += new System.EventHandler(this.btn_last_action_Click);
            // 
            // F_AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 282);
            this.Controls.Add(this.btn_last_action);
            this.Controls.Add(this.btn_RemoveItem);
            this.Controls.Add(this.CB_EquipDesc);
            this.Controls.Add(this.LB_AddedEquipmentList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_JobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_ClientNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.btn_add_equipment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_AddClient";
            this.Text = "Editar Lista de Clientes";
            this.Load += new System.EventHandler(this.F_AddClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add_equipment;
        private TextBox TB_Name;
        private ComboBox CB_ClientNames;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem updateClientTableToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label3;
        private TextBox TB_CPF;
        private Label label4;
        private TextBox TB_JobTitle;
        private ListBox LB_AddedEquipmentList;
        private ComboBox CB_EquipDesc;
        private Button btn_RemoveItem;
        private Button btn_last_action;
    }
}