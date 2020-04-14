using System;
namespace SoftwareArchitectureFundamentals.Stubs
{
    internal class SqlConnection : IDisposable
    {
        public string ConnectionString { get; internal set; }

        public void Dispose()
        {
           
        }

        internal void Open()
        {
           
        }
    }
}