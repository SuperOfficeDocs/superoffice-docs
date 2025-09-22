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
  "ProjectmemberId": 561,
  "ContactId": 484,
  "ProjectId": 881,
  "ContactName": "Prohaska, Walter and Farrell",
  "ContactDepartment": "",
  "ProjectName": "Collins-Weber",
  "EmailId": 603,
  "EmailAddress": "eliane@gislason.uk",
  "CountryId": 980,
  "Firstname": "Elias",
  "MiddleName": "Huels-Ebert",
  "Lastname": "Morar",
  "PersonId": 671,
  "Mrmrs": "reprehenderit",
  "ProjectMemberTypeName": "Zieme, Ward and Bode",
  "Phone": "634-339-1416",
  "PhoneId": 831,
  "ProjectMemberTypeId": 786,
  "EmailAddressName": "tyrel.mcclure@rosenbaumheller.co.uk",
  "Comment": "sit",
  "FullName": "Rex Berge",
  "Registered": "2000-06-23T11:24:48.5001409+02:00",
  "Updated": "2017-05-20T11:24:48.5001409+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 947,
  "ContactId": 797,
  "ProjectId": 657,
  "ContactName": "Ondricka, Aufderhar and Ondricka",
  "ContactDepartment": "",
  "ProjectName": "Heller, Goodwin and Gusikowski",
  "EmailId": 350,
  "EmailAddress": "darrick@klingsporer.name",
  "CountryId": 735,
  "Firstname": "Lisandro",
  "MiddleName": "Bradtke-White",
  "Lastname": "Jaskolski",
  "PersonId": 55,
  "Mrmrs": "dolore",
  "ProjectMemberTypeName": "Mann-Dietrich",
  "Phone": "917-614-7888 x51103",
  "PhoneId": 393,
  "ProjectMemberTypeId": 934,
  "EmailAddressName": "toni.stamm@beahan.com",
  "Comment": "eum",
  "FullName": "Gia Sipes",
  "Registered": "2018-03-28T11:24:48.5001409+02:00",
  "Updated": "2012-08-19T11:24:48.5001409+02:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 773
    }
  }
}
```