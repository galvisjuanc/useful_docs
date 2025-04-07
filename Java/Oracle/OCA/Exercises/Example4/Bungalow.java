package Java.Oracle.OCA.Exercises.Example4;

interface Bungalow extends House {

    public default String getAddress() {
        return "101 Smart Str";
    }    
}
