using System;
using System.Diagnostics;
using Android.Util;
using ApiChecker.Droid.Effects;
using ApiChecker.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("ApiChecker")]
[assembly: ExportEffect(typeof(AndroidTransparentSelectableEffect), nameof(TransparentSelectableEffect))]
namespace ApiChecker.Droid.Effects
{
    public class AndroidTransparentSelectableEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                TypedValue value = new TypedValue();
                Android.App.Application.Context.Theme.ResolveAttribute(Android.Resource.Attribute.SelectableItemBackground, value, true);
                Control.SetBackgroundResource(value.ResourceId);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Cannot set property on attached control. Error: " + ex.Message);
            }
        }

        protected override void OnDetached()
        {

        }
    }
}
