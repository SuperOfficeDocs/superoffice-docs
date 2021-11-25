---
title: POST Agents/Project/SaveProjectMember
id: v1ProjectAgent_SaveProjectMember
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
POST /api/v1/Agents/Project/SaveProjectMember
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 913,
  "ContactId": 416,
  "ProjectId": 187,
  "ContactName": "Hauck, Greenholt and Huel",
  "ContactDepartment": "",
  "ProjectName": "Zemlak Inc and Sons",
  "EmailId": 649,
  "EmailAddress": "marlen@sauer.us",
  "CountryId": 458,
  "Firstname": "Ubaldo",
  "MiddleName": "Miller, Bogan and Considine",
  "Lastname": "Walker",
  "PersonId": 595,
  "Mrmrs": "numquam",
  "ProjectMemberTypeName": "Haley Group",
  "Phone": "1-063-344-6103",
  "PhoneId": 804,
  "ProjectMemberTypeId": 266,
  "EmailAddressName": "tressa_renner@bayer.uk",
  "Comment": "nihil",
  "FullName": "Ernestine Baumbach"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectmemberId": 801,
  "ContactId": 341,
  "ProjectId": 78,
  "ContactName": "Medhurst Group",
  "ContactDepartment": "",
  "ProjectName": "Gibson-Wintheiser",
  "EmailId": 272,
  "EmailAddress": "laura_paucek@ward.info",
  "CountryId": 48,
  "Firstname": "Montana",
  "MiddleName": "D'Amore-Lind",
  "Lastname": "Mayert",
  "PersonId": 570,
  "Mrmrs": "ipsam",
  "ProjectMemberTypeName": "Abbott Group",
  "Phone": "848.016.7318 x777",
  "PhoneId": 917,
  "ProjectMemberTypeId": 948,
  "EmailAddressName": "sabina@torphy.us",
  "Comment": "rerum",
  "FullName": "Micheal Armstrong",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "productize real-time infrastructures"
      },
      "FieldType": "System.String",
      "FieldLength": 453
    }
  }
}
```