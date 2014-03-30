using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;
using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;
using System.Data.SqlClient;
using System.Data;
using ArrayList = System.Collections.ArrayList;

namespace C2CUDATranslator
{
    class Program
    {
        public static StringTemplateGroup templates;
        public static StringTemplateGroup templates2;
        public static StringTemplateGroup templates3;
        static void Main(string[] args)
        {
            try
            {
                string inputFileName;
                string templateFileName;
                
                if ((args.Length == 1) || (args.Length == 2))
                {
                    if (args.Length == 1)
                    {
                        templateFileName = "CUDAC.stg";
                        inputFileName = args[0];
                    }
                    else
                    {
                        templateFileName = args[0];
                        inputFileName = args[1];
                    }

                   
                    if (!Path.IsPathRooted(templateFileName))
                    {
                        //templateFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, templateFileName);
                        templateFileName = Path.Combine(Environment.CurrentDirectory, templateFileName);
                    }
                    if (!Path.IsPathRooted(inputFileName))
                    {
                        inputFileName = Path.Combine(Environment.CurrentDirectory, inputFileName);
                    }

                    templates = new StringTemplateGroup(new StreamReader(templateFileName),
                                        typeof(AngleBracketTemplateLexer));
                    templates2 = new StringTemplateGroup(new StreamReader("CUDAPattern.stg"),
                                        typeof(AngleBracketTemplateLexer));
                    templates3 = new StringTemplateGroup(new StreamReader("CUDACkernel.stg"),
                                       typeof(AngleBracketTemplateLexer));

                    //ArrayList one=new ArrayList();
                    //one.Add("i");
                    ////one.Add("+");
                    ////one.Add("1");

                    //ArrayList two = new ArrayList();
                    //two.Add("i");

                    Analysis analysis = new Analysis();
                    //if (analysis.BenergyTest(one, two))
                    //{
                    //    Console.Out.WriteLine("Iterative Dependecy");
                    //}
                    //else
                    //{
                    //    Console.Out.WriteLine("No Dependecy");
                    //}
                    //return;

                    ICharStream input = new ANTLRFileStream(inputFileName);
                    C2CUDATranslatorLexer lexer = new C2CUDATranslatorLexer(input);
                    CommonTokenStream tokens = new CommonTokenStream(lexer);
                    C2CUDATranslatorParser parser = new C2CUDATranslatorParser(tokens);
                    parser.TemplateLib = templates;
                    RuleReturnScope r = parser.program();
                    Console.Out.WriteLine(r.Template.ToString().Replace(@"\/", "/").ToString());
                    // Part 2
                    // Console.Error.WriteLine("Getting Pattern");
                    ICharStream input3 = new ANTLRFileStream(inputFileName);
                    C2CUDATranslatorLexer lexer3 = new C2CUDATranslatorLexer(input3);
                    CommonTokenStream tokens3 = new CommonTokenStream(lexer3);
                    C2CUDATranslatorParser parser3 = new C2CUDATranslatorParser(tokens3);
                    parser3.TemplateLib = templates3;
                    RuleReturnScope r3 = parser3.program();


                    ICharStream input2 = new ANTLRStringStream(r3.Template.ToString().Replace("((", "( (").Replace(@"\/", "/").ToString().ToString().Replace("))", ") )").ToString().Replace("){", ") {").ToString().Replace("**", "*").ToString());
                    PatternGeneratorLexer lexer2 = new PatternGeneratorLexer(input2);
                    CommonTokenStream tokens2 = new CommonTokenStream(lexer2);
                    PatternGeneratorParser parser2 = new PatternGeneratorParser(tokens2);
                    parser2.TemplateLib = templates2;
                    RuleReturnScope r2 = parser2.pattern();
                    Console.Error.WriteLine("// Pattern : ");
                    string pattern= r2.Template.ToString();
                    Console.Out.WriteLine("//" + r2.Template.ToString().Replace("\r\n","\r\n//"));
                
                    
                    //Console.Out.WriteLine("Checking in Database");
                    
                    //string connecstr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
                    //SqlConnection con = new SqlConnection(connecstr);
                    //con.Close();
                    //con.Open();
                    //String sql = "Select * from PatternDatabase";
                    //DataTable dt = new DataTable();
                    //SqlDataAdapter adp = new SqlDataAdapter(sql,con);
                    //adp.Fill(dt);
                    //bool flag=false ;
                    //for(int i=0;i<dt.Rows.Count -1 ;i++)
                    //{
                    //    if(pattern==dt.Rows[i][1].ToString())
                    //    {
                    //        Console.Out.WriteLine("Found in Database");
                    //        flag =true ;
                    //    }
                    //    else
                    //    {
                    //    }
                    //}
                    //if (flag == true)
                    //{
                    //}
                    //else
                    //{
                    //    sql = "Insert into PatternDatabase values('"+pattern.ToString()+"','"+pattern.ToString()+"')";
                    //    SqlCommand cmd = new SqlCommand(sql, con);
                    //    cmd.ExecuteNonQuery();
                    //    con.Close();
                    //    Console.Out.WriteLine("Not Found in Database But added in database");
                    //}
                    //con.Close();
                    string lines = "group CUDA;\r\n pattern(type,name,args,";
                        
                     string[] p = pattern.ToString().Replace("{", " ").ToString().Replace("}", " ").ToString().Replace("\n", ",").Replace(@"\/", "/").ToString().Substring(34, pattern.Length - 34).ToString().Split(',');
                    for (int i = 0;i< p.Length  -1; i++)
                    {
                        if (p[i].ToString().Trim() != "")
                        {
                            lines = lines + p[i].ToString().Trim() + ",\r\n";
                        }
                    }
                    lines = lines + ") ::= << " + "\r\n" + "<type> <name>(<args; separator=\"\\n\">) {" + "\r\n";
                        
                    for (int i = 0;i< p.Length  -1; i++)
                    {
                        if (p[i].ToString().Trim() != "")
                        {
                            lines = lines + " <" + p[i].ToString().Trim() + ">" + "\r\n";
                        }
                    }
                    lines = lines + ">>";
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.stg");
                    file.WriteLine(lines);
                    
                    file.Close();

                      
                    
                    Console.ReadLine();

                }
                else
                    Console.Error.WriteLine("Usage: C2CUDATranslator [<output-template-file>] <input-file>");
            }
            catch (System.Exception e)
            {
                Console.Error.WriteLine("exception: " + e);
                Console.Error.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
