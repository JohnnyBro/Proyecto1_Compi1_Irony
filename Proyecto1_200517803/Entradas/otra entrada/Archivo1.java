
public class Archivo1 extends prueba1{

    //ATRIBUTOS
    public String estawea;
    String cad;
    int edad;
    double numero = 5.05;
    char a = 'c';
    String cadenita = "cadenita" + cad;
    boolean logica = true;
    prueba1 uiui = new prueba1();
    double sueldo = uiui.ObtenerSueldo(edad, numero, a);

    /**Esto es un
    ejemplo de constructor**/

    public Archivo1(String c, int d){
        this.cad = c;
        this.edad = d;
    }

    public Archivo1(){

    }

    //EJEMPLOS DE FUNCIONES
    public int producto (int a, int b) {
        return  a*b;
    }

    private Nodo getSiguiente(){
        String a;
        int b;
        a = "jajajaja";
        b = 0;
        Nodo es = new Nodo();
        this.mostrar();
        arbol arbolito = new arbol();
        Nodo nodo1 = arbolito.getNombre();
        switch(getNombre()){
            case "hola mundo":
                a = "jejeje";
                b = 1;
                break;
            default:
                a = "jojojo";
                b = 2;
                break;
        }

        return es;
    }

    private String getNombre(){
        return "fksdjfks";
    }

    private void Iniciar(String h, int op, boolean funciono, double d){

    }

    protected String mostrar(){
        String a;
        int b;
        int resul;
        Llamada();
        Iniciar("Hola", (1+2)*5, true, 20.1526);

        for (b=0; b<=10; b = b +1){
            //concatenando valores
            a = "10*b=resul";
        }
        a = "hola";
        b = 50;
        Nodo nodo1 = new Nodo();
        nodo1.nombre=getNombre();

        switch(getNombre()){
            case "hola mundo":
                a = "jejeje";
                b = 1;
                break;
            case "adios mundo":
                a = "juju";
                b = 2;
                break;
            default:
                a = "jojojo";
                b = 2;
                break;
        }
        Nodo nodo2 = new Nodo();
        while (nodo2.nombre != null){
            nodo2.nombre = nodo1.nombre;
        }

        return a;
    }

    double Sumar_Restar(int x, int y, double var1, double var2){
        /**Esta funcion realiza operaciones aritmeticas**/
        int o=32;
        int skjs=32;
        int resultado;
        this.edad=x;
        o=y;

         if(x>y && x > 10){
            do{
                resultado = (x + y) - (o-skjs);
                x++;
            }while(x > 10);
         }else{
            resultado = (x - y) + (o*skjs);
         }

         return resultado;
    }

    public boolean esPositivo(int x) {
        if (x<0){
            return false;
        }else if (x>0){
            return  true;
        }else{
            return true;
        }
    }

    //EJEMOPLOS DE METODOS
    private void Llamada(){

    }

    private void Buscar(){
    }

    public void tabla(int n) {
    // de tipo void
        System.out.println("Tabla de multiplicar del numero " + n);

        for(int i=0; i<=10; i++){
            System.out.println(n + " x " + i + " = " + producto(n,i));
        }
        // No devuelve ningun valor

    }

    private void calendario(){
        arbol miarbol = new arbol();
        int dia = miarbol.getarbolitos();

        for (int i = 1; i <= 7; i++) {
            if (dia == i){
                System.out.println("Hoy es el " + i + " dia de la semana.");
                break;
            }
        }

        return;
    }


    private void calendario2(){

        Calendar cal = new Calendar();
        cal.setCalendar();
        int dia = cal.esta();

        for (int i = 1; i <= 7; i++) {

            if (dia == i){
                a++;
                continue;
            }

            System.out.println("Dia " + i);

        }

        System.out.println("Seguimos...");

        int a =1;
        while(a < 7){
            if (dia == a){
                a++;
                continue;
            }

            break;
        }
    }

    private void Buscar2(){
        int a=0;
        this.edad=a;
        String b = "Hola";
        a = 45+9;
        Nodo nodo = new Nodo();

        if(nodo.nombre == "s"){
            nodo.apellido = "a";
        }else if(nodo.nombre == "E"){
            nodo.apellido = "B";
         }else if(nodo.nombre == "T"){
            nodo.apellido = "C";
         }

        int v1=32;
        int v2=8;
        //int v1=0, v2=0;
         while(v1 < 10 || v2 > 20 +suma(2,4)){
            b = "El valor cumple las condiciones";
            a++;
         }
    }

    private int suma(int a, int b){
        return a+b;
    }

    protected void Llenar(int x, int y, boolean bandera){
        int a;
        String b = "Hola";
        a = 45+9;
        Nodo aveces = new Nodo();
        arbol ar = new arbol();
        //arbol.raiz.personas.familia.hijo.datos.setNombre("Luis");
        aveces=ar.estaweaweita();
        aveces.tam=ar.taza(a, 232.323, x);
        int r3;
        for (a=10; a>=0; a++ ){
            r3 = a *10;
            b = "El resultado es r";
            for ( aveces.tam =10; aveces.tam >=0; aveces.tam-- ){
                aveces.tam =32;
            }
        }

        switch(this.cadenita){
            case "S":
                ar.ramitas = 1;
                break;
            case "E":
                ar.ramitas = 2;
                break;
            case "T":
                ar.ramitas = 3;
                break;
            default:
                ar.ramitas = 4;
                break;
        }
    }

    void Ejecutar(Nodo padre){
        int a;
        String b = "Hola";
        a = 45+9;
        Nodo titulo = new Nodo();
        arbol miar = new arbol();
        titulo.nombre=this.cad;

        if(titulo.nombre == "s"){
            titulo.apellido = "a";
            titulo.rango = "3";
            do{
                titulo.aceptado = "Si";
                titulo = miar.estaweaweita();
            }while(titulo.aceptado != null);

        }else if(titulo.nombre == "E"){
            titulo.apellido = "B";
            titulo.rango = "4";
        }else if(titulo.nombre == "T"){
            titulo.apellido = "C";
            titulo.rango = "5";
        }else{
                if(titulo.edad == 20){
                    titulo.rango = "1";
                }else{
                    titulo.rango = "2";
                }
        }
    }

}
