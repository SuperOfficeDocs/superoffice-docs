---
title: DEL PreferenceDescription/{id}
id: v1PreferenceDescription_DeletePreferenceDescription
---

# DEL PreferenceDescription/{id}

```http
DELETE /api/v1/PreferenceDescription/{id}
```

Deletes the PreferenceDescription

Calls the Preference agent service DeletePreferenceDescription.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PreferenceDescription to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | PreferenceDescription deleted. |