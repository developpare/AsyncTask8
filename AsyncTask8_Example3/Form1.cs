namespace AsyncTask8_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMessage.Text = "Le singole operazioni funzionano correttamente, ma se provate a cliccare prima " +
                "su Operazione Pesatente Start e poi su Test1 vedrete come la finestra sia completamente bloccata" +
                " e il messaggio che dovrebbe stampare Test1 viene stampato solo quando la nostra operazione pesante" +
                "comclude la sua esecuzione";
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

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            UpdateLabelOperation("Test1 click");
        }
    }
}