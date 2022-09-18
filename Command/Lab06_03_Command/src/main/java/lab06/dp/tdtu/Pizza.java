package lab06.dp.tdtu;

public class Pizza implements Order {

    private PizzaChef chef;

    public Pizza() {
        this.chef = new PizzaChef();
    }


    public void execute() {
        chef.makePizza();
    }


    public String toString() {
        return "pizza";
    }

}