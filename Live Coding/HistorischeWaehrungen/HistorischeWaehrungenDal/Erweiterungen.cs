using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HistorischeWaehrungenDal
{
    public static class Erweiterungen
    {
        public static bool IsNumeric(this string text)
        {
            //return double.TryParse(text, out _);

            if (Double.TryParse(text, out double zahl))
            {
                return true;
            }

            return false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="liste"></param>
        /// <param name="element"></param>
        /// <example>
        ///             Handelstag tag = new Handelstag();
        ///            this.Handelstage.AddIfNew(tag);
        /// </example>
        /// <remarks>
        ///             Handelstag tag = new Handelstag();
        ///            this.Handelstage.AddIfNew(tag);
        /// </remarks>
        public static void AddIfNew<T>(this List<T> liste, T element)
        {
            if (!liste.Contains(element))
            {
                liste.Add(element);
            }
        }
    }
}