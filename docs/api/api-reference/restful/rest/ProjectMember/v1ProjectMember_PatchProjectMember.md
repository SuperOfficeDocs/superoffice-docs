---
title: PATCH ProjectMember/{id}
id: v1ProjectMember_PatchProjectMember
---

# PATCH ProjectMember/{id}

```http
PATCH /api/v1/ProjectMember/{id}
```

Update a ProjectMember with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IProjectAgent} service SaveProjectMember.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectMember  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/ProjectMember/{id}?$select=name,department,category/id
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

A person can be a member of multiple projects, with a different comment and member type in each project.



ProjectMember entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectMember  updated. |
| 404 | ProjectMember with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ProjectMember has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectmemberId | int32 | Primary key |
| ContactId | int32 | Contact ID of person who is the project member |
| ProjectId | int32 | Parent project - the project this project member belongs to. |
| ContactName | string | Contact name |
| ContactDepartment | string | Contact department |
| ProjectName | string | Name of the project this project member belongs to. |
| EmailId | int32 | The person's email address id |
| EmailAddress | string | The e-mail address |
| CountryId | int32 | Country |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| PersonId | int32 | The person's id - primary key |
| Mrmrs | string | e.g. Mrs, Dr, Ms. |
| ProjectMemberTypeName | string | The projectmembers type name: 'secretary', 'member', etc. |
| Phone | string | Phone number |
| PhoneId | int32 | The phone id |
| ProjectMemberTypeId | int32 | ProjectMember Type Id - from the ProjectMemberType list.  <para>Use MDO List name "PMembType" to get list items.</para> |
| EmailAddressName | string | The e-mail address description |
| Comment | string | Comment text on the project membership |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/ProjectMember/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "molestiae",
    "value": {
      "value1": {
        "PrimaryKey": 440,
        "EntityName": "sale",
        "saleId": 440,
        "contactId": 1230,
        "name": "Waters Group"
      },
      "value2": {
        "PrimaryKey": 6750,
        "EntityName": "sale",
        "saleId": 6750,
        "contactId": 771,
        "name": "Towne LLC"
      }
    }
  },
  {
    "op": "add",
    "path": "molestiae",
    "value": {
      "value1": {
        "PrimaryKey": 440,
        "EntityName": "sale",
        "saleId": 440,
        "contactId": 1230,
        "name": "Waters Group"
      },
      "value2": {
        "PrimaryKey": 6750,
        "EntityName": "sale",
        "saleId": 6750,
        "contactId": 771,
        "name": "Towne LLC"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ProjectMember  updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 271,
  "ContactId": 575,
  "ProjectId": 136,
  "ContactName": "Moore-Skiles",
  "ContactDepartment": "",
  "ProjectName": "Gleason-Wisozk",
  "EmailId": 737,
  "EmailAddress": "angie@batz.name",
  "CountryId": 629,
  "Firstname": "Rowan",
  "MiddleName": "Strosin-Armstrong",
  "Lastname": "Mertz",
  "PersonId": 318,
  "Mrmrs": "et",
  "ProjectMemberTypeName": "Fisher-Kozey",
  "Phone": "004.734.4163 x6578",
  "PhoneId": 102,
  "ProjectMemberTypeId": 894,
  "EmailAddressName": "carmella@howell.uk",
  "Comment": "quod",
  "FullName": "Deonte Wolff",
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
      "FieldLength": 84
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```