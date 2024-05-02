namespace VeriTabaniFinalProjesi
{
    partial class YönetmenEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YönetmenEkrani));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listelebtn = new System.Windows.Forms.Button();
            this.yonetmensilmebtn = new System.Windows.Forms.Button();
            this.yonetmenguncellebtn = new System.Windows.Forms.Button();
            this.yonetmeneklebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 9;
            // 
            // listelebtn
            // 
            this.listelebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listelebtn.Location = new System.Drawing.Point(448, 79);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(303, 67);
            this.listelebtn.TabIndex = 8;
            this.listelebtn.Text = "LİSTELE";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // yonetmensilmebtn
            // 
            this.yonetmensilmebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yonetmensilmebtn.Location = new System.Drawing.Point(448, 6);
            this.yonetmensilmebtn.Name = "yonetmensilmebtn";
            this.yonetmensilmebtn.Size = new System.Drawing.Size(303, 67);
            this.yonetmensilmebtn.TabIndex = 7;
            this.yonetmensilmebtn.Text = "Yönetmen silme işlemi için tıklayınız";
            this.yonetmensilmebtn.UseVisualStyleBackColor = true;
            this.yonetmensilmebtn.Click += new System.EventHandler(this.yonetmensilmebtn_Click);
            // 
            // yonetmenguncellebtn
            // 
            this.yonetmenguncellebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yonetmenguncellebtn.Location = new System.Drawing.Point(54, 79);
            this.yonetmenguncellebtn.Name = "yonetmenguncellebtn";
            this.yonetmenguncellebtn.Size = new System.Drawing.Size(303, 67);
            this.yonetmenguncellebtn.TabIndex = 6;
            this.yonetmenguncellebtn.Text = "Yönetmen Güncelleme işlemi için tıklayınız";
            this.yonetmenguncellebtn.UseVisualStyleBackColor = true;
            this.yonetmenguncellebtn.Click += new System.EventHandler(this.yonetmenguncellebtn_Click);
            // 
            // yonetmeneklebtn
            // 
            this.yonetmeneklebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yonetmeneklebtn.Location = new System.Drawing.Point(54, 6);
            this.yonetmeneklebtn.Name = "yonetmeneklebtn";
            this.yonetmeneklebtn.Size = new System.Drawing.Size(303, 67);
            this.yonetmeneklebtn.TabIndex = 5;
            this.yonetmeneklebtn.Text = "Yönetmen Ekleme işlemi için tıklayınız";
            this.yonetmeneklebtn.UseVisualStyleBackColor = true;
            this.yonetmeneklebtn.Click += new System.EventHandler(this.yonetmeneklebtn_Click);
            // 
            // YönetmenEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.yonetmensilmebtn);
            this.Controls.Add(this.yonetmenguncellebtn);
            this.Controls.Add(this.yonetmeneklebtn);
            this.Name = "YönetmenEkrani";
            this.Text = "YönetmenEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button listelebtn;
        private Button yonetmensilmebtn;
        private Button yonetmenguncellebtn;
        private Button yonetmeneklebtn;
    }
}