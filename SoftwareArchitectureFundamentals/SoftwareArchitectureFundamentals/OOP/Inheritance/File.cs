using System.Text;

namespace SoftwareArchitectureFundamentals.OOP.Inheritance
{
    public abstract class File
    {
        protected readonly string _content;

        public File(string content)
        {
            _content = content;
          
        }
        public abstract void Save(string path);
        public abstract void Save(string path, Encoding encoding);
    }
}
