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
    public partial class AboutLocality : Form
    {
        public Locality locality;
        public BaseSystem baseSystem;
        public AboutLocality(BaseSystem baseSystem)
        {
            this.baseSystem = baseSystem;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateForm()
        {
            Label labelCountry = (Label)Controls.Find("countryLabel", true)[0];
            Label labelCity = (Label)Controls.Find("cityLabel", true)[0];
            Label labelHotels = (Label)Controls.Find("hotelLocalityLabel", true)[0];
            
            labelCountry.Text = locality.country;
            labelCity.Text = locality.city;
            labelHotels.Text = "";
            for (int i = 0; i < locality.hotels.Count; i++)
            {
                labelHotels.Text = labelHotels.Text + locality.hotels[i].hotelName;
                if (i < locality.hotels.Count - 1)
                {
                    labelHotels.Text = labelHotels.Text + ", ";
                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddHotel_Click(object sender, EventArgs e)
        {
            TextBox name = (TextBox)Controls.Find("nameHotelBoxL", true)[0];
            
            
                bool success;
                success = baseSystem.GetHotelByName(name.Text)!=null;
            
                
            if (success)
            {
                if (locality.GetHotelByName(name.Text) == null)
                {
                    locality.AddHotel(baseSystem.GetHotelByName(name.Text));
                    UpdateForm();
                    MessageBox.Show("Готель був успішно зареєстрований");
                    
                }
            }
            else
                MessageBox.Show("Помилка реєстрації, спробуйте ще раз");
            
        }

        private void nameHotelBoxL_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
