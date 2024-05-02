namespace VeriTabaniFinalProjesi
{
    partial class YonetmenOyuncularListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenOyuncularListesi));
            this.label2 = new System.Windows.Forms.Label();
            this.yonetmenaditxt = new System.Windows.Forms.TextBox();
            this.goruntulebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(279, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // yonetmenaditxt
            // 
            this.yonetmenaditxt.Location = new System.Drawing.Point(415, 29);
            this.yonetmenaditxt.Name = "yonetmenaditxt";
            this.yonetmenaditxt.Size = new System.Drawing.Size(125, 27);
            this.yonetmenaditxt.TabIndex = 2;
            // 
            // goruntulebtn
            // 
            this.goruntulebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goruntulebtn.Location = new System.Drawing.Point(347, 86);
            this.goruntulebtn.Name = "goruntulebtn";
            this.goruntulebtn.Size = new System.Drawing.Size(138, 40);
            this.goruntulebtn.TabIndex = 3;
            this.goruntulebtn.Text = "GÖRÜNTÜLE";
            this.goruntulebtn.UseVisualStyleBackColor = true;
            this.goruntulebtn.Click += new System.EventHandler(this.goruntulebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(724, 306);
            this.dataGridView1.TabIndex = 4;
            // 
            // YonetmenOyuncularListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goruntulebtn);
            this.Controls.Add(this.yonetmenaditxt);
            this.Controls.Add(this.label2);
            this.Name = "YonetmenOyuncularListesi";
            this.Text = "YonetmenOyuncularListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox yonetmenaditxt;
        private Button goruntulebtn;
        private DataGridView dataGridView1;
    }
}