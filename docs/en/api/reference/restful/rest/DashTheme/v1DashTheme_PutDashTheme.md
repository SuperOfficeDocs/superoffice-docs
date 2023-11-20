---
title: PUT DashTheme/{id}
uid: v1DashTheme_PutDashTheme
generated: true
---

# PUT DashTheme/{id}

```http
PUT /api/v1/DashTheme/{id}
```

Updates the existing DashTheme






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTheme id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/DashTheme/{id}?$select=name,department,category/id
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

## Request Body: entity 

The DashTheme to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardThemeId | Integer | Primary key |
| Name | String | The name of this theme |
| Config | String | The JSON clob-formatted config |
| Rank | Integer | Rank order |
| Client | String | Name of client(s) this theme is available to |
| Style | String | Style value - for example 'light' or 'dark' |

## Response:

DashTheme updated.

| Response | Description |
|----------------|-------------|
| 200 | DashTheme updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/DashTheme/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DashboardThemeId": 88,
  "Name": "Terry LLC",
  "Config": "voluptas",
  "Rank": 819,
  "Client": "sed",
  "Style": "sit"
}
```

## Sample response

```http_
HTTP/1.1 200 DashTheme updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardThemeId": 215,
  "Name": "Medhurst-D'Amore",
  "Config": "suscipit",
  "Rank": 227,
  "Client": "velit",
  "Style": "nihil",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 266
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```