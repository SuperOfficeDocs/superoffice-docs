---
title: POST Agents/Preference/DeletePreferenceDescription
uid: v1PreferenceAgent_DeletePreferenceDescription
generated: true
content_type: reference
---

# POST Agents/Preference/DeletePreferenceDescription

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescription
```

Deletes the PreferenceDescription


NsApiSlow threshold: 1000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| preferenceDescriptionId | int32 | **Required** The identity of the PreferenceDescription |

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescription?preferenceDescriptionId=489
```


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

[!include[sample request](../../samples/agent/request/v1PreferenceAgent_DeletePreferenceDescription.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1PreferenceAgent_DeletePreferenceDescription.md)]