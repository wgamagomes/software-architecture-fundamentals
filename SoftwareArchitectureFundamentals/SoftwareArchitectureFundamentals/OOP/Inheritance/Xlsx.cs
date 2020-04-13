using System.Diagnostics;
using System.Text;

namespace SoftwareArchitectureFundamentals.OOP.Inheritance
{
    public class Xlsx: File
    {
        public Xlsx(string content)
           : base(content)
        {

        }

        public override void Save(string path)
        {
            Debug.WriteLine($"Saving Xlsx file> {_content}");
        }

        public override void Save(string path, Encoding encoding)
        {
            Debug.WriteLine($"Saving Xlsx file> {_content}");
        }
    }
}
