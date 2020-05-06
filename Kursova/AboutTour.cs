using Kursova.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class AboutTour : Form
    {
        public Tour tour;
        public BaseSystem baseSystem;
        public PriceListForm priceListForm;
        public AboutTour(BaseSystem baseSystem)
        {
            this.baseSystem = baseSystem;
            priceListForm = new PriceListForm();
            InitializeComponent();
        }
        public void UpdateForm()
        {
            Label labelName = (Label)Controls.Find("nameTourLabel", true)[0];
            Label labelType = (Label)Controls.Find("TypeTourLabel", true)[0];
            Label labelTransport = (Label)Controls.Find("transportTourLabel", true)[0];
            Label labelDuration = (Label)Controls.Find("durationTourLabel", true)[0];
            Label labelCity = (Label)Controls.Find("cityTourLabel", true)[0];
            Label labelHotels = (Label)Controls.Find("hotels", true)[0];



            labelName.Text = tour.nameTour;
            labelType.Text = tour.typeTour;
            labelTransport.Text = tour.transport;
            labelDuration.Text = tour.durationDay + "";
            labelCity.Text = "";
            labelHotels.Text = "";
            for (int i = 0; i < tour.localities.Count; i++)
            {
                labelCity.Text = labelCity.Text + tour.localities[i].city;
                if (i < tour.localities.Count - 1)
                {
                    labelCity.Text = labelCity.Text + ", ";
                }
                for (int j = 0; j < tour.localities[i].hotels.Count; j++)
                {
                    if (tour.localities[i].hotels[j].namberOfStars == 5) {
                        labelHotels.Text = labelHotels.Text + tour.localities[i].hotels[j];
                        if (j < tour.localities[i].hotels.Count - 1)
                        {

                            labelHotels.Text = labelHotels.Text + ", ";
                        }
                        
                    }
                }
                
            }
            
        }
        

        private void AboutTour_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void buttonAddLocality_Click(object sender, EventArgs e)
        {
            TextBox name = (TextBox)Controls.Find("cityAT", true)[0];


            bool success;
            success = baseSystem.GetLocacionByCity(name.Text) != null;


            if (success)
            {
                if (tour.GetLocacionByCity(name.Text) == null)
                {
                    tour.AddLocality(baseSystem.GetLocacionByCity(name.Text));
                    UpdateForm();
                    MessageBox.Show("Населений пункт був успішно доданий");

                }
                else MessageBox.Show("Помилка, спробуйте ще раз");
            }
            else
                MessageBox.Show("Помилка, спробуйте ще раз");

        }

        private void addPriceList_Click(object sender, EventArgs e)
        {
            DateTimePicker timeA = (DateTimePicker)Controls.Find("dateA", true)[0];
            DateTimePicker timeB = (DateTimePicker)Controls.Find("dateB", true)[0];
            NumericUpDown price = (NumericUpDown)Controls.Find("price", true)[0];
            NumericUpDown num = (NumericUpDown)Controls.Find("pice", true)[0];

            if (price.Text != "" && num.Text != null)
            {
                int n =(int) num.Value;
                int p = (int) price.Value;
                bool success;
                success = tour.AddPriseList(new PriceList(timeA.Value, timeB.Value, p, n));
                if (success)
                {
                    MessageBox.Show("Прайс-лист був успішно доданий");
                }
                else
                {
                    MessageBox.Show("Помилка, спробуйте ще раз");
                }
               
            }else
            MessageBox.Show("Помилка, спробуйте ще раз");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTime = (DateTimePicker)Controls.Find("date", true)[0];
            if (tour.GetPriceListByDay(new DateTime(dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day)) != null)
            {
                priceListForm.priceList = tour.GetPriceListByDay(dateTime.Value);
                priceListForm.UpdateForm();
                priceListForm.ShowDialog();
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
