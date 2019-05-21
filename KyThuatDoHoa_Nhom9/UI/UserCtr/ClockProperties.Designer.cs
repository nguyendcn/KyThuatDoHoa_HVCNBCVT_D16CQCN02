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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Hours)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 48);
            this.panel1.TabIndex = 1;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(11, 10);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(39, 13);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "Clock";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 553);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // lbl_TimeCurrent
            // 
            this.lbl_TimeCurrent.AutoSize = true;
            this.lbl_TimeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeCurrent.Location = new System.Drawing.Point(8, 29);
            this.lbl_TimeCurrent.Name = "lbl_TimeCurrent";
            this.lbl_TimeCurrent.Size = new System.Drawing.Size(71, 13);
            this.lbl_TimeCurrent.TabIndex = 9;
            this.lbl_TimeCurrent.Text = "timeCurrent";
            // 
            // btn_GetTimeSystem
            // 
            this.btn_GetTimeSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetTimeSystem.Location = new System.Drawing.Point(116, 24);
            this.btn_GetTimeSystem.Name = "btn_GetTimeSystem";
            this.btn_GetTimeSystem.Size = new System.Drawing.Size(65, 23);
            this.btn_GetTimeSystem.TabIndex = 8;
            this.btn_GetTimeSystem.Text = "Sys Time";
            this.btn_GetTimeSystem.UseVisualStyleBackColor = true;
            this.btn_GetTimeSystem.Click += new System.EventHandler(this.Btn_GetTimeSystem_Click);
            // 
            // btn_ChangeTime
            // 
            this.btn_ChangeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeTime.Location = new System.Drawing.Point(128, 62);
            this.btn_ChangeTime.Name = "btn_ChangeTime";
            this.btn_ChangeTime.Size = new System.Drawing.Size(53, 23);
            this.btn_ChangeTime.TabIndex = 7;
            this.btn_ChangeTime.Text = "Change";
            this.btn_ChangeTime.UseVisualStyleBackColor = true;
            // 
            // numud_Second
            // 
            this.numud_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Second.Location = new System.Drawing.Point(87, 64);
            this.numud_Second.Name = "numud_Second";
            this.numud_Second.Size = new System.Drawing.Size(36, 20);
            this.numud_Second.TabIndex = 6;
            // 
            // numud_Minute
            // 
            this.numud_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Minute.Location = new System.Drawing.Point(45, 64);
            this.numud_Minute.Name = "numud_Minute";
            this.numud_Minute.Size = new System.Drawing.Size(36, 20);
            this.numud_Minute.TabIndex = 5;
            // 
            // numud_Hours
            // 
            this.numud_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Hours.Location = new System.Drawing.Point(6, 64);
            this.numud_Hours.Name = "numud_Hours";
            this.numud_Hours.Size = new System.Drawing.Size(33, 20);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Component";
            // 
            // lbl_hSecondB
            // 
            this.lbl_hSecondB.AutoSize = true;
            this.lbl_hSecondB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hSecondB.Location = new System.Drawing.Point(106, 94);
            this.lbl_hSecondB.Name = "lbl_hSecondB";
            this.lbl_hSecondB.Size = new System.Drawing.Size(41, 13);
            this.lbl_hSecondB.TabIndex = 9;
            this.lbl_hSecondB.Text = "label8";
            // 
            // lbl_hMinuteB
            // 
            this.lbl_hMinuteB.AutoSize = true;
            this.lbl_hMinuteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hMinuteB.Location = new System.Drawing.Point(106, 63);
            this.lbl_hMinuteB.Name = "lbl_hMinuteB";
            this.lbl_hMinuteB.Size = new System.Drawing.Size(41, 13);
            this.lbl_hMinuteB.TabIndex = 8;
            this.lbl_hMinuteB.Text = "label7";
            // 
            // lbl_hHoursB
            // 
            this.lbl_hHoursB.AutoSize = true;
            this.lbl_hHoursB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hHoursB.Location = new System.Drawing.Point(109, 33);
            this.lbl_hHoursB.Name = "lbl_hHoursB";
            this.lbl_hHoursB.Size = new System.Drawing.Size(41, 13);
            this.lbl_hHoursB.TabIndex = 7;
            this.lbl_hHoursB.Text = "label6";
            // 
            // lbl_hSecondA
            // 
            this.lbl_hSecondA.AutoSize = true;
            this.lbl_hSecondA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hSecondA.Location = new System.Drawing.Point(42, 93);
            this.lbl_hSecondA.Name = "lbl_hSecondA";
            this.lbl_hSecondA.Size = new System.Drawing.Size(41, 13);
            this.lbl_hSecondA.TabIndex = 6;
            this.lbl_hSecondA.Text = "label8";
            // 
            // lbl_hMinuteA
            // 
            this.lbl_hMinuteA.AutoSize = true;
            this.lbl_hMinuteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hMinuteA.Location = new System.Drawing.Point(42, 62);
            this.lbl_hMinuteA.Name = "lbl_hMinuteA";
            this.lbl_hMinuteA.Size = new System.Drawing.Size(41, 13);
            this.lbl_hMinuteA.TabIndex = 5;
            this.lbl_hMinuteA.Text = "label7";
            // 
            // lbl_hHoursA
            // 
            this.lbl_hHoursA.AutoSize = true;
            this.lbl_hHoursA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hHoursA.Location = new System.Drawing.Point(45, 32);
            this.lbl_hHoursA.Name = "lbl_hHoursA";
            this.lbl_hHoursA.Size = new System.Drawing.Size(41, 13);
            this.lbl_hHoursA.TabIndex = 4;
            this.lbl_hHoursA.Text = "label6";
            // 
            // Boder
            // 
            this.Boder.AutoSize = true;
            this.Boder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boder.Location = new System.Drawing.Point(12, 126);
            this.Boder.Name = "Boder";
            this.Boder.Size = new System.Drawing.Size(44, 13);
            this.Boder.TabIndex = 3;
            this.Boder.Text = "Border";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "hSecond";
            // 
            // hMinute
            // 
            this.hMinute.AutoSize = true;
            this.hMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hMinute.Location = new System.Drawing.Point(2, 62);
            this.hMinute.Name = "hMinute";
            this.hMinute.Size = new System.Drawing.Size(52, 13);
            this.hMinute.TabIndex = 1;
            this.hMinute.Text = "hMinute";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(2, 32);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(47, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "hHours";
            // 
            // ClockProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClockProperties";
            this.Size = new System.Drawing.Size(194, 601);
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
    }
}
