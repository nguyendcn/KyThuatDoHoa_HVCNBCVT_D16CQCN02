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
            this.Clock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TimeCurrent = new System.Windows.Forms.Label();
            this.btn_GetTimeSystem = new System.Windows.Forms.Button();
            this.btn_ChangeTime = new System.Windows.Forms.Button();
            this.numud_Second = new System.Windows.Forms.NumericUpDown();
            this.numud_Minute = new System.Windows.Forms.NumericUpDown();
            this.numud_Hours = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 48);
            this.panel1.TabIndex = 3;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(11, 10);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(34, 13);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "Clock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TimeCurrent);
            this.groupBox1.Controls.Add(this.btn_GetTimeSystem);
            this.groupBox1.Controls.Add(this.btn_ChangeTime);
            this.groupBox1.Controls.Add(this.numud_Second);
            this.groupBox1.Controls.Add(this.numud_Minute);
            this.groupBox1.Controls.Add(this.numud_Hours);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // lbl_TimeCurrent
            // 
            this.lbl_TimeCurrent.AutoSize = true;
            this.lbl_TimeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeCurrent.Location = new System.Drawing.Point(5, 33);
            this.lbl_TimeCurrent.Name = "lbl_TimeCurrent";
            this.lbl_TimeCurrent.Size = new System.Drawing.Size(60, 13);
            this.lbl_TimeCurrent.TabIndex = 9;
            this.lbl_TimeCurrent.Text = "timeCurrent";
            // 
            // btn_GetTimeSystem
            // 
            this.btn_GetTimeSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetTimeSystem.Location = new System.Drawing.Point(96, 25);
            this.btn_GetTimeSystem.Name = "btn_GetTimeSystem";
            this.btn_GetTimeSystem.Size = new System.Drawing.Size(68, 23);
            this.btn_GetTimeSystem.TabIndex = 8;
            this.btn_GetTimeSystem.Text = "Sys Time";
            this.btn_GetTimeSystem.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeTime
            // 
            this.btn_ChangeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeTime.Location = new System.Drawing.Point(104, 67);
            this.btn_ChangeTime.Name = "btn_ChangeTime";
            this.btn_ChangeTime.Size = new System.Drawing.Size(59, 23);
            this.btn_ChangeTime.TabIndex = 7;
            this.btn_ChangeTime.Text = "Change";
            this.btn_ChangeTime.UseVisualStyleBackColor = true;
            // 
            // numud_Second
            // 
            this.numud_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Second.Location = new System.Drawing.Point(71, 68);
            this.numud_Second.Name = "numud_Second";
            this.numud_Second.Size = new System.Drawing.Size(28, 20);
            this.numud_Second.TabIndex = 6;
            // 
            // numud_Minute
            // 
            this.numud_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Minute.Location = new System.Drawing.Point(35, 68);
            this.numud_Minute.Name = "numud_Minute";
            this.numud_Minute.Size = new System.Drawing.Size(28, 20);
            this.numud_Minute.TabIndex = 5;
            // 
            // numud_Hours
            // 
            this.numud_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numud_Hours.Location = new System.Drawing.Point(4, 68);
            this.numud_Hours.Name = "numud_Hours";
            this.numud_Hours.Size = new System.Drawing.Size(25, 20);
            this.numud_Hours.TabIndex = 4;
            // 
            // TimepieceProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimepieceProperties";
            this.Size = new System.Drawing.Size(197, 550);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TimeCurrent;
        private System.Windows.Forms.Button btn_GetTimeSystem;
        private System.Windows.Forms.Button btn_ChangeTime;
        private System.Windows.Forms.NumericUpDown numud_Second;
        private System.Windows.Forms.NumericUpDown numud_Minute;
        private System.Windows.Forms.NumericUpDown numud_Hours;
    }
}
