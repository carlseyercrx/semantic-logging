﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Argument is empty.
        /// </summary>
        internal static string ArgumentIsEmptyError {
            get {
                return ResourceManager.GetString("ArgumentIsEmptyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be an instance of ObservableEventListener..
        /// </summary>
        internal static string ArgumentMustBeObservableEventListener {
            get {
                return ResourceManager.GetString("ArgumentMustBeObservableEventListener", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The size of &apos;{0}&apos; should be greater or equal to &apos;{1}&apos;..
        /// </summary>
        internal static string ArgumentNotGreaterOrEqualTo {
            get {
                return ResourceManager.GetString("ArgumentNotGreaterOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The size of &apos;{0}&apos; should be lower or equal to &apos;{1}&apos;..
        /// </summary>
        internal static string ArgumentNotLowerOrEqualTo {
            get {
                return ResourceManager.GetString("ArgumentNotLowerOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An event type argument could not be properly serialized into an event source manifest. Verify any use of Enums whose base type is other than Int32 or Int64 and replace it with any of these allowed types. For more infromation about issues using Enums read: http://connect.microsoft.com/VisualStudio/feedback/details/785409/eventsource-manifest-generation-creates-wrong-map-values-for-enum-types-other-than-int32-or-int64.
        /// </summary>
        internal static string EventSourceAnalyzerBadFormedManifestError {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerBadFormedManifestError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of WriteEvent arguments and event parameters are different in event name &apos;{0}&apos;..
        /// </summary>
        internal static string EventSourceAnalyzerDifferentParameterCount {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerDifferentParameterCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EventSource manifest generation failure.
        ///{0}
        ///Manifest:
        ///{1}.
        /// </summary>
        internal static string EventSourceAnalyzerManifestGenerationError {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerManifestGenerationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A call to method &apos;{0}&apos; threw an exception..
        /// </summary>
        internal static string EventSourceAnalyzerMethodCallError {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerMethodCallError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter name &apos;{0}&apos; defined in the event &apos;{1}&apos; does not match the order in WriteEvent function..
        /// </summary>
        internal static string EventSourceAnalyzerMismatchParametersOrder {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerMismatchParametersOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter name &apos;{0}&apos; with type &apos;{1}&apos; does not match the payload type &apos;{2}&apos; in method &apos;{3}&apos;. Check the parameter type in WriteEvent and assign a type that matches the same event arguement type . .
        /// </summary>
        internal static string EventSourceAnalyzerMismatchParametersType {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerMismatchParametersType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event method &apos;{0}&apos; does not call WriteEvent() or the call is bypassed due to incorrect filtering before the WriteEvent call..
        /// </summary>
        internal static string EventSourceAnalyzerMissingWriteEventCallError {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerMissingWriteEventCallError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified EventSource does not have any method decorated with EventAttribute..
        /// </summary>
        internal static string EventSourceAnalyzerNoEventsError {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerNoEventsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The payload argument in position &apos;{0}&apos; is sending a null value which may not map to the parameter &apos;{1}&apos; in event &apos;{2}&apos;..
        /// </summary>
        internal static string EventSourceAnalyzerNullPayloadValue {
            get {
                return ResourceManager.GetString("EventSourceAnalyzerNullPayloadValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment Variables access denied..
        /// </summary>
        internal static string ExceptionReadEnvironmentVariablesDenied {
            get {
                return ResourceManager.GetString("ExceptionReadEnvironmentVariablesDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while flushing the event entries..
        /// </summary>
        internal static string FlushFailedException {
            get {
                return ResourceManager.GetString("FlushFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not created the formatter specified in configuration element name &apos;{0}&apos;..
        /// </summary>
        internal static string FormatterElementNotResolvedError {
            get {
                return ResourceManager.GetString("FormatterElementNotResolvedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters specified in this element does not map to an existing type member. All paramters are required in the same order of the defined type member. .
        /// </summary>
        internal static string IncompleteArgumentsError {
            get {
                return ResourceManager.GetString("IncompleteArgumentsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid arguments combination for buffering interval and count. Please specify valid range values for count and interval parameters..
        /// </summary>
        internal static string InvalidBufferingArguments {
            get {
                return ResourceManager.GetString("InvalidBufferingArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value does not represent a connection string.
        /// </summary>
        internal static string InvalidConnectionStringError {
            get {
                return ResourceManager.GetString("InvalidConnectionStringError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The date time format is invalid..
        /// </summary>
        internal static string InvalidDateTimeFormatError {
            get {
                return ResourceManager.GetString("InvalidDateTimeFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A file name with a relative path is not allowed. Provide only the file name or the full path of the file..
        /// </summary>
        internal static string InvalidNavigationPathInFileNameError {
            get {
                return ResourceManager.GetString("InvalidNavigationPathInFileNameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A file name with a relative path after replacing environment variables is not allowed. Provide only the file name or the full path of the file..
        /// </summary>
        internal static string InvalidNavigationPathInReplacedFileNameError {
            get {
                return ResourceManager.GetString("InvalidNavigationPathInReplacedFileNameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot serialize to JSON format the payload: {0}.
        /// </summary>
        internal static string JsonSerializationError {
            get {
                return ResourceManager.GetString("JsonSerializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maxBufferSize argument has to be at least 3 times larger than the bufferingCount argument. Current values are maxBufferSize={0} and bufferingCount={1}..
        /// </summary>
        internal static string MaxBufferSizeShouldBeLargerThanBufferingCount {
            get {
                return ResourceManager.GetString("MaxBufferSizeShouldBeLargerThanBufferingCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot serialize the payload: {0}.
        /// </summary>
        internal static string TextSerializationError {
            get {
                return ResourceManager.GetString("TextSerializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The valid range for &apos;{0}&apos; is from 0 to 24.20:31:23.647.
        /// </summary>
        internal static string TimeSpanOutOfRangeError {
            get {
                return ResourceManager.GetString("TimeSpanOutOfRangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot serialize to XML format the payload: {0}.
        /// </summary>
        internal static string XmlSerializationError {
            get {
                return ResourceManager.GetString("XmlSerializationError", resourceCulture);
            }
        }
    }
}
