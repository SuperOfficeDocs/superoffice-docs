---
title: GET List/WebPanel/Items/{id}
id: v1WebPanelEntityList_GetWebPanelEntity
---

# GET List/WebPanel/Items/{id}

```http
GET /api/v1/List/WebPanel/Items/{id}
```

Gets a WebPanelEntity list item.

Calls the List agent service GetWebPanelEntity.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the WebPanelEntity to return. **Required** |

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

## Response: object

The web panel entity contains information on a web panel

Carrier object for WebPanelEntity.
Services for the WebPanelEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 404 | Not Found. |

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
GET /api/v1/List/WebPanel/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebPanelId": 716,
  "Name": "Bogan LLC",
  "Tooltip": "non",
  "Deleted": true,
  "Rank": 277,
  "UrlEncoding": "ANSI",
  "VisibleIn": "ActivityDialog",
  "OnCentral": true,
  "OnSatellite": true,
  "OnTravel": false,
  "OnSalesMarketingWeb": false,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": false,
  "ShowInToolBar": true,
  "ShowInAddressBar": true,
  "ShowInStatusBar": false,
  "WindowName": "Abshire, Little and Lesch",
  "Url": "http://www.example.com/",
  "ProgId": "velit",
  "Icon": 973,
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
      "FieldLength": 115
    }
  }
}
```
