using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Messaging;

namespace msmqProgram
{
	public partial class senderAndReceiver : System.Web.UI.Page
	{
		

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

			MessageQueue myqueue;
			if (MessageQueue.Exists(@".\Private$\MyQueue"))
			{
				myqueue = new MessageQueue(@".\Private$\MyQueue");
			}
			else
			{
				myqueue = MessageQueue.Create(@".\Private$\MyQueue");
			}

			Message msg = new Message();

			msg.Formatter = new BinaryMessageFormatter();
			msg.Body = TextBox1.Text;
			msg.Label = "new message";
			myqueue.Send(msg);
			
			TextBox1.Text = null;

		}

		protected void btnReceive_Click(object sender, EventArgs e)
		{
			//if(MessageQueue.Exists(@".\Private$\MyQueue"))
			//{

				MessageQueue myqueue;
				myqueue = new MessageQueue(@".\Private$\MyQueue");
				Message msg = myqueue.Receive();
				msg.Formatter = new BinaryMessageFormatter();
				TextBox2.Text = msg.Body.ToString();
			
			
			//}
			//else
			//{
			//	TextBox2.Text = "No Message to dispaly";
			//}
		}
	}
}