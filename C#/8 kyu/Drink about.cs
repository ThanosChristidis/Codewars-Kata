using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//description

//Kids drink toddy.
//Teens drink coke.
//Young adults drink beer.
//Adults drink whisky.
//Make a function that receive age, and return what they drink.

//Rules:


//Children under 14 old.
//Teens under 18 old.
//Young under 21 old.
//Adults have 21 or more.
//Examples:


//PeopleWithAgeDrink(13) == "drink toddy"
//PeopleWithAgeDrink(17) == "drink coke"
//PeopleWithAgeDrink(18) == "drink beer"
//PeopleWithAgeDrink(20) == "drink beer"
//PeopleWithAgeDrink(30) == "drink whisky"


namespace Drink_about
{
    class Program
    {
        public static string PeopleWithAgeDrink(int old) => (old < 14) ? "drink toddy" : (old < 18) ? "drink coke" : (old < 21) ? "drink beer" : "drink whisky";

    }
}
