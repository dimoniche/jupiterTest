

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Text;
/**
* Описание полученной архивной записи
* @author d.chistyakov
*
*/
public class Row {
	
	/**
	 * Время или индекс записи
	 */
	public ArchiveTableKey key;
	
	/**
	 *  Результат получения данных
	 */
	public ErrorDeviceEnum result;

	/**
	 * Полученное значение
	 */
	public List<String> value;

    public Row()
    {
    }

    public Row(Row row) {
		key = row.key;
		result = row.result;
		value = row.value;
	}

    internal static Row FromXml(JToken value)
    {
        Row row = new Row();
        UTF8Encoding utf8 = new UTF8Encoding();
        Encoding win1251 = Encoding.GetEncoding("Windows-1251");

        foreach (JProperty val in value)
        {
            if (val.Name == "key")
            {
                ArchiveTableKey key = new ArchiveTableKey();
                foreach (JObject obj in val)
                {
                    key.value_time = new DateTime(long.Parse(obj["value_time"].ToString()) * 10000 + 621355968000000000);
                }

                row.key = key;
            }
            else if (val.Name == "result")
            {
                ErrorDeviceEnum type;

                if (Enum.TryParse(val.Value.ToString(), out type))
                {
                    row.result = type;
                }
            }
            else if (val.Name == "value")
            {
                List<String> list_value = new List<string>();

                foreach (JArray obj in val)
                {
                    for(int i = 0; i < obj.Count; i++)
                    {
                        Byte[] encodedBytes = utf8.GetBytes(obj[i].ToString());
                        Byte[] win1251Bytes = Encoding.Convert(utf8, win1251, encodedBytes);
                        String decodedString = utf8.GetString(win1251Bytes);

                        list_value.Add(decodedString);
                    }
                }

                row.value = list_value;
            }
        }

        return row;
    }
}
