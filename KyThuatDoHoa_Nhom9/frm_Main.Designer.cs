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
            this.btn_ChangeMode = new System.Windows.Forms.Button();
            this.pnl_ToolBox = new System.Windows.Forms.Panel();
            this.pnl_Change = new System.Windows.Forms.Panel();
            this.pnl_WorkStation = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.pnl_Mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Mode
            // 
            this.pnl_Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_Mode.Controls.Add(this.btn_Menu);
            this.pnl_Mode.Controls.Add(this.button2);
            this.pnl_Mode.Controls.Add(this.btn_ChangeMode);
            this.pnl_Mode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Mode.Location = new System.Drawing.Point(0, 0);
            this.pnl_Mode.Name = "pnl_Mode";
            this.pnl_Mode.Size = new System.Drawing.Size(860, 50);
            this.pnl_Mode.TabIndex = 0;
            // 
            // btn_ChangeMode
            // 
            this.btn_ChangeMode.Location = new System.Drawing.Point(116, 12);
            this.btn_ChangeMode.Name = "btn_ChangeMode";
            this.btn_ChangeMode.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangeMode.TabIndex = 0;
            this.btn_ChangeMode.Text = "toolbar";
            this.btn_ChangeMode.UseVisualStyleBackColor = true;
            this.btn_ChangeMode.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_ToolBox
            // 
            this.pnl_ToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_ToolBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ToolBox.Location = new System.Drawing.Point(600, 50);
            this.pnl_ToolBox.Name = "pnl_ToolBox";
            this.pnl_ToolBox.Size = new System.Drawing.Size(260, 600);
            this.pnl_ToolBox.TabIndex = 1;
            // 
            // pnl_Change
            // 
            this.pnl_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_Change.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Change.Location = new System.Drawing.Point(0, 50);
            this.pnl_Change.Name = "pnl_Change";
            this.pnl_Change.Size = new System.Drawing.Size(600, 50);
            this.pnl_Change.TabIndex = 2;
            // 
            // pnl_WorkStation
            // 
            this.pnl_WorkStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_WorkStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_WorkStation.Location = new System.Drawing.Point(0, 100);
            this.pnl_WorkStation.Name = "pnl_WorkStation";
            this.pnl_WorkStation.Size = new System.Drawing.Size(600, 550);
            this.pnl_WorkStation.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.Text = "menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "frm_main";
            this.pnl_Mode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Mode;
        private System.Windows.Forms.Panel pnl_ToolBox;
        private System.Windows.Forms.Panel pnl_Change;
        private System.Windows.Forms.Panel pnl_WorkStation;
        private System.Windows.Forms.Button btn_ChangeMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Menu;
    }
}

