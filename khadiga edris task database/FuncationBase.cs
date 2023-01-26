using System.Data;

namespace khadiga_edris_task_database
{
    internal abstract class FuncationBase
    {
        public abstract DataTable GetData(string Query);
    }
}