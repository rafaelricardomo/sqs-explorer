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
    public partial class MessageForm : Form
    {
        private readonly IMessageService _messageService;

        private static Core.Entidades.Queue _queueSelected;

        private static Core.Entidades.Queue getQueueSelected()
        {
            return _queueSelected;
        }

        public static void SetQueueSelected(Core.Entidades.Queue queue)
        {
            _queueSelected = queue;            
        }

        private Core.Entidades.Message LastMessage { get; set; }

        public MessageForm(IMessageService messageService)
        {
            InitializeComponent();
            reset();
            _messageService = messageService;            
        }

        private void  loadQueueSelected()
        {
            var queueSelected = getQueueSelected();
            if (queueSelected == null) return;

            lblQueueSelected.Text = queueSelected.Name;
        }

        private async Task sendMessages()
        {
            var queueSelected = getQueueSelected();
            if (queueSelected == null) return;

            var messageText = textBox1.Text;

            var sentMessage =  await _messageService.SendMessage(messageText, queueSelected.Name);
            if (sentMessage)
                MessageBox.Show("Mensagem enviada.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mensagem com falha no envio.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task receiveMessage()
        {
            var queueSelected = getQueueSelected();
            if (queueSelected == null) return;

            var message = await _messageService.GetMessage(queueSelected.Name);
            if (message == null)
            {
                MessageBox.Show("Sem mensagem para retorno.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                return;
            }

            LastMessage = message;

            lblReceivedLastMessageId.Text = message.Id;
            textBox1.Text = message.Content;
        }

        private async Task deleteMessage()
        {
            var queueSelected = getQueueSelected();
            if (queueSelected == null) return;

            if (LastMessage == null) return;

            var deletedMessage = await _messageService.DeleteMessage(LastMessage.QueueIdentifier, queueSelected.Name);
            if (deletedMessage)
                MessageBox.Show("Mensagem deletada Ok.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mensagem com falha na exclusão.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void reset()
        {
            LastMessage = null;
            textBox1.Text = string.Empty;
            lblReceivedLastMessageId.Text = string.Empty;
        }

        private void btSendMessages_Click(object sender, EventArgs e)
        {
            sendMessages();
            reset();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btReceiveLastMessageSelectedQueue_Click(object sender, EventArgs e)
        {
            receiveMessage();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            loadQueueSelected();
            reset();
        }

        private void btDeleteLastMessage_Click(object sender, EventArgs e)
        {
            deleteMessage();
            reset();
        }
    }
}
