---
title: GET Person/{id}/Consent/{purpose}
id: v1PersonEntity_HasConsent
---

# GET Person/{id}/Consent/{purpose}

```http
GET /api/v1/Person/{personId}/Consent/{purpose}
```

Check if consent has been given by a specified person, for a specific purpose.

Withdraw consents return FALSE.




| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id **Required** |
| purpose | string | The key of the purpose to check. (e.g. 'STORE' or 'EMARKETING') **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: bool



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: bool


## Sample Request

```http!
GET /api/v1/Person/{personId}/Consent/{purpose}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

false
```