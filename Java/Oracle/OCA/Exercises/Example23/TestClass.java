package Java.Oracle.OCA.Exercises.Example23;

public class TestClass {
    
    void probe(Object x) { System.out.println("In Object"); } //3 

    void probe(Number x) { System.out.println("In Number"); } //2

    void probe(Integer x) { System.out.println("In Integer"); } //2
    
    void probe(Long x) { System.out.println("In Long"); } //4
    
    public static void main(String[] args){
        double a = 10; 
        new TestClass().probe(a); 
    }
}
