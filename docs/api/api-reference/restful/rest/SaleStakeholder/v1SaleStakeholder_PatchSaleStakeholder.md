---
title: PATCH SaleStakeholder/{id}
id: v1SaleStakeholder_PatchSaleStakeholder
---

# PATCH SaleStakeholder/{id}

```http
PATCH /api/v1/SaleStakeholder/{id}
```

Update a SaleStakeholder with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.ISaleAgent} service SaveSaleStakeholder.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleStakeholder  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/SaleStakeholder/{id}?$select=name,department,category/id
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




SaleStakeholder entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SaleStakeholder  updated. |
| 404 | SaleStakeholder with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because SaleStakeholder has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | string | Stakeholder role name |
| Comment | string | Optional comment text |
| StakeholderRoleId | int32 | Stakeholde role list id - Primary key |
| CountryId | int32 | Country id - primary key |
| PersonId | int32 | Person id - Primary key |
| EmailDescription | string | E-mail description |
| EmailId | int32 | E-mail address id - Primary key |
| EmailAddress | string | E-mail address |
| PhoneId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactId | int32 | Contact ID of person or contact who is the sale stakeholder |
| SaleId | int32 | Parent sale |
| Mrmrs | string | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| SaleStakeholderId | int32 | Primary key |
| Rank | int32 | Rank in list of stakeholders |
| Phone | string | Phone number |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/SaleStakeholder/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "tempore",
    "value": {
      "value1": {
        "PrimaryKey": 7171,
        "EntityName": "person",
        "personId": 7171,
        "fullName": "Nettie Pollich"
      },
      "value2": {
        "PrimaryKey": 2239,
        "EntityName": "sale",
        "saleId": 2239,
        "contactId": 9999,
        "name": "Leffler Inc and Sons"
      }
    }
  },
  {
    "op": "add",
    "path": "tempore",
    "value": {
      "value1": {
        "PrimaryKey": 7171,
        "EntityName": "person",
        "personId": 7171,
        "fullName": "Nettie Pollich"
      },
      "value2": {
        "PrimaryKey": 2239,
        "EntityName": "sale",
        "saleId": 2239,
        "contactId": 9999,
        "name": "Leffler Inc and Sons"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SaleStakeholder  updated.
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Nitzsche-Boehm",
  "Comment": "asperiores",
  "StakeholderRoleId": 941,
  "CountryId": 33,
  "PersonId": 896,
  "EmailDescription": "rey.morar@crookscormier.ca",
  "EmailId": 944,
  "EmailAddress": "kayden_klein@morarbaumbach.info",
  "PhoneId": 53,
  "ContactName": "Tremblay Inc and Sons",
  "ContactId": 754,
  "SaleId": 681,
  "Mrmrs": "quam",
  "Firstname": "Mertie",
  "MiddleName": "Douglas Group",
  "Lastname": "Sawayn",
  "SaleStakeholderId": 442,
  "Rank": 942,
  "Phone": "(635)831-3184 x721",
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
      "FieldType": "System.Int32",
      "FieldLength": 945
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```