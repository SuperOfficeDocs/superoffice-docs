---
title: DEL List/ProductCategory/Items
id: v1ProductCategoryList_DeleteAllProductCategory
---

# DEL List/ProductCategory/Items

```http
DELETE /api/v1/List/ProductCategory/Items
```

Delete all the items in the ProductCategory list.

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
