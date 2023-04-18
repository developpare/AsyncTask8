using System.Diagnostics;

namespace AsyncTask8_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMessage.Text = "Utilizzando il SynchronizationContext risolviamo il problema. \n" +
                "In questo modo la cliccando su Operazione Pesante Start e poi tu Test1 vedremo che i messaggi " +
                "verranno scritti correttamente e la finestra non sarà bloccata";
        }

        private void buttonOperazionePesante_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"UI Thread = {Thread.CurrentThread.ManagedThreadId}");

            UpdateLabelOperation("Click Button Operazione Pesante");

            Thread.Sleep(200);

            Thread threadOperazionePesante = new Thread(OperazionePesanteSyncTest);

            threadOperazionePesante.Start(SynchronizationContext.Current);

        }
        private void OperazionePesanteSyncTest(object? inputSynchronizationContext)
        {
            Debug.WriteLine($"OperazionePesanteSyncTest Thread = {Thread.CurrentThread.ManagedThreadId}");

            SynchronizationContext? synchronizationContext = inputSynchronizationContext as SynchronizationContext;

            synchronizationContext.Post(_ => UpdateLabelOperation("Operazione Pesante Start"), null);

            int progresBarMaximumValue = 500;

            synchronizationContext.Post(_ => progressBarOperazionePesante.Maximum = progresBarMaximumValue, null);

            for (int i = 1; i <= progresBarMaximumValue; i++)
            {
                Thread.Sleep(5);
                var index = i;
                synchronizationContext.Post(_ => progressBarOperazionePesante.Value = index, null);
            }

            synchronizationContext.Post(_ => UpdateLabelOperation("Operazione Pesante End"), null);
        }

        private void UpdateLabelOperation(string message)
        {
            Debug.WriteLine($"UpdateLabelOperation Thread = {Thread.CurrentThread.ManagedThreadId}");

            LabelOperation.Text = message;
            LabelOperation.Update();
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            UpdateLabelOperation("Test1 click");
        }
    }
}