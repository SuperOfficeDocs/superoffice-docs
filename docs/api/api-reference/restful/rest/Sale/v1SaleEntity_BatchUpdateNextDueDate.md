---
title: POST Sale/NextDueDate
id: v1SaleEntity_BatchUpdateNextDueDate
---

# POST Sale/NextDueDate

```http
POST /api/v1/Sale/NextDueDate
```

Re-calculate all the next due dates








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