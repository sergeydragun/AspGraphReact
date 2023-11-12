using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IInfoCardRepository InfoCards { get; }
        IUserRepository Users { get; }
        Task<int> SaveAsync();
    }
}
