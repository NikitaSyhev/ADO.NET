using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SQLite;
using System.Data.Entity;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        SQLiteDataAdapter adapter;
        string connectionString = "Data Source=qqq.db3";
     
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString); // строка подключения
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            if(checkBoxBD.Checked)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = @"insert into tmp(id,tt) values (@id, @tt)";
                SQLiteParameter param1 = new SQLiteParameter();
                SQLiteParameter param2 = new SQLiteParameter();
                param1.ParameterName = "id";
                param1.Value = tb_ID.Text;
                cmd.Parameters.Add(param1);

                param2.ParameterName = "tt";
                param2.Value = tb_TT.Text;
                cmd.Parameters.Add(param2);
            }
            else
            {
                cmd.CommandText = "create table tmp(id int PRIMARY KEY, tt varchar(20));" +
                                  "insert into tmp(id,tt) values (1,'qq');" +
                                  "insert into tmp(id,tt) values (2, 'ww');"; // описали команду // команда для insert , update, delete
            }
            
            cmd.ExecuteNonQuery();                        
            conn.Close();
          
        }

        private void buttonFill_Click(object sender, EventArgs e) // присоединенный режим чтения
        {

            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.ConnectionString = connectionString; 
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tmp";
            SQLiteDataReader reader = cmd.ExecuteReader(); //команда для select
            while (reader.Read()) // прошли циклом и вывели таблицу в текстбокс
            {
                tbBD.Text = tbBD.Text + reader[0] + ' ' + reader[1] + "\r\n";
            }
            reader = null;
            conn.Close();


        }


        private void btn3_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection(connectionString); // отсоединенный режим чтения
           // SQLiteCommand cmd = new SQLiteCommand(); //он нужен для сложных запросов и многотабличных БД
            adapter = new SQLiteDataAdapter(tbSQL.Text, conn); // адапте нужен для связи
           // adapter.SelectCommand = cmd;
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter); //строит запросы для БД нужен для однотабличной БД
            dataSet = new DataSet();    // набор таблиц где хранятся данные с которыми мы можем работать
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(dataSet);
        }

        private void createNewTable_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "create table tmp1(id int PRIMARY KEY, tt varchar(20));" +
                              "insert into tmp1(id,tt) values (1,'qq');" +
                              "insert into tmp1(id,tt) values (2, 'ww');" +
                              "create table tmp2(id int PRIMARY KEY, tt varchar(20));" +
                              "insert into tmp2(id,tt) values (1,'qq');" +
                              "insert into tmp2(id,tt) values (2, 'ww');" +
                              "create table tmp3(id int PRIMARY KEY, tt varchar(20));" +
                              "insert into tmp3(id,tt) values (1,'qq');" +
                              "insert into tmp3(id,tt) values (2, 'ww');";


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void btnSelectTable_Click(object sender, EventArgs e)
        {
            string sqltext = "select * from tmp1;" +
                "select * from tmp2;" +
                "select * from tmp3;";
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            adapter = new SQLiteDataAdapter(sqltext, conn);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select name from sqlite_master where type='table'";
            SQLiteDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
               
            }
            reader = null;
            conn.Close();

            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
            adapter.TableMappings.Add("Table1", "tmp1");
            adapter.TableMappings.Add("Table2", "tmp2");
            adapter.TableMappings.Add("Table3", "tmp3");
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables["tmp"];
            

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables[comboBox1.Text];
        }
    }
}
