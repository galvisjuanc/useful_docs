package Java.Oracle.OCA.Exercises.Example4;

interface House {

    public default String getAddress() {
        return "101 Main Str";
    }
}