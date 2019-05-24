namespace KyThuatDoHoa_Nhom9.UI.UserCtr
{
    partial class ClockProperties
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TimeCurrent = new System.Windows.Forms.Label();
            this.btn_GetTimeSystem = new System.Windows.Forms.Button();
            this.btn_ChangeTime = new System.Windows.Forms.Button();
            this.numud_Second = new System.Windows.Forms.NumericUpDown();
            this.numud_Minute = new System.Windows.Forms.NumericUpDown();
            this.numud_Hours = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_hSecondB = new System.Windows.Forms.Label();
            this.lbl_hMinuteB = new System.Windows.Forms.Label();
            this.lbl_hHoursB = new System.Windows.Forms.Label();
            this.lbl_hSecondA = new System.Windows.Forms.Label();
            this.lbl_hMinuteA = new System.Windows.Forms.Label();
            this.lbl_hHoursA = new System.Windows.Forms.Label();
            this.Boder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hMinute = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Hours)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btn_Hide);
            this.panel1.Controls.Add(this.btn_Destroy);
            this.panel1.Controls.Add(this.Clock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 30);
            this.panel1.TabIndex = 1;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackgroundImage = global::KyThuatDoHoa_Nhom9.Image_Res.Hide_32px;
            this.btn_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hide.Location = new System.Drawing.Point(113, 0);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(33, 30);
            this.btn_Hide.TabIndex = 4;
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Destroy
            // 
            this.btn_Destroy.BackgroundImage = global::KyThuatDoHoa_Nhom9.Image_Res.Dispose_32px;
            this.btn_Destroy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Destroy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Destroy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Destroy.Location = new System.Drawing.Point(146, 0);
            this.btn_Destroy.Name = "btn_Destroy";
            this.btn_Destroy.Size = new System.Drawing.Size(29, 30);
            this.btn_Destroy.TabIndex = 3;
            this.btn_Destroy.UseVisualStyleBackColor = true;
            this.btn_Destroy.Click += new System.EventHandler(this.btn_Destroy_Click);
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(10, 8);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(47, 16);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "Clock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 571);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TimeCurrent);
            this.groupBox1.Controls.Add(this.btn_GetTimeSystem);
            this.groupBox1.Controls.Add(this.btn_ChangeTime);
            this.groupBox1.Controls.Add(this.numud_Second);
            this.groupBox1.Controls.Add(this.numud_Minute);
            this.groupBox1.Controls.Add(this.numud_Hours);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // lbl_TimeCurrent
            // 
            this.lbl_TimeCurrent.AutoSize = true;
            this.lbl_TimeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeCurrent.Location = new System.Drawing.Point(1, 33);
            this.lbl_TimeCurrent.Name = "lbl_TimeCurrent";
            this.lbl_TimeCurrent.Size = new System.Drawing.Size(86, 16);
            this.lbl_TimeCurrent.TabIndex = 9;
            this.lbl_TimeCurrent.Text = "timeCurrent";
            // 
            // btn_GetTimeSystem
            // 
            this.btn_GetTimeSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetTimeSystem.Location = new System.Drawing.Point(99, 29);
            this.btn_GetTimeSystem.Name = "btn_GetTimeSystem";
            this.btn_GetTimeSystem.Size = new System.Drawing.Size(60, 23);
            this.btn_GetTimeSystem.TabIndex = 8;
            this.btn_GetTimeSystem.Text = "Sys Time";
            this.btn_GetTimeSystem.UseVisualStyleBackColor = true;
            this.btn_GetTimeSystem.Click += new System.EventHandler(this.Btn_GetTimeSystem_Click);
            // 
            // btn_ChangeTime
            // 
            this.btn_ChangeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeTime.Location = new System.Drawing.Point(104, 65);
            this.btn_ChangeTime.Name = "btn_ChangeTime";
            this.btn_ChangeTime.Size = new System.Drawing.Size(59, 23);
            this.btn_ChangeTime.TabIndex = 7;
            this.btn_ChangeTime.Text = "Change";
            this.btn_ChangeTime.UseVisualStyleBackColor = true;
            this.btn_ChangeTime.Click += new System.EventHandler(this.btn_ChangeTime_Click);
            // 
            // numud_Second
            // 
            this.numud_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Second.Location = new System.Drawing.Point(71, 68);
            this.numud_Second.Name = "numud_Second";
            this.numud_Second.Size = new System.Drawing.Size(28, 22);
            this.numud_Second.TabIndex = 6;
            // 
            // numud_Minute
            // 
            this.numud_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Minute.Location = new System.Drawing.Point(35, 68);
            this.numud_Minute.Name = "numud_Minute";
            this.numud_Minute.Size = new System.Drawing.Size(28, 22);
            this.numud_Minute.TabIndex = 5;
            // 
            // numud_Hours
            // 
            this.numud_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Hours.Location = new System.Drawing.Point(4, 68);
            this.numud_Hours.Name = "numud_Hours";
            this.numud_Hours.Size = new System.Drawing.Size(25, 22);
            this.numud_Hours.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_hSecondB);
            this.groupBox2.Controls.Add(this.lbl_hMinuteB);
            this.groupBox2.Controls.Add(this.lbl_hHoursB);
            this.groupBox2.Controls.Add(this.lbl_hSecondA);
            this.groupBox2.Controls.Add(this.lbl_hMinuteA);
            this.groupBox2.Controls.Add(this.lbl_hHoursA);
            this.groupBox2.Controls.Add(this.Boder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hMinute);
            this.groupBox2.Controls.Add(this.lbl_1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Component";
            // 
            // lbl_hSecondB
            // 
            this.lbl_hSecondB.AutoSize = true;
            this.lbl_hSecondB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hSecondB.Location = new System.Drawing.Point(105, 94);
            this.lbl_hSecondB.Name = "lbl_hSecondB";
            this.lbl_hSecondB.Size = new System.Drawing.Size(38, 15);
            this.lbl_hSecondB.TabIndex = 9;
            this.lbl_hSecondB.Text = "label8";
            // 
            // lbl_hMinuteB
            // 
            this.lbl_hMinuteB.AutoSize = true;
            this.lbl_hMinuteB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hMinuteB.Location = new System.Drawing.Point(105, 63);
            this.lbl_hMinuteB.Name = "lbl_hMinuteB";
            this.lbl_hMinuteB.Size = new System.Drawing.Size(38, 15);
            this.lbl_hMinuteB.TabIndex = 8;
            this.lbl_hMinuteB.Text = "label7";
            // 
            // lbl_hHoursB
            // 
            this.lbl_hHoursB.AutoSize = true;
            this.lbl_hHoursB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hHoursB.Location = new System.Drawing.Point(106, 33);
            this.lbl_hHoursB.Name = "lbl_hHoursB";
            this.lbl_hHoursB.Size = new System.Drawing.Size(38, 15);
            this.lbl_hHoursB.TabIndex = 7;
            this.lbl_hHoursB.Text = "label6";
            // 
            // lbl_hSecondA
            // 
            this.lbl_hSecondA.AutoSize = true;
            this.lbl_hSecondA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hSecondA.Location = new System.Drawing.Point(46, 93);
            this.lbl_hSecondA.Name = "lbl_hSecondA";
            this.lbl_hSecondA.Size = new System.Drawing.Size(38, 15);
            this.lbl_hSecondA.TabIndex = 6;
            this.lbl_hSecondA.Text = "label8";
            // 
            // lbl_hMinuteA
            // 
            this.lbl_hMinuteA.AutoSize = true;
            this.lbl_hMinuteA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hMinuteA.Location = new System.Drawing.Point(46, 62);
            this.lbl_hMinuteA.Name = "lbl_hMinuteA";
            this.lbl_hMinuteA.Size = new System.Drawing.Size(38, 15);
            this.lbl_hMinuteA.TabIndex = 5;
            this.lbl_hMinuteA.Text = "label7";
            // 
            // lbl_hHoursA
            // 
            this.lbl_hHoursA.AutoSize = true;
            this.lbl_hHoursA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hHoursA.Location = new System.Drawing.Point(45, 32);
            this.lbl_hHoursA.Name = "lbl_hHoursA";
            this.lbl_hHoursA.Size = new System.Drawing.Size(38, 15);
            this.lbl_hHoursA.TabIndex = 4;
            this.lbl_hHoursA.Text = "label6";
            // 
            // Boder
            // 
            this.Boder.AutoSize = true;
            this.Boder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boder.Location = new System.Drawing.Point(3, 128);
            this.Boder.Name = "Boder";
            this.Boder.Size = new System.Drawing.Size(49, 16);
            this.Boder.TabIndex = 3;
            this.Boder.Text = "Border";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "hSecond";
            // 
            // hMinute
            // 
            this.hMinute.AutoSize = true;
            this.hMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hMinute.Location = new System.Drawing.Point(2, 62);
            this.hMinute.Name = "hMinute";
            this.hMinute.Size = new System.Drawing.Size(61, 16);
            this.hMinute.TabIndex = 1;
            this.hMinute.Text = "hMinute";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(2, 32);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(57, 16);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "hHours";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KyThuatDoHoa_Nhom9.Properties.Resources.gnome_window_close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(153, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KyThuatDoHoa_Nhom9.Properties.Resources.history;
            this.pictureBox1.Location = new System.Drawing.Point(51, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ClockProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClockProperties";
            this.Size = new System.Drawing.Size(175, 601);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Hours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TimeCurrent;
        private System.Windows.Forms.Button btn_GetTimeSystem;
        private System.Windows.Forms.Button btn_ChangeTime;
        private System.Windows.Forms.NumericUpDown numud_Second;
        private System.Windows.Forms.NumericUpDown numud_Minute;
        private System.Windows.Forms.NumericUpDown numud_Hours;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_hSecondB;
        private System.Windows.Forms.Label lbl_hMinuteB;
        private System.Windows.Forms.Label lbl_hHoursB;
        private System.Windows.Forms.Label lbl_hSecondA;
        private System.Windows.Forms.Label lbl_hMinuteA;
        private System.Windows.Forms.Label lbl_hHoursA;
        private System.Windows.Forms.Label Boder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hMinute;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_Destroy;
    }
}
