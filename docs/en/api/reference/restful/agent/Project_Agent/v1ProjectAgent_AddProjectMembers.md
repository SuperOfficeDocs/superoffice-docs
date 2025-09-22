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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 206,
  "ProjectMembers": [
    {
      "ProjectmemberId": 206,
      "ContactId": 168,
      "ProjectId": 214,
      "ContactName": "Hintz, Reynolds and Bergstrom",
      "ContactDepartment": "",
      "ProjectName": "Rosenbaum Inc and Sons",
      "EmailId": 986,
      "EmailAddress": "margret@rosenbaum.info",
      "CountryId": 244,
      "Firstname": "Kale",
      "MiddleName": "Mraz, Hirthe and Pollich",
      "Lastname": "Prohaska",
      "PersonId": 425,
      "Mrmrs": "quod",
      "ProjectMemberTypeName": "Kerluke Inc and Sons",
      "Phone": "500.329.9187",
      "PhoneId": 536,
      "ProjectMemberTypeId": 610,
      "EmailAddressName": "ashton.prosacco@reichel.uk",
      "Comment": "quia",
      "FullName": "Henry Stanton",
      "Registered": "2008-07-30T11:24:48.4688922+02:00",
      "Updated": "2018-06-25T11:24:48.4688922+02:00"
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