---
title: DEL Product/{id}
id: v1Product_DeleteProduct
---

# DEL Product/{id}

```http
DELETE /api/v1/Product/{id}
```

Deletes the Product

Calls the Quote agent service DeleteProduct.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Product to be deleted. **Required** |

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response

| Response | Description |
|----------------|-------------|
| 204 | Product deleted. |
