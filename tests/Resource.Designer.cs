﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HSPI_HomeKitControllerTest {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HSPI_HomeKitControllerTest.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;accessories&quot;:[{&quot;aid&quot;:1,&quot;services&quot;:[{&quot;iid&quot;:1,&quot;type&quot;:&quot;0000003e-0000-1000-8000-0026bb765291&quot;,&quot;primary&quot;:null,&quot;hidden&quot;:null,&quot;characteristics&quot;:{}},{&quot;iid&quot;:8,&quot;type&quot;:&quot;0000008a-0000-1000-8000-0026bb765291&quot;,&quot;primary&quot;:null,&quot;hidden&quot;:null,&quot;characteristics&quot;:{}}],&quot;Name&quot;:&quot;Sensor1&quot;,&quot;Version&quot;:null,&quot;Model&quot;:&quot;&quot;,&quot;SerialNumber&quot;:&quot;default&quot;,&quot;FirmwareRevision&quot;:&quot;&quot;}]}.
        /// </summary>
        internal static string TemperatureSensorPairedAccessoryJson {
            get {
                return ResourceManager.GetString("TemperatureSensorPairedAccessoryJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;$type&quot;:&quot;System.Collections.Generic.SortedDictionary`2[[System.Int32, mscorlib],[System.Collections.Generic.Dictionary`2[[HomeSeer.PluginSdk.Devices.EProperty, PluginSdk],[System.Object, mscorlib]], mscorlib]], System&quot;,&quot;8475&quot;:{&quot;$type&quot;:&quot;System.Collections.Generic.Dictionary`2[[HomeSeer.PluginSdk.Devices.EProperty, PluginSdk],[System.Object, mscorlib]], mscorlib&quot;,&quot;PlugExtraData&quot;:[{&quot;key&quot;:&quot;accessory.aid&quot;,&quot;value&quot;:&quot;1&quot;},{&quot;key&quot;:&quot;enabled.characteristic&quot;,&quot;value&quot;:&quot;[9]&quot;},{&quot;key&quot;:&quot;pairing.info&quot;,&quot;value&quot;:&quot;{\&quot;DeviceInforma [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TemperatureSensorPairedHS3DataJson {
            get {
                return ResourceManager.GetString("TemperatureSensorPairedHS3DataJson", resourceCulture);
            }
        }
    }
}
