---
title: POST Agents/Project/UpdateProjectMembers
uid: v1ProjectAgent_UpdateProjectMembers
generated: true
content_type: reference
---

# POST Agents/Project/UpdateProjectMembers

```http
POST /api/v1/Agents/Project/UpdateProjectMembers
```

Update existing project members.


Not creating new (only projectmember_id &gt; 0 accepted)
NsApiSlow threshold: 2000 ms.






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
  "ProjectId": 867,
  "ProjectMembers": [
    {
      "ProjectmemberId": 776,
      "ContactId": 165,
      "ProjectId": 542,
      "ContactName": "Russel Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Daugherty Group",
      "EmailId": 954,
      "EmailAddress": "annette@borer.us",
      "CountryId": 290,
      "Firstname": "Anabelle",
      "MiddleName": "Russel Inc and Sons",
      "Lastname": "Schinner",
      "PersonId": 306,
      "Mrmrs": "totam",
      "ProjectMemberTypeName": "Aufderhar-Kuvalis",
      "Phone": "1-706-797-7759 x775",
      "PhoneId": 778,
      "ProjectMemberTypeId": 598,
      "EmailAddressName": "eriberto_boehm@wilderman.com",
      "Comment": "cupiditate",
      "FullName": "Dr. Lenore Maegan Gottlieb I",
      "Registered": "2020-04-04T03:40:47.4999832+02:00",
      "Updated": "2017-10-28T03:40:47.4999832+02:00"
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