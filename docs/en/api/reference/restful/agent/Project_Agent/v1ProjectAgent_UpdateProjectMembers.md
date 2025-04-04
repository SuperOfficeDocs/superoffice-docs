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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 49,
  "ProjectMembers": [
    {
      "ProjectmemberId": 577,
      "ContactId": 444,
      "ProjectId": 488,
      "ContactName": "Stanton, Schultz and Effertz",
      "ContactDepartment": "",
      "ProjectName": "Lueilwitz-Bauch",
      "EmailId": 603,
      "EmailAddress": "miracle_shanahan@lemke.name",
      "CountryId": 725,
      "Firstname": "Bernie",
      "MiddleName": "Price-Howe",
      "Lastname": "Casper",
      "PersonId": 731,
      "Mrmrs": "reprehenderit",
      "ProjectMemberTypeName": "Swaniawski-Crist",
      "Phone": "1-218-753-9721 x41919",
      "PhoneId": 95,
      "ProjectMemberTypeId": 323,
      "EmailAddressName": "curtis@ebert.co.uk",
      "Comment": "temporibus",
      "FullName": "Miss Melany Fisher PhD"
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