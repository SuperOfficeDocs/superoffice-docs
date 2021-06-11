---
title: Agents WebAPI
uid: webapi_agents
description: Agents Web API
author: {github-id}
keywords: webapi, agents
so.date:
so.topic: concept
---

# Agents WebAPI

The Agents API contains everything in the normal web service API but does not attempt to model entities. It exposes the latest Services agents and functions. All operations are accessed using HTTP POST.
To get the version and more info, [access the API endpoint][7]: `/api`

> [!NOTE]
> The agents do not return HTTP errors - a failed call will return NULL instead.

**Examples:**

```http
POST /api/v1/Agents/Contact/GetContact?contactId=123
```

Returns a JSON object representing Contact 123.

```http
POST /api/v1/Agents/List/SaveListItemEntity
```

Adds a new list item to the Category list (assuming the list item entity parameter has been properly initialized).

## GET vs. POST

`GET /api/v1/Agents/Appointment/CalculateDays`

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

This method takes an appointment entity as its parameter so this needs to be in the POST body. The result of the service call is returned as JSON or XML, depending on the Accept header.

## Errors

Errors are returned as a NULLs:

**HTTP 200 OK - with a NULL result:**

```http
POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=9999
```

**HTTP 400 Bad Request - with an error result:**

```http
POST api/v1/Agents/Contact/GetContactEntity?contactEntityId=glops
```

**200 OK with an internal error object:**

```javascript
{
  "Message": "The request is invalid.",
  "MessageDetail": "The parameters dictionary contains a null entry for parameter 'contactEntityId'."
}
```

## How to

> [!NOTE]
> The examples below are given using JavaScripty pseudo-code.

* [Create a new company][2]
* [Add a category list item][3]
* [Add a document template][4]
* [Generate a document][5]

---

## You might also be interested in

* [Learn the REST WebAPI][1]
* [Look up endpoints in the Agents reference][8]
* [Download REST WebAPI Swagger file][6]

<!-- Referenced links -->
[1]: ../rest/index.md
[2]: ../../contact/services/create-contact-webapi-agents.md
[3]: ../../netserver/lists/services/listagent/add-catlist-item-webapi-agents.md
[4]: ../../documents/agents-web-api/add-document-template.md
[5]: ../../documents/agents-web-api/generate-document.md
[6]: ../../assets/downloads/Swagger-v1-Agents.zip
[7]: get-version.md
[8]: ../../api-reference/restful/agent/index.md
