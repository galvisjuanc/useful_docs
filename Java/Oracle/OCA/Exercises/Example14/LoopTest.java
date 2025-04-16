package Java.Oracle.OCA.Exercises.Example14;

public class LoopTest {
    public static void main(String[] args) {
        new LoopTest().printThem();
    }

    int k = 5;
    public boolean checkIt(int k) {
        return k--> 0 ? true : false; 
    }

    public void printThem() {
        while(checkIt(k)) {
            System.out.println(k--);
        }
    }
}