---
title: POST String
id: v1String_GetStrings
---

# POST String

```http
POST /api/v1/String
```

Gets the value of the string(s) with a given name in all known languages.

Post the array of strings to get translations for all the strings.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| isoLangCode | string |  ISO Language code. ("nb-no", "en-gb" etc) Defaults to all languages if nothing specified in the Accept-Language header. |
| ignoreOverrides | bool |  Ignore the user-provided overrides, and return the translation as defined by the system. |

```http
POST /api/v1/String?isoLangCode=omnis
POST /api/v1/String?ignoreOverrides=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: sr_ids  

The string names: ['SR_YES', 'SR_NO' etc]. You can specify multiple string ids in the array. 



## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/String
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "An object of some kind",
  "2": "An object of some kind"
}
```