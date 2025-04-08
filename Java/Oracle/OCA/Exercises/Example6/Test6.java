package Java.Oracle.OCA.Exercises.Example6;

public class Test6 {
    public static void main(String[] args) {
        System.out.println(Boolean.parseBoolean("true"));
        System.out.println(new Boolean(null));
        //System.out.println(new Boolean());
        System.out.println(new Boolean("true"));
        System.out.println(new Boolean("trUE"));

        Boolean a = new Boolean(true);
        Boolean b = Boolean.valueOf("true");

        System.out.println("Comparando dos valores");
        System.out.println(a == b ? a : !b);

        System.out.println(new Boolean(true) == Boolean.parseBoolean("true"));
    }
}
