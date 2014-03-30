using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using IList = System.Collections.IList;
using ArrayList = System.Collections.ArrayList;

namespace C2CUDATranslator
{
    class Analysis
    {
        public bool BenergyTest(ArrayList index1, ArrayList index2)
        {
            int i,j;
            int count = 0;
            string te = ArraytoString(index1);
            if (string.Compare(ArraytoString(index1), ArraytoString(index2)) == 0)
            {
                return false;
            }


            if (index1.Count >= index2.Count)
            {
                for (i = 0; i < index1.Count; i++)
                {
                    for (j = 0; j < index2.Count; j++)
                    {
                        if ((index1[i].ToString() == "+") || (index1[i].ToString() == "-") || (index1[i].ToString() == "["))
                        {
                            index1.RemoveAt(i);
                        }
                        if (String.Compare(index1[i].ToString() ,index2[j].ToString()) == 0)
                        {
                            index1.RemoveAt(i);
                            index2.RemoveAt(j);
                        }
                        else
                        {
                            count++;
                        }
                       
                    }
                }
                if (index1.Count == 0)
                {
                    return false;
                }
            }
            else
            {
                for (i = 0; i < index2.Count; i++)
                {
                    for (j = 0; j < index1.Count; j++)
                    {
                        if ((index2[i].ToString() == "+") || (index2[i].ToString() == "-") || (index2[i].ToString() == "["))
                        {
                            index2.RemoveAt(i);
                        }
                        if (String.Compare(index2[i].ToString(), index1[j].ToString())==0)
                        {
                            index2.RemoveAt(i);
                            index1.RemoveAt(j);
                        }
                        else
                        {
                            count++;
                        }
                        
                    }
                }
                if (index2.Count == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public ArrayList GetindexofArrayfromassignmentStatement(string statement)
        {
            
            ArrayList index = new ArrayList();
            ArrayList index1 = new ArrayList();
            ArrayList indextemp = new ArrayList();
            int i;
            bool flag=false,flagagain=false ;
            
            for (i = 0; i <= statement.Length -1; i++)
            {
                if (statement[i]=='[')
                {
                    flag = true;
                    i = i + 1;
                }
                if (statement[i] == ']')
                {
                    flag = false;
                    flagagain = true;
                }
                if (flag)
                {
                    index.Add(statement[i]);
                   
                }
                if (flagagain)
                {
                    if (index1.Count < index.Count)
                    {

                        if (index.Count >= indextemp.Count)
                        {
                            index1 = (ArrayList)index.Clone();
                        }
                        else
                        {
                            index1 = (ArrayList)indextemp.Clone();
                        }
                    }
                    indextemp = (ArrayList)index.Clone();
                    index.Clear();
                    flagagain = false;
                }
            }
            
            return index1;
        }

        public string ParallelizeLoop(ForLoop Loop)
        {

            return "";

        }
        public string ArraytoString(ArrayList index1)
        {
            string a = string.Empty ;
            int i;
            for (i = 0; i < index1.Count; i++)
            {
                a += index1[i];
            }
            return a;
        }
    }
}
