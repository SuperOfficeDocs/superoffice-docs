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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 216,
  "ProjectMembers": [
    {
      "ProjectmemberId": 824,
      "ContactId": 500,
      "ProjectId": 278,
      "ContactName": "Hackett, Shields and Harber",
      "ContactDepartment": "",
      "ProjectName": "Bechtelar Group",
      "EmailId": 855,
      "EmailAddress": "monica_lebsack@haley.ca",
      "CountryId": 836,
      "Firstname": "Laurence",
      "MiddleName": "Parker Inc and Sons",
      "Lastname": "Cormier",
      "PersonId": 416,
      "Mrmrs": "inventore",
      "ProjectMemberTypeName": "Jacobs, Rodriguez and VonRueden",
      "Phone": "583-042-3016",
      "PhoneId": 262,
      "ProjectMemberTypeId": 537,
      "EmailAddressName": "jordy@brekkefriesen.uk",
      "Comment": "amet",
      "FullName": "Dewitt Schuster"
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