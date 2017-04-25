
/// Tommie Terrell
/// FlightTest class project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        class FlightTest /// class that will assign values to variables.
        {
            public string airName;
            public int flightNum;
            public int row;
            public string seat;
            public string AirName
            {
                get
                {
                    return airName;
                }
                set
                {
                    airName = value;
                }
            }
            public virtual int FlightNum
            {
                get
                {
                    return flightNum;
                }
                set
                {
                    flightNum = value;
                }
            }
            public virtual int Row
            {
                get
                {
                    return row;
                }
                set
                {
                    row = value;
                }
            }

            public string Seat
            {
                get
                {
                    return seat;

                }
                set
                {
                    seat = value;
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)/// Button action. This will insert data into FlightTest class then return values to label.Text
        {
            FlightTest flightinfo = new FlightTest();
            flightinfo.airName = "Con Air";
            flightinfo.flightNum = 27;
            flightinfo.row = 22;
            flightinfo.seat = "A";
             lblresults.Text +=  "Airline:"+ flightinfo.AirName+"\n";
             lblresults.Text += "Flight Number:" + flightinfo.FlightNum.ToString() + "\n";
             lblresults.Text += "Row:" + flightinfo.Row.ToString() + "\n";
             lblresults.Text += "Seat:" + flightinfo.Seat + "\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}