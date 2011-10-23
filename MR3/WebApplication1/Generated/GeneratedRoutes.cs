//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Controllers {
    using System;
    using System.Web;
    using Castle.MonoRail;
    using Castle.MonoRail.Routing;
    using System.Runtime.InteropServices;
    
    
    public partial class TodoController {
        
        public abstract class Urls {
            
            public abstract class Index : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Index"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Index"));
                }
            }
            
            public abstract class View : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "View"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "View", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "View"));
                }
            }
            
            public abstract class New : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "New"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "New"));
                }
            }
            
            public abstract class Edit : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Edit"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Edit", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Edit"));
                }
            }
            
            public abstract class DeleteConfirmation : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "DeleteConfirmation"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "DeleteConfirmation", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "DeleteConfirmation"));
                }
            }
            
            public abstract class Create : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Create"));
                }
                
                public static TargetUrl Get(Castle.MonoRail.Model<WebApplication1.Models.Todo> todo) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Create", new System.Collections.Generic.KeyValuePair<string, string>("todo", todo.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Create"));
                }
            }
            
            public abstract class Update : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Update"));
                }
                
                public static TargetUrl Get(Castle.MonoRail.Model<WebApplication1.Models.Todo> todo) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Update", new System.Collections.Generic.KeyValuePair<string, string>("todo", todo.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Update"));
                }
            }
            
            public abstract class Delete : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Delete"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Delete", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Todo", "Delete"));
                }
            }
        }
    }
    
    public partial class HomeController {
        
        public abstract class Urls {
            
            public abstract class Index : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Home", "Index"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Home", "Index"));
                }
            }
            
            public abstract class Components : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Home", "Components"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("Home", "Components"));
                }
            }
        }
    }
    
    public partial class UserController {
        
        public abstract class Urls {
            
            public abstract class Index : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Index"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Index"));
                }
            }
            
            public abstract class View : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "View"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "View", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "View"));
                }
            }
            
            public abstract class New : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "New"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "New"));
                }
            }
            
            public abstract class Edit : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Edit"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Edit", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Edit"));
                }
            }
            
            public abstract class DeleteConfirmation : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "DeleteConfirmation"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "DeleteConfirmation", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "DeleteConfirmation"));
                }
            }
            
            public abstract class PostCreate : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "PostCreate"));
                }
                
                public static TargetUrl Get(Castle.MonoRail.Model<WebApplication1.Models.SiteUser> todo) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "PostCreate", new System.Collections.Generic.KeyValuePair<string, string>("todo", todo.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "PostCreate"));
                }
            }
            
            public abstract class PutUpdate : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "PutUpdate"));
                }
                
                public static TargetUrl Get(Castle.MonoRail.Model<WebApplication1.Models.SiteUser> todo) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "PutUpdate", new System.Collections.Generic.KeyValuePair<string, string>("todo", todo.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "PutUpdate"));
                }
            }
            
            public abstract class Delete : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Delete"));
                }
                
                public static TargetUrl Get(int id) {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Delete", new System.Collections.Generic.KeyValuePair<string, string>("id", id.ToString())));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes["default"], new Castle.MonoRail.UrlParameters("User", "Delete"));
                }
            }
        }
    }
}
namespace WebApplication1.ViewComponents.Components {
    using System;
    using System.Web;
    using Castle.MonoRail;
    using Castle.MonoRail.Routing;
    using System.Runtime.InteropServices;
    
    
    public partial class OrdersComponent {
        
        public abstract class Urls {
            
            public abstract class Refresh : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes[null], new Castle.MonoRail.UrlParameters("OrdersComponent", "Refresh"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes[null], new Castle.MonoRail.UrlParameters("OrdersComponent", "Refresh"));
                }
            }
            
            public abstract class Render : Castle.MonoRail.GeneratedUrlsBase {
                
                public static TargetUrl Get() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes[null], new Castle.MonoRail.UrlParameters("OrdersComponent", "Render"));
                }
                
                public static TargetUrl Post() {
                    return new Castle.MonoRail.RouteBasedTargetUrl(VirtualPath, CurrentRouter.Routes[null], new Castle.MonoRail.UrlParameters("OrdersComponent", "Render"));
                }
            }
        }
    }
}