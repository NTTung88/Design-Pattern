package lab01_01;

public class MainApp01 {
	private static Node makeLAN01() {
		Node pc01 = new Workstation("PC01", null);		
		Node server01 = new Server("Server01", pc01);
		Node printer01 = new Printer01("Printer01", server01);
		Node printer02 = new Printer02("Printer02", printer01);
		
		return printer02;
	}
	
	private static Node makeLAN02() {
		Node pc01 = new Workstation("PC01", null);		
		Node server01 = new Server("Server01", null);
		Node printer01 = new Printer01("Printer01", null);
		Node printer02 = new Printer02("Printer02", null);
		
		server01.insertNode(pc01);
		printer01.insertNode(server01);
		printer02.insertNode(printer01);
		
		return printer02;
	}
	
	public static void main(String[] args) {
		//Program run 
		Node lan01 = makeLAN01();
		
		//User create 1 packet
		Packet packet01 = new Packet ("PC1", "Printer01", "SINGLETON");
		
		//User print packet
		lan01.accept(packet01);//In mau SINGLETON.
		
//		Packet packet02 = new Packet ("PC1", "Printer02", "SINGLETON");
//		lan01.accept(packet02);//In trang den SINGLETON.
				
	} 
}
