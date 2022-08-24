namespace Main
{
    class Program
    {
        static void Main()
        {
            Library.Producto P1 = new Library.Producto("Aluminio", 100);
            P1.addReview(1, "Primera review");
            P1.addReview(3, "Segunda review");
            P1.addReview(5, "Tercera review");
            P1.getReviews();
        }
    }
}