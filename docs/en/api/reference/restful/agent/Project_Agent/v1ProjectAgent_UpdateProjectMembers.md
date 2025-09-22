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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 568,
  "ProjectMembers": [
    {
      "ProjectmemberId": 997,
      "ContactId": 695,
      "ProjectId": 640,
      "ContactName": "Russel Group",
      "ContactDepartment": "target sticky content",
      "ProjectName": "Schinner Inc and Sons",
      "EmailId": 327,
      "EmailAddress": "freda@maggio.name",
      "CountryId": 493,
      "Firstname": "Isabell",
      "MiddleName": "Friesen-Anderson",
      "Lastname": "Feest",
      "PersonId": 222,
      "Mrmrs": "cumque",
      "ProjectMemberTypeName": "Kreiger-Corwin",
      "Phone": "1-666-564-7493 x2954",
      "PhoneId": 708,
      "ProjectMemberTypeId": 9,
      "EmailAddressName": "sandra.cassin@hettinger.biz",
      "Comment": "ea",
      "FullName": "Amely Funk",
      "Registered": "2021-08-10T11:24:48.5001409+02:00",
      "Updated": "2011-06-25T11:24:48.5001409+02:00"
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