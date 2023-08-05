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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public bool isRealtor;
        private void HideAll()
        {
            informationView.Hide();
            QueryText.Hide();
            Clear.Hide();
            Run.Hide();

            title.Text = "";
            QueryText.Text = "SELECT";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            HideAll();

            HideAll();
            title.Text = "Нерухомість";
            informationView.Show();


            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT type, city, district, address, area, price, floor, information, (first_name + ' ' + middle_name + ' ' + last_name) AS N'Власник' FROM Supply, Customer WHERE customer_id = landlord_id AND relevance = 1", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }
        
        private void рієлторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account form = new Account();
            form.isRealtor = true;
            this.Hide();
            form.Show();
        }

        private void клієнтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account form = new Account();
            form.isRealtor = false;
            this.Hide();
            form.Show();
        }

        //Інформація
        private void рієлториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            title.Text = "Рієлтори";
            informationView.Show();

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT first_name + ' ' + middle_name + ' ' + last_name AS 'Рієлтор', phone AS 'Телефон', Email FROM Realtor", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }

        private void нерухомістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            title.Text = "Нерухомість";
            informationView.Show();


            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT type, city, district, address, area, price, floor, information, (first_name + ' ' + middle_name + ' ' + last_name) AS N'Власник' FROM Supply, Customer WHERE customer_id = landlord_id AND relevance = 1", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }

        private void оголошенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            title.Text = "Оголошення про пошук";
            informationView.Show();

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT type, city, district, area_min, area_max, price_min, price_max, floor_min, floor_max, (first_name + ' ' + middle_name + ' ' + last_name) AS N'Орендар' FROM Demand, Customer WHERE customer_id = tenant_id AND relevance = 1", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }

        //Рейтинг
        private void довільнийЗапитToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            QueryText.Show();
            Clear.Show();
            Run.Show();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            QueryText.Text = "SELECT";
            informationView.Hide();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand(QueryText.Text, db.getConnection());

                db.OpenConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();

                informationView.Show();
                informationView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error " + ex.Message);
            }
        }

        private void рієлторівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationView.Show();
            title.Text = "Рейтинг рієлторів";

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand($"SELECT (Realtor.last_name + ' ' + Realtor.first_name + ' ' + Realtor.middle_name) AS 'Рієлтор', COUNT(Cooperation_contract.contract_id) AS 'Кількість договір співпраці за місяць', (SELECT COUNT(Rental_contract.realtor_id) FROM Realtor AS R1, Rental_contract WHERE R1.realtor_id = Realtor.realtor_id AND R1.realtor_id = Rental_contract.realtor_id) AS 'Кількість договорів оренди' FROM Realtor, Cooperation_contract WHERE Realtor.realtor_id = Cooperation_contract.realtor_id GROUP BY Realtor.realtor_id, Realtor.last_name, Realtor.first_name, Realtor.middle_name ORDER BY COUNT(Cooperation_contract.contract_id) DESC", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }

        private void містаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationView.Show();
            title.Text = "Рейтинг міст за кількість нерухомості";

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT Supply.city AS 'Місто', COUNT(Supply.city) AS 'Кількість КН' FROM Supply GROUP BY Supply.city ORDER BY COUNT(Supply.city) DESC", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }

        private void місяціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationView.Show();
            title.Text = "Рейтинг місяців за кількістю оренд";

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT N'Січень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 1 " +
                "UNION SELECT N'Лютий' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 2 " +
                "UNION SELECT N'Березень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 3 " +
                "UNION SELECT N'Квітень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 4 " +
                "UNION SELECT N'Травень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 5 " +
                "UNION SELECT N'Червень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 6 " +
                "UNION SELECT N'Липень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 7 " +
                "UNION SELECT N'Серпень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 8 " +
                "UNION SELECT N'Вересень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 9 " +
                "UNION SELECT N'Жовтень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 10 " +
                "UNION SELECT N'Листопад' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 11 " +
                "UNION SELECT N'Грудень' AS 'Місяць', COUNT(contract_id) AS 'Кількість укладених оренд' FROM Rental_contract WHERE MONTH(date) = 12 ORDER BY COUNT(contract_id) DESC", db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }

        private void видиНерухомостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            informationView.Show();
            title.Text = "Рейтинг видів нерухомостей за кількістю оренд";

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT type AS 'Тип', COUNT(type) AS 'Кількість нерухомості' FROM Supply, Rental_contract WHERE Rental_contract. supply_id = Supply.supply_id GROUP BY type ORDER BY COUNT(type) DESC" , db.getConnection());

            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            informationView.DataSource = table;
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

