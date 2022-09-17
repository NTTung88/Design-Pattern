package lab01_01;

public class Node {
	private String name;
	private Node nextNode;	
	
	public Node(String name, Node nextNode) {
		super();
		this.name = name;
		this.nextNode = nextNode;
	}

	public Node nextNode(){
		return nextNode;
	}
	
	public void insertNode(Node node) {
		nextNode = node;
	}

	@Override
	public String toString() {
		return "Node [name=" + name + ", nextNode=" + nextNode + "]";
	}

	public void accept(Packet packet){
		Node next = nextNode();
		if(next!=null) {
			next.accept(packet);
		}
	}
	
	public String getName() {
		return this.name;
	}
}
