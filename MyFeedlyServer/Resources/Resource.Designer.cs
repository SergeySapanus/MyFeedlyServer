﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFeedlyServer.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MyFeedlyServer.Resources.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong inside {0} action: {1}.
        /// </summary>
        public static string LogErrorException {
            get {
                return ResourceManager.GetString("LogErrorException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} with id: {1}, hasn&apos;t been found in db..
        /// </summary>
        public static string LogErrorGetByIdIsNull {
            get {
                return ResourceManager.GetString("LogErrorGetByIdIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid {0} object sent from client. {1}.
        /// </summary>
        public static string LogErrorInvalidModel {
            get {
                return ResourceManager.GetString("LogErrorInvalidModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} object sent from client is null..
        /// </summary>
        public static string LogErrorObjectIsNull {
            get {
                return ResourceManager.GetString("LogErrorObjectIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returned all users from database..
        /// </summary>
        public static string LogInfoGetAllUsers {
            get {
                return ResourceManager.GetString("LogInfoGetAllUsers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returned {0} with id: {1}.
        /// </summary>
        public static string LogInfoGetById {
            get {
                return ResourceManager.GetString("LogInfoGetById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid model object.
        /// </summary>
        public static string Status400BadRequestInvalidModel {
            get {
                return ResourceManager.GetString("Status400BadRequestInvalidModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} object is null.
        /// </summary>
        public static string Status400BadRequestObjectIsNull {
            get {
                return ResourceManager.GetString("Status400BadRequestObjectIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal server error.
        /// </summary>
        public static string Status500 {
            get {
                return ResourceManager.GetString("Status500", resourceCulture);
            }
        }
    }
}