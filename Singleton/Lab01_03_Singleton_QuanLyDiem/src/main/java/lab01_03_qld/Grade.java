package lab01_03_qld;

public class Grade {
	private Course course;
	private double grade;
	
	public Grade(Course course,double grade) {
		super();
		this.course=course;
		this.grade=grade;
	}
	public Course getCourse() {
		return course;
	}
	public double getGrade() {
		return grade;
	}
}
