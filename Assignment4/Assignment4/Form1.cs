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
            comboBox2.SelectedItem = "C";
        }
        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int y = e.MarginBounds.Top;
            int x0 = e.MarginBounds.Left;
            int increment = 130;
            int x2;

            Car currentCar;
            using (Font font = new Font("Times New Roman", 20))
            {
                e.Graphics.DrawString("VIN", font, Brushes.Red, x0, y);
                e.Graphics.DrawString("Make", font, Brushes.Red, x0 + increment, y);
                e.Graphics.DrawString("Model", font, Brushes.Red, x0 + (2 * increment), y);
                e.Graphics.DrawString("Year", font, Brushes.Red, x0 + (3 * increment), y);
                e.Graphics.DrawString("Type", font, Brushes.Red, x0 + (4 * increment), y);

                //draw horizontal line
                x2 = x0 + (5 * increment) + 20;
                e.Graphics.DrawLine(Pens.Green, x0 - 10, y + (int)(font.Size * 1.5), x2, y + (int)(font.Size * 1.3));


                y += (int)(font.Size * 1.5);
                IEnumerator<Car> grabbedCars = db.GetTable<Car>().GetEnumerator();
                while (grabbedCars.MoveNext())
                {
                    currentCar = grabbedCars.Current;
                    e.Graphics.DrawString(currentCar.vIN.ToString(), font, Brushes.Black, x0, y);
                    e.Graphics.DrawString(currentCar.make, font, Brushes.Black, x0 + increment, y);
                    e.Graphics.DrawString(currentCar.model, font, Brushes.Black, x0 + 2* increment, y);
                    e.Graphics.DrawString(currentCar.year, font, Brushes.Black, x0 + 3* increment, y);
                    e.Graphics.DrawString(currentCar.type, font, Brushes.Black, x0 + 4* increment, y);
        

                    y += (int)(font.Size * 2);
                }
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
            if(languageBox.Text == "English" || languageBox.Text == "Anglais")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                this.Controls.Clear();
                this.InitializeComponent();
                printDocument1.PrintPage += printDocument1_PrintPage;
                comboBox2.SelectedItem = "C";
            }
            else if (languageBox.Text == "French" || languageBox.Text == "Français")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
                this.Controls.Clear();
                this.InitializeComponent();
                printDocument1.PrintPage += printDocument1_PrintPage;
                comboBox2.SelectedItem = "C";
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
            this.Controls.Clear();
            this.InitializeComponent();
            printDocument1.PrintPage += printDocument1_PrintPage;
            comboBox2.SelectedItem = "C";


        }
        

        /// <summary>
        /// Searches the database for a VIN
        /// </summary>
        public void searchVIN()
        {
            IEnumerable<Car> cars = from c in db.car where c.vIN == Int32.Parse(textBox4.Text) && c.type == "C" select c;
            foreach (Car car in cars)
            {
                textBox1.Text = car.model;
                textBox2.Text = car.make;
                textBox3.Text = car.year;
                comboBox2.SelectedItem = "C";
                textBox4.Text = car.vIN.ToString();
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;

            }

            IEnumerable<Car> passGrabbed = from c in db.car where c.vIN == Int32.Parse(textBox4.Text) && c.type == "P" select c;
            foreach (Passenger pass in passGrabbed)
            {
                textBox1.Text = pass.model;
                textBox2.Text = pass.make;
                textBox3.Text = pass.year;
                comboBox2.SelectedItem = pass.type;
                textBox4.Text = pass.vIN.ToString();
                textBox5.Text = pass.trimCode.ToString();
                textBox6.Text = null;
                textBox7.Text = null;
            }
            IEnumerable<Car> tuckGrabbed = from c in db.car where c.vIN == Int32.Parse(textBox4.Text) && c.type == "T" select c;
            foreach (Truck truck in tuckGrabbed)
            {
                textBox1.Text = truck.model;
                textBox2.Text = truck.make;
                textBox3.Text = truck.year;
                comboBox2.SelectedItem = truck.type;
                textBox4.Text = truck.vIN.ToString();
                textBox6.Text = truck.axels .ToString();
                textBox7.Text = truck.tonnage.ToString();
                textBox5.Text = null;
            }
            if (cars.Count<object>() < 1 && passGrabbed.Count<object>() < 1 && tuckGrabbed.Count<object>() < 1)
            {
                MessageBox.Show(resManager.GetString("cantFind", Thread.CurrentThread.CurrentUICulture));
            }
        }

        /// <summary>
        /// Adds or updates a record
        /// </summary>
        public void addRecord()
        {
            //insert into DB using subtypes
            IEnumerable<Car> cars = from c in db.car where c.vIN == Int32.Parse(textBox4.Text) select c;
            if (cars.Count<object>() < 1)
            {
                if (comboBox2.SelectedItem.Equals("C"))
                {
                    Car car = new Car();
                    car.model = textBox1.Text;
                    car.make = textBox2.Text;
                    car.year = textBox3.Text;
                    car.type = "C";
                    car.vIN = Int32.Parse(textBox4.Text);
                    db.GetTable<Car>().InsertOnSubmit(car);
                    db.SubmitChanges();
                }
                else if (comboBox2.SelectedItem.Equals("T"))
                {
                    Truck truck = new Truck();
                    truck.model = textBox1.Text;
                    truck.make = textBox2.Text;
                    truck.year = textBox3.Text;
                    truck.type = comboBox2.SelectedItem.ToString();
                    truck.vIN = Int32.Parse(textBox4.Text);
                    int result;
                    if (textBox7.Text == "" || int.TryParse(textBox7.Text, out result) == false)
                    {
                        textBox7.Text = "0";
                    }
                    if (textBox6.Text == "" || int.TryParse(textBox6.Text, out result) == false)
                    {
                        textBox6.Text = "0";
                    }
                    truck.axels = Int32.Parse(textBox6.Text);
                    truck.tonnage = Int32.Parse(textBox7.Text);
                    db.GetTable<Car>().InsertOnSubmit(truck);
                    db.SubmitChanges();
                }
                else if (comboBox2.SelectedItem.Equals("P"))
                {
                    Passenger passenger = new Passenger();
                    passenger.model = textBox1.Text;
                    passenger.make = textBox2.Text;
                    passenger.year = textBox3.Text;
                    passenger.type = comboBox2.SelectedItem.ToString();
                    passenger.vIN = Int32.Parse(textBox4.Text);
                    int result;
                    if (textBox5.Text == "" || int.TryParse(textBox5.Text, out result) == false)
                    {
                        textBox5.Text = "0";
                    }
                    passenger.trimCode = Int32.Parse(textBox5.Text);
                    db.GetTable<Car>().InsertOnSubmit(passenger);
                    db.SubmitChanges();
                }
            }
            else
            {
                var carsUpdate = db.car.Where(c => c.vIN == Int32.Parse(textBox4.Text) && c.type == "C");
                foreach (var car in carsUpdate)
                {
                    ((Car)car).model = textBox1.Text;
                    ((Car)car).make = textBox2.Text;
                    ((Car)car).year = textBox3.Text;
                    ((Car)car).type = comboBox2.SelectedItem.ToString();

                }
                var trucksUpdate = db.car.Where(c => c.vIN == Int32.Parse(textBox4.Text) && c.type == "T");
                foreach (var truck in trucksUpdate)
                {
                    ((Truck)truck).model = textBox1.Text;
                    ((Truck)truck).make = textBox2.Text;
                    ((Truck)truck).year = textBox3.Text;
                    ((Truck)truck).type = comboBox2.SelectedItem.ToString();
                    if (textBox7.Text == "")
                    {
                        textBox7.Text = "0";
                    }
                    if (textBox6.Text == "")
                    {
                        textBox6.Text = "0";
                    }
                    ((Truck)truck).axels = Int32.Parse(textBox6.Text);
                    ((Truck)truck).tonnage = Int32.Parse(textBox7.Text);

                }
                var passUpdate = db.car.Where(c => c.vIN == Int32.Parse(textBox4.Text) && c.type == "P");
                foreach (var pass in passUpdate)
                {
                    ((Passenger)pass).model = textBox1.Text;
                    ((Passenger)pass).make = textBox2.Text;
                    ((Passenger)pass).year = textBox3.Text;
                    ((Passenger)pass).type = comboBox2.SelectedItem.ToString();
                    if (textBox5.Text == null)
                    {
                        textBox5.Text = "0";
                    }
                    ((Passenger)pass).trimCode = Int32.Parse(textBox5.Text);

                }
                db.SubmitChanges();

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            addRecord();
            this.Controls.Clear();
            this.InitializeComponent();
            printDocument1.PrintPage += printDocument1_PrintPage;
            comboBox2.SelectedItem = "C";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            searchVIN();
        }
    }



}
