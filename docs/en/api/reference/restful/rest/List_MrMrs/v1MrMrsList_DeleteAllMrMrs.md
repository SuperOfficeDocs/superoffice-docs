---
title: DEL List/MrMrs/Items
uid: v1MrMrsList_DeleteAllMrMrs
---

# DEL List/MrMrs/Items

```http
DELETE /api/v1/List/MrMrs/Items
```

Delete all the items in the MrMrs list.


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

### Response body: RecurrenceInfo


## Sample request

```http!
DELETE /api/v1/List/MrMrs/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```