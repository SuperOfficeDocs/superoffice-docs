---
title: GET String/{sr_id}/{isoLangCode}
id: v1String_GetString
---

# GET String/{sr_id}/{isoLangCode}

```http
GET /api/v1/String/{sr_id}/{isoLangCode}
```

Gets the value of the string with a given name in a given language






| Path Part | Type | Description |
|-----------|------|-------------|
| sr_id | string | The name of the string: SR_YES, SR_NO etc **Required** |
| isoLangCode | string | ISO Language code. ("nb-no", "en-gb" etc) Defaults to English if nothing specified in the Accept-Language header. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ignoreOverrides | bool |  Ignore the user-provided overrides, and return the translation as defined by the system. |

```http
GET /api/v1/String/{sr_id}/{isoLangCode}?ignoreOverrides=True
```


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


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
GET /api/v1/String/{sr_id}/{isoLangCode}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"est"
```