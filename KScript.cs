using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpToTypescriptDefine
{
    public interface KScript
    {
        public User User { get; set; }

        public void Execute(string code, User user);
    }

    public class User : Person
    {
        public string Name { get; set; }
        public string Pwd { get; set; }
        public int Age { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
    }
}
