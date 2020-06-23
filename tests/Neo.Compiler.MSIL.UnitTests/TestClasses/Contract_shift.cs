using System.ComponentModel;

namespace Neo.Compiler.MSIL.UnitTests.TestClasses
{
    class Contract_shift : SmartContract.Framework.SmartContract
    {
        public delegate void mydelegate(int arg);

        [DisplayName("event")]
        public static event mydelegate notify;

        public static object Main()
        {
            int v = 8;
            var v1 = v << 1;
            var v2 = v << -1;
            var v3 = v >> 1;
            var v4 = v >> -1;
            notify(v1);
            notify(v2);
            notify(v3);
            notify(v4);
            return false;
        }
    }
}
