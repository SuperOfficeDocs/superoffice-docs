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
  "ProjectEntityId": 81,
  "ProjectMembers": [
    {
      "ProjectmemberId": 280,
      "ContactId": 160,
      "ProjectId": 674,
      "ContactName": "Bradtke Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Moen, Sanford and Doyle",
      "EmailId": 804,
      "EmailAddress": "raoul@wehner.biz",
      "CountryId": 715,
      "Firstname": "Willie",
      "MiddleName": "Boyle-Hagenes",
      "Lastname": "Boyer",
      "PersonId": 783,
      "Mrmrs": "pariatur",
      "ProjectMemberTypeName": "Marvin Inc and Sons",
      "Phone": "1-748-833-5602 x2450",
      "PhoneId": 940,
      "ProjectMemberTypeId": 614,
      "EmailAddressName": "lura@haagkertzmann.name",
      "Comment": "eveniet",
      "FullName": "Chesley Schaefer"
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