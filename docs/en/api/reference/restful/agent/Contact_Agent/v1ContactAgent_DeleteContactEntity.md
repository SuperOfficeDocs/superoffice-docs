---
title: POST Agents/Contact/DeleteContactEntity
uid: v1ContactAgent_DeleteContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/DeleteContactEntity

```http
POST /api/v1/Agents/Contact/DeleteContactEntity
```

Deletes the ContactEntity.


This table supports Soft Delete; records will be marked as deleted and disappear from the GUI and API results, but will not be physically deleted by this (and any other) method.
NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The identity of the ContactEntity |

```http
POST /api/v1/Agents/Contact/DeleteContactEntity?contactEntityId=281
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

[!include[sample request](../../samples/agent/request/v1ContactAgent_DeleteContactEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ContactAgent_DeleteContactEntity.md)]