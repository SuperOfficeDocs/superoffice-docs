---
title: POST Agents/Project/SaveProjectMember
uid: v1ProjectAgent_SaveProjectMember
generated: true
---

# POST Agents/Project/SaveProjectMember

```http
POST /api/v1/Agents/Project/SaveProjectMember
```

Updates the existing ProjectMember or creates a new ProjectMember if the id parameter is empty








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

## Request Body: entity 

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 683,
  "ContactId": 857,
  "ProjectId": 887,
  "ContactName": "Armstrong-Frami",
  "ContactDepartment": "",
  "ProjectName": "Jenkins Group",
  "EmailId": 479,
  "EmailAddress": "jada_nader@conroydenesik.uk",
  "CountryId": 393,
  "Firstname": "Elmira",
  "MiddleName": "Lehner-Graham",
  "Lastname": "Borer",
  "PersonId": 61,
  "Mrmrs": "tempore",
  "ProjectMemberTypeName": "Mann, Howell and Collins",
  "Phone": "286-190-5735",
  "PhoneId": 713,
  "ProjectMemberTypeId": 700,
  "EmailAddressName": "jany@ohara.com",
  "Comment": "quam",
  "FullName": "Mrs. Jonas Lindgren"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 106,
  "ContactId": 417,
  "ProjectId": 726,
  "ContactName": "Anderson Inc and Sons",
  "ContactDepartment": "",
  "ProjectName": "Davis-Greenfelder",
  "EmailId": 717,
  "EmailAddress": "salvador@feestswaniawski.co.uk",
  "CountryId": 772,
  "Firstname": "Ernest",
  "MiddleName": "Mohr, Morar and Schmitt",
  "Lastname": "Crona",
  "PersonId": 782,
  "Mrmrs": "facere",
  "ProjectMemberTypeName": "Ullrich Group",
  "Phone": "617.192.3315 x299",
  "PhoneId": 954,
  "ProjectMemberTypeId": 952,
  "EmailAddressName": "lazaro_king@steuberjohnson.name",
  "Comment": "perspiciatis",
  "FullName": "Xander Bednar",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 35
    }
  }
}
```