
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
	public String value;

    public String name;

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
            else if (val.Name == "name")
            {
                unit.name = val.Value.ToString();
            }
            else
            {
                List<String> list_value = new List<string>();

                unit.value = val.Value.ToString();
            }
        }
  
        return unit;
    }
}
