package Java.Oracle.OCA.Exercises.Example5;

class Test {
    public static void main(String[] args) {
        for (int i = 0; i < args.length; i++) {
            System.out.println(i == 0 ? args[i] : " " + args[i]);
        }
        
    }
}