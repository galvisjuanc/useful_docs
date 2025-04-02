package Java.Oracle.OCA.Exercises.Example2;

public class A {

    int i;
    public A(int x) {
        this.i = x;
    }
}

class B extends A {
    int j;

    public B(int x, int y) {
        super(x);
        this.j = y;
    }

    /*public B(){
        //No valida. No llama super(x) para heredar de clase A.
    }

    public B(int y) {
        j = y;
        //No valida. No llama super(x) para heredar de clase A.
    }

    public B(int y) {
        super(y*2);
        j= y;
    }

    
    public B(int y ) { 
        i = y; 
        j = y*2; 
        //No valida. No llama super(x) para heredar de clase A.
    }

    public B(int z ) { 
        this(z, z); 
        //En vez de llamar super, se puede llamar otro constructor de la clase base, así que la clase A si se puede instanciar.
    }*/
}
