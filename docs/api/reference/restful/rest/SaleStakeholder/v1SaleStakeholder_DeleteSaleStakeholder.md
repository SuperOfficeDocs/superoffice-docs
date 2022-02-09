---
title: DEL SaleStakeholder/{id}
id: v1SaleStakeholder_DeleteSaleStakeholder
---

# DEL SaleStakeholder/{id}

```http
DELETE /api/v1/SaleStakeholder/{id}
```

Deletes the SaleStakeholder

Calls the Sale agent service DeleteSaleStakeholder.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleStakeholder to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | SaleStakeholder deleted. |