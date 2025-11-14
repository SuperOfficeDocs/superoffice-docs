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


NsApiSlow threshold: 2000 ms.






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
  "ProjectEntityId": 240,
  "ProjectMembers": [
    {
      "ProjectmemberId": 998,
      "ContactId": 363,
      "ProjectId": 222,
      "ContactName": "Bartell-Tremblay",
      "ContactDepartment": "",
      "ProjectName": "Doyle, Satterfield and Halvorson",
      "EmailId": 898,
      "EmailAddress": "mable@gleichner.uk",
      "CountryId": 702,
      "Firstname": "Dayton",
      "MiddleName": "Aufderhar, Braun and Cassin",
      "Lastname": "Hackett",
      "PersonId": 182,
      "Mrmrs": "harum",
      "ProjectMemberTypeName": "Kshlerin-Braun",
      "Phone": "373-007-0225",
      "PhoneId": 391,
      "ProjectMemberTypeId": 919,
      "EmailAddressName": "jammie_cronin@kutch.uk",
      "Comment": "ex",
      "FullName": "Juvenal Collier",
      "Registered": "2008-05-19T02:30:47.6632017+02:00",
      "Updated": "2024-04-23T02:30:47.6632017+02:00"
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