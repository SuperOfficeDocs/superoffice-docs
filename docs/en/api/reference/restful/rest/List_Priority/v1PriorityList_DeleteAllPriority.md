---
title: DEL List/Priority/Items
uid: v1PriorityList_DeleteAllPriority
generated: true
content_type: reference
---

# DEL List/Priority/Items

```http
DELETE /api/v1/List/Priority/Items
```

Delete all the items in the Priority list.


Marks all existing items as deleted.







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

[!include[sample request](../../samples/rest/request/v1PriorityList_DeleteAllPriority.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1PriorityList_DeleteAllPriority.md)]