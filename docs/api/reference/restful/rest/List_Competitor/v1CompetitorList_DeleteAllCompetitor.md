---
title: DEL List/Competitor/Items
id: v1CompetitorList_DeleteAllCompetitor
---

# DEL List/Competitor/Items

```http
DELETE /api/v1/List/Competitor/Items
```

Delete all the items in the Competitor list.

Marks all existing items as deleted.






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