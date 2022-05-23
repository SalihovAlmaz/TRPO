using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void EndTest_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && numericUpDown2.Value != 0 && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {

                DB db = new DB();

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO `people` (`age`,`status`,`WorkRecord`,`Sex`,`Тип интеллекта`,`Тип темперамента`,`Тип характера`,`Проебладающий вид`,`тип эмоц сферы`,`вид воли`,`вид самооценки`,`вид мотивации`,`стремление к общ`,`коммуникация`,`поддержание контакта`,`Жестикуляция`,`Мимика`,`Громкость`,`физ. контакт`,`объём общения`,`Место общения`,`кол-во собесед.`,`круг общения`,`тематика`,`зона общения`,`тональность`,`вид речи`) VALUES (@a1,@a2,@a3,@a4,@q1,@q2,@q3,@q4,@q5,@q6,@q7,@q8,@q9,@q10,@q11,@q12,@q13,@q14,@q15,@q16,@q17,@q18,@q19,@q20,@q21,@q22,@q23)", db.getConnection());
                command.Parameters.Add("@q1", MySqlDbType.Text).Value = Quest1.Text;
                command.Parameters.Add("@q2", MySqlDbType.Text).Value = Quest2.Text;
                command.Parameters.Add("@q3", MySqlDbType.Text).Value = Quest3.Text;
                command.Parameters.Add("@q4", MySqlDbType.Text).Value = Quest4.Text;
                command.Parameters.Add("@q5", MySqlDbType.Text).Value = Quest5.Text;
                command.Parameters.Add("@q6", MySqlDbType.Text).Value = Quest6.Text;
                command.Parameters.Add("@q7", MySqlDbType.Text).Value = Quest7.Text;
                command.Parameters.Add("@q8", MySqlDbType.Text).Value = Quest8.Text;
                command.Parameters.Add("@q9", MySqlDbType.Text).Value = Quest9.Text;
                command.Parameters.Add("@q10", MySqlDbType.Text).Value = Quest10.Text;
                command.Parameters.Add("@q11", MySqlDbType.Text).Value = Quest11.Text;
                command.Parameters.Add("@q12", MySqlDbType.Text).Value = Quest12.Text;
                command.Parameters.Add("@q13", MySqlDbType.Text).Value = Quest13.Text;
                command.Parameters.Add("@q14", MySqlDbType.Text).Value = Quest14.Text;
                command.Parameters.Add("@q15", MySqlDbType.Text).Value = Quest15.Text;
                command.Parameters.Add("@q16", MySqlDbType.Text).Value = Quest16.Text;
                command.Parameters.Add("@q17", MySqlDbType.Text).Value = Quest17.Text;
                command.Parameters.Add("@q18", MySqlDbType.Text).Value = Quest18.Text;
                command.Parameters.Add("@q19", MySqlDbType.Text).Value = Quest19.Text;
                command.Parameters.Add("@q20", MySqlDbType.Text).Value = Quest20.Text;
                command.Parameters.Add("@q21", MySqlDbType.Text).Value = Quest21.Text;
                command.Parameters.Add("@q22", MySqlDbType.Text).Value = Quest22.Text;
                command.Parameters.Add("@q23", MySqlDbType.Text).Value = Quest23.Text;
                command.Parameters.Add("@a1", MySqlDbType.Text).Value = numericUpDown2.Value;
                command.Parameters.Add("@a2", MySqlDbType.Text).Value = comboBox2.Text;
                command.Parameters.Add("@a3", MySqlDbType.Text).Value = numericUpDown2.Value;
                command.Parameters.Add("@a4", MySqlDbType.Text).Value = comboBox1.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Анкета успешно заполнена");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Анкета не успешно заполнена");
                }

                db.closeConnection();
            }
            else
                label9.Visible = true;

        }
        private void Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
