using MySql.Data;
using MySql.Data.MySqlClient;

namespace IdeaManagement
{
    // TODO - domácí úkol
    // 1) Mazání ideas
    // 2) Pøi editu pøedvyplnit title a description
    // 3) "Pøerušení editu", aby šlo znovu pøidávat


    public partial class Form1 : Form
    {
        string server = "localhost";
        string database = "ideas2itb";
        string username = "root";
        string password = "";

        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM ideas";
            listBox1.Items.Clear();

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Idea idea = new Idea()
                    {
                        Id = dataReader["id"].ToString(),
                        Title = dataReader["title"].ToString(),
                        Description = dataReader["description"].ToString(),
                        Creation_Date = dataReader["creation_date"].ToString()
                    };

                    listBox1.Items.Add(idea);
                }

                dataReader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "0")
            {
                AddIdea();
            }
            else
            {
                EditIdea(textBox2.Text);
            }
        }

        private void AddIdea()
        {
            string query = "INSERT INTO ideas (title, description) VALUES (@title, @description)";

            var title = textBox1.Text;
            var desc = richTextBox1.Text;

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", desc);

                try
                {
                    var count = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadData();
        }

        private void EditIdea(string id)
        {
            string query = "UPDATE ideas SET title=@title, description=@description WHERE id=@id";

            var title = textBox1.Text;
            var desc = richTextBox1.Text;

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", desc);

                try
                {
                    var count = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idea = listBox1.SelectedItem as Idea;
            textBox2.Text = idea.Id;
        }
    }
}
