using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Jupiter.Controls;
using Jupiter.Forms;

namespace Jupiter
{
    public partial class JupiterTest : Form
    {
        ConnectionFactory factory;
        IConnection conn;
        IModel channel;

        ServerRpc request;
        Dictionary<String, ServerRpc> Requests;

        public JupiterTest()
        {
            InitializeComponent();

            factory = new ConnectionFactory();
            factory.UserName = "devel";
            factory.Password = "devel";
            factory.VirtualHost = "/";
            factory.HostName = "parabox.org";

            conn = factory.CreateConnection();

            channel = conn.CreateModel();

            channel.QueueDeclare("jupiter.transport.toserver", true, false, false, null);
            channel.QueueDeclare("jupiter.transport.toserver.callback", true, false, false, null);

            channel.QueueDeclare("jupiter.transport.fromserver", true, false, false, null);
            channel.QueueDeclare("jupiter.transport.fromserver.callback", true, false, false, null);

            EventingBasicConsumer consumerToServer = new EventingBasicConsumer(channel);
            consumerToServer.Received += (ch, ea) =>
            {
                var body = ea.Body;

                fromTransportResponse(ea.Body);

                try
                {
                    //channel.BasicAck(ea.DeliveryTag, false);
                }
                catch
                {

                }
            };
            String consumerTag1 = channel.BasicConsume("jupiter.transport.toserver", false, "", consumerToServer);

            //DeviceControl device = new DeviceControl();
            //device.Visible = true;

            //Device dev = new Device();

            //JupiterTest.ActiveForm.MdiParent = dev;
        }

        void fromTransportResponse(byte[] response)
        {
            request = ServerRpc.fromJson(JObject.Parse(Encoding.Default.GetString(response)));

            resultResponseViewJupiter.InsertUnitsRow(request.units);

            request.deviceid = "0";
        }

        private void JupiterTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (channel != null)
            {
                channel.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
