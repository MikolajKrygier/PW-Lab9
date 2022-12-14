using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;

namespace PW_Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class karta
        {
            public string kierunek;
            public string studiawzakresie;
            public string profilstudiow;
            public string formastudiow;
            public string poziomstudiow;
            public string student1imie;
            public string student1album;
            public string student1data;
            public string student2imie;
            public string student2album;
            public string student2data;
            public string student3imie;
            public string student3album;
            public string student3data;
            public string student4imie;
            public string student4album;
            public string student4data;
            public string tytul;
            public string ang;
            public string dane;
            public string zakres;
            public string promotor;
            public string jednostka;



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox1.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox1.Text = "";
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox2.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox2.Text = "";
            }
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
                if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox5.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    richTextBox5.Text = "";
                }

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
                if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox4.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    richTextBox4.Text = "";
                }

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
                if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox3.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    richTextBox3.Text = "";
                }
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
                if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox6.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    richTextBox6.Text = "";
                }

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
                if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox7.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    richTextBox7.Text = "";
                }

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
                if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox8.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    richTextBox8.Text = "";
                }

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox9.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox9.Text = "";
            }
        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox10.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox10.Text = "";
            }
        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox11.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox11.Text = "";
            }
        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox12.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox12.Text = "";
            }
        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox13.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox13.Text = "";
            }
        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox14.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox14.Text = "";
            }
        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox15.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                richTextBox15.Text = "";
            }
        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox16.Text, "^[0-9]"))
            {
                MessageBox.Show("This textbox accepts only numerical characters");
                richTextBox16.Text = "";
            }
        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox18.Text, "^[0-9]"))
            {
                MessageBox.Show("This textbox accepts only numerical characters");
                richTextBox18.Text = ""; ;
            }
        }

        private void richTextBox20_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox20.Text, "^[0-9]"))
            {
                MessageBox.Show("This textbox accepts only numerical characters");
                richTextBox20.Text = "";
            }
        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(richTextBox22.Text, "^[0-9]"))
            {
                MessageBox.Show("This textbox accepts only numerical characters");
                richTextBox2.Text = "";
            }
        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            karta Karta = new karta();
            Karta.kierunek = richTextBox1.Text;
            Karta.studiawzakresie = richTextBox2.Text;
            Karta.profilstudiow = richTextBox5.Text;
            Karta.formastudiow = richTextBox4.Text;
            Karta.profilstudiow = richTextBox3.Text;
            Karta.student1imie = richTextBox6.Text;
            Karta.student1album = richTextBox16.Text;
            Karta.student1data = maskedTextBox1.Text;
            Karta.student2imie = richTextBox7.Text;
            Karta.student2album = richTextBox18.Text;
            Karta.student2data = maskedTextBox2.Text;
            Karta.student3imie = richTextBox8.Text;
            Karta.student3album = richTextBox20.Text;
            Karta.student3data = maskedTextBox3.Text;
            Karta.student4imie = richTextBox9.Text;
            Karta.student4album = richTextBox22.Text;
            Karta.student4data = maskedTextBox4.Text;
            Karta.tytul = richTextBox10.Text;
            Karta.ang = richTextBox11.Text;
            Karta.dane= richTextBox12.Text;
            Karta.zakres = richTextBox13.Text;
            Karta.promotor = richTextBox14.Text;
            Karta.jednostka = richTextBox15.Text;

            XmlSerializer xsSubmit = new XmlSerializer(typeof(karta));
            var xml = "";
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = new XmlTextWriter(sww))
                {
                    xsSubmit.Serialize(writer, Karta);
                    xml = sww.ToString();
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, xml);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 0;
            openFileDialog.DefaultExt = "xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(karta));
                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);
                karta Karta = (karta)reader.Deserialize(file);
                file.Close();
                richTextBox1.Text = Karta.kierunek;
                richTextBox2.Text = Karta.studiawzakresie;
                richTextBox5.Text = Karta.profilstudiow;
                richTextBox4.Text = Karta.formastudiow;
                richTextBox3.Text = Karta.profilstudiow;
                richTextBox6.Text = Karta.student1imie;
                richTextBox16.Text = Karta.student1album;
                maskedTextBox1.Text = Karta.student1data;
                richTextBox7.Text = Karta.student2imie;
                richTextBox18.Text = Karta.student2album;
                maskedTextBox2.Text = Karta.student2data;
                richTextBox8.Text = Karta.student3imie;
                richTextBox20.Text = Karta.student3album;
                maskedTextBox3.Text = Karta.student3data;
                richTextBox9.Text = Karta.student4imie;
                richTextBox22.Text = Karta.student4album;
                maskedTextBox4.Text = Karta.student4data;
                richTextBox10.Text = Karta.tytul;
                richTextBox11.Text = Karta.ang;
                richTextBox12.Text = Karta.dane;
                richTextBox13.Text = Karta.zakres;
                richTextBox14.Text = Karta.promotor;
                richTextBox15.Text = Karta.jednostka;

            }
        }

        
    }
}