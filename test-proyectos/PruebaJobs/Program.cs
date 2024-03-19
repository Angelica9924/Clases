using Clases;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("mensaje", () => "Hello World!");

app.MapGet("calculadora/sumar", () => {
    //clase-variable-instacia(la vble contendra todo lo de la clase calculadora), la vble se puede llamar como sea, pero llamemosla como la clase pero en minuscula
    Calculadora calculadora = new Calculadora();
    //llamamos
    return calculadora.Sumar(12,30);
});

app.MapGet("calculadora/restar", () => {
    Calculadora calculadora = new Calculadora();
    return calculadora.Restar(120,30);
});

app.MapGet("calculadora/dividir", () => {
    Calculadora calculadora = new Calculadora();
    return calculadora.Dividir(120,30);
});

app.MapGet("calculadora/multiplicar", () => {
    Calculadora calculadora = new Calculadora();
    return calculadora.Multiplicar(120,30);
});

app.MapGet("usuario", () => {
    Persona usuario = new Persona();
    return usuario.Usuario("Angelica","Martinez");
});



app.Run();
