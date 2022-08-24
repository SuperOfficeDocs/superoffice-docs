---
title: POST Project/UdefLayout/Revert
id: v1ProjectEntity_RevertUdefLayout
---

# POST Project/UdefLayout/Revert

```http
POST /api/v1/Project/UdefLayout/Revert
```

Revert all un-published ProjectEntity udef layout changes.

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
