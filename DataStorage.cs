using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppT
{
    internal class DataStorage
    {

        /// <summary>
        /// Lista för att lagra kvitton på köp och sälj
        /// </summary>
        public static List<string> kvittona = new();


        /// <summary>
        /// List för att lagra köpare(privatpersoner)
        /// </summary>
        public static List<string> buyers = new();


        /// <summary>
        /// Lista för att lagra säljare(privatpersoner)
        /// </summary>
        public static List<string> sellers = new();

        /// <summary>
        /// Lista på bilarna i garaget/till salu
        /// </summary>
        public static List<string> bilarna = new() // lista över alla bilar
                                        {
                                            "Toyota Auris",
                                            "BMW M3",
                                            "Nissan Skyline",
                                            "Volvo V70"
                                        };

        /// <summary>
        /// Lista för att lagra instämplad personal
        /// </summary>
        public static List<string> personal = new();


        /// <summary>
        /// Lista på Ärenden
        /// </summary>
        public static List<string> ToDo = new()
                                        {
                                            "Ärende: Volvo XC60, Trasig framruta --> Inlagt av: Bob",
                                            "Ärende: Dacia Duster, Byta till vinterdäck --> Inlagt av: Bob",
                                            "Ärende: Honda Civic, Repor i lacken --> Inlagt av: Bob"
                                        };

        /// <summary>
        /// Lista på uppklarade ärenden
        /// </summary>
        public static List<string> ResolveTodo = new();




    }
}
