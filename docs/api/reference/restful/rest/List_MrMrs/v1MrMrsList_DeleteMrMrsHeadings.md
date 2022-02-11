---
title: DEL List/MrMrs/Headings
id: v1MrMrsList_DeleteMrMrsHeadings
---

# DEL List/MrMrs/Headings

```http
DELETE /api/v1/List/MrMrs/Headings
```

Delete all headings for the MrMrs list.

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