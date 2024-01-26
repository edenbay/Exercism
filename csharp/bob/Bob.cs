using System;
using System.Linq;
using System.Text.RegularExpressions;

    public static class Bob
    {
                    public static string Response(string statement)
        {
            //yelling question

            string trimmedStatement = statement.Trim();

            if (trimmedStatement.IsQuestion())
            {
                if (trimmedStatement.IsYelled())
                {
                    return "Calm down, I know what I'm doing!";
                }
                else
                {
                    return "Sure.";
                }
            }
            else if (trimmedStatement.IsYelled())
            {
                return "Whoa, chill out!";
            }
            else if (trimmedStatement.IsSilent())
            {
                return "Fine. Be that way!";
            }
            else
            {
                return "Whatever.";
            }

            

        }

        private static bool IsYelled(this string str) => str.Any(char.IsUpper) && !str.Any(char.IsLower);

        private static bool IsQuestion(this string str) => str.EndsWith('?');

        private static bool IsSilent(this string str) => str == "";
    }