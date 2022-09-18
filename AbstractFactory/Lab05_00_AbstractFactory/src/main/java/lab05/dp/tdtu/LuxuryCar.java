package lab05.dp.tdtu;

class LuxuryCar extends Car 
{ 
    LuxuryCar(Location location) 
    { 
        super(CarType.LUXURY, location); 
        construct(); 
    } 
    @Override
    protected void construct() 
    { 
        System.out.println("Connecting to luxury car"); 
    } 
} 
