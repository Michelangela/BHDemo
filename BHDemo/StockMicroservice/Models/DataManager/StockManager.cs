using StockMicroservice.Data;
using StockMicroservice.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace StockMicroservice.Models.DataManager
{
    public class StockManager : IDataRepository<Stock>
    {
        readonly StockContext _stockContext;

        public StockManager(StockContext context)
        {
            _stockContext = context;
        }

        public IEnumerable<Stock> GetAll()
        {
            return _stockContext.Stocks.ToList();
        }

        public Stock Get(long id)
        {
            return _stockContext.Stocks
                  .FirstOrDefault(e => e.Id == id);
        }

        public void Add(Stock entity)
        {
            _stockContext.Stocks.Add(entity);
            _stockContext.SaveChanges();
        }

        public void Update(Stock stock, Stock entity)
        {
            stock.Id = entity.Id;
            stock.Symbol = entity.Symbol;
            stock.Date = entity.Date;
            stock.Price = entity.Price;

            _stockContext.SaveChanges();
        }

        public void Delete(Stock stock)
        {
            _stockContext.Stocks.Remove(stock);
            _stockContext.SaveChanges();
        }
    }
}
