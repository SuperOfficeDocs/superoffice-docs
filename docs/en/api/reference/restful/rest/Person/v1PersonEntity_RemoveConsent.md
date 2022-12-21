---
title: DEL Person/{id}/Consent/{purpose}
uid: v1PersonEntity_RemoveConsent
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

Response body: 


## Sample request

```http!
DELETE /api/v1/Person/{personId}/Consent/{purpose}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```