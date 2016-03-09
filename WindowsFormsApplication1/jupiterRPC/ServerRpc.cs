

using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
/**
* Класс для передачи заданий драйверам устройств
* 
* @author d.chistyakov
* 
*/
public class ServerRpc {

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
	public Calendar creationTime;
	
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
		timeOutTask = 120;
		timeOutRequest = 3;
		//creationTime = Calendar.GetInstance();
	}

	public static ServerRpc fromJson(JObject objects)
    {
        ServerRpc result = new ServerRpc();

		foreach(var obj in objects)
        {
			if(obj.Key == "deviceid")
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
                result.errorText = obj.Value.ToString();
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
