package bai04.lab04.dp.tdtu;

import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;

public class Rectangle implements AShape{
	private Point a;
	private int width;
	private int height;
	
	public Rectangle(Point a, int width, int height) {
		super();
		this.a = a;
		this.width = width;
		this.height = height;
	}
	
	@Override
	public void draw(Graphics g) {
		// TODO Auto-generated method stub
		Graphics2D g2d = (Graphics2D) g;
		
		g2d.drawRect(a.x, a.y, width, height);
	}
	
}
