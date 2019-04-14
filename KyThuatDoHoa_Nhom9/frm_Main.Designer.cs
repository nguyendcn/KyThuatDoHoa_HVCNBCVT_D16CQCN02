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
            this.pnl_Mode = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_ShowDetails_btn = new System.Windows.Forms.Button();
            this.btn_Toolbar = new System.Windows.Forms.Button();
            this.pnl_ToolBox = new System.Windows.Forms.Panel();
            this.pnl_Tb_2D = new System.Windows.Forms.Panel();
            this.pnl_Tb_3D = new System.Windows.Forms.Panel();
            this.pnl_Change = new System.Windows.Forms.Panel();
            this.pnl_WorkStation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Mode.SuspendLayout();
            this.pnl_ToolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Mode
            // 
            this.pnl_Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_Mode.Controls.Add(this.panel1);
            this.pnl_Mode.Controls.Add(this.btn_Menu);
            this.pnl_Mode.Controls.Add(this.btn_Toolbar);
            this.pnl_Mode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Mode.Location = new System.Drawing.Point(0, 0);
            this.pnl_Mode.Name = "pnl_Mode";
            this.pnl_Mode.Size = new System.Drawing.Size(860, 49);
            this.pnl_Mode.TabIndex = 0;
            // 
            // btn_Menu
            // 
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Image = global::KyThuatDoHoa_Nhom9.Image_Res.List_25px;
            this.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Menu.Location = new System.Drawing.Point(10, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(85, 50);
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Menu.UseVisualStyleBackColor = true;
            // 
            // btn_ShowDetails_btn
            // 
            this.btn_ShowDetails_btn.FlatAppearance.BorderSize = 0;
            this.btn_ShowDetails_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowDetails_btn.Image = global::KyThuatDoHoa_Nhom9.Image_Res.Expand_Arrow_25px;
            this.btn_ShowDetails_btn.Location = new System.Drawing.Point(3, 0);
            this.btn_ShowDetails_btn.Name = "btn_ShowDetails_btn";
            this.btn_ShowDetails_btn.Size = new System.Drawing.Size(40, 50);
            this.btn_ShowDetails_btn.TabIndex = 1;
            this.btn_ShowDetails_btn.UseVisualStyleBackColor = true;
            this.btn_ShowDetails_btn.Click += new System.EventHandler(this.btn_ShowDetails_btn_Click);
            // 
            // btn_Toolbar
            // 
            this.btn_Toolbar.FlatAppearance.BorderSize = 0;
            this.btn_Toolbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Toolbar.ForeColor = System.Drawing.Color.White;
            this.btn_Toolbar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Toolbar.Location = new System.Drawing.Point(117, 0);
            this.btn_Toolbar.Name = "btn_Toolbar";
            this.btn_Toolbar.Size = new System.Drawing.Size(85, 50);
            this.btn_Toolbar.TabIndex = 0;
            this.btn_Toolbar.Text = "toolbar";
            this.btn_Toolbar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Toolbar.UseVisualStyleBackColor = true;
            this.btn_Toolbar.Click += new System.EventHandler(this.btn_Toolbar_Click);
            // 
            // pnl_ToolBox
            // 
            this.pnl_ToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl_ToolBox.Controls.Add(this.pnl_Tb_2D);
            this.pnl_ToolBox.Controls.Add(this.pnl_Tb_3D);
            this.pnl_ToolBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ToolBox.Location = new System.Drawing.Point(600, 49);
            this.pnl_ToolBox.Name = "pnl_ToolBox";
            this.pnl_ToolBox.Size = new System.Drawing.Size(260, 601);
            this.pnl_ToolBox.TabIndex = 1;
            // 
            // pnl_Tb_2D
            // 
            this.pnl_Tb_2D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.pnl_Tb_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tb_2D.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tb_2D.Name = "pnl_Tb_2D";
            this.pnl_Tb_2D.Size = new System.Drawing.Size(260, 601);
            this.pnl_Tb_2D.TabIndex = 0;
            // 
            // pnl_Tb_3D
            // 
            this.pnl_Tb_3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.pnl_Tb_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tb_3D.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tb_3D.Name = "pnl_Tb_3D";
            this.pnl_Tb_3D.Size = new System.Drawing.Size(260, 601);
            this.pnl_Tb_3D.TabIndex = 1;
            // 
            // pnl_Change
            // 
            this.pnl_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_Change.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Change.Location = new System.Drawing.Point(0, 49);
            this.pnl_Change.Name = "pnl_Change";
            this.pnl_Change.Size = new System.Drawing.Size(600, 49);
            this.pnl_Change.TabIndex = 2;
            // 
            // pnl_WorkStation
            // 
            this.pnl_WorkStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_WorkStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_WorkStation.Location = new System.Drawing.Point(0, 98);
            this.pnl_WorkStation.Name = "pnl_WorkStation";
            this.pnl_WorkStation.Size = new System.Drawing.Size(600, 552);
            this.pnl_WorkStation.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ShowDetails_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(807, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 49);
            this.panel1.TabIndex = 3;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 650);
            this.Controls.Add(this.pnl_WorkStation);
            this.Controls.Add(this.pnl_Change);
            this.Controls.Add(this.pnl_ToolBox);
            this.Controls.Add(this.pnl_Mode);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Main";
            this.Text = "frm_main";
            this.pnl_Mode.ResumeLayout(false);
            this.pnl_ToolBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Mode;
        private System.Windows.Forms.Panel pnl_ToolBox;
        private System.Windows.Forms.Panel pnl_Change;
        private System.Windows.Forms.Panel pnl_WorkStation;
        private System.Windows.Forms.Button btn_Toolbar;
        private System.Windows.Forms.Button btn_ShowDetails_btn;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel pnl_Tb_2D;
        private System.Windows.Forms.Panel pnl_Tb_3D;
        private System.Windows.Forms.Panel panel1;
    }
}

