namespace choices
{
    partial class frmSpider
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
            btnCrawl = new Button();
            txtTiebaName = new TextBox();
            progressBar1 = new ProgressBar();
            numPages = new NumericUpDown();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCrawl
            // 
            btnCrawl.Location = new Point(472, 20);
            btnCrawl.Name = "btnCrawl";
            btnCrawl.Size = new Size(112, 34);
            btnCrawl.TabIndex = 0;
            btnCrawl.Text = "button1";
            btnCrawl.UseVisualStyleBackColor = true;
            // 
            // txtTiebaName
            // 
            txtTiebaName.Location = new Point(114, 29);
            txtTiebaName.Name = "txtTiebaName";
            txtTiebaName.Size = new Size(150, 30);
            txtTiebaName.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(115, 87);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(150, 34);
            progressBar1.TabIndex = 2;
            // 
            // numPages
            // 
            numPages.Location = new Point(439, 90);
            numPages.Name = "numPages";
            numPages.Size = new Size(180, 30);
            numPages.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 4;
            // 
            // frmSpider
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(numPages);
            Controls.Add(progressBar1);
            Controls.Add(txtTiebaName);
            Controls.Add(btnCrawl);
            Name = "frmSpider";
            Text = "frmSpider";
            ((System.ComponentModel.ISupportInitialize)numPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrawl;
        private TextBox txtTiebaName;
        private ProgressBar progressBar1;
        private NumericUpDown numPages;
        private DataGridView dataGridView1;
    }
}