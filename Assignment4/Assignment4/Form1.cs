using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Threading;
using System.Globalization;
using CarLib;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        protected CultureInfo culture;
        protected ComponentResourceManager resManager;
        DataAccess db;
        public Form1()
        { 
            InitializeComponent();
            db = new DataAccess();
            this.resManager = new ComponentResourceManager(this.GetType());
            this.culture = CultureInfo.CurrentUICulture;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
        }
        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int y = e.MarginBounds.Top;
            int x0 = e.MarginBounds.Left;
            int increment = 130;
            int x2;

            //Person person;
            using (Font font = new Font("Times New Roman", 20))
            {
                e.Graphics.DrawString("Id", font, Brushes.Red, x0, y);
                e.Graphics.DrawString("Name", font, Brushes.Red, x0 + increment, y);
                e.Graphics.DrawString("Std Code", font, Brushes.Red, x0 + (2 * increment), y);
                e.Graphics.DrawString("Type", font, Brushes.Red, x0 + (3 * increment), y);
                e.Graphics.DrawString("Teach Code", font, Brushes.Red, x0 + (4 * increment), y);

                //draw horizontal line
                x2 = x0 + (5 * increment) + 20;
                e.Graphics.DrawLine(Pens.Green, x0 - 10, y + (int)(font.Size * 1.5), x2, y + (int)(font.Size * 1.3));


                y += (int)(font.Size * 1.5);
                //IEnumerator<Person> ppl = db.GetTable<Person>().GetEnumerator();
                /*while (ppl.MoveNext())
                {
                    person = ppl.Current;
                    e.Graphics.DrawString(person.id.ToString(), font, Brushes.Black, x0, y);
                    e.Graphics.DrawString(person.name, font, Brushes.Black, x0 + increment, y);
                    if (person is Student)
                    {
                        e.Graphics.DrawString(((Student)person).StudentCode.ToString(), font, Brushes.Black, x0 + (2 * increment), y);

                    }
                    else
                    {
                        e.Graphics.DrawString("NA", font, Brushes.Black, x0 + (2 * increment), y);

                    }
                    e.Graphics.DrawString(person.type, font, Brushes.Black, x0 + (3 * increment), y);


                    if (person is Teacher)
                    {
                        e.Graphics.DrawString(((Teacher)person).TeacherCode.ToString(), font, Brushes.Black, x0 + (4 * increment), y);

                    }
                    else
                    {
                        e.Graphics.DrawString("NA", font, Brushes.Black, x0 + (4 * increment), y);

                    }

                    y += (int)(font.Size * 2);
                }*/
            }
            
            //draw enclosing rectangle
            float width = x2 - x0 + 10;
            float height = y - e.MarginBounds.Top + 10;
            e.Graphics.DrawRectangle(Pens.Green, x0 - 10, e.MarginBounds.Top - 10, width, height);
        }


        private void printingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(languageBox.Text == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if(languageBox.Text == "French")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }
        public void deleteRecord()
        {
            IEnumerable<Car> cars = from c in db.car where c.vIN == Int32.Parse(textBox4.Text) select c;

            db.GetTable<Car>().DeleteAllOnSubmit(cars);
            db.SubmitChanges();


        }
        
        public void searchVIN()
        {
            IEnumerable<Car> cars = from c in db.car where c.vIN == Int32.Parse(textBox4.Text) && c.type == "C" select c;
            foreach (Car car in cars)
            {
                textBox1.Text = car.model;
                textBox2.Text = car.make;
                textBox3.Text = car.year;
                comboBox2.SelectedItem = car.type;
                textBox4.Text = car.vIN.ToString();

            }
            /*foreach (Passenger pass in cars)
            {
                textBox1.Text = pass.model;
                textBox2.Text = pass.make;
                textBox3.Text = pass.year;
                comboBox2.SelectedItem = pass.type;
                textBox4.Text = pass.vIN.ToString();
                textBox5.Text = pass.trimCode.ToString();
            }
            foreach (Truck truck in cars)
            {
                textBox1.Text = truck.model;
                textBox2.Text = truck.make;
                textBox3.Text = truck.year;
                comboBox2.SelectedItem = truck.type;
                textBox4.Text = truck.vIN.ToString();
                textBox6.Text = truck.axles.ToString();
                textBox7.Text = truck.tonnage.ToString();
            }*/
        }
        public void addRecord()
        {
            //insert into DB using subtypes
            if (comboBox2.SelectedItem.Equals("C"))
            {
                Car car = new Car();
                car.model = textBox1.Text;
                car.make = textBox2.Text;
                car.year = textBox3.Text;
                car.type = comboBox2.SelectedItem.ToString();
                car.vIN = Int32.Parse(textBox4.Text);
                db.GetTable<Car>().InsertOnSubmit(car);
                MessageBox.Show("ya done good");
            } else if (comboBox2.SelectedItem.Equals("T"))
            {
                Truck truck = new Truck();
                truck.model = textBox1.Text;
                truck.make = textBox2.Text;
                truck.year = textBox3.Text;
                truck.type = comboBox2.SelectedItem.ToString();
                truck.vIN = Int32.Parse(textBox4.Text);
                truck.axles = Int32.Parse(textBox7.Text);
                truck.tonnage = Int32.Parse(textBox6.Text);
                MessageBox.Show("ya done bad");
                db.GetTable<Car>().InsertOnSubmit(truck);
            }
            else if (comboBox2.SelectedItem.Equals("P"))
            {
                Passenger passenger = new Passenger();
                passenger.model = textBox1.Text;
                passenger.make = textBox2.Text;
                passenger.year = textBox3.Text;
                passenger.type = comboBox2.SelectedItem.ToString();
                passenger.vIN = Int32.Parse(textBox4.Text);
                passenger.trimCode = Int32.Parse(textBox5.Text);
                db.GetTable<Car>().InsertOnSubmit(passenger);
            }
                db.SubmitChanges();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchVIN();
        }
    }



}
