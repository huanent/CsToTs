using System;
using System.IO;
using CSharpToTypescriptDefine;

namespace CsToTs
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Conventer().Convent(typeof(KScript));
            File.WriteAllText("kscript.d.ts", result);
        }
    }
}
