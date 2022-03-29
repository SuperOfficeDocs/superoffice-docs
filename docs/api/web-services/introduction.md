# Placeholder TBD

Contains:

* Authentication
* Authorization headers
* Example Javascript XMLHttpRequest
* XSRF token
* REST vs WCF method invocations
* REST Documentation
* REST API root in a browser
* Complex queries with OData
* OData filters
* Binary data

## Authentication

SuperOffice NetServer supports only **the following first two** authentication mechanisms.

1. BASIC
2. SOTicket
3. Bearer (OAuth - for Online only)
4. X-XSRF-TOKEN (web client - cookie and hidden field)

### Authorization header

If the web server receives an *anonymous* request for a SuperOffice resource it will force the use of **Basic** authentication by rejecting the request with a **401 (Access Denied)** status code and setting the **WWW-Authenticate** response header:

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
<p>BEARER scheme with OAuth access token AbCXyz123== returned from SuperID.</p>
```

The `Authorization` header specifies the authentication mechanism, in this case, *Basic*, followed by the username and password. Although, the string `aHR0cHdhdGNoOmY=` may look encrypted it is not. It is a base64 encoded version of `<username>:<password>`.

If the web application calling SuperOffice REST services already has a current users' ticket, which may have been passed to the web application as a template variable in a SuperOffice web panel, the request could use the *SOTicket* authentication mechanism instead of *Basic*.

```http
GET superoffice/api/v1/person/5 
HTTP/1.1 Host: www.yourserver.com 
Authorization: SOTicket 7:HlksdjfLKJlkjKJHKJhkjHKJHiuhuYGHGFgdttGVuYGuR&R&f==
```

Given an HTML form that contains three text-box controls for username, password, and ID, the following example demonstrates how an XMLHttpRequest is used to call to the project resource to get a project by a given ID value.

**Example HTML / JavaScript method:**

```html
<script>
  function onGetId(f)
  {
    var user = document.getElementById("user").value;
    var pass = document.getElementById("pass").value;
    var project = document.getElementById('projectid');
    var projectid = project.value;
    var url = "https://server/SuperOffice/api/v1/project/" + projectid;
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

> [!NOTE]
> The `setRequestHeader` method takes two arguments: the Authorization key and the authentication mechanism.
>
> The [btoa method][3] base64 encodes a string. It's not something we've created. but built into the browser's window class and supported by all browsers. There is also the `atob` method, which decodes a base64 encoded value to a normal string.

### XSRF token

The [XSRF token][4] works only when code exists in the client and can execute on the same domain. This is used by the client to stop **cross-site request forgery**. The XSRF token is accessible in the cookie or a hidden input field on the web client, called XSRF_TOKEN. With the token, calls can be made to the web API without an authenticate header - use the **X-XSRF-TOKEN** header instead. The xsrf value is set on login. It does not change until the next login.

That's pretty much all there is to know for SuperOffice REST services authentication. Now lets' focus on how to create, read, update and delete known entities.

#### Supported CRUD operations

The SuperOffice REST API depends on the SuperOffice SOAP service layer. The SuperOffice REST API takes full advantage of the existing SOAP functionality to support Create, Read, Update and Delete (CRUD) operations for all entity types, list items, and more.

**SuperOffice API layer diagram:**

![SuperOffice API layer diagram][img4]

This means that when you ask for resources using the REST API, the framework is calling into the NetServer web services API for executing the request. Take the following resource request for example.

```http
GET /api/v1/Appointment/123
```

Underneath the covers, this call is actually invocating the AppointmentAgent `GetAppointmentEntity` web service method. The following example displays a few more examples of how the API calls into NetServers web service infrastructure.

**Example REST resources and WCF method invocations:**

| | REST resource| WFC method |
|-|---|---|
| GET | /api/v1/Appointment/123 | AppointmentService.GetAppointmentEntity(123) |
| PUT | /api/v1/Appointment/123 | AppointmentServices.SaveAppointmentEntity(123) |
| GET | /api/v1/Lists/Category | ListService.GetCategories() |
| GET | /api/v1/Lists/Category/123 | ListService.GetFromListDefinition(-64, 123) |

## REST Documentation

Navigate to the **API root** and see available REST service versions.

**REST API root in a browser:**

![REST API root in a browser -screenshot][img5]

While you can click the links on the page to view the REST API endpoints, we recommend you use the published REST documentation here for the pure [REST API][4]; and one for the [RESTful Agents API][6].

![REST API reference -screenshot][img6]

**Available actions for the Person resource:**

![REST Person API reference -screenshot][img7]

### Interactive Documentation

Every REST endpoint supports dynamic invocation towards an online test database that is reset each night.

![image12qvq.png][img8]

## Content negotiation

You can specify what format of data you get back by sending either an [Accept][9] or [Content-Type][10] HTTP header.

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

## Complex queries with OData

[Wikipedia][7] states OData "is an open protocol which allows the creation and consumption of queryable and interoperable RESTful APIs in a simple and standard way."

In addition to constructing [complex queries on entities][8], our APIs expose the /api/v1/archives resource for even more advanced OData queries. This means it's possible to construct complex queries that are pre-filtered on the server, allowing you to focus on processing only the information you want.

Let's look at a simple example:

```http
http://localhost/SuperOffice80/api/v1/contact/?$select=name, department&$filter=name begins 'S'
```

The example queries the contact service, asks for the contact name and department columns, and adds a filter criterion to restrict the results to only return contacts where the name begins with 'S'.

**OData query results:**

![OData query results][img11]

### OData system query options

SuperOffice implements support for the following OData system query options:

* $filter
* $orderby
* $top
* $skip
* $select

Use an **ampersand** to separate query options, just like you might do with URL query strings.

```http
../api/v1/contact/?$select=name, department&$filter=name begins 'S'&$orderby=name&$top=2
```

SuperOffice supports a variety of restriction operators. Certain operators work only one, or more, data types. For example, while *is* will work with operands of type integer and string, it will not work with data types of type date or list. Below are the most common operators used in constructing filters.

#### OData filter expressions - OData datatype

| Operator | Description |
|---|---|
| eq or = | Equal to |
| ne | Not equal to |
| le or <= | Less than or equal to |
| ge or >= | Greater than or equal to |

#### OData filter expressions - Integer datatype

| Operator | Description |
|---|---|
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

#### OData filter expressions - String datatype

| Operator | Description |
|---|---|
| begins | Begins with  |
| contains | Does contain |
| is | Is equal to |
| notbegins | Does not begin with |
| notcontains | Does not contain |
| isnot | Is not equal to |

#### OData filter expressions - Dates datatype

| Operator | Description |
|---|---|
| before | Is before date  |
| date | Is on date |
| after | Is after date |
| datebetween | Is between two dates |

#### OData filter expressions - Lists datatype

| Operator | Description |
|---|---|
| oneof | Is one of  |
| notoneof | Is not one of |
| is | Is equal to |

#### OData filter expressions -  Associate datatype

| Operator | Description |
|---|---|
| associateisoneof | The associate is one of  
| associateisnotoneof | The associate is not one of |

### Query field conventions

Query fields in NetServer archives contain a **forward slash** separation character. For example:

```text
streetAddress/addressId
streetAddress/line1
streetAddress/line2
streetAddress/line3
```

When used in OData queries, use **3 underscore characters** instead. For example:

```http
../api/v1/contact/?$select=nameDepartment, category, postAddress___city, code&$top=2
```

**OData query results with sub-field:**

![OData query results][img12]

### Implicit filters

All entity REST services expose the ability to query for a specific instance. For example:

```http
./api/v1/contact/123
```

This implies NetServer to add the following filter:

```http
../api/v1/contact?$select=name&$filter=contactId=123`
```

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

Person, Project, and Product image data is just content that can be GET or POST without the need to wrap it in XML. For example:

```http
/api/v1/Person/123/image
/api/v1/Project/123/image
/api/v1/Product/123/image
```

Each one of these calls, if issued in a GET call, returns the image associated with each one accordingly. If no image can be found, the resulting message will say just that "Image not found".

```http
{
  $type: "System.Web.Http.HttpError, System.Web.Http."
  Message: "Image not found"
}
```

### Optional parameters

GET takes the following extra parameters:

* W=100&H=200
* Type=JPEG or PNG or GIF
* ifBlank=ClearPixel or SrNoPhoto

The width and height parameters will scale the image to a specified size.

The type parameter returns the desired image format.

The `ifBlank` parameter will return with a transparent 1x1 px png, or an image that states no photo if the result is no image exists, and instead of the "Image not found" message:

![Image that states no photo -screenshot][img14]

### Upload example

This example uses the below form, which uses a multipart/form-data enctype to upload an image to the project. It specifies a default project identity of 23 but will update the `projectId` when something else is typed into the project Id input field. The choose file button opens a select image file dialog, permitting the user to select an image. When the Upload Project Image button is clicked, the forms' onsubmit event is raised and updates the action URL with the current project identity.

**Example upload form:**

![Example upload form -screenshot][img15]

Once the form has been successfully submitted, and the REST services have completed, the browser is redirected and shows the binaryobject identity:

[!code-html[HTML](includes/image-upload-form.html)]

**Post form submission result:**

![Post form submission result -screenshot][img16]