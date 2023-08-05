namespace Realtor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рієлторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рієлториToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нерухомістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оголошенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рієлторівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.містаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видиНерухомостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.місяціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довільнийЗапитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationView = new System.Windows.Forms.DataGridView();
            this.RealtorEmail = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.QueryText = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.інформаціяToolStripMenuItem,
            this.рейтингToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рієлторToolStripMenuItem,
            this.клієнтToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.loginToolStripMenuItem.Text = "Увійти";
            // 
            // рієлторToolStripMenuItem
            // 
            this.рієлторToolStripMenuItem.Name = "рієлторToolStripMenuItem";
            this.рієлторToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.рієлторToolStripMenuItem.Text = "Рієлтор";
            this.рієлторToolStripMenuItem.Click += new System.EventHandler(this.рієлторToolStripMenuItem_Click);
            // 
            // клієнтToolStripMenuItem
            // 
            this.клієнтToolStripMenuItem.Name = "клієнтToolStripMenuItem";
            this.клієнтToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.клієнтToolStripMenuItem.Text = "Клієнт";
            this.клієнтToolStripMenuItem.Click += new System.EventHandler(this.клієнтToolStripMenuItem_Click);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рієлториToolStripMenuItem,
            this.нерухомістьToolStripMenuItem,
            this.оголошенняToolStripMenuItem});
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.інформаціяToolStripMenuItem.Text = "Інформація";
            // 
            // рієлториToolStripMenuItem
            // 
            this.рієлториToolStripMenuItem.Name = "рієлториToolStripMenuItem";
            this.рієлториToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.рієлториToolStripMenuItem.Text = "Рієлтори";
            this.рієлториToolStripMenuItem.Click += new System.EventHandler(this.рієлториToolStripMenuItem_Click);
            // 
            // нерухомістьToolStripMenuItem
            // 
            this.нерухомістьToolStripMenuItem.Name = "нерухомістьToolStripMenuItem";
            this.нерухомістьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.нерухомістьToolStripMenuItem.Text = "Нерухомість";
            this.нерухомістьToolStripMenuItem.Click += new System.EventHandler(this.нерухомістьToolStripMenuItem_Click);
            // 
            // оголошенняToolStripMenuItem
            // 
            this.оголошенняToolStripMenuItem.Name = "оголошенняToolStripMenuItem";
            this.оголошенняToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оголошенняToolStripMenuItem.Text = "Оголошення";
            this.оголошенняToolStripMenuItem.Click += new System.EventHandler(this.оголошенняToolStripMenuItem_Click);
            // 
            // рейтингToolStripMenuItem
            // 
            this.рейтингToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рієлторівToolStripMenuItem,
            this.містаToolStripMenuItem,
            this.видиНерухомостіToolStripMenuItem,
            this.місяціToolStripMenuItem,
            this.довільнийЗапитToolStripMenuItem});
            this.рейтингToolStripMenuItem.Name = "рейтингToolStripMenuItem";
            this.рейтингToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.рейтингToolStripMenuItem.Text = "Рейтинг";
            // 
            // рієлторівToolStripMenuItem
            // 
            this.рієлторівToolStripMenuItem.Name = "рієлторівToolStripMenuItem";
            this.рієлторівToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.рієлторівToolStripMenuItem.Text = "Рієлтори";
            this.рієлторівToolStripMenuItem.Click += new System.EventHandler(this.рієлторівToolStripMenuItem_Click);
            // 
            // містаToolStripMenuItem
            // 
            this.містаToolStripMenuItem.Name = "містаToolStripMenuItem";
            this.містаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.містаToolStripMenuItem.Text = "Міста";
            this.містаToolStripMenuItem.Click += new System.EventHandler(this.містаToolStripMenuItem_Click);
            // 
            // видиНерухомостіToolStripMenuItem
            // 
            this.видиНерухомостіToolStripMenuItem.Name = "видиНерухомостіToolStripMenuItem";
            this.видиНерухомостіToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.видиНерухомостіToolStripMenuItem.Text = "Види нерухомості";
            this.видиНерухомостіToolStripMenuItem.Click += new System.EventHandler(this.видиНерухомостіToolStripMenuItem_Click);
            // 
            // місяціToolStripMenuItem
            // 
            this.місяціToolStripMenuItem.Name = "місяціToolStripMenuItem";
            this.місяціToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.місяціToolStripMenuItem.Text = "Місяці";
            this.місяціToolStripMenuItem.Click += new System.EventHandler(this.місяціToolStripMenuItem_Click);
            // 
            // довільнийЗапитToolStripMenuItem
            // 
            this.довільнийЗапитToolStripMenuItem.Name = "довільнийЗапитToolStripMenuItem";
            this.довільнийЗапитToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.довільнийЗапитToolStripMenuItem.Text = "Довільний запит";
            this.довільнийЗапитToolStripMenuItem.Click += new System.EventHandler(this.довільнийЗапитToolStripMenuItem_Click);
            // 
            // informationView
            // 
            this.informationView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.informationView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.informationView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationView.Location = new System.Drawing.Point(24, 154);
            this.informationView.Name = "informationView";
            this.informationView.RowHeadersWidth = 51;
            this.informationView.RowTemplate.Height = 24;
            this.informationView.Size = new System.Drawing.Size(1033, 306);
            this.informationView.TabIndex = 1;
            this.informationView.Visible = false;
            // 
            // RealtorEmail
            // 
            this.RealtorEmail.AutoSize = true;
            this.RealtorEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.RealtorEmail.Location = new System.Drawing.Point(1141, 28);
            this.RealtorEmail.Name = "RealtorEmail";
            this.RealtorEmail.Size = new System.Drawing.Size(0, 16);
            this.RealtorEmail.TabIndex = 12;
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Run.Location = new System.Drawing.Point(849, 103);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(150, 40);
            this.Run.TabIndex = 15;
            this.Run.Text = "Виконати";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(849, 57);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(150, 40);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Очистити";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // QueryText
            // 
            this.QueryText.Location = new System.Drawing.Point(79, 57);
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(751, 86);
            this.QueryText.TabIndex = 13;
            this.QueryText.Text = "SELECT";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(43, 103);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 25);
            this.title.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 595);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.QueryText);
            this.Controls.Add(this.RealtorEmail);
            this.Controls.Add(this.informationView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Рієлторська організація";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рієлторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рієлториToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нерухомістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оголошенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рієлторівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem містаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видиНерухомостіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem місяціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довільнийЗапитToolStripMenuItem;
        private System.Windows.Forms.DataGridView informationView;
        private System.Windows.Forms.Label RealtorEmail;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RichTextBox QueryText;
        private System.Windows.Forms.Label title;
    }
}