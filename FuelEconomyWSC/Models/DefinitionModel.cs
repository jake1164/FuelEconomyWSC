/********************************************************************************
### The MIT License (MIT)

### Copyright (c) 2013 Jason Jackson

### Permission is hereby granted, free of charge, to any person obtaining a copy of
### this software and associated documentation files (the "Software"), to deal in
### the Software without restriction, including without limitation the rights to
### use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
### the Software, and to permit persons to whom the Software is furnished to do so,
### subject to the following conditions:

### The above copyright notice and this permission notice shall be included in all
### copies or substantial portions of the Software.

### THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
### IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
### FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
### COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
### IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
### CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### This software is an adaptation of Parker Smith's FEWS C# project from github
### https://github.com/parkrrr/FEWS

*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotJustMaple.WebService.FuelEconomy.API.Models
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