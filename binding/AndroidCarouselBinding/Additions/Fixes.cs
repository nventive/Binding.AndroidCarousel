using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FR.Rolandl.Carousel
{
	public partial class Carousel
	{
		protected override Java.Lang.Object RawAdapter
		{
			get { return Adapter.JavaCast<Java.Lang.Object>(); }
			set { Adapter = value.JavaCast<global::Android.Widget.ISpinnerAdapter>(); }
		}
	}

	public partial class CarouselSpinner
	{
		protected override Java.Lang.Object RawAdapter
		{
			get { return Adapter.JavaCast<Java.Lang.Object>(); }
			set { Adapter = value.JavaCast<global::Android.Widget.ISpinnerAdapter>(); }
		}
	}

	public partial class CarouselSpinner
	{
		static Delegate cb_getAdapter;
#pragma warning disable 0169
		static Delegate GetGetAdapterHandler()
		{
			if (cb_getAdapter == null)
				cb_getAdapter = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetAdapter);
			return cb_getAdapter;
		}

		static IntPtr n_GetAdapter(IntPtr jnienv, IntPtr native__this)
		{
			global::FR.Rolandl.Carousel.CarouselSpinner __this = global::Java.Lang.Object.GetObject<global::FR.Rolandl.Carousel.CarouselSpinner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Adapter);
		}
#pragma warning restore 0169

		static Delegate cb_setAdapter_Landroid_widget_SpinnerAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Landroid_widget_SpinnerAdapter_Handler()
		{
			if (cb_setAdapter_Landroid_widget_SpinnerAdapter_ == null)
				cb_setAdapter_Landroid_widget_SpinnerAdapter_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetAdapter_Landroid_widget_SpinnerAdapter_);
			return cb_setAdapter_Landroid_widget_SpinnerAdapter_;
		}

		static void n_SetAdapter_Landroid_widget_SpinnerAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::FR.Rolandl.Carousel.CarouselSpinner __this = global::Java.Lang.Object.GetObject<global::FR.Rolandl.Carousel.CarouselSpinner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ISpinnerAdapter p0 = (global::Android.Widget.ISpinnerAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.ISpinnerAdapter>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Adapter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		static IntPtr id_setAdapter_Landroid_widget_SpinnerAdapter_;
		public unsafe global::Android.Widget.ISpinnerAdapter Adapter
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='fr.rolandl.carousel']/class[@name='CarouselSpinner']/method[@name='getAdapter' and count(parameter)=0]"
			[Register("getAdapter", "()Landroid/widget/SpinnerAdapter;", "GetGetAdapterHandler")]
			get
			{
				if (id_getAdapter == IntPtr.Zero)
					id_getAdapter = JNIEnv.GetMethodID(class_ref, "getAdapter", "()Landroid/widget/SpinnerAdapter;");
				try
				{

					if (GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ISpinnerAdapter>(JNIEnv.CallObjectMethod(Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ISpinnerAdapter>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getAdapter", "()Landroid/widget/SpinnerAdapter;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='fr.rolandl.carousel']/class[@name='CarouselSpinner']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.SpinnerAdapter']]"
			[Register("setAdapter", "(Landroid/widget/SpinnerAdapter;)V", "GetSetAdapter_Landroid_widget_SpinnerAdapter_Handler")]
			set
			{
				if (id_setAdapter_Landroid_widget_SpinnerAdapter_ == IntPtr.Zero)
					id_setAdapter_Landroid_widget_SpinnerAdapter_ = JNIEnv.GetMethodID(class_ref, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V");
				try
				{
					JValue* __args = stackalloc JValue[1];
					__args[0] = new JValue(value);

					if (GetType() == ThresholdType)
						JNIEnv.CallVoidMethod(Handle, id_setAdapter_Landroid_widget_SpinnerAdapter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setAdapter", "(Landroid/widget/SpinnerAdapter;)V"), __args);
				}
				finally
				{
				}
			}
		}
	}

}