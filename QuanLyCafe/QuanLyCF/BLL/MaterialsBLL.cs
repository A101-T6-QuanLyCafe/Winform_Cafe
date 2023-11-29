using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MaterialsBLL
    {
        // Đối tượng DbContext hoặc kết nối cơ sở dữ liệu
        CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

       
        // Phương thức để lấy tất cả dữ liệu từ bảng materials
        public List<material> GetAllMaterials()
        {
            return db.materials.ToList();
        }

        // Phương thức để thêm mới một đối tượng materials
        public void AddMaterial(material newMaterial)
        {
            if (newMaterial != null)
            {
                // Kiểm tra logic hoặc điều kiện trước khi thêm mới
                db.materials.InsertOnSubmit(newMaterial);
                db.SubmitChanges();
            }
        }

        // Phương thức để cập nhật một đối tượng materials
        public void UpdateMaterial(material updatedMaterial)
        {
            if (updatedMaterial != null)
            {
                // Kiểm tra logic hoặc điều kiện trước khi cập nhật
                var existingMaterial = db.materials.SingleOrDefault(m => m.Materials_ID == updatedMaterial.Materials_ID);
                if (existingMaterial != null)
                {
                    // Cập nhật thuộc tính của đối tượng cũ từ đối tượng mới
                    existingMaterial.Materials_Name = updatedMaterial.Materials_Name;
                    existingMaterial.Price = updatedMaterial.Price;
                    existingMaterial.supplieriD = updatedMaterial.supplieriD;
                    existingMaterial.quantity = updatedMaterial.quantity;
                    existingMaterial.TypeID = updatedMaterial.TypeID;

                    db.SubmitChanges();
                }
            }
        }

        // Phương thức để xóa một đối tượng materials
        public void DeleteMaterial(int materialID)
        {
            var materialToDelete = db.materials.SingleOrDefault(m => m.Materials_ID == materialID);
            if (materialToDelete != null)
            {
                // Kiểm tra logic hoặc điều kiện trước khi xóa
                db.materials.DeleteOnSubmit(materialToDelete);
                db.SubmitChanges();
            }
        }
        public List<material> GetMaterialsBySupplierID(int supplierID)
        {
            return db.materials.Where(m => m.supplieriD == supplierID && m.ISDELETE == 0).ToList();
        }
        public List<material> FuzzySearchMaterialsByName(string searchString)
        {
            return db.materials
                .Where(m => m.Materials_Name.Contains(searchString) && m.ISDELETE == 0)
                .ToList();
        }
        // Hàm tìm kiếm gần đúng materials dựa trên tên
        public List<material> SearchMaterialsByName(string keyword)
        {
           
            var result = db.materials
                .Where(m => m.Materials_Name.Contains(keyword))
                .ToList();

            return result;
        }
        public List<material> GetMaterialsNotISdelete()
        {
            return db.materials.Where(m => m.ISDELETE == 0).ToList();
        }
        public List<material> GetMaterialsISdelete()
        {
            return db.materials.Where(m => m.ISDELETE == 1).ToList();
        }
    }
}
