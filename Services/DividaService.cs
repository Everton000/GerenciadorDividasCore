using System;
using System.Collections.Generic;
using System.Linq;
using GerenciadorDividasCore.Models;

namespace GerenciadorDividasCore.Services
{
    public interface ISDividaService
    {
        IList<Divida> GetAllDividas();
        IList<Divida> GetByCliente(int clienteId);
        Divida GetById(int id);
        Divida Add(Divida divida);
        void Edit(Divida editItem);
        void Remove(int id);
    }

    public class DividaService : ISDividaService
    {
        private readonly GerenciadorDividasContext _context;
        
        public DividaService(GerenciadorDividasContext context)
        {
            _context = context;
        }

        public IList<Divida> GetAllDividas()
        {
            return _context.Dividas
                .Where(d => d.DataExclusao == null)
                .ToList();
        }

        public IList<Divida> GetByCliente(int clienteId)
        {
            return _context.Dividas
                .Where(d => d.ClienteId == clienteId &&
                    d.DataExclusao == null)
                .ToList();
        }

        public Divida GetById(int id)
        {
            return _context.Dividas
                .Where(d => d.Id == id &&
                    d.DataExclusao == null)
                .FirstOrDefault();
        }

        public Divida Add(Divida divida)
        {
            _context.Dividas.Add(divida);
            _context.SaveChanges();

            return divida;
        }

        public void Edit(Divida divida)
        {
            _context.Dividas.Update(divida);
            _context.SaveChanges();
        }

        // method set datetime exclusao
        public void Remove(int id)
        {
            Divida divida = _context.Dividas
                .Where(d => d.Id == id)
                .FirstOrDefault();

            divida.DataExclusao = DateTime.Now;
            
            _context.Dividas.Update(divida);
            _context.SaveChanges();
        }
        
        // method remove
        /* public void Remove(int id)
        {
            Divida divida = _context.Dividas
                .Where(d => d.Id == id)
                .FirstOrDefault();
            
            _context.Remove(divida);
            _context.SaveChanges();
        } */
    }
}