package lap08.dp.tdtu;

public class MyApp {
	ISimpleFTP ftp;
	
	public void setFTP(ISimpleFTP ftp) {
		this.ftp = ftp;
	}
	public void doSomething() {
		ftp.connectServer();
		ftp.sendAMsg("abc");
	}
}
