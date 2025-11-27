---
title: DEL PreferenceDescriptionLine/{id}
uid: v1PreferenceDescriptionLine_DeletePreferenceDescriptionLine
generated: true
content_type: reference
---

# DEL PreferenceDescriptionLine/{id}

```http
DELETE /api/v1/PreferenceDescriptionLine/{id}
```

Deletes the PreferenceDescriptionLine


Calls the Preference agent service DeletePreferenceDescriptionLine.
NsApiSlow threshold: 1000 ms.





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

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1PreferenceDescriptionLine_DeletePreferenceDescriptionLine.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1PreferenceDescriptionLine_DeletePreferenceDescriptionLine.md)]