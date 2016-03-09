using System;
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

        foreach (JProperty val in value)
        {
            if (val.Name == "column")
            {
                col.column = val.Value.ToString();
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
                col.columnUnits = val.Value.ToString();
            }
        }

        return col;
    }
}