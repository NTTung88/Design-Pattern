package Lab02_01.dp.tdtu;

import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;

public class StudentList {

	private Student[] student;
	private int count;
	private ISortStrategy sortStrategy;
	
	
	public StudentList(Student[] student,int count,ISortStrategy sortStrategy) {

		this.student= student;
		this.count=student.length;
		this.sortStrategy=sortStrategy;
	}
	

	public Student[] getStudent() {
		return student;
	}

	public void setStudent(Student[] student) {
		this.student = student;
	}

	public int getCount() {
		return count;
	}

	public void setCount(int count) {
		this.count = count;
	}




	public ISortStrategy getSortStrategy() {
		return sortStrategy;
	}

	public void setSortStrategy(ISortStrategy sortStrategy) {
		this.sortStrategy = sortStrategy;
	}

	public void addStudent(Student e) {
		student =Arrays.copyOf(student,student.length+1);
		student[student.length -1] = e;	
	}


	public void sort() {

	}
	public void display() {	
		
	}


	@Override
	public String toString() {
		return "StudentList [student=" + Arrays.toString(student) + ", count=" + count + ", sortStrategy="
				+ sortStrategy + "]";
	}

}