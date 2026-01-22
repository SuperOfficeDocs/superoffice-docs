---
title: POST Agents/Project/DeleteProjectEntity
uid: v1ProjectAgent_DeleteProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/DeleteProjectEntity

```http
POST /api/v1/Agents/Project/DeleteProjectEntity
```

Deletes the ProjectEntity


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEntityId | int32 | **Required** The identity of the ProjectEntity |

```http
POST /api/v1/Agents/Project/DeleteProjectEntity?projectEntityId=888
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

[!include[sample request](../../samples/agent/request/v1ProjectAgent_DeleteProjectEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ProjectAgent_DeleteProjectEntity.md)]