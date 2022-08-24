namespace Library;

public class Producto
{
    public string Nombre {get;}
    public float Precio {get;}
    public List<Review> Reviews {get;} = new List<Review>();
    
    public Producto(string nombre, float precio){
        this.Nombre = nombre;
        this.Precio = precio;
    }
    
    public void addReview(int calificacion, string comentario){
        var review = new Review(calificacion, comentario);
        this.Reviews.Add(review);
    }

    public void getReviews(){
        if (this.Reviews.Count != 0)
        {
            Console.WriteLine("El producto '{0}' tiene las siguientes reviews:\n", this.Nombre);
            int i = 1;
            foreach (var item in this.Reviews)
            {
                Console.WriteLine("Review numero {0}: \nCalificacion: {1} \nComentario: {2}\n", i, item.Calificacion, item.Comentario);
                i++;
            }
            
        } else {
            Console.WriteLine("Aun no existen reviews para este producto.");
        }
    }
}
