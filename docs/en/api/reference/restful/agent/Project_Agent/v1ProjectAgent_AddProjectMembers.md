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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 690,
  "ProjectMembers": [
    {
      "ProjectmemberId": 677,
      "ContactId": 316,
      "ProjectId": 122,
      "ContactName": "Rolfson-Bins",
      "ContactDepartment": "",
      "ProjectName": "Rogahn Group",
      "EmailId": 691,
      "EmailAddress": "talon@kuphalhermiston.name",
      "CountryId": 36,
      "Firstname": "Steve",
      "MiddleName": "Streich, Baumbach and Klocko",
      "Lastname": "Bosco",
      "PersonId": 474,
      "Mrmrs": "voluptatem",
      "ProjectMemberTypeName": "Wiza, Wilkinson and Schaefer",
      "Phone": "922-027-1414 x76511",
      "PhoneId": 703,
      "ProjectMemberTypeId": 984,
      "EmailAddressName": "tanya@kertzmannhermann.com",
      "Comment": "quae",
      "FullName": "Keshaun Hickle"
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