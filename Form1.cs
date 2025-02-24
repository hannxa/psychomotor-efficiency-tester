using System;
using System.Windows.Forms;

namespace zad2_poskx
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += informativeLabel; //aby automatycznie wyswietlilo sie na ekranie
        }
        private void informativeLabel(object sender, EventArgs e)
        {
            label1.Text = "Witaj! Naciśnij 'start' aby przeczytać instrukcję.";
            szkolenie_button.Enabled = false;
            test_button.Enabled = false;
        }
        private void start_Click(object sender, EventArgs e)
        {
            label1.Text = "Test polega na sprawdzeniu twoich zdolności psychometrycznych, \n" +
                "w którym będzisz miał 6 prób w jednej serii na jak najszybszą reakcje \n" +
                "na bodźcie optyczne i akustyczne. Test będzie polegać na wskazywaniu \n" +
                "odpowiednich prostokątków (A- lewy, W- górny, D- prawy), \n" +
                "gdy zmienią one swój kolor lub wciśnieciu spacji, gdy usłyszysz dźwięk. \n" +
                "Na początku przejdź odpowiednie szkolenie, w którym nie będziesz podlegać ocenie. \n\n" +
                "POWODZENIA!";
            szkolenie_button.Enabled = true;
            test_button.Enabled = false;
            start_button.Enabled = false;
        }
        private void szkolenie_button_Click(object sender, EventArgs e)
        {
            Forms2 symulacja = new Forms2(false);
            symulacja.ShowDialog();
            szkolenie_button.Enabled = false;
            if (symulacja.IsTrainingCompleted)
            {
                test_button.Enabled = true;
            }
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            Forms2 symulacja = new Forms2(true); //instancja nowego formularza
            symulacja.ShowDialog();
        }
    }
}
