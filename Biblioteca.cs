//clase principal
public class Biblioteca{
    //metodo principal
    public static void Main(string[] args){
        //defino una instancia de libro como odisea, y la inicializo como nueva
        libro Odisea=new libro();
         //defino una instancia de libro como dracula, y la inicializo como nueva
         libro Dracula=new libro();
       
       //llama al configurador de autor, y le damos el valor Homero
        Odisea.setAutor("Homero");
         //llama al configurador de Npaginas, y le damos el valor 448
        Odisea.setNpaginas(448);
         //llama al configurador de ISBN, y le damos el valor 9789583043888
        Odisea.setISBN(9789583043888);
         //llama al configurador de Titulo, y le damos el valor Odisea
        Odisea.setTitulo("Odisea");
        //llama al metodo tostring, y muestra el contenido de la clase libro agrgandole los valores que le dimos a Odisea
        Odisea.tostring();

        //llama al configurador de autor, y le damos el valor Bram Stoker
        Dracula.setAutor("Bram Stoker");
        //llama al configurador de Npaginas, y le damos el valor 418
        Dracula.setNpaginas(418);
        //llama al configurador de ISBN, y le damos el valor 9780786181483
        Dracula.setISBN(9780786181483);
        //llama al configurador de Titulo, y le damos el valor Dracula
        Dracula.setTitulo("Dracula");
        //llama al metodo tostring, y muestra el contenido de la clase libro agrgandole los valores que le dimos a Dracula
        Dracula.tostring();
    
      //condicion Si, para saber cual de los dos libros tiene mas pagina
        if (Odisea.getNpaginas()>Dracula.getNpaginas()){
            //si la condicion se cumple, muetra en pantalla que odisea tiene mas paginas 
            Console.WriteLine("Odisea tiene mas paginas");
        }
        //SiNo para cuando no se cumple la condicion 
        else {
            //muestra en pantalla que la Dracula tiene mas paginas 
            Console.WriteLine("Dracula tiene mas paginas");
        }
    }
}