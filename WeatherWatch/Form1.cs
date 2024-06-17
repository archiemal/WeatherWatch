using System.Net;
using System.Net.NetworkInformation;

namespace WeatherWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void confirmLocationEntry_Click(object sender, EventArgs e)
        {
            weatherImage.Refresh();
            WeatherFetch fetch = new WeatherFetch();
            String location = locationText.Text;
            String temp;
            String conditions;
            String conditionsDesc;
            var data = await fetch.GetJsonData(location);
            if (data != null)
            {
                temp = data["main"]["temp"].ToString();
                conditions = data["weather"][0]["main"].ToString();
                conditionsDesc = data["weather"][0]["description"].ToString();
            }
            else
            {
                temp = "error";
                conditions = "error";
                conditionsDesc = "error";
            }
            currentLocation.Text = $"Current Location: {location}";
            temperature.Text = $"Temperature: {temp}°C";
            weather.Text = $"Weather: {conditions}";
            weatherDesc.Text = $"Description: {conditionsDesc}";
            weatherImage.Load($@"https://openweathermap.org/img/wn/{data["weather"][0]["icon"]}@2x.png"); // Pulls the image to be displayed from the internet then displays it
        }

    }
}