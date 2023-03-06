---
title: POST Agents/Project/AddProjectMembers
uid: v1ProjectAgent_AddProjectMembers
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

### Response body: TableRight


## Sample request

```http!
POST /api/v1/Agents/Project/AddProjectMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 440,
  "ProjectMembers": [
    {
      "ProjectmemberId": 867,
      "ContactId": 640,
      "ProjectId": 47,
      "ContactName": "Runolfsdottir-Doyle",
      "ContactDepartment": "",
      "ProjectName": "Hettinger, Reichel and Rempel",
      "EmailId": 10,
      "EmailAddress": "clementina@koss.name",
      "CountryId": 239,
      "Firstname": "Emanuel",
      "MiddleName": "King Inc and Sons",
      "Lastname": "Heller",
      "PersonId": 189,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Hessel Inc and Sons",
      "Phone": "257.854.0401",
      "PhoneId": 900,
      "ProjectMemberTypeId": 391,
      "EmailAddressName": "kelton.kirlin@pfannerstillconroy.biz",
      "Comment": "omnis",
      "FullName": "Eleanora Prosacco"
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