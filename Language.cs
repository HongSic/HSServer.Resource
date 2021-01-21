using HS.Utils;
using System;
using System.Globalization;

namespace HSServer.Resource
{
    public class Language
    {
        public static LanguageManager FromLocale(string Locale = null)
        {
            string lngcode = string.IsNullOrWhiteSpace(Locale) ? CultureInfo.CurrentCulture.Name.ToLower() : Locale;
            if (lngcode.Equals("ko-kr")) return new LanguageManager(Resources.Language_ko_kr.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
            else return new LanguageManager(Resources.Language_en_us.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
