---
title: REST WebAPI
uid: rest_api
description: SuperOffice REST Web API exposes objects as entities that can be manipulated using the HTTP verbs GET, PUT, POST, and DELETE.
author: {github-id}
keywords: webapi, rest
so.date:
so.topic: concept
---

# REST WebAPI

The REST API exposes objects as entities that can be retrieved using HTTP GET, modified using HTTP PUT, created using HTTP POST, and deleted using HTTP DELETE. To get the version and more info, [access the API endpoint][12]: `/api`

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

## Entities

The REST API has the major entities (Company, Person, Project, Sale, and so on) exposed.

* `/api/v1/Contact`
* `/api/v1/Person`
* `/api/v1/Project`
* `/api/v1/Sale`
* ...

The entities all have similar structures.

`/api/v1/Contact` returns an ODATA feed of contact records. You can select fields and order and filter the result using ODATA operations.

### Filter

`/api/v1/Contact?$select=name,category&$filter=registeredDate before '2009-1-1'`

This returns the contact ID, name, and category for contacts created before 2009.

### Default

`/api/v1/Contact/default` returns a new blank entity.

### Retrieve object

`/api/v1/Contact/123` returns the Contact with ID 123. This object can be PUT or DELETE - subject to the usual sentry restrictions. If your role does not allow you to update, then the WebAPI won't give you more access.

```http
GET /api/v1/Contact/123
PUT /api/v1/Contact/123
DELETE /api/v1/Contact/123
```

### Simple

`/api/v1/Contact/123/Simple` returns a simplified version of the entity. This cannot be updated or deleted, but it can be easier to work with - it does not have deeply nested structures, and does not support things like user-defined fields.

### User-defined fields

Most of the entities have user-defined fields, and expose information about the layout at `/api/v1/Contact/UdefLayout`.

The actual user-defined field values are returned in the entity's `UserDefinedFields` property.

### Lists of entities

Many have related lists of other entities as well:

* `/api/v1/Contact/123/Projects`|
* `/api/v1/Contact/123/Sales`|

These lists are archives that you can filter and sort using OData operations.

## Lists

SuperOffice has built-in lists (Category, Business, Position, and so on). You can add your own custom lists.

`/api/v1/List` returns a list of lists.

To return meta-data about the list, including the list ID:

* `/api/v1/List/Category`
* `/api/v1/List/Business`
* `/api/v1/List/YourOwnList`

To return the list items in the given list:

* `/api/v1/List/Category/Items`
* `/api/v1/List/Business/Items`
* `/api/v1/List/YourOwnList/Items`

`/api/v1/MDOList` gives you read access to hierarchical lists and other list providers in the system.

## Archives

The archive provider system is exposed as an OData endpoint.

* `/api/v1/Archive/OwnerContacts?$select=contactId,name,orgnr`
* `/api/v1/Archive/EmailAddress?$select=fullName,emailAddress&$filter=contactId=12`

## User preferences

User preferences and `pref.descriptions` can be read and updated.

* `/api/v1/Preference/section/keyname`
* `/api/v1/PreferenceDescription/section/keyname`

## Foreign keys

`/api/v1/ForeignApp/Glops/Foobar/Key/Lookup/Contact/123`

Returns the key called 'Lookup' from the foreign app 'Glops' for the Contact record 123.

## Strings

Built-in string resources can be read in supported languages.

`/api/v1/String/SR_YES?isoLangCode=sv`

## System

Users, Roles, License stuff are exposed via simple endpoints. If you have admin rights in your role, you can POST or PUT to update system information.

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

## How to

> [!NOTE]
> The examples below are given using JavaScripty pseudo-code.

* [Submit a non-interactive REST request][13]
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
* [Read Tony's article][15] on how to consume SuperOffice REST resources, set required authentication headers, and how a request URL, body, and response body should appear and behave.

<!-- Referenced links -->
[1]: ../agents/index.md
[2]: ../../contact/services/create-contact-rest.md
[3]: ../../netserver/lists/services/rest/add-catlist-item-rest.md
[4]: ../../documents/rest/add-document-template.md
[5]: ../../documents/rest/generate-document.md
[6]: ../../person/services/get-person-image-rest.md
[7]: ../../person/services/update-person-image-rest.md
[8]: ../../netserver/webhooks/register.md
[9]: ../../assets/downloads/Swagger-v1-REST.zip
[10]: ../../security/sentry/services/index.md
[11]: ../../netserver/webhooks/reference/index.md
[12]: get-version.md
[13]: submit-rest.md
[14]: ../../api-reference/restful/rest/index.md
[15]: rest.md
