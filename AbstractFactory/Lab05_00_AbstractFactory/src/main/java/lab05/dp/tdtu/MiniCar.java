package lab05.dp.tdtu;

class MiniCar extends Car 
{ 
    MiniCar(Location location) 
    { 
        super(CarType.MINI,location ); 
        construct(); 
    } 
      
    @Override
    void construct() 
    { 
        System.out.println("Connecting to Mini car"); 
    } 
} 