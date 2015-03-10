using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController", DoNotGenerateAcw=true)]
	public partial class QueryController : global::Com.Layer.Sdk.Query.RecyclerViewController, global::Com.Layer.Sdk.Listeners.ILayerChangeEventListenerBackgroundThread {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationContract']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$CalculationContract", DoNotGenerateAcw=true)]
		protected internal partial class CalculationContract : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$CalculationContract", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CalculationContract); }
			}

			protected CalculationContract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationContract']/constructor[@name='QueryController.CalculationContract' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected CalculationContract () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CalculationContract)) {
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

			static IntPtr id_a_Ljava_lang_Iterable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationContract']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
			[Register ("a", "(Ljava/lang/Iterable;)Lcom/layer/sdk/internal/query/QueryController$CalculationContract;", "")]
			public global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationContract A (global::Java.Lang.IIterable p0)
			{
				if (id_a_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_a_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Iterable;)Lcom/layer/sdk/internal/query/QueryController$CalculationContract;");
				global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationContract __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationContract> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_b_Ljava_lang_Iterable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationContract']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
			[Register ("b", "(Ljava/lang/Iterable;)Lcom/layer/sdk/internal/query/QueryController$CalculationContract;", "")]
			public global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationContract B (global::Java.Lang.IIterable p0)
			{
				if (id_b_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_b_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/Iterable;)Lcom/layer/sdk/internal/query/QueryController$CalculationContract;");
				global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationContract __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationContract> (JNIEnv.CallObjectMethod  (Handle, id_b_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationResult']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$CalculationResult", DoNotGenerateAcw=true)]
		protected internal partial class CalculationResult : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$CalculationResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CalculationResult); }
			}

			protected CalculationResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationResult']/constructor[@name='QueryController.CalculationResult' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected CalculationResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CalculationResult)) {
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

			static IntPtr id_a_Lcom_layer_sdk_internal_query_QueryController_Update_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationResult']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.query.QueryController.Update']]"
			[Register ("a", "(Lcom/layer/sdk/internal/query/QueryController$Update;)V", "")]
			public void A (global::Com.Layer.Sdk.Internal.Query.QueryController.Update p0)
			{
				if (id_a_Lcom_layer_sdk_internal_query_QueryController_Update_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_query_QueryController_Update_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/query/QueryController$Update;)V");
				JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_query_QueryController_Update_, new JValue (p0));
			}

			static IntPtr id_a_Ljava_util_List_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationResult']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.util.Map']]"
			[Register ("a", "(Ljava/util/List;Ljava/util/Map;)Lcom/layer/sdk/internal/query/QueryController$CalculationResult;", "")]
			public global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationResult A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0, global::System.Collections.Generic.IDictionary<global::Android.Net.Uri, global::Java.Lang.Integer> p1)
			{
				if (id_a_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
					id_a_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;Ljava/util/Map;)Lcom/layer/sdk/internal/query/QueryController$CalculationResult;");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Android.Net.Uri, global::Java.Lang.Integer>.ToLocalJniHandle (p1);
				global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationResult __ret = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController.CalculationResult> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_List_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static IntPtr id_a_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.CalculationResult']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "")]
			public void A (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update> p0)
			{
				if (id_a_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.ContentUpdate']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$ContentUpdate", DoNotGenerateAcw=true)]
		protected internal partial class ContentUpdate : global::Com.Layer.Sdk.Internal.Query.QueryController.Update {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$ContentUpdate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ContentUpdate); }
			}

			protected ContentUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILandroid_net_Uri_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.ContentUpdate']/constructor[@name='QueryController.ContentUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.net.Uri']]"
			[Register (".ctor", "(ILandroid/net/Uri;)V", "")]
			protected ContentUpdate (int p0, global::Android.Net.Uri p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ContentUpdate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILandroid/net/Uri;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILandroid/net/Uri;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_ILandroid_net_Uri_ == IntPtr.Zero)
					id_ctor_ILandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/net/Uri;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILandroid_net_Uri_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILandroid_net_Uri_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.ContentUpdate']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()I", "")]
			public int A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_a);
			}

			static IntPtr id_a_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.ContentUpdate']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "")]
			public override sealed void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
			{
				if (id_a_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.StructuralUpdate']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$StructuralUpdate", DoNotGenerateAcw=true)]
		protected internal abstract partial class StructuralUpdate : global::Com.Layer.Sdk.Internal.Query.QueryController.Update {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$StructuralUpdate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StructuralUpdate); }
			}

			protected StructuralUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.StructuralUpdate']/constructor[@name='QueryController.StructuralUpdate' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected StructuralUpdate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (StructuralUpdate)) {
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

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$StructuralUpdate", DoNotGenerateAcw=true)]
		internal partial class StructuralUpdateInvoker : StructuralUpdate {

			public StructuralUpdateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (StructuralUpdateInvoker); }
			}

			static IntPtr id_a_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.Update']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "GetA_Ljava_util_List_Handler")]
			public override void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
			{
				if (id_a_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.Update']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$Update", DoNotGenerateAcw=true)]
		protected internal abstract partial class Update : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$Update", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Update); }
			}

			protected Update (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.Update']/constructor[@name='QueryController.Update' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected Update () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Update)) {
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

			static Delegate cb_a_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_util_List_Handler ()
			{
				if (cb_a_Ljava_util_List_ == null)
					cb_a_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_List_);
				return cb_a_Ljava_util_List_;
			}

			static void n_A_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Layer.Sdk.Internal.Query.QueryController.Update __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<Android.Net.Uri> p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.Update']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "GetA_Ljava_util_List_Handler")]
			public abstract void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0);

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$Update", DoNotGenerateAcw=true)]
		internal partial class UpdateInvoker : Update {

			public UpdateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateInvoker); }
			}

			static IntPtr id_a_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.Update']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "GetA_Ljava_util_List_Handler")]
			public override void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
			{
				if (id_a_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateInsert']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$UpdateInsert", DoNotGenerateAcw=true)]
		protected internal partial class UpdateInsert : global::Com.Layer.Sdk.Internal.Query.QueryController.StructuralUpdate {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$UpdateInsert", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateInsert); }
			}

			protected UpdateInsert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILandroid_net_Uri_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateInsert']/constructor[@name='QueryController.UpdateInsert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.net.Uri']]"
			[Register (".ctor", "(ILandroid/net/Uri;)V", "")]
			protected UpdateInsert (int p0, global::Android.Net.Uri p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (UpdateInsert)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILandroid/net/Uri;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILandroid/net/Uri;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_ILandroid_net_Uri_ == IntPtr.Zero)
					id_ctor_ILandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/net/Uri;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILandroid_net_Uri_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILandroid_net_Uri_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateInsert']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()I", "")]
			public int A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_a);
			}

			static IntPtr id_a_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateInsert']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "")]
			public override sealed void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
			{
				if (id_a_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateMove']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$UpdateMove", DoNotGenerateAcw=true)]
		protected internal partial class UpdateMove : global::Com.Layer.Sdk.Internal.Query.QueryController.StructuralUpdate {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$UpdateMove", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateMove); }
			}

			protected UpdateMove (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateMove']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "")]
			public override sealed void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
			{
				if (id_a_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateRemove']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryController$UpdateRemove", DoNotGenerateAcw=true)]
		protected internal partial class UpdateRemove : global::Com.Layer.Sdk.Internal.Query.QueryController.StructuralUpdate {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController$UpdateRemove", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateRemove); }
			}

			protected UpdateRemove (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILandroid_net_Uri_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateRemove']/constructor[@name='QueryController.UpdateRemove' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.net.Uri']]"
			[Register (".ctor", "(ILandroid/net/Uri;)V", "")]
			protected UpdateRemove (int p0, global::Android.Net.Uri p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (UpdateRemove)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILandroid/net/Uri;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILandroid/net/Uri;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_ILandroid_net_Uri_ == IntPtr.Zero)
					id_ctor_ILandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/net/Uri;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILandroid_net_Uri_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILandroid_net_Uri_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateRemove']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()I", "")]
			public int A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_a);
			}

			static IntPtr id_a_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController.UpdateRemove']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("a", "(Ljava/util/List;)V", "")]
			public override sealed void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0)
			{
				if (id_a_Ljava_util_List_ == IntPtr.Zero)
					id_a_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueryController); }
		}

		protected QueryController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_query_Query_Ljava_util_Set_Lcom_layer_sdk_query_RecyclerViewController_Callback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/constructor[@name='QueryController' and count(parameter)=4 and parameter[1][@type='com.layer.sdk.LayerClient'] and parameter[2][@type='com.layer.sdk.query.Query'] and parameter[3][@type='java.util.Set'] and parameter[4][@type='com.layer.sdk.query.RecyclerViewController.Callback']]"
		[Register (".ctor", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/query/Query;Ljava/util/Set;Lcom/layer/sdk/query/RecyclerViewController$Callback;)V", "")]
		public QueryController (global::Com.Layer.Sdk.LayerClient p0, global::Com.Layer.Sdk.Query.Query p1, global::System.Collections.Generic.ICollection<string> p2, global::Com.Layer.Sdk.Query.RecyclerViewController.ICallback p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);;
			if (GetType () != typeof (QueryController)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/query/Query;Ljava/util/Set;Lcom/layer/sdk/query/RecyclerViewController$Callback;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/query/Query;Ljava/util/Set;Lcom/layer/sdk/query/RecyclerViewController$Callback;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_query_Query_Ljava_util_Set_Lcom_layer_sdk_query_RecyclerViewController_Callback_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_query_Query_Ljava_util_Set_Lcom_layer_sdk_query_RecyclerViewController_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/LayerClient;Lcom/layer/sdk/query/Query;Ljava/util/Set;Lcom/layer/sdk/query/RecyclerViewController$Callback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_query_Query_Ljava_util_Set_Lcom_layer_sdk_query_RecyclerViewController_Callback_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_LayerClient_Lcom_layer_sdk_query_Query_Ljava_util_Set_Lcom_layer_sdk_query_RecyclerViewController_Callback_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Layer.Sdk.Internal.Query.QueryController __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemCount);
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public override global::Java.Lang.Integer ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()Ljava/lang/Integer;", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()Ljava/lang/Integer;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getItemCount), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_a_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("a", "(Ljava/lang/Iterable;)Ljava/util/Map;", "")]
		protected static global::System.Collections.Generic.IDictionary<global::Android.Net.Uri, global::Java.Lang.Integer> A (global::Java.Lang.IIterable p0)
		{
			if (id_a_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_a_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Iterable;)Ljava/util/Map;");
			global::System.Collections.Generic.IDictionary<global::Android.Net.Uri, global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaDictionary<global::Android.Net.Uri, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;Ljava/util/List;)V", "")]
		protected static void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update> p1)
		{
			if (id_a_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_util_List_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Ljava_util_List_Ljava_util_Map_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.List']]"
		[Register ("a", "(Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "")]
		protected static void A (global::System.Collections.Generic.IList<global::Android.Net.Uri> p0, global::System.Collections.Generic.IDictionary<global::Android.Net.Uri, global::Java.Lang.Integer> p1, global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update> p2)
		{
			if (id_a_Ljava_util_List_Ljava_util_Map_Ljava_util_List_ == IntPtr.Zero)
				id_a_Ljava_util_List_Ljava_util_Map_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Android.Net.Uri, global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update>.ToLocalJniHandle (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_util_List_Ljava_util_Map_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_b_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.util.List']]"
		[Register ("b", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;", "")]
		protected static global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update> B (global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Query.IQueryable> p0, global::System.Collections.Generic.IList<global::Android.Net.Uri> p1)
		{
			if (id_b_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_b_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Query.IQueryable>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (p1);
			global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Internal.Query.QueryController.Update>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Ljava_util_List_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
			global::Com.Layer.Sdk.Internal.Query.QueryController __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public override void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_execute);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
		}

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
			global::Com.Layer.Sdk.Internal.Query.QueryController __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/layer/sdk/query/Queryable;", "GetGetItem_IHandler")]
		public override global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/layer/sdk/query/Queryable;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Lcom/layer/sdk/query/Queryable;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_;
#pragma warning disable 0169
		static Delegate GetOnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_Handler ()
		{
			if (cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ == null)
				cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_);
			return cb_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_;
		}

		static void n_OnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Query.QueryController __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Changes.LayerChangeEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Changes.LayerChangeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEventAsync (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryController']/method[@name='onEventAsync' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.changes.LayerChangeEvent']]"
		[Register ("onEventAsync", "(Lcom/layer/sdk/changes/LayerChangeEvent;)V", "GetOnEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_Handler")]
		public virtual void OnEventAsync (global::Com.Layer.Sdk.Changes.LayerChangeEvent p0)
		{
			if (id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ == IntPtr.Zero)
				id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_ = JNIEnv.GetMethodID (class_ref, "onEventAsync", "(Lcom/layer/sdk/changes/LayerChangeEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onEventAsync_Lcom_layer_sdk_changes_LayerChangeEvent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onEventAsync", "(Lcom/layer/sdk/changes/LayerChangeEvent;)V"), new JValue (p0));
		}

	}
}
