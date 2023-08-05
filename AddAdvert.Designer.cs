namespace Realtor
{
    partial class AddAdvert
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
            this.information = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.floorLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.districtLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.IdCustomerLabel = new System.Windows.Forms.Label();
            this.floor = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.idCustomer = new System.Windows.Forms.ComboBox();
            this.floorMax = new System.Windows.Forms.TextBox();
            this.priceMax = new System.Windows.Forms.TextBox();
            this.areaMax = new System.Windows.Forms.TextBox();
            this.areaMaxLabel = new System.Windows.Forms.Label();
            this.priceMaxLabel = new System.Windows.Forms.Label();
            this.floorMaxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.information.Location = new System.Drawing.Point(366, 353);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(303, 75);
            this.information.TabIndex = 38;
            this.information.Text = "";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(242, 460);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(229, 56);
            this.add.TabIndex = 37;
            this.add.Text = "Додати";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(204, 348);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(59, 25);
            this.infoLabel.TabIndex = 36;
            this.infoLabel.Text = "Опис";
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorLabel.Location = new System.Drawing.Point(204, 306);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(79, 25);
            this.floorLabel.TabIndex = 35;
            this.floorLabel.Text = "Поверх";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(204, 265);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(93, 25);
            this.priceLabel.TabIndex = 34;
            this.priceLabel.Text = "Вартість";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaLabel.Location = new System.Drawing.Point(204, 225);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(76, 25);
            this.areaLabel.TabIndex = 33;
            this.areaLabel.Text = "Площа";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(204, 186);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(79, 25);
            this.addressLabel.TabIndex = 32;
            this.addressLabel.Text = "Адреса";
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtLabel.Location = new System.Drawing.Point(204, 148);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(67, 25);
            this.districtLabel.TabIndex = 31;
            this.districtLabel.Text = "Район";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(204, 103);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(65, 25);
            this.cityLabel.TabIndex = 30;
            this.cityLabel.Text = "Місто";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(204, 62);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(46, 25);
            this.typeLabel.TabIndex = 29;
            this.typeLabel.Text = "Тип";
            // 
            // IdCustomerLabel
            // 
            this.IdCustomerLabel.AutoSize = true;
            this.IdCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdCustomerLabel.Location = new System.Drawing.Point(204, 25);
            this.IdCustomerLabel.Name = "IdCustomerLabel";
            this.IdCustomerLabel.Size = new System.Drawing.Size(105, 25);
            this.IdCustomerLabel.TabIndex = 28;
            this.IdCustomerLabel.Text = "ID клієнта";
            // 
            // floor
            // 
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor.Location = new System.Drawing.Point(366, 308);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(100, 30);
            this.floor.TabIndex = 27;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(366, 267);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 30);
            this.price.TabIndex = 26;
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.area.Location = new System.Drawing.Point(366, 227);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 30);
            this.area.TabIndex = 25;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(366, 188);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(303, 30);
            this.address.TabIndex = 24;
            // 
            // district
            // 
            this.district.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.district.Location = new System.Drawing.Point(366, 150);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(303, 30);
            this.district.TabIndex = 23;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.Location = new System.Drawing.Point(366, 105);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(303, 30);
            this.city.TabIndex = 22;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(366, 64);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(303, 30);
            this.type.TabIndex = 21;
            // 
            // idCustomer
            // 
            this.idCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCustomer.FormattingEnabled = true;
            this.idCustomer.Location = new System.Drawing.Point(366, 23);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(121, 33);
            this.idCustomer.TabIndex = 20;
            // 
            // floorMax
            // 
            this.floorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorMax.Location = new System.Drawing.Point(569, 308);
            this.floorMax.Name = "floorMax";
            this.floorMax.Size = new System.Drawing.Size(100, 30);
            this.floorMax.TabIndex = 41;
            this.floorMax.Visible = false;
            // 
            // priceMax
            // 
            this.priceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMax.Location = new System.Drawing.Point(569, 267);
            this.priceMax.Name = "priceMax";
            this.priceMax.Size = new System.Drawing.Size(100, 30);
            this.priceMax.TabIndex = 40;
            this.priceMax.Visible = false;
            // 
            // areaMax
            // 
            this.areaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaMax.Location = new System.Drawing.Point(569, 227);
            this.areaMax.Name = "areaMax";
            this.areaMax.Size = new System.Drawing.Size(100, 30);
            this.areaMax.TabIndex = 39;
            this.areaMax.Visible = false;
            // 
            // areaMaxLabel
            // 
            this.areaMaxLabel.AutoSize = true;
            this.areaMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaMaxLabel.Location = new System.Drawing.Point(518, 230);
            this.areaMaxLabel.Name = "areaMaxLabel";
            this.areaMaxLabel.Size = new System.Drawing.Size(35, 25);
            this.areaMaxLabel.TabIndex = 42;
            this.areaMaxLabel.Text = "до";
            this.areaMaxLabel.Visible = false;
            // 
            // priceMaxLabel
            // 
            this.priceMaxLabel.AutoSize = true;
            this.priceMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceMaxLabel.Location = new System.Drawing.Point(518, 270);
            this.priceMaxLabel.Name = "priceMaxLabel";
            this.priceMaxLabel.Size = new System.Drawing.Size(35, 25);
            this.priceMaxLabel.TabIndex = 43;
            this.priceMaxLabel.Text = "до";
            this.priceMaxLabel.Visible = false;
            // 
            // floorMaxLabel
            // 
            this.floorMaxLabel.AutoSize = true;
            this.floorMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorMaxLabel.Location = new System.Drawing.Point(518, 311);
            this.floorMaxLabel.Name = "floorMaxLabel";
            this.floorMaxLabel.Size = new System.Drawing.Size(35, 25);
            this.floorMaxLabel.TabIndex = 44;
            this.floorMaxLabel.Text = "до";
            this.floorMaxLabel.Visible = false;
            // 
            // AddAdvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 542);
            this.Controls.Add(this.floorMaxLabel);
            this.Controls.Add(this.priceMaxLabel);
            this.Controls.Add(this.areaMaxLabel);
            this.Controls.Add(this.floorMax);
            this.Controls.Add(this.priceMax);
            this.Controls.Add(this.areaMax);
            this.Controls.Add(this.information);
            this.Controls.Add(this.add);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.floorLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.IdCustomerLabel);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.price);
            this.Controls.Add(this.area);
            this.Controls.Add(this.address);
            this.Controls.Add(this.district);
            this.Controls.Add(this.city);
            this.Controls.Add(this.type);
            this.Controls.Add(this.idCustomer);
            this.Name = "AddAdvert";
            this.Text = "Додавання нерухомості";
            this.Load += new System.EventHandler(this.AddAdvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox information;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label IdCustomerLabel;
        private System.Windows.Forms.TextBox floor;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.ComboBox idCustomer;
        private System.Windows.Forms.TextBox floorMax;
        private System.Windows.Forms.TextBox priceMax;
        private System.Windows.Forms.TextBox areaMax;
        private System.Windows.Forms.Label areaMaxLabel;
        private System.Windows.Forms.Label priceMaxLabel;
        private System.Windows.Forms.Label floorMaxLabel;
    }
}