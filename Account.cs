using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Realtor
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();

        }
        public bool isRealtor;
        private bool isChangeRealtor;
        private int id = 0;
        private string first_name;
        private string middle_name;
        private string last_name;
        private string email;
        private string phone;
        private DataTable info;
        void HideAll()
        {
            termTitle.Visible = false;
            term.Visible = false;
            searchSupply.Visible = false;
            rental.Visible = false;
            supplyId.Visible = false;
            supplyIdLabel.Visible = false;
            demandId.Visible = false;
            title.Visible = false;
            customerID.Visible = false;
            idCustomer.Visible = false;
            firstName.Visible = false;
            middleName.Visible = false;
            lastName.Visible = false;
            emailText.Visible = false;
            phoneText.Visible = false;
            password.Visible = false;
            editInfo.Visible = false;
            logIn.Visible = false;
            register.Visible = false;
            registrationButton.Visible = false;
            informationTable.Visible = false;
            commission.Visible = false;
            commissionLabel.Visible = false;
            AddCustomer.Hide();
            contractIdLabel.Hide();
            print.Hide();
            idDemandLabel.Hide();

            emailText.Text = "Введіть пошту";
            phoneText.Text = "Введіть номер телефону";
            password.Text = "Введіть кодовий пароль";
            lastName.Text = "Прізвище";
            middleName.Text = "По-Батькові";
            firstName.Text = "Ім'я";
            commission.Text = "";
            supplyId.Text = "";
            demandId.Text = "";

            firstName.ForeColor = Color.Gray;
            middleName.ForeColor = Color.Gray;
            lastName.ForeColor = Color.Gray;
            password.ForeColor = Color.Gray;
            emailText.ForeColor = Color.Gray;
            phoneText.ForeColor = Color.Gray;

        }
        private void Account_Load(object sender, EventArgs e)
        {
            emailText.Text = "Введіть пошту";
            phoneText.Text = "Введіть номер телефону";
            password.Text = "Введіть кодовий пароль";
            lastName.Text = "Прізвище";
            middleName.Text = "По-Батькові";
            firstName.Text = "Ім'я";

            firstName.ForeColor = Color.Gray;
            middleName.ForeColor = Color.Gray;
            lastName.ForeColor = Color.Gray;
            password.ForeColor = Color.Gray;
            emailText.ForeColor = Color.Gray;
            phoneText.ForeColor = Color.Gray;

            if (!isRealtor)
            {
                password.Visible = false;
                register.Visible = false;
                клієнтиToolStripMenuItem.Visible = false;
                розрахунокToolStripMenuItem.Visible = false;
            }


        }
        private void logIn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            if (isRealtor)
            {
                if (password.Text == "RealtorAdmin")
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Realtor WHERE email = @email AND phone = @phone", db.getConnection());

                    command.Parameters.AddWithValue("email", emailText.Text);
                    command.Parameters.AddWithValue("phone", phoneText.Text);

                    db.OpenConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Невірний пароль");
                    return;
                }
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE email = @email AND phone = @phone", db.getConnection());

                command.Parameters.AddWithValue("email", emailText.Text);
                command.Parameters.AddWithValue("phone", phoneText.Text);

                db.OpenConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();
            }

            if (table.Rows.Count == 1)
            {

                if (isRealtor)
                {
                    id = table.Rows[0].Field<int>("realtor_id");
                }
                else id = table.Rows[0].Field<int>("customer_id");

                first_name = table.Rows[0].Field<string>("first_name");
                middle_name = table.Rows[0].Field<string>("middle_name");
                last_name = table.Rows[0].Field<string>("last_name");
                email = table.Rows[0].Field<string>("email");
                phone = table.Rows[0].Field<string>("phone");
                customerEmail.Text = email;

                menuStrip1.Visible = true;
                HideAll();
                if (!isRealtor)
                {
                    клієнтToolStripMenuItem.Visible = false;
                    клієнтToolStripMenuItem1.Visible = false;
                }

            }
            else MessageBox.Show("Невірні данні");
        }
        private void emailText_Enter(object sender, EventArgs e)
        {
            if (emailText.Text == "Введіть пошту")
            {
                emailText.Text = "";
                emailText.ForeColor = Color.Black;
            }
        }
        private void emailText_Leave(object sender, EventArgs e)
        {
            if (emailText.Text == "")
            {
                emailText.Text = "Введіть пошту";
                emailText.ForeColor = Color.Gray;
            }
            else if (title.Text == "Реєстрація")
            {
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT * FROM Realtor WHERE email = @email", db.getConnection());

                command.Parameters.AddWithValue("email", emailText.Text);

                db.OpenConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Данний email вже використовується");
                }

            }
        }
        private void phoneText_Enter(object sender, EventArgs e)
        {
            if (phoneText.Text == "Введіть номер телефону")
            {
                phoneText.Text = "";
                phoneText.ForeColor = Color.Black;
            }
        }
        private void phoneText_Leave(object sender, EventArgs e)
        {
            if (phoneText.Text == "")
            {
                phoneText.Text = "Введіть номер телефону";
                phoneText.ForeColor = Color.Gray;
            }
            else if (title.Text == "Реєстрація")
            {
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT * FROM Realtor WHERE phone = @phone", db.getConnection());

                command.Parameters.AddWithValue("phone", phoneText.Text);

                db.OpenConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Данний номер вже використовується");
                }
            }
        }
        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введіть кодовий пароль";
                password.ForeColor = Color.Gray;
            }
        }
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введіть кодовий пароль")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }
        private void register_MouseEnter(object sender, EventArgs e)
        {
            register.ForeColor = Color.Blue;
        }
        private void register_MouseLeave(object sender, EventArgs e)
        {
            register.ForeColor = Color.Black;
        }
        private void register_Click(object sender, EventArgs e)
        {
            title.Text = "Реєстрація";
            lastName.Text = "Прізвище";
            middleName.Text = "По-Батькові";
            firstName.Text = "Ім'я";

            firstName.ForeColor = Color.Gray;
            middleName.ForeColor = Color.Gray;
            lastName.ForeColor = Color.Gray;

            lastName.Visible = true;
            firstName.Visible = true;
            middleName.Visible = true;
            registrationButton.Visible = true;
            logIn.Visible = false;
            register.Visible = false;
        }
        private void lastName_Enter(object sender, EventArgs e)
        {
            if (lastName.Text == "Прізвище")
            {
                lastName.Text = "";
                lastName.ForeColor = Color.Black;
            }
        }
        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text == "")
            {
                lastName.Text = "Прізвище";
                lastName.ForeColor = Color.Gray;
            }
        }
        private void firstName_Enter(object sender, EventArgs e)
        {
            if (firstName.Text == "Ім'я")
            {
                firstName.Text = "";
                firstName.ForeColor = Color.Black;
            }
        }
        private void firstName_Leave(object sender, EventArgs e)
        {
            if (firstName.Text == "")
            {
                firstName.Text = "Ім'я";
                firstName.ForeColor = Color.Gray;
            }
        }
        private void middleName_Enter(object sender, EventArgs e)
        {
            if (middleName.Text == "По-Батькові")
            {
                middleName.Text = "";
                middleName.ForeColor = Color.Black;
            }
        }
        private void middleName_Leave(object sender, EventArgs e)
        {
            if (middleName.Text == "")
            {
                middleName.Text = "По-Батькові";
                middleName.ForeColor = Color.Gray;
            }
        }
        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (password.Text == "RealtorAdmin")
            {
                if (firstName.Text != "Ім'я" && middleName.Text != "По-Батькові" && lastName.Text != "Прізвище" && emailText.Text != "Введіть пошту" && phoneText.Text != "Введіть номер телефону")
                {
                    DB db = new DB();
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    SqlCommand command = new SqlCommand("SELECT * FROM Realtor WHERE email = @email OR phone = @phone", db.getConnection());

                    command.Parameters.AddWithValue("email", emailText.Text);
                    command.Parameters.AddWithValue("phone", phoneText.Text);

                    db.OpenConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    db.CloseConnection();

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Використовуйте унікальні email та номер телефону");
                    }
                    else if (table.Rows.Count == 0)
                    {
                        SqlCommand addRealtor = new SqlCommand("INSERT INTO Realtor (first_name, middle_name, last_name, phone, email) VALUES (@first_name, @middle_name, @last_name, @phone, @email)", db.getConnection());

                        addRealtor.Parameters.AddWithValue("first_name", firstName.Text);
                        addRealtor.Parameters.AddWithValue("middle_name", middleName.Text);
                        addRealtor.Parameters.AddWithValue("last_name", lastName.Text);
                        addRealtor.Parameters.AddWithValue("email", emailText.Text);
                        addRealtor.Parameters.AddWithValue("phone", phoneText.Text);

                        db.OpenConnection();
                        if (addRealtor.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Реєстрація успішна");

                            lastName.Visible = false;
                            firstName.Visible = false;
                            middleName.Visible = false;
                            registrationButton.Visible = false;
                            logIn.Visible = true;
                            register.Visible = true;
                        }
                        else MessageBox.Show("Помилка реєстрації");
                        db.CloseConnection();
                    }
                    
                }
                else MessageBox.Show("Заповніть всі поля");
                
            }else MessageBox.Show("Невірний пароль");
        }
        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
        }
        private void нерухомістьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditInfoSupply ei = new EditInfoSupply();
            ei.email = customerEmail.Text;
            ei.isRealtor = isRealtor;
            ei.ShowDialog();
        }
        private void оголошенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditInfoDemand ei = new EditInfoDemand();
            ei.email = customerEmail.Text;
            ei.isRealtor = isRealtor;
            ei.ShowDialog();
        }
        private void себеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();

            firstName.Text = first_name;
            middleName.Text = middle_name;
            lastName.Text = last_name;
            emailText.Text = email;
            phoneText.Text = phone;

            firstName.ForeColor = Color.Black;
            middleName.ForeColor = Color.Black;
            lastName.ForeColor = Color.Black;
            emailText.ForeColor = Color.Black;
            phoneText.ForeColor = Color.Black;

            customerEmail.Visible = true;
            lastName.Visible = true;
            firstName.Visible = true;
            middleName.Visible = true;
            emailText.Visible = true;
            phoneText.Visible = true;
            editInfo.Visible = true;

            isChangeRealtor = isRealtor;
        }
        private void клієнтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideAll();

            firstName.ForeColor = Color.Black;
            middleName.ForeColor = Color.Black;
            lastName.ForeColor = Color.Black;
            emailText.ForeColor = Color.Black;
            phoneText.ForeColor = Color.Black;

            customerEmail.Visible = true;
            idCustomer.Visible = true;
            customerID.Visible = true;
            lastName.Visible = true;
            firstName.Visible = true;
            middleName.Visible = true;
            emailText.Visible = true;
            phoneText.Visible = true;
            editInfo.Visible = true;

            isChangeRealtor = false;

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand($"SELECT Customer.* FROM Customer, Cooperation_contract WHERE Cooperation_contract.realtor_id = {id} AND Cooperation_contract.customer_id = Customer.customer_id", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();
            idCustomer.Items.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                idCustomer.Items.Add(table.Rows[i].Field<int>("customer_id").ToString());
                idCustomer.Text = table.Rows[i].Field<int>("customer_id").ToString();
                lastName.Text = table.Rows[i].Field<string>("last_name");
                middleName.Text = table.Rows[i].Field<string>("middle_name");
                firstName.Text = table.Rows[i].Field<string>("first_name");
                emailText.Text = table.Rows[i].Field<string>("email");
                phoneText.Text = table.Rows[i].Field<string>("phone");
            }
        }
        private void editInfo_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string commandString;
            string editID;

            if (isChangeRealtor)
            {
                commandString = "UPDATE [Realtor] SET [first_name] = @first_name, [middle_name] = @middle_name, [last_name] = @last_name, [phone] =@phone, [email] = @email WHERE [realtor_id] = @id";
                editID = id.ToString();

            }
            else
            {
                commandString = "UPDATE [Customer] SET [first_name] = @first_name, [middle_name] = @middle_name, [last_name] = @last_name, [phone] =@phone, [email] = @email WHERE [customer_id] = @id";

                if (isRealtor)
                {
                    editID = idCustomer.Text;
                }
                else editID = id.ToString();
            }

            SqlCommand update = new SqlCommand(commandString, db.getConnection());

            update.Parameters.AddWithValue("id", editID);
            update.Parameters.AddWithValue("first_name", firstName.Text);
            update.Parameters.AddWithValue("middle_name", middleName.Text);
            update.Parameters.AddWithValue("last_name", lastName.Text);
            update.Parameters.AddWithValue("phone", phoneText.Text);
            update.Parameters.AddWithValue("email", emailText.Text);

            db.OpenConnection();
            if (update.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Операція успішна");
            }
            else MessageBox.Show("Помилка операції");
        }
        private void idCustomer_TextChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand($"SELECT * FROM Customer WHERE customer_id = @customer_id", db.getConnection());
            command.Parameters.AddWithValue("customer_id", idCustomer.Text);

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            lastName.Text = table.Rows[0].Field<string>("last_name");
            middleName.Text = table.Rows[0].Field<string>("middle_name");
            firstName.Text = table.Rows[0].Field<string>("first_name");
            emailText.Text = table.Rows[0].Field<string>("email");
            phoneText.Text = table.Rows[0].Field<string>("phone");
        }
        private void нерухомістьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideAll();
            informationTable.Show();

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandString;

            if (isRealtor)
            {
                commandString = $"SELECT Supply.supply_id, Supply.type, Supply.city, Supply.district, Supply.address, Supply.area, Supply.price, Supply.floor, Supply.information, (Customer.first_name + ' ' + Customer.middle_name + ' ' + Customer.last_name) AS N'Власник', Supply.relevance FROM Supply, Customer, Cooperation_contract WHERE Cooperation_contract.realtor_id = {id} AND Cooperation_contract.customer_id = Customer.customer_id AND Supply.landlord_id = Customer.customer_id";
            }
            else commandString = $"SELECT Supply.type, Supply.city, Supply.district, Supply.address, Supply.area, Supply.price, Supply.floor, Supply.information, (Customer.first_name + ' ' + Customer.middle_name + ' ' + Customer.last_name) AS N'Власник', Supply.relevance FROM Supply, Customer WHERE Supply.landlord_id = Customer.customer_id AND Customer.customer_id = {id}";

            SqlCommand command = new SqlCommand(commandString, db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationTable.DataSource = table;
        }
        private void оголошенняПошукуToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            HideAll();
            informationTable.Show();
            demandId.Show();
            searchSupply.Show();
            idDemandLabel.Show();

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandString;

            if (isRealtor)
            {
                commandString = $"SELECT Demand.demand_id, Demand.type, Demand.city, Demand.district, Demand.area_min, Demand.area_max, Demand.price_min, Demand.price_max, Demand.floor_min, Demand.floor_max, (Customer.first_name + ' ' + Customer.middle_name + ' ' + Customer.last_name) AS N'Орендар', Demand.relevance FROM Demand, Customer, Cooperation_contract WHERE Cooperation_contract.realtor_id = {id} AND Cooperation_contract.customer_id = Customer.customer_id AND Demand.tenant_id = Customer.customer_id ORDER BY relevance DESC";
            }
            else commandString = $"SELECT Demand.demand_id, Demand.type, Demand.city, Demand.district, Demand.area_min, Demand.area_max, Demand.price_min, Demand.price_max, Demand.floor_min, Demand.floor_max, (Customer.first_name + ' ' + Customer.middle_name + ' ' + Customer.last_name) AS N'Орендар', Demand.relevance FROM Demand, Customer WHERE Demand.tenant_id = Customer.customer_id AND Customer.customer_id = {id} ORDER BY relevance DESC";

            SqlCommand command = new SqlCommand(commandString, db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationTable.DataSource = table;

            demandId.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                demandId.Items.Add(table.Rows[i].Field<int>("demand_id").ToString());
            }
        }
        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationTable.Show();

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand($"SELECT Customer.* FROM Customer, Cooperation_contract WHERE Customer.customer_id = Cooperation_contract.customer_id AND Cooperation_contract.realtor_id = {id}", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationTable.DataSource = table;
        }
        private void searchSupply_Click(object sender, EventArgs e)
        {
            supplyId.Show();
            supplyIdLabel.Show();
            rental.Show();
            termTitle.Show();
            term.Show();
            commission.Show();
            commissionLabel.Show();

            DB db = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable supply = new DataTable();

            SqlCommand search = new SqlCommand($"SELECT Supply.*  FROM Supply, Demand WHERE Supply.type = Demand.type AND Supply.city = Demand.city AND Supply.district = Demand.district AND Supply.area BETWEEN area_min AND area_max AND Supply.price BETWEEN price_min AND price_max AND Supply.floor BETWEEN floor_min AND floor_max AND Supply.relevance = 1 AND demand_id = @id", db.getConnection());
            search.Parameters.AddWithValue("id", demandId.Text);

            db.OpenConnection();
            adapter.SelectCommand = search;
            adapter.Fill(supply);
            db.CloseConnection();

            supplyId.Items.Clear();

            for(int i = 0; i < supply.Rows.Count; i++)
            {
                supplyId.Items.Add(supply.Rows[0].Field<int>("supply_id").ToString());
            }
            informationTable.DataSource = supply;

            if (isRealtor)
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter2 = new SqlDataAdapter();

                SqlCommand command = new SqlCommand($"SELECT Cooperation_contract.customer_id FROM Cooperation_contract WHERE Cooperation_contract.realtor_id = {id}", db.getConnection());

                db.OpenConnection();
                adapter2.SelectCommand = command;
                adapter2.Fill(table);
                db.CloseConnection();
                idCustomer.Items.Clear();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    idCustomer.Items.Add(table.Rows[i].Field<int>("customer_id").ToString());
                }
            }
            else
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter2 = new SqlDataAdapter();

                SqlCommand command = new SqlCommand($"SELECT Cooperation_contract.realtor_id FROM Cooperation_contract WHERE Cooperation_contract.customer_id = {id}", db.getConnection());

                db.OpenConnection();
                adapter2.SelectCommand = command;
                adapter2.Fill(table);
                db.CloseConnection();
                idCustomer.Items.Clear();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    idCustomer.Items.Add(table.Rows[i].Field<int>("realtor_id").ToString());
                }
            }

        }
        private void rental_Click(object sender, EventArgs e)
        {
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
                    command = $"INSERT INTO Rental_contract (supply_id, tenant_id, realtor_id, realtors_commission, term, total_price, date) VALUES ({supplyId.Text}, (SELECT tenant_id FROM Demand WHERE demand_id = {demandId.Text}), {id}, {commission.Text}, {term.Text}, {totalPrice} ,@date)";
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
                    SqlCommand updateDemand = new SqlCommand($"UPDATE Demand SET relevance = 0 WHERE demand_id = {demandId.Text}", db.getConnection());

                    if ((updateSupply.ExecuteNonQuery() + updateDemand.ExecuteNonQuery()) == 2)
                    {
                        string Realtor = "";
                        string Tenant = ""; 

                        if (isRealtor)
                        {
                            Realtor = $"{last_name} {first_name} {middle_name}";
                        }
                        else 
                        {
                            Tenant = $"{last_name} {first_name} {middle_name}";
                        }

                        SqlDataAdapter landlordAdapter = new SqlDataAdapter();
                        DataTable tableLandlord = new DataTable();
                        SqlCommand landlord = new SqlCommand($"SELECT (Customer.last_name + ' ' + Customer.first_name + ' ' + Customer.middle_name) AS 'Landlord', Supply.city, Supply.type, Supply.address  FROM Customer, Supply WHERE Customer.customer_id = Supply.landlord_id AND supply_id = {supplyId.Text}", db.getConnection());

                        db.OpenConnection();
                        landlordAdapter.SelectCommand = landlord;
                        landlordAdapter.Fill(tableLandlord);
                        db.CloseConnection();

                        string Landlord = tableLandlord.Rows[0].Field<string>("Landlord");
                        string address = tableLandlord.Rows[0].Field<string>("address");
                        string type = tableLandlord.Rows[0].Field<string>("type");
                        string city = tableLandlord.Rows[0].Field<string>("city");

                        Contract rentalContract = new Contract();
                        rentalContract.RentalContract(Landlord, Tenant, Realtor, city, address, type, term.Text, totalPrice.ToString(), today.ToShortDateString(), commission.Text);

                        MessageBox.Show("Операція успішна. Файл договору оренди знаходиться у папці Program");
                    }
                }
                else { MessageBox.Show("Помилка операції"); }
                db.CloseConnection();
            }
            else MessageBox.Show("Заповніть всі поля");
        }
        private void клієнтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();

            title.Text = "Додавання клієнта";

            lastName.Visible = true;
            firstName.Visible = true;
            middleName.Visible = true;
            emailText.Visible = true;
            phoneText.Visible = true;
            AddCustomer.Visible = true;

        }
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            if (firstName.Text != "Ім'я" && middleName.Text != "По-Батькові" && lastName.Text != "Прізвище" && emailText.Text != "Введіть пошту" && phoneText.Text != "Введіть номер телефону")
            {
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE email = @email OR phone = @phone", db.getConnection());

                command.Parameters.AddWithValue("email", emailText.Text);
                command.Parameters.AddWithValue("phone", phoneText.Text);

                db.OpenConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Використовуйте унікальні email та номер телефону");
                }
                else if (table.Rows.Count == 0)
                {
                    SqlCommand addCustomer = new SqlCommand("INSERT INTO Customer (first_name, middle_name, last_name, phone, email) VALUES (@first_name, @middle_name, @last_name, @phone, @email)", db.getConnection());

                    addCustomer.Parameters.AddWithValue("first_name", firstName.Text);
                    addCustomer.Parameters.AddWithValue("middle_name", middleName.Text);
                    addCustomer.Parameters.AddWithValue("last_name", lastName.Text);
                    addCustomer.Parameters.AddWithValue("email", emailText.Text);
                    addCustomer.Parameters.AddWithValue("phone", phoneText.Text);

                    db.OpenConnection();
                    if (addCustomer.ExecuteNonQuery() == 1)
                    {
                        SqlCommand selectId = new SqlCommand("SELECT customer_id FROM Customer WHERE email = @email AND phone = @phone", db.getConnection());

                        selectId.Parameters.AddWithValue("email", emailText.Text);
                        selectId.Parameters.AddWithValue("phone", phoneText.Text);

                        adapter.SelectCommand = selectId;
                        adapter.Fill(table);

                        int addId = table.Rows[0].Field<int>("customer_id");

                        string nameContract = "contract" + Convert.ToInt32(addId);

                        DateTime today = DateTime.Today;

                        SqlCommand addContract = new SqlCommand($"INSERT INTO Cooperation_contract (customer_id, realtor_id, date) VALUES ({addId}, {id}, @today)", db.getConnection());
                        addContract.Parameters.AddWithValue("today", today);


                        if (addContract.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Операція успішна");
                        }
                        else 
                        {
                            SqlCommand deleteCustomer = new SqlCommand($"DELETE FROM Customer WHERE customer_id = {addId}", db.getConnection());
                            deleteCustomer.ExecuteNonQuery();
                        }
                    }
                    else MessageBox.Show("Помилка операції");

                    db.CloseConnection();

                }
                else MessageBox.Show("Заповніть всі поля");
            }
        }
        private void нерухомістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdvert form = new AddAdvert();

            form.isRealtor = isRealtor;
            form.isSupply = true;
            form.id = id;
            form.ShowDialog();
        }
        private void оголошенняПошукуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdvert form = new AddAdvert();

            form.isRealtor = isRealtor;
            form.isSupply = false;
            form.id = id;
            form.ShowDialog(); 
        }
        private void орендиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationTable.Show();
            title.Text = "Договори оренди";
            title.Show();
            supplyId.Items.Clear();
            supplyId.Show();
            print.Show();
            contractIdLabel.Show();

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandString;
            if (isRealtor)
            {
                commandString = $"SELECT Rental_contract.contract_id, (T.last_name + ' ' + T.first_name + ' ' + T.middle_name) AS 'Орендар', (L.last_name + ' ' + L.first_name + ' ' + L.middle_name) AS 'Орендодавець', (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Рієлтор', Rental_contract.term, Rental_contract.total_price, Rental_contract.realtors_commission, Rental_contract.date FROM Rental_contract, Customer AS T, Customer AS L, Realtor, Supply WHERE Rental_contract.realtor_id = {id} AND Rental_contract.realtor_id = Realtor.realtor_id AND T.customer_id = Rental_contract.tenant_id AND Rental_contract.supply_id = Supply.supply_id AND Supply.landlord_id = L.customer_id";
            }
            else
            {
                commandString = $"SELECT Rental_contract.contract_id, (T.last_name + ' ' + T.first_name + ' ' + T.middle_name) AS 'Орендар', (L.last_name + ' ' + L.first_name + ' ' + L.middle_name) AS 'Орендодавець', (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Рієлтор', Rental_contract.term, Rental_contract.total_price, Rental_contract.realtors_commission, Rental_contract.date FROM Rental_contract, Customer AS T, Customer AS L, Realtor, Supply WHERE Rental_contract.realtor_id = Realtor.realtor_id AND T.customer_id = Rental_contract.tenant_id AND Rental_contract.supply_id = Supply.supply_id AND Supply.landlord_id = L.customer_id AND (L.customer_id = {id} OR T.customer_id = {id})";
            }
            SqlCommand command = new SqlCommand(commandString, db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationTable.DataSource = table;
            info = table;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                supplyId.Items.Add(table.Rows[i].Field<int>("contract_id").ToString());
            }
        }
        private void співпраціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationTable.Show();
            title.Text = "Договори співпраці";
            title.Show();
            supplyId.Items.Clear();
            supplyId.Show();
            print.Show();
            contractIdLabel.Show();

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandString;

            if (isRealtor)
            {
                commandString = $"SELECT Cooperation_contract.contract_id, (Customer.last_name + ' ' + Customer.first_name + ' ' + Customer.middle_name) AS 'Клієнт', (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Рієлтор', Cooperation_contract.date FROM Cooperation_contract, Realtor, Customer WHERE Cooperation_contract.realtor_id = {id} AND Cooperation_contract.realtor_id = Realtor.realtor_id AND Cooperation_contract.customer_id = Customer.customer_id";
            }
            else
            {
                commandString = $"SELECT Cooperation_contract.contract_id, (Customer.last_name + ' ' + Customer.first_name + ' ' + Customer.middle_name) AS 'Клієнт', (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Рієлтор', Cooperation_contract.date FROM Cooperation_contract, Realtor, Customer WHERE Cooperation_contract.customer_id = {id} AND Cooperation_contract.realtor_id = Realtor.realtor_id AND Cooperation_contract.customer_id = Customer.customer_id";
            }
            SqlCommand command = new SqlCommand(commandString, db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationTable.DataSource = table;
            info = table;

            for(int i = 0; i < table.Rows.Count; i++)
            {
                supplyId.Items.Add(table.Rows[i].Field<int>("contract_id"));
            }
        }
        private void print_Click(object sender, EventArgs e)
        {
            int contract_id = Convert.ToInt32(supplyId.Text);
            
            for(int i = 0; i < info.Rows.Count; i++)
            {
                if(info.Rows[i].Field<int>("contract_id") == contract_id)
                {
                    if (title.Text == "Договори оренди")
                    {
                        DB db = new DB();
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        SqlCommand command = new SqlCommand($"SELECT (T.last_name + ' ' + T.first_name + ' ' + T.middle_name) AS 'Tenant', (L.last_name + ' ' + L.first_name + ' ' + L.middle_name) AS 'Landlord', (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Realtor', Rental_contract.term, Rental_contract.total_price, Rental_contract.realtors_commission, Rental_contract.date, Supply.city, Supply.address, Supply.type FROM Rental_contract, Customer AS T, Customer AS L, Realtor, Supply WHERE Rental_contract.realtor_id = Realtor.realtor_id AND T.customer_id = Rental_contract.tenant_id AND Rental_contract.supply_id = Supply.supply_id AND Supply.landlord_id = L.customer_id AND Rental_contract.contract_id = {contract_id}", db.getConnection());

                        db.OpenConnection();
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        db.CloseConnection();

                        string Landlord = table.Rows[0].Field<string>("Landlord");
                        string Tenant = table.Rows[0].Field<string>("Tenant");
                        string Realtor = table.Rows[0].Field<string>("Realtor");
                        string city = table.Rows[0].Field<string>("city");
                        string address = table.Rows[0].Field<string>("address");
                        string type = table.Rows[0].Field<string>("type");
                        string term = table.Rows[0].Field<int>("term").ToString();
                        string totalPrice = table.Rows[0].Field<int>("total_price").ToString();
                        string date = table.Rows[0].Field<DateTime>("date").ToShortDateString();
                        string realtors_commision = table.Rows[0].Field<int>("realtors_commission").ToString();

                        Contract cooperation = new Contract();
                        cooperation.RentalContract(Landlord, Tenant, Realtor, city, address, type, term, totalPrice, date, realtors_commision);
                        MessageBox.Show("Копія договору успішно отримано. Файл знаходиться у папці Program");
                    }
                    else if (title.Text == "Договори співпраці")
                    {
                        Contract cooperation = new Contract();
                        cooperation.CooperationContract(info.Rows[i].Field<string>("Клієнт"), info.Rows[i].Field<string>("Рієлтор"), info.Rows[i].Field<DateTime>("date").ToShortDateString());
                        MessageBox.Show("Копія договору успішно отримано. Файл знаходиться у папці Program");
                    }
                }
            }
        }
        private void розрахунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationTable.Show();

            DateTime today = DateTime.Today;

            DB db = new DB();
            DataTable tableOfCooperation = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand cooperation = new SqlCommand($"SELECT (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Рієлтор', COUNT(Cooperation_contract.contract_id) AS 'Кількість договір співпраці за місяць', " +
                $"(SELECT COUNT(Rental_contract.contract_id) FROM Realtor AS R1, Rental_contract WHERE R1.realtor_id = Realtor.realtor_id AND R1.realtor_id = Rental_contract.realtor_id AND ((DAY(date) > {today.Day} AND MONTH(date) = {today.Month} - 1) OR (DAY(date) <= {today.Day} AND MONTH(date) = {today.Month}))) AS 'Кількість договорв оренди за місяць', " +
                $"(SELECT SUM((total_price * realtors_commission)/(term*100)) FROM Realtor AS R2, Rental_contract WHERE R2.realtor_id = Realtor.realtor_id AND R2.realtor_id = Rental_contract.realtor_id AND ((DAY(date) > {today.Day} AND MONTH(date) = {today.Month} - 1) OR (DAY(date) <= {today.Day} AND MONTH(date) = {today.Month}))) AS 'Загальна сума комісій' " + 
                $"FROM Realtor, Cooperation_contract WHERE Realtor.realtor_id = Cooperation_contract.realtor_id AND ((DAY(date) > {today.Day} AND MONTH(date) = {today.Month} - 1) OR (DAY(date) <= {today.Day} AND MONTH(date) = {today.Month})) GROUP BY Realtor.realtor_id, Realtor.last_name, Realtor.first_name, Realtor.middle_name", db.getConnection());
            
            db.OpenConnection();
            adapter.SelectCommand = cooperation;
            adapter.Fill(tableOfCooperation);
            db.CloseConnection();

            informationTable.DataSource = tableOfCooperation;

            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wst = (Excel.Worksheet)exApp.ActiveSheet;

            for(int i = 0; i <= informationTable.RowCount-2; i++)
            {
                for (int j = 0; j <= informationTable.ColumnCount - 1; j++)
                {
                    wst.Cells[1, j + 1] = informationTable.Columns[j].HeaderText.ToString();
                    wst.Cells[i + 2, j + 1] = informationTable[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search form = new Search();
            form.isRealtor = isRealtor;
            form.id = id;
            form.ShowDialog();
        }

        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "GmailApp";
        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
        private void перевіркаАктуальностіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();


            SqlCommand command = new SqlCommand("SELECT C1.email AS 'emailTenant', (C1.last_name + ' ' + C1.first_name + ' ' + C1.middle_name) AS 'Tenant', C2.email AS 'emailLandlord', (C2.last_name + ' ' + C2.first_name + ' ' + C2.middle_name) AS 'Landlord', Realtor.email AS 'emailRealtor', (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Realtor', Rental_contract.* FROM Rental_contract, Customer AS C1, Customer AS C2, Supply, Realtor WHERE C1.customer_id = Rental_contract.tenant_id AND Rental_contract.supply_id = Supply.supply_id AND Supply.landlord_id = C2.customer_id AND Rental_contract.realtor_id = Realtor.realtor_id", db.getConnection());
            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            DateTime today = DateTime.Today;
            DateTime date;
            int term, month, year;
            string emailRealtor = "", emailTenant, emailLandlord, realtor, tenant, landlord, toEmail = "artem.fomychov@nure.ua";

            for (int i = 0; i < table.Rows.Count; i++)
            {
                term = table.Rows[i].Field<int>("term");
                date = table.Rows[i].Field<DateTime>("date");

                year = date.Year + (term - (term % 12)) / 12;
                month = date.Month + (term % 12);
                if (month > 12)
                {
                    month -= 12;
                    year++;
                }

                if((today.Month == month && today.Year == year) || (date.Date <= today.Date && today.Month == month - 1 && today.Year == year) || (date.Date <= today.Date && today.Month == 12 && month == 1 && today.Year == year - 1))
                {
                    emailRealtor = table.Rows[i].Field<string>("emailRealtor");
                    emailTenant = table.Rows[i].Field<string>("emailTenant");
                    emailLandlord = table.Rows[i].Field<string>("emailLandlord");
                    realtor = table.Rows[i].Field<string>("Realtor");
                    tenant = table.Rows[i].Field<string>("Tenant");
                    landlord = table.Rows[i].Field<string>("Landlord");

                    UserCredential credential;

                    using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                        path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
                    }

                    //Замість toEmail потрібно вставити emailRealtor, emailTenant, emailLandlord у відповідні повідомлення

                    string messageToRealtor = $"To: {toEmail}\r\nSubject: Lease term ends \r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>Закінчується термін оренди комерційної нерухомості, яка належить {landlord}, Зверність стосовно подовження оренди до власника нерухомості {landlord} {emailLandlord} та орендаря {tenant} {emailTenant}</h2>";
                    string messageToLandlord = $"To: {toEmail}\r\nSubject: Lease term ends \r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>Закінчується термін оренди комерційної нерухомості орендарем {tenant}, для подовження оренди зверніться до рієлтора {realtor} email {emailRealtor}</h2>";
                    string messageToTenant = $"To: {toEmail}\r\nSubject: Lease term ends \r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h2>Закінчується термін оренди комерційної нерухомості, яка належить {landlord}, для подовження оренди зверніться до рієлтора {realtor} email {emailRealtor}</h2>";

                    
                    var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
                    
                    //Відправка листа рієлтору
                    var msgToRealtor = new Google.Apis.Gmail.v1.Data.Message();
                    msgToRealtor.Raw = Base64UrlEncode(messageToRealtor.ToString());
                    //service.Users.Messages.Send(msgToRealtor, "me").Execute();

                    //Відправка листа орендодатору
                    var msgToLandlord = new Google.Apis.Gmail.v1.Data.Message();
                    msgToLandlord.Raw = Base64UrlEncode(messageToLandlord.ToString());
                    service.Users.Messages.Send(msgToLandlord, "me").Execute();

                    //Відправка листа орендарю
                    var msgToTenant = new Google.Apis.Gmail.v1.Data.Message();
                    msgToTenant.Raw = Base64UrlEncode(messageToTenant.ToString());
                    //service.Users.Messages.Send(msgToTenant, "me").Execute();

                    MessageBox.Show($"Успішна відправка листів рієлтору {realtor}, орендодатору {landlord} та орендарю {tenant}", "Операція успішна", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }

            if(emailRealtor == "")
            {
                MessageBox.Show("Жоден термін оренди не спливає протягом місяця");
            }
        }
    }
}
