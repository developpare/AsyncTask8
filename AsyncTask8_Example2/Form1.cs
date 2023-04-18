namespace AsyncTask8_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMessage.Text = "In questo modo siamo stati in grado di vedere la nostra Label aggiornarsi di volta in volta " +
                "con i valori giusti, tuttavia non è una buona prassi e  comunque non funziona con tutti i problemi";
        }

        private void buttonOperazionePesante_Click(object sender, EventArgs e)
        {
            UpdateLabelOperation("Click Button Operazione Pesante");

            Thread.Sleep(200);

            OperazionePesanteSyncTest();

            Thread.Sleep(200);

            UpdateLabelOperation("Exit Click Button Operazione Pesante");

        }
        private void OperazionePesanteSyncTest()
        {
            UpdateLabelOperation("Operazione Pesante Start");

            int progresBarMaximumValue = 500;

            progressBarOperazionePesante.Maximum = progresBarMaximumValue;

            for (int i = 1; i <= progresBarMaximumValue; i++)
            {
                Thread.Sleep(5);
                progressBarOperazionePesante.Value = i;
            }

            UpdateLabelOperation("Operazione Pesante End");

        }
        private void UpdateLabelOperation(string message)
        {
            LabelOperation.Text = message;
            LabelOperation.Update();
        }


    }
}