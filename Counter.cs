using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Counter
    {
        private int count = 0;
        private int increment;

        public Counter(int increment)
        {
            this.increment = increment;
        }

        public int GetAndIncrement()
        {
            this.count += this.increment;
            return this.count;
        }

        //public abstract string GetNewDocumentName();
    }

    public class DocumentNameCreator : Counter
    {
        private string prefix;

        public DocumentNameCreator(int increment, string prefix, Counter creator) : base(increment)
        {
            this.prefix = prefix;
        }

        public string GetNewDocumentName()
        {
            return prefix + GetAndIncrement();
        }
    }
}
