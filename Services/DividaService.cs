using System;
using System.Collections.Generic;
using GerenciadorDividasCore.Models;

namespace GerenciadorDividasCore.Services
{
    public interface ISDividaService
    {
        IEnumerable<Divida> GetAllItems();
        Divida Add(Divida newItem);
        Divida Edit(Divida editItem);
        Divida GetById(Guid id);
        void Remove(Guid id);
    }

    public class DividaService : ISDividaService
    {
        
        public IEnumerable<Divida> GetAllItems()
        {
            throw new NotImplementedException();
        }
        public Divida GetById(Guid id)
        {
            throw new NotImplementedException();
        }
        public Divida Add(Divida newItem)
        {
            throw new NotImplementedException();
        }
        public Divida Edit(Divida newItem)
        {
            throw new NotImplementedException();
        }
        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}