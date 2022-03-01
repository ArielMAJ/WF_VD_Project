namespace WF_VD_Project
{
    partial class F_Equipments
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
            this.dgv_equipments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_equipments
            // 
            this.dgv_equipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_equipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_equipments.Location = new System.Drawing.Point(0, 0);
            this.dgv_equipments.Name = "dgv_equipments";
            this.dgv_equipments.RowTemplate.Height = 25;
            this.dgv_equipments.Size = new System.Drawing.Size(509, 213);
            this.dgv_equipments.TabIndex = 0;
            // 
            // F_Equipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 213);
            this.Controls.Add(this.dgv_equipments);
            this.Name = "F_Equipments";
            this.Text = "Equipamentos";
            this.Load += new System.EventHandler(this.F_Equipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_equipments;
    }
}