namespace KyThuatDoHoa_Nhom9
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.pnl_ControlBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.btn_MiniSize = new System.Windows.Forms.Button();
            this.btn_MaxSize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_MenuBar = new System.Windows.Forms.Panel();
            this.pnl_ControlBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ControlBar
            // 
            this.pnl_ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_ControlBar.Controls.Add(this.btn_Exit);
            this.pnl_ControlBar.Controls.Add(this.btn_MaxSize);
            this.pnl_ControlBar.Controls.Add(this.btn_MiniSize);
            this.pnl_ControlBar.Controls.Add(this.lbl_FileName);
            this.pnl_ControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ControlBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnl_ControlBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_ControlBar.Name = "pnl_ControlBar";
            this.pnl_ControlBar.Size = new System.Drawing.Size(800, 35);
            this.pnl_ControlBar.TabIndex = 0;
            this.pnl_ControlBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_ControlBar_Paint);
            this.pnl_ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_ControlBar_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 552);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 498);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 54);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(600, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 552);
            this.panel4.TabIndex = 0;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FileName.Location = new System.Drawing.Point(12, 9);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(74, 19);
            this.lbl_FileName.TabIndex = 0;
            this.lbl_FileName.Text = "Name file";
            // 
            // btn_MiniSize
            // 
            this.btn_MiniSize.BackColor = System.Drawing.Color.Transparent;
            this.btn_MiniSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MiniSize.BackgroundImage")));
            this.btn_MiniSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_MiniSize.FlatAppearance.BorderSize = 0;
            this.btn_MiniSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_MiniSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_MiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MiniSize.Location = new System.Drawing.Point(687, 3);
            this.btn_MiniSize.Name = "btn_MiniSize";
            this.btn_MiniSize.Size = new System.Drawing.Size(31, 30);
            this.btn_MiniSize.TabIndex = 1;
            this.btn_MiniSize.UseVisualStyleBackColor = false;
            // 
            // btn_MaxSize
            // 
            this.btn_MaxSize.BackColor = System.Drawing.Color.Transparent;
            this.btn_MaxSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MaxSize.BackgroundImage")));
            this.btn_MaxSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_MaxSize.FlatAppearance.BorderSize = 0;
            this.btn_MaxSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_MaxSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_MaxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaxSize.Location = new System.Drawing.Point(724, 3);
            this.btn_MaxSize.Name = "btn_MaxSize";
            this.btn_MaxSize.Size = new System.Drawing.Size(31, 30);
            this.btn_MaxSize.TabIndex = 2;
            this.btn_MaxSize.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.CausesValidation = false;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(761, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 30);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnl_MenuBar
            // 
            this.pnl_MenuBar.BackColor = System.Drawing.Color.DimGray;
            this.pnl_MenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_MenuBar.Controls.Add(this.button1);
            this.pnl_MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MenuBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnl_MenuBar.Location = new System.Drawing.Point(0, 35);
            this.pnl_MenuBar.Name = "pnl_MenuBar";
            this.pnl_MenuBar.Size = new System.Drawing.Size(800, 63);
            this.pnl_MenuBar.TabIndex = 1;
            this.pnl_MenuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_MenuBar_Paint);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_MenuBar);
            this.Controls.Add(this.pnl_ControlBar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "frm_main";
            this.pnl_ControlBar.ResumeLayout(false);
            this.pnl_ControlBar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnl_MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ControlBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_MaxSize;
        private System.Windows.Forms.Button btn_MiniSize;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_MenuBar;
    }
}

