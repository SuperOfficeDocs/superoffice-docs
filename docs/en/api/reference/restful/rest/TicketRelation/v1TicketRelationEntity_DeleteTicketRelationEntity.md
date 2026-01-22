---
title: DEL TicketRelation/{id}
uid: v1TicketRelationEntity_DeleteTicketRelationEntity
generated: true
content_type: reference
---

# DEL TicketRelation/{id}

```http
DELETE /api/v1/TicketRelation/{id}
```

Deletes the TicketRelationEntity


Calls the Ticket agent service DeleteTicketRelationEntity.
NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketRelationEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

TicketRelationEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | TicketRelationEntity deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1TicketRelationEntity_DeleteTicketRelationEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1TicketRelationEntity_DeleteTicketRelationEntity.md)]