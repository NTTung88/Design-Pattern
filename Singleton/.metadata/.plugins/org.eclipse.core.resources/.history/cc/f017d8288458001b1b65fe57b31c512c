package lab01_01;

public class Printer01 extends Server{

	public Printer01(String name, Node nextNode) {
		super(name, nextNode);
		// TODO Auto-generated constructor stub
	}
	
	public void print(Packet packet) {
		System.out.println("IN MAU" + packet.getContents());
	}
	
	public void accept(Packet packet){
		if(this.isForMe(packet)) {
			print(packet);
			return;
		}
		Node node = nextNode();
		if(node != null) 
			node.accept(packet);
	}
}
