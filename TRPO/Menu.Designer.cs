
namespace TRPO
{
    partial class Menu
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
            this.Anketa = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.Приветсвую = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Anketa
            // 
            this.Anketa.BackColor = System.Drawing.Color.Red;
            this.Anketa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Anketa.Location = new System.Drawing.Point(69, 239);
            this.Anketa.Name = "Anketa";
            this.Anketa.Size = new System.Drawing.Size(209, 122);
            this.Anketa.TabIndex = 0;
            this.Anketa.Text = "Пройти анкетирование";
            this.Anketa.UseVisualStyleBackColor = false;
            this.Anketa.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.MediumBlue;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin.ForeColor = System.Drawing.Color.Red;
            this.Admin.Location = new System.Drawing.Point(450, 239);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(209, 122);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Проверить результаты(админ)";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Приветсвую
            // 
            this.Приветсвую.AutoSize = true;
            this.Приветсвую.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Приветсвую.Location = new System.Drawing.Point(197, 78);
            this.Приветсвую.Name = "Приветсвую";
            this.Приветсвую.Size = new System.Drawing.Size(370, 65);
            this.Приветсвую.TabIndex = 3;
            this.Приветсвую.Text = "Приветствую";
            this.Приветсвую.Click += new System.EventHandler(this.Приветсвую_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Приветсвую);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Anketa);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anketa;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Label Приветсвую;
    }
}