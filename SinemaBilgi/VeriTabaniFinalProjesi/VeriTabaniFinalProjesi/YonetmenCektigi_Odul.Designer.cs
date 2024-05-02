namespace VeriTabaniFinalProjesi
{
    partial class YonetmenCektigi_Odul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenCektigi_Odul));
            this.label1 = new System.Windows.Forms.Label();
            this.yonetmenidtxt = new System.Windows.Forms.TextBox();
            this.goruntulebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetmenin id :";
            // 
            // yonetmenidtxt
            // 
            this.yonetmenidtxt.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yonetmenidtxt.Location = new System.Drawing.Point(412, 18);
            this.yonetmenidtxt.Name = "yonetmenidtxt";
            this.yonetmenidtxt.Size = new System.Drawing.Size(125, 27);
            this.yonetmenidtxt.TabIndex = 1;
            // 
            // goruntulebtn
            // 
            this.goruntulebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goruntulebtn.Location = new System.Drawing.Point(339, 63);
            this.goruntulebtn.Name = "goruntulebtn";
            this.goruntulebtn.Size = new System.Drawing.Size(138, 40);
            this.goruntulebtn.TabIndex = 2;
            this.goruntulebtn.Text = "GÖRÜNTÜLE";
            this.goruntulebtn.UseVisualStyleBackColor = true;
            this.goruntulebtn.Click += new System.EventHandler(this.goruntulebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(694, 304);
            this.dataGridView1.TabIndex = 3;
            // 
            // YonetmenCektigi_Odul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goruntulebtn);
            this.Controls.Add(this.yonetmenidtxt);
            this.Controls.Add(this.label1);
            this.Name = "YonetmenCektigi_Odul";
            this.Text = "YonetmenCektigi_Odul";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox yonetmenidtxt;
        private Button goruntulebtn;
        private DataGridView dataGridView1;
    }
}