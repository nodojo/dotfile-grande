
/**
 * Realm
 ***********/
public JsonResult SiteMap()
{
   var controllerActions = new List<Dictionary<string, string>>();
   var allController = from controllers in Assembly.GetExecutingAssembly().GetTypes().Where(type => typeof(Controller).IsAssignableFrom(type)) select controllers;
   foreach (var controller in allController)
   {
       var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance);
       foreach (var method in methods)
       {
           if (method.ReturnType == typeof(ActionResult))
           {
               var model = new Dictionary<string, string>();
               model["Controller"] = controller.Name;
               model["Action"] = method.Name;
               controllerActions.Add(model);
           }
       }
   }
   return Json(controllerActions, JsonRequestBehavior.AllowGet);
}


/**
 * Missioninsite
 ******************/
public JsonResult SiteMap()
{
       var controllerActions = new List<Dictionary<string, string>>();
       var allController = from controllers in Assembly.GetExecutingAssembly().GetTypes().Where(type => typeof(Controller).IsAssignableFrom(type)) select controllers;
       foreach (var controller in allController)
       {
           var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance);
           foreach (var method in methods)
           {
               //if (method.ReturnType == typeof(ActionResult) || method.ReturnType == typeof(Task<ActionResult>))
               if (method.ReturnType == typeof(Task<IActionResult>))
               {
                   var model = new Dictionary<string, string>();
                   model["Controller"] = controller.Name;
                   model["Action"] = method.Name;
                   controllerActions.Add(model);
                   System.Console.WriteLine(controller.Name + "/" + method.Name);
               }
           }
       }
       return Json(controllerActions);
}
