// See https://aka.ms/new-console-template for more information

using LINQ;

int[] numeros = Enumerable.Range(1,20).ToArray();

//Primer video
// Sintaxis de metodos
var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

// Sintaxis de querys
var numerosPares2 = (from n in numeros
                    where n % 2 == 0
                    select n).ToList();


//Segundo video
var numerosPares3 = numeros.Where(n =>
{
    Console.WriteLine($"Evaluando si {n} es par");
    return n % 2 == 0;
});

foreach (var numero in numerosPares3)
{
    Console.WriteLine($"Si el {numero} es par");
}

//Tercer video
var numerosImpares = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

var numerosImpares2 = from n in numeros 
                     where n % 2 == 1 && n > 10
                     select n;

Console.WriteLine("Los numeros impares son");
foreach (var numero in numerosImpares)
{
    Console.WriteLine(numero);
}

//Cuarto video
var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALAEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALAEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALAEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALAEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALAEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

//Decimo video
int[] numerooos = { 1, 5, 12, 2, 3, 111, 6 };

            foreach (var numero in numeros.OrderBy(x => x))
            {
                Console.WriteLine(numero);
            }

            // Sintaxis de queries
            var numeros_2 = from n in numeros
                            orderby n
                            select n;

            var personasOrdenadasPorEdad_2 = from p in personas
                                             orderby p.Edad descending
                                             select p;
//Decimo video//


            //var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();

            //foreach (var persona in personasDe25AñosOMenos)
            //{
            //    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");
            //}

            //var solteros = personas.Where(p => p.Edad <= 25 && p.Soltero).ToList();

            //foreach (var persona in solteros)
            //{
            //    Console.WriteLine($"{persona.Nombre} es soltero/a");
            //}

            var personasConMenosDe3MesesEnLaEmpresa = personas
                                                    .Where(p => p.FechaIngresoALAEmpresa >= DateTime.Now.AddMonths(-3)).ToList();

            
            var personasConMenosDe3MesesEnLaEmpresa_2 = from p in personas
                                                        where p.FechaIngresoALAEmpresa >= DateTime.Now.AddMonths(-3)
                                                        select p;

            foreach (var persona in personasConMenosDe3MesesEnLaEmpresa_2)
            {
                Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa.");
            }

//Quinto video
var primeraPersona = personas.First();
            var primeraPersona2 = personas.FirstOrDefault();

            var paises = new List<string>();
            try
            {
                var primerPais = paises.First();
            }
            catch (Exception )
            {
                Console.WriteLine("ha ocurrido un error");
            }

            var primerPais2 = paises.FirstOrDefault();

            

            var primeraPersonaNoSoltera = personas.FirstOrDefault(s => !s.Soltero);

            // Sintaxis de queries
            var primeraPersonaNoSoltera_2 = (from s in personas
                                             where !s.Soltero
                                             select s).FirstOrDefault();
        
//Sexto video
var ultimaPersona = personas.Last();
            var ultimaPersona2 = personas.LastOrDefault();
            var ultimaPersonaSoltera = personas.Last(p => p.Soltero);

            // Sintaxis de queries
            var ultimaPersonaSoltera_2 = (from p in personas
                                          where p.Soltero
                                          select p).Last();

            
//Septimo video
var terceraPersona = personas.ElementAt(2);
            var sextaPersona = personas.ElementAtOrDefault(5);

            // Sintaxis de queries
            var sextaPersona_2 = (from p in personas
                                  select p).ElementAtOrDefault(5);

//Octavo video
var personasMayorDe60 = personas.Single(p => p.Edad > 60);

            // Sintaxis de queries
            var personaMayorDe60_2 = (from p in personas
                                      where p.Edad > 60
                                      select p).Single();

            try
            {
                var personaMayorA100 = personas.Single(p => p.Edad > 100);
            }
            catch (Exception )
            {
                Console.WriteLine("Hubo un error, arreglo vacío");
            }

            try
            {
                var personaMayor5 = personas.SingleOrDefault(p => p.Edad > 5);
            }
            catch (Exception )
            {
                Console.WriteLine("Hubo otro error, arreglo con mas de un elemento");
            }
//Noveno video
var listado = new List<object>() { "Felipe", 1, 2, "Claudia", true };

            var strings = listado.OfType<string>();
            var numeroos = listado.OfType<int>();

            // sintaxis de queries
            var strings_2 = from s in listado.OfType<string>()
                            select s;

            // Ejemplo 2: herencia

            var listadoAnimales = new List<Animal>()
                                    {
                                        new Perro(){Nombre = "Firulais"},
                                        new Gato(){Nombre = "Félix"}
                                    };

            var perros = listadoAnimales.OfType<Perro>();
        

        public abstract class Animal
        {
            public abstract string? Nombre { get; set; }
        }

        public class Perro : Animal
        {
            public override string? Nombre { get; set; }
        }

        public class Gato : Animal
        {
            public override string? Nombre { get; set; }
        }





