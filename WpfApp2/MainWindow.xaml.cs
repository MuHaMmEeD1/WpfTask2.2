using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double eded1 = 0;
        public double eded2 = 0;
        public bool eded1Yoxla = false;
        public bool devamBol = false;
        public bool devamVur = false;
        public bool devamTopla = false;
        public bool devamCix = false;
        public bool ilk = false;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            EsasLabel.Content = "0";

            eded1Yoxla = false; eded1 = 0;

            devamBol = false;
            devamCix = false;
            devamVur = false;
            devamTopla = false;
            ilk = false;
        }


        private void button5_Click_1(object sender, EventArgs e)
        {

            ilk = false;
            if (EsasLabel.Content == "0") { }
            else
            {

                if (EsasLabel.Content.ToString().Length == 1) { EsasLabel.Content = "0"; }
                else
                {

                    List<char> newText = new List<char>();
                    for (int i = 0; i < EsasLabel.Content.ToString().Length - 1; i++)
                    {
                        newText.Add(EsasLabel.Content.ToString()[i]);
                    }
                    EsasLabel.Content = "";

                    for (int i = 0; i < newText.Count; i++)
                    {
                        EsasLabel.Content = EsasLabel.Content.ToString() + newText[i];
                    }

                }

            }


        }

        private void _1_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "1"; eded1Yoxla = false; }
            else { EsasLabel.Content += "1"; }
            ilk = false;
        }

        private void _2_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "2"; eded1Yoxla = false; }
            else { EsasLabel.Content += "2"; }
            ilk = false;
        }

        private void _3_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "3"; eded1Yoxla = false; }
            else { EsasLabel.Content += "3"; }
            ilk = false;
        }

        private void _4_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "4"; eded1Yoxla = false; }
            else { EsasLabel.Content += "4"; }
            ilk = false;
        }

        private void _5_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "5"; eded1Yoxla = false; }
            else { EsasLabel.Content += "5"; }
            ilk = false;
        }

        private void _6_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "6"; eded1Yoxla = false; }
            else { EsasLabel.Content += "6"; }
            ilk = false;
        }

        private void _7_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "7"; eded1Yoxla = false; }
            else { EsasLabel.Content += "7"; }
            ilk = false;
        }

        private void _8_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "8"; eded1Yoxla = false; }
            else { EsasLabel.Content += "8"; }
            ilk = false;
        }

        private void _9_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "9"; eded1Yoxla = false; }
            else { EsasLabel.Content += "9"; }
            ilk = false;
        }

        private void _0_Click(object sender, EventArgs e)
        {
            if ((EsasLabel.Content.ToString() == "0" && EsasLabel.Content != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) && EsasLabel.Content.ToString().Length < 2) || ilk) { EsasLabel.Content = "0"; }
            else { EsasLabel.Content += "0"; }
            ilk = false;
        }

        private void bol_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamBol)
            {

                eded2 = double.Parse(EsasLabel.Content.ToString());

                if (eded2 != 0)
                {


                    
                    eded1 /= eded2;
                    EsasLabel.Content = $"{eded1}";
                }
                else { EsasLabel.Content = "Cannot divide by zero"; }
            }
            else
            {

                eded1Yoxla = true;

                devamBol = true;
                devamVur = false;
                devamTopla = false;
                devamCix = false;

                eded1 = double.Parse(EsasLabel.Content.ToString());
               

            }
        }

        private void vur_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamVur)
            {

                eded2 = double.Parse(EsasLabel.Content.ToString());



               
                eded1 *= eded2;
                EsasLabel.Content = $"{eded1}";


            }
            else
            {

                eded1Yoxla = true;

                devamBol = false;
                devamVur = true;
                devamTopla = false;
                devamCix = false;

                eded1 = double.Parse(EsasLabel.Content.ToString());
               


            }
        }

        private void cix_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamCix)
            {

                eded2 = double.Parse(EsasLabel.Content.ToString());


               
                eded1 -= eded2;
                EsasLabel.Content = $"{eded1}";


            }
            else
            {

                eded1Yoxla = true;

                devamBol = false;
                devamVur = false;
                devamTopla = false;
                devamCix = true;

                eded1 = double.Parse(EsasLabel.Content.ToString());


            }
        }

        private void topla_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamTopla)
            {

                eded2 = double.Parse(EsasLabel.Content.ToString());


                
                eded1 += eded2;
                EsasLabel.Content = $"{eded1}";


            }
            else
            {

                eded1Yoxla = true;

                devamBol = false;
                devamVur = false;
                devamTopla = true;
                devamCix = false;

                eded1 = double.Parse(EsasLabel.Content.ToString());
               


            }
        }

        private void beraberdi_Click(object sender, EventArgs e)
        {


            ilk = false;
            if (devamBol)
            {
                eded2 = double.Parse(EsasLabel.Content.ToString());

                if (eded2 != 0)
                {


                   
                    eded1 /= eded2;
                    EsasLabel.Content = $"{eded1}";
                }
                else { EsasLabel.Content = "Cannot divide by zero"; }

                devamBol = false;

            }
            else if (devamVur)
            {

                eded2 = double.Parse(EsasLabel.Content.ToString());
                
               
                eded1 *= eded2;
                EsasLabel.Content = $"{eded1}";

                devamVur = false;
            }
            else if (devamTopla)
            {

                eded2 = double.Parse(EsasLabel.Content.ToString());

                
                eded1 += eded2;

                EsasLabel.Content = $"{eded1}";

                devamTopla = false;

            }
            else if (devamCix)
            {
                eded2 = double.Parse(EsasLabel.Content.ToString());


                
                eded1 -= eded2;

                EsasLabel.Content = $"{eded1}";

                devamCix = false;
            }




        }

        private void button23_Click(object sender, EventArgs e)
        {
            ilk = false;

            bool verguleYoxla = true;

            for (int i = 0; i < EsasLabel.Content.ToString().Length; i++)
            {
                if (EsasLabel.Content.ToString()[i] == ',') { verguleYoxla = false; }
            }

            if (verguleYoxla) { EsasLabel.Content +=  ","; }

        }


    }



}

