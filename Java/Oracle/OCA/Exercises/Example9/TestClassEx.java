package Java.Oracle.OCA.Exercises.Example9;

interface Flyer {
    String getName();
}

class Bird implements Flyer {
    public String name;
    
    public Bird(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
}

class Eagle extends Bird {
    
    public Eagle(String name) {
        super(name);
    }
}


public class TestClassEx {

    public static void main(String[] args) {
        Flyer f = new Eagle("American Bald Eagle");
        System.out.println(f.getName());
    }
    
}
