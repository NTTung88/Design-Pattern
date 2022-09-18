package bai01.lab04.dp.tdtu;

public class DrawShape {
	public void draw(int shapeType, int style) {
		IShape shape = createShape(shapeType, style);
		
		shape.draw();
	}
	
	private IShape createShape(int shapeType, int style) {
		IShape shape = null;
		
		if(style == 2) {
			if(shapeType == 1)
				shape = new SolidCircle();
			else if(shapeType == 2)
				shape = new SolidSquares();
			else
				shape = new SolidRectangle();
		} 
		else {
			if(shapeType == 1)
				shape = new Circle();
			else if(shapeType == 2)
				shape = new Squares();
			else
				shape = new Rectangle();
		}
		
		return shape;
	}
}
