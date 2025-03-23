using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CSharp;

namespace Utilities.Funciones
{
    /// <summary>
    /// 
    /// </summary>
    public class CSharp
    {

        public static void SetReferences(CompilerParameters cp, List<string> Assemblies)
        {
            cp.ReferencedAssemblies.Add("system.dll");
            cp.ReferencedAssemblies.Add("system.xml.dll");
            cp.ReferencedAssemblies.Add("system.data.dll");
            cp.ReferencedAssemblies.Add("system.windows.forms.dll");
            cp.ReferencedAssemblies.Add("system.drawing.dll");
            if (Assemblies != null)
            {
                Assemblies.ForEach(x => cp.ReferencedAssemblies.Add(x));
            }
        }

        public static void SetUsings(StringBuilder sb, List<string> Usings)
        {
            sb.Append("using System;\n");
            sb.Append("using System.Xml;\n");
            sb.Append("using System.Data;\n");
            sb.Append("using System.Data.SqlClient;\n");
            sb.Append("using System.Windows.Forms;\n");
            sb.Append("using System.Drawing;\n");
            sb.Append("using System.Collections.Generic;\n");
            if (Usings != null)
            {
                Usings.ForEach(x => sb.Append(string.Format("using {0};\n", x)));
            }
        }

        public static void SetProperties(object o, List<KeyValuePair<string, object>> properties)
        {
            Type t = o.GetType();

            properties.ForEach(p => t.GetProperty(p.Key).SetValue(o, p.Value, null));
        }

        /// <summary>
        /// Agrega el código dentro dentro de una fución y la ejecuta. Para obtener resultado, es necesario realizar el retur
        /// </summary>
        /// <param name="Code">Codigo que se ejecutará</param>
        /// <param name="Assemblies">Nombre de los ensablados requeridos</param>
        /// <param name="Usings"></param>
        /// <returns>object</returns>
        public static object ExecSource(string Code, List<string> Assemblies = null, List<string> Usings = null)
        {
            CSharpCodeProvider c = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();

            /*cp.ReferencedAssemblies.Add("system.dll");
            cp.ReferencedAssemblies.Add("system.xml.dll");
            cp.ReferencedAssemblies.Add("system.data.dll");
            cp.ReferencedAssemblies.Add("system.windows.forms.dll");
            cp.ReferencedAssemblies.Add("system.drawing.dll");
            if (Assemblies != null)
            {
                Assemblies.ForEach(x => cp.ReferencedAssemblies.Add(x));
            }
            */
            SetReferences(cp, Assemblies);

            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;

            StringBuilder sb = new StringBuilder("");
            /*sb.Append("using System;\n");
            sb.Append("using System.Xml;\n");
            sb.Append("using System.Data;\n");
            sb.Append("using System.Data.SqlClient;\n");
            sb.Append("using System.Windows.Forms;\n");
            sb.Append("using System.Drawing;\n");
            if (Usings != null)
            {
                Usings.ForEach(x => sb.Append(string.Format("using {0};\n", x)));
            }*/
            SetUsings(sb, Usings);

            sb.Append("namespace DNOTA{ \n");
            sb.Append("    public class CodeEval{ \n");
            sb.Append("        public object ExecText(){\n");
            //sb.Append("return " + sCSCode + "; \n");
            sb.Append(              Code + "\n");
            sb.Append("        }\n");
            sb.Append("    }\n");
            sb.Append("}\n");

            CompilerResults cr = c.CompileAssemblyFromSource(cp, sb.ToString());
            if (cr.Errors.Count > 0)
            {
                /*MessageBox.Show("ERROR: " + cr.Errors[0].ErrorText,
                   "Error evaluating cs code", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);*/
                throw new Exception(cr.Errors[0].ErrorText);
            }

            System.Reflection.Assembly a = cr.CompiledAssembly;
            object o = a.CreateInstance("ESKPE.CodeEval");

            Type t = o.GetType();
            MethodInfo mi = t.GetMethod("ExecText");

            object s = mi.Invoke(o, null);
            return s;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="ClassName"></param>
        /// <param name="FunctionExec"></param>
        /// <param name="Assemblies"></param>
        /// <param name="Usings"></param>
        /// <returns></returns>
        public static object ExecClass(string Code, string ClassName, string FunctionExec, List<string> Assemblies = null, List<string> Usings = null, List<KeyValuePair<string, object>> properties = null)
        {
            CSharpCodeProvider c = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();

            SetReferences(cp, Assemblies);

            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;

            StringBuilder sb = new StringBuilder("");
            SetUsings(sb, Usings);

            sb.Append("namespace DNOTA{ \n");
            sb.Append(Code + "\n");
            sb.Append("}\n");

            CompilerResults cr = c.CompileAssemblyFromSource(cp, sb.ToString());
            if (cr.Errors.Count > 0)
            {
                //MessageBox.Show("ERROR: " + cr.Errors[0].ErrorText,"Error evaluating cs code", MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw new Exception(cr.Errors[0].ErrorText);
            }

            System.Reflection.Assembly a = cr.CompiledAssembly;
            object o = a.CreateInstance("ESKPE."+ClassName);

            SetProperties(o, properties);

            Type t = o.GetType();
            MethodInfo mi = t.GetMethod(FunctionExec);
            
            object s = mi.Invoke(o, null);
            return s;

        }


        /// <summary>
        /// Compila una clase dado su código
        /// </summary>
        /// <param name="Code">Codigo de la clase</param>
        /// <param name="ClassName">Nombre de la clase</param>
        /// <param name="Assemblies">Ensamblados necesarios</param>
        /// <param name="Usings">Usings utilizados</param>
        /// <returns>Objecto de la clase compilada</returns>
        public static object CompileClass(string Code, string ClassName, List<string> Assemblies = null, List<string> Usings = null)
        {
            CSharpCodeProvider c = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();

            SetReferences(cp, Assemblies);

            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;

            StringBuilder sb = new StringBuilder("");
            SetUsings(sb, Usings);

            sb.Append("namespace DNOTA{ \n");
            sb.Append(Code + "\n");
            sb.Append("}\n");

            CompilerResults cr = c.CompileAssemblyFromSource(cp, sb.ToString());
            if (cr.Errors.Count > 0)
            {
                //MessageBox.Show("ERROR: " + cr.Errors[0].ErrorText,"Error evaluating cs code", MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw new Exception(cr.Errors[0].ErrorText);
            }

            System.Reflection.Assembly a = cr.CompiledAssembly;
            object o = a.CreateInstance("ESKPE." + ClassName);

            return o;
        }


        /// <summary>
        /// Ejecuta una función de un objeto, a partir del nombre de esta
        /// </summary>
        /// <param name="o">Objeto</param>
        /// <param name="funcionName">Nombre de la función</param>
        /// <returns>Object</returns>
        public static object ExecuteFunction(object o, string funcionName)
        {
            Type t = o.GetType();
            MethodInfo mi = t.GetMethod(funcionName);

            object s = mi.Invoke(o, null);
            return s;
        }
    }
}
