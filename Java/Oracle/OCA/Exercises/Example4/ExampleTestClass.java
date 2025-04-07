package Java.Oracle.OCA.Exercises.Example4;

public class ExampleTestClass {
    public static void main(String[] args) {
        HouseExample houseExample = new MyHouseExample();
        System.out.println(houseExample.getAddress());
            
    }
}

interface HouseExample{
    public default String getAddress(){
       return "101 Main Str";
    }
  }
  
  interface BungalowExample extends HouseExample{
    
    public default String getAddress(){
       return "101 Smart Str";
    }
  }
  
  class MyHouseExample implements BungalowExample, HouseExample{
  
  }