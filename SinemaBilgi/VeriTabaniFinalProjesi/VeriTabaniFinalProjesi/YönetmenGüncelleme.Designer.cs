namespace VeriTabaniFinalProjesi
{
    partial class YönetmenGüncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YönetmenGüncelleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listelebtn = new System.Windows.Forms.Button();
            this.yonetmenguncellebtn = new System.Windows.Forms.Button();
            this.cinsiyettxt = new System.Windows.Forms.TextBox();
            this.dogumtarihitxt = new System.Windows.Forms.TextBox();
            this.gercekaditxt = new System.Windows.Forms.TextBox();
            this.sahneaditxt = new System.Windows.Forms.TextBox();
            this.yonetmenidtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.odulsayisitxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(770, 280);
            this.dataGridView1.TabIndex = 25;
            // 
            // listelebtn
            // 
            this.listelebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listelebtn.Location = new System.Drawing.Point(429, 101);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(138, 51);
            this.listelebtn.TabIndex = 24;
            this.listelebtn.Text = "LİSTELE";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // yonetmenguncellebtn
            // 
            this.yonetmenguncellebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yonetmenguncellebtn.Location = new System.Drawing.Point(256, 99);
            this.yonetmenguncellebtn.Name = "yonetmenguncellebtn";
            this.yonetmenguncellebtn.Size = new System.Drawing.Size(138, 51);
            this.yonetmenguncellebtn.TabIndex = 23;
            this.yonetmenguncellebtn.Text = "GÜNCELLE";
            this.yonetmenguncellebtn.UseVisualStyleBackColor = true;
            this.yonetmenguncellebtn.Click += new System.EventHandler(this.yonetmenguncellebtn_Click);
            // 
            // cinsiyettxt
            // 
            this.cinsiyettxt.Location = new System.Drawing.Point(419, 66);
            this.cinsiyettxt.Name = "cinsiyettxt";
            this.cinsiyettxt.Size = new System.Drawing.Size(125, 27);
            this.cinsiyettxt.TabIndex = 22;
            // 
            // dogumtarihitxt
            // 
            this.dogumtarihitxt.Location = new System.Drawing.Point(134, 66);
            this.dogumtarihitxt.Name = "dogumtarihitxt";
            this.dogumtarihitxt.Size = new System.Drawing.Size(125, 27);
            this.dogumtarihitxt.TabIndex = 21;
            // 
            // gercekaditxt
            // 
            this.gercekaditxt.Location = new System.Drawing.Point(660, 23);
            this.gercekaditxt.Name = "gercekaditxt";
            this.gercekaditxt.Size = new System.Drawing.Size(125, 27);
            this.gercekaditxt.TabIndex = 20;
            // 
            // sahneaditxt
            // 
            this.sahneaditxt.Location = new System.Drawing.Point(419, 23);
            this.sahneaditxt.Name = "sahneaditxt";
            this.sahneaditxt.Size = new System.Drawing.Size(125, 27);
            this.sahneaditxt.TabIndex = 19;
            // 
            // yonetmenidtxt
            // 
            this.yonetmenidtxt.Location = new System.Drawing.Point(134, 23);
            this.yonetmenidtxt.Name = "yonetmenidtxt";
            this.yonetmenidtxt.Size = new System.Drawing.Size(125, 27);
            this.yonetmenidtxt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gerçek Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sahne Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Yönetmen İD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ödül Sayısı:";
            // 
            // odulsayisitxt
            // 
            this.odulsayisitxt.Location = new System.Drawing.Point(660, 67);
            this.odulsayisitxt.Name = "odulsayisitxt";
            this.odulsayisitxt.Size = new System.Drawing.Size(125, 27);
            this.odulsayisitxt.TabIndex = 27;
            // 
            // YönetmenGüncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odulsayisitxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.yonetmenguncellebtn);
            this.Controls.Add(this.cinsiyettxt);
            this.Controls.Add(this.dogumtarihitxt);
            this.Controls.Add(this.gercekaditxt);
            this.Controls.Add(this.sahneaditxt);
            this.Controls.Add(this.yonetmenidtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YönetmenGüncelleme";
            this.Text = "YönetmenGüncelleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button listelebtn;
        private Button yonetmenguncellebtn;
        private TextBox cinsiyettxt;
        private TextBox dogumtarihitxt;
        private TextBox gercekaditxt;
        private TextBox sahneaditxt;
        private TextBox yonetmenidtxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox odulsayisitxt;
    }
}