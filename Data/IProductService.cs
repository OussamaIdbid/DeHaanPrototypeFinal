using System.Collections.Generic;  
using System.Threading.Tasks;  


namespace DeHaanCash.Data
{  
    public interface IProductService  
    {  
        Task<IEnumerable<Product>> GetProducts();  
        Task<bool> CreateProduct(Product product);  
        Task<bool> EditProduct(int id, Product product);  

        Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
        Task<Product> SingleProduct(int id);  
        Task<bool> DeleteProduct(int id);  
    }  
} 