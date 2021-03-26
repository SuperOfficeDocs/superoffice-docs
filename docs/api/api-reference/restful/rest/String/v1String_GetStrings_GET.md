---
title: GET String/{sr_id}
id: v1String_GetStrings_GET
---

# GET String/{sr_id}

```http
GET /api/v1/String/{sr_id}
```

Gets the value of the string(s) with a given name in all known languages.






| Path Part | Type | Description |
|-----------|------|-------------|
| sr_id | string | The name of the string: SR_YES, SR_NO etc. You can specify multiple string ids separated by commas: "SR_YES,SR_NO" **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| isoLangCode | string |  ISO Language code. ("nb-no", "en-gb" etc) Defaults to all languages if nothing specified in the Accept-Language header. |
| ignoreOverrides | bool |  Ignore the user-provided overrides, and return the translation as defined by the system. |

```http
GET /api/v1/String/{sr_id}?isoLangCode=labore
GET /api/v1/String/{sr_id}?ignoreOverrides=False
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
GET /api/v1/String/{sr_id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "An object of some kind",
  "2": "An object of some kind"
}
```