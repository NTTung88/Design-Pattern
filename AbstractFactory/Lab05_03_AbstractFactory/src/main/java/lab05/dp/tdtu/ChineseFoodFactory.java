package lab05.dp.tdtu;

public class ChineseFoodFactory extends AbstractFoodFactory {
	 

    public AbstractFoodFactory placeOrder(String itemName, int quantity) {
        return new ChineseFood();
    }
 
}