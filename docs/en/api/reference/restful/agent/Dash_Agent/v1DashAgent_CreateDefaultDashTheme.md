---
title: POST Agents/Dash/CreateDefaultDashTheme
uid: v1DashAgent_CreateDefaultDashTheme
generated: true
---

# POST Agents/Dash/CreateDefaultDashTheme

```http
POST /api/v1/Agents/Dash/CreateDefaultDashTheme
```

Set default values into a new DashTheme.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

```http!
POST /api/v1/Agents/Dash/CreateDefaultDashTheme
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardThemeId": 970,
  "Name": "Hintz-Marquardt",
  "Config": "consectetur",
  "Rank": 829,
  "Client": "veniam",
  "Style": "similique",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 120
    }
  }
}
```