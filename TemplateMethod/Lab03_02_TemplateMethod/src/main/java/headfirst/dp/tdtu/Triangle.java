package headfirst.dp.tdtu;

import java.awt.Graphics;
import java.awt.Point;

public abstract class Triangle {
	private Point p1, p2, p3;
	public Triangle(Point a, Point b, Point c) {
	// save
		p1 = a;
		p2 = b;
		p3 = c;
	}
	// template method
	public void draw(Graphics g) {
	// This routine draws a general triangle
		drawLine(g, p1, p2);
		Point current = draw2ndLine(g, p2, p3);
		closeTriangle(g, current);
	}
	public void drawLine(Graphics g, Point a, Point b) {
		g.drawLine(a.x, a.y, b.x, b.y);
	}
	// this routine is the &quot;Hook&quot; that has to be implemented
	// for each triangle type.
	public abstract Point draw2ndLine(Graphics g, Point a, Point b);
		public void closeTriangle(Graphics g, Point c) {
		// draw back to first point
		g.drawLine(c.x, c.y, p1.x, p1.y);
	}
}