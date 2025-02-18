---
title: POST Agents/Project/AddProjectMembers
uid: v1ProjectAgent_AddProjectMembers
generated: true
---

# POST Agents/Project/AddProjectMembers

```http
POST /api/v1/Agents/Project/AddProjectMembers
```

Add multiple project members to a project







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/AddProjectMembers?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ProjectEntityId, ProjectMembers 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectEntityId | Integer |  |
| ProjectMembers | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Project/AddProjectMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 541,
  "ProjectMembers": [
    {
      "ProjectmemberId": 429,
      "ContactId": 427,
      "ProjectId": 124,
      "ContactName": "Fisher-Larkin",
      "ContactDepartment": "",
      "ProjectName": "Zboncak, Fisher and Stamm",
      "EmailId": 637,
      "EmailAddress": "verla@satterfield.uk",
      "CountryId": 885,
      "Firstname": "Wallace",
      "MiddleName": "Roob Inc and Sons",
      "Lastname": "Schroeder",
      "PersonId": 104,
      "Mrmrs": "ratione",
      "ProjectMemberTypeName": "Romaguera, O'Kon and Jacobi",
      "Phone": "(152)237-8741 x8440",
      "PhoneId": 563,
      "ProjectMemberTypeId": 476,
      "EmailAddressName": "roy@watsicawintheiser.co.uk",
      "Comment": "odit",
      "FullName": "Ms. Godfrey Goodwin"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```