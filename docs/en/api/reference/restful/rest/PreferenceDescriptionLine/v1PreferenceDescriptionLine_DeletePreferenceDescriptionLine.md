---
title: DEL PreferenceDescriptionLine/{id}
uid: v1PreferenceDescriptionLine_DeletePreferenceDescriptionLine
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
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

PreferenceDescriptionLine deleted.

| Response | Description |
|----------------|-------------|
| 204 | PreferenceDescriptionLine deleted. |

Response body: 


## Sample request

```http!
DELETE /api/v1/PreferenceDescriptionLine/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 PreferenceDescriptionLine deleted.
Content-Type: application/json; charset=utf-8

null
```