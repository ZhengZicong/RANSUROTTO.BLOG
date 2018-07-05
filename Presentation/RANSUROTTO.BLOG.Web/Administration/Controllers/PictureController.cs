﻿using System.Web.Mvc;
using RANSUROTTO.BLOG.Framework.Security;
using RANSUROTTO.BLOG.Services.Media;

namespace RANSUROTTO.BLOG.Admin.Controllers
{
    public class PictureController : BaseAdminController
    {

        private readonly IPictureService _pictureService;

        public PictureController(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        [HttpPost]
        //do not validate request token (XSRF)
        [AdminAntiForgery(true)]
        public virtual ActionResult AsyncUpload()
        {
            return null;
        }

    }
}