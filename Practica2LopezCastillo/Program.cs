using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Practica2LopezCastillo
{
    class Program
    {
        static void Main(string[] args)
        {
            String errores ="";

            StreamReader streamReader = new StreamReader(args[0]);

            AntlrInputStream antlrInputStream = new AntlrInputStream(streamReader);

            sicxegramLexer lexer = new sicxegramLexer(antlrInputStream);

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            sicxegramParser parser = new sicxegramParser(tokens);

            //IParseTree tree = parser.compileUnit();

            //Console.WriteLine(tree.ToStringTree(parser));
            /*
            otraopcion = fuenteTextBox.Text + Environment.NewLine;
                GramaticaLexer cLex = new GramaticaLexer(new AntlrInputStream(otraopcion));
                */
            string pa = Environment.CurrentDirectory + "\\salida.t";
            FileStream file = new FileStream(pa, FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter(file);
                Console.SetError(write);


            BaseErrorListener ListaErrores = new BaseErrorListener();
               // ErrorListener errores = new ErrorListener();
                parser.AddErrorListener(ListaErrores);

                try
                {
                parser.compileUnit();  // Analiza la gramática
                }
                catch (RecognitionException ex)
                {
                    Console.Error.WriteLine(ex.StackTrace);
                }

                write.Close();
                file.Close();

                file = new FileStream(pa, FileMode.Open, FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(file);
                string sLine = "";
                List<string> arrErrores = new List<string>();

                while (sLine != null)
                {
                    sLine = reader.ReadLine();
                    if (sLine != null)
                        arrErrores.Add(sLine);
                }

                reader.Close();
                file.Close();

                if (arrErrores.Count != 0)
                {
                    foreach (var error in arrErrores)
                    {
                        errores += error + "\r\n";
                    }
                }
                else
                {
                    errores = "No se encontraron errores";
                }
            Console.ReadKey();
            /*
                StreamReader streamReader = new StreamReader(args[0]);

                AntlrInputStream antlrInputStream = new AntlrInputStream(streamReader);

                sicxegramLexer lexer = new sicxegramLexer(antlrInputStream);

                CommonTokenStream tokens = new CommonTokenStream(lexer);

                sicxegramParser parser = new sicxegramParser(tokens);

                IParseTree tree = parser.compileUnit();

                Console.WriteLine(tree.ToStringTree(parser));

                Console.ReadKey();*/

        }
    }
}
