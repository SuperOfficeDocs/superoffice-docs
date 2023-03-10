---
title: POST Agents/Project/GetProjectMembers
uid: v1ProjectAgent_GetProjectMembers
---

# POST Agents/Project/GetProjectMembers

```http
POST /api/v1/Agents/Project/GetProjectMembers
```

Returns an array of project members







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectMembers?$select=name,department,category/id
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

ProjectId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/GetProjectMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 395
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ProjectmemberId": 39,
    "ContactId": 325,
    "ProjectId": 642,
    "ContactName": "Medhurst-Wuckert",
    "ContactDepartment": "",
    "ProjectName": "Dach-Anderson",
    "EmailId": 324,
    "EmailAddress": "eugenia.bergnaum@reichert.us",
    "CountryId": 347,
    "Firstname": "Buddy",
    "MiddleName": "Zieme-Heaney",
    "Lastname": "Larson",
    "PersonId": 638,
    "Mrmrs": "tenetur",
    "ProjectMemberTypeName": "Miller, Langosh and Simonis",
    "Phone": "759.406.3726 x415",
    "PhoneId": 334,
    "ProjectMemberTypeId": 972,
    "EmailAddressName": "christine.flatley@christiansenhauck.info",
    "Comment": "numquam",
    "FullName": "Ashley Jacobs",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 630
      }
    }
  }
]
```