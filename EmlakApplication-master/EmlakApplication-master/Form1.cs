namespace EmlakApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float price = GetArea() * GetCityFactor() * GetCategoryFactor() * GetDateFactor() * GetTypeFactor();
            MessageBox.Show(price.ToString());
        }

        private int GetArea()
        {
            return Convert.ToInt32(nudArea.Value);
        }

        private float GetCategoryFactor()
        {
            if(rbLand.Checked == true)
            {
                return 1.75F;
            }
            else if(rbHome.Checked == true) 
            {
                return 2.25F;
            }
            else
            {
                throw new Exception("Lütfen Mülkiyet Tipi seçin.");
            }
        }

        private int GetTypeFactor()
        {
            if (rbRental.Checked == true)
            {
                return 1;
            }
            else if (rbSale.Checked == true)
            {
                return 200;
            }
            else
            {
                throw new Exception("Lütfen Mülkiyet Tipi seçin.");
            }
        }

        private float GetDateFactor()
        {
            DateTime now = DateTime.Now;

            float diff = (now - dtpDate.Value).Days/365;

            if(diff < 5) {
                return 1;
            }
            else
            {
                return 1.1F;
            }
        }

        private float GetCityFactor()
        {
            if (cmbCity.Text == "Ankara")
            {
                return 1.8F;
            }
            else if (cmbCity.Text == "İstanbul")
            {
                return 2.7F;
            }
            else if (cmbCity.Text == "İzmir")
            {
                return 0.9F;
            }
            else
            {
                throw new Exception("Lütfen şehir seçin.");
            }
        }
    }
}