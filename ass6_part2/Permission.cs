using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6_part2
{
    [Flags]
    public enum Permission:byte
    {
        read=1,
        write=2,
        delete=4,
        execute=8

    }
}
