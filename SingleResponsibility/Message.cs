using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public enum MessageCarrier { Smtp, VMessage }

    /// <summary>
    /// Message class that sends messages
    /// This class must not be edited.
    /// Go to MessageManager to change the logic.
    /// </summary>
    public class Message
    {
        private MessageManager manager;
        public Message()
        {
            manager = new MessageManager();
        }

        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="type">Type of message to send</param>
        /// <param name="m">All the message information</param>
        /// <param name="isHTML">If true it converts the body to HTML else not</param>
        public void SendMessage(MessageCarrier type, MessageInfo m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            manager.ConvertBodyToHTML(m, isHTML);
            manager.SendSmtpMessage(type, m, isHTML);
            manager.SendVMessage(type, m, isHTML);
        }

        /// <summary>
        /// Sends a message to multiple people
        /// </summary>
        /// <param name="type">Type of message to send</param>
        /// <param name="to">Everyone who should receive this message</param>
        /// <param name="m">All the message information</param>
        /// <param name="isHTML">If true it converts the body to HTML else not</param>
        public void SendMessageToMultiple(MessageCarrier type, string[] to, MessageInfo m, bool isHTML)
        {
            //herinde sendes der en email ud til flere modtagere
            manager.ConvertBodyToHTML(m, isHTML);
            manager.SendMessageToMultipleSmtp(type, to, m, isHTML);
            manager.SendMessageToMultipleVMessage(type, to, m, isHTML);
        }

        
    }
}
