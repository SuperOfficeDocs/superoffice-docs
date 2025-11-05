---
title: POST ProjectMember
uid: v1ProjectMember_PostProjectMember
generated: true
content_type: reference
---

# POST ProjectMember

```http
POST /api/v1/ProjectMember
```

Creates a new ProjectMember


Calls the Project agent service SaveProjectMember.
NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ProjectMember?$select=name,department,category/id
```


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

## Request Body: newEntity 

The ProjectMember to be saved. 

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
POST /api/v1/ProjectMember
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 915,
  "ContactId": 857,
  "ProjectId": 517,
  "ContactName": "Zulauf, Bergstrom and Fahey",
  "ContactDepartment": "",
  "ProjectName": "Hilpert, Zulauf and Cassin",
  "EmailId": 755,
  "EmailAddress": "sofia@heller.info",
  "CountryId": 533,
  "Firstname": "Ed",
  "MiddleName": "Gerlach Group",
  "Lastname": "Gutkowski",
  "PersonId": 405,
  "Mrmrs": "veritatis",
  "ProjectMemberTypeName": "Stokes-Koch",
  "Phone": "(668)276-4519 x044",
  "PhoneId": 709,
  "ProjectMemberTypeId": 843,
  "EmailAddressName": "celia_feil@herzog.uk",
  "Comment": "voluptatem",
  "FullName": "Felton Padberg",
  "Registered": "2004-04-30T02:30:53.0692723+02:00",
  "Updated": "2005-05-10T02:30:53.0692723+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 938,
  "ContactId": 189,
  "ProjectId": 305,
  "ContactName": "Powlowski-Blanda",
  "ContactDepartment": "",
  "ProjectName": "Zulauf, Adams and Kuhic",
  "EmailId": 267,
  "EmailAddress": "elena_schmeler@smitham.info",
  "CountryId": 450,
  "Firstname": "Marisa",
  "MiddleName": "Macejkovic-Batz",
  "Lastname": "Bednar",
  "PersonId": 402,
  "Mrmrs": "vero",
  "ProjectMemberTypeName": "Watsica-Heaney",
  "Phone": "276-614-8586",
  "PhoneId": 264,
  "ProjectMemberTypeId": 87,
  "EmailAddressName": "jeanette.paucek@johnston.uk",
  "Comment": "sit",
  "FullName": "Noe Durgan",
  "Registered": "2015-07-12T02:30:53.0692723+02:00",
  "Updated": "2024-01-22T02:30:53.0692723+01:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 922
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```