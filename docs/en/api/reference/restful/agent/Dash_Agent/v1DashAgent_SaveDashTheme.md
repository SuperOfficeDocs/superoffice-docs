---
title: POST Agents/Dash/SaveDashTheme
uid: v1DashAgent_SaveDashTheme
generated: true
content_type: reference
---

# POST Agents/Dash/SaveDashTheme

```http
POST /api/v1/Agents/Dash/SaveDashTheme
```

Updates the existing DashTheme or creates a new DashTheme if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: dashTheme 

The DashTheme that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardThemeId | Integer | Primary key |
| Name | String | The name of this theme |
| Config | String | The JSON clob-formatted config |
| Rank | Integer | Rank order |
| Client | String | Name of client(s) this theme is available to |
| Style | String | Style value - for example 'light' or 'dark' |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DashTheme

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardThemeId | int32 | Primary key |
| Name | string | The name of this theme |
| Config | string | The JSON clob-formatted config |
| Rank | int32 | Rank order |
| Client | string | Name of client(s) this theme is available to |
| Style | string | Style value - for example 'light' or 'dark' |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1DashAgent_SaveDashTheme.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1DashAgent_SaveDashTheme.md)]