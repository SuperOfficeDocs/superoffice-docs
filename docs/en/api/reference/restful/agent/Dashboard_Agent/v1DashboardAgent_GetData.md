---
title: POST Agents/Dashboard/GetData
uid: v1DashboardAgent_GetData
---

# POST Agents/Dashboard/GetData

```http
POST /api/v1/Agents/Dashboard/GetData
```

Get data for this tile







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dashboard/GetData?$select=name,department,category/id
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

DashboardTileId, Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | Integer |  |
| Restrictions | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Columns | array | Column information |
| Result | ArchiveListResult | The result set |

## Sample request

```http!
POST /api/v1/Agents/Dashboard/GetData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 885,
  "Restrictions": "enim"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Columns": [
      {
        "DisplayName": "Metz-Cummings",
        "DisplayTooltip": "consequatur",
        "DisplayType": "et",
        "CanOrderBy": true,
        "Name": "Hessel-Haag",
        "CanRestrictBy": false,
        "RestrictionType": "illo",
        "RestrictionListName": "Williamson-Walsh",
        "IsVisible": true,
        "ExtraInfo": "eaque",
        "Width": "aut",
        "IconHint": "omnis",
        "HeadingIconHint": "quasi"
      }
    ],
    "Result": null
  },
  {
    "Columns": [
      {
        "DisplayName": "Metz-Cummings",
        "DisplayTooltip": "consequatur",
        "DisplayType": "et",
        "CanOrderBy": true,
        "Name": "Hessel-Haag",
        "CanRestrictBy": false,
        "RestrictionType": "illo",
        "RestrictionListName": "Williamson-Walsh",
        "IsVisible": true,
        "ExtraInfo": "eaque",
        "Width": "aut",
        "IconHint": "omnis",
        "HeadingIconHint": "quasi"
      }
    ],
    "Result": null
  }
]
```