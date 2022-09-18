package lab05.dp.tdtu;

public class ChineseFood extends AbstractFood {
    String itemName;
    int quantity;
    boolean delivered;
     
    public String getItemName() {
        return itemName;
    }
 
    public void setItemName(String itemName) {
        this.itemName = itemName;
    }
 
    public int getQuantity() {
        return quantity;
    }
 
    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }
 
    public boolean isDelivered() {
        return delivered;
    }
 
    public void setDelivered(boolean delivered) {
        this.delivered = delivered;
    }
}