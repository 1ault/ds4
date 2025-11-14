---
title: "CS ASP.Net Web Aplication (.NET Framework)"
date_create: 12-11-2025
author: "tuzikuz"
date_update: 14-11-2025
tags:
  - Markdown
  - C#
  - CS
  - ASP.Net
  - .NET
documentclass: report
top-level-division: section
---

# CS ASP.Net Web Aplication (.NET Framework)

## Templates

### 1 Blank solution
![dark_blank_solution](./../../../assets/cs/visual_studio/dark_blank_solution.png)


### 2 Add new project
**Solution Explorer** > `**Solution name**` > **(Anti-click)**


![dark_add_new_project](./../../../assets/cs/visual_studio/dark_add_new_project.png)

#### 2.1 Add ASP.NET Web Application (.Net Framework)
![dark_asp_net_web_application](./../../../assets/cs/visual_studio/dark_asp_net_web_application.png)

![dark_aspnet_mvc](./../../../assets/cs/visual_studio/dark_aspnet_mvc.png)

![dark_aspnet_web_api](./../../../assets/cs/visual_studio/dark_aspnet_web_api.png)

## Template Web Database config

**Error: config**
```sh
cd "$env:ProgramFiles\IIS Express"
.\appcmd set config /section:system.webServer/directoryBrowse /enabled:true
.\appcmd.exe set config /section:system.webServer/directoryBrowse /enabled:true
```
**Solution Explorer** > Web.Config > **Code**.**\<configuration>**

**SQL Server**
```html
<configuration>

	<connectionStrings>
		<add name="db.Name"
			 connectionString="Data Source=.; Initial Catalog=northwind; Integrated Security=True; Encrypt=False; TrustServerCertificate=True;"
			 providerName="System.Data.SqlClient"/>
	</connectionStrings>
```

**Express SQL (No Tested)**
```html
	<connectionStrings>
		<add name="db.Name"
		ConnectionString="data source=SQLEXPRESS;initial catalog=northwind; persist security info=True; Integrated Security=SSPI;"/>
	</connectionStrings>
```


**Solution Explorer** > Default.aspx

**SQL Server**
```sh
<asp:SqlDataSource ID="MyDataSource1" runat="server"
    ConnectionString="Data Source=.;Initial Catalog=northwind;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"
    ProviderName="System.Data.SqlClient"
    SelectCommand="SELECT ProductId, ProductName, UnitPrice FROM Products"
    UpdateCommand="UPDATE Products SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductId]=@ProductId">
</asp:SqlDataSource>
```

**Solution Explorer** > Default.aspx > **Full example**

**SQL Server**
```sh
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio171._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="row">

        <div>
              <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
                AllowSorting="True" AllowPaging="True"
                DataKeyNames="ProductID"
                AutoGenerateEditButton="True"
                Runat="Server" />


            <asp:SqlDataSource ID="MyDataSource1" runat="server"
                ConnectionString="Data Source=.;Initial Catalog=northwind;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT ProductId, ProductName, UnitPrice FROM Products"
                UpdateCommand="UPDATE Products SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductId]=@ProductId">
            </asp:SqlDataSource>
        </div>

        </div>
    </main>

</asp:Content>
```



## Template Web Api Reply

### 1 Web API template
![cs_visual_estudio_aspnet_mvc](./../../../assets/cs/visual_studio/dark_aspnet_web_api.png)

### 2 Replay cs
**Solution Explorer** > ./Models/WS > (Anti-click) > add > **class...** > Reply.cs


![dark_add_class](./../../../assets/cs/visual_studio/dark_add_class.png)

![dark_add_class_reply](./../../../assets/cs/visual_studio/dark_add_class_reply.png)

![dark_add_class_reply_name](./../../../assets/cs/visual_studio/dark_add_class_reply_name.png)

**Solution Explorer** > ./Models/WS/Reply.cs > **Code**
```cs
public class Reply
{
    public int Result { get; set; }
    public Object Data { get; set; }
    public string Message { get; set; }
}
```

### 3 Config App_Start/WebApiConfig.cs
**Solution Explorer** > ./App_Start/WebApiConfig.cs > **Code**
```cs
public static class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        // Web API configuration and services

        // Web API routes
        config.MapHttpAttributeRoutes();

        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );

        // force JSON responses
        var json = config.Formatters.JsonFormatter;
        config.Formatters.Remove(config.Formatters.XmlFormatter);
    }
}
```


### 4 AccessController

**Solution Explorer** > ./Controllers/ > (Anti-click) > add > Web API 2 Controller - Empty >  **AccessController**


![dark_add_controller](./../../../assets/cs/visual_studio/dark_add_controller.png)


![cs_visual_estudio_aspnet_mvc](./../../../assets/cs/visual_studio/dark_web_api_2_controller_empty.png)


**Solution Explorer** > ./Controllers/AccessController.cs
> **Code**

```cs
public class AccessController : ApiController
{
    [HttpGet]
    public Reply HelloWorld()
    {
        return new Reply
        {
            Result = 1,
            Data = {},
            Message = "Mi Hello World en API"
        };
    }
}
```

### 5 Run

**Run**

![Run lls Express](./../../../assets/cs/visual_studio/dark_web_api_run.png)

**Go to Api**

![cs_visual_estudio_aspnet_mvc](./../../../assets/cs/visual_studio/dark_web_api_page.png)

**Go to Api > GET api/Access/HelloWold**

![cs_visual_estudio_aspnet_mvc](./../../../assets/cs/visual_studio/dark_web_api_page_access_hello_world.png)

**Go to Api > GET api/Access/HelloWold > Info**

![cs_visual_estudio_aspnet_mvc](./../../../assets/cs/visual_studio/dark_web_api_page_access_hello_world_json.png)








### 6 Postman

![white_postman](./../../../assets/cs/visual_studio/white_postman.png)

**New http**

![dark_postman_new_http](./../../../assets/cs/visual_studio/dark_postman_new_http.png)



**Copy and Replace the port**

![dark_generate_port](./../../../assets/cs/visual_studio/dark_generate_port.png)

https://localhost:`<Port>`/api/Access/HelloWorld

My: **https://localhost:44393/api/Access/HelloWorld**

**Paste in Postman And Send**

![cs_visual_studio_dark_generate_port](./../../../assets/cs/visual_studio/dark_postman_new_http_paste_url.png)




### 7 MVC Api (Consume)

![cs_visual_studio_cs_visual_estudio_aspnet_mvc](./../../../assets/cs/visual_studio/dark_aspnet_mvc.png)



**Solution Explorer** > `**Solution name**` > `**Project name**` > **(Anti-click)** > add > add_folder > **Services**

![cs_visual_studio_dark_add_folder](./../../../assets/cs/visual_studio/dark_add_folder.png)

### 7.1 Api.cs

**Solution Explorer** > `**Solution name**` > add > ./Services/Api.cs

![cs_visual_studio_dark_add_folder](./../../../assets/cs/visual_studio/dark_add_class.png)

**Gui** > **Tools** > **NuGet Package Manager** > **Newtonsoft.json**

![nuget_package_manager_menu](./../../../assets/cs/visual_studio/nuget_package_manager_menu.png)

![nuget_package_manager_menu_add_Newtonsoft.json](./../../../assets/cs/visual_studio/nuget_package_manager_menu_add_Newtonsoft-json.png)

```cs
public static class Api
{

    private static readonly string BaseUrl = "https://localhost:44393/";

    private static readonly HttpClient _httpClient;

    static Api()
    {
        ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

        var handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (m, c, ch, e) => true
        };

        _httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(BaseUrl),
            Timeout = TimeSpan.FromSeconds(15)
        };
    }

    public static async Task<T> Get<T>(string relativePath)
    {
        var json = await _httpClient.GetStringAsync(relativePath);
        return JsonConvert.DeserializeObject<T>(json);
    }
}
```

## 7.2 ValuesControls

**Solution Explorer** > `**Solution name**` > `**Project name**` > **(Anti-click)** > add > Controllers/ValuesController.cs

```cs
public class ValuesController : Controller
{
    // GET: Value
    // GET /Values/Index
    // calls https://localhost:44305/api/values/get
    public async Task<ActionResult> Index()
    {
        var items = await Api.Get<string[]>("api/values/get");
        return View(items);
    }

    // GET /Values/Details/1
    // calls https://localhost:44305/api/value/get/1
    [HttpGet]
    public async Task<ActionResult> Details(int id = 1)
    {
        var item = await Api.Get<string>($"api/Values/get/{id}");
        return View(model: item);
    }
}
```
## 7.3 View/Shared/_Layout.cshtml

**Solution Explorer** > `**Solution name**` > `**Project name**` > View/Shared/_Layout.cshtml

**Important Part for ./Controllers/Values/Details/1**

**https://localhost:44303/Values/Details/1**

```html
<li>@Html.ActionLink("Consume", "Details", "Values", new { id = 1 },  new { @class = "nav-link" })</li>
```

**Important Part for ./Controllers/Values/Index/**

**https://localhost:44303/Values**
```html
<li>@Html.ActionLink("Consume", "Index", "Values", new { area = "" }, new { @class = "nav-link" })</li>
```

```html
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            @Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li>@Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { @class = "nav-link" })</li>
                    <li>@Html.ActionLink("About", "About", "Home", new { area = "" }, new { @class = "nav-link" })</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home", new { area = "" }, new { @class = "nav-link" })</li>
                    <li>@Html.ActionLink("Consume", "Details", "Values", new { id = 1 },  new { @class = "nav-link" })</li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required: false)
</body>
</html>
```
## 7.4 View/Values/Details && index


./View/Values/Index && Details <--Relation--> ./Controllers/ValuesController.cs

**Solution Explorer** > `**Solution name**` > `**Project name**` > View/Values/Index.cshtml > Code

```html
@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
</head>
<body>
    <div>
        @model string[]
        <h2>All Values</h2>
        <ul>
            @foreach (var v in Model){<li>@v</li>}
        </ul>
    </div>
</body>
</html>
```

**Solution Explorer** > `**Solution name**` > `**Project name**` > View/Values/Details.cshtml > Code

```html
@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
</head>
<body>
    <div>
        @model string
        <h2>Value Details</h2>
        <p>@Model</p>
    </div>
</body>
</html>
```

## Result

![run](./../../../assets/cs/visual_studio/dark_web_api_run.png)

### Api Shared

**https://localhost:44393/api/Values/get**

**https://localhost:44393/api/Values/get/1**

![Result](./../../../assets/cs/visual_studio/result_1_1.png)

![Result](./../../../assets/cs/visual_studio/result_1_2.png)

![Result](./../../../assets/cs/visual_studio/result_1_3.png)

![Result](./../../../assets/cs/visual_studio/result_1_4.png)

### Consume All

**https://localhost:44301**

**https://localhost:44301/Values**

![Result](./../../../assets/cs/visual_studio/result_2_1.png)

![Result](./../../../assets/cs/visual_studio/result_2_2.png)

### Consume One

**https://localhost:44303**

**https://localhost:44303/Values/Details/1**

![Result](./../../../assets/cs/visual_studio/result_3_1.png)


![Result](./../../../assets/cs/visual_studio/result_3_3.png)


![Result](./../../../assets/cs/visual_studio/result_3_2.png)

### Postman

https://localhost:`<Port>`/api/Access/HelloWorld

My: **https://localhost:44393/api/Access/HelloWorld**

![Result](./../../../assets/cs/visual_studio/result_4_1.png)

![Result](./../../../assets/cs/visual_studio/result_4_2.png)

![Result](./../../../assets/cs/visual_studio/result_4_3.png)


### How Work Diagram ref

![Result](./../../../assets/cs/visual_studio/api.png)


## References

<!--[^DS4_Lab_19_Regis_Rivera]: **DS4-Lab-19.pdf** — Regis Rivera.-->

**DS4-Lab-19.pdf** — Regis Rivera.
