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

        #region hoang
        public static List<typeProduct> GetAllProductType()
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.typeProducts.Where(x => true).ToList();
        }

        public static Boolean Add(typeProduct pd)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            if(IsExists(pd.typeProductName))
            {
                return false;
            }
            DB.typeProducts.InsertOnSubmit(pd);
            DB.SubmitChanges();
            return true;
        }

        public static Boolean IsExists(String name)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.typeProducts.Any(x => x.typeProductName == name);
        }

        public static Boolean Edit(typeProduct tp)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            typeProduct pd = DB.typeProducts.FirstOrDefault(x => x.typeProductID == tp.typeProductID);
            pd.typeProductName = tp.typeProductName;
            DB.SubmitChanges();
            return true;
        }

        public static Boolean Remove(int v)
        {
            try
            {
                CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
                typeProduct pd = DB.typeProducts.FirstOrDefault(x => x.typeProductID == v);
                DB.typeProducts.DeleteOnSubmit(pd);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        #endregion
    }
}
