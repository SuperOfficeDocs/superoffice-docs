---
title: DEL Sale/{id}
uid: v1SaleEntity_DeleteSaleEntity
generated: true
content_type: reference
---

# DEL Sale/{id}

```http
DELETE /api/v1/Sale/{id}
```

Deletes the SaleEntity


Calls the Sale agent service DeleteSaleEntity.
NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

SaleEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | SaleEntity deleted. |
| 412 | Delete aborted because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1SaleEntity_DeleteSaleEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1SaleEntity_DeleteSaleEntity.md)]