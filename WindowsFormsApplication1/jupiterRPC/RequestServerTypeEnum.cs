
/**
 * Тип запроса сервера к устройствам
 * @author d.chistyakov
 *
 */
public enum RequestServerTypeEnum {
	NONE,
	
	/**
	 * Запрос данных
	 */
	GET_DATA,
	
	/**
	 * Запись данных, управление
	 */
	SET_DATA,
	
	/**
	 * Запрос архива
	 */
	GET_ARCHIVE,
	
	/**
	 * Получение единиц измерения
	 */
	GET_UNITS,
}
