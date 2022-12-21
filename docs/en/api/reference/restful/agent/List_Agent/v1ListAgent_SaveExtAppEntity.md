---
title: POST Agents/List/SaveExtAppEntity
uid: v1ListAgent_SaveExtAppEntity
---

# POST Agents/List/SaveExtAppEntity

```http
POST /api/v1/Agents/List/SaveExtAppEntity
```

Updates the existing ExtAppEntity or creates a new ExtAppEntity if the id parameter is empty








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

The ExtAppEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ExtAppId | int32 | The identity of the external app |
| Name | string | The name of the web panel |
| Tooltip | string | The tooltip of the web panel |
| Deleted | bool | True if the application is marked as deleted |
| Rank | int32 | The rank of the application |
| Filename | string | Filename of the programfile |
| Parameters | string | &lt;template variable&gt; &lt;other template variable&gt; |
| Workdir | string | Directory set to current when loading the application, if different from application's own |
| ShowState | string | The application is shown in which state Minimized, Maximized or Restored |
| VisibleIn | string | The application is visible in |
| OnCentral | bool | Is the application visible when user is on central database |
| OnSatellite | bool | Is the application visible when user is on a satellite |
| OnTravel | bool | Is the application visible when user is on travel |
| OnSalesMarketingPocket | bool | Is the webpanel visible when user is on pocket client |
| ShowInMenuBar | bool | Does the application have a menu bar |
| ShowInToolBar | bool | Does the webpanel have a toolbar |
| ShowInAddressBar | bool | Does the webpanel have an address bar |
| ShowInStatusBar | bool | Does the webpanel have a status bar |
| Icon | int32 | The id of the icon of the external app |
| WaitToFinish | bool | True if the application shall wait for fininsh event |
| ExecuteOnEvent | string | Events that cause automatic execution of this app |
| Path | string | Path where the programfile is located; if empty, PATH is used |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ExtAppId | int32 | The identity of the external app |
| Name | string | The name of the web panel |
| Tooltip | string | The tooltip of the web panel |
| Deleted | bool | True if the application is marked as deleted |
| Rank | int32 | The rank of the application |
| Filename | string | Filename of the programfile |
| Parameters | string | &lt;template variable&gt; &lt;other template variable&gt; |
| Workdir | string | Directory set to current when loading the application, if different from application's own |
| ShowState | string | The application is shown in which state Minimized, Maximized or Restored |
| VisibleIn | string | The application is visible in |
| OnCentral | bool | Is the application visible when user is on central database |
| OnSatellite | bool | Is the application visible when user is on a satellite |
| OnTravel | bool | Is the application visible when user is on travel |
| OnSalesMarketingPocket | bool | Is the webpanel visible when user is on pocket client |
| ShowInMenuBar | bool | Does the application have a menu bar |
| ShowInToolBar | bool | Does the webpanel have a toolbar |
| ShowInAddressBar | bool | Does the webpanel have an address bar |
| ShowInStatusBar | bool | Does the webpanel have a status bar |
| Icon | int32 | The id of the icon of the external app |
| WaitToFinish | bool | True if the application shall wait for fininsh event |
| ExecuteOnEvent | string | Events that cause automatic execution of this app |
| Path | string | Path where the programfile is located; if empty, PATH is used |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveExtAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ExtAppId": 460,
  "Name": "Satterfield-Armstrong",
  "Tooltip": "qui",
  "Deleted": true,
  "Rank": 982,
  "Filename": "qui",
  "Parameters": "itaque",
  "Workdir": "atque",
  "ShowState": "AddressBar",
  "VisibleIn": "ActivityDialog",
  "OnCentral": false,
  "OnSatellite": true,
  "OnTravel": false,
  "OnSalesMarketingPocket": false,
  "ShowInMenuBar": false,
  "ShowInToolBar": true,
  "ShowInAddressBar": false,
  "ShowInStatusBar": false,
  "Icon": 90,
  "WaitToFinish": false,
  "ExecuteOnEvent": "LocalUpdate",
  "Path": "explicabo"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ExtAppId": 894,
  "Name": "Lehner, Gutkowski and Berge",
  "Tooltip": "repudiandae",
  "Deleted": false,
  "Rank": 182,
  "Filename": "recusandae",
  "Parameters": "iste",
  "Workdir": "modi",
  "ShowState": "AddressBar",
  "VisibleIn": "ActivityDialog",
  "OnCentral": false,
  "OnSatellite": false,
  "OnTravel": false,
  "OnSalesMarketingPocket": false,
  "ShowInMenuBar": false,
  "ShowInToolBar": false,
  "ShowInAddressBar": false,
  "ShowInStatusBar": false,
  "Icon": 684,
  "WaitToFinish": false,
  "ExecuteOnEvent": "LocalUpdate",
  "Path": "tenetur",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 717
    }
  }
}
```