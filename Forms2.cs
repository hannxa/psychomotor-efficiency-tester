using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace zad2_poskx
{
    public partial class Forms2 : Form
    {
        private Timer timer;
        private Random random;
        private Button[] buttons;
        private int nrTryPossible;
        private int nrTry;
        private int nrSeries = 1;
        private string series;
        private bool soundTestActive = false;
        private SoundPlayer soundPlayer;
        private float averageValue;
        private float averageValueFromAll;
        public bool IsTrainingCompleted { get; set; } //przez konstruktor przekazujemy bool
        private DateTime startTime;
        private Dictionary<int, float> reactionTimes = new Dictionary<int, float>();
        private Dictionary<int, float> averageReactionTimes = new Dictionary<int, float>();

        public Forms2(bool isTrainingCompleted)
        {
            InitializeComponent();
            IsTrainingCompleted = isTrainingCompleted; //ustawianie wartosci przy tworzeniu formularza
            InitializeGame();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OnKeyDown);
        }

        private void InitializeGame()
        {
            if (!IsTrainingCompleted)
            {
                average_serie_label.Visible = false; //tylko brak widocznosci w treningu
            }

            chart1.Visible = false;
            nrTryPossible = 6;
            nrTry = 0;
            timer = new Timer();
            timer.Tick += timer1_Tick;
            random = new Random();
            buttons = new Button[] { button1, button2, button3 };

            soundPlayer = new SoundPlayer("C:\\Users\\akabe\\source\\repos\\zad2_poskx\\zad2_poskx\\Resources\\movieSound.wav");

            timer.Interval = random.Next(500, 2000);
            timer.Start();
            //przez cala gierke brak widoczności, tylko po zakonczniu
            close_button.Enabled = false;
            repeat_button.Enabled = false;
            averageValuesButton.Enabled = false;
            averageValues_label.Visible = false;
            chart1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ResetButtons();
            ilosci.Text = "Twoja liczba pozostałych prób: " + (nrTryPossible - nrTry);
            if (nrTry == nrTryPossible)
            { //zakonczenie serii
                soundPlayer.Stop();
                timer.Stop();
                if (IsTrainingCompleted)
                {
                    allAverage();
                    averageValue = reactionTimes.Values.Average();
                    average_serie_label.Text = $"Średnia wartość z serii {nrSeries}: {averageValue} ms";
                }
                feedbackLabel.Text = "Koniec gry! Kliknij 'Zamknij' aby zakończyć.";
                //wszystkie klawisze na koniec gry włączamy
                close_button.Enabled = true;
                repeat_button.Enabled = true;
                averageValuesButton.Enabled = true;
            }
            else
            {
                startTime = DateTime.Now;
                if (random.Next(2) == 0)
                {
                    StartVisualTest();
                }
                else
                {
                    StartSoundTest();
                }
                timer.Interval = random.Next(500, 2000);
                timer.Start();
                nrTry++;
            }
        }
        private void StartVisualTest()
        {
            soundTestActive = false;
            int buttonIndex = random.Next(buttons.Length);
            Button activeButton = buttons[buttonIndex];

            activeButton.Enabled = true;
            activeButton.BackColor = System.Drawing.Color.Green;
            feedbackLabel.Text = "Wciśnij odpowiedni klawisz A/W/D, gdy zmieni się kolor!";
        }
        private void StartSoundTest()
        {
            soundTestActive = true;
            soundPlayer.Play();
            feedbackLabel.Text = "Wciśnij spacje, gdy usłyszysz dźwięk!";
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (soundTestActive)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        feedbackLabel.Text = "Udało Ci się trafić w dźwięk!";
                        soundTestActive = false;
                        GetReaction(); //jezeli sie trafi
                    }
                    else
                    {
                        FalseClick(); //jezeli sie nie trafi
                    }
                }
                else if (!soundTestActive)
                {
                    if (button1.Enabled && e.KeyCode == Keys.A)
                    {
                        feedbackLabel.Text = "Udało Ci się trafić w lewy przycisk!";
                        GetReaction();
                    }
                    else if (button2.Enabled && e.KeyCode == Keys.W)
                    {
                        feedbackLabel.Text = "Udało Ci się trafić w środkowy przycisk!";
                        GetReaction();
                    }
                    else if (button3.Enabled && e.KeyCode == Keys.D)
                    {
                        feedbackLabel.Text = "Udało Ci się trafić w prawy przycisk!";
                        GetReaction();
                    }
                    else
                    {
                        FalseClick();
                    }
                }
                soundPlayer.Stop();
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ResetButtons()
        {
            soundPlayer.Stop();
            foreach (Button button in buttons)
            {
                button.Enabled = false;
                button.BackColor = DefaultBackColor;
            }
        }

        private void FalseClick()
        {
            reactionTimes.Add(nrTry, 0);
        }
        private void GetReaction()
        {
            if (IsTrainingCompleted)
            {
                float reactionTime = (float)(DateTime.Now - startTime).TotalMilliseconds;
                average_serie_label.Text = $"Czas reakcji z  {nrTry} próby: {reactionTime} ms";
                reactionTimes.Add(nrTry, reactionTime); // zapisujemy czasy z pojedycznej serii
            }
        }

        private void averageValuesButton_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            averageValues_label.Text = $"Średnia wartość z wszystkich serii: {averageValueFromAll} ms";
            averageValues_label.Visible = true;

            foreach (var trial in averageReactionTimes) //petlujemy kazda wartosci z averageReactionTimes
            {
                try
                {
                    int trialNumber = trial.Key;
                    double reactionTime = trial.Value;
                    chart1.Series[series].Points.AddXY(trialNumber, reactionTime);
                }
                catch (System.ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
        private void allAverage()
        {
            //przygotowywanie obliczen do wyswietlania, po nacisnieciu buttonu
            averageValue = reactionTimes.Values.Average(); //obliczanie sredniej z listy reactionTimes
            averageReactionTimes.Add(nrSeries, averageValue);   //srednia z jednej serii
            series = nrSeries + " serii";
            averageValueFromAll = averageReactionTimes.Values.Average(); //srednia ze wszystkichs srednich

            chart1.Series.Add(series);
            chart1.Series[series].ChartType = SeriesChartType.Bubble;
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            timer.Stop();
            IsTrainingCompleted = true;
            this.Close();
        }
        private void repeat_button_Click(object sender, EventArgs e)
        {
            if (IsTrainingCompleted) //nie mozna rysowac wykresu i dodawac serii jak jestesmy w fazie szkoleniowej
            {
                reactionTimes.Clear(); // Usuwamy poprzednie dane dla nowego testu
            }
            nrSeries++; // dodajemy kolejną serie
            InitializeGame(); //resetowanie gry
        }
    }
}
