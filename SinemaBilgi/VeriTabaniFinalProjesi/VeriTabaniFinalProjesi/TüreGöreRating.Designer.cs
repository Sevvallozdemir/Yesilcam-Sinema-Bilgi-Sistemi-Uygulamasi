namespace VeriTabaniFinalProjesi
{
    partial class TüreGöreRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TüreGöreRating));
            this.label1 = new System.Windows.Forms.Label();
            this.goruntulebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmturutxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Türü:";
            // 
            // goruntulebtn
            // 
            this.goruntulebtn.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goruntulebtn.Location = new System.Drawing.Point(343, 72);
            this.goruntulebtn.Name = "goruntulebtn";
            this.goruntulebtn.Size = new System.Drawing.Size(135, 49);
            this.goruntulebtn.TabIndex = 2;
            this.goruntulebtn.Text = "GÖRÜNTÜLE";
            this.goruntulebtn.UseVisualStyleBackColor = true;
            this.goruntulebtn.Click += new System.EventHandler(this.goruntulebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 311);
            this.dataGridView1.TabIndex = 3;
            // 
            // filmturutxt
            // 
            this.filmturutxt.Location = new System.Drawing.Point(384, 24);
            this.filmturutxt.Name = "filmturutxt";
            this.filmturutxt.Size = new System.Drawing.Size(125, 27);
            this.filmturutxt.TabIndex = 5;
            // 
            // TüreGöreRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filmturutxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goruntulebtn);
            this.Controls.Add(this.label1);
            this.Name = "TüreGöreRating";
            this.Text = "TüreGöreRating";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button goruntulebtn;
        private DataGridView dataGridView1;
        private TextBox filmturutxt;
    }
}