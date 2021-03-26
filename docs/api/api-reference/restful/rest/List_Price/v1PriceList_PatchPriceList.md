---
title: PATCH Pricelist/{id}
id: v1PriceList_PatchPriceList
---

# PATCH Pricelist/{id}

```http
PATCH /api/v1/Pricelist/{id}
```

Update a PriceList with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IQuoteAgent} service SavePriceList.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PriceList  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Pricelist/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

A pricelist is basically a collection of products. It can be valid in a time period, and outright deactivated. All prices in the product list is in a specific currency. We have decieded not to separate prices and products, which means that we get a simpler data model, but some redundancy.



PriceList entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | PriceList  updated. |
| 404 | PriceList with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because PriceList has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PriceListId | int32 | Primary key |
| ERPPriceListKey | string | The key that uniquely identifies this pricelist in the ERP system |
| QuoteConnectionId | int32 | (Reserved for future use) The connection to the ERP system used for this pricelist |
| Name | string | Name of this pricelist to use in the user interface. |
| Description | string | Description of this pricelist , will be used as tool-tip in the user interface. |
| Currency | string | The iso currency code, like 'USD' or 'NOK'. |
| CurrencyName | string | The name to use in the user interface, like perhaps 'US dollar' or '$' |
| ValidFrom | date-time | The date (inclusive) the pricelist start to be valid. This can be DateTime.MinValue to signal that it doesn't have a specific start date. |
| ValidTo | date-time | The date (inclusive) the pricelist ends to be valid. This can be DateTime.MaxValue to signal that it doesn't have a specific end date. |
| IsActive | bool | Is the list active (as opposed to being worked on, suddenly canceled, etc. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Pricelist/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "velit",
    "value": {
      "value1": {
        "PrimaryKey": 7385,
        "EntityName": "sale",
        "saleId": 7385,
        "contactId": 6143,
        "name": "Rogahn, Gerlach and Thompson"
      },
      "value2": {
        "PrimaryKey": 4375,
        "EntityName": "sale",
        "saleId": 4375,
        "contactId": 9271,
        "name": "Brown LLC"
      }
    }
  },
  {
    "op": "add",
    "path": "velit",
    "value": {
      "value1": {
        "PrimaryKey": 7385,
        "EntityName": "sale",
        "saleId": 7385,
        "contactId": 6143,
        "name": "Rogahn, Gerlach and Thompson"
      },
      "value2": {
        "PrimaryKey": 4375,
        "EntityName": "sale",
        "saleId": 4375,
        "contactId": 9271,
        "name": "Brown LLC"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 PriceList  updated.
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 42,
  "ERPPriceListKey": "voluptatum",
  "QuoteConnectionId": 69,
  "Name": "VonRueden Inc and Sons",
  "Description": "Multi-lateral uniform local area network",
  "Currency": "enim",
  "CurrencyName": "Stoltenberg-Spencer",
  "ValidFrom": "2001-04-26T09:41:00.5203816+02:00",
  "ValidTo": "2001-02-07T09:41:00.5203816+01:00",
  "IsActive": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 976
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```