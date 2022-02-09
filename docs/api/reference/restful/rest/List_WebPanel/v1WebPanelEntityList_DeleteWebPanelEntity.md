---
title: DEL List/WebPanel/Items/{id}
id: v1WebPanelEntityList_DeleteWebPanelEntity
---

# DEL List/WebPanel/Items/{id}

```http
DELETE /api/v1/List/WebPanel/Items/{id}
```

Marks the existing WebPanelEntity as deleted.

Calls the List agent service SaveWebPanelEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of WebPanelEntity to be marked as deleted. **Required** |



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