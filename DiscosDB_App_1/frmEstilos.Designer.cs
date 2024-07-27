namespace DiscosDB_App_1
{
    partial class frmEstilos
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
            this.dgvEstilos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstilos
            // 
            this.dgvEstilos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstilos.Location = new System.Drawing.Point(56, 45);
            this.dgvEstilos.Name = "dgvEstilos";
            this.dgvEstilos.RowHeadersWidth = 51;
            this.dgvEstilos.RowTemplate.Height = 24;
            this.dgvEstilos.Size = new System.Drawing.Size(544, 195);
            this.dgvEstilos.TabIndex = 0;
            // 
            // frmEstilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 391);
            this.Controls.Add(this.dgvEstilos);
            this.Name = "frmEstilos";
            this.Text = "frmEstilos";
            this.Load += new System.EventHandler(this.frmEstilos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstilos;
    }
}