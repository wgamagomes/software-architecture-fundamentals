using System.Diagnostics;
using System.Text;

namespace SoftwareArchitectureFundamentals.OOP.Inheritance
{
    public class Pdf: File
    {
        public Pdf(string content)
           : base(content)
        {
        }

        public override void Save(string path)
        {
            Debug.WriteLine($"Saving Pdf file> {_content}");
        }

        public override void Save(string path, Encoding encoding)
        {
            Debug.WriteLine($"Saving Pdf file> {_content}");
        }
    }
}
