package lab05.dp.tdtu;

public class ConsumerClass {
    public AbstractFood placeOrder(String itemName,int quantity,String itemType) {
        AbstractFoodFactory a = null;
        if(itemType.equals("italian")) {
            a = new ItalianFoodFactory();
        }else if(itemType.equals("mexican")) {
            a = new MexicanFoodFactory();
        }else if(itemType.equals("chinese")) {
            a = new ItalianFoodFactory();
        }
        if(a!=null) {
            return a.placeOrder(itemName, quantity);
        }else {
            return null;
        }
    }
}