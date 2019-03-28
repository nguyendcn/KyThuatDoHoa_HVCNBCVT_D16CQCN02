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
            this.pnl_ControlBar = new System.Windows.Forms.Panel();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.pnl_MenuBar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_ShowToolBarDialog = new System.Windows.Forms.Panel();
            this.btn_pnl_ShowTB_2D = new System.Windows.Forms.Button();
            this.btn_pnl_ShowTB_3D = new System.Windows.Forms.Button();
            this.btn_ChangeTextMenuBar = new System.Windows.Forms.Button();
            this.btn_Toolbar = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_MaxSize = new System.Windows.Forms.Button();
            this.btn_MiniSize = new System.Windows.Forms.Button();
            this.pnl_ControlBar.SuspendLayout();
            this.pnl_MenuBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_ShowToolBarDialog.SuspendLayout();
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
            // pnl_MenuBar
            // 
            this.pnl_MenuBar.BackColor = System.Drawing.Color.DimGray;
            this.pnl_MenuBar.Controls.Add(this.btn_ChangeTextMenuBar);
            this.pnl_MenuBar.Controls.Add(this.btn_Toolbar);
            this.pnl_MenuBar.Controls.Add(this.btn_Menu);
            this.pnl_MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MenuBar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_MenuBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnl_MenuBar.Location = new System.Drawing.Point(0, 35);
            this.pnl_MenuBar.Name = "pnl_MenuBar";
            this.pnl_MenuBar.Size = new System.Drawing.Size(800, 63);
            this.pnl_MenuBar.TabIndex = 1;
            this.pnl_MenuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_MenuBar_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(600, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 552);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Location = new System.Drawing.Point(0, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 500);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 54);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pnl_ShowToolBarDialog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 552);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnl_ShowToolBarDialog
            // 
            this.pnl_ShowToolBarDialog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_ShowToolBarDialog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_ShowToolBarDialog.Controls.Add(this.btn_pnl_ShowTB_2D);
            this.pnl_ShowToolBarDialog.Controls.Add(this.btn_pnl_ShowTB_3D);
            this.pnl_ShowToolBarDialog.Location = new System.Drawing.Point(0, 0);
            this.pnl_ShowToolBarDialog.Name = "pnl_ShowToolBarDialog";
            this.pnl_ShowToolBarDialog.Size = new System.Drawing.Size(217, 96);
            this.pnl_ShowToolBarDialog.TabIndex = 3;
            this.pnl_ShowToolBarDialog.Visible = false;
            // 
            // btn_pnl_ShowTB_2D
            // 
            this.btn_pnl_ShowTB_2D.BackColor = System.Drawing.Color.Transparent;
            this.btn_pnl_ShowTB_2D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pnl_ShowTB_2D.FlatAppearance.BorderSize = 0;
            this.btn_pnl_ShowTB_2D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_pnl_ShowTB_2D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_pnl_ShowTB_2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pnl_ShowTB_2D.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pnl_ShowTB_2D.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_pnl_ShowTB_2D.Image = global::KyThuatDoHoa_Nhom9.Image_Res._2D_shapes_32px;
            this.btn_pnl_ShowTB_2D.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pnl_ShowTB_2D.Location = new System.Drawing.Point(112, 9);
            this.btn_pnl_ShowTB_2D.Name = "btn_pnl_ShowTB_2D";
            this.btn_pnl_ShowTB_2D.Size = new System.Drawing.Size(88, 58);
            this.btn_pnl_ShowTB_2D.TabIndex = 3;
            this.btn_pnl_ShowTB_2D.Text = "2D shapes";
            this.btn_pnl_ShowTB_2D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pnl_ShowTB_2D.UseVisualStyleBackColor = false;
            this.btn_pnl_ShowTB_2D.Click += new System.EventHandler(this.btn_pnl_ShowTB_2D_Click);
            // 
            // btn_pnl_ShowTB_3D
            // 
            this.btn_pnl_ShowTB_3D.BackColor = System.Drawing.Color.Transparent;
            this.btn_pnl_ShowTB_3D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pnl_ShowTB_3D.FlatAppearance.BorderSize = 0;
            this.btn_pnl_ShowTB_3D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_pnl_ShowTB_3D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_pnl_ShowTB_3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pnl_ShowTB_3D.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pnl_ShowTB_3D.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_pnl_ShowTB_3D.Image = global::KyThuatDoHoa_Nhom9.Image_Res._3D_shapes_32px;
            this.btn_pnl_ShowTB_3D.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pnl_ShowTB_3D.Location = new System.Drawing.Point(13, 9);
            this.btn_pnl_ShowTB_3D.Name = "btn_pnl_ShowTB_3D";
            this.btn_pnl_ShowTB_3D.Size = new System.Drawing.Size(93, 58);
            this.btn_pnl_ShowTB_3D.TabIndex = 2;
            this.btn_pnl_ShowTB_3D.Text = "3D shapes";
            this.btn_pnl_ShowTB_3D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pnl_ShowTB_3D.UseVisualStyleBackColor = false;
            this.btn_pnl_ShowTB_3D.Click += new System.EventHandler(this.btn_pnl_ShowTB_3D_Click);
            // 
            // btn_ChangeTextMenuBar
            // 
            this.btn_ChangeTextMenuBar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChangeTextMenuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ChangeTextMenuBar.FlatAppearance.BorderSize = 0;
            this.btn_ChangeTextMenuBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_ChangeTextMenuBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_ChangeTextMenuBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeTextMenuBar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ChangeTextMenuBar.Image = global::KyThuatDoHoa_Nhom9.Image_Res.Expand_Arrow_32px;
            this.btn_ChangeTextMenuBar.Location = new System.Drawing.Point(751, 10);
            this.btn_ChangeTextMenuBar.Name = "btn_ChangeTextMenuBar";
            this.btn_ChangeTextMenuBar.Size = new System.Drawing.Size(43, 38);
            this.btn_ChangeTextMenuBar.TabIndex = 2;
            this.btn_ChangeTextMenuBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ChangeTextMenuBar.UseVisualStyleBackColor = false;
            this.btn_ChangeTextMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ChangeTextMenuBar_MouseDown);
            // 
            // btn_Toolbar
            // 
            this.btn_Toolbar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Toolbar.BackgroundImage = global::KyThuatDoHoa_Nhom9.Image_Res.Sort_Down_16px;
            this.btn_Toolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Toolbar.FlatAppearance.BorderSize = 0;
            this.btn_Toolbar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Toolbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Toolbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Toolbar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Toolbar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Toolbar.Image = global::KyThuatDoHoa_Nhom9.Image_Res._2D_shapes_32px;
            this.btn_Toolbar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Toolbar.Location = new System.Drawing.Point(88, 2);
            this.btn_Toolbar.Name = "btn_Toolbar";
            this.btn_Toolbar.Size = new System.Drawing.Size(88, 58);
            this.btn_Toolbar.TabIndex = 1;
            this.btn_Toolbar.Text = "2D shapes";
            this.btn_Toolbar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Toolbar.UseVisualStyleBackColor = false;
            this.btn_Toolbar.Click += new System.EventHandler(this.btn_Toolbar_Click);
            this.btn_Toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Toolbar_MouseDown);
            this.btn_Toolbar.MouseLeave += new System.EventHandler(this.btn_Toolbar_MouseLeave);
            this.btn_Toolbar.MouseHover += new System.EventHandler(this.btn_Toolbar_MouseHover);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Menu.Image = global::KyThuatDoHoa_Nhom9.Image_Res.Menu_32px;
            this.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Menu.Location = new System.Drawing.Point(3, 2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(66, 58);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Menu.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.CausesValidation = false;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::KyThuatDoHoa_Nhom9.Image_Res.X_32px;
            this.btn_Exit.Location = new System.Drawing.Point(761, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 30);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_MaxSize
            // 
            this.btn_MaxSize.BackColor = System.Drawing.Color.Transparent;
            this.btn_MaxSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_MaxSize.FlatAppearance.BorderSize = 0;
            this.btn_MaxSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_MaxSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_MaxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaxSize.Image = global::KyThuatDoHoa_Nhom9.Image_Res.Square_32px;
            this.btn_MaxSize.Location = new System.Drawing.Point(724, 3);
            this.btn_MaxSize.Name = "btn_MaxSize";
            this.btn_MaxSize.Size = new System.Drawing.Size(31, 30);
            this.btn_MaxSize.TabIndex = 2;
            this.btn_MaxSize.UseVisualStyleBackColor = false;
            // 
            // btn_MiniSize
            // 
            this.btn_MiniSize.BackColor = System.Drawing.Color.Transparent;
            this.btn_MiniSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_MiniSize.FlatAppearance.BorderSize = 0;
            this.btn_MiniSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_MiniSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_MiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MiniSize.Image = global::KyThuatDoHoa_Nhom9.Image_Res.Subtract_32px;
            this.btn_MiniSize.Location = new System.Drawing.Point(687, 3);
            this.btn_MiniSize.Name = "btn_MiniSize";
            this.btn_MiniSize.Size = new System.Drawing.Size(31, 30);
            this.btn_MiniSize.TabIndex = 1;
            this.btn_MiniSize.UseVisualStyleBackColor = false;
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
            this.pnl_MenuBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_ShowToolBarDialog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ControlBar;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_MaxSize;
        private System.Windows.Forms.Button btn_MiniSize;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Toolbar;
        private System.Windows.Forms.Panel pnl_MenuBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_ShowToolBarDialog;
        private System.Windows.Forms.Button btn_pnl_ShowTB_2D;
        private System.Windows.Forms.Button btn_pnl_ShowTB_3D;
        private System.Windows.Forms.Button btn_ChangeTextMenuBar;
    }
}

