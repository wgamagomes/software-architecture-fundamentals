using System.Diagnostics;
using System.Text;

namespace SoftwareArchitectureFundamentals.OOP.Inheritance
{
    public class Txt : File
    {
        public Txt(string content)
            : base(content)
        {

        }

        public override void Save(string path)
        {
            Debug.WriteLine($"Saving Txt file> {_content}");

        }

        public override void Save(string path, Encoding encoding)
        {
            Debug.WriteLine($"Saving Txt file> {_content}");
        }
    }
}
