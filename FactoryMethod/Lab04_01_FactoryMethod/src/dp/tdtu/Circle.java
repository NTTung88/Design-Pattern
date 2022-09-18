package dp.tdtu;

public class Circle {
	private double radius;
	public final double PI = 3.14;
	
	public Circle(double radius) {
		this.radius = radius;
	}
	
	public double area() {
		return PI + this.radius * this.radius;
	}
}
