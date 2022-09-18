package headfirst.dp.tdtu;

import java.awt.Graphics;
import java.util.Vector;

import javax.swing.JPanel;

public class TPanel extends JPanel {
	private Vector<Triangle> triangles;
	public TPanel() {
		triangles = new Vector();
	}
	public void addTriangle(Triangle t) {
		triangles.addElement(t);
	}
	public void paint(Graphics g) {
		for (int i = 0; i < triangles.size(); i++) {
		
		Triangle tngl = triangles.elementAt(i);
		tngl.draw(g);
		}
	}
}