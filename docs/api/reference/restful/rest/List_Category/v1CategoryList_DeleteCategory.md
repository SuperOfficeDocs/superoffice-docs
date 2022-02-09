---
title: DEL List/Category/Items/{id}
id: v1CategoryList_DeleteCategory
---

# DEL List/Category/Items/{id}

```http
DELETE /api/v1/List/Category/Items/{id}
```

Marks the existing Category list item as deleted.

Calls the List agent service SaveFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of Category list item to be marked as deleted. **Required** |



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