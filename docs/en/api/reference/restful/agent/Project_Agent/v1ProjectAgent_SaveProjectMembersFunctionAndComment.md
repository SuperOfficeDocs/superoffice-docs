---
title: POST Agents/Project/SaveProjectMembersFunctionAndComment
uid: v1ProjectAgent_SaveProjectMembersFunctionAndComment
generated: true
---

# POST Agents/Project/SaveProjectMembersFunctionAndComment

```http
POST /api/v1/Agents/Project/SaveProjectMembersFunctionAndComment
```

Saves role and comment on an array of projectmembers represented by ids







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/SaveProjectMembersFunctionAndComment?$select=name,department,category/id
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

ProjectMemberIds, RoleId, Comment 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectMemberIds | Array |  |
| RoleId | Integer |  |
| Comment | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectMembersFunctionAndComment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectMemberIds": [
    429,
    112
  ],
  "RoleId": 833,
  "Comment": "non"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```