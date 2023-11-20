---
title: POST Agents/List/SaveWebPanelEntity
uid: v1ListAgent_SaveWebPanelEntity
generated: true
---

# POST Agents/List/SaveWebPanelEntity

```http
POST /api/v1/Agents/List/SaveWebPanelEntity
```

Updates the existing WebPanelEntity or creates a new WebPanelEntity if the id parameter is empty








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

The WebPanelEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WebPanelId | Integer | The identity of the web panel |
| Name | String | The name of the web panel |
| Tooltip | String | The tooltip of the web panel |
| Deleted | Boolean | True if the web panel is marked as deleted |
| Rank | Integer | The rank of the web panel |
| UrlEncoding | String | The encoding of the URL |
| VisibleIn | String | The webpanel is visible in |
| OnCentral | Boolean | Is the webpanel visible when user is on central database |
| OnSatellite | Boolean | Is the webpanel visible when user is on a satellite |
| OnTravel | Boolean | Is the webpanel visible when user is on travel |
| OnSalesMarketingWeb | Boolean | Is the webpanel visible when user is on web client |
| OnSalesMarketingPocket | Boolean | Is the webpanel visible when user is on pocket client |
| ShowInMenuBar | Boolean | Does the webpanel have a menu bar |
| ShowInToolBar | Boolean | Does the webpanel have a toolbar |
| ShowInAddressBar | Boolean | Does the webpanel have an address bar |
| ShowInStatusBar | Boolean | Does the webpanel have a status bar |
| WindowName | String | The window which the URL address is to open in (webpanel only) |
| Url | String | The url |
| ProgId | String | String key that can be used to uniquely retrieve the panel; particularly useful for partners and others who do not wish to store database ID's |
| Icon | Integer | The icon of the webpanel |
| AlwaysReloadOnShow | Boolean | If set to true, the content will reload every time the panel is shown |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: WebPanelEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| WebPanelId | int32 | The identity of the web panel |
| Name | string | The name of the web panel |
| Tooltip | string | The tooltip of the web panel |
| Deleted | bool | True if the web panel is marked as deleted |
| Rank | int32 | The rank of the web panel |
| UrlEncoding | string | The encoding of the URL |
| VisibleIn | string | The webpanel is visible in |
| OnCentral | bool | Is the webpanel visible when user is on central database |
| OnSatellite | bool | Is the webpanel visible when user is on a satellite |
| OnTravel | bool | Is the webpanel visible when user is on travel |
| OnSalesMarketingWeb | bool | Is the webpanel visible when user is on web client |
| OnSalesMarketingPocket | bool | Is the webpanel visible when user is on pocket client |
| ShowInMenuBar | bool | Does the webpanel have a menu bar |
| ShowInToolBar | bool | Does the webpanel have a toolbar |
| ShowInAddressBar | bool | Does the webpanel have an address bar |
| ShowInStatusBar | bool | Does the webpanel have a status bar |
| WindowName | string | The window which the URL address is to open in (webpanel only) |
| Url | string | The url |
| ProgId | string | String key that can be used to uniquely retrieve the panel; particularly useful for partners and others who do not wish to store database ID's |
| Icon | int32 | The icon of the webpanel |
| AlwaysReloadOnShow | bool | If set to true, the content will reload every time the panel is shown |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveWebPanelEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebPanelId": 516,
  "Name": "Jewess-Hirthe",
  "Tooltip": "aut",
  "Deleted": true,
  "Rank": 434,
  "UrlEncoding": "ANSI",
  "VisibleIn": "ActivityDialog",
  "OnCentral": true,
  "OnSatellite": false,
  "OnTravel": false,
  "OnSalesMarketingWeb": true,
  "OnSalesMarketingPocket": false,
  "ShowInMenuBar": false,
  "ShowInToolBar": true,
  "ShowInAddressBar": false,
  "ShowInStatusBar": true,
  "WindowName": "Langworth-Emard",
  "Url": "http://www.example.com/",
  "ProgId": "aliquid",
  "Icon": 975,
  "AlwaysReloadOnShow": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebPanelId": 35,
  "Name": "Larkin LLC",
  "Tooltip": "quia",
  "Deleted": true,
  "Rank": 38,
  "UrlEncoding": "ANSI",
  "VisibleIn": "ActivityDialog",
  "OnCentral": false,
  "OnSatellite": true,
  "OnTravel": false,
  "OnSalesMarketingWeb": false,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": true,
  "ShowInToolBar": false,
  "ShowInAddressBar": false,
  "ShowInStatusBar": false,
  "WindowName": "Herzog LLC",
  "Url": "http://www.example.com/",
  "ProgId": "a",
  "Icon": 278,
  "AlwaysReloadOnShow": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 363
    }
  }
}
```