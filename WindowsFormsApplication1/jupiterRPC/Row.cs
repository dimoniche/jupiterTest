

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
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
                        list_value.Add(obj[i].ToString());
                    }
                }

                row.value = list_value;
            }
        }

        return row;
    }
}
