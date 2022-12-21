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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectEntityId": 352,
  "ProjectMembers": [
    {
      "ProjectmemberId": 151,
      "ContactId": 71,
      "ProjectId": 158,
      "ContactName": "Russel-Kutch",
      "ContactDepartment": "",
      "ProjectName": "Vandervort, Kemmer and Tremblay",
      "EmailId": 7,
      "EmailAddress": "elza.fritsch@crona.ca",
      "CountryId": 944,
      "Firstname": "Reina",
      "MiddleName": "Blanda-Ruecker",
      "Lastname": "Daniel",
      "PersonId": 446,
      "Mrmrs": "aperiam",
      "ProjectMemberTypeName": "Ward-Herman",
      "Phone": "(240)510-3251",
      "PhoneId": 622,
      "ProjectMemberTypeId": 915,
      "EmailAddressName": "alexie.kuhn@tromp.ca",
      "Comment": "pariatur",
      "FullName": "Lisandro Hyatt"
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