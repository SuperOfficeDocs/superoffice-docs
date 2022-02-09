---
title: POST Document/UdefLayout/Revert
id: v1DocumentEntity_RevertUdefLayout
---

# POST Document/UdefLayout/Revert

```http
POST /api/v1/Document/UdefLayout/Revert
```

Revert all un-published DocumentEntity udef layout changes.

Reset to the currently published layout.






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