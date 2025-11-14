---
title: POST Agents/Preference/DeletePreferenceDescriptionLine
uid: v1PreferenceAgent_DeletePreferenceDescriptionLine
generated: true
content_type: reference
---

# POST Agents/Preference/DeletePreferenceDescriptionLine

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescriptionLine
```

Deletes the PreferenceDescriptionLine


NsApiSlow threshold: 1000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| preferenceDescriptionLineId | int32 | **Required** The identity of the PreferenceDescriptionLine |

```http
POST /api/v1/Agents/Preference/DeletePreferenceDescriptionLine?preferenceDescriptionLineId=838
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

```http!
POST /api/v1/Agents/Preference/DeletePreferenceDescriptionLine
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```