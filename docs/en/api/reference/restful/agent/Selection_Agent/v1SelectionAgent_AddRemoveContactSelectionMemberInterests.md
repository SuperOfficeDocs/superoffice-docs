---
title: POST Agents/Selection/AddRemoveContactSelectionMemberInterests
uid: v1SelectionAgent_AddRemoveContactSelectionMemberInterests
generated: true
---

# POST Agents/Selection/AddRemoveContactSelectionMemberInterests

```http
POST /api/v1/Agents/Selection/AddRemoveContactSelectionMemberInterests
```

Adds or removes interests on companies and persons in a selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/AddRemoveContactSelectionMemberInterests?$select=name,department,category/id
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

SelectionId, AddCompanyInterests, RemoveCompanyInterests, AddContactInterests, RemoveContactInterests 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | Integer |  |
| AddCompanyInterests | Array |  |
| RemoveCompanyInterests | Array |  |
| AddContactInterests | Array |  |
| RemoveContactInterests | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Selection/AddRemoveContactSelectionMemberInterests
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 136,
  "AddCompanyInterests": [
    390,
    948
  ],
  "RemoveCompanyInterests": [
    597,
    73
  ],
  "AddContactInterests": [
    861,
    275
  ],
  "RemoveContactInterests": [
    126,
    742
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```