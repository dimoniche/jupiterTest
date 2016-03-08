namespace Jupiter.Controls
{
    partial class DeviceControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishArchivedateTime = new System.Windows.Forms.DateTimePicker();
            this.StartArchivedateTime = new System.Windows.Forms.DateTimePicker();
            this.radioButtonHour = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.TypeArchive = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TypeArchive.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FinishArchivedateTime);
            this.groupBox1.Controls.Add(this.StartArchivedateTime);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Даты архива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Начало";
            // 
            // FinishArchivedateTime
            // 
            this.FinishArchivedateTime.Location = new System.Drawing.Point(79, 55);
            this.FinishArchivedateTime.Name = "FinishArchivedateTime";
            this.FinishArchivedateTime.Size = new System.Drawing.Size(200, 20);
            this.FinishArchivedateTime.TabIndex = 4;
            // 
            // StartArchivedateTime
            // 
            this.StartArchivedateTime.Location = new System.Drawing.Point(79, 19);
            this.StartArchivedateTime.Name = "StartArchivedateTime";
            this.StartArchivedateTime.Size = new System.Drawing.Size(200, 20);
            this.StartArchivedateTime.TabIndex = 3;
            // 
            // radioButtonHour
            // 
            this.radioButtonHour.AutoSize = true;
            this.radioButtonHour.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHour.Name = "radioButtonHour";
            this.radioButtonHour.Size = new System.Drawing.Size(101, 17);
            this.radioButtonHour.TabIndex = 4;
            this.radioButtonHour.TabStop = true;
            this.radioButtonHour.Text = "Часовой архив";
            this.radioButtonHour.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(6, 42);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(105, 17);
            this.radioButtonDay.TabIndex = 4;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Суточный архив";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // TypeArchive
            // 
            this.TypeArchive.Controls.Add(this.radioButtonHour);
            this.TypeArchive.Controls.Add(this.radioButtonDay);
            this.TypeArchive.Location = new System.Drawing.Point(318, 16);
            this.TypeArchive.Name = "TypeArchive";
            this.TypeArchive.Size = new System.Drawing.Size(139, 94);
            this.TypeArchive.TabIndex = 5;
            this.TypeArchive.TabStop = false;
            this.TypeArchive.Text = "Тип архива";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запросить архив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeviceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TypeArchive);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviceControl";
            this.Size = new System.Drawing.Size(471, 151);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TypeArchive.ResumeLayout(false);
            this.TypeArchive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FinishArchivedateTime;
        private System.Windows.Forms.DateTimePicker StartArchivedateTime;
        private System.Windows.Forms.RadioButton radioButtonHour;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.GroupBox TypeArchive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}
