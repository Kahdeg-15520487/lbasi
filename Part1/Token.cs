using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    enum TokenType
    {
        INTERGER,
        PLUS,
        MINUS,
        EOF
    }

    class Token
    {
        public readonly TokenType type;
        public readonly string value;

        public Token(TokenType t,string v)
        {
            type = t;
            value = v;
        }

        public override string ToString()
        {
            return string.Format("Token({0}, {1})", type, value);
        }
    }
}
