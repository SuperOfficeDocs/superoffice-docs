---
title: GET ProjectMember/{id}
uid: v1ProjectMember_GetProjectMember
generated: true
content_type: reference
---

# GET ProjectMember/{id}

```http
GET /api/v1/ProjectMember/{id}
```

Gets a ProjectMember object.


Calls the Project agent service GetProjectMember.
NsApiSlow threshold: 2000 ms.





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
| Registered | date-time | The date and time when the project member was registered  in UTC. |
| Updated | date-time | The date and time when the project member was last updated  in UTC. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/ProjectMember/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ProjectMember found.
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 664,
  "ContactId": 23,
  "ProjectId": 186,
  "ContactName": "Cole LLC",
  "ContactDepartment": "",
  "ProjectName": "Bauch, Bailey and Koepp",
  "EmailId": 230,
  "EmailAddress": "tara.bayer@howelljacobs.co.uk",
  "CountryId": 386,
  "Firstname": "Paris",
  "MiddleName": "Koch Inc and Sons",
  "Lastname": "Gibson",
  "PersonId": 896,
  "Mrmrs": "molestiae",
  "ProjectMemberTypeName": "Christiansen, Cremin and Dicki",
  "Phone": "529-943-0184 x09136",
  "PhoneId": 744,
  "ProjectMemberTypeId": 292,
  "EmailAddressName": "agustin_feeney@vandervortolson.co.uk",
  "Comment": "eum",
  "FullName": "Mr. Ahmed Senger I",
  "Registered": "2008-04-28T02:30:53.0692723+02:00",
  "Updated": "2006-11-18T02:30:53.0692723+01:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 529
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```