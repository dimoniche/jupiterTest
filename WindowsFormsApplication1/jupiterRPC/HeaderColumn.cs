using System;
using System.Text;
using Newtonsoft.Json.Linq;

public class HeaderColumn
{
    /**
 * Название колонки
 */
    public string column;

    /**
	 * Единица измерения колонки
	 */
    public string columnUnits;

    /**
	 * Единица измерения колонки в численном виде
	 */
    public MeasureUnitTypeEnum columnUnitsDigital;

    internal static HeaderColumn FromXml(JToken value)
    {
        HeaderColumn col = new HeaderColumn();
		UTF8Encoding utf8 = new UTF8Encoding();
		Encoding win1251 = Encoding.GetEncoding("Windows-1251");

        foreach (JProperty val in value)
        {
            if (val.Name == "column")
            {
				Byte[] encodedBytes = utf8.GetBytes(val.Value.ToString());
				Byte[] win1251Bytes = Encoding.Convert(utf8, win1251, encodedBytes);
				String decodedString = utf8.GetString(win1251Bytes);

				col.column = decodedString;
            }
            else if (val.Name == "columnUnitsDigital")
            {
                MeasureUnitTypeEnum type;

                if (Enum.TryParse(val.Value.ToString(), out type))
                {
                    col.columnUnitsDigital = type;
                }
            }
            else if (val.Name == "columnUnits")
            {
				Byte[] encodedBytes = utf8.GetBytes(val.Value.ToString());
				Byte[] win1251Bytes = Encoding.Convert(utf8, win1251, encodedBytes);
				String decodedString = utf8.GetString(win1251Bytes);

				col.columnUnits = decodedString;
            }
        }

        return col;
    }
}