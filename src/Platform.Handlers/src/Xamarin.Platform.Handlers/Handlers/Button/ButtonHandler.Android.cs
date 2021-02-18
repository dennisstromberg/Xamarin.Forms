﻿using AndroidX.AppCompat.Widget;
using AView = Android.Views.View;

namespace Xamarin.Platform.Handlers
{
	public partial class ButtonHandler : AbstractViewHandler<IButton, AppCompatButton>
	{
		ButtonClickListener ClickListener { get; } = new ButtonClickListener();
		ButtonTouchListener TouchListener { get; } = new ButtonTouchListener();

		protected override AppCompatButton CreateNativeView()
		{
			AppCompatButton nativeButton = new AppCompatButton(Context)
			{
				SoundEffectsEnabled = false
			};

			return nativeButton;
		}

		protected override void ConnectHandler(AppCompatButton nativeView)
		{
			ClickListener.Handler = this;
			nativeView.SetOnClickListener(ClickListener);

			TouchListener.Handler = this;
			nativeView.SetOnTouchListener(TouchListener);

			base.ConnectHandler(nativeView);
		}

		protected override void DisconnectHandler(AppCompatButton nativeView)
		{
			ClickListener.Handler = null;
			nativeView.SetOnClickListener(null);

			TouchListener.Handler = null;
			nativeView.SetOnTouchListener(null);

			base.DisconnectHandler(nativeView);
		}

		public static void MapText(ButtonHandler handler, IButton button)
		{
			ViewHandler.CheckParameters(handler, button);

			handler.TypedNativeView?.UpdateText(button);
		}

		public static void MapTextColor(ButtonHandler handler, IButton button)
		{
			ViewHandler.CheckParameters(handler, button);

			handler.TypedNativeView?.UpdateTextColor(button);
		}

		public class ButtonClickListener : Java.Lang.Object, AView.IOnClickListener
		{
			public ButtonHandler? Handler { get; set; }

			public void OnClick(AView? v)
			{
				ButtonManager.OnClick(Handler?.VirtualView, v);
			}
		}

		public class ButtonTouchListener : Java.Lang.Object, AView.IOnTouchListener
		{
			public ButtonHandler? Handler { get; set; }

			public bool OnTouch(AView? v, global::Android.Views.MotionEvent? e)
			{
				ButtonManager.OnTouch(Handler?.VirtualView, v, e);
				return true;
			}
		}
	}
}