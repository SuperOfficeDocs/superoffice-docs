---
title: POST Person/UdefLayout/Revert
uid: v1PersonEntity_RevertUdefLayout
generated: true
content_type: reference
---

# POST Person/UdefLayout/Revert

```http
POST /api/v1/Person/UdefLayout/Revert
```

Revert all un-published PersonEntity udef layout changes.


Reset to the currently published layout.







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

[!include[sample request](../../samples/rest/request/v1PersonEntity_RevertUdefLayout.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1PersonEntity_RevertUdefLayout.md)]