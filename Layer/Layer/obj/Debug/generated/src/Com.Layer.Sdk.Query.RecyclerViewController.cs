using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']"
	[global::Android.Runtime.Register ("com/layer/sdk/query/RecyclerViewController", DoNotGenerateAcw=true)]
	public abstract partial class RecyclerViewController : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']"
		[Register ("com/layer/sdk/query/RecyclerViewController$Callback", "", "Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryDataSetChanged' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController']]"
			[Register ("onQueryDataSetChanged", "(Lcom/layer/sdk/query/RecyclerViewController;)V", "GetOnQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_Handler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryDataSetChanged (global::Com.Layer.Sdk.Query.RecyclerViewController p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryItemChanged' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController'] and parameter[2][@type='int']]"
			[Register ("onQueryItemChanged", "(Lcom/layer/sdk/query/RecyclerViewController;I)V", "GetOnQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_IHandler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryItemChanged (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryItemInserted' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController'] and parameter[2][@type='int']]"
			[Register ("onQueryItemInserted", "(Lcom/layer/sdk/query/RecyclerViewController;I)V", "GetOnQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_IHandler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryItemInserted (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryItemMoved' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onQueryItemMoved", "(Lcom/layer/sdk/query/RecyclerViewController;II)V", "GetOnQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_IIHandler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryItemMoved (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryItemRangeChanged' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onQueryItemRangeChanged", "(Lcom/layer/sdk/query/RecyclerViewController;II)V", "GetOnQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_IIHandler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryItemRangeChanged (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryItemRangeInserted' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onQueryItemRangeInserted", "(Lcom/layer/sdk/query/RecyclerViewController;II)V", "GetOnQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_IIHandler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryItemRangeInserted (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryItemRangeRemoved' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onQueryItemRangeRemoved", "(Lcom/layer/sdk/query/RecyclerViewController;II)V", "GetOnQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_IIHandler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryItemRangeRemoved (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='RecyclerViewController.Callback']/method[@name='onQueryItemRemoved' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.RecyclerViewController'] and parameter[2][@type='int']]"
			[Register ("onQueryItemRemoved", "(Lcom/layer/sdk/query/RecyclerViewController;I)V", "GetOnQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_IHandler:Com.Layer.Sdk.Query.RecyclerViewController/ICallbackInvoker, Layer")]
			void OnQueryItemRemoved (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/query/RecyclerViewController$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/query/RecyclerViewController$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.query.RecyclerViewController.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			static Delegate cb_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_;
#pragma warning disable 0169
			static Delegate GetOnQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_Handler ()
			{
				if (cb_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_ == null)
					cb_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_);
				return cb_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_;
			}

			static void n_OnQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryDataSetChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_;
			public void OnQueryDataSetChanged (global::Com.Layer.Sdk.Query.RecyclerViewController p0)
			{
				if (id_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_ == IntPtr.Zero)
					id_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_ = JNIEnv.GetMethodID (class_ref, "onQueryDataSetChanged", "(Lcom/layer/sdk/query/RecyclerViewController;)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryDataSetChanged_Lcom_layer_sdk_query_RecyclerViewController_, new JValue (p0));
			}

			static Delegate cb_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I;
#pragma warning disable 0169
			static Delegate GetOnQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_IHandler ()
			{
				if (cb_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I == null)
					cb_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I);
				return cb_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I;
			}

			static void n_OnQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryItemChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I;
			public void OnQueryItemChanged (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1)
			{
				if (id_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I == IntPtr.Zero)
					id_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I = JNIEnv.GetMethodID (class_ref, "onQueryItemChanged", "(Lcom/layer/sdk/query/RecyclerViewController;I)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryItemChanged_Lcom_layer_sdk_query_RecyclerViewController_I, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I;
#pragma warning disable 0169
			static Delegate GetOnQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_IHandler ()
			{
				if (cb_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I == null)
					cb_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I);
				return cb_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I;
			}

			static void n_OnQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryItemInserted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I;
			public void OnQueryItemInserted (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1)
			{
				if (id_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I == IntPtr.Zero)
					id_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I = JNIEnv.GetMethodID (class_ref, "onQueryItemInserted", "(Lcom/layer/sdk/query/RecyclerViewController;I)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryItemInserted_Lcom_layer_sdk_query_RecyclerViewController_I, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II;
#pragma warning disable 0169
			static Delegate GetOnQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_IIHandler ()
			{
				if (cb_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II == null)
					cb_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II);
				return cb_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II;
			}

			static void n_OnQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryItemMoved (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II;
			public void OnQueryItemMoved (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2)
			{
				if (id_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II == IntPtr.Zero)
					id_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II = JNIEnv.GetMethodID (class_ref, "onQueryItemMoved", "(Lcom/layer/sdk/query/RecyclerViewController;II)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryItemMoved_Lcom_layer_sdk_query_RecyclerViewController_II, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II;
#pragma warning disable 0169
			static Delegate GetOnQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_IIHandler ()
			{
				if (cb_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II == null)
					cb_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II);
				return cb_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II;
			}

			static void n_OnQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryItemRangeChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II;
			public void OnQueryItemRangeChanged (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2)
			{
				if (id_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II == IntPtr.Zero)
					id_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II = JNIEnv.GetMethodID (class_ref, "onQueryItemRangeChanged", "(Lcom/layer/sdk/query/RecyclerViewController;II)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryItemRangeChanged_Lcom_layer_sdk_query_RecyclerViewController_II, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II;
#pragma warning disable 0169
			static Delegate GetOnQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_IIHandler ()
			{
				if (cb_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II == null)
					cb_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II);
				return cb_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II;
			}

			static void n_OnQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryItemRangeInserted (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II;
			public void OnQueryItemRangeInserted (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2)
			{
				if (id_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II == IntPtr.Zero)
					id_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II = JNIEnv.GetMethodID (class_ref, "onQueryItemRangeInserted", "(Lcom/layer/sdk/query/RecyclerViewController;II)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryItemRangeInserted_Lcom_layer_sdk_query_RecyclerViewController_II, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II;
#pragma warning disable 0169
			static Delegate GetOnQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_IIHandler ()
			{
				if (cb_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II == null)
					cb_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II);
				return cb_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II;
			}

			static void n_OnQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryItemRangeRemoved (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II;
			public void OnQueryItemRangeRemoved (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1, int p2)
			{
				if (id_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II == IntPtr.Zero)
					id_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II = JNIEnv.GetMethodID (class_ref, "onQueryItemRangeRemoved", "(Lcom/layer/sdk/query/RecyclerViewController;II)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryItemRangeRemoved_Lcom_layer_sdk_query_RecyclerViewController_II, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I;
#pragma warning disable 0169
			static Delegate GetOnQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_IHandler ()
			{
				if (cb_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I == null)
					cb_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I);
				return cb_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I;
			}

			static void n_OnQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Layer.Sdk.Query.RecyclerViewController p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryItemRemoved (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I;
			public void OnQueryItemRemoved (global::Com.Layer.Sdk.Query.RecyclerViewController p0, int p1)
			{
				if (id_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I == IntPtr.Zero)
					id_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I = JNIEnv.GetMethodID (class_ref, "onQueryItemRemoved", "(Lcom/layer/sdk/query/RecyclerViewController;I)V");
				JNIEnv.CallVoidMethod (Handle, id_onQueryItemRemoved_Lcom_layer_sdk_query_RecyclerViewController_I, new JValue (p0), new JValue (p1));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/query/RecyclerViewController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecyclerViewController); }
		}

		protected RecyclerViewController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']/constructor[@name='RecyclerViewController' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RecyclerViewController () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RecyclerViewController)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItemCount);
			return cb_getItemCount;
		}

		static IntPtr n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.RecyclerViewController __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemCount);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Integer ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()Ljava/lang/Integer;", "GetGetItemCountHandler")] get;
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.RecyclerViewController __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public abstract void Execute ();

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Layer.Sdk.Query.RecyclerViewController __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.RecyclerViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/layer/sdk/query/Queryable;", "GetGetItem_IHandler")]
		public abstract global::Java.Lang.Object GetItem (int p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/query/RecyclerViewController", DoNotGenerateAcw=true)]
	internal partial class RecyclerViewControllerInvoker : RecyclerViewController {

		public RecyclerViewControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecyclerViewControllerInvoker); }
		}

		static IntPtr id_getItemCount;
		public override global::Java.Lang.Integer ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()Ljava/lang/Integer;", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getItemCount), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public override void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_execute);
		}

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/class[@name='RecyclerViewController']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/layer/sdk/query/Queryable;", "GetGetItem_IHandler")]
		public override global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/layer/sdk/query/Queryable;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
