namespace ClinicMangement
{
    partial class ReportDoctor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx = new DevComponents.DotNetBar.PanelEx();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewXEmp = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx
            // 
            this.panelEx.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx.Controls.Add(this.btnClose);
            this.panelEx.Controls.Add(this.dataGridViewXEmp);
            this.panelEx.Controls.Add(this.label1);
            this.panelEx.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx.Location = new System.Drawing.Point(0, 0);
            this.panelEx.Name = "panelEx";
            this.panelEx.Size = new System.Drawing.Size(700, 465);
            this.panelEx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx.Style.BackColor1.Color = System.Drawing.Color.LightBlue;
            this.panelEx.Style.BackColor2.Color = System.Drawing.Color.Azure;
            this.panelEx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx.Style.GradientAngle = 90;
            this.panelEx.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(22, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "بازگشت";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewXEmp
            // 
            this.dataGridViewXEmp.AllowUserToAddRows = false;
            this.dataGridViewXEmp.AllowUserToDeleteRows = false;
            this.dataGridViewXEmp.AllowUserToResizeRows = false;
            this.dataGridViewXEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewXEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXEmp.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewXEmp.Location = new System.Drawing.Point(3, 62);
            this.dataGridViewXEmp.MultiSelect = false;
            this.dataGridViewXEmp.Name = "dataGridViewXEmp";
            this.dataGridViewXEmp.ReadOnly = true;
            this.dataGridViewXEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewXEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXEmp.Size = new System.Drawing.Size(697, 329);
            this.dataGridViewXEmp.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "نام پزشک";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "تخصص";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "روزهای حضور";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(304, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "دکتر";
            // 
            // ReportDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 465);
            this.Controls.Add(this.panelEx);
            this.MaximizeBox = false;
            this.Name = "ReportDoctor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارشات دکتر";
            this.panelEx.ResumeLayout(false);
            this.panelEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
    }
}