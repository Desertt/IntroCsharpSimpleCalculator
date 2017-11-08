using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCsharpSimpleCalculator
{
    public class Calculate
    {

        #region Basip Hesap Makinesi/Simple Calculator

        public int AddingNumbers(int x, int y)
        {
            return x + y;

        }

        public string AddingNumbersS(string x, string y)
        {
            int a, b, c;
            a = Convert.ToInt32(x);
            b = Convert.ToInt32(y);

            c = a + b;

            return c.ToString();

        }

        public int SubtractingNumbers(int x, int y)
        {
            return x - y;

        }

        public int Multiplying(int x, int y)
        {
            return x * y;

        }

        public int Dividing(int x, int y)
        {
            return x / y;

        }

        public int Mod(int x, int y)
        {
            return x % y;

        }

        #endregion

        #region Ortalama Hesaplama/Average Calculation
        public string CalculateAverage(string a, string b, string c, string d)
        {
            double x, y, z, w, r;
            x = Convert.ToDouble(a);
            y = Convert.ToDouble(b);
            z = Convert.ToDouble(c);
            w = Convert.ToDouble(d);
            r = (x + y + z + w) / 4;
            return r.ToString();

        }
        #endregion

    }
}
