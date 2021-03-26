---
title: DEL List/{udListDefinitionName}/Items
id: v1ListItemEntity_DeleteAllFromListName
---

# DEL List/{udListDefinitionName}/Items

```http
DELETE /api/v1/List/{udListDefinitionName}/Items
```

Marks all items in the list deleted






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to delete the items from. **Required** |



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