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
    public partial class EditInfoSupply : Form
    {
        public EditInfoSupply()
        {
            InitializeComponent();
        }

        public string email;
        public bool isRealtor;
        private void EditInfoSupply_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandString;

            if (isRealtor)
            {
                commandString = "SELECT Supply.supply_id AS 'id' FROM Supply, Customer, Realtor, Cooperation_contract WHERE Cooperation_contract.realtor_id = Realtor.realtor_id AND Cooperation_contract.customer_id = Customer.customer_id AND Supply.landlord_id = Customer.customer_id AND Realtor.email = @email";
            }
            else commandString = "SELECT Supply.supply_id AS 'id' FROM Supply, Customer WHERE Supply.landlord_id = Customer.customer_id AND Customer.email = @email";

            SqlCommand command = new SqlCommand(commandString, db.getConnection()); 
            command.Parameters.AddWithValue("email", email);

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            for(int i = 0; i < table.Rows.Count; i++)
            {
                id.Items.Add(table.Rows[i].Field<int>("id").ToString());
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Supply WHERE supply_id = @supply_id", db.getConnection());
            command.Parameters.AddWithValue("supply_id", id.Text);

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            type.Text = table.Rows[0].Field<string>("type");
            city.Text = table.Rows[0].Field<string>("city");
            district.Text = table.Rows[0].Field<string>("district");
            address.Text = table.Rows[0].Field<string>("address");
            area.Text = table.Rows[0].Field<int>("area").ToString();
            price.Text = table.Rows[0].Field<int>("price").ToString();
            floor.Text = table.Rows[0].Field<int>("floor").ToString();
            information.Text = table.Rows[0].Field<string>("information");
            relevance.Checked = table.Rows[0].Field<bool>("relevance");
        }

        private void update_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlCommand update = new SqlCommand("UPDATE [Supply] SET [type] = @type, [city] = @city, [district] = @district, [address] =@address, [area] = @area, [price] = @price, [floor] = @floor, [information] = @information, [relevance] = @relevance WHERE [supply_id] = @supply_id", db.getConnection());

            update.Parameters.AddWithValue("supply_id", id.Text);
            update.Parameters.AddWithValue("type", type.Text);
            update.Parameters.AddWithValue("city", city.Text);
            update.Parameters.AddWithValue("district", district.Text);
            update.Parameters.AddWithValue("address", address.Text);
            update.Parameters.AddWithValue("area", area.Text);
            update.Parameters.AddWithValue("price", price.Text);
            update.Parameters.AddWithValue("floor", floor.Text);
            update.Parameters.AddWithValue("information", information.Text);
            update.Parameters.AddWithValue("relevance", relevance.Checked);

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
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand check = new SqlCommand("SELECT * FROM Rental_contract WHERE supply_id = @supply_id", db.getConnection());

            check.Parameters.AddWithValue("supply_id", id.Text);

            db.OpenConnection();
            adapter.SelectCommand = check;
            adapter.Fill(table);
            db.CloseConnection();

            if(table.Rows.Count > 0)
            {
                SqlCommand update = new SqlCommand("UPDATE [Supply] SET relevance = 0 WHERE supply_id = @supply_id", db.getConnection());
                update.Parameters.AddWithValue("supply_id", id.Text);

                db.OpenConnection();
                if (update.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Видалення нерухомості неможливе. Статус актуальності смінено на неактуальний");
                }
                else MessageBox.Show("Помилка операції");
                db.CloseConnection();

            }
            else
            {
                SqlCommand delete = new SqlCommand("DELETE FROM Supply WHERE supply_id = @supply_id", db.getConnection());
                delete.Parameters.AddWithValue("supply_id", id.Text);

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
}
