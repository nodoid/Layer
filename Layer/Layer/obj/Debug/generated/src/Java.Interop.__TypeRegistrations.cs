using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/layer/sdk/internal/messaging",
						"com/layer/sdk/listeners",
						"com/layer/sdk/messaging",
					},
					new Converter<string, Type>[]{
						lookup_com_layer_sdk_internal_messaging_package,
						lookup_com_layer_sdk_listeners_package,
						lookup_com_layer_sdk_messaging_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_layer_sdk_internal_messaging_mappings;
		static Type lookup_com_layer_sdk_internal_messaging_package (string klass)
		{
			if (package_com_layer_sdk_internal_messaging_mappings == null) {
				package_com_layer_sdk_internal_messaging_mappings = new string[]{
					"com/layer/sdk/internal/messaging/AttributeFilter$Metadata:Com.Layer.Sdk.Internal.Messaging.AttributeFilterMetadata",
					"com/layer/sdk/internal/messaging/AttributeFilter$Participants:Com.Layer.Sdk.Internal.Messaging.AttributeFilterParticipants",
					"com/layer/sdk/internal/messaging/AttributeFilter$Recipients:Com.Layer.Sdk.Internal.Messaging.AttributeFilterRecipients",
					"com/layer/sdk/internal/messaging/AttributeFilter$Unity:Com.Layer.Sdk.Internal.Messaging.AttributeFilterUnity",
					"com/layer/sdk/internal/messaging/ChangeableContext$BackgroundContext:Com.Layer.Sdk.Internal.Messaging.ChangeableContextBackgroundContext",
					"com/layer/sdk/internal/messaging/ChangeableContext$GenericContext:Com.Layer.Sdk.Internal.Messaging.ChangeableContextGenericContext",
				};
			}

			return Lookup (package_com_layer_sdk_internal_messaging_mappings, klass);
		}

		static string[] package_com_layer_sdk_listeners_mappings;
		static Type lookup_com_layer_sdk_listeners_package (string klass)
		{
			if (package_com_layer_sdk_listeners_mappings == null) {
				package_com_layer_sdk_listeners_mappings = new string[]{
					"com/layer/sdk/listeners/LayerProgressListener$Operation:Com.Layer.Sdk.Listeners.LayerProgressListenerOperation",
					"com/layer/sdk/listeners/LayerTypingIndicatorListener$TypingIndicator:Com.Layer.Sdk.Listeners.LayerTypingIndicatorListenerTypingIndicator",
				};
			}

			return Lookup (package_com_layer_sdk_listeners_mappings, klass);
		}

		static string[] package_com_layer_sdk_messaging_mappings;
		static Type lookup_com_layer_sdk_messaging_package (string klass)
		{
			if (package_com_layer_sdk_messaging_mappings == null) {
				package_com_layer_sdk_messaging_mappings = new string[]{
					"com/layer/sdk/messaging/LayerObject$Type:Com.Layer.Sdk.Messaging.LayerObjectType",
				};
			}

			return Lookup (package_com_layer_sdk_messaging_mappings, klass);
		}
	}
}
