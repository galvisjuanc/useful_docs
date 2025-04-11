package Java.Oracle.OCA.Exercises.Example11;

public class TestClassExample {

    static boolean b;
    static int[] ia = new int[1];
    static char ch;
    static boolean[] ba = new boolean[1];

    public static void main(String[] args) {
        boolean x = false;

        System.out.println(b);
        System.out.println(ia);
        System.out.println(ia[0]);
        System.out.println(ch);
        System.out.println(ba[0]);

        if ( b ) {
            x = ( ch == ia[ch]);
        } 
        else x = ( ba[ch] = b);
        System.out.println(x + " " + ba[ch]);
    }
}