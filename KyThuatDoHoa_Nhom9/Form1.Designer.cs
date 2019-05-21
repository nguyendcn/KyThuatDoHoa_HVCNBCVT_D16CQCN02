namespace KyThuatDoHoa_Nhom9
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
            this.picb3D = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb3D)).BeginInit();
            this.SuspendLayout();
            // 
            // picb3D
            // 
            this.picb3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb3D.Location = new System.Drawing.Point(0, 0);
            this.picb3D.Name = "picb3D";
            this.picb3D.Size = new System.Drawing.Size(800, 450);
            this.picb3D.TabIndex = 0;
            this.picb3D.TabStop = false;
            this.picb3D.Paint += new System.Windows.Forms.PaintEventHandler(this.Picb3D_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picb3D);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picb3D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb3D;
    }
}