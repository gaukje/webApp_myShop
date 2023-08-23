var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//This line adds services required for handling controllers and views to the dependency injection container. It sets up 
//the application to use the MVC pattern for handling HTTP requests.

//Services:
/*"Service" refers to the components that are registered with the ASP.NET Core Dependency Injection (DI) container.
 * Services are objects that provide specific functionality and can be used throughout the application by other components.
 */

var app = builder.Build();

app.MapDefaultControllerRoute();
/*This line maps the default controller route for the application. It sets up a route that matches URLs to controller actions based on 
 * conventional patterns. For example, a URL like "/Item/List" would map to the List action in the ItemController.
 */

app.Run();
/* This line adds a middleware to the application. This middleware is the final piece in the pipeline and is responsible for handling the 
 * request and generating the response. It is executed when the pipeline reaches the end and no other middleware has handled the request.
 */

//The app.MapDefaultC... altso adds a middleware to the pipeline. This middleware handles the routing of incoming requests to the appropritte controller based on the defined routes.