namespace VeriTabaniFinalProjesi
{
    partial class FilmSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmSilme));
            this.filmsilbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filmidtxt = new System.Windows.Forms.TextBox();
            this.listelebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmsilbtn
            // 
            this.filmsilbtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmsilbtn.Location = new System.Drawing.Point(251, 61);
            this.filmsilbtn.Name = "filmsilbtn";
            this.filmsilbtn.Size = new System.Drawing.Size(122, 41);
            this.filmsilbtn.TabIndex = 0;
            this.filmsilbtn.Text = "SİL";
            this.filmsilbtn.UseVisualStyleBackColor = true;
            this.filmsilbtn.Click += new System.EventHandler(this.filmsilbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek istediğiniz filmin id\'sini giriniz:";
            // 
            // filmidtxt
            // 
            this.filmidtxt.Location = new System.Drawing.Point(413, 12);
            this.filmidtxt.Name = "filmidtxt";
            this.filmidtxt.Size = new System.Drawing.Size(125, 27);
            this.filmidtxt.TabIndex = 2;
            // 
            // listelebtn
            // 
            this.listelebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listelebtn.Location = new System.Drawing.Point(416, 61);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(122, 41);
            this.listelebtn.TabIndex = 3;
            this.listelebtn.Text = "LİSTELE";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 330);
            this.dataGridView1.TabIndex = 4;
            // 
            // FilmSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.filmidtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmsilbtn);
            this.Name = "FilmSilme";
            this.Text = "FilmSilme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button filmsilbtn;
        private Label label1;
        private TextBox filmidtxt;
        private Button listelebtn;
        private DataGridView dataGridView1;
    }
}