---
title: DEL List/{name}/Headings
uid: v1ListItemEntity_DeleteAllHeadingsFromName
generated: true
content_type: reference
---

# DEL List/{name}/Headings

```http
DELETE /api/v1/List/{name}/Headings
```

Delete all headings for list resolved by the provided name.






| Path Part | Type | Description |
|-----------|------|-------------|
| name | string | The name of the list to look up. **Required** |



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

[!include[sample request](../../samples/rest/request/v1ListItemEntity_DeleteAllHeadingsFromName.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1ListItemEntity_DeleteAllHeadingsFromName.md)]