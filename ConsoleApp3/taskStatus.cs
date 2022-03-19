using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class taskStatus
    {
        public static taskStatus Waiting { get; internal set; }
        public static taskStatus Rejected { get; internal set; }
        public static taskStatus Done { get; internal set; }
        public static taskStatus Progress { get; internal set; }
    }
}
