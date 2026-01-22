---
title: POST Agents/Sale/DeleteSaleEntity
uid: v1SaleAgent_DeleteSaleEntity
generated: true
content_type: reference
---

# POST Agents/Sale/DeleteSaleEntity

```http
POST /api/v1/Agents/Sale/DeleteSaleEntity
```

Deletes the SaleEntity


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| saleEntityId | int32 | **Required** The identity of the SaleEntity |

```http
POST /api/v1/Agents/Sale/DeleteSaleEntity?saleEntityId=562
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

[!include[sample request](../../samples/agent/request/v1SaleAgent_DeleteSaleEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1SaleAgent_DeleteSaleEntity.md)]