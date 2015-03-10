using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Layer.Sdk.Internal.Query
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='MessageQueryRepository']"
    [global::Android.Runtime.Register("com/layer/sdk/internal/query/MessageQueryRepository", DoNotGenerateAcw = true)]
    public partial class MessageQueryRepository : global::Com.Layer.Sdk.Internal.Query.QueryRepository
    {

        internal static new IntPtr java_class_handle;

        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/layer/sdk/internal/query/MessageQueryRepository", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(MessageQueryRepository); }
        }

        protected MessageQueryRepository(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        static IntPtr id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='MessageQueryRepository']/constructor[@name='MessageQueryRepository' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.internal.query.QueryRepository.Context']]"
        [Register(".ctor", "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V", "")]
        public MessageQueryRepository(global::Com.Layer.Sdk.Internal.Query.QueryRepository.IContext p0)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (Handle != IntPtr.Zero)
                return;

            if (GetType() != typeof(MessageQueryRepository))
            {
                SetHandle(
                    global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V", new JValue(p0)),
                    JniHandleOwnership.TransferLocalRef);
                global::Android.Runtime.JNIEnv.FinishCreateInstance(Handle, "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V", new JValue(p0));
                return;
            }

            if (id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_ == IntPtr.Zero)
                id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Lcom/layer/sdk/internal/query/QueryRepository$Context;)V");
            SetHandle(
                global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_, new JValue(p0)),
                JniHandleOwnership.TransferLocalRef);
            JNIEnv.FinishCreateInstance(Handle, class_ref, id_ctor_Lcom_layer_sdk_internal_query_QueryRepository_Context_, new JValue(p0));
        }

        static IntPtr id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='MessageQueryRepository']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.layer.sdk.internal.query.SQL.Statement.Builder'] and parameter[2][@type='com.layer.sdk.query.Predicate'] and parameter[3][@type='com.layer.sdk.internal.query.SQL.Conjunction']]"
        [Register("a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V", "")]
        protected override sealed void A(global::Com.Layer.Sdk.Internal.Query.SQL.Statement.Builder p0, global::Com.Layer.Sdk.Query.Predicate p1, global::Com.Layer.Sdk.Internal.Query.SQL.Conjunction p2)
        {
            if (id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_ == IntPtr.Zero)
                id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_ = JNIEnv.GetMethodID(class_ref, "a", "(Lcom/layer/sdk/internal/query/SQL$Statement$Builder;Lcom/layer/sdk/query/Predicate;Lcom/layer/sdk/internal/query/SQL$Conjunction;)V");
            JNIEnv.CallVoidMethod(Handle, id_a_Lcom_layer_sdk_internal_query_SQL_Statement_Builder_Lcom_layer_sdk_query_Predicate_Lcom_layer_sdk_internal_query_SQL_Conjunction_, new JValue(p0), new JValue(p1), new JValue(p2));
        }

        static IntPtr id_a_Lcom_layer_sdk_query_Query_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='MessageQueryRepository']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
        [Register("a", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "")]
        public override sealed global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> A(global::Com.Layer.Sdk.Query.Query p0)
        {
            if (id_a_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
                id_a_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID(class_ref, "a", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;");
            global::System.Collections.Generic.IList<global::Com.Layer.Sdk.Messaging.Message> __ret = global::Android.Runtime.JavaList<global::Com.Layer.Sdk.Messaging.Message>.FromJniHandle(JNIEnv.CallObjectMethod(Handle, id_a_Lcom_layer_sdk_query_Query_, new JValue(p0)), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static IntPtr id_b_Lcom_layer_sdk_query_Query_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='MessageQueryRepository']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
        [Register("b", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;", "")]
        public override sealed global::System.Collections.Generic.IList<global::Android.Net.Uri> B(global::Com.Layer.Sdk.Query.Query p0)
        {
            if (id_b_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
                id_b_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID(class_ref, "b", "(Lcom/layer/sdk/query/Query;)Ljava/util/List;");
            global::System.Collections.Generic.IList<global::Android.Net.Uri> __ret = global::Android.Runtime.JavaList<global::Android.Net.Uri>.FromJniHandle(JNIEnv.CallObjectMethod(Handle, id_b_Lcom_layer_sdk_query_Query_, new JValue(p0)), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static IntPtr id_c_Lcom_layer_sdk_query_Query_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.layer.sdk.internal.query']/class[@name='MessageQueryRepository']/method[@name='c' and count(parameter)=1 and parameter[1][@type='com.layer.sdk.query.Query']]"
        [Register("c", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;", "")]
        public override sealed global::Java.Lang.Long C(global::Com.Layer.Sdk.Query.Query p0)
        {
            if (id_c_Lcom_layer_sdk_query_Query_ == IntPtr.Zero)
                id_c_Lcom_layer_sdk_query_Query_ = JNIEnv.GetMethodID(class_ref, "c", "(Lcom/layer/sdk/query/Query;)Ljava/lang/Long;");
            global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long>(JNIEnv.CallObjectMethod(Handle, id_c_Lcom_layer_sdk_query_Query_, new JValue(p0)), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

    }
}
