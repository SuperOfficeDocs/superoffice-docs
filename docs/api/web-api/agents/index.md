---
title: agents_api
description: Agents Web API
author: {github-id}             # Your GitHub alias.
keywords:
so.date:
so.topic: concept
---

The Agents API contains everything in the normal service API but does not attempt to model entities. All operations are accessed using HTTP POST.

The agents expose the latest Services agents and functions. It contains everything in the normal service API, but does not attempt to model entities. All the web service operations are accessed using HTTP POST.

> [!NOTE]
> The agents do not return HTTP errors - a failed call will return NULL instead.

**Examples:**

`POST /api/v1/Agents/Contact/GetContact?contactId=123`

Returns a JSON object representing Contact 123.

`POST /api/v1/Agents/List/SaveListItemEntity`

Adds a new list item to the Category list (assuming the list item entity parameter has been properly initialized).

`/api/v1/Agents/Appointment/CalculateDays`

GET this to get a description of the call. The method is not invoked using GET, even if the method is called **GetAppointment**. To actually invoke the method, you need to POST to the endpoint:

```http
POST /api/v1/Agents/Appointment/CalculateDays
{ "Contact": { "ContactId": 123 },
  "AppointmentId": 1234,
  "Description": "string",
  "StartDate": "2017-06-06T13:02:55Z",
  "EndDate": "2017-06-06T13:02:55Z"
}
```

This method takes an appointment entity as parameter so this needs to be in the POST body. The result of the service call is returned as JSON.

## How to

> [!NOTE]
> The examples below are given using Javascripty pseudo-code.

* [Create a new company][2]
* [Add a category list item][3]
* [Add a document template][4]
* [Generate a document][5]

---

See also: WebAPI [REST API][1]

[Download Agent Swagger file][6]

<!-- Referenced links -->
[1]: ../rest/index.md
[2]: ../../contact/create/create-contact-webapi-agents.md
[3]: ../../contact/category/add-catlist-item-webapi-agents.md
[4]: ../../documents/agents-web-api/add-document-template.md
[5]: ../../documents/agents-web-api/generate-document.md
[6]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/swagger/Swagger-v1-Agents.json
