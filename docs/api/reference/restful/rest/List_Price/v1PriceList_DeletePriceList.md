---
title: DEL Pricelist/{id}
id: v1PriceList_DeletePriceList
---

# DEL Pricelist/{id}

```http
DELETE /api/v1/Pricelist/{id}
```

Deletes the PriceList

Calls the Quote agent service DeletePriceList.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PriceList to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | PriceList deleted. |