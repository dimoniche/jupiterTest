using System;
using System.Windows.Forms;
using RabbitMQ.Client;

namespace Jupiter.Controls
{
    public partial class DeviceControl : UserControl
    {
        public ServerRpc request = new ServerRpc();
        IModel channel;

        public DeviceControl()
        {
            InitializeComponent();


        }

        public DeviceControl(IModel channel)
        {
            InitializeComponent();

            this.channel = channel;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bus = 1;

            int.TryParse(textBox1.Text,out bus);

            request.busAddress = bus;

            int type = 0;
            int.TryParse(devicetype.Text,out type);

            request.device = (DeviceTypeEnum)type;

            request.deviceid = deviceId.Text;
            request.imei = IMEI.Text;

            ArchiveJob job = new ArchiveJob();

            if(radioButtonHour.Checked) job.archiveType = ArchiveTypeEnum.HOUR;
            else job.archiveType = ArchiveTypeEnum.DAY;

            job.dateStart = StartArchivedateTime.Value;
            job.dateFinish = FinishArchivedateTime.Value;

            request.archiveJob = job;

            DeviceSetting.Enabled = false;
            DateArchive.Enabled = false;
            TypeArchive.Enabled = false;

            result.Text = "Пошел запрос";


			channel.BasicPublish("", "jupiter.transport.fromserver", null, ServerRpc.toJson(request));
        }
    }
}
