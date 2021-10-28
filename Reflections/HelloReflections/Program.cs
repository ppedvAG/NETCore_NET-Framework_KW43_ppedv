﻿using System;

using System.Reflection;


namespace HelloReflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly repräsentiert eine geladene DLL 
            Assembly geladeneDll = Assembly.LoadFrom("Taschenrechner.dll");
            Type taschenrechnerTyp = geladeneDll.GetType("Taschenrechner.Rechner");

            object tr = Activator.CreateInstance(taschenrechnerTyp);

            MethodInfo addInfo = taschenrechnerTyp.GetMethod("Add", new Type[] { typeof(Int32), typeof(Int32) });
            var result = addInfo.Invoke(tr, new object[] { 11, 22 });

            Console.WriteLine(result);
        }
    }
}
