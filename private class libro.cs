//creacion de clase frito con los atributos especificos
public class fritos{
    // establece atributos de seguridad privada tipo texto de la clase fritos
    private string tipofrito, salsita;
    // establece atributos de seguridad privada tipo entero de la clase fritos
    private int valor, cantkal;

//creacion de get que  se ejecuta cuando se lee la propiedad.  
    public string gettipofrito(){
        // retorna la promesa
        return (this.tipofrito);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public string settipofrito(string nombref){
    // retorna la promesa
        return this.tipofrito=nombref;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public string getsalsita(){
        // retorna la promesa
        return (this.salsita);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public string setsalsita(string nombresal){
    // retorna la promesa
        return this.salsita=nombresal;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public int getvalor(){
        // retorna la promesa
        return (this.valor);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public int setvalor(int valort){
    // retorna la promesa
        return this.valor=valort;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public int getcantkal(){
        // retorna la promesa
        return this.cantkal;
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public int setcantkal(int npagi){
    // retorna la promesa
        return this.cantkal=npagi;
}
//creacion de la consulta por salsita de libro
public void tostring(){ 
    // muestra en pantalla la concantenacion de los valores
    Console.WriteLine("El frito "+this.tipofrito+" con valor de "+this.valor+" con "+this.salsita+" tiene "+this.cantkal+" Calorias.");
    // Fin
}
// Fin
}