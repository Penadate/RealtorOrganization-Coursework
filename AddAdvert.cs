using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtor
{
    public partial class AddAdvert : Form
    {
        public AddAdvert()
        {
            InitializeComponent();
        }
        public int id;
        public bool isSupply;
        public bool isRealtor;

        private void AddAdvert_Load(object sender, EventArgs e)
        {
            if (isRealtor)
            {
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand($"SELECT Customer.* FROM Customer, Cooperation_contract WHERE Cooperation_contract.realtor_id = {id} AND Cooperation_contract.customer_id = Customer.customer_id", db.getConnection());

                db.OpenConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();
                idCustomer.Text = table.Rows[0].Field<int>("customer_id").ToString();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    idCustomer.Items.Add(table.Rows[i].Field<int>("customer_id").ToString());
                }
            }
            else
            {
                IdCustomerLabel.Hide();
                idCustomer.Hide();
            }
            if (!isSupply)
            {
                this.Text = "Додавання оголошення пошуку";
                areaLabel.Text += " від";
                priceLabel.Text += " від";
                floorLabel.Text += " від";
                infoLabel.Hide();
                information.Hide();
                addressLabel.Hide();
                address.Hide();
                areaMaxLabel.Show();
                areaMax.Show();
                floorMaxLabel.Show();
                floorMax.Show();
                priceMaxLabel.Show();
                priceMax.Show();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            if (isSupply)
            {
                if (type.Text != "" && city.Text != "" && district.Text != "" && area.Text != "" && price.Text != "" && floor.Text != "")
                {
                    if (isRealtor)
                    {
                        if (idCustomer.Text != null && idCustomer.Text != "")
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO Supply (type, city, district, address, area, price, floor, landlord_id, information, relevance) VALUES (@type, @city, @district, @address, @area, @price, @floor, @landlord_id, @information, 1)", db.getConnection());

                            command.Parameters.AddWithValue("type", type.Text);
                            command.Parameters.AddWithValue("city", city.Text);
                            command.Parameters.AddWithValue("district", district.Text);
                            command.Parameters.AddWithValue("address", address.Text);
                            command.Parameters.AddWithValue("area", area.Text);
                            command.Parameters.AddWithValue("price", price.Text);
                            command.Parameters.AddWithValue("floor", floor.Text);
                            command.Parameters.AddWithValue("landlord_id", idCustomer.Text);
                            command.Parameters.AddWithValue("information", information.Text);

                            db.OpenConnection();
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Операція успішна");
                            }
                            else MessageBox.Show("Помилка операції");
                            db.CloseConnection();
                        }
                        else MessageBox.Show("Оберіть клієнта");
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO Supply (type, city, district, address, area, price, floor, landlord_id, information, relevance) VALUES (@type, @city, @district, @address, @area, @price, @floor, @landlord_id, @information, 1)", db.getConnection());

                        command.Parameters.AddWithValue("type", type.Text);
                        command.Parameters.AddWithValue("city", city.Text);
                        command.Parameters.AddWithValue("district", district.Text);
                        command.Parameters.AddWithValue("address", address.Text);
                        command.Parameters.AddWithValue("area", area.Text);
                        command.Parameters.AddWithValue("price", price.Text);
                        command.Parameters.AddWithValue("floor", floor.Text);
                        command.Parameters.AddWithValue("landlord_id", id);
                        command.Parameters.AddWithValue("information", information.Text);

                        db.OpenConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Операція успішна");
                        }
                        else MessageBox.Show("Помилка операції");
                        db.CloseConnection();
                    }
                }
                else MessageBox.Show("Заповніть всі поля");

            }
            else
            {
                if (type.Text != "" && city.Text != "" && district.Text != "" && area.Text != "" && areaMax.Text != "" && price.Text != "" && priceMax.Text != "" && floor.Text != "" && floorMax.Text != "")
                {
                    if (isRealtor)
                    {
                        if (idCustomer.Text != null && idCustomer.Text != "")
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO Demand (type, city, district, area_min, area_max, price_min, price_max, floor_min, floor_max, tenant_id, relevance) VALUES (@type, @city, @district, @area_min, @area_max, @price_min, @price_max, @floor_min, @floor_max, @tenant_id, 1)", db.getConnection());

                            command.Parameters.AddWithValue("type", type.Text);
                            command.Parameters.AddWithValue("city", city.Text);
                            command.Parameters.AddWithValue("district", district.Text);
                            command.Parameters.AddWithValue("area_min", area.Text);
                            command.Parameters.AddWithValue("area_max", areaMax.Text);
                            command.Parameters.AddWithValue("price_min", price.Text);
                            command.Parameters.AddWithValue("price_max", priceMax.Text);
                            command.Parameters.AddWithValue("floor_min", floor.Text);
                            command.Parameters.AddWithValue("floor_max", floorMax.Text);
                            command.Parameters.AddWithValue("tenant_id", idCustomer.Text);

                            db.OpenConnection();
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Операція успішна");
                            }
                            else MessageBox.Show("Помилка операції");
                            db.CloseConnection();
                        }
                        else MessageBox.Show("Оберіть клієнта");
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO Demand (type, city, district, area_min, area_max, price_min, price_max, floor_min, floor_max, tenant_id, relevance) VALUES (@type, @city, @district, @area_min, @area_max, @price_min, @price_max, @floor_min, @floor_max, @tenant_id, 1)", db.getConnection());

                        command.Parameters.AddWithValue("type", type.Text);
                        command.Parameters.AddWithValue("city", city.Text);
                        command.Parameters.AddWithValue("district", district.Text);
                        command.Parameters.AddWithValue("area_min", area.Text);
                        command.Parameters.AddWithValue("area_max", areaMax.Text);
                        command.Parameters.AddWithValue("price_min", price.Text);
                        command.Parameters.AddWithValue("price_max", priceMax.Text);
                        command.Parameters.AddWithValue("floor_min", floor.Text);
                        command.Parameters.AddWithValue("floor_max", floorMax.Text);
                        command.Parameters.AddWithValue("tenant_id", id);

                        db.OpenConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Операція успішна");
                        }
                        else MessageBox.Show("Помилка операції");
                        db.CloseConnection();
                    }
                }
                else MessageBox.Show("Заповніть всі поля");
            }
        }

    }
}
