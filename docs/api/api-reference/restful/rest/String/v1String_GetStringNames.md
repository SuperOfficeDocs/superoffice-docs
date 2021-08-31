---
title: GET String
id: v1String_GetStringNames
---

# GET String

```http
GET /api/v1/String
```

Gets all the string names containing a search string.

Search the strings using Q parameter.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| q | string |  Limit the results to strings containing this word |
| isoLangCode | string |  ISO Language code. ("nb-no", "en-gb" etc) Defaults to English if nothing specified in the Accept-Language header. |

```http
GET /api/v1/String?q=sit
GET /api/v1/String?isoLangCode=expedita
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array


## Sample Request

```http!
GET /api/v1/String
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  "temporibus",
  "dolore"
]
```