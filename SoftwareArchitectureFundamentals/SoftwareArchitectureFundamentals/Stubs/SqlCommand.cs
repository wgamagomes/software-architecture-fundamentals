using System;
using System.Data;

namespace SoftwareArchitectureFundamentals.Stubs
{
    internal class SqlCommand: IDisposable
    {
        public SqlCommand()
        {
        }

        public SqlConnection Connection { get; internal set; }
        public CommandType CommandType { get; internal set; }
        public string CommandText { get; internal set; }

        internal void Parameters(string key, object value)
        {
            
        }

        internal void ExecuteNonQuery()
        {
           
        }

        public void Dispose()
        {
           
        }
    }
}