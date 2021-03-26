---
title: POST Agents/Project/UpdateProjectMember
id: v1ProjectAgent_UpdateProjectMember
---

# POST Agents/Project/UpdateProjectMember

```http
POST /api/v1/Agents/Project/UpdateProjectMember
```

Updates a ProjectMember row.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/UpdateProjectMember?$select=name,department,category/id
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

## Request Body: request  

ProjectMember 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectMember |  | A person can be a member of multiple projects, with a different comment and member type in each project. <para /> Carrier object for ProjectMember. Services for the ProjectMember Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IProjectAgent">Project Agent</see>. |


## Response: object

A person can be a member of multiple projects, with a different comment and member type in each project.



Carrier object for ProjectMember.
Services for the ProjectMember Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IProjectAgent">Project Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
POST /api/v1/Agents/Project/UpdateProjectMember
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectMember": {
    "ProjectmemberId": 811,
    "ContactId": 267,
    "ProjectId": 901,
    "ContactName": "Prosacco LLC",
    "ContactDepartment": "",
    "ProjectName": "Collins, Funk and Braun",
    "EmailId": 912,
    "EmailAddress": "clarissa@corkery.name",
    "CountryId": 82,
    "Firstname": "Michaela",
    "MiddleName": "Crooks, Schroeder and Blanda",
    "Lastname": "Cormier",
    "PersonId": 765,
    "Mrmrs": "consequatur",
    "ProjectMemberTypeName": "Little, Breitenberg and Jerde",
    "Phone": "557.103.1802 x60202",
    "PhoneId": 179,
    "ProjectMemberTypeId": 182,
    "EmailAddressName": "ida_torp@oberbrunnerklein.info",
    "Comment": "earum",
    "FullName": "Rick Schaefer"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 136,
  "ContactId": 467,
  "ProjectId": 718,
  "ContactName": "Feeney-Wisozk",
  "ContactDepartment": "",
  "ProjectName": "Kozey-Schneider",
  "EmailId": 362,
  "EmailAddress": "leopold.wiza@mooredaugherty.biz",
  "CountryId": 472,
  "Firstname": "Dennis",
  "MiddleName": "Carter LLC",
  "Lastname": "Mante",
  "PersonId": 101,
  "Mrmrs": "voluptates",
  "ProjectMemberTypeName": "Bergnaum-Purdy",
  "Phone": "405.806.0823",
  "PhoneId": 226,
  "ProjectMemberTypeId": 677,
  "EmailAddressName": "pierre@lueilwitz.biz",
  "Comment": "harum",
  "FullName": "Eda Buckridge II",
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
      "FieldLength": 980
    }
  }
}
```