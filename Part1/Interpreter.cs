using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Interpreter
    {
        private string text;
        private int pos;
        private Token current_token;
        private char current_char;

        public Interpreter(string t)
        {
            text = t;
        }

        private void Error()
        {
            throw new Exception("Error parsing input");
        }

        private Token GetNextToken()
        {
            if (pos > text.Length - 1)
                return new Token(TokenType.EOF, null);

            current_char = text[pos];

            if (char.IsDigit(current_char))
            {
                pos += 1;
                return new Token(TokenType.INTERGER, current_char.ToString());
            }

            if (current_char == '+')
            {
                pos += 1;
                return new Token(TokenType.PLUS, current_char.ToString());
            }

            Error();
            return null;
        }

        private void Eat(TokenType t)
        {
            if (current_token.type == t)
                current_token = GetNextToken();
            else
                Error();
        }

        public int expr()
        {
            current_token = GetNextToken();

            var left = current_token;
            Eat(TokenType.INTERGER);

            var op = current_token;
            Eat(TokenType.PLUS);

            var right = current_token;
            Eat(TokenType.INTERGER);

            int result = int.Parse(left.value) + int.Parse(right.value);
            return result;
        }
    }
}
