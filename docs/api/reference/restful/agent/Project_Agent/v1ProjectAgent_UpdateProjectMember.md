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
    "ProjectmemberId": 47,
    "ContactId": 385,
    "ProjectId": 30,
    "ContactName": "O'Connell LLC",
    "ContactDepartment": "scale customized channels",
    "ProjectName": "Sipes, Nolan and Macejkovic",
    "EmailId": 321,
    "EmailAddress": "dewayne@christiansen.us",
    "CountryId": 231,
    "Firstname": "Syble",
    "MiddleName": "Zboncak Group",
    "Lastname": "Cassin",
    "PersonId": 396,
    "Mrmrs": "nostrum",
    "ProjectMemberTypeName": "Parisian, Dicki and Hamill",
    "Phone": "160-641-3633 x130",
    "PhoneId": 602,
    "ProjectMemberTypeId": 829,
    "EmailAddressName": "jade@barrows.uk",
    "Comment": "aliquam",
    "FullName": "Domenica Rohan"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 381,
  "ContactId": 40,
  "ProjectId": 456,
  "ContactName": "Muller-Franecki",
  "ContactDepartment": "",
  "ProjectName": "Heller LLC",
  "EmailId": 854,
  "EmailAddress": "judge@russel.us",
  "CountryId": 343,
  "Firstname": "Mathew",
  "MiddleName": "Kirlin, Berge and Kiehn",
  "Lastname": "Towne",
  "PersonId": 93,
  "Mrmrs": "facere",
  "ProjectMemberTypeName": "Wisozk-Maggio",
  "Phone": "1-567-273-0160 x5477",
  "PhoneId": 731,
  "ProjectMemberTypeId": 560,
  "EmailAddressName": "claudie@haag.ca",
  "Comment": "reiciendis",
  "FullName": "Miss Kacie Dare",
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
      "FieldLength": 590
    }
  }
}
```