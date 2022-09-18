package lab06.dp.tdtu;

public class Steak implements Order {

    private SteakChef chef;

    public Steak() {
        this.chef = new SteakChef();
    }


    public void execute() {
        chef.makeSteak();
    }


    public String toString() {
        return "steak";
    }

}