using RepoOrganizer.Core.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoOrganizer.Data
{
    public abstract class DataRepositoryBase<T> : DataRepositoryBase<T, DataContexClassIsHere>
        where T : class, new()
    {
    }
}
