namespace AsyncTask8_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMessage.Text = "La ProgressBar funziona correttamente, " +
                "tuttavia la nostra label con i messaggi non viene aggiornata se non alla fine dell’esecuzione";
        }

        private void buttonOperazionePesante_Click(object sender, EventArgs e)
        {
            LabelOperation.Text = "Click Button Operazione Pesante";

            Thread.Sleep(200);

            OperazionePesanteSyncTest();

            Thread.Sleep(200);

            LabelOperation.Text = "Exit Click Button Operazione Pesante";

        }
        private void OperazionePesanteSyncTest()
        {
            LabelOperation.Text = "Operazione Pesante Start";

            int progresBarMaximumValue = 500;

            progressBarOperazionePesante.Maximum = progresBarMaximumValue;

            for (int i = 1; i <= progresBarMaximumValue; i++)
            {
                Thread.Sleep(2);
                progressBarOperazionePesante.Value = i;
            }

            LabelOperation.Text = "Operazione Pesante End";
        }

    }
}