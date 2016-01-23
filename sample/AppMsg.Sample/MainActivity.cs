using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Msg = Sino.Droid.AppMsg.AppMsg;
using Android.Graphics;

namespace AppMsg.Sample
{
    [Activity(Label = "AppMsg.Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Msg appmsg;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.btnAlert).Click += (e, s) =>
            {
                Msg.MakeText(this, "Alert 测试", Msg.STYLE_ALERT).Show();
            };

            FindViewById<Button>(Resource.Id.btnConfirm).Click += (e, s) =>
            {
                Msg.MakeText(this, "Confirm 测试", Msg.STYLE_CONFIRM).Show();
            };

            FindViewById<Button>(Resource.Id.btnInfo).Click += (e, s) =>
            {
                Msg.MakeText(this, "Info 测试", Msg.STYLE_INFO).Show();
            };

            FindViewById<Button>(Resource.Id.btnOpen).Click += (e, s) =>
            {
                if (appmsg == null)
                {
                    appmsg = Msg.MakeText(this, "不会自动关闭的提示", new Sino.Droid.AppMsg.Style(Msg.LENGTH_STICKY, Color.White, Color.Yellow));
                }
                if (!appmsg.IsShowing)
                {
                    appmsg.Show();
                }
            };

            FindViewById<Button>(Resource.Id.btnClose).Click += (e, s) =>
            {
                if (appmsg != null)
                {
                    appmsg.Dismiss();
                }
            };
        }
    }
}

