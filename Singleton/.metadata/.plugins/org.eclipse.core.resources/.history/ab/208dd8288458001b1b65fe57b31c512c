package lab01_01;

public class Server extends Node {
	
	public Server(String name, Node nextNode) {
		super(name, nextNode);
	}
	
	public boolean isForMe(Packet packet) {
		if(packet.isDestination(this)) {
			return true;
		}
		return false;
	}
}
