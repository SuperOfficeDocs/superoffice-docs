---
title: DEL Person/{id}/Consent/{purpose}
id: v1PersonEntity_RemoveConsent
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
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |