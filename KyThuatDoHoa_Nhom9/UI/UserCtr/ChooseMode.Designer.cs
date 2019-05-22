namespace KyThuatDoHoa_Nhom9.UI.UserCtr
{
    partial class ChooseMode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_3D = new System.Windows.Forms.Button();
            this.btn_2D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_3D
            // 
            this.btn_3D.FlatAppearance.BorderSize = 0;
            this.btn_3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3D.ForeColor = System.Drawing.Color.White;
            this.btn_3D.Image = global::KyThuatDoHoa_Nhom9.Image_Res._3D_Model_25px;
            this.btn_3D.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_3D.Location = new System.Drawing.Point(131, 14);
            this.btn_3D.Name = "btn_3D";
            this.btn_3D.Size = new System.Drawing.Size(87, 63);
            this.btn_3D.TabIndex = 3;
            this.btn_3D.Text = "3D shapes";
            this.btn_3D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_3D.UseVisualStyleBackColor = true;
            this.btn_3D.Click += new System.EventHandler(this.btn_3D_Click);
            // 
            // btn_2D
            // 
            this.btn_2D.FlatAppearance.BorderSize = 0;
            this.btn_2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2D.ForeColor = System.Drawing.Color.White;
            this.btn_2D.Image = global::KyThuatDoHoa_Nhom9.Image_Res._2D_Model_25px;
            this.btn_2D.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_2D.Location = new System.Drawing.Point(16, 14);
            this.btn_2D.Name = "btn_2D";
            this.btn_2D.Size = new System.Drawing.Size(87, 63);
            this.btn_2D.TabIndex = 2;
            this.btn_2D.TabStop = false;
            this.btn_2D.Text = "2D shapes";
            this.btn_2D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_2D.UseVisualStyleBackColor = true;
            this.btn_2D.Click += new System.EventHandler(this.btn_2D_Click);
            // 
            // ChooseMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btn_3D);
            this.Controls.Add(this.btn_2D);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChooseMode";
            this.Size = new System.Drawing.Size(307, 133);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_3D;
        private System.Windows.Forms.Button btn_2D;
    }
}
