using System;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;

namespace Jupiter.Controls
{
    public partial class DeviceControl : UserControl
    {
        public ServerRpc request = new ServerRpc();
        IModel channel;

        public String CorrelationId;

        public DeviceControl()
        {
            InitializeComponent();


        }

        public DeviceControl(IModel channel)
        {
            InitializeComponent();

            this.channel = channel;


        }

        public delegate void changeVisibleHandler();

        public void changeVisible()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new changeVisibleHandler(change));
                return;
            }
            else
            {
                change();
            }
        }

        void change()
        {
            DeviceSetting.Enabled = !DeviceSetting.Enabled;
            DateArchive.Enabled = !DateArchive.Enabled;
            TypeArchive.Enabled = !TypeArchive.Enabled;
            button1.Enabled = !button1.Enabled;

            if(button1.Enabled) result.Text = "Ответ получен";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bus = 0;

            request.busAddress = bus;

            DeviceTypeEnum type = 0;
            Enum.TryParse(devicetype.Text,out type);

            request.device = type;

            request.deviceid = deviceId.Text;
            request.imei = IMEI.Text;
            request.creationTime = DateTime.Now;

            ArchiveJob job = new ArchiveJob();

            if(radioButtonHour.Checked) job.archiveType = ArchiveTypeEnum.HOUR;
            else job.archiveType = ArchiveTypeEnum.DAY;

            job.dateStart = StartArchivedateTime.Value;
            job.dateFinish = FinishArchivedateTime.Value;

            request.archiveJob = job;
            request.timeOutRequest = 15;
            request.timeOutTask = 300;
            request.requestType = RequestServerTypeEnum.GET_ARCHIVE;

            DeviceSetting.Enabled = false;
            DateArchive.Enabled = false;
            TypeArchive.Enabled = false;

            result.Text = "Пошел запрос";

            button1.Enabled = false;

            Guid corrId = new Guid();
            corrId = Guid.NewGuid();  
            BasicProperties props = new BasicProperties();
            props.CorrelationId = corrId.ToString();
            request.requestId = props.CorrelationId;
  
            channel.BasicPublish("","jupiter.transport.fromserver", props, ServerRpc.toJson(request));
        }
    }
}
