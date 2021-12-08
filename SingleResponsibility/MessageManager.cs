using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    /// <summary>
    /// Message manager wich holds logic for sending messages.
    /// This class can be edited.
    /// </summary>
    public class MessageManager
    {

        private Converter convert;
        public MessageManager()
        {
            convert = new Converter();
        }

        /// <summary>
        /// Sends message as Smtp.
        /// </summary>
        /// <param name="type">Type of message to send</param>
        /// <param name="m">All the message information</param>
        /// <param name="isHTML">If true it converts the body to HTML else not</param>
        public void SendSmtpMessage(MessageCarrier type, MessageInfo m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                //her implementeres alt koden til at sende via Smtp
            }
        }

        /// <summary>
        /// Sends message as VMessage.
        /// </summary>
        /// <param name="type">Type of message to send</param>
        /// <param name="m">All the message information</param>
        /// <param name="isHTML">If true it converts the body to HTML else not</param>
        public void SendVMessage(MessageCarrier type, MessageInfo m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                //her implementeres alt koden til at sende via VMessage
            }
        }

        /// <summary>
        /// Sends multiple Smtp messages.
        /// </summary>
        /// <param name="type">Type of message to send</param>
        /// <param name="to">Everyone who should receive this message</param>
        /// <param name="m">All the message information</param>
        /// <param name="isHTML">If true it converts the body to HTML else not</param>
        public void SendMessageToMultipleSmtp(MessageCarrier type, string[] to, MessageInfo m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                //her implementeres alt koden til at sende via Smtp
            }
        }

        /// <summary>
        /// Sends multiple VMessages.
        /// </summary>
        /// <param name="type">Type of message to send</param>
        /// <param name="to">Everyone who should receive this message</param>
        /// <param name="m">All the message information</param>
        /// <param name="isHTML">If true it converts the body to HTML else not</param>
        public void SendMessageToMultipleVMessage(MessageCarrier type, string[] to, MessageInfo m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                //her implementeres alt koden til at sende via VMessage
            }
        }

        /// <summary>
        /// Converts the body to html.
        /// </summary>
        /// <param name="m">All the message information</param>
        /// <param name="isHTML">If true it converts the body to HTML else not</param>
        public void ConvertBodyToHTML(MessageInfo m, bool isHTML)
        {
            if (isHTML)
                m.Body = convert.ConvertToHTML(m.Body);
        }
    }
}
