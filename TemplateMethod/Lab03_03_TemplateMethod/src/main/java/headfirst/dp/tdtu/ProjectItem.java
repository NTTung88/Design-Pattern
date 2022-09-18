package headfirst.dp.tdtu;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Iterator;

abstract class ProjectItem implements Serializable {
	private String name;
	private String description;
	private double rate;
	public ProjectItem() {
	}
	public ProjectItem(String newName, String newDescription, double newRate) {
		name = newName;
		description = newDescription;
		rate = newRate;
	}
	public void setName(String newName) {
		name = newName;
	}
	public void setDescription(String newDescription) {
		description = newDescription;
	}
	public void setRate(double newRate) {
		rate = newRate;
	}
	public String getName() {
		return name;
	}
	public String getDescription() {
		return description;
	}
	// template method
	public final double getCostEstimate() {
		return getTimeRequired() * getRate() + getMaterialsCost();
	}
	public double getRate() {
		return rate;
	}
	public String toString() {
		return getName();
	}
	public abstract double getTimeRequired();
	public abstract double getMaterialsCost();
}
	
