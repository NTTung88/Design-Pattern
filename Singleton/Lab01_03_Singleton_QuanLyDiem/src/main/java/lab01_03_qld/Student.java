package lab01_03_qld;

import java.util.Date;
import java.util.List;

public class Student{
	private String name;
	private Date birthDate;
	private Lecturer assistant;
	private List<Grade> grades;
	
	public Student(String name,Date birthDate, Lecturer assistant,List<Grade> grades) {
		super();
		this.name=name;
		this.birthDate=birthDate;
		this.assistant=assistant;
		this.grades=grades;
		
	}
	public String getName() {
		return name;
	}
	public Date getBirthDate() {
		return birthDate;
	}
	public Lecturer getAssistant() {
		return assistant;
	}
	public List<Grade> getGrades(){
		return grades;
	}
}

