// See https://aka.ms/new-console-template for more information

using LINQ;

int[] numeros = Enumerable.Range(1, 20).ToArray();

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
catch (Exception)
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
catch (Exception)
{
    Console.WriteLine("Hubo un error, arreglo vacío");
}

try
{
    var personaMayor5 = personas.SingleOrDefault(p => p.Edad > 5);
}
catch (Exception)
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

//11 video
public class ThenBy
{
    public void ThenByD()
    {
        var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALAEmpresa = new DateTime(2021, 1, 2), Soltero = true },
new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALAEmpresa = new DateTime(2015, 11, 22), Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALAEmpresa = new DateTime(2020, 4, 12), Soltero = false },
new Persona { Nombre = "Valentina", Edad = 19, FechaIngresoALAEmpresa = new DateTime(2021, 7, 8), Soltero = false },
new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALAEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

        var personasOrdenadasPorEdad = personas.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

        foreach (var persona in personasOrdenadasPorEdad)
        {
            Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
        }

        // Sintaxis de queries

        var personasOrdenadasPorEdad_2 = from p in personas
                                         orderby p.Edad, p.Nombre descending
                                         select p;
    }
}

//Video 13
public class Select
{
    public void EjSelect()
    {
        var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALAEmpresa = new DateTime(2021, 1, 2), Soltero = true },
new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALAEmpresa = new DateTime(2015, 11, 22), Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 25, FechaIngresoALAEmpresa = new DateTime(2020, 4, 12), Soltero = false },
new Persona { Nombre = "Valentina", Edad = 37, FechaIngresoALAEmpresa = new DateTime(2021, 7, 8), Soltero = false },
new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALAEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

        var nombres = personas.Select(p => p.Nombre).ToList();

        var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad }).ToList();

        var personasDTOs = personas.Select(p => new Persona { Nombre = p.Nombre, Edad = p.Edad }).ToList();

        var numeros = Enumerable.Range(1, 5).ToList();
        var numerosDuplicados = numeros.Select(n => 2 * n).ToList();

        var personasConIndice = personas.Select((p, indice) => new { Persona = p, Indice = indice + 1 }).ToList();

        foreach (var item in personasConIndice)
        {
            Console.WriteLine($"{item.Indice}) {item.Persona.Nombre}");
        }

        // Sintaxis de queries
        var nombres_2 = (from p in personas
                         select p.Nombre).ToList();

        var nombresYEdades_2 = from p in personas
                               select new { Nombre = p.Nombre, Edad = p.Edad };

        var numerosDuplicados_2 = from n in numeros
                                  select 2 * n;


    }
}


//Video 14
public class Count
{
    public void EjCount()
    {
        var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Soltero = true },
                new Persona { Nombre = "Nidia", Soltero = true },
                new Persona { Nombre = "Alejandro", Soltero = true },
                new Persona { Nombre = "Valentina", Soltero = false }
                };

        Console.WriteLine($"La cantidad de personas es {personas.Count()}");

        Console.WriteLine($"La cantidad de personas solteras es {personas.Count(p => p.Soltero)}");

        Console.WriteLine($"Int max = {int.MaxValue.ToString("N")}");

        personas.LongCount();

        // Sintaxis de queries 

        var conteoSolteros = (from p in personas
                              where p.Soltero
                              select p).Count();
    }
}


//Video 15
public class SumaMaxMin
{
    public void EjSumMaxMin()
    {
        var personas = new List<Persona>() {
                                new Persona { Nombre = "Eduardo", Edad = 19, },
                                new Persona { Nombre = "Nidia", Edad = 25 },
                                new Persona { Nombre = "Alejandro", Edad = 30 },
                                new Persona { Nombre = "Valentina", Edad = 22 }
                                };

        var numeros = Enumerable.Range(1, 5);

        Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
        Console.WriteLine($"La suma de los numeros es {personas.Sum(p => p.Edad)}");

        Console.WriteLine($"La edad máxima de las personas es {personas.Max(x => x.Edad)}");
        Console.WriteLine($"La edad mínima de las personas es {personas.Min(x => x.Edad)}");

        var personaDeMayorEdad = personas.MaxBy(x => x.Edad);
        var personaDeMenorEdad = personas.MinBy(x => x.Edad);
    }
}


//Video 19
public class Agregado
{
    public void EjAgregado()
    {
        var numeros = Enumerable.Range(1, 5);

        var resultado = numeros.Aggregate((a, b) => a * b);

        Console.WriteLine("Resultado es " + resultado);

        var resultadoConValorInicial = numeros.Aggregate(10, (a, b) => a * b);

        Console.WriteLine("El resultado con el valor semilla es: " + resultadoConValorInicial);
    }
}

//Video 21

public class Contains
{
    public void EjContain()
    {
        var numeros = Enumerable.Range(1, 5);

        var estaElNumero3 = numeros.Contains(3);

        var estaElNumero20 = numeros.Contains(20);

    }
}

//Video 22

public class Any
{
    public void EjAny()
    {
        var personas = new List<Persona>()
            {
                new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
            };

        var existeMenor = personas.Any(p => p.Edad < 18);

        var existePersonaMayorDe20 = personas.Any(p => p.Edad > 20);

    }
}

//Video 27 y 28
public class GroupBy
    {
        public void EjGroup()
        {

            var personas = new List<Persona>() 
            {
                new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
                new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
                new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
            };

            var agrupamientoPorSolteria = personas.GroupBy(p => p.Soltero);

            // sintaxis de queries
            var agrupamientoPorSolteria_2 = from p in personas
                                           group p by p.Soltero into grupos
                                           select grupos;

            foreach (var item in agrupamientoPorSolteria_2)
            {
                Console.WriteLine($"Grupo de las personas donde Soltero = {item.Key} (Total: {item.Count()})");
                foreach (var persona in item)
                {
                    Console.WriteLine($"- {persona.Nombre}");
                }
            }
            var agrupamientoPorRangoEdad = personas.GroupBy(p => p.Edad / 5);

            // Sintaxis de queries

            var agrupamientoPorRangoEdad_2 = from p in personas
                                             group p by p.Edad / 5 into grupos
                                             select grupos;

            foreach (var item in agrupamientoPorRangoEdad_2)
            {
                Console.WriteLine($"Grupo de las personas en el rango de edad {item.Key * 5} - {item.Key * 5 + 5 - 1}");

                foreach (var persona in item)
                {
                    Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
                }
            }

        }
    }

//Video 29 y 30
public class Join
    {
        public void EjJoin()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Alejandro", EmpresaId = 3 },
                            new Persona { Nombre = "Valentina",  EmpresaId = 2 },
                            new Persona { Nombre = "Roberto",  EmpresaId = 3 },
                            new Persona { Nombre = "Eugenia"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            var empresas = new List<Empresa>()
            {
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"}
            };

            var personasYEmpresas = personas.Join(empresas, p => p.EmpresaId, e => e.Id, (persona, empresa) => new
            {
                Persona = persona,
                Empresa = empresa
            });

            // Sintaxis de queries
            var personasYEmpresas_2 = from persona in personas
                                      join empresa in empresas on persona.EmpresaId equals empresa.Id
                                      select new
                                      {
                                          Persona = persona,
                                          Empresa = empresa
                                      };

            foreach (var item in personasYEmpresas_2)
            {
                Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}");
            }

            var empresasYSusEmpleados = empresas.GroupJoin(personas, e => e.Id, p => p.EmpresaId,
                (empresa, personas) => new { Empresa = empresa, Personas = personas });

            // Sintaxis de queries
            var empresasYSusEmpleados_2 = from empresa in empresas
                                          join persona in personas
                                          on empresa.Id equals persona.EmpresaId into personas2
                                          select new
                                          {
                                              Empresa = empresa,
                                              Personas = personas2
                                          };

            foreach (var item in empresasYSusEmpleados_2)
            {
                Console.WriteLine($"Las siguientes personas trabajan en {item.Empresa.Nombre}");

                foreach (var persona in item.Personas)
                {
                    Console.WriteLine($"-{persona.Nombre}");
                }
            }

        }
    }

internal class Empresa
{
    public int Id { get; internal set; }
    public string Nombre { get; internal set; }
}

//Video 31
public class Distinct
    {
        public void EjDistinct()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Eduardo"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            int[] numeros = { 1, 2, 3, 1, 1, 6 };

            var numerosSinRepeticiones = numeros.Distinct();

            var personasSinNombresRepetidos = personas.DistinctBy(x => x.Nombre);

            // Sintaxis de queries
            var numerosSinRepeticiones_2 = from n in numeros.Distinct()
                                           select n;

            var personasSinNombresRepetidos_2 = from p in personas.DistinctBy(x => x.Nombre)
                                                select p;
        }
    }

//Video 32
public class Union
    {
        public void EjUnion()
        {
            var personasA = new List<Persona>()
             {
                new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
             };

            var personasB = new List<Persona>()
            {
                new Persona{Nombre = "Fernando", Edad = 25},
                new Persona { Nombre = "Eduardo", EmpresaId = 1, },
            };

            int[] numerosA = { 1, 2, 3, 1, 1, 6 };

            int[] numerosB = { 1, 2, 15 };

            var unionDeNumeros = numerosA.Union(numerosB);

            var unionDePersonas = personasA.UnionBy(personasB, x => x.Nombre);

        }
    }

//Video 35
public class Concat
    {
        public void EjConcat()
        {
            int[] A = { 1, 2, 3 };

            int[] B = { 4, 5, 6 };

            var resultado = A.Concat(B);

        }
    }