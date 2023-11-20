---
title: POST Agents/List/DeleteTicketStatusEntity
uid: v1ListAgent_DeleteTicketStatusEntity
generated: true
---

# POST Agents/List/DeleteTicketStatusEntity

```http
POST /api/v1/Agents/List/DeleteTicketStatusEntity
```

Deletes the TicketStatusEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| TicketStatusEntityId | int32 | **Required** The id of the TicketStatusEntity to be deleted. |

```http
POST /api/v1/Agents/List/DeleteTicketStatusEntity?TicketStatusEntityId=583
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/List/DeleteTicketStatusEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```