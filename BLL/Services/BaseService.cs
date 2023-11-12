using AutoMapper;
using BLL.Interfaces;
using Microsoft.Extensions.Logging;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public abstract class BaseService : IBaseService
    {
        public IMapper _mapper;
        protected readonly ILogger<IBaseService> _logger;
        protected IUnitOfWork _database;

        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public BaseService(IUnitOfWork unitOfWork, IMapper mapper) : this(mapper)
        {
            _database = unitOfWork; 
        }
        public BaseService(IUnitOfWork unitOfWork, ILogger<IBaseService> logger, IMapper mapper) : this(unitOfWork, mapper)
        {
            _logger = logger;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_database != null)
                {
                    _database.Dispose();
                    _database = null;
                }
            }
        }
    }
}
