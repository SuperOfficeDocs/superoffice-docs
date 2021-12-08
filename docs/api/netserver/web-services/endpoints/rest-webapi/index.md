---
title: REST WebAPI
uid: rest_api
description: SuperOffice REST Web API exposes objects as entities that can be manipulated using the HTTP verbs GET, PUT, POST, and DELETE.
author: Bergfrid Dias
so.date: 12.03.2021
keywords: API, web services, endpoints, WebAPI, REST, ODATA, SO-AppToken, SOTicket
so.topic: concept
---

# REST WebAPI

The REST API exposes objects as entities that can be retrieved using HTTP GET, modified using HTTP PUT or PATCH, created using HTTP POST, and deleted using HTTP DELETE. To get the version and more info, [access the API endpoint][12]: `/api`

**Examples:**

```http
GET /api/v1/Contact/123
```

Returns a JSON object representing Contact 123. This object can be PUT to update it or DELETEd - subject to the usual [sentry restrictions][10]. Attempting to GET an object that doesn't exist will return an HTTP 404 error.
​
```http
POST api/v1/List/Category/Items
```

Adds a new list item to the Category list.

The REST API exposes the **major entities** (Company, Person, Project, Sale, and so on):

* `/api/v1/Contact`
* `/api/v1/Person`
* `/api/v1/Project`
* `/api/v1/Sale`
* ...

The entities all have similar structures.

`/api/v1/Contact` returns an [ODATA][16] feed of contact records. You can select fields and order and filter the result using ODATA operations.

## ODATA filters

`/api/v1/Contact?$select=name,category&$filter=registeredDate before '2021-1-1'`

This returns the contact ID, name, and category for contacts created before 2021.

[Read more about REST WebAPI search.][17]

## Default

Entities have dependencies derived from preferences. When you create entities using the APIs, be aware of these and leverage the [preference system][18].

Using Default will calculate some of the needed values for you, similar to clicking **New** inside the SuperOffice client. ​

`/api/v1/Contact/default`

[Read more about best practice API usage.][19]

## Retrieve object

`/api/v1/Contact/123` returns the Contact with ID 123. This object can be PUT or DELETE - subject to the usual sentry restrictions. The WebAPI won't facilitate elevated access.

```http
GET /api/v1/Contact/123
PUT /api/v1/Contact/123
DELETE /api/v1/Contact/123
```

### Simple

`/api/v1/Contact/123/Simple` returns a simplified version of the entity. This cannot be updated or deleted, but it can be easier to work with - it does not have deeply nested structures, and does not include things like user-defined fields.

## PATCH

Using PATCH instead of PUT you can update an entity without sending the entire entity.

HTTP PUT replaces the entire entity.

```http
PUT /api/v1/contact/123
{ Name: 'foo', Department: 'bar', Category: { Id: 123 }, Business: { Id: 123 }, Code: 'foo', etc etc }
```

HTTP PATCH allows partial updates on entities. This is a simple [JSON MERGE PATCH format (RFC 7396)][20].

```http
PATCH /api/v1/contact/123
{ Department: 'bar', Category: { Id: 123 } }
```

This can also be represented more explicitly as a [JSON PATCH (RFC 6902)][21]. This is the preferred structure for the WebAPI.

```http
PATCH /api/v1/contact/123
[ { op: 'replace', path: 'Department', value: 'bar' },
  { op: 'replace' path: 'Category/Id', value: 123 } ]
```

See [erosb.github.io][22] for a discussion of the benefits and problems with these two formats.

> [!NOTE]
> If you pass an **object where an array is expected**, we add the object to the array.

For example, if you send the following patch, the corresponding JSON MERGE is generated and applied.

**JSON MERGE:**

```http
{
  Department: 'foo',
  Phones: { Value: '12345678' }
}
```

**Turns into JSON PATCH:**

```http
[{ op: 'replace', path: '/Department', value: 'foo' },
 { op: 'add', path: '/Phones/-', value: { Value: '12345678' } } ]
```

Why? We know that Phones is an array, and we can't replace it with an object. If you passed an array, we would replace the entire phones value:

**JSON MERGE:**

```http
{
   Department: 'foo',
   Phones: [ { Value: '12345678' } ]
}
```

**Turns into JSON PATCH:**

```http
[{ op: 'replace', path: '/Department', value: 'foo' },
 { op: 'replace', path: '/Phones', value: [ { Value: '12345678' } ] } ]
```

**To update an existing Contact, use PATCH:**

```http
PATCH /api/v1/Contact/5

[
  {
    "op": "add",
    "path": "Interests",
    "value": [
      {
        "Id": "3",
        "Selected": true
      }
    ]
  }
]
```

## Custom fields

Most of the entities have **user-defined fields**, and expose information about the layout at `/api/v1/Contact/UdefLayout`.

The actual user-defined field values are returned in the entity's `UserDefinedFields` property.

To update a udeffield:

```http
PATCH /api/v1/contact/32

[
  {
    "op": "replace",
    "path": "CustomFields",
    "value": {
      "SuperOffice:1": "Testing"
    }
  }
]
```

To update a field in a Service extra table:

```http
[ { 'op' : 'replace', 'path': 'ExtraFields/x_foobar', 'value': 'baz' } ]
```

## Lists of entities

Many have related lists of other entities as well:

* `/api/v1/Contact/123/Projects`
* `/api/v1/Contact/123/Sales`

These lists are archives that you can filter and sort using OData queries.

## Lists

SuperOffice has built-in lists (Category, Business, Position, and so on). You can add your own custom lists.

`/api/v1/List` returns a list of lists.

To return **meta-data** about the list, including the list ID:

* `/api/v1/List/Category`
* `/api/v1/List/Business`
* `/api/v1/List/YourOwnList`

To return the **list items** in the given list:

* `/api/v1/List/Category/Items`
* `/api/v1/List/Business/Items`
* `/api/v1/List/YourOwnList/Items`

`/api/v1/MDOList` gives you read access to hierarchical lists and other list providers in the system.

## Search

The archive provider system is used to search to get read-only data and is exposed as an OData endpoint.

* `/api/v1/Archive/OwnerContacts?$select=contactId,name,orgnr`
* `/api/v1/Archive/EmailAddress?$select=fullName,emailAddress&$filter=contactId=12`

## User preferences

[User preferences][18] and `pref.descriptions` can be read and updated.

* `/api/v1/Preference/section/keyname`
* `/api/v1/PreferenceDescription/section/keyname`

## Foreign keys

`/api/v1/ForeignApp/Glops/Foobar/Key/Lookup/Contact/123`

Returns the key called 'Lookup' from the foreign app 'Glops' for the Contact record 123.

## Strings

Built-in string resources can be read in supported languages.

`/api/v1/String/SR_YES?isoLangCode=sv`

## System

Users, roles, and license stuff are exposed via simple endpoints. Available onsite only!

If you have admin rights in your role, you can POST or PUT to update system information.

* `/api/v1/User/Tony`
* `/api/v1/Role/12`
* `/api/v1/License/SuperOffice`

## Errors

Errors are returned using HTTP error codes, and as a JSON object:

`/api/v1/Contact/99999` returns HTTP **404 Contact Not Found**, and the following JSON result

```json
{
  "Error": true,
  "ErrorType": "SoNotFoundException",
  "ErrorMessage": "Contact id 99999 not found",
  "ErrorSource": "SuperOffice.Services.Implementation"
}
```

## Calling (non-interactive request)

Let's look at how your application can communicate with the SuperOffice web services *after* authenticating and obtaining the system user ticket. You have to establish a secure connection before you start exchanging data.

In contrast to the **interactive** workflow, where the `Authorization` header uses `Bearer [access_token]`, the **non-interactive** workflow requires the `Authorization` header to use `SOTicket` instead of `Bearer`, followed by the ticket value. You also have to include the `SO-AppToken` header.

> [!NOTE]
> Pre-requisites: You have a [valid system user ticket][13].

The **ApplicationToken** header must also be specified as SO-AppToken with the client secret (application token) value provided when the application was registered.

* **Authorization**: `SOTicket System_User_Ticket_Value`
* **SO-AppToken**: `Application_Token_Value`

```csharp
GET /Cust26759/api/v1/MDOList/category?flat=True HTTP/1.1
Host: sod.superoffice.com
accept: application/json
authorization: SOTICKET 7T:MAA3AGYAMQBlAGQAZAAxAGQAZQAwADgAYgAxAGEAYwBkADYAOAA0ADcAMQA2ADkAOQBhADQAZgBiADMAOQAyADsAMgAwADgANwAzADEANQAwADQAMwA7AEMAdQBzAHQAMgA2ADcANQA5AA==
accept-language: en
SO-AppToken: f2398a3a7wer3759d4b220e9a9c94321
```

## How to (code samples)

* [Create a new company][2]
* [Add a category list item][3]
* [Add a document template][4]
* [Generate a document][5]
* [Get person image][6]
* [Set person image][7]

## Webhooks

Registering a webhook is covered in the [Webhook overview][8]. [Webhook callback events][11] are described separately.

---

## You might also be interested in

* [Learn the Agents WebAPI][1]
* [Look up endpoints in the REST reference][14]
* [Download REST WebAPI Swagger file][9]
* [Read the article][15] on how to consume SuperOffice REST resources, set required authentication headers, and how a request URL, body, and response body should appear and behave.

<!-- Referenced links -->
[1]: ../agents-webapi/index.md
[2]: ../../../../contact/services/create-contact-rest.md
[3]: ../../../lists/services/rest/add-catlist-item-rest.md
[4]: ../../../../documents/rest/add-document-template.md
[5]: ../../../../documents/rest/generate-document.md
[6]: ../../../../person/services/get-person-image-rest.md
[7]: ../../../../person/services/update-person-image-rest.md
[8]: ../../../webhooks/register.md
[9]: ../../../../assets/downloads/Swagger-v1-REST.zip
[10]: ../../../../security/sentry/services/index.md
[11]: ../../../webhooks/reference/index.md
[12]: ../get-webapi-version.md
[13]: ../../../../authentication/online/auth-application/get-system-user-ticket.md
[14]: ../../../../api-reference/restful/rest/index.md
[15]: ../../setup-rest.md
[16]: ../../../search/odata/index.md
[17]: ../../../search/index.md
[18]: ../../../../../../superoffice-docs/docs/admin/user-preferences/index.md
[19]: ../../../../../../superoffice-docs/docs/apps/best-practices.md#entity-creation
[20]: https://tools.ietf.org/html/rfc7386
[21]: https://tools.ietf.org/html/rfc6902
[22]: https://erosb.github.io/post/json-patch-vs-merge-patch/
