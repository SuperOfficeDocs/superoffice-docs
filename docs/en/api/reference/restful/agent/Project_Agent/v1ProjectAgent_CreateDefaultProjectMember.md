---
title: POST Agents/Project/CreateDefaultProjectMember
uid: v1ProjectAgent_CreateDefaultProjectMember
generated: true
content_type: reference
---

# POST Agents/Project/CreateDefaultProjectMember

```http
POST /api/v1/Agents/Project/CreateDefaultProjectMember
```

Loading default values into a new ProjectMember.








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
POST /api/v1/Agents/Project/CreateDefaultProjectMember
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 195,
  "ContactId": 596,
  "ProjectId": 314,
  "ContactName": "Barton-Kuhlman",
  "ContactDepartment": "",
  "ProjectName": "Wilkinson, Kemmer and Wolf",
  "EmailId": 240,
  "EmailAddress": "brandy_leuschke@hudson.us",
  "CountryId": 972,
  "Firstname": "Jacklyn",
  "MiddleName": "Bahringer, McGlynn and Lemke",
  "Lastname": "Berge",
  "PersonId": 62,
  "Mrmrs": "esse",
  "ProjectMemberTypeName": "Casper, O'Kon and Bogisich",
  "Phone": "760-942-0495",
  "PhoneId": 314,
  "ProjectMemberTypeId": 752,
  "EmailAddressName": "myles@turner.ca",
  "Comment": "blanditiis",
  "FullName": "Marlene Littel",
  "Registered": "2023-06-17T11:24:48.5001409+02:00",
  "Updated": "2022-01-03T11:24:48.5001409+01:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 747
    }
  }
}
```