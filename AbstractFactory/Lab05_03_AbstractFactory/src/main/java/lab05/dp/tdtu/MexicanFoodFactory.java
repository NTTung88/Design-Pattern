package lab05.dp.tdtu;

public class MexicanFoodFactory extends AbstractFoodFactory {
    @Override
    public AbstractFood placeOrder(String itemName, int quantity) {
        return new MexicanFood(itemName,quantity);
    }
}
