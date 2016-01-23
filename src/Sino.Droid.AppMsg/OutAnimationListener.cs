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
using Android.Views.Animations;

namespace Sino.Droid.AppMsg
{
    public class OutAnimationListener : Java.Lang.Object, Animation.IAnimationListener
    {
        private AppMsg appMsg;

        public OutAnimationListener(AppMsg appMsg)
        {
            this.appMsg = appMsg;
        }

        public void OnAnimationEnd(Animation animation)
        {
            View view = appMsg.View;
            if (appMsg.Floating)
            {
                ViewGroup parent = view.Parent as ViewGroup;
                if (parent != null)
                {
                    parent.Post(() =>
                    {
                        parent.RemoveView(view);
                    });
                }
            }
            else
            {
                view.Visibility = ViewStates.Gone;
            }
        }

        public void OnAnimationRepeat(Animation animation)
        {

        }

        public void OnAnimationStart(Animation animation)
        {

        }
    }
}