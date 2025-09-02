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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectMember
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 857,
  "ContactId": 528,
  "ProjectId": 8,
  "ContactName": "Goodwin, Zboncak and White",
  "ContactDepartment": "",
  "ProjectName": "Kuhn LLC",
  "EmailId": 507,
  "EmailAddress": "savion@tillmandouglas.uk",
  "CountryId": 783,
  "Firstname": "Rossie",
  "MiddleName": "Stoltenberg Inc and Sons",
  "Lastname": "Bednar",
  "PersonId": 793,
  "Mrmrs": "maxime",
  "ProjectMemberTypeName": "Murray LLC",
  "Phone": "(596)550-6416",
  "PhoneId": 39,
  "ProjectMemberTypeId": 454,
  "EmailAddressName": "bennett@schimmel.us",
  "Comment": "assumenda",
  "FullName": "Ms. Mariela Theron Sawayn"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 992,
  "ContactId": 924,
  "ProjectId": 713,
  "ContactName": "Jacobs Group",
  "ContactDepartment": "",
  "ProjectName": "Ondricka-Rath",
  "EmailId": 515,
  "EmailAddress": "kaden@baumbach.ca",
  "CountryId": 825,
  "Firstname": "Esteban",
  "MiddleName": "Beier LLC",
  "Lastname": "Thompson",
  "PersonId": 218,
  "Mrmrs": "deserunt",
  "ProjectMemberTypeName": "Harris-Sawayn",
  "Phone": "375-783-8390",
  "PhoneId": 163,
  "ProjectMemberTypeId": 584,
  "EmailAddressName": "delfina@wolforn.com",
  "Comment": "velit",
  "FullName": "Arielle Schamberger",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 163
    }
  }
}
```