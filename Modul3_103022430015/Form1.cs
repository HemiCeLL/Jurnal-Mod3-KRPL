using System.Xml.Serialization;

namespace Modul3_103022430015
{
    public partial class Form1 : Form
    {
        double inputNilai = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_con_Click(object sender, EventArgs e)
        {

            String suhuAk = (string)comboBox2.SelectedItem;
            inputNilai = double.Parse(textBox1.Text);

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih suhu awal dan akhir!");
                return;
            }

            if(!double.TryParse(textBox1.Text, out double nilai))
            {
                MessageBox.Show("Pilih suhu awal dan akhir!");
                return;

            }

            String dari = comboBox1.SelectedItem.ToString().Trim();
            String ke = comboBox2.SelectedItem.ToString().Trim();
            double celcius = dariCelcius(nilai, dari);
            double hasil = dariCelcius(celcius, ke);
            textBox2.Text = hasil.ToString("F2");
        }


        private double dariCelcius(double nilai, string satuan)
        {
            switch (satuan)
            {
                case "celcius":

                    return nilai;

                case "farenheit":
                    return (nilai * 9 / 5) + 32;

                case "kelvin":
                    return nilai *4/5;

                case "reamur":
                    return nilai + 273.15;

                default:
                    return nilai;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

