---
title: GET ProjectMember/{id}
uid: v1ProjectMember_GetProjectMember
generated: true
---

# GET ProjectMember/{id}

```http
GET /api/v1/ProjectMember/{id}
```

Gets a ProjectMember object.


Calls the Project agent service GetProjectMember.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ProjectMember to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/ProjectMember/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ProjectMember found.

| Response | Description |
|----------------|-------------|
| 200 | ProjectMember found. |
| 404 | Not Found. |

### Response body: ProjectMemberWithLinks

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
| ProjectMemberTypeId | int32 | ProjectMember Type Id - from the ProjectMemberType list.  Use MDO List name "PMembType" to get list items. |
| EmailAddressName | string | The e-mail address description |
| Comment | string | Comment text on the project membership |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/ProjectMember/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 ProjectMember found.
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 475,
  "ContactId": 782,
  "ProjectId": 282,
  "ContactName": "Powlowski-Johnston",
  "ContactDepartment": "",
  "ProjectName": "Kuhn, Connelly and Runte",
  "EmailId": 188,
  "EmailAddress": "derrick_abernathy@krajcikschulist.ca",
  "CountryId": 515,
  "Firstname": "Brandyn",
  "MiddleName": "Macejkovic, Cassin and O'Keefe",
  "Lastname": "Kreiger",
  "PersonId": 733,
  "Mrmrs": "qui",
  "ProjectMemberTypeName": "Kulas-Emmerich",
  "Phone": "(011)768-3046 x4697",
  "PhoneId": 255,
  "ProjectMemberTypeId": 845,
  "EmailAddressName": "orion.bailey@emmerichkuphal.biz",
  "Comment": "quas",
  "FullName": "Dr. Kamille Mac McLaughlin",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 600
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```