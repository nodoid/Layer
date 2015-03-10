using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException']"
	[global::Android.Runtime.Register ("com/layer/sdk/exceptions/LayerException", DoNotGenerateAcw=true)]
	public partial class LayerException : global::Java.Lang.RuntimeException {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']"
		[global::Android.Runtime.Register ("com/layer/sdk/exceptions/LayerException$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr ALREADY_AUTHENTICATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='ALREADY_AUTHENTICATED']"
			[Register ("ALREADY_AUTHENTICATED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type AlreadyAuthenticated {
				get {
					if (ALREADY_AUTHENTICATED_jfieldId == IntPtr.Zero)
						ALREADY_AUTHENTICATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALREADY_AUTHENTICATED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALREADY_AUTHENTICATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALREADY_AUTHENTICATED_jfieldId == IntPtr.Zero)
						ALREADY_AUTHENTICATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALREADY_AUTHENTICATED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALREADY_AUTHENTICATED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ALREADY_CONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='ALREADY_CONNECTED']"
			[Register ("ALREADY_CONNECTED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type AlreadyConnected {
				get {
					if (ALREADY_CONNECTED_jfieldId == IntPtr.Zero)
						ALREADY_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALREADY_CONNECTED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALREADY_CONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ALREADY_CONNECTED_jfieldId == IntPtr.Zero)
						ALREADY_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALREADY_CONNECTED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ALREADY_CONNECTED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr APP_ID_MALFORMED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='APP_ID_MALFORMED']"
			[Register ("APP_ID_MALFORMED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type AppIdMalformed {
				get {
					if (APP_ID_MALFORMED_jfieldId == IntPtr.Zero)
						APP_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID_MALFORMED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_ID_MALFORMED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_ID_MALFORMED_jfieldId == IntPtr.Zero)
						APP_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID_MALFORMED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_ID_MALFORMED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr APP_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='APP_NOT_FOUND']"
			[Register ("APP_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type AppNotFound {
				get {
					if (APP_NOT_FOUND_jfieldId == IntPtr.Zero)
						APP_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (APP_NOT_FOUND_jfieldId == IntPtr.Zero)
						APP_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, APP_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr AUTHENTICATION_CHALLENGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='AUTHENTICATION_CHALLENGE']"
			[Register ("AUTHENTICATION_CHALLENGE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type AuthenticationChallenge {
				get {
					if (AUTHENTICATION_CHALLENGE_jfieldId == IntPtr.Zero)
						AUTHENTICATION_CHALLENGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_CHALLENGE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHENTICATION_CHALLENGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AUTHENTICATION_CHALLENGE_jfieldId == IntPtr.Zero)
						AUTHENTICATION_CHALLENGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_CHALLENGE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AUTHENTICATION_CHALLENGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CANNOT_CONNECT_TO_HOST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='CANNOT_CONNECT_TO_HOST']"
			[Register ("CANNOT_CONNECT_TO_HOST")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type CannotConnectToHost {
				get {
					if (CANNOT_CONNECT_TO_HOST_jfieldId == IntPtr.Zero)
						CANNOT_CONNECT_TO_HOST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_CONNECT_TO_HOST", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANNOT_CONNECT_TO_HOST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CANNOT_CONNECT_TO_HOST_jfieldId == IntPtr.Zero)
						CANNOT_CONNECT_TO_HOST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANNOT_CONNECT_TO_HOST", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CANNOT_CONNECT_TO_HOST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CERTIFICATE_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='CERTIFICATE_NOT_FOUND']"
			[Register ("CERTIFICATE_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type CertificateNotFound {
				get {
					if (CERTIFICATE_NOT_FOUND_jfieldId == IntPtr.Zero)
						CERTIFICATE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CERTIFICATE_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CERTIFICATE_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CERTIFICATE_NOT_FOUND_jfieldId == IntPtr.Zero)
						CERTIFICATE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CERTIFICATE_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CERTIFICATE_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CONFLICT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='CONFLICT']"
			[Register ("CONFLICT")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type Conflict {
				get {
					if (CONFLICT_jfieldId == IntPtr.Zero)
						CONFLICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFLICT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONFLICT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONFLICT_jfieldId == IntPtr.Zero)
						CONFLICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFLICT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONFLICT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CONTENT_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='CONTENT_NOT_FOUND']"
			[Register ("CONTENT_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type ContentNotFound {
				get {
					if (CONTENT_NOT_FOUND_jfieldId == IntPtr.Zero)
						CONTENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CONTENT_NOT_FOUND_jfieldId == IntPtr.Zero)
						CONTENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CONTENT_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DATA_LENGTH_EXCEEDS_MAXIMUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='DATA_LENGTH_EXCEEDS_MAXIMUM']"
			[Register ("DATA_LENGTH_EXCEEDS_MAXIMUM")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type DataLengthExceedsMaximum {
				get {
					if (DATA_LENGTH_EXCEEDS_MAXIMUM_jfieldId == IntPtr.Zero)
						DATA_LENGTH_EXCEEDS_MAXIMUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_LENGTH_EXCEEDS_MAXIMUM", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_LENGTH_EXCEEDS_MAXIMUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DATA_LENGTH_EXCEEDS_MAXIMUM_jfieldId == IntPtr.Zero)
						DATA_LENGTH_EXCEEDS_MAXIMUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_LENGTH_EXCEEDS_MAXIMUM", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DATA_LENGTH_EXCEEDS_MAXIMUM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_ID_MALFORMED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='DEVICE_ID_MALFORMED']"
			[Register ("DEVICE_ID_MALFORMED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type DeviceIdMalformed {
				get {
					if (DEVICE_ID_MALFORMED_jfieldId == IntPtr.Zero)
						DEVICE_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID_MALFORMED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_ID_MALFORMED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_ID_MALFORMED_jfieldId == IntPtr.Zero)
						DEVICE_ID_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ID_MALFORMED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_ID_MALFORMED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='DEVICE_NOT_FOUND']"
			[Register ("DEVICE_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type DeviceNotFound {
				get {
					if (DEVICE_NOT_FOUND_jfieldId == IntPtr.Zero)
						DEVICE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_NOT_FOUND_jfieldId == IntPtr.Zero)
						DEVICE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_PERSISTENCE_FAILURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='DEVICE_PERSISTENCE_FAILURE']"
			[Register ("DEVICE_PERSISTENCE_FAILURE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type DevicePersistenceFailure {
				get {
					if (DEVICE_PERSISTENCE_FAILURE_jfieldId == IntPtr.Zero)
						DEVICE_PERSISTENCE_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_PERSISTENCE_FAILURE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_PERSISTENCE_FAILURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_PERSISTENCE_FAILURE_jfieldId == IntPtr.Zero)
						DEVICE_PERSISTENCE_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_PERSISTENCE_FAILURE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_PERSISTENCE_FAILURE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DEVICE_TOKEN_INVALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='DEVICE_TOKEN_INVALID']"
			[Register ("DEVICE_TOKEN_INVALID")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type DeviceTokenInvalid {
				get {
					if (DEVICE_TOKEN_INVALID_jfieldId == IntPtr.Zero)
						DEVICE_TOKEN_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_TOKEN_INVALID", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_TOKEN_INVALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEVICE_TOKEN_INVALID_jfieldId == IntPtr.Zero)
						DEVICE_TOKEN_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_TOKEN_INVALID", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEVICE_TOKEN_INVALID_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_CLAIM_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_CLAIM_NOT_FOUND']"
			[Register ("EIT_CLAIM_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitClaimNotFound {
				get {
					if (EIT_CLAIM_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_CLAIM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_CLAIM_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_CLAIM_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_CLAIM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_CLAIM_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_CLAIM_WRONG_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_CLAIM_WRONG_TYPE']"
			[Register ("EIT_CLAIM_WRONG_TYPE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitClaimWrongType {
				get {
					if (EIT_CLAIM_WRONG_TYPE_jfieldId == IntPtr.Zero)
						EIT_CLAIM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_WRONG_TYPE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_CLAIM_WRONG_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_CLAIM_WRONG_TYPE_jfieldId == IntPtr.Zero)
						EIT_CLAIM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_CLAIM_WRONG_TYPE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_CLAIM_WRONG_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_EXPIRED']"
			[Register ("EIT_EXPIRED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitExpired {
				get {
					if (EIT_EXPIRED_jfieldId == IntPtr.Zero)
						EIT_EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_EXPIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_EXPIRED_jfieldId == IntPtr.Zero)
						EIT_EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_EXPIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_EXPIRED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_HEADER_PARAM_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_HEADER_PARAM_NOT_FOUND']"
			[Register ("EIT_HEADER_PARAM_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitHeaderParamNotFound {
				get {
					if (EIT_HEADER_PARAM_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_HEADER_PARAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_HEADER_PARAM_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_HEADER_PARAM_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_HEADER_PARAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_HEADER_PARAM_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_HEADER_PARAM_WRONG_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_HEADER_PARAM_WRONG_TYPE']"
			[Register ("EIT_HEADER_PARAM_WRONG_TYPE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitHeaderParamWrongType {
				get {
					if (EIT_HEADER_PARAM_WRONG_TYPE_jfieldId == IntPtr.Zero)
						EIT_HEADER_PARAM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_TYPE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_HEADER_PARAM_WRONG_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_HEADER_PARAM_WRONG_TYPE_jfieldId == IntPtr.Zero)
						EIT_HEADER_PARAM_WRONG_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_TYPE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_HEADER_PARAM_WRONG_TYPE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_HEADER_PARAM_WRONG_VALUE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_HEADER_PARAM_WRONG_VALUE']"
			[Register ("EIT_HEADER_PARAM_WRONG_VALUE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitHeaderParamWrongValue {
				get {
					if (EIT_HEADER_PARAM_WRONG_VALUE_jfieldId == IntPtr.Zero)
						EIT_HEADER_PARAM_WRONG_VALUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_VALUE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_HEADER_PARAM_WRONG_VALUE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_HEADER_PARAM_WRONG_VALUE_jfieldId == IntPtr.Zero)
						EIT_HEADER_PARAM_WRONG_VALUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_HEADER_PARAM_WRONG_VALUE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_HEADER_PARAM_WRONG_VALUE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_KEY_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_KEY_DELETED']"
			[Register ("EIT_KEY_DELETED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitKeyDeleted {
				get {
					if (EIT_KEY_DELETED_jfieldId == IntPtr.Zero)
						EIT_KEY_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DELETED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_KEY_DELETED_jfieldId == IntPtr.Zero)
						EIT_KEY_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DELETED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_KEY_DELETED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_KEY_DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_KEY_DISABLED']"
			[Register ("EIT_KEY_DISABLED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitKeyDisabled {
				get {
					if (EIT_KEY_DISABLED_jfieldId == IntPtr.Zero)
						EIT_KEY_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DISABLED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_KEY_DISABLED_jfieldId == IntPtr.Zero)
						EIT_KEY_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_DISABLED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_KEY_DISABLED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_KEY_MALFORMED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_KEY_MALFORMED']"
			[Register ("EIT_KEY_MALFORMED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitKeyMalformed {
				get {
					if (EIT_KEY_MALFORMED_jfieldId == IntPtr.Zero)
						EIT_KEY_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_MALFORMED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_MALFORMED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_KEY_MALFORMED_jfieldId == IntPtr.Zero)
						EIT_KEY_MALFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_MALFORMED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_KEY_MALFORMED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_KEY_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_KEY_NOT_FOUND']"
			[Register ("EIT_KEY_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitKeyNotFound {
				get {
					if (EIT_KEY_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_KEY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_KEY_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_KEY_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_KEY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_KEY_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_KEY_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_MALFORMED_BASE64URL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_MALFORMED_BASE64URL']"
			[Register ("EIT_MALFORMED_BASE64URL")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitMalformedBase64url {
				get {
					if (EIT_MALFORMED_BASE64URL_jfieldId == IntPtr.Zero)
						EIT_MALFORMED_BASE64URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_BASE64URL", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_MALFORMED_BASE64URL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_MALFORMED_BASE64URL_jfieldId == IntPtr.Zero)
						EIT_MALFORMED_BASE64URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_BASE64URL", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_MALFORMED_BASE64URL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_MALFORMED_JSON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_MALFORMED_JSON']"
			[Register ("EIT_MALFORMED_JSON")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitMalformedJson {
				get {
					if (EIT_MALFORMED_JSON_jfieldId == IntPtr.Zero)
						EIT_MALFORMED_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_JSON", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_MALFORMED_JSON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_MALFORMED_JSON_jfieldId == IntPtr.Zero)
						EIT_MALFORMED_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_MALFORMED_JSON", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_MALFORMED_JSON_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_NONCE_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_NONCE_NOT_FOUND']"
			[Register ("EIT_NONCE_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitNonceNotFound {
				get {
					if (EIT_NONCE_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_NONCE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NONCE_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_NONCE_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_NONCE_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_NONCE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NONCE_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_NONCE_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_NOT_BEFORE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_NOT_BEFORE']"
			[Register ("EIT_NOT_BEFORE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitNotBefore {
				get {
					if (EIT_NOT_BEFORE_jfieldId == IntPtr.Zero)
						EIT_NOT_BEFORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NOT_BEFORE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_NOT_BEFORE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_NOT_BEFORE_jfieldId == IntPtr.Zero)
						EIT_NOT_BEFORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_NOT_BEFORE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_NOT_BEFORE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_PROVIDER_NOT_BOUND_TO_APP']"
			[Register ("EIT_PROVIDER_NOT_BOUND_TO_APP")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitProviderNotBoundToApp {
				get {
					if (EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId == IntPtr.Zero)
						EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_BOUND_TO_APP", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId == IntPtr.Zero)
						EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_BOUND_TO_APP", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_PROVIDER_NOT_BOUND_TO_APP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_PROVIDER_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_PROVIDER_NOT_FOUND']"
			[Register ("EIT_PROVIDER_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitProviderNotFound {
				get {
					if (EIT_PROVIDER_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_PROVIDER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_PROVIDER_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_PROVIDER_NOT_FOUND_jfieldId == IntPtr.Zero)
						EIT_PROVIDER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_PROVIDER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_PROVIDER_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_SIGNATURE_VERIFICATION_FAILED']"
			[Register ("EIT_SIGNATURE_VERIFICATION_FAILED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitSignatureVerificationFailed {
				get {
					if (EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId == IntPtr.Zero)
						EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_SIGNATURE_VERIFICATION_FAILED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId == IntPtr.Zero)
						EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_SIGNATURE_VERIFICATION_FAILED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_SIGNATURE_VERIFICATION_FAILED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_USER_BLACKLISTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_USER_BLACKLISTED']"
			[Register ("EIT_USER_BLACKLISTED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitUserBlacklisted {
				get {
					if (EIT_USER_BLACKLISTED_jfieldId == IntPtr.Zero)
						EIT_USER_BLACKLISTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_USER_BLACKLISTED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_USER_BLACKLISTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_USER_BLACKLISTED_jfieldId == IntPtr.Zero)
						EIT_USER_BLACKLISTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_USER_BLACKLISTED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_USER_BLACKLISTED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EIT_WRONG_JWS_PART_COUNT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EIT_WRONG_JWS_PART_COUNT']"
			[Register ("EIT_WRONG_JWS_PART_COUNT")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EitWrongJwsPartCount {
				get {
					if (EIT_WRONG_JWS_PART_COUNT_jfieldId == IntPtr.Zero)
						EIT_WRONG_JWS_PART_COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_WRONG_JWS_PART_COUNT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EIT_WRONG_JWS_PART_COUNT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EIT_WRONG_JWS_PART_COUNT_jfieldId == IntPtr.Zero)
						EIT_WRONG_JWS_PART_COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EIT_WRONG_JWS_PART_COUNT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EIT_WRONG_JWS_PART_COUNT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EVENT_DELETED']"
			[Register ("EVENT_DELETED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EventDeleted {
				get {
					if (EVENT_DELETED_jfieldId == IntPtr.Zero)
						EVENT_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_DELETED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_DELETED_jfieldId == IntPtr.Zero)
						EVENT_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_DELETED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_DELETED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='EVENT_NOT_FOUND']"
			[Register ("EVENT_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type EventNotFound {
				get {
					if (EVENT_NOT_FOUND_jfieldId == IntPtr.Zero)
						EVENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_NOT_FOUND_jfieldId == IntPtr.Zero)
						EVENT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FAILED_TO_AUTHENTICATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='FAILED_TO_AUTHENTICATE']"
			[Register ("FAILED_TO_AUTHENTICATE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type FailedToAuthenticate {
				get {
					if (FAILED_TO_AUTHENTICATE_jfieldId == IntPtr.Zero)
						FAILED_TO_AUTHENTICATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED_TO_AUTHENTICATE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_TO_AUTHENTICATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FAILED_TO_AUTHENTICATE_jfieldId == IntPtr.Zero)
						FAILED_TO_AUTHENTICATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED_TO_AUTHENTICATE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FAILED_TO_AUTHENTICATE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FAILED_TO_PERSIST_SESSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='FAILED_TO_PERSIST_SESSION']"
			[Register ("FAILED_TO_PERSIST_SESSION")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type FailedToPersistSession {
				get {
					if (FAILED_TO_PERSIST_SESSION_jfieldId == IntPtr.Zero)
						FAILED_TO_PERSIST_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED_TO_PERSIST_SESSION", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_TO_PERSIST_SESSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FAILED_TO_PERSIST_SESSION_jfieldId == IntPtr.Zero)
						FAILED_TO_PERSIST_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED_TO_PERSIST_SESSION", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FAILED_TO_PERSIST_SESSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HTTP_HEADER_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='HTTP_HEADER_NOT_FOUND']"
			[Register ("HTTP_HEADER_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type HttpHeaderNotFound {
				get {
					if (HTTP_HEADER_NOT_FOUND_jfieldId == IntPtr.Zero)
						HTTP_HEADER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_HEADER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_HEADER_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HTTP_HEADER_NOT_FOUND_jfieldId == IntPtr.Zero)
						HTTP_HEADER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_HEADER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HTTP_HEADER_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IDENTITY_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='IDENTITY_NOT_FOUND']"
			[Register ("IDENTITY_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type IdentityNotFound {
				get {
					if (IDENTITY_NOT_FOUND_jfieldId == IntPtr.Zero)
						IDENTITY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDENTITY_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDENTITY_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IDENTITY_NOT_FOUND_jfieldId == IntPtr.Zero)
						IDENTITY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDENTITY_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IDENTITY_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INTERNAL_SERVER_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='INTERNAL_SERVER_ERROR']"
			[Register ("INTERNAL_SERVER_ERROR")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type InternalServerError {
				get {
					if (INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
						INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_SERVER_ERROR", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_SERVER_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
						INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_SERVER_ERROR", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INTERNAL_SERVER_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INVALID_CONTENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='INVALID_CONTENT']"
			[Register ("INVALID_CONTENT")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type InvalidContent {
				get {
					if (INVALID_CONTENT_jfieldId == IntPtr.Zero)
						INVALID_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_CONTENT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_CONTENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INVALID_CONTENT_jfieldId == IntPtr.Zero)
						INVALID_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_CONTENT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INVALID_CONTENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INVALID_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='INVALID_MESSAGE']"
			[Register ("INVALID_MESSAGE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type InvalidMessage {
				get {
					if (INVALID_MESSAGE_jfieldId == IntPtr.Zero)
						INVALID_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_MESSAGE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INVALID_MESSAGE_jfieldId == IntPtr.Zero)
						INVALID_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_MESSAGE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INVALID_MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr KEY_PAIR_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='KEY_PAIR_NOT_FOUND']"
			[Register ("KEY_PAIR_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type KeyPairNotFound {
				get {
					if (KEY_PAIR_NOT_FOUND_jfieldId == IntPtr.Zero)
						KEY_PAIR_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_PAIR_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_PAIR_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (KEY_PAIR_NOT_FOUND_jfieldId == IntPtr.Zero)
						KEY_PAIR_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_PAIR_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, KEY_PAIR_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MEMBER_ID_REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='MEMBER_ID_REQUIRED']"
			[Register ("MEMBER_ID_REQUIRED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type MemberIdRequired {
				get {
					if (MEMBER_ID_REQUIRED_jfieldId == IntPtr.Zero)
						MEMBER_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ID_REQUIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_ID_REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MEMBER_ID_REQUIRED_jfieldId == IntPtr.Zero)
						MEMBER_ID_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_ID_REQUIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MEMBER_ID_REQUIRED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MEMBER_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='MEMBER_NOT_FOUND']"
			[Register ("MEMBER_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type MemberNotFound {
				get {
					if (MEMBER_NOT_FOUND_jfieldId == IntPtr.Zero)
						MEMBER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMBER_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MEMBER_NOT_FOUND_jfieldId == IntPtr.Zero)
						MEMBER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMBER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MEMBER_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_ALREADY_MARKED_AS_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='MESSAGE_ALREADY_MARKED_AS_READ']"
			[Register ("MESSAGE_ALREADY_MARKED_AS_READ")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type MessageAlreadyMarkedAsRead {
				get {
					if (MESSAGE_ALREADY_MARKED_AS_READ_jfieldId == IntPtr.Zero)
						MESSAGE_ALREADY_MARKED_AS_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_ALREADY_MARKED_AS_READ", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_ALREADY_MARKED_AS_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_ALREADY_MARKED_AS_READ_jfieldId == IntPtr.Zero)
						MESSAGE_ALREADY_MARKED_AS_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_ALREADY_MARKED_AS_READ", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_ALREADY_MARKED_AS_READ_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NETWORK_CONNECTION_LOST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='NETWORK_CONNECTION_LOST']"
			[Register ("NETWORK_CONNECTION_LOST")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type NetworkConnectionLost {
				get {
					if (NETWORK_CONNECTION_LOST_jfieldId == IntPtr.Zero)
						NETWORK_CONNECTION_LOST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_CONNECTION_LOST", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_CONNECTION_LOST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NETWORK_CONNECTION_LOST_jfieldId == IntPtr.Zero)
						NETWORK_CONNECTION_LOST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_CONNECTION_LOST", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NETWORK_CONNECTION_LOST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NONCE_LIMIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='NONCE_LIMIT']"
			[Register ("NONCE_LIMIT")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type NonceLimit {
				get {
					if (NONCE_LIMIT_jfieldId == IntPtr.Zero)
						NONCE_LIMIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONCE_LIMIT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONCE_LIMIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONCE_LIMIT_jfieldId == IntPtr.Zero)
						NONCE_LIMIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONCE_LIMIT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONCE_LIMIT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NOT_AUTHENTICATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='NOT_AUTHENTICATED']"
			[Register ("NOT_AUTHENTICATED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type NotAuthenticated {
				get {
					if (NOT_AUTHENTICATED_jfieldId == IntPtr.Zero)
						NOT_AUTHENTICATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHENTICATED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_AUTHENTICATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NOT_AUTHENTICATED_jfieldId == IntPtr.Zero)
						NOT_AUTHENTICATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHENTICATED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NOT_AUTHENTICATED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NOT_CONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='NOT_CONNECTED']"
			[Register ("NOT_CONNECTED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type NotConnected {
				get {
					if (NOT_CONNECTED_jfieldId == IntPtr.Zero)
						NOT_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_CONNECTED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_CONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NOT_CONNECTED_jfieldId == IntPtr.Zero)
						NOT_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_CONNECTED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NOT_CONNECTED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PERSISTENCE_CLOSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='PERSISTENCE_CLOSED']"
			[Register ("PERSISTENCE_CLOSED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type PersistenceClosed {
				get {
					if (PERSISTENCE_CLOSED_jfieldId == IntPtr.Zero)
						PERSISTENCE_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERSISTENCE_CLOSED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERSISTENCE_CLOSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PERSISTENCE_CLOSED_jfieldId == IntPtr.Zero)
						PERSISTENCE_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERSISTENCE_CLOSED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PERSISTENCE_CLOSED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr REQUEST_TIMEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='REQUEST_TIMEOUT']"
			[Register ("REQUEST_TIMEOUT")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type RequestTimeout {
				get {
					if (REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
						REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_TIMEOUT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_TIMEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
						REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_TIMEOUT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REQUEST_TIMEOUT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SERVICE_UNAVAILABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='SERVICE_UNAVAILABLE']"
			[Register ("SERVICE_UNAVAILABLE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type ServiceUnavailable {
				get {
					if (SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
						SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_UNAVAILABLE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_UNAVAILABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
						SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_UNAVAILABLE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SERVICE_UNAVAILABLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SESSION_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='SESSION_NOT_FOUND']"
			[Register ("SESSION_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type SessionNotFound {
				get {
					if (SESSION_NOT_FOUND_jfieldId == IntPtr.Zero)
						SESSION_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SESSION_NOT_FOUND_jfieldId == IntPtr.Zero)
						SESSION_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SESSION_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STREAM_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='STREAM_DELETED']"
			[Register ("STREAM_DELETED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type StreamDeleted {
				get {
					if (STREAM_DELETED_jfieldId == IntPtr.Zero)
						STREAM_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_DELETED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STREAM_DELETED_jfieldId == IntPtr.Zero)
						STREAM_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_DELETED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STREAM_DELETED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STREAM_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='STREAM_NOT_FOUND']"
			[Register ("STREAM_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type StreamNotFound {
				get {
					if (STREAM_NOT_FOUND_jfieldId == IntPtr.Zero)
						STREAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STREAM_NOT_FOUND_jfieldId == IntPtr.Zero)
						STREAM_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STREAM_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STREAM_SEQ_CONTENTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='STREAM_SEQ_CONTENTION']"
			[Register ("STREAM_SEQ_CONTENTION")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type StreamSeqContention {
				get {
					if (STREAM_SEQ_CONTENTION_jfieldId == IntPtr.Zero)
						STREAM_SEQ_CONTENTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_SEQ_CONTENTION", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_SEQ_CONTENTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STREAM_SEQ_CONTENTION_jfieldId == IntPtr.Zero)
						STREAM_SEQ_CONTENTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_SEQ_CONTENTION", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STREAM_SEQ_CONTENTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SYNCHRONIZATION_FAILURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='SYNCHRONIZATION_FAILURE']"
			[Register ("SYNCHRONIZATION_FAILURE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type SynchronizationFailure {
				get {
					if (SYNCHRONIZATION_FAILURE_jfieldId == IntPtr.Zero)
						SYNCHRONIZATION_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNCHRONIZATION_FAILURE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYNCHRONIZATION_FAILURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SYNCHRONIZATION_FAILURE_jfieldId == IntPtr.Zero)
						SYNCHRONIZATION_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNCHRONIZATION_FAILURE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SYNCHRONIZATION_FAILURE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TARGET_SEQ_REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='TARGET_SEQ_REQUIRED']"
			[Register ("TARGET_SEQ_REQUIRED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type TargetSeqRequired {
				get {
					if (TARGET_SEQ_REQUIRED_jfieldId == IntPtr.Zero)
						TARGET_SEQ_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_SEQ_REQUIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TARGET_SEQ_REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TARGET_SEQ_REQUIRED_jfieldId == IntPtr.Zero)
						TARGET_SEQ_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TARGET_SEQ_REQUIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TARGET_SEQ_REQUIRED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TIMED_OUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='TIMED_OUT']"
			[Register ("TIMED_OUT")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type TimedOut {
				get {
					if (TIMED_OUT_jfieldId == IntPtr.Zero)
						TIMED_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMED_OUT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMED_OUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TIMED_OUT_jfieldId == IntPtr.Zero)
						TIMED_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMED_OUT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TIMED_OUT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TOO_MANY_PARTICIPANTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='TOO_MANY_PARTICIPANTS']"
			[Register ("TOO_MANY_PARTICIPANTS")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type TooManyParticipants {
				get {
					if (TOO_MANY_PARTICIPANTS_jfieldId == IntPtr.Zero)
						TOO_MANY_PARTICIPANTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOO_MANY_PARTICIPANTS", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOO_MANY_PARTICIPANTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TOO_MANY_PARTICIPANTS_jfieldId == IntPtr.Zero)
						TOO_MANY_PARTICIPANTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOO_MANY_PARTICIPANTS", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TOO_MANY_PARTICIPANTS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TRANSPORT_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='TRANSPORT_ERROR']"
			[Register ("TRANSPORT_ERROR")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type TransportError {
				get {
					if (TRANSPORT_ERROR_jfieldId == IntPtr.Zero)
						TRANSPORT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSPORT_ERROR", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSPORT_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TRANSPORT_ERROR_jfieldId == IntPtr.Zero)
						TRANSPORT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSPORT_ERROR", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TRANSPORT_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNAUTHORIZED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='UNAUTHORIZED']"
			[Register ("UNAUTHORIZED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type Unauthorized {
				get {
					if (UNAUTHORIZED_jfieldId == IntPtr.Zero)
						UNAUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNAUTHORIZED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNAUTHORIZED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNAUTHORIZED_jfieldId == IntPtr.Zero)
						UNAUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNAUTHORIZED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNAUTHORIZED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNDEFINED_SYNC_FAILURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='UNDEFINED_SYNC_FAILURE']"
			[Register ("UNDEFINED_SYNC_FAILURE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type UndefinedSyncFailure {
				get {
					if (UNDEFINED_SYNC_FAILURE_jfieldId == IntPtr.Zero)
						UNDEFINED_SYNC_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDEFINED_SYNC_FAILURE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDEFINED_SYNC_FAILURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNDEFINED_SYNC_FAILURE_jfieldId == IntPtr.Zero)
						UNDEFINED_SYNC_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDEFINED_SYNC_FAILURE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNDEFINED_SYNC_FAILURE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNPROCESSABLE_RESPONSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='UNPROCESSABLE_RESPONSE']"
			[Register ("UNPROCESSABLE_RESPONSE")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type UnprocessableResponse {
				get {
					if (UNPROCESSABLE_RESPONSE_jfieldId == IntPtr.Zero)
						UNPROCESSABLE_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNPROCESSABLE_RESPONSE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNPROCESSABLE_RESPONSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNPROCESSABLE_RESPONSE_jfieldId == IntPtr.Zero)
						UNPROCESSABLE_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNPROCESSABLE_RESPONSE", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNPROCESSABLE_RESPONSE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNSPECIFIED_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='UNSPECIFIED_ERROR']"
			[Register ("UNSPECIFIED_ERROR")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type UnspecifiedError {
				get {
					if (UNSPECIFIED_ERROR_jfieldId == IntPtr.Zero)
						UNSPECIFIED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED_ERROR", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSPECIFIED_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNSPECIFIED_ERROR_jfieldId == IntPtr.Zero)
						UNSPECIFIED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED_ERROR", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNSPECIFIED_ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr USER_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='USER_NOT_FOUND']"
			[Register ("USER_NOT_FOUND")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type UserNotFound {
				get {
					if (USER_NOT_FOUND_jfieldId == IntPtr.Zero)
						USER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (USER_NOT_FOUND_jfieldId == IntPtr.Zero)
						USER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_NOT_FOUND", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, USER_NOT_FOUND_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERSION_INCORRECT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='VERSION_INCORRECT']"
			[Register ("VERSION_INCORRECT")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type VersionIncorrect {
				get {
					if (VERSION_INCORRECT_jfieldId == IntPtr.Zero)
						VERSION_INCORRECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_INCORRECT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_INCORRECT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERSION_INCORRECT_jfieldId == IntPtr.Zero)
						VERSION_INCORRECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_INCORRECT", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERSION_INCORRECT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr VERSION_REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/field[@name='VERSION_REQUIRED']"
			[Register ("VERSION_REQUIRED")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type VersionRequired {
				get {
					if (VERSION_REQUIRED_jfieldId == IntPtr.Zero)
						VERSION_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_REQUIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (VERSION_REQUIRED_jfieldId == IntPtr.Zero)
						VERSION_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_REQUIRED", "Lcom/layer/sdk/exceptions/LayerException$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, VERSION_REQUIRED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/exceptions/LayerException$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCode;
			public int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					if (id_getCode == IntPtr.Zero)
						id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getCode);
				}
			}

			static IntPtr id_fromErrorCode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/method[@name='fromErrorCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromErrorCode", "(I)Lcom/layer/sdk/exceptions/LayerException$Type;", "")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type FromErrorCode (int p0)
			{
				if (id_fromErrorCode_I == IntPtr.Zero)
					id_fromErrorCode_I = JNIEnv.GetStaticMethodID (class_ref, "fromErrorCode", "(I)Lcom/layer/sdk/exceptions/LayerException$Type;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromErrorCode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/exceptions/LayerException$Type;", "")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/layer/sdk/exceptions/LayerException$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Layer.Sdk.Exceptions.LayerException.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/layer/sdk/exceptions/LayerException$Type;", "")]
			public static global::Com.Layer.Sdk.Exceptions.LayerException.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/layer/sdk/exceptions/LayerException$Type;");
				return (global::Com.Layer.Sdk.Exceptions.LayerException.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Layer.Sdk.Exceptions.LayerException.Type));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/exceptions/LayerException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerException); }
		}

		protected LayerException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException']/constructor[@name='LayerException' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.exceptions.LayerException.Type'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/Throwable;)V", "")]
		public LayerException (global::Com.Layer.Sdk.Exceptions.LayerException.Type p0, global::Java.Lang.Throwable p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LayerException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/Throwable;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/Throwable;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/Throwable;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException']/constructor[@name='LayerException' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.exceptions.LayerException.Type'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public LayerException (global::Com.Layer.Sdk.Exceptions.LayerException.Type p0, string p1, global::Java.Lang.Throwable p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (LayerException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;Ljava/lang/Throwable;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;Ljava/lang/Throwable;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;Ljava/lang/Throwable;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException']/constructor[@name='LayerException' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.exceptions.LayerException.Type'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;)V", "")]
		public LayerException (global::Com.Layer.Sdk.Exceptions.LayerException.Type p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (LayerException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/exceptions/LayerException$Type;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException']/constructor[@name='LayerException' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.exceptions.LayerException.Type']]"
		[Register (".ctor", "(Lcom/layer/sdk/exceptions/LayerException$Type;)V", "")]
		public LayerException (global::Com.Layer.Sdk.Exceptions.LayerException.Type p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LayerException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/exceptions/LayerException$Type;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/exceptions/LayerException$Type;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/exceptions/LayerException$Type;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_exceptions_LayerException_Type_, new JValue (p0));
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Exceptions.LayerException __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.exceptions']/class[@name='LayerException']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/layer/sdk/exceptions/LayerException$Type;", "GetGetTypeHandler")]
		public virtual global::Com.Layer.Sdk.Exceptions.LayerException.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/layer/sdk/exceptions/LayerException$Type;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Exceptions.LayerException.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/layer/sdk/exceptions/LayerException$Type;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
