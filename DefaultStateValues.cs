using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace William_Chamness_206_Assignment_3
{
    /*
     * Wrapper for the constants representing default state values.
     * 
     * Pre-processed text files to sort by state. Used vim macros to automatically generate each string.
     */
    static class DefaultStateValues
    {
        public static string[] StatePopulations()
        {
            string[] statePopulations = {
                "Alaska	731545",
                "Arizona	7278717",
                "Arkansas	3017804",
                "California	39512223",
                "Colorado	5758736",
                "Connecticut	3565287",
                "Delaware	973764",
                "Florida	21477737",
                "Georgia	10617423",
                "Hawaii	1415872",
                "Idaho	1787065",
                "Illinois	12671821",
                "Indiana	6732219",
                "Iowa	3155070",
                "Kansas	2913314",
                "Kentucky	4467673",
                "Louisiana	4648794",
                "Maine	1344212",
                "Maryland	6045680",
                "Massachusetts	6892503",
                "Michigan	9986857",
                "Minnesota	5639632",
                "Mississippi	2976149",
                "Missouri	6137428",
                "Montana	1068778",
                "Nebraska	1934408",
                "Nevada	3080156",
                "New Hampshire	1359711",
                "New Jersey	8882190",
                "New Mexico	2096829",
                "New York	19453561",
                "North Carolina	10488084",
                "North Dakota	762062",
                "Ohio	11689100",
                "Oklahoma	3956971",
                "Oregon	4217737",
                "Pennsylvania	12801989",
                "Rhode Island	1059361",
                "South Carolina	5148714",
                "South Dakota	884659",
                "Tennessee	6829174",
                "Texas	28995881",
                "Utah	3205958",
                "Vermont	623989",
                "Virginia	8535519",
                "Washington	7614893",
                "West Virginia	1792147",
                "Wisconsin	5822434",
                "Wyoming	578759" };

            return statePopulations;

        }
        public static string[] StateSalaries()
        {
            string[] salaries =
            {
                "Alaska 48820",
                "Arizona 39500",
                "Arkansas 36680",
                "California 47920",
                "Colorado 47940",
                "Connecticut 48720",
                "Delaware 46700",
                "Florida 37920",
                "Georgia 38340",
                "Hawaii 47700",
                "Idaho 37550",
                "Illinois 46630",
                "Indiana 38330",
                "Iowa 39070",
                "Kansas 38050",
                "Kentucky 37660",
                "Louisiana 37320",
                "Maine 42950",
                "Maryland 48460",
                "Massachusetts 58540",
                "Michigan 45190",
                "Minnesota 47590",
                "Mississippi 35070",
                "Missouri 38130",
                "Montana 38050",
                "Nebraska 38780",
                "Nevada 37900",
                "New Hampshire	4696",
                "New Jersey	4820",
                "New Mexico	3781",
                "New York	4880",
                "North Carolina	3837",
                "North Dakota	4696",
                "Ohio 39680",
                "Oklahoma 37500",
                "Oregon 46910",
                "Pennsylvania 44900",
                "Rhode Island	4778",
                "South Carolina	3725",
                "South Dakota	3771",
                "Tennessee 37700",
                "Texas 39030",
                "Utah 38860",
                "Vermont 46910",
                "Virginia 47200",
                "Washington 50450",
                "West Virginia	3686",
                "Wisconsin 45000",
                "Wyoming 45890",
            };
            return salaries;
        }

        public static string[] StateOtherInfo()
        {
            // state    capital     largest city    bird    flower
            string[] otherInfo = {
                "Alaska	Juneau	Anchorage	Willow Ptarmigan	Forget-me-not",
                "Arizona	Phoenix	Phoenix	Cactus Wren	Saguaro Cactus Blossom",
                "Arkansas	Little Rock	Little Rock	Mockingbird	Apple Blossom",
                "California	Sacramento	Los Angeles	California Valley Quail	Golden Poppy",
                "Colorado	Denver	Denver	Lark Bunting	Columbine",
                "Connecticut	Hartford	Bridgeport	American Robin	Mountain Laurel",
                "Delaware	Dover	Wilmington	Blue Hen Chicken	Peach Blossom",
                "Florida	Tallahassee	Jacksonville	Mockingbird	Orange Blossom",
                "Georgia	Atlanta	Atlanta	Brown Thrasher	Cherokee Rose",
                "Hawaii	Honolulu	Honolulu	Nene (Hawaiian Goose)	Hibiscus",
                "Idaho	Boise	Boise	Mountain Bluebird	Syringa",
                "Illinois	Springfield	Chicago	Cardinal	Native violet",
                "Indiana	Indianapolis	Indianapolis	Cardinal	Peony",
                "Iowa	Des Moines	Des Moines	Eastern Goldfinch	Wild Rose",
                "Kansas	Topeka	Wichita	Western Meadowlark	Native Sunflower",
                "Kentucky	Frankfort	Louisville	Kentucky Cardinal	Goldenrod",
                "Louisiana	Baton Rouge	New Orleans	Pelican	Magnolia",
                "Maine	Augusta	Portland	Chickadee	White Pine Cone and Tassel",
                "Maryland	Annapolis	Baltimore	Baltimore Oriole	Black-Eyed Susan",
                "Massachusetts	Boston	Boston	Chickadee	Mayflower",
                "Michigan	Lansing	Detroit	Robin	Apple Blossom",
                "Minnesota	St. Paul	Minneapolis	Common Loon	Pink and White Lady’s Slipper",
                "Mississippi	Jackson	Jackson	Mockingbird	Magnolia",
                "Missouri	Jefferson City	Kansas City	Bluebird	Hawthorn",
                "Montana	Helena	Billings	Western Meadowlark	Bitterroot",
                "Nebraska	Lincoln	Omaha	Western Meadowlark	Goldenrod",
                "Nevada	Carson City	Las Vegas	Mountain Bluebird	Sagebrush",
                "New Hampshire	Concord	Manchester	Purple Finch	Purple Lilac",
                "New Jersey	Trenton	Newark	Eastern Goldfinch	Purple Violet",
                "New Mexico	Santa Fe	Albuquerque	Roadrunner	Yucca Flower",
                "New York	Albany	New York	Bluebird	Rose",
                "North Carolina	Raleigh	Charlotte	Cardinal	Dogwood",
                "North Dakota	Bismarck	Fargo	Western Meadowlark	Wild Prairie Rose",
                "Ohio	Columbus	Columbus	Cardinal	Scarlet Carnation",
                "Oklahoma	Oklahoma City	Oklahoma City	Scissor-Tailed Flycatcher	Mistletoe",
                "Oregon	Salem	Portland	Western Meadowlark	Oregon Grape",
                "Pennsylvania	Harrisburg	Philadelphia	Ruffed Grouse	Mountain Laurel",
                "Rhode Island	Providence	Providence	Rhode Island Red	Violet",
                "South Carolina	Columbia	Columbia	Carolina Wren	Yellow Jessamine",
                "South Dakota	Pierre	Sioux Falls	Ring-Necked Pheasant	American Pasqueflower",
                "Tennessee	Nashville	Memphis	Mockingbird	Iris",
                "Texas	Austin	Houston	Mockingbird	Bluebonnet",
                "Utah	Salt Lake City	Salt Lake City	California Gull	Sego Lily",
                "Vermont	Montpelier	Burlington	Hermit Thrush	Red Clover",
                "Virginia	Richmond	Virginia Beach	Cardinal	Dogwood",
                "Washington	Olympia	Seattle	Willow Goldfinch	Western Rhododendron",
                "West Virginia	Charleston	Charleston	Cardinal	Big Rhododendron",
                "Wisconsin	Madison	Milwaukee	Robin	Wood Violet",
                "Wyoming	Cheyenne	Cheyenne	Meadowlark	Indian Paintbrush",
            };
            return otherInfo;
        }

        /*
         * too lazy to pre-process names. just get result from another function 
         * and mutate the strings
         */
        public static string[] StateNames()
        {
            string[] states = StatePopulations();
            for(int i = 0; i < states.Length; i++)
            {
                states[i] = states[i].Split('\t')[0];  
            }
            return states;
        }
    }
}
