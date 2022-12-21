---
title: POST Agents/Dash/SaveDashTiles
uid: v1DashAgent_SaveDashTiles
---

# POST Agents/Dash/SaveDashTiles

```http
POST /api/v1/Agents/Dash/SaveDashTiles
```

Saves the ordered list of tiles for a dashboard







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/SaveDashTiles?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

DashboardId, DashTiles 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 |  |
| DashTiles | array |  |


## Response: 

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body: 


## Sample request

```http!
POST /api/v1/Agents/Dash/SaveDashTiles
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 810,
  "DashTiles": [
    {
      "DashboardTileId": 215,
      "DashboardId": 413,
      "Height": 772,
      "Width": 644,
      "Rank": 386,
      "DashTileDefinition": null
    },
    {
      "DashboardTileId": 215,
      "DashboardId": 413,
      "Height": 772,
      "Width": 644,
      "Rank": 386,
      "DashTileDefinition": null
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```