package bai02.lab04.dp.tdtu;

public class SortApp {
	public static void main(String[] args) {
		SortedList test = new SortedList();
		test.add(1);
		test.add(5);
		test.add(3);
		test.add(9);
		test.add(4);
		test.sort(1);
		test.printList();
		test.sort(2);
		test.printList();
		test.sort(3);
		test.printList();
	}
}
