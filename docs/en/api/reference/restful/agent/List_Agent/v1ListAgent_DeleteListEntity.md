---
title: POST Agents/List/DeleteListEntity
uid: v1ListAgent_DeleteListEntity
generated: true
content_type: reference
---

# POST Agents/List/DeleteListEntity

```http
POST /api/v1/Agents/List/DeleteListEntity
```

Deletes the ListEntity


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| listEntityId | int32 | **Required** The identity of the ListEntity |

```http
POST /api/v1/Agents/List/DeleteListEntity?listEntityId=226
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

[!include[sample request](../../samples/agent/request/v1ListAgent_DeleteListEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ListAgent_DeleteListEntity.md)]