
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;

public class ArchiveJob {
	
	/**
	 * тип запрашиваемого архива
	 */
	public ArchiveTypeEnum archiveType;

    /**
	 * время начала опроса архива
	 */
    public DateTime dateStart;

    /**
	 * время конца опроса архива 
	 */
    public DateTime dateFinish;

	public ArchiveJob() {
	}

	public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
	{
		// Java timestamp is millisecods past epoch
		System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
		dtDateTime = dtDateTime.AddSeconds(Math.Round(javaTimeStamp / 1000));
		return dtDateTime;
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
				job.dateStart = JavaTimeStampToDateTime(double.Parse(val.Value.ToString()));
            }
            else if (val.Name == "dateFinish")
            {
				job.dateFinish = JavaTimeStampToDateTime(double.Parse(val.Value.ToString()));
            }
        }

        return job;
    }

    public bool Equals(ArchiveJob job)
    {
        if (this.archiveType == job.archiveType
        && this.dateFinish == job.dateFinish
        && this.dateStart == job.dateStart)
            return true;

        return false;
    }
}
