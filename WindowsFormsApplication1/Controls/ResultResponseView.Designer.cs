namespace WindowsFormsApplication1.Controls
{
    partial class ResultResponseView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UnitsPage = new System.Windows.Forms.TabPage();
            this.UnitsView = new System.Windows.Forms.DataGridView();
            this.NameUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchivePage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.UnitsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UnitsPage);
            this.tabControl1.Controls.Add(this.ArchivePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // UnitsPage
            // 
            this.UnitsPage.Controls.Add(this.UnitsView);
            this.UnitsPage.Location = new System.Drawing.Point(4, 22);
            this.UnitsPage.Name = "UnitsPage";
            this.UnitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.UnitsPage.Size = new System.Drawing.Size(469, 404);
            this.UnitsPage.TabIndex = 1;
            this.UnitsPage.Text = "Единицы измерения";
            this.UnitsPage.UseVisualStyleBackColor = true;
            // 
            // UnitsView
            // 
            this.UnitsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUnits,
            this.ValueUnits});
            this.UnitsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitsView.Location = new System.Drawing.Point(3, 3);
            this.UnitsView.Name = "UnitsView";
            this.UnitsView.Size = new System.Drawing.Size(463, 398);
            this.UnitsView.TabIndex = 0;
            // 
            // NameUnits
            // 
            this.NameUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameUnits.HeaderText = "Имя";
            this.NameUnits.Name = "NameUnits";
            // 
            // ValueUnits
            // 
            this.ValueUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueUnits.HeaderText = "Значение";
            this.ValueUnits.Name = "ValueUnits";
            // 
            // ArchivePage
            // 
            this.ArchivePage.Location = new System.Drawing.Point(4, 22);
            this.ArchivePage.Name = "ArchivePage";
            this.ArchivePage.Padding = new System.Windows.Forms.Padding(3);
            this.ArchivePage.Size = new System.Drawing.Size(469, 404);
            this.ArchivePage.TabIndex = 2;
            this.ArchivePage.Text = "Архивы";
            this.ArchivePage.UseVisualStyleBackColor = true;
            // 
            // ResultResponseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ResultResponseView";
            this.Size = new System.Drawing.Size(477, 430);
            this.tabControl1.ResumeLayout(false);
            this.UnitsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UnitsPage;
        private System.Windows.Forms.DataGridView UnitsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueUnits;
        private System.Windows.Forms.TabPage ArchivePage;
    }
}
