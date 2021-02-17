﻿using UIKit;
using Xamarin.Forms;

namespace Xamarin.Platform
{
	public static class EntryExtensions
	{
		public static void UpdateText(this UITextField textField, IEntry entry)
		{
			textField.Text = entry.Text;
		}

		public static void UpdateTextColor(this UITextField textField, IEntry entry)
		{
			textField.UpdateTextColor(entry, null);
		}

		public static void UpdateTextColor(this UITextField textField, IEntry entry, UIColor? defaultTextColor)
		{
			if (entry.TextColor == Color.Default)
			{
				if (defaultTextColor != null)
					textField.TextColor = defaultTextColor;
			}
			else
				textField.TextColor = entry.TextColor.ToNative();
		}

		public static void UpdateFont(this UITextField textField, IEntry entry)
		{

		}

		public static void UpdateTextTransform(this UITextField textField, IEntry entry)
		{
			
		}

		public static void UpdateCharacterSpacing(this UITextField textField, IEntry entry)
		{
	
		}

		public static void UpdatePlaceholder(this UITextField textField, IEntry entry)
		{

		}

		public static void UpdatePlaceholderColor(this UITextField textField, IEntry entry)
		{

		}

		public static void UpdateMaxLength(this UITextField textField, IEntry entry)
		{

		}

		public static void UpdateIsReadOnly(this UITextField textField, IEntry entry)
		{

		}

		public static void UpdateKeyboard(this UITextField textField, IEntry entry)
		{
		
		}

		public static void UpdateIsSpellCheckEnabled(this UITextField textField, IEntry entry)
		{
	
		}

		public static void UpdateHorizontalTextAlignment(this UITextField textField, IEntry entry)
		{

		}

		public static void UpdateVerticalTextAlignment(this UITextField textField, IEntry entry)
		{
		
		}

		public static void UpdateIsPassword(this UITextField textField, IEntry entry)
		{
			if (entry.IsPassword && textField.IsFirstResponder)
			{
				textField.Enabled = false;
				textField.SecureTextEntry = true;
				textField.Enabled = entry.IsEnabled;
				textField.BecomeFirstResponder();
			}
			else
				textField.SecureTextEntry = entry.IsPassword;
		}

		public static void UpdateReturnType(this UITextField textField, IEntry entry)
		{
			
		}

		public static void UpdateCursorPosition(this UITextField textField, IEntry entry)
		{
		
		}

		public static void UpdateSelectionLength(this UITextField textField, IEntry entry)
		{
			
		}

		public static void UpdateIsTextPredictionEnabled(this UITextField textField, IEntry entry)
		{

		}

		public static void UpdateClearButtonVisibility(this UITextField textField, IEntry entry)
		{

		}
	}
}