

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/**
* Класс для передачи заданий драйверам устройств
* 
* @author d.chistyakov
* 
*/
public class ServerRpc {

 
    public String requestId;


    /**
	 * Идентификатор прибора должен быть уникальным - серийный номер
	 */
    public String deviceid;
	
	/**
	 * Описание прибора к которому нужно сформировать запрос
	 * 
	 */
	public DeviceTypeEnum device;
	
	/**
	 * Адрес прибора - заполняется дата сервером
	 */
	public int busAddress;

	/**
	 * Идентификатор устройства связи, для поиска его контекста - заполняется дата сервером
	 */
	public String imei;

	/**
	 * тип запроса - получение данных, запись данных, просто соединение и тд
	 */
	public RequestServerTypeEnum requestType;
	
	/**
	 * Описание задачи опроса архива - заполняется дата сервером
	 */
	public ArchiveJob archiveJob;

	/**
	 * Тайм аут выполнения задачи
	 */
	public int timeOutTask;

	/**
	 * Тайм аут запроса к прибору
	 */
	public int timeOutRequest;

	/**
	 * необходим, если нужно будет опрашивать и параметры прибора
	 * Это ключ для поиска описания параметра прибора в базе или справочнике
	 */
	public int ParamId;
	
	/**
	 * Время создания запроса
	 */
	public DateTime creationTime;
	
	// ниже результат обмена с прибором

	/**
	 * Результат запроса
	 */
	public ErrorDeviceEnum error;

	/**
	 * Описание результата запроса
	 */
	public String errorText;

    /**
	 * Заголовок архива
	 */
    public List<HeaderColumn> header;

    /**
	 * Строки полученного от прибора архива
	 */
    public List<Row> rows;
	
	/**
	 * Единицы измерений из прибора
	 */
	public List<Units> units;

	/**
	 *  Величина, предназначенная для записи в прибор
	 */
	public String valueWrite;

	public ServerRpc() {
		timeOutTask = 3600;
		timeOutRequest = 3;
		//creationTime = Calendar.GetInstance();
	}

    static byte[] GetBytes(string str)
    {
        byte[] bytes = new byte[str.Length * sizeof(char)];
        System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
        return bytes;
    }

    public static long ConvertToUnixTimestamp(DateTime date)
    {
        DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        TimeSpan diff = date - origin;

        return (long)Math.Floor(diff.TotalMilliseconds);
    }

    public static byte[] toJson(ServerRpc objects)
	{
        JObject jsonObj = 
            new JObject(new JProperty("requestId", JToken.FromObject(objects.requestId)),
                        new JProperty("deviceid", JToken.FromObject(objects.deviceid)),
                        new JProperty("device", JToken.FromObject(objects.device.ToString())),
                        new JProperty("busAddress", JToken.FromObject(objects.busAddress)),
                        new JProperty("imei", JToken.FromObject(objects.imei)),
                        new JProperty("requestType", JToken.FromObject(JToken.FromObject(objects.requestType.ToString()))),
                        new JProperty("archiveJob",
                            new JObject(
                                new JProperty("archiveType", JToken.FromObject(objects.archiveJob.archiveType.ToString())),
                                new JProperty("dateStart", JToken.FromObject(ConvertToUnixTimestamp(objects.archiveJob.dateStart))),
                                new JProperty("dateFinish", JToken.FromObject(ConvertToUnixTimestamp(objects.archiveJob.dateFinish)))
                                )
                            ),
                        new JProperty("timeOutTask", JToken.FromObject(objects.timeOutTask)),
                        new JProperty("timeOutRequest", JToken.FromObject(objects.timeOutRequest)),
                        new JProperty("ParamId", JToken.FromObject(objects.ParamId)),
                        new JProperty("creationTime", JToken.FromObject(ConvertToUnixTimestamp(objects.creationTime)))
            );

        UTF8Encoding utf8 = new UTF8Encoding();
        Encoding win1251 = Encoding.GetEncoding("Windows-1251");
        Byte[] encodedBytes = win1251.GetBytes(jsonObj.ToString());
        Byte[] win1251Bytes = Encoding.Convert(win1251, utf8, encodedBytes);
        String decodedString = utf8.GetString(win1251Bytes);

        byte[] json = utf8.GetBytes(decodedString);

        return json;
	}

	public static ServerRpc fromJson(JObject objects)
    {
        ServerRpc result = new ServerRpc();
		UTF8Encoding utf8 = new UTF8Encoding();
		Encoding win1251 = Encoding.GetEncoding("Windows-1251");

		foreach(var obj in objects)
        {
			if(obj.Key == "requestId")
            {
                result.requestId = obj.Value.ToString();
            }
            else if (obj.Key == "deviceid")
            {
                result.deviceid = obj.Value.ToString();
            }
            else if (obj.Key == "device")
            {
                DeviceTypeEnum type;

                if (Enum.TryParse(obj.Value.ToString(), out type))
                {
                    result.device = type;
                }
            }
            else if (obj.Key == "busAddress")
            {
                result.busAddress = int.Parse(obj.Value.ToString());
            }
            else if (obj.Key == "imei")
            {
                result.imei = obj.Value.ToString();
            }
            else if (obj.Key == "requestType")
            {
                RequestServerTypeEnum type;

                if (Enum.TryParse(obj.Value.ToString(), out type))
                {
                    result.requestType = type;
                }
            }
            else if (obj.Key == "archiveJob")
            {
                result.archiveJob = ArchiveJob.FromXml(obj.Value);
            }
            else if (obj.Key == "error")
            {
                ErrorDeviceEnum error;

                if (Enum.TryParse(obj.Value.ToString(), out error))
                {
                    result.error = error;
                }
            }
            else if (obj.Key == "errorText")
            {
				Byte[] encodedBytes = utf8.GetBytes(obj.Value.ToString());
				Byte[] win1251Bytes = Encoding.Convert(utf8, win1251, encodedBytes);
				String decodedString = utf8.GetString(win1251Bytes);

				result.errorText = decodedString;
            }
            else if (obj.Key == "header")
            {
                result.header = new List<HeaderColumn>();

                foreach (JToken val in obj.Value)
                {
                    result.header.Add(HeaderColumn.FromXml(val));
                }
            }
            else if (obj.Key == "rows")
            {
                result.rows = new List<Row>();

                foreach (JToken val in obj.Value)
                    result.rows.Add(Row.FromXml(val));
            }
            else if (obj.Key == "units")
            {
                result.units = new List<Units>();
                foreach (JToken val in obj.Value)
                    result.units.Add(Units.FromXml(val));
            }
        }

        return result;
    }
}
