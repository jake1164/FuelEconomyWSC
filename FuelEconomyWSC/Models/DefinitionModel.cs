using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotJustMaple.WebService.FuelEconomy.Models
{
    public class DefinitionModel
    {
        /// <summary>
        /// Code-versions of http://www.fueleconomy.gov/feg/ws/wsData.shtml
        /// </summary>
        public class Definitions
        {
            /// <summary>
            /// atvtype - alternative fuel or advanced technology vehicle
            /// </summary>
            public readonly Dictionary<string, string> AlternativeFuel = new Dictionary<string, string>
                                                                         {
                                                                             {
                                                                                 "Bifuel (CNG)",
                                                                                 "Bi-fuel gasoline and compressed natural gas vehicle"
                                                                             },
                                                                             {
                                                                                 "Bifuel (LPG)",
                                                                                 "Bi-fuel gasoline and propane vehicle"
                                                                             },
                                                                             {
                                                                                 "CNG",
                                                                                 "Compressed natural gas vehicle"
                                                                             },
                                                                             {"Diesel", "Diesel vehicle"},
                                                                             {"EV", "Electric vehicle"},
                                                                             {
                                                                                 "FFV",
                                                                                 "Flexible fueled vehicle (gasoline or E85)"
                                                                             },
                                                                             {"Hybrid", "Hybrid vehicle"},
                                                                             {
                                                                                 "Plug-in Hybrid",
                                                                                 "Plug-in hybrid vehicle"
                                                                             }
                                                                         };

            /// <summary>
            /// standard - Vehicle Emission Standards*
            /// For additional information visit http://ofmpub.epa.gov/greenvehicles/summarychart.pdf
            /// </summary>
            public readonly Dictionary<string, string> EmissionsStandard = new Dictionary<string, string>
                                                                           {
                                                                               {"B1", "Bin 1"},
                                                                               {"B2", "Bin 2"},
                                                                               {"B3", "Bin 3"},
                                                                               {"B4", "Bin 4"},
                                                                               {"B5", "Bin 5"},
                                                                               {"B7", "Bin 7"},
                                                                               {"B8", "Bin 8"},
                                                                               {"B9", "Bin 9"},
                                                                               {"Bin 10", "Bin 10"},
                                                                               {"L1", "LEV"},
                                                                               {"L2", "LEV,II"},
                                                                               {"L2OP", "LEV,II Optional"},
                                                                               {"LEV", "LEV"},
                                                                               {"PZEV", "PZEV"},
                                                                               {"S1", "SULEV"},
                                                                               {"SLEV", "SULEV"},
                                                                               {"T1", "Tier 1"},
                                                                               {"L2", "LEV,II"},
                                                                               {"BU1", "ULEV"},
                                                                               {"U2", "LEV,II ULEV"},
                                                                               {"ULEV", "ULEV"},
                                                                               {"ZEV", "ZEV"}
                                                                           };
        }
    }
}