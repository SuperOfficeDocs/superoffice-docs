---
title: POST Agents/Tooltips/GetTooltip
id: v1TooltipsAgent_GetTooltip
---

# POST Agents/Tooltips/GetTooltip

```http
POST /api/v1/Agents/Tooltips/GetTooltip
```

Parse a tooltip hint and return a tooltip.

The returned tooltip string may contain resource string identifiers (in square brackets), to be processed by the resource manager.&lt;para /&gt;The tooltip hint is either a literal text, representing itself, or a set of key/value pairs enclosed in curly braces. Each key is separated from its value by an equals sign, and each pair from the next by an ampersand, according to usual conventions.&lt;para /&gt;A typical tooltip hint could be {contact_id=123} or {appointment_id=222&amp;amp;mode=simple}





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Tooltips/GetTooltip?$select=name,department,category/id
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

## Request Body: request  

TooltipHint 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TooltipHint | string |  |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
POST /api/v1/Agents/Tooltips/GetTooltip
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TooltipHint": "quod"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"consequatur"
```