package Lab10.dp.tdtu;

public abstract class LoggerDecorator extends Logger{
	
	protected Logger logger;
	
	public LoggerDecorator(Logger logger) {
		this.logger=logger;
	}

}
