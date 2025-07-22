using System.Runtime.CompilerServices;
//crear funciones y pasarlas a variables, para que su llamada se pueda hacer mas corta
var t = Tomorrow;
t();

var tDate = TomorrowDate;
tDate(new DateTime(2025,08,09));


DateTime Tomorrow()
{
    return DateTime.Now.AddDays(1); 
}

DateTime TomorrowDate(DateTime date)
{
    return date.AddDays(1);
}


//Action -> hacer algo, le puedes pasar infinitos parametros, pero no deuvleve nada
Action tAction = () => Console.WriteLine("Hello, World!");
Action<string> show = Console.WriteLine;
tAction(); 
show("Hello, World!");

Action<string> hi = name => Console.WriteLine($"Hola {name}");
hi("Cristian");
Action<int, int> add = (a, b) => show((a + b).ToString());
add(5, 10);




//Function -> hacer algo, con retorno de algo, le puedes pasar infinitios parametros, el ultimo es lo que devolveria(func<int , int,bool> en este caso es el bool)
Func<DateTime> tFunc = () => DateTime.Now.AddDays(1);

Func<int,int,int> mul =(a,b) => a * b;  
show(mul(5, 10).ToString());
Func<int, int, string> mulString = (a, b) =>
{
    var res = a * b;
    return $"El resultado de {a} * {b} es {res}";
};
show(mulString(5, 10));

//Crear un filtro generico para una lista de enteros, que reciba una lista y una funcion que sea el filtro
List<int> numbers = [1, 2, 3, 4, 5,6,7,8,9,10];
var numbers2 = Filter(numbers,numbers=>numbers%2 == 0);


//Predicate es un tipo de Func que solo se le pasa un parametro y SIEMPRE deuvelve bool
Predicate<int> condition1 = x=>x%2==0; 
Predicate<int> condition2 = x => x > 5;

var number2 = FilterPredicate(numbers, condition1);
var number3 = FilterPredicate(numbers, condition2);

var numbers4 = Filter(numbers, numbers => numbers % 2 == 0);

List<int> Filter(List<int> list, Func<int, bool> condition)
{
    List<int> result = new List<int>();
    foreach (var item in list)
    {
        if (condition(item))
        {
            result.Add(item);
        }
    }
    return result;
}
//Estas dos funciones, son equivalentes, pero la segunda es mas sencilla. por el tipo de Predicate en vez de Func
List<int> FilterPredicate(List<int> list, Predicate<int> condition)
{
    List<int> result = new List<int>();
    foreach (var item in list)
    {
        if (condition(item))
        {
            result.Add(item);
        }
    }
    return result;
}

//delegate
//de esta manera , se puede crear un delegate generico, que se puede usar para cualquier tipo de dato
Operation<int> addOp = (a, b) => a + b;
Operation<Double> addOpDouble = (a, b) => a + b;
Operation<string> concatenate = (a, b) => a +" "+ b;

Console.WriteLine(addOp(1, 5));
Console.WriteLine(addOpDouble(1.5, 3.8));
Console.WriteLine(concatenate("Cristian", "Kraker"));


delegate T Operation <T>(T element1, T element2);
