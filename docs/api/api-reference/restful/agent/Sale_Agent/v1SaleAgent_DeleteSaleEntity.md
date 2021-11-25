---
title: POST Agents/Sale/DeleteSaleEntity
id: v1SaleAgent_DeleteSaleEntity
---

# POST Agents/Sale/DeleteSaleEntity

```http
POST /api/v1/Agents/Sale/DeleteSaleEntity
```

Deletes the SaleEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| SaleEntityId | int32 | **Required** The id of the SaleEntity to be deleted. |

```http
POST /api/v1/Agents/Sale/DeleteSaleEntity?SaleEntityId=167
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |