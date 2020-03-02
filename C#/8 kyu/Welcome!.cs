using System;
using System.Collections.Generic;
using System.Linq;

//description:

//Your start-up's BA has told marketing that your website has a large audience in Scandinavia and surrounding countries. Marketing thinks it would be great to welcome visitors to the site in their own language. Luckily you already use an API that detects the user's location, so this is an easy win.

//The Task
//Think of a way to store the languages as a database (eg an object). The languages are listed below so you can copy and paste!
//Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. It should default to English if the language is not in the database, or in the event of an invalid input.
//The Database
//{ "english", "Welcome"},
//{ "czech", "Vitejte"},
//{ "danish", "Velkomst"},
//{ "dutch", "Welkom"},
//{ "estonian", "Tere tulemast"},
//{ "finnish", "Tervetuloa"},
//{ "flemish", "Welgekomen"},
//{ "french", "Bienvenue"},
//{ "german", "Willkommen"},
//{ "irish", "Failte"},
//{ "italian", "Benvenuto"},
//{ "latvian", "Gaidits"},
//{ "lithuanian", "Laukiamas"},
//{ "polish", "Witamy"},
//{ "spanish", "Bienvenido"},
//{ "swedish", "Valkommen"},
//{ "welsh", "Croeso"}
//Possible invalid inputs include:

//IP_ADDRESS_INVALID - not a valid ipv4 or ipv6 ip address
//IP_ADDRESS_NOT_FOUND - ip address not in the database
//IP_ADDRESS_REQUIRED - no ip address was supplied


    class Program
    {   
    //First solution
        public static string Greet(string language)
        {
            if (language == "english") { return "Welcome"; }
            else if(language == "czech") { return "Vitejte"; }
            else if (language == "danish") { return "Velkomst"; }
            else if (language == "dutch") { return "Welkom"; }
            else if (language == "estonian") { return "Tere tulemast"; }
            else if (language == "finnish") { return "Tervetuloa"; }
            else if (language == "flemish") { return "Welgekomen"; }
            else if (language == "french") { return "Bienvenue"; }
            else if (language == "german") { return "Willkommen"; }
            else if (language == "irish") { return "Failte"; }
            else if (language == "italian") { return "Benvenuto"; }
            else if (language == "latvian") { return "Gaidits"; }
            else if (language == "lithuanian") { return "lithuanian"; }
            else if (language == "polish") { return "Witamy"; }
            else if (language == "spanish") { return "Bienvenido"; }
            else if (language == "swedish") { return "Valkommen"; }
            else if (language == "welsh") { return "Croeso"; }
            else { return "Welcome"; }
        }
    //Second solution
        public static string Greet(string language)
        {
            string greetings;
            Dictionary<string, string> welcome = new Dictionary<string, string>
            {
              {"english", "Welcome"},
              {"czech", "Vitejte"},
              {"danish", "Velkomst"},
              {"dutch", "Welkom"},
              {"estonian", "Tere tulemast"},
              {"finnish", "Tervetuloa"},
              {"flemish", "Welgekomen"},
              {"french", "Bienvenue"},
              {"german", "Willkommen"},
              {"irish", "Failte"},
              {"italian", "Benvenuto"},
              {"latvian", "Gaidits"},
              {"lithuanian", "Laukiamas"},
              {"polish", "Witamy"},
              {"spanish", "Bienvenido"},
              {"swedish", "Valkommen"},
              {"welsh", "Croeso"}
            };
            try
            {
                greetings = welcome[language];
            }
            catch (Exception e)
            {
                greetings = "Welcome";
            }
            return greetings;
        }
    }

