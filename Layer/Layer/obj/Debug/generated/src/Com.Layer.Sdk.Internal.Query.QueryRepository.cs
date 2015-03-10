using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Query {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']"
	[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryRepository", DoNotGenerateAcw=true)]
	public abstract partial class QueryRepository : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.internal.query']/interface[@name='QueryRepository.Context']"
		[Register ("com/layer/sdk/internal/query/QueryRepository$Context", "", "Com.Layer.Sdk.Internal.Query.QueryRepository/IContextInvoker")]
		public partial interface IContext : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/interface[@name='QueryRepository.Context']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Lcom/layer/sdk/internal/persistence/SyncPersistence;", "GetAHandler:Com.Layer.Sdk.Internal.Query.QueryRepository/IContextInvoker, Layer")]
			global::Com.Layer.Sdk.Internal.Persistence.SyncPersistence A ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/interface[@name='QueryRepository.Context']/method[@name='b' and count(parameter)=0]"
			[Register ("b", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;", "GetBHandler:Com.Layer.Sdk.Internal.Query.QueryRepository/IContextInvoker, Layer")]
			global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache B ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/interface[@name='QueryRepository.Context']/method[@name='c' and count(parameter)=0]"
			[Register ("c", "()Ljava/lang/String;", "GetCHandler:Com.Layer.Sdk.Internal.Query.QueryRepository/IContextInvoker, Layer")]
			string C ();

		}

		[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryRepository$Context", DoNotGenerateAcw=true)]
		internal class IContextInvoker : global::Java.Lang.Object, IContext {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryRepository$Context");
			IntPtr class_ref;

			public static IContext GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IContext> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.internal.query.QueryRepository.Context"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IContextInvoker); }
			}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.A ());
			}
#pragma warning restore 0169

			IntPtr id_a;
			public global::Com.Layer.Sdk.Internal.Persistence.SyncPersistence A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/layer/sdk/internal/persistence/SyncPersistence;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Persistence.SyncPersistence> (JNIEnv.CallObjectMethod (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_b;
#pragma warning disable 0169
			static Delegate GetBHandler ()
			{
				if (cb_b == null)
					cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
				return cb_b;
			}

			static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.B ());
			}
#pragma warning restore 0169

			IntPtr id_b;
			public global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache B ()
			{
				if (id_b == IntPtr.Zero)
					id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/layer/sdk/internal/messaging/ChangeableCache;");
				return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Messaging.ChangeableCache> (JNIEnv.CallObjectMethod (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_c;
#pragma warning disable 0169
			static Delegate GetCHandler ()
			{
				if (cb_c == null)
					cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
				return cb_c;
			}

			static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.C ());
			}
#pragma warning restore 0169

			IntPtr id_c;
			public string C ()
			{
				if (id_c == IntPtr.Zero)
					id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/layer/sdk/internal/query/QueryRepository", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueryRepository); }
		}

		protected QueryRepository (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/constructor[@name='QueryRepository' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.query.QueryRepository.Context']]"
		[Register (".ctor", "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V", "")]
		public QueryRepository (global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (QueryRepository)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_ == IntPtr.Zero)
				id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_, new JValue (p0));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/layer/sdk/internal/query/QueryRepository$Context;", "")]
		protected global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/layer/sdk/internal/query/QueryRepository$Context;");
			return global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext> (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_internal_query_SQL_Statement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.query.SQL.Statement.Builder'] and parameter[2][@type='com.layer.sdk.internal.query.SQL.Statement']]"
		[Register ("a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/internal/query/SQL$Statement;)V", "")]
		protected static void A (global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder p0, global::Com.Layer.Sdk.Internal.Query.SQL.Statement p1)
		{
			if (id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_internal_query_SQL_Statement_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_internal_query_SQL_Statement_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/internal/query/SQL$Statement;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_internal_query_SQL_Statement_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_CompoundPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.internal.query.SQL.Statement.Builder'] and parameter[2][@type='com.layer.sdk.query.CompoundPredicate']]"
		[Register ("a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/query/CompoundPredicate;)V", "")]
		protected void A (global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder p0, global::Com.Layer.Sdk.Query.CompoundPredicate p1)
		{
			if (id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_CompoundPredicate_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_CompoundPredicate_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/query/CompoundPredicate;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_CompoundPredicate_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_ == null)
				cb_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_);
			return cb_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_;
		}

		static void n_A_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Layer.Sdk.Internal.Query.QueryRepository __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Predicate p1 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Predicate> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction p2 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.query.SQL.Statement.Builder'] and parameter[2][@type='com.layer.sdk.query.Predicate'] and parameter[3][@type='com.layer.sdk.internal.query.SQL.Conjunction']]"
		[Register ("a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V", "GetA_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_Handler")]
		protected abstract void A (global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder p0, global::Com.Layer.Sdk.Query.Predicate p1, global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction p2);

		static IntPtr id_a_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.Predicate'] and parameter[2][@type='com.layer.sdk.query.Queryable.Property']]"
		[Register ("a", "(Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/query/Queryable$Property;)Ljava/lang/IllegalArgumentException;", "")]
		protected static global::Java.Lang.IllegalArgumentException A (global::Com.Layer.Sdk.Query.Predicate p0, global::Com.Layer.Sdk.Query.IQueryableProperty p1)
		{
			if (id_a_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/query/Queryable$Property;)Ljava/lang/IllegalArgumentException;");
			global::Java.Lang.IllegalArgumentException __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IllegalArgumentException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_a_Lcom_layer_sdk_query_Query_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_layer_sdk_query_Query_Handler ()
		{
			if (cb_a_Lcom_layer_sdk_query_Query_ == null)
				cb_a_Lcom_layer_sdk_query_Query_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lcom_layer_sdk_query_Query_);
			return cb_a_Lcom_layer_sdk_query_Query_;
		}

		static IntPtr n_A_Lcom_layer_sdk_query_Query_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Query.QueryRepository __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("a", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetA_Lcom_layer_sdk_query_Query_Handler")]
		public abstract global::System.Collections.IList A (global::Com.Layer.Sdk.Query.Query p0);

		static IntPtr id_a_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.Query'] and parameter[2][@type='com.layer.sdk.query.Query.ResultType']]"
		[Register ("a", "(Lcom/layer/sdk/query/Query;Lcom/layer/sdk/query/Query$ResultType;)Ljava/util/List;", "")]
		public global::System.Collections.IList A (global::Com.Layer.Sdk.Query.Query p0, global::Com.Layer.Sdk.Query.Query.ResultType p1)
		{
			if (id_a_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/query/Query;Lcom/layer/sdk/query/Query$ResultType;)Ljava/util/List;");
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_query_Query_Lcom_layer_sdk_query_Query_ResultType_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='b' and count(parameter)=2 and parameter[1][@type='com.layer.sdk.query.Predicate'] and parameter[2][@type='com.layer.sdk.query.Queryable.Property']]"
		[Register ("b", "(Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/query/Queryable$Property;)V", "")]
		protected static void B (global::Com.Layer.Sdk.Query.Predicate p0, global::Com.Layer.Sdk.Query.IQueryableProperty p1)
		{
			if (id_b_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/query/Queryable$Property;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_query_Queryable_Property_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_b_Lcom_layer_sdk_query_Query_;
#pragma warning disable 0169
		static Delegate GetB_Lcom_layer_sdk_query_Query_Handler ()
		{
			if (cb_b_Lcom_layer_sdk_query_Query_ == null)
				cb_b_Lcom_layer_sdk_query_Query_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Lcom_layer_sdk_query_Query_);
			return cb_b_Lcom_layer_sdk_query_Query_;
		}

		static IntPtr n_B_Lcom_layer_sdk_query_Query_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Query.QueryRepository __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.ToLocalJniHandle (__this.B (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("b", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetB_Lcom_layer_sdk_query_Query_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Android.Net.Uri> B (global::Com.Layer.Sdk.Query.Query p0);

		static Delegate cb_c_Lcom_layer_sdk_query_Query_;
#pragma warning disable 0169
		static Delegate GetC_Lcom_layer_sdk_query_Query_Handler ()
		{
			if (cb_c_Lcom_layer_sdk_query_Query_ == null)
				cb_c_Lcom_layer_sdk_query_Query_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_C_Lcom_layer_sdk_query_Query_);
			return cb_c_Lcom_layer_sdk_query_Query_;
		}

		static IntPtr n_C_Lcom_layer_sdk_query_Query_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Layer.Sdk.Internal.Query.QueryRepository __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Internal.Query.QueryRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Layer.Sdk.Query.Query p0 = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.Query> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.C (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='c' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("c", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;", "GetC_Lcom_layer_sdk_query_Query_Handler")]
		public abstract global::Java.Lang.Long C (global::Com.Layer.Sdk.Query.Query p0);

	}

	[global::Android.Runtime.Register ("com/layer/sdk/internal/query/QueryRepository", DoNotGenerateAcw=true)]
	internal partial class QueryRepositoryInvoker : QueryRepository {

		public QueryRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueryRepositoryInvoker); }
		}

		static IntPtr id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.query.SQL.Statement.Builder'] and parameter[2][@type='com.layer.sdk.query.Predicate'] and parameter[3][@type='com.layer.sdk.internal.query.SQL.Conjunction']]"
		[Register ("a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V", "GetA_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_Handler")]
		protected override void A (global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder p0, global::Com.Layer.Sdk.Query.Predicate p1, global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction p2)
		{
			if (id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_a_Lcom_layer_sdk_query_Query_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("a", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetA_Lcom_layer_sdk_query_Query_Handler")]
		public override global::System.Collections.IList A (global::Com.Layer.Sdk.Query.Query p0)
		{
			if (id_a_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
				id_a_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;");
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_a_Lcom_layer_sdk_query_Query_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_b_Lcom_layer_sdk_query_Query_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("b", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "GetB_Lcom_layer_sdk_query_Query_Handler")]
		public override global::System.Collections.Generic.IList<global::Android.Net.Uri> B (global::Com.Layer.Sdk.Query.Query p0)
		{
			if (id_b_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
				id_b_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_b_Lcom_layer_sdk_query_Query_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c_Lcom_layer_sdk_query_Query_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='QueryRepository']/method[@name='c' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
		[Register ("c", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;", "GetC_Lcom_layer_sdk_query_Query_Handler")]
		public override global::Java.Lang.Long C (global::Com.Layer.Sdk.Query.Query p0)
		{
			if (id_c_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
				id_c_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID (class_ref, "c", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;");
			global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_c_Lcom_layer_sdk_query_Query_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
