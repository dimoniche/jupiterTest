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
			this.devicesTab = new System.Windows.Forms.TabControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.state = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// devicesTab
			// 
			this.devicesTab.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.devicesTab.Location = new System.Drawing.Point(0, 79);
			this.devicesTab.Name = "devicesTab";
			this.devicesTab.SelectedIndex = 0;
			this.devicesTab.Size = new System.Drawing.Size(646, 593);
			this.devicesTab.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.state);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(646, 79);
			this.panel1.TabIndex = 1;
			// 
			// state
			// 
			this.state.AutoSize = true;
			this.state.Location = new System.Drawing.Point(12, 50);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(59, 13);
			this.state.TabIndex = 3;
			this.state.Text = "disconnect";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(95, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Подключиться";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(470, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(164, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Удалить устройство";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(298, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Новое устройство";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// JupiterTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 672);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.devicesTab);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "JupiterTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jupiter";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JupiterTest_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl devicesTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label state;
    }
}

