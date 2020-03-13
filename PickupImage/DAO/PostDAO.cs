using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PickupImage.Models;

namespace PickupImage.DAO
{
    public class PostDAO
    {
        pickupimageDb db;

        public PostDAO()
        {
            db = new pickupimageDb();
        }


        /// <summary>
        /// Create new Post
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool create(Post entity)
        {
            try
            {
                db.Posts.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// For edit existing Post
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool edit(Post entity)
        {
            try
            {
                var model = db.Posts.Find(entity.id);
                model.title = entity.title;
                model.Content = entity.Content;
                model.ImagePath = entity.ImagePath;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Find Post object by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Post findById(int id)
        {
            Post model = db.Posts.Find(id);
            return model;
        }

    }
}