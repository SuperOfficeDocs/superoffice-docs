---
title: DEL PreferenceDescription/{section}/{key}
id: v1PreferenceDescription_DeleteFromSectionAndKey
---

# DEL PreferenceDescription/{section}/{key}

```http
DELETE /api/v1/PreferenceDescription/{section}/{key}
```

Gets a PreferenceDescription based on the section and key






| Path Part | Type | Description |
|-----------|------|-------------|
| section | string | The PreferenceDescription-section **Required** |
| key | string | The PreferenceDescription-key **Required** |



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