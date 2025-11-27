---
title: DEL Contact/{id}/Image
uid: v1ContactEntity_DeleteImageContent
generated: true
content_type: reference
---

# DEL Contact/{id}/Image

```http
DELETE /api/v1/Contact/{contactId}/Image
```

Remove the contact image.






| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | Contact id **Required** |



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

[!include[sample request](../../samples/rest/request/v1ContactEntity_DeleteImageContent.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1ContactEntity_DeleteImageContent.md)]