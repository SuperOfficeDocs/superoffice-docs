---
title: POST Agents/Project/AddProjectMembers
uid: v1ProjectAgent_AddProjectMembers
generated: true
content_type: reference
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
  "ProjectEntityId": 499,
  "ProjectMembers": [
    {
      "ProjectmemberId": 429,
      "ContactId": 687,
      "ProjectId": 332,
      "ContactName": "Auer, Wintheiser and Gaylord",
      "ContactDepartment": "",
      "ProjectName": "Lowe-Stokes",
      "EmailId": 211,
      "EmailAddress": "pietro@bogan.biz",
      "CountryId": 877,
      "Firstname": "Jewell",
      "MiddleName": "Wolff Inc and Sons",
      "Lastname": "Halvorson",
      "PersonId": 355,
      "Mrmrs": "dignissimos",
      "ProjectMemberTypeName": "Hilll-Hand",
      "Phone": "120-927-8992",
      "PhoneId": 562,
      "ProjectMemberTypeId": 37,
      "EmailAddressName": "ocie_bogisich@leuschke.ca",
      "Comment": "similique",
      "FullName": "Addison Wyman",
      "Registered": "2020-05-05T03:41:53.9025923+02:00",
      "Updated": "2013-12-01T03:41:53.9025923+01:00"
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