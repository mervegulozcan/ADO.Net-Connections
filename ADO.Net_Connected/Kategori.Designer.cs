namespace ADO.Net_Connected
{
    partial class KategoriForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnurunGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(545, 316);
            this.listBox1.TabIndex = 0;
            // 
            // btnurunGoster
            // 
            this.btnurunGoster.Location = new System.Drawing.Point(184, 13);
            this.btnurunGoster.Name = "btnurunGoster";
            this.btnurunGoster.Size = new System.Drawing.Size(168, 23);
            this.btnurunGoster.TabIndex = 1;
            this.btnurunGoster.Text = "Ürünleri Göster";
            this.btnurunGoster.UseVisualStyleBackColor = true;
            this.btnurunGoster.Click += new System.EventHandler(this.btnurunGoster_Click);
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 384);
            this.Controls.Add(this.btnurunGoster);
            this.Controls.Add(this.listBox1);
            this.Name = "KategoriForm";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnurunGoster;
    }
}