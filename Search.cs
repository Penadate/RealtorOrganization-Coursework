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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public bool isRealtor;
        public int id;

        private void Search_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT supply_id AS 'ID нерухомості', type AS 'Тип', city AS 'Місто', district AS 'Район', address AS 'Адресс', area AS 'Площа', price AS 'Вартість', floor AS 'Поверх', information AS 'Додактова інформація', (first_name + ' ' + middle_name + ' ' + last_name) AS N'Власник' FROM Supply, Customer WHERE customer_id = landlord_id AND relevance = 1", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            resultTable.DataSource = table;

            if (isRealtor)
            {
                label4.Show();
                customerId.Show();

                DataTable idTable = new DataTable();
                SqlDataAdapter adapterCustomer = new SqlDataAdapter();
                SqlCommand customer = new SqlCommand($"SELECT customer_id FROM Cooperation_contract WHERE realtor_id = {id}", db.getConnection());

                db.OpenConnection();
                adapterCustomer.SelectCommand = customer;
                adapterCustomer.Fill(idTable);
                db.CloseConnection();

                for(int i = 0; i < idTable.Rows.Count; i++)
                {
                    customerId.Items.Add(idTable.Rows[i].Field<int>("customer_id").ToString());
                }
            }
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            string result = $"";

            if (type.Text != "")
            {
                result += $" Тип LIKE '%{type.Text}%'";
            }
            if (city.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Місто LIKE '%{city.Text}%'";
            }
            if (district.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Район LIKE '%{district.Text}%'";
            }
            if (areaMin.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Площа >= {areaMin.Text}";
            }
            if (floorMin.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Поверх >= {floorMin.Text}";
            }
            if (priceMin.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Вартість >= {priceMin.Text}";
            }
            if (areaMax.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Площа <= {areaMax.Text}";
            }
            if (floorMax.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Поверх <= {floorMax.Text}";
            }
            if (priceMax.Text != "")
            {
                if (result != "") { result += " AND"; }
                result += $" Вартість <= {priceMax.Text}";
            }

            try
            {
                (resultTable.DataSource as DataTable).DefaultView.RowFilter = result;
            } catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }


        }

        private void rental_Click(object sender, EventArgs e)
        {
            if (isRealtor && customerId.Text == "")
            {
                MessageBox.Show("Оберіть клієнта");
                return;
            }
            if (supplyId.Text != "" && commission.Text != "" && term.Text != "")
            {
                DB db = new DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand price = new SqlCommand($"SELECT Supply.price  FROM Supply WHERE supply_id = @id ", db.getConnection());
                price.Parameters.AddWithValue("id", supplyId.Text);

                db.OpenConnection();
                adapter.SelectCommand = price;
                adapter.Fill(table);
                db.CloseConnection();

                int totalPrice = table.Rows[0].Field<int>("price") * Convert.ToInt32(term.Text);

                DateTime today = DateTime.Today;

                string command;

                if (isRealtor)
                {
                    command = $"INSERT INTO Rental_contract (supply_id, tenant_id, realtor_id, realtors_commission, term, total_price, date) VALUES ({supplyId.Text}, {customerId.Text}, {id}, {commission.Text}, {term.Text}, {totalPrice} ,@date)";
                }
                else
                {
                    command = $"INSERT INTO Rental_contract (supply_id, tenant_id, realtor_id, realtors_commission, term, total_price, date) VALUES ({supplyId.Text}, {id}, (SELECT realtor_id FROM Cooperation_contract WHERE customer_id = {id}) {commission.Text}, {term.Text}, {totalPrice} ,@date)";
                }
                SqlCommand rental = new SqlCommand(command, db.getConnection());

                rental.Parameters.AddWithValue("date", today);

                db.OpenConnection();
                if (rental.ExecuteNonQuery() == 1)
                {
                    SqlCommand updateSupply = new SqlCommand($"UPDATE Supply SET relevance = 0 WHERE supply_id = {supplyId.Text}", db.getConnection());

                    if (updateSupply.ExecuteNonQuery() == 1)
                    {
                        SqlDataAdapter landlordAdapter = new SqlDataAdapter();
                        DataTable tableLandlord = new DataTable();
                        SqlCommand landlord = new SqlCommand($"SELECT (C1.last_name + ' ' + C1.first_name + ' ' + C1.middle_name) AS 'Tenant', (C2.last_name + ' ' + C2.first_name + ' ' + C2.middle_name) AS 'Landlord', (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Realtor', city, address, type FROM Customer AS C1, Customer AS C2, Realtor, Rental_contract, Supply WHERE Rental_contract.realtor_id = Realtor.realtor_Id AND Rental_contract.tenant_id = C1.customer_Id AND Rental_contract.supply_id = Supply.supply_Id AND C2.customer_Id = Supply.landlord_id AND Rental_contract.contract_id = (SELECT MAX(contract_id) FROM Rental_contract WHERE tenant_id = @id)", db.getConnection());

                        if (isRealtor)
                        {
                            landlord.Parameters.AddWithValue("id", customerId.Text);
                        }
                        else
                        {
                            landlord.Parameters.AddWithValue("id", id);
                        }
                        db.OpenConnection();
                        landlordAdapter.SelectCommand = landlord;
                        landlordAdapter.Fill(tableLandlord);
                        db.CloseConnection();

                        string Realtor = tableLandlord.Rows[0].Field<string>("Realtor");
                        string Tenant = tableLandlord.Rows[0].Field<string>("Tenant");
                        string Landlord = tableLandlord.Rows[0].Field<string>("Landlord");
                        string city = tableLandlord.Rows[0].Field<string>("city");
                        string address = tableLandlord.Rows[0].Field<string>("address");
                        string type = tableLandlord.Rows[0].Field<string>("type");

                        Contract rentalContract = new Contract();
                        rentalContract.RentalContract(Landlord, Tenant, Realtor, city, address, type, term.Text, totalPrice.ToString(), today.ToShortDateString(), commission.Text);

                        MessageBox.Show("Операція успішна. Файл договору оренди знаходиться у папці Program");

                        DataTable resetTable = new DataTable();
                        SqlDataAdapter resetAdapter = new SqlDataAdapter();
                        SqlCommand reset = new SqlCommand("SELECT supply_id AS 'ID нерухомості', type AS 'Тип', city AS 'Місто', district AS 'Район', address AS 'Адресс', area AS 'Площа', price AS 'Вартість', floor AS 'Поверх', information AS 'Додактова інформація', (first_name + ' ' + middle_name + ' ' + last_name) AS N'Власник' FROM Supply, Customer WHERE customer_id = landlord_id AND relevance = 1", db.getConnection());

                        db.OpenConnection();
                        resetAdapter.SelectCommand = reset;
                        resetAdapter.Fill(resetTable);
                        db.CloseConnection();

                        resultTable.DataSource = resetTable;
                    }
                }
                else { MessageBox.Show("Помилка операції"); }
                db.CloseConnection();
            }
            else MessageBox.Show("Заповніть всі поля");
        }
    }
}
