package lap08.dp.tdtu;

public class TestMyApp {
	public static void main(String[] args) {
		MyApp app = new MyApp();
		ISimpleFTP ftp = new MyFTP();
		
		app.setFTP(ftp);
		app.doSomething();

		
	}
}
