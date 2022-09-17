package Lab02_01.dp.tdtu;

public class InsertionSortStrategy implements ISortStrategy{

	public void sort(Comparable[] data, int count) {
		// TODO Auto-generated method stub
		for (int i = 1; i < data.length; i++) { 
			Comparable<Student> objectToSort = data[i]; 
			int j = i; 
			while (j > 0 && data[j - 1].compareTo(objectToSort) > 1) { 
				data[j] = data[j - 1]; j--; 
				} 
			data[j] = objectToSort; 
			}
	}
}
