// clase publica del libro
public class libro{
   //atributo privado para guardar el autor y el titulo del libro 
  string Autor="",Titulo="";
  //atributo privado para guardar el nuemero de pagina del libro
  int Npaginas;
//atributo privado para guardar el ISBN del libro
  long ISBN;
  
  //metodo publico de tipo string para consultar el autor
  public string getAutor(){
    //funcion que devuelve el valor y llama al autor
    return this.Autor;
  }
  //metodo publico que configura al autor y la guarda en la variable nombre de tipo string
  public void setAutor(string nombre){
    //procedimiento que llama al autor, que se guardo en variable nombre
    this.Autor=nombre;
  }
  //metodo publico de tipo string para consultar el titulo
  public string getTitulo(){
    //funcion que devuelve el valor y llama al titulo
    return this.Titulo;
  }
  //metodo publico que configura al titulo y la guarda en la variable titular de tipo string
  public void setTitulo(string titular){
    //procedimiento que llama al titulo, que se guardo en variable titular
    this.Titulo=titular;
  }
   //metodo publico de tipo int para consultar el Npaginas
  public int getNpaginas(){
    //funcion que devuelve el valor y llama al Npaginas
    return this.Npaginas;
  }
  //metodo publico que configura al Npaginas y la guarda en la variable paginas de tipo int
  public void setNpaginas(int paginas){
    //procedimiento que llama al Npaginas, que se guardo en variable paginas
    this.Npaginas=paginas;
  }
   //metodo publico de tipo long para consultar el ISBN
  public long getISBN(){
    //funcion que devuelve el valor y llama al ISBN
    return this.ISBN;
  }
  //metodo publico que configura al ISBN y la guarda en la variable Nbarras de tipo long
  public void setISBN(long Nbarras){
    //procedimiento que llama al ISBN, que se guardo en variable Nbarras
    this.ISBN=Nbarras;
  }
  //metodo publico tostring que muestra el contenido de la clase
  public void tostring(){
    //muestra en pantalla el libro  con IBSN  creado por el autor  tiene  paginas
    Console.WriteLine("El libro "+this.Titulo+" con ISBN "+this.ISBN+" creado por el autor "+this.Autor+" tiene "+this.Npaginas+" páginas.");
  }
}