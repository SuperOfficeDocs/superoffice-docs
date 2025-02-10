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
  "ProjectEntityId": 319,
  "ProjectMembers": [
    {
      "ProjectmemberId": 837,
      "ContactId": 79,
      "ProjectId": 57,
      "ContactName": "Wuckert Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Rowe Group",
      "EmailId": 666,
      "EmailAddress": "amelie@pfefferlindgren.us",
      "CountryId": 250,
      "Firstname": "Creola",
      "MiddleName": "Koss, Jaskolski and Ebert",
      "Lastname": "Durgan",
      "PersonId": 750,
      "Mrmrs": "cum",
      "ProjectMemberTypeName": "Schumm-Pfeffer",
      "Phone": "269-284-3557 x1928",
      "PhoneId": 664,
      "ProjectMemberTypeId": 757,
      "EmailAddressName": "jaiden@johnsonhomenick.com",
      "Comment": "consequatur",
      "FullName": "Kathryn Wehner"
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