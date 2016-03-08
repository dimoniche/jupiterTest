
/**
 * Список ошибок работы с прибором
 * @author d.chistyakov
 *
 */
public enum ErrorDeviceEnum {
	OK ,
	UNKNOWN ,
	ERROR ,
	
	NO_MAKE_COMPLETE_REQUEST,
	NO_COMPLETE_REQUEST,
	BAD_ADDRESS ,
	BAD_DATA,
	BAD_FORMAT,
	
	INCLOMPLETE_PACKAGE,
	
	/**
	 * Нарушение структуры запроса
	 */
	LOGIKA_BAD_REQUEST ,
	
	/**
	 * Защита от ввода параметра
	 */
	LOGIKA_ACCESS_DENIED,
	
	/**
	 * Недопустимые значения параметров запроса
	 */
	LOGIKA_WRONG_DATA ,
	
	/**
	 * Нет данных
	 */
	LOGIKA_NO_DATA ,
	
	/**
	 * Нет соединения
	 */
	NO_CONNECTION ,
	
	/**
	 * прибор занят
	 */
	DEVICE_BUSY, 
	
	/**
	 * тайм аут задачи
	 */
	DEVICE_TIME_OUT,
	
	/**
	 * тайм аут запроса к прибору
	 */

	REQUEST_TIME_OUT,

}
