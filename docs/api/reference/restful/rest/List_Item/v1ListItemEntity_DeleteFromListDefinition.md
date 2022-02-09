---
title: DEL List/{id}/Items/{id}
id: v1ListItemEntity_DeleteFromListDefinition
---

# DEL List/{id}/Items/{id}

```http
DELETE /api/v1/List/{udListDefinitionId}/Items/{id}
```

Delete a list item from the specified list defintion






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The identity of the list item to delete **Required** |
| udListDefinitionId | int32 | The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |



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