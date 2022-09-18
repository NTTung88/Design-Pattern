package Lab10.dp.tdtu;

public class ZipLoggerDecorator extends LoggerDecorator{
	
	public ZipLoggerDecorator(Logger logger) {
		super(logger);
	}
	@Override
	public void log(String msg) {
		System.out.println("ZipLoggerDecorator" +msg);
		
		this.logger.log(msg);
	}

}
