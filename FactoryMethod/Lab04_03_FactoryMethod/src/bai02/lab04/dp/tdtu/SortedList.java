package bai02.lab04.dp.tdtu;

import java.util.ArrayList;

public class SortedList {
	private ArrayList<Integer> list = new ArrayList<>();
	
	
	public void add(int number) {
		list.add(number);
	}

	public SortAlg selectSortAlg(int sortType) {
		return null;
	}
	
	public void sort(int sortType) {
		SortAlg sortInstance = selectSortAlg(sortType);
		
		sortInstance.sort(list);
	}
	
	public void printList() {
		
		System.out.println("Array: ");
		for (int element: list) {
			System.out.println(element);
		}
	}
}
