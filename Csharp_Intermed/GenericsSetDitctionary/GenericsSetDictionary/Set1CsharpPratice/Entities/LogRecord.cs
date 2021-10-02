using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1CsharpPratice.Entities
{
    internal class LogRecord
    {
        public string? Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            if (Username is not null)
            {
                return Username.GetHashCode();
            }

            return 0;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not LogRecord)
            {
                return false;
            }

            if (obj is not null)
            { 
                LogRecord other = obj as LogRecord;

                if (Username is not null)
                {
                    return Username.Equals(other?.Username);
                }
            }

            return false;
        }
    }
}
