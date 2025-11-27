---
title: DEL Person/{id}/Consent/{purpose}
uid: v1PersonEntity_RemoveConsent
generated: true
content_type: reference
---

# DEL Person/{id}/Consent/{purpose}

```http
DELETE /api/v1/Person/{personId}/Consent/{purpose}
```

Turn off consent for a specified person and purpose.






| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id **Required** |
| purpose | string | The key of the purpose to remove. (e.g. 'STORE' or 'EMARKETING') **Required** |



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

[!include[sample request](../../samples/rest/request/v1PersonEntity_RemoveConsent.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1PersonEntity_RemoveConsent.md)]