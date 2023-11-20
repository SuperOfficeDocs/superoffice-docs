---
title: POST Agents/Preference/DeletePreferenceDescriptionLine
uid: v1PreferenceAgent_DeletePreferenceDescriptionLine
generated: true
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
POST /api/v1/Agents/Preference/DeletePreferenceDescriptionLine?PreferenceDescriptionLineId=191
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```