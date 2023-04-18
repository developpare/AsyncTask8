namespace AsyncTask8_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMessage.Text = "Se proviamo a mandare in esecuzione la nostra operazione pesante su un Thread dedicato otterremo" +
                "un Exception: System.InvalidOperationException: Operazione cross-thread non valida \n" +
                "Cliccate su Operazione Pesante Start";
        }

        private void buttonOperazionePesante_Click(object sender, EventArgs e)
        {
            UpdateLabelOperation("Click Button Operazione Pesante");

            Thread.Sleep(200);

            Thread threadOperazionePesante = new Thread(OperazionePesanteSyncTest);

            threadOperazionePesante.Start();

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