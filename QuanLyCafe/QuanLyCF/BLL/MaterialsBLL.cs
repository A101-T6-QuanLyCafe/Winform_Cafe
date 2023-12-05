using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class MaterialsBLL
    {
        // Đối tượng DbContext hoặc kết nối cơ sở dữ liệu
        CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

       
        // Phương thức để lấy tất cả dữ liệu từ bảng materials
        public  DataTable GetAllMaterials()
        {
            try
            {
                var materialsQuery = from material in db.materials
                                     where material.ISDELETE == 0
                                     select material;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã nguyên liệu", typeof(int));
                dataTable.Columns.Add("Tên nguyên liệu", typeof(string));
                dataTable.Columns.Add("Giá", typeof(float));
                dataTable.Columns.Add("Mã nhà cung cấp", typeof(int));
                dataTable.Columns.Add("Số lượng tồn", typeof(int));
                dataTable.Columns.Add("Đơn vị", typeof(string));
                dataTable.Columns.Add("Mã loại", typeof(int));

                foreach (var material in materialsQuery)
                {
                    dataTable.Rows.Add(
                        material.Materials_ID,
                        material.Materials_Name,
                        material.Price,
                        material.supplieriD,
                        material.quantity,
                        material.Unit,
                        material.TypeID
                    );
                }

                return dataTable;
            }
            catch
            {
                return null;
            }
            
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
                    existingMaterial.Unit = updatedMaterial.Unit;
                    existingMaterial.ISDELETE = updatedMaterial.ISDELETE;
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
        public DataTable GetMaterialsBySupplierID(int supplierID)
        {
            
            try
            {
                var materialsQuery = db.materials.Where(m => m.supplieriD == supplierID && m.ISDELETE == 0).ToList();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã nguyên liệu", typeof(int));
                dataTable.Columns.Add("Tên nguyên liệu", typeof(string));
                dataTable.Columns.Add("Giá", typeof(float));
                dataTable.Columns.Add("Mã nhà cung cấp", typeof(int));
                dataTable.Columns.Add("Số lượng tồn", typeof(int));
                dataTable.Columns.Add("Đơn vị", typeof(string));
                dataTable.Columns.Add("Mã loại", typeof(int));

                foreach (var material in materialsQuery)
                {
                    dataTable.Rows.Add(
                        material.Materials_ID,
                        material.Materials_Name,
                        material.Price,
                        material.supplieriD,
                        material.quantity,
                        material.Unit,
                        material.TypeID
                    );
                }

                return dataTable;
            }
            catch
            {
                return null;
            }
        
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
        public DataTable GetMaterialsISdelete()
        {
            try
            {
                var materialsQuery = from material in db.materials
                                     where material.ISDELETE == 1
                                     select material;
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã nguyên liệu", typeof(int));
                dataTable.Columns.Add("Tên nguyên liệu", typeof(string));
                dataTable.Columns.Add("Giá", typeof(float));
                dataTable.Columns.Add("Mã nhà cung cấp", typeof(int));
                dataTable.Columns.Add("Số lượng tồn", typeof(int));
                dataTable.Columns.Add("Đơn vị", typeof(string));
                dataTable.Columns.Add("Mã loại", typeof(int));

                foreach (var material in materialsQuery)
                {
                    dataTable.Rows.Add(
                        material.Materials_ID,
                        material.Materials_Name,
                        material.Price,
                        material.supplieriD,
                        material.quantity,
                        material.Unit,
                        material.TypeID
                    );
                }

                return dataTable;
            }
            catch
            {
                return null;
            }

        }
    }
}
