---
title: POST Agents/Sale/DeleteSaleStakeholder
id: v1SaleAgent_DeleteSaleStakeholder
---

# POST Agents/Sale/DeleteSaleStakeholder

```http
POST /api/v1/Agents/Sale/DeleteSaleStakeholder
```

Deletes the SaleStakeholder

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| SaleStakeholderId | int32 | **Required** The id of the SaleStakeholder to be deleted. |

```http
POST /api/v1/Agents/Sale/DeleteSaleStakeholder?SaleStakeholderId=229
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
