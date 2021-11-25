---
title: POST Agents/Preference/DeletePreferenceDescriptionLine
id: v1PreferenceAgent_DeletePreferenceDescriptionLine
---

# POST Agents/Preference/DeletePreferenceDescriptionLine

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescriptionLine
```

Deletes the PreferenceDescriptionLine







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| PreferenceDescriptionLineId | int32 | **Required** The id of the PreferenceDescriptionLine to be deleted. |

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescriptionLine?PreferenceDescriptionLineId=475
```


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