namespace ClinicMangement
{
    partial class AddPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx = new DevComponents.DotNetBar.PanelEx();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.افزودنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.افزودنسریعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.افزودنToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دکترToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنضیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewXEmp = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.بیمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx
            // 
            this.panelEx.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx.Controls.Add(this.menuStrip1);
            this.panelEx.Controls.Add(this.label1);
            this.panelEx.Controls.Add(this.dataGridViewXEmp);
            this.panelEx.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx.Location = new System.Drawing.Point(0, 0);
            this.panelEx.Name = "panelEx";
            this.panelEx.Size = new System.Drawing.Size(913, 491);
            this.panelEx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx.Style.BackColor1.Color = System.Drawing.Color.LightBlue;
            this.panelEx.Style.BackColor2.Color = System.Drawing.Color.Azure;
            this.panelEx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx.Style.GradientAngle = 90;
            this.panelEx.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.افزودنToolStripMenuItem,
            this.گزارشاتToolStripMenuItem,
            this.تنضیماتToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(913, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip";
            // 
            // افزودنToolStripMenuItem
            // 
            this.افزودنToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.افزودنسریعToolStripMenuItem,
            this.افزودنToolStripMenuItem1});
            this.افزودنToolStripMenuItem.Name = "افزودنToolStripMenuItem";
            this.افزودنToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.افزودنToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // افزودنسریعToolStripMenuItem
            // 
            this.افزودنسریعToolStripMenuItem.Name = "افزودنسریعToolStripMenuItem";
            this.افزودنسریعToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.افزودنسریعToolStripMenuItem.Text = "افزودن سریع";
            this.افزودنسریعToolStripMenuItem.Click += new System.EventHandler(this.افزودنسریعToolStripMenuItem_Click);
            // 
            // افزودنToolStripMenuItem1
            // 
            this.افزودنToolStripMenuItem1.Name = "افزودنToolStripMenuItem1";
            this.افزودنToolStripMenuItem1.Size = new System.Drawing.Size(156, 28);
            this.افزودنToolStripMenuItem1.Text = "افزودن بیمار";
            this.افزودنToolStripMenuItem1.Click += new System.EventHandler(this.افزودنToolStripMenuItem1_Click);
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بیمارToolStripMenuItem,
            this.دکترToolStripMenuItem,
            this.بیمهToolStripMenuItem});
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            this.گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // بیمارToolStripMenuItem
            // 
            this.بیمارToolStripMenuItem.Name = "بیمارToolStripMenuItem";
            this.بیمارToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.بیمارToolStripMenuItem.Text = "بیمار ";
            this.بیمارToolStripMenuItem.Click += new System.EventHandler(this.بیمارToolStripMenuItem_Click);
            // 
            // دکترToolStripMenuItem
            // 
            this.دکترToolStripMenuItem.Name = "دکترToolStripMenuItem";
            this.دکترToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.دکترToolStripMenuItem.Text = "دکتر";
            this.دکترToolStripMenuItem.Click += new System.EventHandler(this.دکترToolStripMenuItem_Click);
            // 
            // تنضیماتToolStripMenuItem
            // 
            this.تنضیماتToolStripMenuItem.Name = "تنضیماتToolStripMenuItem";
            this.تنضیماتToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.تنضیماتToolStripMenuItem.Text = "تنضیمات";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(52, 27);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(440, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "بیماران";
            // 
            // dataGridViewXEmp
            // 
            this.dataGridViewXEmp.AllowUserToAddRows = false;
            this.dataGridViewXEmp.AllowUserToDeleteRows = false;
            this.dataGridViewXEmp.AllowUserToResizeRows = false;
            this.dataGridViewXEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewXEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.lname,
            this.Ename,
            this.Address,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewXEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewXEmp.Location = new System.Drawing.Point(12, 117);
            this.dataGridViewXEmp.MultiSelect = false;
            this.dataGridViewXEmp.Name = "dataGridViewXEmp";
            this.dataGridViewXEmp.ReadOnly = true;
            this.dataGridViewXEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewXEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXEmp.Size = new System.Drawing.Size(889, 328);
            this.dataGridViewXEmp.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "نام خانوادگی";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // Ename
            // 
            this.Ename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ename.DataPropertyName = "Ename";
            this.Ename.HeaderText = "کد ملی";
            this.Ename.Name = "Ename";
            this.Ename.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "پزشک";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "بیمه";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // بیمهToolStripMenuItem
            // 
            this.بیمهToolStripMenuItem.Name = "بیمهToolStripMenuItem";
            this.بیمهToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.بیمهToolStripMenuItem.Text = "بیمه";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 491);
            this.Controls.Add(this.panelEx);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "AddPatient";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن بیمار";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.panelEx.ResumeLayout(false);
            this.panelEx.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXEmp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem افزودنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem افزودنسریعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem افزودنToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دکترToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تنضیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem بیمهToolStripMenuItem;
    }
}