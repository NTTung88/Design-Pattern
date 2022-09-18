package lap08.dp.tdtu;

public class FTPAdapter implements ISimpleFTP{
	private IComplexFTP complexFTP;
	public FTPAdapter() {
		complexFTP = new ComplexFTP();
	}
	public void sendAMsg(String msg) {
		String[] msgs = new String[] {msg};
		complexFTP.sendMsgs(msgs);
	}
	@Override
	public void connectServer() {
		// TODO Auto-generated method stub
		complexFTP.connect();
	}

}
