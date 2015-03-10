using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Query {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable.Property']"
	[Register ("com/layer/sdk/query/Queryable$Property", "", "Com.Layer.Sdk.Query.IQueryablePropertyInvoker")]
	public partial interface IQueryableProperty : IJavaObject {

		bool IsEqualityQueryable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable.Property']/method[@name='isEqualityQueryable' and count(parameter)=0]"
			[Register ("isEqualityQueryable", "()Z", "GetIsEqualityQueryableHandler:Com.Layer.Sdk.Query.IQueryablePropertyInvoker, Layer")] get;
		}

		bool IsInclusionQueryable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable.Property']/method[@name='isInclusionQueryable' and count(parameter)=0]"
			[Register ("isInclusionQueryable", "()Z", "GetIsInclusionQueryableHandler:Com.Layer.Sdk.Query.IQueryablePropertyInvoker, Layer")] get;
		}

		bool IsRelativeQueryable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable.Property']/method[@name='isRelativeQueryable' and count(parameter)=0]"
			[Register ("isRelativeQueryable", "()Z", "GetIsRelativeQueryableHandler:Com.Layer.Sdk.Query.IQueryablePropertyInvoker, Layer")] get;
		}

		bool IsSortable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable.Property']/method[@name='isSortable' and count(parameter)=0]"
			[Register ("isSortable", "()Z", "GetIsSortableHandler:Com.Layer.Sdk.Query.IQueryablePropertyInvoker, Layer")] get;
		}

	}

	[global::Android.Runtime.Register ("com/layer/sdk/query/Queryable$Property", DoNotGenerateAcw=true)]
	internal class IQueryablePropertyInvoker : global::Java.Lang.Object, IQueryableProperty {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/query/Queryable$Property");
		IntPtr class_ref;

		public static IQueryableProperty GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQueryableProperty> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.query.Queryable.Property"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQueryablePropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IQueryablePropertyInvoker); }
		}

		static Delegate cb_isEqualityQueryable;
#pragma warning disable 0169
		static Delegate GetIsEqualityQueryableHandler ()
		{
			if (cb_isEqualityQueryable == null)
				cb_isEqualityQueryable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEqualityQueryable);
			return cb_isEqualityQueryable;
		}

		static bool n_IsEqualityQueryable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.IQueryableProperty __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryableProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEqualityQueryable;
		}
#pragma warning restore 0169

		IntPtr id_isEqualityQueryable;
		public bool IsEqualityQueryable {
			get {
				if (id_isEqualityQueryable == IntPtr.Zero)
					id_isEqualityQueryable = JNIEnv.GetMethodID (class_ref, "isEqualityQueryable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEqualityQueryable);
			}
		}

		static Delegate cb_isInclusionQueryable;
#pragma warning disable 0169
		static Delegate GetIsInclusionQueryableHandler ()
		{
			if (cb_isInclusionQueryable == null)
				cb_isInclusionQueryable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInclusionQueryable);
			return cb_isInclusionQueryable;
		}

		static bool n_IsInclusionQueryable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.IQueryableProperty __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryableProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInclusionQueryable;
		}
#pragma warning restore 0169

		IntPtr id_isInclusionQueryable;
		public bool IsInclusionQueryable {
			get {
				if (id_isInclusionQueryable == IntPtr.Zero)
					id_isInclusionQueryable = JNIEnv.GetMethodID (class_ref, "isInclusionQueryable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isInclusionQueryable);
			}
		}

		static Delegate cb_isRelativeQueryable;
#pragma warning disable 0169
		static Delegate GetIsRelativeQueryableHandler ()
		{
			if (cb_isRelativeQueryable == null)
				cb_isRelativeQueryable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRelativeQueryable);
			return cb_isRelativeQueryable;
		}

		static bool n_IsRelativeQueryable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.IQueryableProperty __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryableProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRelativeQueryable;
		}
#pragma warning restore 0169

		IntPtr id_isRelativeQueryable;
		public bool IsRelativeQueryable {
			get {
				if (id_isRelativeQueryable == IntPtr.Zero)
					id_isRelativeQueryable = JNIEnv.GetMethodID (class_ref, "isRelativeQueryable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isRelativeQueryable);
			}
		}

		static Delegate cb_isSortable;
#pragma warning disable 0169
		static Delegate GetIsSortableHandler ()
		{
			if (cb_isSortable == null)
				cb_isSortable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSortable);
			return cb_isSortable;
		}

		static bool n_IsSortable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.IQueryableProperty __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryableProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSortable;
		}
#pragma warning restore 0169

		IntPtr id_isSortable;
		public bool IsSortable {
			get {
				if (id_isSortable == IntPtr.Zero)
					id_isSortable = JNIEnv.GetMethodID (class_ref, "isSortable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isSortable);
			}
		}

	}


	[Register ("com/layer/sdk/query/Queryable")]
	public abstract class Queryable {

		internal Queryable ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']/field[@name='BY_EQUALITY']"
		[Register ("BY_EQUALITY")]
		public const int ByEquality = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']/field[@name='BY_INCLUSION']"
		[Register ("BY_INCLUSION")]
		public const int ByInclusion = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']/field[@name='BY_RELATIVE']"
		[Register ("BY_RELATIVE")]
		public const int ByRelative = (int) 4;
	}

	[System.Obsolete ("Use the 'Queryable' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class QueryableConsts : Queryable {

		private QueryableConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']"
	[Register ("com/layer/sdk/query/Queryable", "", "Com.Layer.Sdk.Query.IQueryableInvoker")]
	public partial interface IQueryable : IJavaObject {

		global::Android.Net.Uri Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.query']/interface[@name='Queryable']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Landroid/net/Uri;", "GetGetIdHandler:Com.Layer.Sdk.Query.IQueryableInvoker, Layer")] get;
		}

	}

	[global::Android.Runtime.Register ("com/layer/sdk/query/Queryable", DoNotGenerateAcw=true)]
	internal class IQueryableInvoker : global::Java.Lang.Object, IQueryable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/layer/sdk/query/Queryable");
		IntPtr class_ref;

		public static IQueryable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQueryable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.layer.sdk.query.Queryable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQueryableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IQueryableInvoker); }
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Layer.Sdk.Query.IQueryable __this = global::Java.Lang.Object.GetObject<global::Com.Layer.Sdk.Query.IQueryable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public global::Android.Net.Uri Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
