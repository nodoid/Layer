using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Syncrecon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/SyncRecon", DoNotGenerateAcw=true)]
	public partial class SyncRecon : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/SyncRecon$Contract", DoNotGenerateAcw=true)]
		public partial class Contract : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/SyncRecon$Contract", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Contract); }
			}

			protected Contract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.messaging.ChangeableTransaction']]"
			[Register ("a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;)V", "")]
			public void A (global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction p0)
			{
				if (id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/messaging/ChangeableTransaction;)V");
				JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_messaging_ChangeableTransaction_, new JValue (p0));
			}

			static IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_CancelCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.syncrecon.CancelCallback']]"
			[Register ("a", "(Lcom/layer/sdk/internal/syncrecon/CancelCallback;)V", "")]
			protected void A (global::Com.Layer.Sdk.Internal.Syncrecon.ICancelCallback p0)
			{
				if (id_a_Lcom_layer_sdk_internal_syncrecon_CancelCallback_ == IntPtr.Zero)
					id_a_Lcom_layer_sdk_internal_syncrecon_CancelCallback_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/CancelCallback;)V");
				JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_syncrecon_CancelCallback_, new JValue (p0));
			}

			static IntPtr id_d;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()Lcom/layer/sdk/internal/syncrecon/Reindexer$Persistence;", "")]
			public global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence D ()
			{
				if (id_d == IntPtr.Zero)
					id_d = JNIEnv.GetMethodID (class_ref, "d", "()Lcom/layer/sdk/internal/syncrecon/Reindexer$Persistence;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.Reindexer.IPersistence> (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_e;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='e' and count(parameter)=0]"
			[Register ("e", "()I", "")]
			public int E ()
			{
				if (id_e == IntPtr.Zero)
					id_e = JNIEnv.GetMethodID (class_ref, "e", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_e);
			}

			static IntPtr id_f;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='f' and count(parameter)=0]"
			[Register ("f", "()Ljava/lang/String;", "")]
			public string F ()
			{
				if (id_f == IntPtr.Zero)
					id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_h;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='h' and count(parameter)=0]"
			[Register ("h", "()Lcom/layer/sdk/internal/persistence/SyncPersistence;", "")]
			public global::Com.Layer.Sdk.Internal.Persistence.SyncPersistence H ()
			{
				if (id_h == IntPtr.Zero)
					id_h = JNIEnv.GetMethodID (class_ref, "h", "()Lcom/layer/sdk/internal/persistence/SyncPersistence;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.SyncPersistence> (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_i;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='i' and count(parameter)=0]"
			[Register ("i", "()Lcom/layer/sdk/internal/messaging/ChangeableContext;", "")]
			public global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext I ()
			{
				if (id_i == IntPtr.Zero)
					id_i = JNIEnv.GetMethodID (class_ref, "i", "()Lcom/layer/sdk/internal/messaging/ChangeableContext;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.IChangeableContext> (JNIEnv.CallObjectMethod  (Handle, id_i), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_j;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='j' and count(parameter)=0]"
			[Register ("j", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;", "")]
			public global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache J ()
			{
				if (id_j == IntPtr.Zero)
					id_j = JNIEnv.GetMethodID (class_ref, "j", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache> (JNIEnv.CallObjectMethod  (Handle, id_j), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_k;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='k' and count(parameter)=0]"
			[Register ("k", "()Lcom/layer/sdk/internal/messaging/ChangeableTransaction;", "")]
			public global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction K ()
			{
				if (id_k == IntPtr.Zero)
					id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lcom/layer/sdk/internal/messaging/ChangeableTransaction;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableTransaction> (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_l;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='l' and count(parameter)=0]"
			[Register ("l", "()Lcom/layer/sdk/internal/alerters/SyncAlerter;", "")]
			public global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter L ()
			{
				if (id_l == IntPtr.Zero)
					id_l = JNIEnv.GetMethodID (class_ref, "l", "()Lcom/layer/sdk/internal/alerters/SyncAlerter;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Alerters.ISyncAlerter> (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_m;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='m' and count(parameter)=0]"
			[Register ("m", "()Lcom/layer/sdk/internal/syncrecon/SyncRecon$SyncReconCallback;", "")]
			public global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.ISyncReconCallback M ()
			{
				if (id_m == IntPtr.Zero)
					id_m = JNIEnv.GetMethodID (class_ref, "m", "()Lcom/layer/sdk/internal/syncrecon/SyncRecon$SyncReconCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.ISyncReconCallback> (JNIEnv.CallObjectMethod  (Handle, id_m), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_o;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='o' and count(parameter)=0]"
			[Register ("o", "()Ljava/util/Set;", "")]
			public global::System.Collections.Generic.ICollection<string> O ()
			{
				if (id_o == IntPtr.Zero)
					id_o = JNIEnv.GetMethodID (class_ref, "o", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_o), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_p;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='p' and count(parameter)=0]"
			[Register ("p", "()Ljava/util/concurrent/ConcurrentLinkedQueue;", "")]
			public global::Java.Util.Concurrent.ConcurrentLinkedQueue P ()
			{
				if (id_p == IntPtr.Zero)
					id_p = JNIEnv.GetMethodID (class_ref, "p", "()Ljava/util/concurrent/ConcurrentLinkedQueue;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ConcurrentLinkedQueue> (JNIEnv.CallObjectMethod  (Handle, id_p), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_q;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='q' and count(parameter)=0]"
			[Register ("q", "()Z", "")]
			public bool Q ()
			{
				if (id_q == IntPtr.Zero)
					id_q = JNIEnv.GetMethodID (class_ref, "q", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_q);
			}

			static IntPtr id_r;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Contract']/method[@name='r' and count(parameter)=0]"
			[Register ("r", "()V", "")]
			public void R ()
			{
				if (id_r == IntPtr.Zero)
					id_r = JNIEnv.GetMethodID (class_ref, "r", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_r);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Results']"
		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/SyncRecon$Results", DoNotGenerateAcw=true)]
		public partial class Results : global::Java.Lang.Object, global::Com.Layer.Sdk.Internal.Syncrecon.Recon.InboundRecon.IResults, global::Com.Layer.Sdk.Internal.Syncrecon.Sync.SyncMaster.IResults {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/SyncRecon$Results", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Results); }
			}

			protected Results (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Results']/constructor[@name='SyncRecon.Results' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Results () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Results)) {
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

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Results']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Ljava/util/concurrent/atomic/AtomicInteger;", "")]
			public global::Java.Util.Concurrent.Atomic.AtomicInteger A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/util/concurrent/atomic/AtomicInteger;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_b;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Results']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Ljava/util/concurrent/atomic/AtomicInteger;", "")]
			public global::Java.Util.Concurrent.Atomic.AtomicInteger B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/util/concurrent/atomic/AtomicInteger;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_c;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon.Results']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Ljava/util/concurrent/atomic/AtomicInteger;", "")]
			public global::Java.Util.Concurrent.Atomic.AtomicInteger C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/util/concurrent/atomic/AtomicInteger;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/interface[@name='SyncRecon.SyncReconCallback']"
		[Register ("com/layer/sdk/internal/syncrecon/SyncRecon$SyncReconCallback", "", "Com.Layer.Sdk.Internal.Syncrecon.SyncRecon/ISyncReconCallbackInvoker")]
		public partial interface ISyncReconCallback : IJavaObject {

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/syncrecon/SyncRecon$SyncReconCallback", DoNotGenerateAcw=true)]
		internal class ISyncReconCallbackInvoker : global::Java.Lang.Object, ISyncReconCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/SyncRecon$SyncReconCallback");
			IntPtr class_ref;

			public static ISyncReconCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISyncReconCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.syncrecon.SyncRecon.SyncReconCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISyncReconCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ISyncReconCallbackInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/syncrecon/SyncRecon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncRecon); }
		}

		protected SyncRecon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/constructor[@name='SyncRecon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SyncRecon () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SyncRecon)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Contract_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='a' and count(parameter)=4 and parameter[1][@type='com.layer.sdk.internal.syncrecon.SyncRecon.Contract'] and parameter[2][@type='com.layer.sdk.internal.syncrecon.SyncRecon.Results'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("a", "(Lcom/layer/sdk/internal/syncrecon/SyncRecon$Contract;Lcom/layer/sdk/internal/syncrecon/SyncRecon$Results;ZZ)V", "")]
		public void A (global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.Contract p0, global::Com.Layer.Sdk.Internal.Syncrecon.SyncRecon.Results p1, bool p2, bool p3)
		{
			if (id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Contract_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ZZ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Contract_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ZZ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/syncrecon/SyncRecon$Contract;Lcom/layer/sdk/internal/syncrecon/SyncRecon$Results;ZZ)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Contract_Lcom_layer_sdk_internal_syncrecon_SyncRecon_Results_ZZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_a_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("a", "(Ljava/lang/Runnable;)V", "")]
		public void A (global::Java.Lang.IRunnable p0)
		{
			if (id_a_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_a_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Runnable;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Runnable_, new JValue (p0));
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		public void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_d);
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		public void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_e);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.syncrecon']/class[@name='SyncRecon']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "")]
		public bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_f);
		}

	}
}
