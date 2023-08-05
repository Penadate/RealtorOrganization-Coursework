namespace Realtor
{
    partial class Search
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
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.areaMin = new System.Windows.Forms.TextBox();
            this.floorMin = new System.Windows.Forms.TextBox();
            this.priceMin = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rental = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commission = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.TextBox();
            this.supplyId = new System.Windows.Forms.TextBox();
            this.areaMax = new System.Windows.Forms.TextBox();
            this.floorMax = new System.Windows.Forms.TextBox();
            this.priceMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTable
            // 
            this.resultTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.Location = new System.Drawing.Point(32, 260);
            this.resultTable.Name = "resultTable";
            this.resultTable.RowHeadersWidth = 51;
            this.resultTable.RowTemplate.Height = 24;
            this.resultTable.Size = new System.Drawing.Size(931, 240);
            this.resultTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Місто";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(149, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Район";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(233, 44);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 30);
            this.type.TabIndex = 5;
            this.type.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.Location = new System.Drawing.Point(233, 80);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 30);
            this.city.TabIndex = 6;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // district
            // 
            this.district.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.district.Location = new System.Drawing.Point(233, 120);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(100, 30);
            this.district.TabIndex = 7;
            this.district.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // areaMin
            // 
            this.areaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaMin.Location = new System.Drawing.Point(518, 41);
            this.areaMin.Name = "areaMin";
            this.areaMin.Size = new System.Drawing.Size(100, 30);
            this.areaMin.TabIndex = 8;
            this.areaMin.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // floorMin
            // 
            this.floorMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorMin.Location = new System.Drawing.Point(518, 80);
            this.floorMin.Name = "floorMin";
            this.floorMin.Size = new System.Drawing.Size(100, 30);
            this.floorMin.TabIndex = 11;
            this.floorMin.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // priceMin
            // 
            this.priceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMin.Location = new System.Drawing.Point(518, 117);
            this.priceMin.Name = "priceMin";
            this.priceMin.Size = new System.Drawing.Size(100, 30);
            this.priceMin.TabIndex = 12;
            this.priceMin.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(374, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 25);
            this.label.TabIndex = 14;
            this.label.Text = "Площа від";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(374, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Поверх від";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(374, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Вартість від";
            // 
            // customerId
            // 
            this.customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerId.FormattingEnabled = true;
            this.customerId.Location = new System.Drawing.Point(220, 168);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(62, 33);
            this.customerId.TabIndex = 19;
            this.customerId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID орендаря";
            this.label4.Visible = false;
            // 
            // rental
            // 
            this.rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rental.Location = new System.Drawing.Point(698, 171);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(225, 67);
            this.rental.TabIndex = 21;
            this.rental.Text = "Орендувати";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID нерухомості";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(333, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Комісія рієлтора(%)";
            // 
            // commission
            // 
            this.commission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commission.Location = new System.Drawing.Point(543, 169);
            this.commission.Name = "commission";
            this.commission.Size = new System.Drawing.Size(100, 30);
            this.commission.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(428, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Термін(м)";
            // 
            // term
            // 
            this.term.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term.Location = new System.Drawing.Point(543, 210);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(100, 30);
            this.term.TabIndex = 26;
            // 
            // supplyId
            // 
            this.supplyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplyId.Location = new System.Drawing.Point(220, 213);
            this.supplyId.Name = "supplyId";
            this.supplyId.Size = new System.Drawing.Size(62, 30);
            this.supplyId.TabIndex = 28;
            // 
            // areaMax
            // 
            this.areaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaMax.Location = new System.Drawing.Point(711, 44);
            this.areaMax.Name = "areaMax";
            this.areaMax.Size = new System.Drawing.Size(100, 30);
            this.areaMax.TabIndex = 9;
            this.areaMax.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // floorMax
            // 
            this.floorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorMax.Location = new System.Drawing.Point(711, 83);
            this.floorMax.Name = "floorMax";
            this.floorMax.Size = new System.Drawing.Size(100, 30);
            this.floorMax.TabIndex = 10;
            this.floorMax.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // priceMax
            // 
            this.priceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMax.Location = new System.Drawing.Point(711, 120);
            this.priceMax.Name = "priceMax";
            this.priceMax.Size = new System.Drawing.Size(100, 30);
            this.priceMax.TabIndex = 13;
            this.priceMax.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(670, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(670, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "до";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(670, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "до";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 531);
            this.Controls.Add(this.supplyId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.term);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.commission);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label);
            this.Controls.Add(this.priceMax);
            this.Controls.Add(this.priceMin);
            this.Controls.Add(this.floorMin);
            this.Controls.Add(this.floorMax);
            this.Controls.Add(this.areaMax);
            this.Controls.Add(this.areaMin);
            this.Controls.Add(this.district);
            this.Controls.Add(this.city);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTable);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox areaMin;
        private System.Windows.Forms.TextBox floorMin;
        private System.Windows.Forms.TextBox priceMin;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox customerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox commission;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox term;
        private System.Windows.Forms.TextBox supplyId;
        private System.Windows.Forms.TextBox areaMax;
        private System.Windows.Forms.TextBox floorMax;
        private System.Windows.Forms.TextBox priceMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}