using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrack
{
    public class TrackComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Benzovoz && y is Benzovoz)
            {
                return ComparerBenzovoz((Benzovoz)x, (Benzovoz)y);
            }
            if (x is Benzovoz && y is Track)
            {
                return -1;
            }
            if (x is Track && y is Benzovoz)
            {
                return 1;
            }
            if (x is Track && y is Track)
            {
                return ComparerTrack((Track)x, (Track)y);
            }
            return 0;
        }
        private int ComparerTrack(Track x, Track y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
             if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerBenzovoz(Benzovoz x, Benzovoz y)
        {
            var res = ComparerTrack(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.DangerLight != y.DangerLight)
            {
                return x.DangerLight.CompareTo(y.DangerLight);
            }
            if (x.Cistern != y.Cistern)
            {
                return x.Cistern.CompareTo(y.Cistern);
            }
            return 0;
        }
    }
}
