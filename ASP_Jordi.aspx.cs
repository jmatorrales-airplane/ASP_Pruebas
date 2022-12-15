using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pruebas
{
    public partial class ASP_Jordi : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dBirthday.Add("30,05","Marc");
            dBirthday.Add("22,12","Jordi");
            dBirthday.Add("12,08","Sergi");
            dBirthday.Add("10,12","Michael");
            dBirthday.Add("16,01","Dana");

            addList();
        }

        protected void btn_onClick(Object Sender, EventArgs e)
        {
            userInput.Text = Text1.Text;
            Text1.Text = "";
        }

        protected void addList()
        {
            //  ddlBirthday.Items.Add("");
            string bbdd = "data source=AIRPLANE_JORDI; database=ASP_Birthday; integrated security=SSPI";

            SqlConnection conn = new SqlConnection(bbdd);
            SqlCommand command = new SqlCommand("select * from AP_JUNIORS;", conn);
            conn.Open();
            //command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ddlBirthday.Items.Add($"{reader["nombre"]}, {reader["dia"]}/{reader["mes"]}");
            }

            conn.Close();
        }

        protected Dictionary<string, string> dBirthday = new Dictionary<string, string>();

        protected void btn_onClick_calendar(Object Sender, EventArgs e)
        {
            showdate.Text = "You selected: " + calendar1.SelectedDate.ToString("D");

            int day = calendar1.SelectedDate.Day;
            int month = calendar1.SelectedDate.Month;

            string isBDay = $"{day},{month}";

            showdate.Text = $"{month},  {day}";

            //if(day == 28 && month == 12)
            //{
            //    especial.Text = "Es el dia de los santos inocentes!";
            //}
            if (dBirthday.ContainsKey(isBDay))
            {
                showdate.Text = $"Es el cumpleaños de: {dBirthday[isBDay]}";
            }
        }
    }
}