---
title: DeletePreferenceDescription
id: v1PreferenceAgent_DeletePreferenceDescription
---

# DeletePreferenceDescription

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescription
```

Deletes the PreferenceDescription







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| PreferenceDescriptionId | int32 | **Required** The id of the PreferenceDescription to be deleted. |

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescription?PreferenceDescriptionId=920
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