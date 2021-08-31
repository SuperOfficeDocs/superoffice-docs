---
title: DEL PreferenceDescriptionLine/{id}
id: v1PreferenceDescriptionLine_DeletePreferenceDescriptionLine
---

# DEL PreferenceDescriptionLine/{id}

```http
DELETE /api/v1/PreferenceDescriptionLine/{id}
```

Deletes the PreferenceDescriptionLine

Calls the Preference agent service DeletePreferenceDescriptionLine.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PreferenceDescriptionLine to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | PreferenceDescriptionLine deleted. |