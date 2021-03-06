﻿using LivrariaBlumenau.Domain.Interfaces.Repositories;
using LivrariaBlumenau.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace LivrariaBlumenau.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

		//Injetando dependência
        public ServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}
