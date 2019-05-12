using System;
using ApiChecker.Effects;
using Xamarin.Forms;

namespace ApiChecker.Controls
{
    public class AnimatedButton : Button
    {
        public AnimatedButton() : base()
        {
            const int _animationTime = 100;
            Clicked += async (sender, e) =>
            {
                var btn = (AnimatedButton)sender;
                await btn.ScaleTo(1.2, _animationTime);
                await btn.ScaleTo(1, _animationTime);
            };
            Effects.Add(new TransparentSelectableEffect());
        }
    }
}
