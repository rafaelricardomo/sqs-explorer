using SQSExplorer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQSExplorer
{
    public partial class MainForm : Form
    {
        private readonly IQueueService _queueService;
        private readonly MessageForm _messageForm;

        private static Core.Entidades.Queue _queueSelected;
        public static Core.Entidades.Queue getQueueSelected()
        {
            return _queueSelected;
        }

        private static void  SetQueueSelected(Core.Entidades.Queue queue)
        {
            _queueSelected = queue;
        }


        public MainForm(IQueueService queueService, MessageForm messageForm)
        {
            InitializeComponent();

            _queueService = queueService;
            _messageForm = messageForm;

           loadQueues();
        }

        private string getDetail(Core.Entidades.Queue queue)
        {
            var queueDetails = new StringBuilder();

            queueDetails.AppendLine(String.Concat("Name: ", queue.Name));
            queueDetails.AppendLine(String.Concat("Url: ", queue.Url));

            queueDetails.AppendLine();

            foreach (var item in queue.Especificacoes)
                queueDetails.AppendLine(String.Concat(item.Key, " ", item.Value));

            return queueDetails.ToString();
        }

        private async Task getQueue(string url)
        {
            textBoxEspecificacoesQueue.Text = string.Empty;

            var queue = await _queueService.Get(url);
            if (queue == null) return;          
            
            textBoxEspecificacoesQueue.Text = getDetail(queue);

            SetQueueSelected(queue);
        }
        
        private async Task loadQueues()
        {
            var queues = await _queueService.ListAll();

            listBoxQueues.DataSource = queues;            
          
            listBoxQueues.DisplayMember = "Name";
            listBoxQueues.ValueMember = "Name";

            // Bind the SelectedValueChanged event to our handler for it.
            listBoxQueues.SelectedValueChanged +=
                new EventHandler(ListBox1_SelectedValueChanged);

            // Ensure the form opens with no rows selected.
            listBoxQueues.ClearSelected();
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxQueues.SelectedValue == null) return;

            getQueue(listBoxQueues.SelectedValue.ToString());

        }

        private void btRefreshQueues_Click(object sender, EventArgs e)
        {
            loadQueues();
        }

      
        private void btSendMessageSelectedQueue_Click(object sender, EventArgs e)
        {
            var queueSelected = getQueueSelected();
            if (queueSelected == null)
            {
                MessageBox.Show("No queue selected.", "Queue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageForm.SetQueueSelected(queueSelected);
            _messageForm.ShowDialog();
        }

       

    }
}
