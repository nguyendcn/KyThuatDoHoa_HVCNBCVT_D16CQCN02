namespace KyThuatDoHoa_Nhom9.UI
{
    partial class frm_ChangeMode
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
            this.btn_2D = new System.Windows.Forms.Button();
            this.btn_3D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_2D
            // 
            this.btn_2D.Location = new System.Drawing.Point(12, 12);
            this.btn_2D.Name = "btn_2D";
            this.btn_2D.Size = new System.Drawing.Size(75, 23);
            this.btn_2D.TabIndex = 0;
            this.btn_2D.TabStop = false;
            this.btn_2D.Text = "2D";
            this.btn_2D.UseVisualStyleBackColor = true;
            this.btn_2D.Click += new System.EventHandler(this.btn_2D_Click);
            // 
            // btn_3D
            // 
            this.btn_3D.Location = new System.Drawing.Point(126, 12);
            this.btn_3D.Name = "btn_3D";
            this.btn_3D.Size = new System.Drawing.Size(75, 23);
            this.btn_3D.TabIndex = 1;
            this.btn_3D.Text = "3D";
            this.btn_3D.UseVisualStyleBackColor = true;
            this.btn_3D.Click += new System.EventHandler(this.btn_3D_Click);
            // 
            // frm_ChangeMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(338, 148);
            this.Controls.Add(this.btn_3D);
            this.Controls.Add(this.btn_2D);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChangeMode";
            this.Text = "frm_ChangeMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_2D;
        private System.Windows.Forms.Button btn_3D;
    }
}