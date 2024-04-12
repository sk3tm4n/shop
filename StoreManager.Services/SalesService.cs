using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.DTO;
using StoreManager.Service.Interfaces.Repositories;
using StoreManager.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
namespace StoreManager.Service
{
   

    public  class SalesService : ISalesService
    {
        private readonly IUnitOfWork<IDbConnection> _unitOfWork;

        public SalesService(IUnitOfWork<IDbConnection> unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public int GetTotalProducts()
        {
            try
            {
                _unitOfWork.BeginTransaction();
                IProductRepository productRepository = _unitOfWork.ProductRepository;
                var productData = productRepository.Load().ToList();
                int totalProducts = CalculateTotalProducts(productData);
                _unitOfWork.CommitTransaction();

                return totalProducts;
            }
            catch
            {
                _unitOfWork.RollBackTransaction();
                throw;
            }
        }

        public List<(int productId, decimal unitPrice)> GetProductDetails()
        {
            try
            {
                _unitOfWork.BeginTransaction();
                IProductRepository productRepository = _unitOfWork.ProductRepository;
                var productData = productRepository.Load().ToList();
                var productDetails = GetProductDetails(productData);
                _unitOfWork.CommitTransaction();

                return productDetails;
            }
            catch
            {
                _unitOfWork.RollBackTransaction();
                throw;
            }
        }

        public decimal GetTotalPrice()
        {
            try
            {
                _unitOfWork.BeginTransaction();
                IProductRepository productRepository = _unitOfWork.ProductRepository;
                var productData = productRepository.Load().ToList();
                decimal totalPrice = CalculateTotalPrice(productData);
                _unitOfWork.CommitTransaction();

                return totalPrice;
            }
            catch
            {
                _unitOfWork.RollBackTransaction();
                throw;
            }
        }

        private int CalculateTotalProducts(List<Product> products)
        {
            return products.Count;
        }

        private List<(int productId, decimal unitPrice)> GetProductDetails(List<Product> products)
        {
            return products.Select(p => (p.ProductId, p.UnitPrice)).ToList();
        }

        private decimal CalculateTotalPrice(List<Product> products)
        {
            return products.Sum(p => p.UnitPrice);
        }

    }
}

