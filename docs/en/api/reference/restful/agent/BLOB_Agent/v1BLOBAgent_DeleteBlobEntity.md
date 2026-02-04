---
title: POST Agents/BLOB/DeleteBlobEntity
uid: v1BLOBAgent_DeleteBlobEntity
generated: true
content_type: reference
---

# POST Agents/BLOB/DeleteBlobEntity

```http
POST /api/v1/Agents/BLOB/DeleteBlobEntity
```

Deletes the BlobEntity


NsApiSlow threshold: 3000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| blobEntityId | int32 | **Required** The identity of the BlobEntity |

```http
POST /api/v1/Agents/BLOB/DeleteBlobEntity?blobEntityId=21
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

[!include[sample request](../../samples/agent/request/v1BLOBAgent_DeleteBlobEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1BLOBAgent_DeleteBlobEntity.md)]