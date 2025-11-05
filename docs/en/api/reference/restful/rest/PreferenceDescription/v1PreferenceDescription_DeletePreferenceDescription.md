---
title: DEL PreferenceDescription/{id}
uid: v1PreferenceDescription_DeletePreferenceDescription
generated: true
content_type: reference
---

# DEL PreferenceDescription/{id}

```http
DELETE /api/v1/PreferenceDescription/{id}
```

Deletes the PreferenceDescription


Calls the Preference agent service DeletePreferenceDescription.
NsApiSlow threshold: 1000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PreferenceDescription to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

PreferenceDescription deleted.

| Response | Description |
|----------------|-------------|
| 204 | PreferenceDescription deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/PreferenceDescription/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 PreferenceDescription deleted.
Content-Type: application/json; charset=utf-8

null
```