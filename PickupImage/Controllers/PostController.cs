using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using PickupImage.DAO;
using PickupImage.Models;

namespace PickupImage.Controllers
{
    public class PostController : Controller
    {
        PostDAO dao;
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(Post entity)
        {
            dao = new PostDAO();
            bool result = dao.create(entity);
            return View(entity);
        }

        [HttpGet]
        public ActionResult edit(int id)
        {
            dao = new PostDAO();
            var model = dao.findById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult edit(Post entity)
        {
            dao = new PostDAO();
            if (ModelState.IsValid)
            {
                bool result = dao.edit(entity);
                
            }
            return View(entity);
        }

        [HttpPost]
        /// <summary>
        /// This method wil be call from client via Ajax jQuery.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public JsonResult SaveFile(HttpPostedFileBase file)
        {
            string returnImagePath = string.Empty;
            if (file.ContentLength > 0)
            {
                string fileName, fileExtension, imaageSavePath;
                fileName = Path.GetFileNameWithoutExtension(file.FileName);
                fileExtension = Path.GetExtension(file.FileName);

                imaageSavePath = Server.MapPath("/uploadedImages/") + fileName + fileExtension;
                //Save file
                file.SaveAs(imaageSavePath);

                //Path to return
                returnImagePath = "/uploadedImages/" + fileName + fileExtension;
            }
            return Json(returnImagePath, JsonRequestBehavior.AllowGet);
        }
    }
}