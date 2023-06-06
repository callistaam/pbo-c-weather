using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Bismillah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "2be9940b3a4440857a558a14517ac1e7";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", tbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lbCondition.Text = Info.weather[0].main;
                lbDetail.Text = Info.weather[0].description;
                SunsetNA.Text = convertDateTime(Info.sys.sunset).ToString();
                SunriseNA.Text = convertDateTime(Info.sys.sunrise).ToString();
                WindNA.Text = Info.wind.speed.ToString();
                PressureNA.Text = Info.main.pressure.ToString();
            }

        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970,1,1,0,0,0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
