---
title: GET DashTheme/{id}
uid: v1DashTheme_GetDashTheme
generated: true
---

# GET DashTheme/{id}

```http
GET /api/v1/DashTheme/{id}
```

Gets a DashTheme object.


Calls the Dash agent service GetDashTheme.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the DashTheme to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/DashTheme/{id}?$select=name,department,category/id
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


## Response:

DashTheme found.

| Response | Description |
|----------------|-------------|
| 200 | DashTheme found. |
| 404 | Not Found. |

### Response body: DashThemeWithLinks

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
| _Links | object |  |

## Sample request

```http!
GET /api/v1/DashTheme/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 DashTheme found.
Content-Type: application/json; charset=utf-8

{
  "DashboardThemeId": 450,
  "Name": "Abernathy, Nikolaus and Heller",
  "Config": "tempora",
  "Rank": 814,
  "Client": "fugiat",
  "Style": "quas",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 902
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```