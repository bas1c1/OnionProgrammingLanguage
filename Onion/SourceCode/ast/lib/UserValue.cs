using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnLang.ast.lib
{
    class UserValue : Value
    {
        private object value;

        public UserValue(object value)
        {
            this.value = value;
        }

        public double asDouble()
        {
            try
            {
                return double.Parse(value.ToString());
            }

            catch
            {
                return 0;
            }
        }

        public string asString()
        {
            return value.ToString();
        }

        public int asNumber()
        {
            try
            {
                return int.Parse(value.ToString());
            }

            catch
            {
                return 0;
            }
        }

        public char asChar()
        {
            try
            {
                return char.Parse(value.ToString());
            }

            catch
            {
                return ' ';
            }
        }

        public TokenType type()
        {
            return TokenType.OBJ;
        }
    }
}
