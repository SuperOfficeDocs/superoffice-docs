---
title: DEL List/Task/Headings
uid: v1TaskList_DeleteTaskListItemHeadings
generated: true
content_type: reference
---

# DEL List/Task/Headings

```http
DELETE /api/v1/List/Task/Headings
```

Delete all headings for the TaskListItem list.


Calls the List agent service DeleteAllHeadingsFromListDefinition.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1TaskList_DeleteTaskListItemHeadings.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1TaskList_DeleteTaskListItemHeadings.md)]