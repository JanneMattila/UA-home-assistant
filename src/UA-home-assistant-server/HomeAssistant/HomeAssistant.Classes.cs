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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace HomeAssistant
{
    #region HumiditySensorState Class
    #if (!OPCUA_EXCLUDE_HumiditySensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class HumiditySensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public HumiditySensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeAssistant.ObjectTypes.HumiditySensorType, HomeAssistant.Namespaces.HomeAssistant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUFzc2lzdGFudP////8EYIACAQAAAAEA" +
           "GgAAAEh1bWlkaXR5U2Vuc29yVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wEAAAAVYIkKAgAAAAEA" +
           "CAAAAEh1bWlkaXR5AQECAAAvAQBACQIAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQEGAAAuAEQGAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Humidity
        {
            get
            {
                return m_humidity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_humidity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_humidity = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_humidity != null)
            {
                children.Add(m_humidity);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case HomeAssistant.BrowseNames.Humidity:
                {
                    if (createOrReplace)
                    {
                        if (Humidity == null)
                        {
                            if (replacement == null)
                            {
                                Humidity = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Humidity = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Humidity;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_humidity;
        #endregion
    }
    #endif
    #endregion

    #region PressureSensorState Class
    #if (!OPCUA_EXCLUDE_PressureSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PressureSensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PressureSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeAssistant.ObjectTypes.PressureSensorType, HomeAssistant.Namespaces.HomeAssistant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUFzc2lzdGFudP////8EYIACAQAAAAEA" +
           "GgAAAFByZXNzdXJlU2Vuc29yVHlwZUluc3RhbmNlAQEIAAEBCAAIAAAA/////wEAAAAVYIkKAgAAAAEA" +
           "CAAAAFByZXNzdXJlAQEJAAAvAQBACQkAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQENAAAuAEQNAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Pressure
        {
            get
            {
                return m_pressure;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pressure, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pressure = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pressure != null)
            {
                children.Add(m_pressure);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case HomeAssistant.BrowseNames.Pressure:
                {
                    if (createOrReplace)
                    {
                        if (Pressure == null)
                        {
                            if (replacement == null)
                            {
                                Pressure = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Pressure = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Pressure;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_pressure;
        #endregion
    }
    #endif
    #endregion

    #region TemperatureSensorState Class
    #if (!OPCUA_EXCLUDE_TemperatureSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureSensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public TemperatureSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeAssistant.ObjectTypes.TemperatureSensorType, HomeAssistant.Namespaces.HomeAssistant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUFzc2lzdGFudP////8EYIACAQAAAAEA" +
           "HQAAAFRlbXBlcmF0dXJlU2Vuc29yVHlwZUluc3RhbmNlAQEPAAEBDwAPAAAA/////wEAAAAVYIkKAgAA" +
           "AAEACwAAAFRlbXBlcmF0dXJlAQEQAAAvAQBACRAAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQEUAAAuAEQUAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case HomeAssistant.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Temperature = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_temperature;
        #endregion
    }
    #endif
    #endregion

    #region BatteryDiagnosticState Class
    #if (!OPCUA_EXCLUDE_BatteryDiagnosticState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BatteryDiagnosticState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public BatteryDiagnosticState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeAssistant.ObjectTypes.BatteryDiagnosticType, HomeAssistant.Namespaces.HomeAssistant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUFzc2lzdGFudP////8EYIACAQAAAAEA" +
           "HQAAAEJhdHRlcnlEaWFnbm9zdGljVHlwZUluc3RhbmNlAQEWAAEBFgAWAAAA/////wEAAAAVYIkKAgAA" +
           "AAEABwAAAEJhdHRlcnkBARcAAC8BAEAJFwAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBARsAAC4ARBsAAAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Battery
        {
            get
            {
                return m_battery;
            }

            set
            {
                if (!Object.ReferenceEquals(m_battery, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_battery = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_battery != null)
            {
                children.Add(m_battery);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case HomeAssistant.BrowseNames.Battery:
                {
                    if (createOrReplace)
                    {
                        if (Battery == null)
                        {
                            if (replacement == null)
                            {
                                Battery = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Battery = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Battery;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_battery;
        #endregion
    }
    #endif
    #endregion

    #region IdentityDiagnosticState Class
    #if (!OPCUA_EXCLUDE_IdentityDiagnosticState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IdentityDiagnosticState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public IdentityDiagnosticState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(HomeAssistant.ObjectTypes.IdentityDiagnosticType, HomeAssistant.Namespaces.HomeAssistant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvSG9tZUFzc2lzdGFudP////8EYIACAQAAAAEA" +
           "HgAAAElkZW50aXR5RGlhZ25vc3RpY1R5cGVJbnN0YW5jZQEBHQABAR0AHQAAAP////8BAAAAFWCJCgIA" +
           "AAABAAcAAABCYXR0ZXJ5AQEeAAAvAD8eAAAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> Battery
        {
            get
            {
                return m_battery;
            }

            set
            {
                if (!Object.ReferenceEquals(m_battery, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_battery = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_battery != null)
            {
                children.Add(m_battery);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case HomeAssistant.BrowseNames.Battery:
                {
                    if (createOrReplace)
                    {
                        if (Battery == null)
                        {
                            if (replacement == null)
                            {
                                Battery = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Battery = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Battery;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_battery;
        #endregion
    }
    #endif
    #endregion
}