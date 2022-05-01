using Microsoft.AspNetCore.Mvc;
using mvcCms.Models;
using System.Web.Mvc;

namespace mvcCms.Areas.Admin.Controllers
{
    // admin/post
    [RouteArea("Admin")]
    [RoutePrefix("post")]
  public class PostController : System.Web.Mvc.Controller
  {
    // GET: Admin/Post
    public IActionResult Index()
    {
      return (IActionResult)View();
    }


    //====================================================================================
    //************************************************************************************
    //====================================================================================


    // /admin/post/edit/post-to-edit
    [System.Web.Mvc.HttpGet]
    [System.Web.Mvc.Route("create")]
    [ValidateAntiForgeryToken]
    public System.Web.Mvc.ActionResult Create()
    {
      var model = new Post();
      return View(model);
    }
    
    
    [System.Web.Mvc.HttpPost]
    [System.Web.Mvc.Route("create")]
    public System.Web.Mvc.ActionResult Create(Post model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }

      //TODO: update model in data store

      return RedirectToAction("index");

    }


    //====================================================================================
    //************************************************************************************
    //====================================================================================


    // /admin/post/create/
    [System.Web.Mvc.HttpGet]
    [System.Web.Mvc.Route("edit/{id}")]
    [ValidateAntiForgeryToken]
    public System.Web.Mvc.ActionResult Edit(string id)
    {
      //TODO: to retrive the model from the data store 
      var model = new Post();
      return View(model);
    }

    // /admin/post/edit/post-to-edit
    [System.Web.Mvc.HttpGet]
    [System.Web.Mvc.Route("edit/{id}")]
    public System.Web.Mvc.ActionResult Edit(Post model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }

      //TODO: update model in data store

      return RedirectToAction("index");
    }

    //====================================================================================
    //************************************************************************************
    //====================================================================================


  }
}
