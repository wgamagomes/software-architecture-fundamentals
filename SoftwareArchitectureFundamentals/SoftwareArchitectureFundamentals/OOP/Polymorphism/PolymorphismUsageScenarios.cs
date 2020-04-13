using SoftwareArchitectureFundamentals.OOP.Inheritance;
using System.Collections.Generic;
using System.Text;

namespace SoftwareArchitectureFundamentals.OOP.Polymorphism

{
    /// <summary>
    ///  Polymorphism is the ability of an object to take on many forms.
    /// </summary>
    public class PolymorphismUsageScenarios
    {
        /// <summary> 
        /// Dynamic Polymorphism
        /// When an object (Txt, Pdf or Xlsx) is assigned to a reference class (File)
        /// and when a method of the object is called, the method in the object’s class is executed.
        /// Not the method of the reference class (File).
        /// </summary>
        public static void DynamicPolymorphism()
        {
            List<File> files = new List<File> { new Txt("TXT content"), new Pdf("PDF content"), new Xlsx("XLSX content") };

            foreach (var file in files)
            {
                file.Save("Whatever path here...");
            }
        }

        /// <summary>
        /// Static Polymorphism
        /// This is actually method overloading. Method overloading is having more than one method with the same method name but with different arguments
        /// </summary>
        public static void StaticPolymorphism()
        {
            File file = new Pdf("PDF content");

            // method with 1 parametersis called
            file.Save("Whatever path here...");

            // method with 2 parameters is called
            file.Save("Whatever path here...", Encoding.UTF8);
        }
    }
}
