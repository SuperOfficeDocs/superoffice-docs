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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 532,
  "ProjectMembers": [
    {
      "ProjectmemberId": 47,
      "ContactId": 640,
      "ProjectId": 520,
      "ContactName": "Gleichner-Weissnat",
      "ContactDepartment": "",
      "ProjectName": "Carroll, Hauck and Terry",
      "EmailId": 739,
      "EmailAddress": "juana_sanford@skiles.name",
      "CountryId": 310,
      "Firstname": "Dejah",
      "MiddleName": "Hettinger-Wintheiser",
      "Lastname": "Watsica",
      "PersonId": 260,
      "Mrmrs": "pariatur",
      "ProjectMemberTypeName": "Mraz, Runolfsson and Hoppe",
      "Phone": "204.198.7492",
      "PhoneId": 163,
      "ProjectMemberTypeId": 77,
      "EmailAddressName": "kamren@koss.us",
      "Comment": "soluta",
      "FullName": "Prof. Percy Simonis PhD"
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