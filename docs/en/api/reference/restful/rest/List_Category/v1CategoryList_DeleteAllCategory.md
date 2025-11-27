---
title: DEL List/Category/Items
uid: v1CategoryList_DeleteAllCategory
generated: true
content_type: reference
---

# DEL List/Category/Items

```http
DELETE /api/v1/List/Category/Items
```

Delete all the items in the Category list.


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

[!include[sample request](../../samples/rest/request/v1CategoryList_DeleteAllCategory.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CategoryList_DeleteAllCategory.md)]