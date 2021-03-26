---
title: POST List/WebPanel/Items
id: v1WebPanelEntityList_PostWebPanelEntity
---

# POST List/WebPanel/Items

```http
POST /api/v1/List/WebPanel/Items
```

Create a new WebPanelEntity list item

Calls the List agent service SaveWebPanelEntity.






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

## Request Body: newEntity  

The WebPanelEntity to be created. 

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


## Response: object

The web panel entity contains information on a web panel



Carrier object for WebPanelEntity.
Services for the WebPanelEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/List/WebPanel/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "WebPanelId": 611,
  "Name": "Bradtke Inc and Sons",
  "Tooltip": "sit",
  "Deleted": true,
  "Rank": 157,
  "UrlEncoding": "ANSI",
  "VisibleIn": "ActivityDialog",
  "OnCentral": false,
  "OnSatellite": true,
  "OnTravel": true,
  "OnSalesMarketingWeb": false,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": false,
  "ShowInToolBar": false,
  "ShowInAddressBar": true,
  "ShowInStatusBar": false,
  "WindowName": "Bartell-Reilly",
  "Url": "http://www.example.com/",
  "ProgId": "mollitia",
  "Icon": 676
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebPanelId": 91,
  "Name": "Kertzmann-Upton",
  "Tooltip": "vel",
  "Deleted": false,
  "Rank": 894,
  "UrlEncoding": "ANSI",
  "VisibleIn": "ActivityDialog",
  "OnCentral": false,
  "OnSatellite": true,
  "OnTravel": true,
  "OnSalesMarketingWeb": false,
  "OnSalesMarketingPocket": false,
  "ShowInMenuBar": true,
  "ShowInToolBar": true,
  "ShowInAddressBar": true,
  "ShowInStatusBar": true,
  "WindowName": "Weissnat-Carroll",
  "Url": "http://www.example.com/",
  "ProgId": "tempore",
  "Icon": 737,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 293
    }
  }
}
```