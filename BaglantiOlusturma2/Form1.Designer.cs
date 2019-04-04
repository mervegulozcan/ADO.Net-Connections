namespace BaglantiOlusturma2
{
    partial class Form1
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
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(87, 48);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(265, 78);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Local Değişken ile Bağlan";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnGlobal
            // 
            this.btnGlobal.Location = new System.Drawing.Point(87, 132);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(265, 78);
            this.btnGlobal.TabIndex = 1;
            this.btnGlobal.Text = "Global Değişken ile Bağlan";
            this.btnGlobal.UseVisualStyleBackColor = true;
            this.btnGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(87, 216);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(265, 78);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Class ile Bağlan";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(87, 300);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(265, 78);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "App Config ile Bağlan";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 426);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnGlobal);
            this.Controls.Add(this.btnLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnGlobal;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnConfig;
    }
}

