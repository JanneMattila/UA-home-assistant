/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace HomeAssistant
{
    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint HumiditySensorType = 1;

        /// <remarks />
        public const uint PressureSensorType = 8;

        /// <remarks />
        public const uint TemperatureSensorType = 15;

        /// <remarks />
        public const uint BatteryDiagnosticType = 22;

        /// <remarks />
        public const uint IdentityDiagnosticType = 29;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint HumiditySensorType_Humidity = 2;

        /// <remarks />
        public const uint HumiditySensorType_Humidity_EURange = 6;

        /// <remarks />
        public const uint PressureSensorType_Pressure = 9;

        /// <remarks />
        public const uint PressureSensorType_Pressure_EURange = 13;

        /// <remarks />
        public const uint TemperatureSensorType_Temperature = 16;

        /// <remarks />
        public const uint TemperatureSensorType_Temperature_EURange = 20;

        /// <remarks />
        public const uint BatteryDiagnosticType_Battery = 23;

        /// <remarks />
        public const uint BatteryDiagnosticType_Battery_EURange = 27;

        /// <remarks />
        public const uint IdentityDiagnosticType_Battery = 30;
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId HumiditySensorType = new ExpandedNodeId(HomeAssistant.ObjectTypes.HumiditySensorType, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId PressureSensorType = new ExpandedNodeId(HomeAssistant.ObjectTypes.PressureSensorType, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensorType = new ExpandedNodeId(HomeAssistant.ObjectTypes.TemperatureSensorType, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId BatteryDiagnosticType = new ExpandedNodeId(HomeAssistant.ObjectTypes.BatteryDiagnosticType, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId IdentityDiagnosticType = new ExpandedNodeId(HomeAssistant.ObjectTypes.IdentityDiagnosticType, HomeAssistant.Namespaces.HomeAssistant);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId HumiditySensorType_Humidity = new ExpandedNodeId(HomeAssistant.Variables.HumiditySensorType_Humidity, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId HumiditySensorType_Humidity_EURange = new ExpandedNodeId(HomeAssistant.Variables.HumiditySensorType_Humidity_EURange, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId PressureSensorType_Pressure = new ExpandedNodeId(HomeAssistant.Variables.PressureSensorType_Pressure, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId PressureSensorType_Pressure_EURange = new ExpandedNodeId(HomeAssistant.Variables.PressureSensorType_Pressure_EURange, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensorType_Temperature = new ExpandedNodeId(HomeAssistant.Variables.TemperatureSensorType_Temperature, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensorType_Temperature_EURange = new ExpandedNodeId(HomeAssistant.Variables.TemperatureSensorType_Temperature_EURange, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId BatteryDiagnosticType_Battery = new ExpandedNodeId(HomeAssistant.Variables.BatteryDiagnosticType_Battery, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId BatteryDiagnosticType_Battery_EURange = new ExpandedNodeId(HomeAssistant.Variables.BatteryDiagnosticType_Battery_EURange, HomeAssistant.Namespaces.HomeAssistant);

        /// <remarks />
        public static readonly ExpandedNodeId IdentityDiagnosticType_Battery = new ExpandedNodeId(HomeAssistant.Variables.IdentityDiagnosticType_Battery, HomeAssistant.Namespaces.HomeAssistant);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Battery = "Battery";

        /// <remarks />
        public const string BatteryDiagnosticType = "BatteryDiagnosticType";

        /// <remarks />
        public const string Humidity = "Humidity";

        /// <remarks />
        public const string HumiditySensorType = "HumiditySensorType";

        /// <remarks />
        public const string IdentityDiagnosticType = "IdentityDiagnosticType";

        /// <remarks />
        public const string Pressure = "Pressure";

        /// <remarks />
        public const string PressureSensorType = "PressureSensorType";

        /// <remarks />
        public const string Temperature = "Temperature";

        /// <remarks />
        public const string TemperatureSensorType = "TemperatureSensorType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the HomeAssistant namespace (.NET code namespace is 'HomeAssistant').
        /// </summary>
        public const string HomeAssistant = "http://opcfoundation.org/HomeAssistant";
    }
    #endregion
}