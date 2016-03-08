namespace Jupiter
{
    partial class JupiterTest
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
            this.resultResponseViewJupiter = new WindowsFormsApplication1.Controls.ResultResponseView();
            this.deviceControl1 = new Jupiter.Controls.DeviceControl();
            this.SuspendLayout();
            // 
            // resultResponseViewJupiter
            // 
            this.resultResponseViewJupiter.Location = new System.Drawing.Point(0, 141);
            this.resultResponseViewJupiter.Name = "resultResponseViewJupiter";
            this.resultResponseViewJupiter.Size = new System.Drawing.Size(646, 430);
            this.resultResponseViewJupiter.TabIndex = 1;
            // 
            // deviceControl1
            // 
            this.deviceControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceControl1.Location = new System.Drawing.Point(0, 0);
            this.deviceControl1.Name = "deviceControl1";
            this.deviceControl1.Size = new System.Drawing.Size(646, 150);
            this.deviceControl1.TabIndex = 0;
            // 
            // JupiterTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 590);
            this.Controls.Add(this.resultResponseViewJupiter);
            this.Controls.Add(this.deviceControl1);
            this.Name = "JupiterTest";
            this.Text = "Jupiter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JupiterTest_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DeviceControl deviceControl1;
        private WindowsFormsApplication1.Controls.ResultResponseView resultResponseViewJupiter;
    }
}

