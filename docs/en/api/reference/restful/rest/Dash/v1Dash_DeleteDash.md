---
title: DEL Dash/{id}
uid: v1Dash_DeleteDash
generated: true
content_type: reference
---

# DEL Dash/{id}

```http
DELETE /api/v1/Dash/{id}
```

Deletes the Dash


Calls the Dash agent service DeleteDash.
NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dash to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

Dash deleted.

| Response | Description |
|----------------|-------------|
| 204 | Dash deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1Dash_DeleteDash.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1Dash_DeleteDash.md)]