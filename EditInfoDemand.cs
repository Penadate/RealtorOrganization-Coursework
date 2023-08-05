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
    public partial class EditInfoDemand : Form
    {
        public EditInfoDemand()
        {
            InitializeComponent();
        }

        public string email;
        public bool isRealtor;

        private void EditInfoDemand_Load(object sender, EventArgs e)
        {
            {
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string commandString;

                if (isRealtor)
                {
                    commandString = "SELECT Demand.demand_id AS 'id' FROM Demand, Customer, Realtor, Cooperation_contract WHERE Cooperation_contract.realtor_id = Realtor.realtor_id AND Cooperation_contract.customer_id = Customer.customer_id AND Demand.tenant_id = Customer.customer_id AND Realtor.email = @email";
                }
                else commandString = "SELECT Demand.demand_id AS 'id' FROM Demand, Customer WHERE Demand.tenant_id = Customer.customer_id AND Customer.email = @email";

                SqlCommand command = new SqlCommand(commandString, db.getConnection());
                command.Parameters.AddWithValue("email", email);

                db.OpenConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    id.Items.Add(table.Rows[i].Field<int>("id").ToString());
                }
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Demand WHERE demand_id = @demand_id", db.getConnection());
            command.Parameters.AddWithValue("demand_id", id.Text);

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            type.Text = table.Rows[0].Field<string>("type");
            city.Text = table.Rows[0].Field<string>("city");
            district.Text = table.Rows[0].Field<string>("district");
            areaMin.Text = table.Rows[0].Field<int>("area_min").ToString();
            areaMax.Text = table.Rows[0].Field<int>("area_max").ToString();
            priceMin.Text = table.Rows[0].Field<int>("price_min").ToString();
            priceMax.Text = table.Rows[0].Field<int>("price_max").ToString();
            floorMin.Text = table.Rows[0].Field<int>("floor_min").ToString();
            floorMax.Text = table.Rows[0].Field<int>("floor_max").ToString();
            relavance.Checked = table.Rows[0].Field<bool>("relevance");
        }

        private void update_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand update = new SqlCommand("UPDATE [Demand] SET [type] = @type, [city] = @city, [district] = @district, [area_min] =@area_min, [area_max] = @area_max, [price_min] = @price_min, [price_max] = @price_max, [floor_min] = @floor_min, [floor_max] = @floor_max, [relevance] = @relevance WHERE [demand_id] = @demand_id", db.getConnection());

            update.Parameters.AddWithValue("demand_id", id.Text);
            update.Parameters.AddWithValue("type", type.Text);
            update.Parameters.AddWithValue("city", city.Text);
            update.Parameters.AddWithValue("district", district.Text);
            update.Parameters.AddWithValue("area_min", areaMin.Text);
            update.Parameters.AddWithValue("area_max", areaMax.Text);
            update.Parameters.AddWithValue("price_min", priceMin.Text);
            update.Parameters.AddWithValue("price_max", priceMax.Text);
            update.Parameters.AddWithValue("floor_min", floorMin.Text);
            update.Parameters.AddWithValue("floor_max", floorMax.Text);
            update.Parameters.AddWithValue("relevance", relavance.Checked);

            db.OpenConnection();
            if (update.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Операція успішна");
            }
            else MessageBox.Show("Помилка операції");
            db.CloseConnection();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand delete = new SqlCommand("DELETE FROM Demand WHERE [demand_id] = @demand_id", db.getConnection());

            delete.Parameters.AddWithValue("demand_id", id.Text);

            db.OpenConnection();
            if (delete.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Операція успішна");
            }
            else MessageBox.Show("Помилка операції");
            db.CloseConnection();
        }
    }
}
