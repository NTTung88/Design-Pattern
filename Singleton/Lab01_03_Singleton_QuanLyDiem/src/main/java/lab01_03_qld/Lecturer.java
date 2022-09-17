package lab01_03_qld;

import java.util.Date;

public class Lecturer {
	private String name;
	private Date birthDate;
	private String degree;
	
	public Lecturer(String name,Date birthDate,String degree) {
		super();
		this.name=name;
		this.birthDate=birthDate;
		this.degree=degree;
	}
	
	public String getName() {
		return name;
	}
	public Date getBirthDate() {
		return birthDate;
	}
	public String getDegree() {
		return degree;
	}
}
