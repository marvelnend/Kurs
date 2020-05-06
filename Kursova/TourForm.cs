using Kursova.models;
using Newtonsoft.Json;
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
    public partial class TourForm : Form
    {
        private BaseSystem baseSystem;
        private AboutTour aboutTour;
        private AboutLocality aboutLocality;
        public TourForm(BaseSystem baseSystem)
        {
            this.baseSystem = baseSystem;
            aboutTour = new AboutTour(baseSystem);
            aboutLocality = new AboutLocality(baseSystem);
            InitializeComponent();
            UpdateForm();
        }
        public void UpdateForm()
        {
            ListBox listTours = (ListBox)Controls.Find("listTours", true)[0];
            listTours.DataSource = null;
            listTours.DataSource = baseSystem.tours;

            ListBox listLocalities = (ListBox)Controls.Find("listLocalities", true)[0];
            listLocalities.DataSource = null;
            listLocalities.DataSource = baseSystem.localities;

            ListBox listHotels = (ListBox)Controls.Find("listHotels", true)[0];
            listHotels.DataSource = null;
            listHotels.DataSource = baseSystem.hotels;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void listTours_DoubleClick(object sender, EventArgs e)
        {
            ListBox listTours2 = (ListBox)sender;

            if (listTours2.SelectedItem != null)
            {

                aboutTour.tour = (Tour)listTours2.SelectedItem;
                aboutTour.UpdateForm();

                aboutTour.ShowDialog();
            }
        }
        private void listLocalities_DoubleClick(object sender, EventArgs e)
        {
            ListBox listLocalities2 = (ListBox)sender;

            if (listLocalities2.SelectedItem != null)
            {

                aboutLocality.locality = (Locality)listLocalities2.SelectedItem;
                aboutLocality.UpdateForm();

                aboutLocality.ShowDialog();
            }
        }

        private void listHotels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrHotel_Click(object sender, EventArgs e)
        {
            TextBox name = (TextBox)Controls.Find("nameHotelBox", true)[0];
            NumericUpDown number = (NumericUpDown)Controls.Find("numberOfStarsBox", true)[0];
            if (!number.Text.Equals(""))
            {
                int numberOfStars = (int)number.Value ;

                bool success;

                success = baseSystem.RegisterHotel(name.Text, numberOfStars);

                UpdateForm();
                if (success)
                    MessageBox.Show("Готель був успішно зареєстрований");
                else
                    MessageBox.Show("Помилка реєстрації, спробуйте ще раз");
            }
            else
            {
                MessageBox.Show("Помилка реєстрації, спробуйте ще раз");

            }
        }

        private void buttonRegistrLocality_Click(object sender, EventArgs e)
        {
            
            TextBox countru = (TextBox)Controls.Find("countryBox", true)[0];
            TextBox city = (TextBox)Controls.Find("cityBox", true)[0];
         
            
            bool success;
            success = baseSystem.RegisterLocality(countru.Text, city.Text);
            UpdateForm();
            if (success)
                MessageBox.Show("Населений пункт був успішно зареєстрований");
            else
                MessageBox.Show("Помилка реєстрації, спробуйте ще раз");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBox name = (TextBox)Controls.Find("nameTourBox", true)[0];
            TextBox type = (TextBox)Controls.Find("tupeBox", true)[0];
            TextBox transport = (TextBox)Controls.Find("transportBox", true)[0];
            NumericUpDown durarion = (NumericUpDown)Controls.Find("durationDayBox", true)[0];
            TextBox city = (TextBox)Controls.Find("cityForTourBox", true)[0];
            if (!durarion.Text.Equals(""))
            {
                int d = (int)durarion.Value;
                bool success;
                success = baseSystem.RegisterTour(name.Text, type.Text, transport.Text, d, city.Text);
                UpdateForm();
                if (success)
                {
                    
                    MessageBox.Show("Тур був успішно зареєстрований");
                }
                else
                    MessageBox.Show("Помилка реєстрації, спробуйте ще раз");
            }
            else
            {
                MessageBox.Show("Помилка реєстрації, спробуйте ще раз");

            }

        }

        private void TourForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(openFileDialog.FileName, JsonConvert.SerializeObject(baseSystem, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }));
            }
        }

        private void durationDayBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
