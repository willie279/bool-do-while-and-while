using System.Dynamic;

string? readResult;
Console.WriteLine("Enter a string: ");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
//***********************************************************************//

// Escribir una cadena que incluya al menos 3 caracteres.

string? readResult1;
bool validEntry = false;
Console.WriteLine("Enter a string contain at least three characters:");
do
{
    readResult1 = Console.ReadLine();
    if (readResult1 != null)
    {
        if (readResult1.Length > 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Enter a valid string");
        }
    }

} while (!validEntry);/* esto es un true, dado que la variable esta negada.
 al cambiarla de valor en el if a true, el resutado negado es un flaso, se rompe el ciclo.*/
//***********************************************************************//

// capture user input in a string variable named readResult

string readResult3 = "78"; // si no escribo un numero, la variable me regresa un false 
int numericValue = 0;         // y no se asigna valor numerico a la variable.  
bool validNumber = false;

validNumber = int.TryParse(readResult3, out numericValue);
Console.WriteLine(validNumber); // esto me arroja un true
Console.WriteLine(numericValue);
//***********************************************************************//

//proyecto de codigo que valida una entrada de enteros

string? entero;
int rightNumber = 0;
bool EnterValid = false;
bool numbervalid = false;

Console.WriteLine("Entre un numero entero en el rango de 5 a 10");
do
{
    entero = Console.ReadLine();
    EnterValid = int.TryParse(entero, out rightNumber); //Si escribo un entero esto me arroja un true
    if (EnterValid) // si la variable es true entra al if
    {
        if ((rightNumber > 5) && (rightNumber < 10))
        {
            numbervalid = true;
        }
        else
        {
            Console.WriteLine($"digito {entero}. digite un numero entero dentro del rango valido");
        }
    }
    else
    {
        Console.WriteLine("Por favor, digite un numero entero");
    }


} while (!numbervalid); /* esto es un true, dado que la variable esta negada.
 al cambiarla de valor en el if a true, el resutado negado es un falso, se rompe el ciclo.*/

Console.WriteLine($"su entrada {entero} ha sido validada y aceptada");
entero = Console.ReadLine();
//********************************************************************************************//

//codigo que valida una entrada de enteros. otra forma de hacerlo!

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();
//********************************************************************************************//

// Proyecto de codigo que valida una entrada de cadena

string? rolAssigment;
string tipedRolled = "";
bool rolValid = false;

Console.WriteLine("Enter your rol name (Administrator, Manager or User)");
do
{
    rolAssigment = Console.ReadLine();
    if (rolAssigment != null)
    {
        tipedRolled = rolAssigment.Trim().ToLower();

    }
    if (tipedRolled.Contains("administrator") || (tipedRolled.Contains("manager")))
    {

        rolValid = true;
    }

    else if (tipedRolled.Contains("user"))
    {

        rolValid = true;
    }
    else
    {
        Console.WriteLine($"The role name that your entered,\"{tipedRolled}\" is not valid. Enter your rol name (Administrator, Manager or User) ");
    }

} while (!rolValid);/* esto es un true, dado que la variable esta negada.
 al cambiarla de valor en el if a true, el resutado negado es un falso, se rompe el ciclo.*/
Console.WriteLine($"your input value ({rolAssigment}) has been accepted");
//********************************************************************************************//

// Proyecto de codigo que valida una entrada de cadena. otra forma de hacerlo!

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();
//********************************************************************************************//

// Solucion del proyecto.

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;
/*el for me recorre la posicion de una cadena (indice base cero)
para este caso tengo dos posiciones 0 y 1, no recorre carcateres. 
*/
for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    string mySentence;

    //extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        //first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);// me elimina todo a partir del punto (.) hacia la derecha.

        //the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);// corre una posicion a partir del punto (.)

        //remove any leading white-space from myString
        myString = myString.TrimStart(); // elimina todo espacio incial 

        //update the comma location and increment the counter
        periodLocation = myString.IndexOf("."); // reinicia la busqueda del punto a partir de la posicion indicada
        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
//************************************************************************************************//

// Testnumber();
// static void Testnumber()
// {
//     string? entero;
//     int rightNumber = 0;
//     bool EnterValid = false;
//     bool numbervalid = false;

//     Console.WriteLine("Entre un numero entero en el rango de 5 a 10");
//     do
//     {
//         entero = Console.ReadLine();
//         EnterValid = int.TryParse(entero, out rightNumber);
//         if (EnterValid)
//         {
//             if ((rightNumber > 5) && (rightNumber < 10))
//             {
//                 numbervalid = true;
//             }
//             else
//             {
//                 Console.WriteLine($"digito {entero}. digite un numero entero dentro del rango valido");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Por favor, digite un numero entero");
//         }

//     } while (numbervalid == false);

// }