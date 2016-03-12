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
            this.components = new System.ComponentModel.Container();
            this.DateArchive = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishArchivedateTime = new System.Windows.Forms.DateTimePicker();
            this.StartArchivedateTime = new System.Windows.Forms.DateTimePicker();
            this.radioButtonHour = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.TypeArchive = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.DeviceSetting = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deviceId = new System.Windows.Forms.TextBox();
            this.devicetype = new System.Windows.Forms.ComboBox();
            this.IMEI = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.result = new System.Windows.Forms.Label();
            this.resultResponseView = new WindowsFormsApplication1.Controls.ResultResponseView();
            this.DateArchive.SuspendLayout();
            this.TypeArchive.SuspendLayout();
            this.DeviceSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateArchive
            // 
            this.DateArchive.Controls.Add(this.label2);
            this.DateArchive.Controls.Add(this.label1);
            this.DateArchive.Controls.Add(this.FinishArchivedateTime);
            this.DateArchive.Controls.Add(this.StartArchivedateTime);
            this.DateArchive.Location = new System.Drawing.Point(14, 138);
            this.DateArchive.Name = "DateArchive";
            this.DateArchive.Size = new System.Drawing.Size(296, 94);
            this.DateArchive.TabIndex = 3;
            this.DateArchive.TabStop = false;
            this.DateArchive.Text = "Даты архива";
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
            this.radioButtonHour.Text = "Часовой архив";
            this.radioButtonHour.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Checked = true;
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
            this.TypeArchive.Location = new System.Drawing.Point(316, 138);
            this.TypeArchive.Name = "TypeArchive";
            this.TypeArchive.Size = new System.Drawing.Size(139, 94);
            this.TypeArchive.TabIndex = 5;
            this.TypeArchive.TabStop = false;
            this.TypeArchive.Text = "Тип архива";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запросить архив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeviceSetting
            // 
            this.DeviceSetting.Controls.Add(this.label5);
            this.DeviceSetting.Controls.Add(this.label4);
            this.DeviceSetting.Controls.Add(this.label3);
            this.DeviceSetting.Controls.Add(this.deviceId);
            this.DeviceSetting.Controls.Add(this.devicetype);
            this.DeviceSetting.Controls.Add(this.IMEI);
            this.DeviceSetting.Controls.Add(this.textBox1);
            this.DeviceSetting.Location = new System.Drawing.Point(14, 3);
            this.DeviceSetting.Name = "DeviceSetting";
            this.DeviceSetting.Size = new System.Drawing.Size(200, 129);
            this.DeviceSetting.TabIndex = 7;
            this.DeviceSetting.TabStop = false;
            this.DeviceSetting.Text = "Устройство";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Серийный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IMEI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Адрес";
            // 
            // deviceId
            // 
            this.deviceId.Location = new System.Drawing.Point(94, 71);
            this.deviceId.Name = "deviceId";
            this.deviceId.Size = new System.Drawing.Size(100, 20);
            this.deviceId.TabIndex = 8;
            this.deviceId.Text = "1";
            // 
            // devicetype
            // 
            this.devicetype.FormattingEnabled = true;
            this.devicetype.Items.AddRange(new object[] {
            "Нет",
            "SPT941_11",
            "SPT943",
            "SPT942"});
            this.devicetype.Location = new System.Drawing.Point(9, 19);
            this.devicetype.Name = "devicetype";
            this.devicetype.Size = new System.Drawing.Size(185, 21);
            this.devicetype.TabIndex = 8;
            this.devicetype.Text = "Нет";
            // 
            // IMEI
            // 
            this.IMEI.Location = new System.Drawing.Point(94, 96);
            this.IMEI.Name = "IMEI";
            this.IMEI.Size = new System.Drawing.Size(100, 20);
            this.IMEI.TabIndex = 8;
            this.IMEI.Text = "353173062746001";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(20, 248);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(22, 13);
            this.result.TabIndex = 10;
            this.result.Text = "OK";
            // 
            // resultResponseView
            // 
            this.resultResponseView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultResponseView.Location = new System.Drawing.Point(0, 267);
            this.resultResponseView.Name = "resultResponseView";
            this.resultResponseView.Size = new System.Drawing.Size(632, 300);
            this.resultResponseView.TabIndex = 11;
            // 
            // DeviceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultResponseView);
            this.Controls.Add(this.result);
            this.Controls.Add(this.DeviceSetting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TypeArchive);
            this.Controls.Add(this.DateArchive);
            this.Name = "DeviceControl";
            this.Size = new System.Drawing.Size(632, 567);
            this.DateArchive.ResumeLayout(false);
            this.DateArchive.PerformLayout();
            this.TypeArchive.ResumeLayout(false);
            this.TypeArchive.PerformLayout();
            this.DeviceSetting.ResumeLayout(false);
            this.DeviceSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox DateArchive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FinishArchivedateTime;
        private System.Windows.Forms.DateTimePicker StartArchivedateTime;
        private System.Windows.Forms.RadioButton radioButtonHour;
        private System.Windows.Forms.RadioButton radioButtonDay;
        public System.Windows.Forms.GroupBox TypeArchive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox DeviceSetting;
        private System.Windows.Forms.ComboBox devicetype;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IMEI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deviceId;
        private System.Windows.Forms.Label result;
        public WindowsFormsApplication1.Controls.ResultResponseView resultResponseView;
    }
}
