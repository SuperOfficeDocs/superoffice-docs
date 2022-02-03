---
title: DEL List/{name}
id: v1ListEntity_DeleteListEntityByName
---

# DEL List/{name}

```http
DELETE /api/v1/List/{name}
```

Delete a ListEntity resolved by the provided name.






| Path Part | Type | Description |
|-----------|------|-------------|
| name | string | The name of the list to delete. **Required** |



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