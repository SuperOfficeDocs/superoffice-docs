---
title: DEL List/WebPanel/Items/{id}
uid: v1WebPanelEntityList_DeleteWebPanelEntity
generated: true
content_type: reference
---

# DEL List/WebPanel/Items/{id}

```http
DELETE /api/v1/List/WebPanel/Items/{id}
```

Marks the existing WebPanelEntity as deleted.


Calls the List agent service SaveWebPanelEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of WebPanelEntity to be marked as deleted. **Required** |



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

[!include[sample request](../../samples/rest/request/v1WebPanelEntityList_DeleteWebPanelEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1WebPanelEntityList_DeleteWebPanelEntity.md)]