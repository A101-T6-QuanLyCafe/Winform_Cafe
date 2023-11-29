using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TypeProductBLL
    {
        CoffeeShopDBDataContext dbContext = new CoffeeShopDBDataContext();
        public void AddTypeProduct(typeProduct typeProduct)
        {
          
                // Kiểm tra xem typeProduct đã tồn tại chưa
                if (dbContext.typeProducts.Any(tp => tp.typeProductName == typeProduct.typeProductName))
                {
                    // Nếu tồn tại rồi thì không thêm mới
                    
                    return;
                }

                // Thêm typeProduct mới
                dbContext.typeProducts.InsertOnSubmit(typeProduct);
                dbContext.SubmitChanges();
               
            
        }

        public void UpdateTypeProduct(typeProduct typeProduct)
        {
          
                // Kiểm tra xem typeProduct có tồn tại trong cơ sở dữ liệu không
                var existingTypeProduct = dbContext.typeProducts.FirstOrDefault(tp => tp.typeProductID == typeProduct.typeProductID);
                if (existingTypeProduct == null)
                {
                   
                    return;
                }

                // Cập nhật thông tin của typeProduct
                existingTypeProduct.typeProductName = typeProduct.typeProductName;
                
                dbContext.SubmitChanges();
                
            
        }

        public List<typeProduct> GetAllTypeProducts()
        {
            
               
                return dbContext.typeProducts.ToList();
            
        }
    }
}
