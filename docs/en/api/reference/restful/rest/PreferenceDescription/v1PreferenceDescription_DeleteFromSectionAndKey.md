---
title: DEL PreferenceDescription/{section}/{key}
uid: v1PreferenceDescription_DeleteFromSectionAndKey
generated: true
content_type: reference
---

# DEL PreferenceDescription/{section}/{key}

```http
DELETE /api/v1/PreferenceDescription/{section}/{key}
```

Gets a PreferenceDescription based on the section and key






| Path Part | Type | Description |
|-----------|------|-------------|
| section | string | The PreferenceDescription-section **Required** |
| key | string | The PreferenceDescription-key **Required** |



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

[!include[sample request](../../samples/rest/request/v1PreferenceDescription_DeleteFromSectionAndKey.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1PreferenceDescription_DeleteFromSectionAndKey.md)]