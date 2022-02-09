---
title: DEL List/Category/Headings
id: v1CategoryList_DeleteCategoryHeadings
---

# DEL List/Category/Headings

```http
DELETE /api/v1/List/Category/Headings
```

Delete all headings for the Category list.

Calls the List agent service DeleteAllHeadingsFromListDefinition.






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