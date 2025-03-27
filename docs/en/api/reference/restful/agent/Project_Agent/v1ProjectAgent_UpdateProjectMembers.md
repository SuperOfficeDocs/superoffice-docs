---
title: POST Agents/Project/UpdateProjectMembers
uid: v1ProjectAgent_UpdateProjectMembers
generated: true
---

# POST Agents/Project/UpdateProjectMembers

```http
POST /api/v1/Agents/Project/UpdateProjectMembers
```

Update existing project members.


Not creating new (only projectmember_id &gt; 0 accepted)






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/UpdateProjectMembers?$select=name,department,category/id
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

ProjectId, ProjectMembers 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer |  |
| ProjectMembers | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Project/UpdateProjectMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 436,
  "ProjectMembers": [
    {
      "ProjectmemberId": 248,
      "ContactId": 930,
      "ProjectId": 347,
      "ContactName": "Turcotte, Kihn and Yundt",
      "ContactDepartment": "",
      "ProjectName": "Daugherty, Goldner and Emard",
      "EmailId": 525,
      "EmailAddress": "weldon@upton.us",
      "CountryId": 334,
      "Firstname": "Alia",
      "MiddleName": "Okuneva, Dietrich and Bechtelar",
      "Lastname": "Gislason",
      "PersonId": 778,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Deckow Inc and Sons",
      "Phone": "(042)547-8682 x6799",
      "PhoneId": 441,
      "ProjectMemberTypeId": 760,
      "EmailAddressName": "shania.fahey@bartonklein.name",
      "Comment": "pariatur",
      "FullName": "Miss Christophe Armstrong"
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