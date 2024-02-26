# SuperOffice Agent API v1
## v1-Agents
 
# Welcome 
Welcome to the SuperOffice Agents WebAPI.

You can get the version number and build-date from the API endpoint.

    /api

Returns a block with the supported versions, and the NetServer version number.

```javascript
    { "v1": "http://www.example.com/crm/api/v1",
      "NetServerVersion": "8.8.6352.1249",
      "NetServerAssembly": "8.8.0.9729",
      "NetServerDate": "2017-05-23",
      "NetServer": "SuperOffice NetServer 8.1 Stable (Build: 6352), expires in 76 days."
    }
```

If you fetch the version URL, you get back a list of supported URLs:

     /api/v1

returns an array of URLs:

```javascript
    [
      "/api/v1/Agents/Appointment/Accept",
      "/api/v1/Agents/Appointment/AcceptRejected",
      "/api/v1/Agents/Appointment/AssignTo",
      "/api/v1/Agents/Appointment/CalculateDays",
      "/api/v1/Agents/Appointment/CanAssignToProjectMember",
      "/api/v1/Agents/Appointment/CleanUpBookingDeleted",
      "/api/v1/Agents/Appointment/CleanUpRecurringBookingDeleted",
      "/api/v1/Agents/Appointment/CreateDefaultAppointmentEntity",
      ...
      "/api/v1/Appointment",
      "/api/v1/Appointment/{id}",
      "/api/v1/Appointment/{id}/Links?$select={$select}&$filter={$filter}&$orderBy={$orderBy}&$top={$top}&$skip={$skip}&$mode={$mode}&$options={$options}&$context={$context}&$format={$format}",
      "/api/v1/Appointment/{id}/Participants?$select={$select}&$filter={$filter}&$orderBy={$orderBy}&$top={$top}&$skip={$skip}&$mode={$mode}&$options={$options}&$context={$context}&$format={$format}",
      "/api/v1/Appointment/{id}/Simple",
      "/api/v1/Appointment/default",
      "/api/v1/Appointment/UdefLayout",
      ....
```


You can use this information to determine if the server supports the features you need.


## Building Blocks

The SuperOffice WebAPI has two major parts:
* **REST API** - URLs describe entities like person or sale.
* **Agents API** - the services API, accessible via HTTP. 

## REST API
The REST API exposes objects as entities that can be retrieved using HTTP GET,
modified using HTTP PUT, created using HTTP POST, and deleted using HTTP DELETE.

    GET /api/v1/Contact/default

Returns a new blank contact entity.

    GET /api/v1/Contact/123
    PUT /api/v1/Contact/123
    DELETE /api/v1/Contact/123

returns the Contact with id 123.
This object can be PUT or DELETE - subject to the usual sentry restrictions. 
If your role does not allow you to update, then the web api won't give
you more access.


## Agent API

The agents expose the latest Services agents and functions.

    GET /api/v1/Agents/Appointment/CalculateDays
    POST /api/v1/Agents/Appointment/CalculateDays

GET this to get a description of the call with some documentation. 
The method is not invoked using GET, even if the method is called **GetAppointment**.

To actually invoke the method, you need to POST to the endpoint:

    POST /api/v1/Agents/Appointment/CalculateDays
    { "Contact": { "ContactId": 123 },
      "AppointmentId": 1234,
      "Description": "string",
      "StartDate": "2017-06-06T13:02:55Z",
      "EndDate": "2017-06-06T13:02:55Z"
    }

This method takes an appointment entity as parameter, so this needs to 
be in the POST body.

The result of the service call is returned as JSON or XML, depending on the Accept header.


## Errors
Errors are returned as a NULLs:

    POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=9999

Returns HTTP 200 OK - with a NULL result.

    POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=glops

Returns HTTP 400 Bad Request - with an error result:

```javascript
{
    "Message": "The request is invalid.",
    "MessageDetail": "The parameters dictionary contains a null entry for parameter 'contactEntityId'."
}
```

You may also get a 200 OK with an internal error object.


# HTTP Request Headers

## Content types

The API supports both JSON and XML responses.
Use the **Accept** header to specify which you would like to receive.

     POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=123
     Accept: application/xml

Returns an XML representation of the contact:

```xml
    <ContactEntity>
        <ContactId>123</ContactId>
        <Name>Elan Hoppski</Name>
        <Department>EAvdeling</Department>
        <OrgNr></OrgNr>
        <Number1>123</Number1>
    </ContactEntity>
```

while a request for JSON

     POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=123
     Accept: application/json

returns a JSON representation of the same:

```javascript
    { "ContactId": 123,
      "Name": "Elan Hoppski",
      "Department": "EAvdeling",
      "OrgNr": "",
      "Number1": "123" }
```



# Examples of Agent calls

The examples below are given using javascripty pseudo-code.

## Create a new Company

Get a blank company, modify it, and post it back to create a new company.

```javascript
    company = Post("api/v1/Agents/Contact/CreateDefaultContactEntity")
    company.Name = "New company"
    company.Category.Id = 2
    company.Business.Id = 3
    company.NoMailing = true
    company = Post("api/v1/Agents/Contact/SaveContactEntity", company)
```

## Add a category list item
```javascript
    var item = {}
    item.Id = 0;
    item.Name = "Created by unit test";
    item.Tooltip = "Unit Tests FTW";
	item.UdListDefinitionId = -64    // Category list id
    item = Post("api/v1/Agents/List/SaveListItemEntity", item)
```

The list item will be added - we can get the whole list here:

```javascript
    req = { UdListDefinitionName: "category", IncludeDeleted: true }
    items = Post("api/v1/Agents/List/GetAllFromListName", req)
```

## Add a document template

We could call **SaveDocumentTemplateEntity** and **SaveDocumentTemplateStream** separately, like the REST API 
does, or we can use the agent call that does both in a single call:

```javascript
    content = "Hello {name}.";

    var item = {}
    item.Name = "Created by unit test";
    item.Filename = "footemplate.txt";
    item.Tooltip = "Unit Tests FTW";
    item.SaveInDb = 1;
    item.LoadTemplateFromPlugin = 0;
	
	var req = { DocumentTemplateEntity: item, Stream: content }
    item = Post("api/v1/Agents/List/SetDocumentTemplateStream", req)
```
At this point the document template record has been created, and the content
has been written to the archive.


## Generate a document
```javascript
    var doc = {}
    doc.Header = "Testing test";
    doc.Name = "foo.doc";
    doc.OurRef = "foo/1";
    doc.YourRef = "bar/99";
    doc.Description = "BAZ FTW";
    doc.DocumentTemplate = { DocumentTemplateId = 2 };
    doc.Contact = { ContactId = 25 };
    doc.Person = { PersonId = 63, ContactId = 25 }; 
    doc = Post("api/v1/Agents/Document/SaveDocumentEntity", doc);
```
At this point the document record has been created, but the content
is not generated yet. We can either upload some content directly:

```javascript
    id = doc.DocumentId;
    content = "This is some document content.";
	var req = { DocumentId: id, Stream: content }
    doc = Post("api/v1/Agents/Document/SetDocumentStreamFromId", req);
```
Or we can use the document template to generate a fresh document for us:
```javascript
    id = doc.DocumentId;
	var req = { DocumentId: id }
    doc = Post("api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplate", req);
```
This will generate a new document based on the template and return the
updated document object to us.