

using System;
using System.Globalization;
/**
* 
* @author d.chistyakov
*
*/
public class ArchiveTableKey {

	public DateTime value_time;
	public int value_int;
	
	public ArchiveTableKey() {
		value_int = 0;
		value_time = new DateTime();
	}
	
	public ArchiveTableKey(int index) {
		value_int = index;
		value_time = new DateTime();
	}

	public ArchiveTableKey(DateTime dateTime) {
		value_time = dateTime;
		value_int = 0;
	}	
}
