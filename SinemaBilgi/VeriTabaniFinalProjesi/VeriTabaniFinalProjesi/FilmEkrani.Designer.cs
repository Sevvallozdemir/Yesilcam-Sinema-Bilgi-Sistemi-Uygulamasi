namespace VeriTabaniFinalProjesi
{
    partial class FilmEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmEkrani));
            this.filmeklemeislembtn = new System.Windows.Forms.Button();
            this.filmsilmeislembtn = new System.Windows.Forms.Button();
            this.filmguncellemeislembtn = new System.Windows.Forms.Button();
            this.filmlistelebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmeklemeislembtn
            // 
            this.filmeklemeislembtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filmeklemeislembtn.Location = new System.Drawing.Point(47, 12);
            this.filmeklemeislembtn.Name = "filmeklemeislembtn";
            this.filmeklemeislembtn.Size = new System.Drawing.Size(303, 67);
            this.filmeklemeislembtn.TabIndex = 0;
            this.filmeklemeislembtn.Text = "Film Ekleme işlemi için tıklayınız";
            this.filmeklemeislembtn.UseVisualStyleBackColor = true;
            this.filmeklemeislembtn.Click += new System.EventHandler(this.filmeklemeislembtn_Click);
            // 
            // filmsilmeislembtn
            // 
            this.filmsilmeislembtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filmsilmeislembtn.Location = new System.Drawing.Point(462, 12);
            this.filmsilmeislembtn.Name = "filmsilmeislembtn";
            this.filmsilmeislembtn.Size = new System.Drawing.Size(303, 67);
            this.filmsilmeislembtn.TabIndex = 1;
            this.filmsilmeislembtn.Text = "Film Silme işlemi için tıklayınız";
            this.filmsilmeislembtn.UseVisualStyleBackColor = true;
            this.filmsilmeislembtn.Click += new System.EventHandler(this.filmsilmeislembtn_Click);
            // 
            // filmguncellemeislembtn
            // 
            this.filmguncellemeislembtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filmguncellemeislembtn.Location = new System.Drawing.Point(47, 101);
            this.filmguncellemeislembtn.Name = "filmguncellemeislembtn";
            this.filmguncellemeislembtn.Size = new System.Drawing.Size(303, 67);
            this.filmguncellemeislembtn.TabIndex = 2;
            this.filmguncellemeislembtn.Text = "Film Güncelleme işlemi için tıklayınız";
            this.filmguncellemeislembtn.UseVisualStyleBackColor = true;
            this.filmguncellemeislembtn.Click += new System.EventHandler(this.filmguncellemeislembtn_Click);
            // 
            // filmlistelebtn
            // 
            this.filmlistelebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filmlistelebtn.Location = new System.Drawing.Point(462, 101);
            this.filmlistelebtn.Name = "filmlistelebtn";
            this.filmlistelebtn.Size = new System.Drawing.Size(303, 67);
            this.filmlistelebtn.TabIndex = 3;
            this.filmlistelebtn.Text = "Filmleri Listele";
            this.filmlistelebtn.UseVisualStyleBackColor = true;
            this.filmlistelebtn.Click += new System.EventHandler(this.filmlistelebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 252);
            this.dataGridView1.TabIndex = 4;
            // 
            // FilmEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filmlistelebtn);
            this.Controls.Add(this.filmguncellemeislembtn);
            this.Controls.Add(this.filmsilmeislembtn);
            this.Controls.Add(this.filmeklemeislembtn);
            this.Name = "FilmEkrani";
            this.Text = "FilmEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button filmeklemeislembtn;
        private Button filmsilmeislembtn;
        private Button filmguncellemeislembtn;
        private Button filmlistelebtn;
        private DataGridView dataGridView1;
    }
}