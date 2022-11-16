var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





Circulo c1 = new Circulo();
c1.setRaio(10);



Circulo c2 = new Circulo(10);



app.MapGet("/", () => "Perimetro: " + c2.getPerimetro() + " Área: " + c2.getArea());
app.Run();




class Circulo
{



    double raio;
    double perimetro;
    double area;



    public Circulo()
    {
    }



    public Circulo(double raio)
    {
        this.raio = raio;
    }



    public void calcularArea()
    {
        this.area = Math.PI * Math.Pow(raio, 2);
    }



    public void calcularPerimetro()
    {
        this.perimetro = Math.PI * 2 * Math.Pow(raio, 2);
    }



    public double getArea()
    {
        calcularArea();
        return this.area;
    }



    public double getPerimetro()
    {
        calcularPerimetro();
        return this.perimetro;
    }



    public void setRaio(double raio)
    {
        this.raio = raio;
    }
}



