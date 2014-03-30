using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace C2CUDATranslator
{
    class ForLoop
    {
        private String Loopindex = "";
        private Boolean NestLoop = false;
        private ForLoop child = null;
        private ForLoop parent = null;
        private ArrayList stats = null;

        private String sze ="";

        public String Index
        {
            get
            {
                return Loopindex;
            }
            set
            {
                Loopindex = value;
            }
        }

        public Boolean IsNestLoop
        {
            get
            {
                return NestLoop;
            }
            set
            {
                NestLoop = value;
            }
        }

        public ForLoop ChildLoop
        {
            get
            {
                return child;
            }
            set
            {
                child = value;
            }
        }

        public ForLoop ParentLoop
        {
            get
            {
                return parent;
            }
            set
            {
                parent = value;
            }
        }

        public ArrayList Statements
        {
            get
            {
                return stats;
            }
            set
            {
                stats = value;
            }
        }

        public String Size
        {
            get
            {
                return sze;
            }
            set
            {
                sze = value;
            }
        }

    }
}
