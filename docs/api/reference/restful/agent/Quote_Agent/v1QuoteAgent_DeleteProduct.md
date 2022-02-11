---
title: POST Agents/Quote/DeleteProduct
id: v1QuoteAgent_DeleteProduct
---

# POST Agents/Quote/DeleteProduct

```http
POST /api/v1/Agents/Quote/DeleteProduct
```

Deletes the Product







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ProductId | int32 | **Required** The id of the Product to be deleted. |

```http
POST /api/v1/Agents/Quote/DeleteProduct?ProductId=276
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