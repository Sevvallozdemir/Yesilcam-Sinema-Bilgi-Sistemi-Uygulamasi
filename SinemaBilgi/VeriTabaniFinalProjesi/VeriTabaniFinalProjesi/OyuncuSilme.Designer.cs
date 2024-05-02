namespace VeriTabaniFinalProjesi
{
    partial class OyuncuSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuSilme));
            this.label1 = new System.Windows.Forms.Label();
            this.oyuncuidtxt = new System.Windows.Forms.TextBox();
            this.oyuncusilbtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sillmek istediğiniz oyuncunun id\'sini giriniz:";
            // 
            // oyuncuidtxt
            // 
            this.oyuncuidtxt.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oyuncuidtxt.Location = new System.Drawing.Point(428, 13);
            this.oyuncuidtxt.Name = "oyuncuidtxt";
            this.oyuncuidtxt.Size = new System.Drawing.Size(125, 27);
            this.oyuncuidtxt.TabIndex = 1;
            // 
            // oyuncusilbtn
            // 
            this.oyuncusilbtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oyuncusilbtn.Location = new System.Drawing.Point(251, 58);
            this.oyuncusilbtn.Name = "oyuncusilbtn";
            this.oyuncusilbtn.Size = new System.Drawing.Size(122, 41);
            this.oyuncusilbtn.TabIndex = 2;
            this.oyuncusilbtn.Text = "SİL";
            this.oyuncusilbtn.UseVisualStyleBackColor = true;
            this.oyuncusilbtn.Click += new System.EventHandler(this.oyuncusilbtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listelebtn.Location = new System.Drawing.Point(431, 58);
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 310);
            this.dataGridView1.TabIndex = 4;
            // 
            // OyuncuSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.oyuncusilbtn);
            this.Controls.Add(this.oyuncuidtxt);
            this.Controls.Add(this.label1);
            this.Name = "OyuncuSilme";
            this.Text = "OyuncuSilme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox oyuncuidtxt;
        private Button oyuncusilbtn;
        private Button listelebtn;
        private DataGridView dataGridView1;
    }
}