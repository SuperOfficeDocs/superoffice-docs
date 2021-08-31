---
title: UpdateProjectMember
id: v1ProjectAgent_UpdateProjectMember
---

# UpdateProjectMember

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectMember": {
    "ProjectmemberId": 780,
    "ContactId": 961,
    "ProjectId": 737,
    "ContactName": "Strosin LLC",
    "ContactDepartment": "",
    "ProjectName": "Hauck, Will and Murray",
    "EmailId": 59,
    "EmailAddress": "tavares@jerde.biz",
    "CountryId": 496,
    "Firstname": "Gina",
    "MiddleName": "Wilkinson Group",
    "Lastname": "Kerluke",
    "PersonId": 218,
    "Mrmrs": "dicta",
    "ProjectMemberTypeName": "Lind, Ullrich and Kuhn",
    "Phone": "1-517-210-8633",
    "PhoneId": 73,
    "ProjectMemberTypeId": 902,
    "EmailAddressName": "marlee@brakusbatz.name",
    "Comment": "illo",
    "FullName": "Santina Runolfsson"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 781,
  "ContactId": 845,
  "ProjectId": 362,
  "ContactName": "Strosin, McDermott and Ankunding",
  "ContactDepartment": "",
  "ProjectName": "Dooley LLC",
  "EmailId": 479,
  "EmailAddress": "rasheed.langosh@trantow.us",
  "CountryId": 733,
  "Firstname": "Judge",
  "MiddleName": "Gerhold-Vandervort",
  "Lastname": "Cremin",
  "PersonId": 980,
  "Mrmrs": "ipsam",
  "ProjectMemberTypeName": "Schoen Inc and Sons",
  "Phone": "106-427-2125 x064",
  "PhoneId": 990,
  "ProjectMemberTypeId": 575,
  "EmailAddressName": "clementine@kilbackwalsh.name",
  "Comment": "aliquam",
  "FullName": "Barry Beatty",
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
      "FieldLength": 395
    }
  }
}
```