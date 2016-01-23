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
using Android.Graphics;

namespace Sino.Droid.AppMsg
{
    public class Style
    {
        private int _duration;
        private Color _backColor;
        private Color _textColor;

        public Style(int duration, Color textColor, Color backColor)
        {
            this._duration = duration;
            this._backColor = backColor;
            this._textColor = textColor;
        }

        public int Duration
        {
            get
            {
                return this._duration;
            }
        }

        public Color BackgroundColor
        {
            get
            {
                return this._backColor;
            }
        }

        public Color TextColor
        {
            get
            {
                return this._textColor;
            }
        }

        public override int GetHashCode()
        {
            int hash = _duration.GetHashCode();
            hash ^= _backColor.GetHashCode();
            hash ^= _textColor.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj is Style)
            {
                Style style = obj as Style;
                return style.Duration == this._duration && style.BackgroundColor == this.BackgroundColor;
            }
            return false;
        }
    }
}