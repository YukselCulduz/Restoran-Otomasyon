namespace RestoranProje
{
    partial class Sepet
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
            this.label1 = new System.Windows.Forms.Label();
            this.LockButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sepet_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yemek_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yemek_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siparişler";
            // 
            // LockButton
            // 
            this.LockButton.Location = new System.Drawing.Point(328, 540);
            this.LockButton.Margin = new System.Windows.Forms.Padding(4);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(179, 57);
            this.LockButton.TabIndex = 1;
            this.LockButton.Text = "Sipariş Oluştur";
            this.LockButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sepet_Id,
            this.Masa_Id,
            this.Yemek_Adi,
            this.Yemek_fiyat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 420);
            this.dataGridView1.TabIndex = 2;
            // 
            // Sepet_Id
            // 
            this.Sepet_Id.HeaderText = "Sepet Numarası";
            this.Sepet_Id.MinimumWidth = 6;
            this.Sepet_Id.Name = "Sepet_Id";
            this.Sepet_Id.ReadOnly = true;
            this.Sepet_Id.Width = 125;
            // 
            // Masa_Id
            // 
            this.Masa_Id.HeaderText = "Masa Numarası";
            this.Masa_Id.MinimumWidth = 6;
            this.Masa_Id.Name = "Masa_Id";
            this.Masa_Id.ReadOnly = true;
            this.Masa_Id.Width = 125;
            // 
            // Yemek_Adi
            // 
            this.Yemek_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yemek_Adi.HeaderText = "Yemek Adı";
            this.Yemek_Adi.MinimumWidth = 6;
            this.Yemek_Adi.Name = "Yemek_Adi";
            this.Yemek_Adi.ReadOnly = true;
            // 
            // Yemek_fiyat
            // 
            this.Yemek_fiyat.HeaderText = "Fiyatı";
            this.Yemek_fiyat.MinimumWidth = 6;
            this.Yemek_fiyat.Name = "Yemek_fiyat";
            this.Yemek_fiyat.ReadOnly = true;
            this.Yemek_fiyat.Width = 125;
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LockButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sepet";
            this.Text = "Mutfak";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sepet_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yemek_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yemek_fiyat;
    }
}