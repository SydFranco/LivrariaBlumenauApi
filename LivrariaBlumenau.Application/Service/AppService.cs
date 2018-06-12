using LivrariaBlumenau.Application.Interface;
using LivrariaBlumenau.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaBlumenau.Application.Service
{
    public class AppService<TEntity> : IDisposable, IAppService<TEntity> where TEntity : class
    {
        private readonly IService<TEntity> _service;

        public AppService(IService<TEntity> service)
        {
            _service = service;
        }

        public void Add(TEntity obj)
        {
            _service.Add(obj);
        }

        public void Dispose()
        {
            _service.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _service.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }
    }
}
