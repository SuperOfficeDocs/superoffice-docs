---
title: POST Agents/AI/GetFirstFormDesignCssFromUrl
uid: v1AIAgent_GetFirstFormDesignCssFromUrl
generated: true
content_type: reference
---

# POST Agents/AI/GetFirstFormDesignCssFromUrl

```http
POST /api/v1/Agents/AI/GetFirstFormDesignCssFromUrl
```

Starts a form design analysis from a URL, returning the properties for a single CSS class.


NsApiSlow threshold: 20000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/GetFirstFormDesignCssFromUrl?$select=name,department,category/id
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

Url, CssClass 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Url | String |  |
| CssClass | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: FormDesignCss

| Property Name | Type |  Description |
|----------------|------|--------------|
| CssClass | string | The CSS Class requested. e.g. '.foo' |
| CssRule | string | Generated CSS style based on the analyzed design. e.g. 'background: goldenrod; border-width: 12px; ' |
| State | string | Internal state of the AI analyzer. Pass along in the next call to GetNextFormDesignCss. No user-maintainable parts inside. Do not eat. |

## Sample request

[!include[sample request](../../samples/agent/request/v1AIAgent_GetFirstFormDesignCssFromUrl.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1AIAgent_GetFirstFormDesignCssFromUrl.md)]