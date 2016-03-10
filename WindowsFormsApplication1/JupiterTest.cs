using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Newtonsoft.Json.Linq;
using Jupiter.Controls;

namespace Jupiter
{
    public partial class JupiterTest : Form
    {
        ConnectionFactory factory;
        IConnection conn;
        IModel channel;

        ServerRpc request;
        List<DeviceControl> device = new List<DeviceControl>();

        public JupiterTest()
        {
            InitializeComponent();

        }

        void fromTransportResponse(byte[] response)
        {
            request = ServerRpc.fromJson(JObject.Parse(Encoding.Default.GetString(response)));
            DeviceControl dev;

            dev = device.Where<DeviceControl>(c => c.request.imei.Equals(request.imei)).FirstOrDefault();

            if(dev != null)
            {
                dev.resultResponseView.InsertUnitsRow(request.units);
                if (!dev.resultResponseView.columnLoaded)
                {
                    dev.resultResponseView.InsertArchiveColumn(request.header);
                }
                dev.resultResponseView.InsertArchiveRow(request.rows);
            }
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

        public delegate void newDevice(object sender, EventArgs e);

        private void button1_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new newDevice(newDeviceinsert), sender,e);
                return;
            }
            else
            {
                newDeviceinsert(sender,e);
            }
        }

        public void newDeviceinsert(object sender, EventArgs e)
        {
            TabPage page = new TabPage("Name" + devicesTab.TabPages.Count);
            DeviceControl dev = new DeviceControl(channel);

            page.Controls.Add(dev);
            devicesTab.TabPages.Add(page);

            device.Add(dev);

        }

        private void button3_Click(object sender, EventArgs e)
        {
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

            state.Text = "Подключение";
        }
    }
}
