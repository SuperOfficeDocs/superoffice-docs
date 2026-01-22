---
title: DEL TicketRelationDefinition/{id}
uid: v1TicketRelationDefinitionEntity_DeleteTicketRelationDefinitionEntity
generated: true
content_type: reference
---

# DEL TicketRelationDefinition/{id}

```http
DELETE /api/v1/TicketRelationDefinition/{id}
```

Deletes the TicketRelationDefinitionEntity


Calls the List agent service DeleteTicketRelationDefinitionEntity.
NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketRelationDefinitionEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

TicketRelationDefinitionEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | TicketRelationDefinitionEntity deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1TicketRelationDefinitionEntity_DeleteTicketRelationDefinitionEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1TicketRelationDefinitionEntity_DeleteTicketRelationDefinitionEntity.md)]