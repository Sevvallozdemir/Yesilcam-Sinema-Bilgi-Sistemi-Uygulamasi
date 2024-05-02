namespace VeriTabaniFinalProjesi
{
    partial class OyuncuFilmEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuFilmEkrani));
            this.OyuncuFilmleriGetirbtn = new System.Windows.Forms.Button();
            this.oyuncuid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OyuncuFilmleriGetirbtn
            // 
            this.OyuncuFilmleriGetirbtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OyuncuFilmleriGetirbtn.Location = new System.Drawing.Point(290, 55);
            this.OyuncuFilmleriGetirbtn.Name = "OyuncuFilmleriGetirbtn";
            this.OyuncuFilmleriGetirbtn.Size = new System.Drawing.Size(229, 49);
            this.OyuncuFilmleriGetirbtn.TabIndex = 0;
            this.OyuncuFilmleriGetirbtn.Text = "GÖRÜNTÜLE";
            this.OyuncuFilmleriGetirbtn.UseVisualStyleBackColor = true;
            this.OyuncuFilmleriGetirbtn.Click += new System.EventHandler(this.OyuncuFilmleriGetirbtn_Click);
            // 
            // oyuncuid
            // 
            this.oyuncuid.Location = new System.Drawing.Point(394, 12);
            this.oyuncuid.Name = "oyuncuid";
            this.oyuncuid.Size = new System.Drawing.Size(125, 27);
            this.oyuncuid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oyuncu id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(741, 328);
            this.dataGridView1.TabIndex = 4;
            // 
            // OyuncuFilmEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oyuncuid);
            this.Controls.Add(this.OyuncuFilmleriGetirbtn);
            this.Name = "OyuncuFilmEkrani";
            this.Text = "OyuncuFilmEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OyuncuFilmleriGetirbtn;
        private TextBox oyuncuid;
        private Label label1;
        private DataGridView dataGridView1;
    }
}