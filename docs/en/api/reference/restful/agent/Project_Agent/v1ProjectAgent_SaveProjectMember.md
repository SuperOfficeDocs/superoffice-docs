---
title: POST Agents/Project/SaveProjectMember
uid: v1ProjectAgent_SaveProjectMember
generated: true
content_type: reference
---

# POST Agents/Project/SaveProjectMember

```http
POST /api/v1/Agents/Project/SaveProjectMember
```

Updates the existing ProjectMember or creates a new ProjectMember if the id parameter is 0.


NsApiSlow threshold: 2000 ms.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: projectMember 

The ProjectMember that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectmemberId | Integer | Primary key |
| ContactId | Integer | Contact ID of person who is the project member |
| ProjectId | Integer | Parent project - the project this project member belongs to. |
| ContactName | String | Contact name |
| ContactDepartment | String | Contact department |
| ProjectName | String | Name of the project this project member belongs to. |
| EmailId | Integer | The person's email address id |
| EmailAddress | String | The e-mail address |
| CountryId | Integer | Country |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| PersonId | Integer | The person's id - primary key |
| Mrmrs | String | e.g. Mrs, Dr, Ms. |
| ProjectMemberTypeName | String | The projectmembers type name: 'secretary', 'member', etc. |
| Phone | String | Phone number |
| PhoneId | Integer | The phone id |
| ProjectMemberTypeId | Integer | ProjectMember Type Id - from the ProjectMemberType list.  <para>Use MDO List name "PMembType" to get list items.</para> |
| EmailAddressName | String | The e-mail address description |
| Comment | String | Comment text on the project membership |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| Registered | String | The date and time when the project member was registered  in UTC. |
| Updated | String | The date and time when the project member was last updated  in UTC. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectMember

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

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectMember
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 8,
  "ContactId": 42,
  "ProjectId": 385,
  "ContactName": "Adams Inc and Sons",
  "ContactDepartment": "visualize 24/365 users",
  "ProjectName": "Stracke-Collier",
  "EmailId": 771,
  "EmailAddress": "lera.keeling@franecki.co.uk",
  "CountryId": 311,
  "Firstname": "Savion",
  "MiddleName": "Boehm-Larson",
  "Lastname": "Cruickshank",
  "PersonId": 765,
  "Mrmrs": "autem",
  "ProjectMemberTypeName": "Reinger, Tillman and Hyatt",
  "Phone": "(892)733-1429 x15454",
  "PhoneId": 517,
  "ProjectMemberTypeId": 434,
  "EmailAddressName": "larue.fritsch@vonschamberger.name",
  "Comment": "itaque",
  "FullName": "Lacey Nienow",
  "Registered": "2003-11-15T02:30:47.6944454+01:00",
  "Updated": "2008-06-23T02:30:47.6944454+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 966,
  "ContactId": 299,
  "ProjectId": 858,
  "ContactName": "Gottlieb-Wisoky",
  "ContactDepartment": "",
  "ProjectName": "O'Keefe-Cummerata",
  "EmailId": 488,
  "EmailAddress": "lyric.jast@abbott.us",
  "CountryId": 868,
  "Firstname": "Mohamed",
  "MiddleName": "Fadel, Casper and Monahan",
  "Lastname": "Schultz",
  "PersonId": 767,
  "Mrmrs": "praesentium",
  "ProjectMemberTypeName": "Hickle-Sauer",
  "Phone": "452-624-5642",
  "PhoneId": 402,
  "ProjectMemberTypeId": 734,
  "EmailAddressName": "scot.kuphal@keeling.co.uk",
  "Comment": "est",
  "FullName": "Sim Schaefer",
  "Registered": "2024-07-25T02:30:47.6944454+02:00",
  "Updated": "2019-05-15T02:30:47.6944454+02:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 322
    }
  }
}
```