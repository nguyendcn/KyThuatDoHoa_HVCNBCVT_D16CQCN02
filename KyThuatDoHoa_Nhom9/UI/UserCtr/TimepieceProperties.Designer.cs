namespace KyThuatDoHoa_Nhom9.UI.UserCtr
{
    partial class TimepieceProperties
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Destroy = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.btn_ChangeLocation = new System.Windows.Forms.Button();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Hide);
            this.panel1.Controls.Add(this.btn_Destroy);
            this.panel1.Controls.Add(this.Clock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 32);
            this.panel1.TabIndex = 3;
            // 
            // btn_Hide
            // 
            this.btn_Hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hide.Location = new System.Drawing.Point(113, 0);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(33, 32);
            this.btn_Hide.TabIndex = 2;
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Destroy
            // 
            this.btn_Destroy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Destroy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Destroy.Location = new System.Drawing.Point(146, 0);
            this.btn_Destroy.Name = "btn_Destroy";
            this.btn_Destroy.Size = new System.Drawing.Size(29, 32);
            this.btn_Destroy.TabIndex = 1;
            this.btn_Destroy.UseVisualStyleBackColor = true;
            this.btn_Destroy.Click += new System.EventHandler(this.btn_Destroy_Click);
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(11, 10);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(78, 19);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "Timepiece";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 294);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 100);
            this.panel3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_Location);
            this.groupBox1.Controls.Add(this.btn_ChangeLocation);
            this.groupBox1.Controls.Add(this.txt_Location);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location: ";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Location.Location = new System.Drawing.Point(58, 28);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(65, 15);
            this.lbl_Location.TabIndex = 2;
            this.lbl_Location.Text = "{X=0,Y=0}";
            // 
            // btn_ChangeLocation
            // 
            this.btn_ChangeLocation.Location = new System.Drawing.Point(100, 56);
            this.btn_ChangeLocation.Name = "btn_ChangeLocation";
            this.btn_ChangeLocation.Size = new System.Drawing.Size(49, 23);
            this.btn_ChangeLocation.TabIndex = 1;
            this.btn_ChangeLocation.Text = "Change";
            this.btn_ChangeLocation.UseVisualStyleBackColor = true;
            this.btn_ChangeLocation.Click += new System.EventHandler(this.btn_ChangeLocation_Click);
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(23, 58);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(58, 20);
            this.txt_Location.TabIndex = 0;
            // 
            // TimepieceProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TimepieceProperties";
            this.Size = new System.Drawing.Size(175, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChangeLocation;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Button btn_Destroy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Button btn_Hide;
    }
}
