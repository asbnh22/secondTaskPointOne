using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SecondTaskPartOne
{
    public class HtmlBuilder
    {
        private String indent = new string(' ', 4);
        String sanitaze(String s)
        {
            return s.
                 Replace("&", "&amp;").
                 Replace("<", "&lt;").
                 Replace(">", "&gt;").
                 Replace("\"", "&quot;").
                 Replace("'", "&#x27;");
        }
        String buildUserRef(User user)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(indent);
            builder.Append("<a href =\"mailto:");
            builder.Append(sanitaze(user.Email));
            builder.Append("\">");
            builder.Append(sanitaze(user.Name));
            builder.Append("</a>");
            return builder.ToString();
        }

        public String buildHtml()
        {
            StringBuilder builder = new StringBuilder();
            List<User> users = new List<User>()
            {
                new User(name: "Maxim<script>alert('Name!')</script>", email: "Maxim<script>alert('Name!')</script>"),
                new User(name: "petya", email: "2"),
                new User(name: "vasya", email: "8")
            };

            builder.Append("<body>\n");
            List<String> listOfUsers = users.Select(u => buildUserRef(u)).ToList();
            builder.AppendJoin(" |\n", listOfUsers);
            builder.Append("\n</body>");
            //Console.WriteLine(builder);
            //Console.ReadKey();
            return builder.ToString();
        }
    }
}
