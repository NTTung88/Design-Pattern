package lab05.dp.tdtu;

import java.util.ArrayList;

public class MenuApplication {
    ArrayList order;
    public static void main(String[] args) {
        MenuApplication m = new MenuApplication();
        m.createOrder();
    }
    public boolean createOrder() {
        boolean orderCreated = false;
        ConsumerClass c = new ConsumerClass();
        order = new ArrayList();
        order.add(c.placeOrder("Lazagne", 2, "italian"));
        order.add(c.placeOrder("Taco", 3, "mexican"));
        order.add(c.placeOrder("Noodles", 1, "chinese"));
        System.out.println(order);
        return orderCreated;
    }
 
}