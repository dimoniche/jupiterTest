
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Text;

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

	/**
	 * Единица измерения
	 */
	public String unit;

	/**
	 * Единица измерения в численном виде
	 */
	public MeasureUnitTypeEnum unitsDigital;

    public Units()
    {

    }

    internal static Units FromXml(JToken value)
    {
        Units unit = new Units();
		UTF8Encoding utf8 = new UTF8Encoding();
		Encoding win1251 = Encoding.GetEncoding("Windows-1251");

        foreach (JProperty val in value)
        {
            if (val.Name == "result")
            {
				ErrorDeviceEnum type;
                if (Enum.TryParse(val.Value.ToString(), out type))
                {
                    unit.result = type;
                }
            }
            else if (val.Name == "name")
            {
                Byte[] encodedBytes = utf8.GetBytes(val.Value.ToString());
				Byte[] win1251Bytes = Encoding.Convert(utf8, win1251, encodedBytes);
				String decodedString = utf8.GetString(win1251Bytes);

                unit.name = decodedString;
            }
			else if (val.Name == "unit")
			{
				Byte[] encodedBytes = utf8.GetBytes(val.Value.ToString());
				Byte[] win1251Bytes = Encoding.Convert(utf8, win1251, encodedBytes);
				String decodedString = utf8.GetString(win1251Bytes);

				unit.unit = decodedString;
			}
			else if (val.Name == "unitsDigital")
			{
				MeasureUnitTypeEnum un;
				if (Enum.TryParse(val.Value.ToString(), out un))
				{
					unit.unitsDigital = un;
				}
			}
            else
            {
                Byte[] encodedBytes = utf8.GetBytes(val.Value.ToString());
                Byte[] win1251Bytes = Encoding.Convert(utf8, win1251, encodedBytes);
                String decodedString = utf8.GetString(win1251Bytes);

                unit.value = decodedString;
            }
        }
  
        return unit;
    }
}
