
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;

public class ArchiveJob {
	
	/**
	 * тип запрашиваемого архива
	 */
	private ArchiveTypeEnum archiveType;
	
	/**
	 * время начала опроса архива
	 */
	private DateTime dateStart;
	
	/**
	 * время конца опроса архива 
	 */
	private DateTime dateFinish;

	public ArchiveJob() {
	}

    internal static ArchiveJob FromXml(JToken values)
    {
        ArchiveJob job = new ArchiveJob();

        foreach (JProperty val in values)
        {
            if (val.Name == "archiveType")
            {
                ArchiveTypeEnum type;

                if (Enum.TryParse(val.Value.ToString(), out type))
                {
                    job.archiveType = type;
                }
            }
            else if (val.Name == "dateStart")
            {
                job.dateStart = new DateTime(long.Parse(val.Value.ToString())*10000 + 621355968000000000);
            }
            else if (val.Name == "dateFinish")
            {
                job.dateFinish = new DateTime(long.Parse(val.Value.ToString()) * 10000 + 621355968000000000);
            }
        }

        return job;
    }
}
