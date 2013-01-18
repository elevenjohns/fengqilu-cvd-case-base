using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuQuan.Untility;
using System.IO;
using YuQuan.Helpers;
using FengQiLu.Models;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace FengQiLu.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private FengQiLuEntities db = new FengQiLuEntities();
        private int _pageCapactity = 15;

        public ActionResult Index(int page=1)
        {
            db.SaveChanges();

            ViewBag.TotalCase = db.CVD.Count();
            ViewBag.Page = page;
            ViewBag.TotalPage = (db.CVD.Count() - 1) / _pageCapactity + 1;
            var list = db.CVD.ToList();
            list.Reverse(); // the newest item shown on top
            return View(list.Skip((page - 1) * _pageCapactity).Take(_pageCapactity)); // 15 items on each page
        }

        // rename parameter to id to use as route data (URL segment). e.g. .../Search/Keyword
        public ActionResult Search(String keyword)
        {
            String searchString = keyword;            
            var instance = from item in db.CVD select item; //create LINQ query
            if (!String.IsNullOrEmpty(searchString))
                instance = instance.Where(s => (
                    s.Patient_Name.Contains(searchString) ||
                    s.Diagnosis.Contains(searchString) ||
                    s.Patient_Gender.Contains(searchString)));
            return View(instance);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(CVD instance)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.CVD.Add(instance);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(instance);
            }
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //    return View();
            //}
            catch
            {
                ViewBag.Message = "住院号，病人号，姓名，性别，诊断为必填项";
                return View();
            }            
        }

        public ActionResult Details(int id)
        {
            var instance = db.CVD.First(x => x.ID == id);
            return View(instance);
        }

        public ActionResult Edit(int id)
        {
            CVD instance = db.CVD.First(x => x.ID == id);
            if (instance == null)
                return RedirectToAction("Error","Home", new { message="案例不存在"});
            return View(instance);
        }

        [HttpPost]
        public ActionResult Edit(CVD instance)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (instance == null)
                        return RedirectToAction("Error", "Home", new { message = "案例不存在" });
                    db.Entry(instance).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(instance);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var instance = db.CVD.First(x => x.ID == id);
            if (instance == null)
                return RedirectToAction("Error", "Home", new { message = "案例不存在" });
            return View(instance);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id = 0)
        {
            var instance = db.CVD.First(x => x.ID == id);
            if (instance == null)
                return RedirectToAction("Error", "Home", new { message = "案例不存在" });
            db.CVD.Remove(instance);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Upload()
        {
            var str = "";
            var path = Path.Combine(Server.MapPath("~/App_Data"), "SampleSerializedData.xml");
            using (var sr = new StreamReader(path))
            {
                str = sr.ReadToEnd();
            }
            var obj = SerializationHelper.Deserialize(typeof(System.Data.DataTable), str);
            if (obj != null && obj is System.Data.DataTable)
            {
                var tbl = obj as System.Data.DataTable;
                return View(tbl);
            }
            else
            {
                return RedirectToAction("Error", "Home", new { message = "示例文件读取失败" });
            }
        }

        // This action handles the form POST and the upload
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            var path = "";

            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                var fileName = Guid.NewGuid()+"-"+ Path.GetFileName(file.FileName);
                // store the file inside ~/uploads folder
                path = Path.Combine(Server.MapPath("~/upload"), fileName);
                file.SaveAs(path);
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Import", new { path = path });
        }

        public ActionResult Import(string path)
        {
            try
            {
                var excel = new ExcelOperator(path);
                var tbl = excel.DataSetFromFile.Tables[0];
                if (tbl != null && tbl.Rows.Count>0 && tbl.Columns.Count>0)
                {
                    db.ImportCVDFromDataTable(tbl);
                    return View(tbl);
                }
                else
                    return RedirectToAction("Error", "Home", new { message = "文件格式不正确或内容不正确" });
            }
            catch
            {
                return RedirectToAction("Error", "Home", new { message = "文件格式不正确或内容不正确" });
            }
        }

        public FileResult Download()
        {
            return File(Path.Combine(Server.MapPath("~/App_Data"), "sample.xls"), "application/vnd.ms-excel");
        }

        public ActionResult Error(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        /// <summary>
        /// generate xml serialization of sample data from excel file
        /// </summary>
        /// <returns></returns>
        private string GenerateSampleData()
        {
            // sample data
            var excel = new ExcelOperator(Server.MapPath("~/App_Data") + @"/80岁冠心病随访数据.xls", 3, true);
            object obj = excel.DataSetFromFile.Tables[0];
            var str = SerializationHelper.Serialize(ref obj);
            obj = SerializationHelper.Deserialize(typeof(System.Data.DataTable), str);
            var tbl = obj as System.Data.DataTable;
            return str;
        }
    }
}
