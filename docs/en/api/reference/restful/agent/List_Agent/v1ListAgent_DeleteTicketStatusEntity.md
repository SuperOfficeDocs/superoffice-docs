---
title: POST Agents/List/DeleteTicketStatusEntity
uid: v1ListAgent_DeleteTicketStatusEntity
generated: true
content_type: reference
---

# POST Agents/List/DeleteTicketStatusEntity

```http
POST /api/v1/Agents/List/DeleteTicketStatusEntity
```

Deletes the TicketStatusEntity


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketStatusEntityId | int32 | **Required** The identity of the TicketStatusEntity |

```http
POST /api/v1/Agents/List/DeleteTicketStatusEntity?ticketStatusEntityId=709
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

[!include[sample request](../../samples/agent/request/v1ListAgent_DeleteTicketStatusEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ListAgent_DeleteTicketStatusEntity.md)]