---
title: PUT ProjectMember/{id}
uid: v1ProjectMember_PutProjectMember
generated: true
---

# PUT ProjectMember/{id}

```http
PUT /api/v1/ProjectMember/{id}
```

Updates the existing ProjectMember






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectMember id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/ProjectMember/{id}?$select=name,department,category/id
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

ProjectMember updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectMember updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/ProjectMember/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 757,
  "ContactId": 358,
  "ProjectId": 109,
  "ContactName": "Oberbrunner Group",
  "ContactDepartment": "",
  "ProjectName": "Cormier, Davis and Jewess",
  "EmailId": 942,
  "EmailAddress": "thalia_huel@stromangoldner.biz",
  "CountryId": 987,
  "Firstname": "Erica",
  "MiddleName": "Cummings Inc and Sons",
  "Lastname": "McGlynn",
  "PersonId": 124,
  "Mrmrs": "amet",
  "ProjectMemberTypeName": "Lowe-Welch",
  "Phone": "122.481.6284 x402",
  "PhoneId": 456,
  "ProjectMemberTypeId": 714,
  "EmailAddressName": "kyler.witting@franecki.us",
  "Comment": "amet",
  "FullName": "Marley Farrell"
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectMember updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 243,
  "ContactId": 806,
  "ProjectId": 115,
  "ContactName": "Spencer Inc and Sons",
  "ContactDepartment": "",
  "ProjectName": "Boyer-Veum",
  "EmailId": 944,
  "EmailAddress": "christa.gottlieb@robelward.us",
  "CountryId": 749,
  "Firstname": "Damon",
  "MiddleName": "Wolf Inc and Sons",
  "Lastname": "Kilback",
  "PersonId": 130,
  "Mrmrs": "voluptate",
  "ProjectMemberTypeName": "Gutkowski Inc and Sons",
  "Phone": "810-689-5938",
  "PhoneId": 434,
  "ProjectMemberTypeId": 277,
  "EmailAddressName": "kenna_fadel@connelly.info",
  "Comment": "perferendis",
  "FullName": "Miss Elmer Serena Hills III",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 729
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```