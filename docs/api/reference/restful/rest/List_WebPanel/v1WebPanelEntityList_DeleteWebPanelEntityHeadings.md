---
title: DEL List/WebPanel/Headings
id: v1WebPanelEntityList_DeleteWebPanelEntityHeadings
---

# DEL List/WebPanel/Headings

```http
DELETE /api/v1/List/WebPanel/Headings
```

Delete all headings for the WebPanelEntity list.

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
