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
  "ProjectEntityId": 539,
  "ProjectMembers": [
    {
      "ProjectmemberId": 476,
      "ContactId": 537,
      "ProjectId": 503,
      "ContactName": "Schinner-Abernathy",
      "ContactDepartment": "",
      "ProjectName": "Labadie Inc and Sons",
      "EmailId": 98,
      "EmailAddress": "wade@hartmann.ca",
      "CountryId": 901,
      "Firstname": "Julianne",
      "MiddleName": "Leffler-Dooley",
      "Lastname": "Nienow",
      "PersonId": 775,
      "Mrmrs": "voluptates",
      "ProjectMemberTypeName": "Stark, Murazik and O'Keefe",
      "Phone": "(235)896-6927",
      "PhoneId": 526,
      "ProjectMemberTypeId": 262,
      "EmailAddressName": "samson@gerlach.biz",
      "Comment": "at",
      "FullName": "Trey Ebert"
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