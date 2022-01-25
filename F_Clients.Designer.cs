namespace WF_VD_Project
{
    partial class F_Clients
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
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clients
            // 
            this.dgv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clients.Location = new System.Drawing.Point(0, 0);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.RowTemplate.Height = 25;
            this.dgv_clients.Size = new System.Drawing.Size(495, 236);
            this.dgv_clients.TabIndex = 0;
            // 
            // F_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 236);
            this.Controls.Add(this.dgv_clients);
            this.Name = "F_Clients";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.F_Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_clients;
    }
}