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
| ProjectEntityId | int32 |  |
| ProjectMembers | array |  |


## Response: 

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body: 


## Sample request

```http!
POST /api/v1/Agents/Project/AddProjectMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 900,
  "ProjectMembers": [
    {
      "ProjectmemberId": 749,
      "ContactId": 871,
      "ProjectId": 628,
      "ContactName": "Barton, Blanda and Mitchell",
      "ContactDepartment": "",
      "ProjectName": "Cremin Group",
      "EmailId": 203,
      "EmailAddress": "fiona_kunde@torpbechtelar.info",
      "CountryId": 229,
      "Firstname": "Sharon",
      "MiddleName": "Rosenbaum-Bayer",
      "Lastname": "Stiedemann",
      "PersonId": 694,
      "Mrmrs": "sed",
      "ProjectMemberTypeName": "Langworth, Cummings and Stark",
      "Phone": "328-803-5470 x6975",
      "PhoneId": 990,
      "ProjectMemberTypeId": 656,
      "EmailAddressName": "arnulfo.hackett@smithledner.info",
      "Comment": "rem",
      "FullName": "Jeffery Morar"
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