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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 276,
  "ProjectMembers": [
    {
      "ProjectmemberId": 53,
      "ContactId": 791,
      "ProjectId": 546,
      "ContactName": "Jenkins, Hettinger and Breitenberg",
      "ContactDepartment": "",
      "ProjectName": "Welch LLC",
      "EmailId": 659,
      "EmailAddress": "kelsi.mertz@lubowitz.us",
      "CountryId": 311,
      "Firstname": "Loy",
      "MiddleName": "Cummings, Kassulke and Kilback",
      "Lastname": "Kuhic",
      "PersonId": 843,
      "Mrmrs": "voluptatem",
      "ProjectMemberTypeName": "Rodriguez, Schmitt and Denesik",
      "Phone": "(426)520-5273 x357",
      "PhoneId": 362,
      "ProjectMemberTypeId": 373,
      "EmailAddressName": "chelsie@tillman.com",
      "Comment": "quaerat",
      "FullName": "Kaden Prohaska",
      "Registered": "2020-07-08T02:30:47.6944454+02:00",
      "Updated": "2009-08-07T02:30:47.6944454+02:00"
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