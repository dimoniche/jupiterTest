
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class Units {
	/**
	 *  Результат получения данных
	 */
	public ErrorDeviceEnum result;

	/**
	 * Полученное значение
	 */
	public List<String> value;
	
    public Units()
    {

    }

    internal static Units FromXml(JToken value)
    {
        Units unit = new Units();

        foreach (JProperty val in value)
        {
            ErrorDeviceEnum type;

            if (val.Name == "result")
            {
                if (Enum.TryParse(val.Value.ToString(), out type))
                {
                    unit.result = type;
                }
            }
            else
            {
                List<String> list_value = new List<string>();

                foreach (JArray obj in val)
                {
                    for (int i = 0; i < obj.Count; i++)
                        list_value.Add(obj[i].ToString());
                }
            }
        }
  
        return unit;
    }
}
