using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Handlers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.handlers']/interface[@name='EphemeralEventHandler']"
	[Register ("com/layer/sdk/internal/handlers/EphemeralEventHandler", "", "Com.Layer.Sdk.Internal.Handlers.IEphemeralEventHandlerInvoker")]
	public partial interface IEphemeralEventHandler : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/handlers/EphemeralEventHandler", DoNotGenerateAcw=true)]
	internal class IEphemeralEventHandlerInvoker : global::Java.Lang.Object, IEphemeralEventHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/handlers/EphemeralEventHandler");
		IntPtr class_ref;

		public static IEphemeralEventHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEphemeralEventHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.handlers.EphemeralEventHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEphemeralEventHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEphemeralEventHandlerInvoker); }
		}

	}

}
