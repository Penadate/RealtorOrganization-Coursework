namespace Realtor
{
    partial class Account
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
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.logIn = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нерухомістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оголошенняПошукуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нерухомістьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оголошенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.себеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нерухомістьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.оголошенняПошукуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.орендиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.співпраціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевіркаАктуальностіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розрахунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerEmail = new System.Windows.Forms.Label();
            this.editInfo = new System.Windows.Forms.Button();
            this.idCustomer = new System.Windows.Forms.ComboBox();
            this.customerID = new System.Windows.Forms.Label();
            this.informationTable = new System.Windows.Forms.DataGridView();
            this.demandId = new System.Windows.Forms.ComboBox();
            this.searchSupply = new System.Windows.Forms.Button();
            this.supplyId = new System.Windows.Forms.ComboBox();
            this.rental = new System.Windows.Forms.Button();
            this.term = new System.Windows.Forms.TextBox();
            this.termTitle = new System.Windows.Forms.Label();
            this.commission = new System.Windows.Forms.TextBox();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.supplyIdLabel = new System.Windows.Forms.Label();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.contractIdLabel = new System.Windows.Forms.Label();
            this.idDemandLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailText.Location = new System.Drawing.Point(363, 264);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(276, 30);
            this.emailText.TabIndex = 8;
            this.emailText.Enter += new System.EventHandler(this.emailText_Enter);
            this.emailText.Leave += new System.EventHandler(this.emailText_Leave);
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneText.Location = new System.Drawing.Point(363, 315);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(276, 30);
            this.phoneText.TabIndex = 9;
            this.phoneText.Enter += new System.EventHandler(this.phoneText_Enter);
            this.phoneText.Leave += new System.EventHandler(this.phoneText_Leave);
            // 
            // logIn
            // 
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logIn.Location = new System.Drawing.Point(363, 425);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(276, 37);
            this.logIn.TabIndex = 10;
            this.logIn.Text = "Увійти";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.Location = new System.Drawing.Point(442, 465);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(121, 17);
            this.register.TabIndex = 11;
            this.register.Text = "Зареєструватись";
            this.register.Click += new System.EventHandler(this.register_Click);
            this.register.MouseEnter += new System.EventHandler(this.register_MouseEnter);
            this.register.MouseLeave += new System.EventHandler(this.register_MouseLeave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(363, 365);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(276, 30);
            this.password.TabIndex = 12;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(363, 425);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(276, 37);
            this.registrationButton.TabIndex = 13;
            this.registrationButton.Text = "Зареєструватися";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Visible = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName.Location = new System.Drawing.Point(363, 102);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(276, 30);
            this.lastName.TabIndex = 14;
            this.lastName.Visible = false;
            this.lastName.Enter += new System.EventHandler(this.lastName_Enter);
            this.lastName.Leave += new System.EventHandler(this.lastName_Leave);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.Location = new System.Drawing.Point(363, 156);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(276, 30);
            this.firstName.TabIndex = 15;
            this.firstName.Visible = false;
            this.firstName.Enter += new System.EventHandler(this.firstName_Enter);
            this.firstName.Leave += new System.EventHandler(this.firstName_Leave);
            // 
            // middleName
            // 
            this.middleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleName.Location = new System.Drawing.Point(363, 212);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(276, 30);
            this.middleName.TabIndex = 16;
            this.middleName.Visible = false;
            this.middleName.Enter += new System.EventHandler(this.middleName_Enter);
            this.middleName.Leave += new System.EventHandler(this.middleName_Leave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(429, 46);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(152, 29);
            this.title.TabIndex = 17;
            this.title.Text = "Авторизація";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вийтиToolStripMenuItem,
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.інформаціяToolStripMenuItem,
            this.договориToolStripMenuItem,
            this.пошукToolStripMenuItem,
            this.розрахунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip";
            this.menuStrip1.Visible = false;
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нерухомістьToolStripMenuItem,
            this.оголошенняПошукуToolStripMenuItem,
            this.клієнтToolStripMenuItem});
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.додатиToolStripMenuItem.Text = "Додати";
            // 
            // нерухомістьToolStripMenuItem
            // 
            this.нерухомістьToolStripMenuItem.Name = "нерухомістьToolStripMenuItem";
            this.нерухомістьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.нерухомістьToolStripMenuItem.Text = "Нерухомість";
            this.нерухомістьToolStripMenuItem.Click += new System.EventHandler(this.нерухомістьToolStripMenuItem_Click);
            // 
            // оголошенняПошукуToolStripMenuItem
            // 
            this.оголошенняПошукуToolStripMenuItem.Name = "оголошенняПошукуToolStripMenuItem";
            this.оголошенняПошукуToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.оголошенняПошукуToolStripMenuItem.Text = "Оголошення пошуку";
            this.оголошенняПошукуToolStripMenuItem.Click += new System.EventHandler(this.оголошенняПошукуToolStripMenuItem_Click);
            // 
            // клієнтToolStripMenuItem
            // 
            this.клієнтToolStripMenuItem.Name = "клієнтToolStripMenuItem";
            this.клієнтToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.клієнтToolStripMenuItem.Text = "Клієнт";
            this.клієнтToolStripMenuItem.Click += new System.EventHandler(this.клієнтToolStripMenuItem_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нерухомістьToolStripMenuItem1,
            this.оголошенняToolStripMenuItem,
            this.себеToolStripMenuItem,
            this.клієнтToolStripMenuItem1});
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            // 
            // нерухомістьToolStripMenuItem1
            // 
            this.нерухомістьToolStripMenuItem1.Name = "нерухомістьToolStripMenuItem1";
            this.нерухомістьToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.нерухомістьToolStripMenuItem1.Text = "Нерухомість";
            this.нерухомістьToolStripMenuItem1.Click += new System.EventHandler(this.нерухомістьToolStripMenuItem1_Click);
            // 
            // оголошенняToolStripMenuItem
            // 
            this.оголошенняToolStripMenuItem.Name = "оголошенняToolStripMenuItem";
            this.оголошенняToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.оголошенняToolStripMenuItem.Text = "Оголошення";
            this.оголошенняToolStripMenuItem.Click += new System.EventHandler(this.оголошенняToolStripMenuItem_Click);
            // 
            // себеToolStripMenuItem
            // 
            this.себеToolStripMenuItem.Name = "себеToolStripMenuItem";
            this.себеToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.себеToolStripMenuItem.Text = "Себе";
            this.себеToolStripMenuItem.Click += new System.EventHandler(this.себеToolStripMenuItem_Click);
            // 
            // клієнтToolStripMenuItem1
            // 
            this.клієнтToolStripMenuItem1.Name = "клієнтToolStripMenuItem1";
            this.клієнтToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.клієнтToolStripMenuItem1.Text = "Клієнт";
            this.клієнтToolStripMenuItem1.Click += new System.EventHandler(this.клієнтToolStripMenuItem1_Click);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нерухомістьToolStripMenuItem2,
            this.оголошенняПошукуToolStripMenuItem1,
            this.клієнтиToolStripMenuItem});
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.інформаціяToolStripMenuItem.Text = "Інформація";
            // 
            // нерухомістьToolStripMenuItem2
            // 
            this.нерухомістьToolStripMenuItem2.Name = "нерухомістьToolStripMenuItem2";
            this.нерухомістьToolStripMenuItem2.Size = new System.Drawing.Size(236, 26);
            this.нерухомістьToolStripMenuItem2.Text = "Нерухомість";
            this.нерухомістьToolStripMenuItem2.Click += new System.EventHandler(this.нерухомістьToolStripMenuItem2_Click);
            // 
            // оголошенняПошукуToolStripMenuItem1
            // 
            this.оголошенняПошукуToolStripMenuItem1.Name = "оголошенняПошукуToolStripMenuItem1";
            this.оголошенняПошукуToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.оголошенняПошукуToolStripMenuItem1.Text = "Оголошення пошуку";
            this.оголошенняПошукуToolStripMenuItem1.Click += new System.EventHandler(this.оголошенняПошукуToolStripMenuItem1_Click);
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // договориToolStripMenuItem
            // 
            this.договориToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.орендиToolStripMenuItem,
            this.співпраціToolStripMenuItem,
            this.перевіркаАктуальностіToolStripMenuItem});
            this.договориToolStripMenuItem.Name = "договориToolStripMenuItem";
            this.договориToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.договориToolStripMenuItem.Text = "Договори";
            // 
            // орендиToolStripMenuItem
            // 
            this.орендиToolStripMenuItem.Name = "орендиToolStripMenuItem";
            this.орендиToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.орендиToolStripMenuItem.Text = "Оренди";
            this.орендиToolStripMenuItem.Click += new System.EventHandler(this.орендиToolStripMenuItem_Click);
            // 
            // співпраціToolStripMenuItem
            // 
            this.співпраціToolStripMenuItem.Name = "співпраціToolStripMenuItem";
            this.співпраціToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.співпраціToolStripMenuItem.Text = "Співпраці";
            this.співпраціToolStripMenuItem.Click += new System.EventHandler(this.співпраціToolStripMenuItem_Click);
            // 
            // перевіркаАктуальностіToolStripMenuItem
            // 
            this.перевіркаАктуальностіToolStripMenuItem.Name = "перевіркаАктуальностіToolStripMenuItem";
            this.перевіркаАктуальностіToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.перевіркаАктуальностіToolStripMenuItem.Text = "Перевірка актуальності";
            this.перевіркаАктуальностіToolStripMenuItem.Click += new System.EventHandler(this.перевіркаАктуальностіToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.пошукToolStripMenuItem.Text = "Пошук нерухомості";
            this.пошукToolStripMenuItem.Click += new System.EventHandler(this.пошукToolStripMenuItem_Click);
            // 
            // розрахунокToolStripMenuItem
            // 
            this.розрахунокToolStripMenuItem.Name = "розрахунокToolStripMenuItem";
            this.розрахунокToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.розрахунокToolStripMenuItem.Text = "Діяльність рієлторіів";
            this.розрахунокToolStripMenuItem.Click += new System.EventHandler(this.розрахунокToolStripMenuItem_Click);
            // 
            // customerEmail
            // 
            this.customerEmail.AutoSize = true;
            this.customerEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerEmail.Location = new System.Drawing.Point(0, 0);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(0, 25);
            this.customerEmail.TabIndex = 19;
            // 
            // editInfo
            // 
            this.editInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editInfo.Location = new System.Drawing.Point(363, 365);
            this.editInfo.Name = "editInfo";
            this.editInfo.Size = new System.Drawing.Size(276, 36);
            this.editInfo.TabIndex = 20;
            this.editInfo.Text = "Редагувати";
            this.editInfo.UseVisualStyleBackColor = true;
            this.editInfo.Visible = false;
            this.editInfo.Click += new System.EventHandler(this.editInfo_Click);
            // 
            // idCustomer
            // 
            this.idCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCustomer.FormattingEnabled = true;
            this.idCustomer.Location = new System.Drawing.Point(442, 53);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(121, 33);
            this.idCustomer.TabIndex = 21;
            this.idCustomer.Visible = false;
            this.idCustomer.TextChanged += new System.EventHandler(this.idCustomer_TextChanged);
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerID.Location = new System.Drawing.Point(392, 55);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(31, 25);
            this.customerID.TabIndex = 22;
            this.customerID.Text = "ID";
            this.customerID.Visible = false;
            // 
            // informationTable
            // 
            this.informationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.informationTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.informationTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationTable.Location = new System.Drawing.Point(17, 156);
            this.informationTable.Name = "informationTable";
            this.informationTable.RowHeadersWidth = 51;
            this.informationTable.RowTemplate.Height = 24;
            this.informationTable.Size = new System.Drawing.Size(978, 214);
            this.informationTable.TabIndex = 23;
            this.informationTable.Visible = false;
            // 
            // demandId
            // 
            this.demandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.demandId.FormattingEnabled = true;
            this.demandId.Location = new System.Drawing.Point(175, 403);
            this.demandId.Name = "demandId";
            this.demandId.Size = new System.Drawing.Size(121, 33);
            this.demandId.TabIndex = 24;
            this.demandId.Visible = false;
            // 
            // searchSupply
            // 
            this.searchSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchSupply.Location = new System.Drawing.Point(697, 397);
            this.searchSupply.Name = "searchSupply";
            this.searchSupply.Size = new System.Drawing.Size(148, 43);
            this.searchSupply.TabIndex = 25;
            this.searchSupply.Text = "Підібрати";
            this.searchSupply.UseVisualStyleBackColor = true;
            this.searchSupply.Visible = false;
            this.searchSupply.Click += new System.EventHandler(this.searchSupply_Click);
            // 
            // supplyId
            // 
            this.supplyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplyId.FormattingEnabled = true;
            this.supplyId.Location = new System.Drawing.Point(175, 99);
            this.supplyId.Name = "supplyId";
            this.supplyId.Size = new System.Drawing.Size(121, 33);
            this.supplyId.TabIndex = 26;
            this.supplyId.Visible = false;
            // 
            // rental
            // 
            this.rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rental.Location = new System.Drawing.Point(809, 93);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(148, 43);
            this.rental.TabIndex = 27;
            this.rental.Text = "Орендувати";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Visible = false;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // term
            // 
            this.term.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term.Location = new System.Drawing.Point(675, 99);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(100, 30);
            this.term.TabIndex = 28;
            this.term.Visible = false;
            // 
            // termTitle
            // 
            this.termTitle.AutoSize = true;
            this.termTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termTitle.Location = new System.Drawing.Point(569, 102);
            this.termTitle.Name = "termTitle";
            this.termTitle.Size = new System.Drawing.Size(100, 25);
            this.termTitle.TabIndex = 29;
            this.termTitle.Text = "Строк(м)";
            this.termTitle.Visible = false;
            // 
            // commission
            // 
            this.commission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commission.Location = new System.Drawing.Point(442, 99);
            this.commission.Name = "commission";
            this.commission.Size = new System.Drawing.Size(100, 30);
            this.commission.TabIndex = 30;
            this.commission.Visible = false;
            // 
            // commissionLabel
            // 
            this.commissionLabel.AutoSize = true;
            this.commissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commissionLabel.Location = new System.Drawing.Point(318, 102);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(118, 25);
            this.commissionLabel.TabIndex = 31;
            this.commissionLabel.Text = "Комісія (%)";
            this.commissionLabel.Visible = false;
            // 
            // supplyIdLabel
            // 
            this.supplyIdLabel.AutoSize = true;
            this.supplyIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplyIdLabel.Location = new System.Drawing.Point(12, 102);
            this.supplyIdLabel.Name = "supplyIdLabel";
            this.supplyIdLabel.Size = new System.Drawing.Size(153, 25);
            this.supplyIdLabel.TabIndex = 32;
            this.supplyIdLabel.Text = "ID нерухомості";
            this.supplyIdLabel.Visible = false;
            // 
            // AddCustomer
            // 
            this.AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCustomer.Location = new System.Drawing.Point(363, 399);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(276, 37);
            this.AddCustomer.TabIndex = 33;
            this.AddCustomer.Text = "Додати клієнта";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Visible = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print.Location = new System.Drawing.Point(781, 82);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(197, 65);
            this.print.TabIndex = 34;
            this.print.Text = "Отримати копию";
            this.print.UseVisualStyleBackColor = true;
            this.print.Visible = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // contractIdLabel
            // 
            this.contractIdLabel.AutoSize = true;
            this.contractIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractIdLabel.Location = new System.Drawing.Point(16, 105);
            this.contractIdLabel.Name = "contractIdLabel";
            this.contractIdLabel.Size = new System.Drawing.Size(119, 25);
            this.contractIdLabel.TabIndex = 35;
            this.contractIdLabel.Text = "ID договору";
            this.contractIdLabel.Visible = false;
            // 
            // idDemandLabel
            // 
            this.idDemandLabel.AutoSize = true;
            this.idDemandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDemandLabel.Location = new System.Drawing.Point(12, 405);
            this.idDemandLabel.Name = "idDemandLabel";
            this.idDemandLabel.Size = new System.Drawing.Size(149, 25);
            this.idDemandLabel.TabIndex = 36;
            this.idDemandLabel.Text = "ID оголошення";
            this.idDemandLabel.Visible = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 531);
            this.Controls.Add(this.idDemandLabel);
            this.Controls.Add(this.contractIdLabel);
            this.Controls.Add(this.print);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.supplyIdLabel);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.commission);
            this.Controls.Add(this.termTitle);
            this.Controls.Add(this.term);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.supplyId);
            this.Controls.Add(this.searchSupply);
            this.Controls.Add(this.demandId);
            this.Controls.Add(this.informationTable);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.idCustomer);
            this.Controls.Add(this.editInfo);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.title);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.register);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Account";
            this.Text = "Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Account_FormClosed);
            this.Load += new System.EventHandler(this.Account_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нерухомістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оголошенняПошукуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нерухомістьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оголошенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem себеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтToolStripMenuItem1;
        private System.Windows.Forms.Label customerEmail;
        private System.Windows.Forms.Button editInfo;
        private System.Windows.Forms.ComboBox idCustomer;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нерухомістьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem оголошенняПошукуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.DataGridView informationTable;
        private System.Windows.Forms.ComboBox demandId;
        private System.Windows.Forms.Button searchSupply;
        private System.Windows.Forms.ComboBox supplyId;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.TextBox term;
        private System.Windows.Forms.Label termTitle;
        private System.Windows.Forms.TextBox commission;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.Label supplyIdLabel;
        private System.Windows.Forms.ToolStripMenuItem договориToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem орендиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem співпраціToolStripMenuItem;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label contractIdLabel;
        private System.Windows.Forms.ToolStripMenuItem розрахунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевіркаАктуальностіToolStripMenuItem;
        private System.Windows.Forms.Label idDemandLabel;
    }
}