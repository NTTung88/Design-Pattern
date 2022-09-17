package lab01_01;

public class Packet {
	private String originator;
	private String destination;
	private String contents;
	
	public Packet(String originator, String destination, String contents) {
		super();
		this.originator = originator;
		this.destination = destination;
		this.contents = contents;
	}

	public String getContents() {
		return contents;
	}
	
	public boolean isOriginator(Node node) {
		if(this.originator.equals(node.getName())) {
			return true;
		}
		else {
			return false;
		}
	}
	
	public boolean isDestination(Node node) {
		if(this.destination.equals(node.getName())) {
			return true;
		}
		else {
			return false;
		}
	}
}
