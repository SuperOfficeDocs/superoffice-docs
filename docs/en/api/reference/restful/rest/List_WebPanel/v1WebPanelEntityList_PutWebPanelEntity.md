---
title: PUT List/WebPanel/Items/{id}
uid: v1WebPanelEntityList_PutWebPanelEntity
---

# PUT List/WebPanel/Items/{id}

```http
PUT /api/v1/List/WebPanel/Items/{id}
```

Updates the existing WebPanelEntity


Calls the List agent service SaveWebPanelEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of WebPanelEntity to be saved. **Required** |



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

The details of WebPanelEntity to be saved. 

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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/WebPanel/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebPanelId": 875,
  "Name": "Champlin-Rolfson",
  "Tooltip": "qui",
  "Deleted": false,
  "Rank": 992,
  "UrlEncoding": "ANSI",
  "VisibleIn": "ActivityDialog",
  "OnCentral": false,
  "OnSatellite": false,
  "OnTravel": false,
  "OnSalesMarketingWeb": false,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": true,
  "ShowInToolBar": false,
  "ShowInAddressBar": true,
  "ShowInStatusBar": false,
  "WindowName": "Harris Group",
  "Url": "http://www.example.com/",
  "ProgId": "tempora",
  "Icon": 895,
  "AlwaysReloadOnShow": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebPanelId": 150,
  "Name": "Huel Inc and Sons",
  "Tooltip": "minus",
  "Deleted": false,
  "Rank": 52,
  "UrlEncoding": "ANSI",
  "VisibleIn": "ActivityDialog",
  "OnCentral": false,
  "OnSatellite": false,
  "OnTravel": false,
  "OnSalesMarketingWeb": true,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": false,
  "ShowInToolBar": true,
  "ShowInAddressBar": false,
  "ShowInStatusBar": true,
  "WindowName": "Brekke Group",
  "Url": "http://www.example.com/",
  "ProgId": "doloremque",
  "Icon": 562,
  "AlwaysReloadOnShow": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 738
    }
  }
}
```