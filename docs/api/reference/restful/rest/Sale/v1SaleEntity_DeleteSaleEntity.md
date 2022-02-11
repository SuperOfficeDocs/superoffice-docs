---
title: DEL Sale/{id}
id: v1SaleEntity_DeleteSaleEntity
---

# DEL Sale/{id}

```http
DELETE /api/v1/Sale/{id}
```

Deletes the SaleEntity

Calls the Sale agent service DeleteSaleEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | SaleEntity deleted. |
| 412 | Delete aborted because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |