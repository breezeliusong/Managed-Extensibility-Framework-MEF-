using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedOperations
{
    public class Class1
    {
    }

    [Export(typeof(SimpleCalculator.IOperation))]
    [ExportMetadata("Symbol", '%')]
    public class Mod : SimpleCalculator.IOperation
    {
        public int Operate(int left, int right)
        {
            return left % right;
        }
    }
}
