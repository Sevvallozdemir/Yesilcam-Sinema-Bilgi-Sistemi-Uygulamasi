namespace VeriTabaniFinalProjesi
{
    partial class OyuncuEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuEkrani));
            this.oyuncueklebtn = new System.Windows.Forms.Button();
            this.oyuncuguncellebtn = new System.Windows.Forms.Button();
            this.oyuncusilmebtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // oyuncueklebtn
            // 
            this.oyuncueklebtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oyuncueklebtn.Location = new System.Drawing.Point(53, 12);
            this.oyuncueklebtn.Name = "oyuncueklebtn";
            this.oyuncueklebtn.Size = new System.Drawing.Size(303, 67);
            this.oyuncueklebtn.TabIndex = 0;
            this.oyuncueklebtn.Text = "Oyuncu Ekleme işlemi için tıklayınız";
            this.oyuncueklebtn.UseVisualStyleBackColor = true;
            this.oyuncueklebtn.Click += new System.EventHandler(this.oyuncueklebtn_Click);
            // 
            // oyuncuguncellebtn
            // 
            this.oyuncuguncellebtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oyuncuguncellebtn.Location = new System.Drawing.Point(53, 85);
            this.oyuncuguncellebtn.Name = "oyuncuguncellebtn";
            this.oyuncuguncellebtn.Size = new System.Drawing.Size(303, 67);
            this.oyuncuguncellebtn.TabIndex = 1;
            this.oyuncuguncellebtn.Text = "Oyuncu Güncelleme işlemi için tıklayınız";
            this.oyuncuguncellebtn.UseVisualStyleBackColor = true;
            this.oyuncuguncellebtn.Click += new System.EventHandler(this.oyuncuguncellebtn_Click);
            // 
            // oyuncusilmebtn
            // 
            this.oyuncusilmebtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oyuncusilmebtn.Location = new System.Drawing.Point(447, 12);
            this.oyuncusilmebtn.Name = "oyuncusilmebtn";
            this.oyuncusilmebtn.Size = new System.Drawing.Size(303, 67);
            this.oyuncusilmebtn.TabIndex = 2;
            this.oyuncusilmebtn.Text = "Oyuncu silme işlemi için tıklayınız";
            this.oyuncusilmebtn.UseVisualStyleBackColor = true;
            this.oyuncusilmebtn.Click += new System.EventHandler(this.oyuncusilmebtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listelebtn.Location = new System.Drawing.Point(447, 85);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(303, 67);
            this.listelebtn.TabIndex = 3;
            this.listelebtn.Text = "LİSTELE";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 277);
            this.dataGridView1.TabIndex = 4;
            // 
            // OyuncuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.oyuncusilmebtn);
            this.Controls.Add(this.oyuncuguncellebtn);
            this.Controls.Add(this.oyuncueklebtn);
            this.Name = "OyuncuEkrani";
            this.Text = "OyuncuEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button oyuncueklebtn;
        private Button oyuncuguncellebtn;
        private Button oyuncusilmebtn;
        private Button listelebtn;
        private DataGridView dataGridView1;
    }
}