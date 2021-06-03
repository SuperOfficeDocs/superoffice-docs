---
title: rest
description: SuperOffice RESTful WebAPI
author: Tony Yates
so.date: 11.26.2015
keywords:
so.topic: article
so.envir: cloud
so.client: online
---

# SuperOffice RESTful WebAPI

SuperOffice REST WebAPI services available from version 8.1.

## Introduction

Representational State Transfer (REST) is an architectural pattern penned by Roy Fielding for creating an HTTP-based APIs. There are no shortage of articles online that discuss what REST is, how it's been interpreted and how it's been implemented on various platforms, and therefore will not be discussed here. This article will focus primarily on how to use consume SuperOffice REST resources, set required authentication headers, and describe how a request URL, body, and response body should appear and behave.

## Configuration

Before submitting an actual request to the webserver, we must make sure everything is configured correctly. IIS must be configured to handle all of the HTTP verbs, and NetServer must be configured to support the REST feature.

### IIS Configuration

#### Configure HTTP Action Verbs

In IIS, navigate to the application hosting SuperOffice web client or NetServer. Select it in the IIS application tree, then double-click **Handler Mappings** in the **Features View**.

In the Handler Mappings view, locate and double-click to the **ExtensionlessUrlHandler-Integrated-4.0** entry. The **Edit Managed Handler** dialog will appear. Click the **Request Restrictions** button in the Edit Managed Handler dialog to open the Request Restrictions dialog.

Click to view the **Verbs** tab in the Request Restrictions dialog. Next click the **All Verbs** option, then click **OK** to close the dialog. Close the remaining dialogs and close to exit the IIS manager.

**IIS Manager Handler Mappings:**

![x][img1]

IIS is now configured to access and process all request verbs, and therefore permit requests to create, read, update and delete via SuperOffice REST APIs.

#### Configure Basic Authentication

While API authentication is discussed below, it's important to understand how to configure IIS if you plan on using basic authentication. If you do not plan on using basic authentication, skip this sub-section.

To enable Basic Authentication for REST API, first enable basic authentication on the website root. Do this by selecting the root website, then double-click the Authentication icon in the Features View pane. With the Authentication panel shown, right-click the **Basic Authentication** option and set the status to Enabled.

![x][img2]

Next, disable Basic Authentication on the SuperOffice web application. Select the SuperOffice web application under the root website, then double-click the Authentication icon. In the Authentication panel, if the Basic Authentication status is Enabled, right-click Basic Authentication and select Disable.

![x][img3]

With Basic Authentication configured this way, any valid SuperOffice user can navigate to the REST URLs and invoke a request. To test these settings, navigate to the application's URL and attempt to get the contact where contact ID equals 1. Do that by navigating in a browser to `http://superoffice80/api/v1/contact/1` and this should result in a Credentials dialog prompting for a username and password. Any valid SuperOffice username works.

### NetServer Configuration

In the current SuperOffice installations, NetServer REST services are switched on by default and may not need to be configured. However, for the sake of knowledge, these settings are a feature that must be toggled on by adding or changing the settings in the configuration file.

Ensure the following entries in SuperOffice sectionGroup element: the [WebApi section][1].

**SuperOffice sectionGroup in web.config:**

```xml
<sectionGroup name="SuperOffice">
  <!-- possibly more sections above -->
  <section name="WebApi" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
  <!-- possibly more sections below -->
</sectionGroup>
```

Locate or add the WebApi element and set one or both keys to true to enable: AuthorizeWithUsername and AuthorizeWithTicket.

**SuperOffice element in web.config:**

```xml
<SuperOffice>
  <!--more sections above -->
  <WebApi>
    <add key="AuthorizeWithUsername" value="true" />
    <add key="AuthorizeWithTicket" value="true" />
  </WebApi>
  <!--more sections below -->
</SuperOffice>
```

Now that NetServer configuration is complete, let's dig a little deeper and learn more about submitting actual requests and authentication.

## Hello WebAPI

So now we can make our first request to the API endpoint:

```http
GET superoffice/api
HTTP/1.1Host: www.yourserver.com
```

This will request the API overview. If you use a browser to open `http://crm.example.com/superoffice/api` you will get a web page that says:

```http
HTTP/1.1 200 OK
Content-Type: text/html

SuperOffice Sales and Marketing Web API
Build date: Monday, June 26, 2017
v1 REST API + v1 Agent API
Swagger API Explorer
```

If you use [POSTMAN][2] or a similar tool, you will get back some JSON that contains the same information instead of an HTML page.

This gets us some meta-data about the API without logging in, and an indication that the API is up and running correctly.

## Authentication

SuperOffice NetServer only supports **the following first two** authentication mechanisms.

1. BASIC
2. SOTicket
3. Bearer (OAuth - for Online only)
4. X-XSRF-TOKEN (web client - cookie and hidden field)

### Authorization Header

If the web server receives an *anonymous* request for a SuperOffice resource it will force the use of **Basic** authentication by rejecting the request with a 401 (Access Denied) status code and set the WWW-Authenticate response header as shown below:

```http
HTTP/1.1 401 Unauthorized
WWW-Authenticate: Basic realm="SuperOffice Username or Ticket"
Content-Length: 300
```

Most web browsers will display a login dialog when this response is received, allowing the user to enter a username and password. This information is then used to retry the request with an Authorization request header:

```http
GET superoffice/api/v1/person/5 
HTTP/1.1Host: www.yourserver.com 
Authorization: Basic fGj1cKefdPUdDMr=
```

The response body contains the following helper text:

```html
Use the HTTP <code>Authenticate</code> header to log in.<br/>
<p>BASIC scheme with Base64 encoded SuperOffice username:password.</p>
<p>SOTICKET scheme with the SuperOffice ticket (7T:abc123==) without any encoding.</p>
<p>BEARER scheme with OAuth access token AbCXyz123== returned from SuperId.</p>
```

The `Authorization` header specifies the authentication mechanism, in this case, *Basic*, followed by the username and password. Although, the string `aHR0cHdhdGNoOmY=` may look encrypted it is not. It is a base64 encoded version of `<username>:<password>`.

If the web application calling SuperOffice REST services already has a current users' ticket, which may have been passed to the web application as a template variable in a SuperOffice web panel, the request could use the *SOTicket* authentication mechanism instead of *Basic*.

```http
GET superoffice/api/v1/person/5 
HTTP/1.1 Host: www.yourserver.com 
Authorization: SOTicket 7:HlksdjfLKJlkjKJHKJhkjHKJHiuhuYGHGFgdttGVuYGuR&R&f==
```

Given an HTML form that contains three text box controls for: username, password, and ID, the following example demonstrates how an XMLHttpRequest is used to call to the project resource to get a project by a given ID value.

**Example HTML / Javascript method:**

```html
<script>
   
   function onGetId(f)
   {      
      var user = document.getElementById("user").value;
      var pass = document.getElementById("pass").value;
      var project = document.getElementById('projectid');
      var projectid = project.value;

      var url = ur"https://server/SuperOffice/api/v1/project/" + projectid;
      
      var req = new XMLHttpRequest();
      req.responseType = "json";
      req.open( "GET", url, true);
      req.withCredentials = true;
      req.setRequestHeader("Authorization", "Basic " + btoa(user + ":" + pass))
      req.onload = function() { onGetProject(req.response ); };
      req.onerror = function() { alert( "Request Error - check Console for details." ); };
      req.send();
      
      // Don't submit form
      return false;
   }
   
   function onGetProject(proj)
   {
     var n = document.getElementById('project_name');
     var ti = document.getElementById('project_typeid');
     var tn = document.getElementById('project_typename');
     
     n.value = proj.Name;
     ti.value = proj.ProjectType.Id;         
     tn.value = proj.ProjectType.Value;
   }

</script>
```

Notice how the setRequestHeader method takes 2 arguments: the Authorization key and the authentication mechanism. Note that the [btoa method][3] base64 encodes a string. It's not something we've created. but built into the browser's window class and supported by all browsers. There is also the `atob` method which decoded a base64 encoded value to a normal string.

### XSRF Token

The [XSRF token][4] only works when code exists in the client and is able to execute on the same domain. This is used by the client to stop **cross-site request forgery**. The XSRF token is accessible in the cookie or a hidden input field on the web client, called XSRF\_TOKEN. With the token, calls can be made to the web API without an authenticate header - use the **X-XSRF-TOKEN** header instead. The xsrf value is set on login. It does not change until the next login.

That's pretty much all there is to know for SuperOffice REST services authentication. Now lets' focus on how to create, read, update and delete known entities.

#### Supported CRUD Operations

The SuperOffice REST API depends on the SuperOffice SOAP service layer. The SuperOffice REST API takes full advantage of the existing SOAP functionality to support Create, Read, Update and Delete (CRUD) operations for all entity types, list items, and more.

**SuperOffice API layer diagram:**

![x][img4]

This means that when you ask for resources using the REST API, the framework is calling into the NetServer web services API for executing the request. Take the following resource request for example.

```http
GET /api/v1/Appointment/123
```

Underneath the covers, this call is actually invocating the AppointmentAgent GetAppointmentEntity web service method. The following example displays a few more examples of how the API calls into NetServers web service infrastructure.

**Example REST resources and Wcf method invocations:**

| | REST resource| WFC method |
|-|---|---|
| GET | /api/v1/Appointment/123 | AppointmentService.GetAppointmentEntity(123) |
| PUT | /api/v1/Appointment/123 | AppointmentServices.SaveAppointmentEntity(123) |
| GET | /api/v1/Lists/Category | ListService.GetCategories() |
| GET | /api/v1/Lists/Category/123 | ListService.GetFromListDefinition(-64, 123) |

## REST Documentation

Navigate to the **API root** and see available REST service versions.

**REST API root in a browser:**

![imagebr9pi.png][img5]

While you can click the links on the page to view the REST API endpoints, we recommend you use the published REST documentation here for the pure [REST API][4]; and one for the [RESTful Agents API][6].

![image09ess.png][img6]

**Available actions for the Person resource:**

![image8th4dv.png][img7]

### Interactive Documentation

Every REST endpoint supports dynamic invocation towards an online test database that is reset each night.

![image12qvq.png][img8]

## Content Negotiation

You can specify what format of data you get back by sending either an Accept or Content-Type HTTP header.

```http
GET http://localhost/SuperOffice80/api/v1/Person/15 HTTP/1.1
Authorization: Basic QWRtMDo=
Host: localhost
Content-Type: application/json; charset=utf-8
```

When issuing the request with an Content-Type of *application/json*, the response will return JSON:

![x][img9]

If instead, the request contains a Content-Type or Accept header of *text/xml*, then the response will contain as expected XML.

```http
GET http://localhost/SuperOffice80/api/v1/Person/15 HTTP/1.1
Authorization: Basic QWRtMDo=
Host: localhost
Content-Type: text/xml; charset=utf-8
```

**Response in XML:**

![x][img10]

## Complex Queries with OData

[Wikipedia][7] states OData "is an open protocol which allows the creation and consumption of queryable and interoperable RESTful APIs in a simple and standard way."

In addition to constructing [complex queries on entities][8], our APIs expose the /api/v1/archives resource for even more advanced OData queries. This means it's possible to construct complex queries that are pre-filtered on the server, allowing you to focus on processing only the information you want.

Let's look at a simple example:

```http
http://localhost/SuperOffice80/api/v1/contact/?$select=name, department&$filter=name begins 'S'
```

The example queries the contact service, asks for the contact name and department columns, and adds a filter criterion to restrict the results to only return contacts where the name begins with 'S'.

**OData query results:**

![x][img11]

### OData System Query Options

SuperOffice implements support for the following OData System Query Options:

* $filter
* $orderby
* $top
* $skip
* $select

Use an ampersand to separate query options, just like you might do with URL query strings.

```http
../api/v1/contact/?$select=name, department&$filter=name begins 'S'&$orderby=name&$top=2
```

SuperOffice supports a variety of restriction operators. Certain operators work only one, or more, data types. For example, while *is* will work with operands of type integer and string, it will not work with data types of type date or list. Below are the most common operators used in constructing filters.

**OData Filter Expressions - OData datatype:**

| Operator | Description |
|----------|-------------|
| eq or = | Equal to |
| ne | Not equal to |
| le or <= | Less than or equal to |
| ge or >= | Greater than or equal to |

**OData Filter Expressions - Integer datatype:**

| Operator | Description |
|----------|-------------|
| set | Is True |
| equals | Is equal to |
| greater | Greater than |
| less | Is less than |
| unequal | In not equal to |
| between | Is between |
| begins | Begins with |
| contains | Does contain |
| is | Is equal to |
| notbegins | Does not begin with |
| notcontains | Does not contain |
| isnot | Is not equal to |

**OData Filter Expressions - String datatype:**

| Operator | Description |
|----------|-------------|
| begins | Begins with  |
| contains | Does contain |
| is | Is equal to |
| notbegins | Does not begin with |
| notcontains | Does not contain |
| isnot | Is not equal to |

**OData Filter Expressions - Dates datatype:**

| Operator | Description |
|----------|-------------|
| before | Is before date  |
| date | Is on date |
| after | Is after date |
| datebetween | Is between two dates |

**OData Filter Expressions - Lists datatype:**

| Operator | Description |
|----------|-------------|
| oneof | Is one of  |
| notoneof | Is not one of |
| is | Is equal to |

**OData Filter Expressions -  Associate datatype:**

| Operator | Description |
|----------|-------------|
| associateisoneof | The associate is one of  
| associateisnotoneof | The associate is not one of |

### Query Field Conventions

Query fields in NetServer archives contain a forward slash separation character. For example:

```text
streetAddress/addressId
streetAddress/line1
streetAddress/line2
streetAddress/line3
```

When used in OData queries, use 3 underscore characters instead. For example:

```http
../api/v1/contact/?$select=nameDepartment, category, postAddress___city, code&$top=2
```

**OData Query Results with sub field:**

![x][img14]

### Implicit Filters

All entity REST services expose the ability to query for a specific instance. For example:

```http
./api/v1/contact/123
```

This implies NetServer to add the following filter:

../api/v1/contact?$select=name&$filter=contactId=123

When used, the implicit filter is an easy way to drill into related entities. For example:

```http
/api/v1/Contact/123/Persons
/api/v1/Contact/123/Appointments
/api/v1/Contact/123/Documents
/api/v1/Contact/123/Projects
/api/v1/Contact/123/Sales
```

Each one of the examples will return the related entities for contact with `contactId` equal to 123.

## Binary Data

Person, Project, and Product Image data is just content that can be GET or POST without the need to wrap it in XML. For example:

```http
/api/v1/Person/123/image
/api/v1/Project/123/image
/api/v1/Product/123/image
```

Each one of these calls, if issued in a GET call, returns the image associated with each one accordingly. If not image can be found, the resulting message will say just that "Image not found".

![x][img13]

### Optional Parameters

GET takes the following extra parameters:

* W=100&H=200
* Type=JPEG or PNG or GIF
* ifBlank=ClearPixel or SrNoPhoto

The width and height parameters will scale the image to a specified size.

The type parameter returns the desired image format.

The `ifBlank` parameter will return with a transparent 1x1 px png, or an image that states no photo if the result is no image exists, and instead of the "Image not found" message:

![x][img14]

### Upload Example

This example uses the below form, which using a multipart/form-data enctype to upload an image to the project. It specifies a default project identity of 23 but will update the `projectId` when something else is typed into the project Id input field. The chose file button opens a select image file dialog, permitting the user to select an image. When the Upload Project Image button is clicked, the forms' onsubmit event is raised and updates the action URL with the current project identity.

**Example upload form:**

![x][img15]

Once the form has been successfully submitted, and the REST services have completed, the browser is redirected and shows the binaryobject identity:

```html
<!DOCTYPE html>
<html>
<head>
    <title>Image Upload</title>
    <script>
 
        var projectId = 23; //random default
 
        function updateProjectId(input) {
            //should validate its a valid number
            projectId = Number(input.value);
        }
 
        function onUploadImage(form) {
            var actionUrl = "http://localhost/superoffice80/api/v1/project/" +
                            projectId + "/image";
            form.action = actionUrl;
        }
 
        function onGetId(button) {
            var actionUrl = "http://localhost/superoffice80/api/v1/project/" + 
                            projectId + "/image?ifBlank=2";
            button.form.action = actionUrl;
            var img = document.getElementById('projectimg')
            img.src = actionUrl;
            return false;
        }
 
    </script>
</head>
<body>
    <h1>Images</h1>
    <img id='projectimg' src=''>
 
    <form id='formUpload' onsubmit="return onUploadImage(this)" action="#" method="post" 
          enctype="multipart/form-data">
        <fieldset>
            <legend>Project Information</legend>
            <br />
            Project Id:<br />
            <input id='projectid' name='projectid' value='23' 
                   onkeyup="updateProjectId(this)">
            <br /><br />
            <button type="submit" formaction="#" formmethod="get" 
                    onclick="return onGetId(this)">Get Image</button>
            <br /><br />
            Project Image: <br />
            <input accept="image/*" id="projectImg" name='projectimg' type="file">
            <br /><br />
            <button type="submit">Upload Project Image</button>
        </fieldset>
    </form>
</body>
</html>
```

**Post form submission result:**

![x][img16]

## Conclusion

SuperOffice REST services add another API surface to the NetServer real estate, offering a great deal of information in a highly desired format. Although incomplete, it should suffice for a majority of REST consumers and will evolve as demand increase.

Take your time getting to know SuperOffice REST services, and if you happen to stumble into an area that lacks support, please submit an email to sdk@superoffice.com with your API wishes.
<!-- Referenced links -->
[1]: ../../netserver/config/webapi.md
[2]: https://www.getpostman.com/
[3]: http://www.w3schools.com/jsref/met_win_btoa.asp
[4]: index.md
[6]: agents/index.md
[7]: https://en.wikipedia.org/wiki/Open_Data_Protocol
[8]: ../../netserver/search/odata/index.md

<!-- Referenced images -->
[img1]: media/iis-configuration.png
[img2]: media/websiteauthentication.png
[img3]: media/soapplicationauthentication.png
[img4]: media/rest-layers.png
[img5]: media/imagebr9pi.png
[img6]: media/image09ess.png
[img7]: media/image8th4dv.png
[img8]: media/image12qvq.png
[img9]: media/rest-1.png
[img10]: media/rest-2.png
[img11]: media/rest-3.png
[img12]: media/rest-4.png
[img13]: media/rest-5.png
[img14]: media/rest-6.png
[img15]: media/imagesupload.png
[img16]: media/rest-7.png
