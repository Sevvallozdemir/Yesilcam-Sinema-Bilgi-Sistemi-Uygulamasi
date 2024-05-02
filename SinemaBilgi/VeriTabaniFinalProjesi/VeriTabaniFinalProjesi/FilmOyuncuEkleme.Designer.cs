namespace VeriTabaniFinalProjesi
{
    partial class FilmOyuncuEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmOyuncuEkleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filmidtxt = new System.Windows.Forms.TextBox();
            this.oyuncuidtxt = new System.Windows.Forms.TextBox();
            this.eklebtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyuncu ID:";
            // 
            // filmidtxt
            // 
            this.filmidtxt.Location = new System.Drawing.Point(211, 29);
            this.filmidtxt.Name = "filmidtxt";
            this.filmidtxt.Size = new System.Drawing.Size(125, 27);
            this.filmidtxt.TabIndex = 2;
            // 
            // oyuncuidtxt
            // 
            this.oyuncuidtxt.Location = new System.Drawing.Point(211, 69);
            this.oyuncuidtxt.Name = "oyuncuidtxt";
            this.oyuncuidtxt.Size = new System.Drawing.Size(125, 27);
            this.oyuncuidtxt.TabIndex = 3;
            // 
            // eklebtn
            // 
            this.eklebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eklebtn.Location = new System.Drawing.Point(412, 43);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(122, 44);
            this.eklebtn.TabIndex = 4;
            this.eklebtn.Text = "EKLE";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listelebtn.Location = new System.Drawing.Point(593, 43);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(122, 44);
            this.listelebtn.TabIndex = 5;
            this.listelebtn.Text = "LİSTELE";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(729, 306);
            this.dataGridView1.TabIndex = 6;
            // 
            // FilmOyuncuEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.oyuncuidtxt);
            this.Controls.Add(this.filmidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FilmOyuncuEkleme";
            this.Text = "FilmOyuncuEkleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox filmidtxt;
        private TextBox oyuncuidtxt;
        private Button eklebtn;
        private Button listelebtn;
        private DataGridView dataGridView1;
    }
}