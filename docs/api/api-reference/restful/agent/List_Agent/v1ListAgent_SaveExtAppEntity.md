---
title: SaveExtAppEntity
id: v1ListAgent_SaveExtAppEntity
---

# SaveExtAppEntity

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


## Response: object

The ext app entity contains information on an external application



Carrier object for ExtAppEntity.
Services for the ExtAppEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/List/SaveExtAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ExtAppId": 989,
  "Name": "Davis-Kassulke",
  "Tooltip": "pariatur",
  "Deleted": true,
  "Rank": 801,
  "Filename": "nostrum",
  "Parameters": "est",
  "Workdir": "nam",
  "ShowState": "AddressBar",
  "VisibleIn": "ActivityDialog",
  "OnCentral": true,
  "OnSatellite": true,
  "OnTravel": true,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": false,
  "ShowInToolBar": false,
  "ShowInAddressBar": false,
  "ShowInStatusBar": true,
  "Icon": 261,
  "WaitToFinish": true,
  "ExecuteOnEvent": "LocalUpdate",
  "Path": "ut"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ExtAppId": 903,
  "Name": "Jones LLC",
  "Tooltip": "mollitia",
  "Deleted": false,
  "Rank": 589,
  "Filename": "adipisci",
  "Parameters": "nemo",
  "Workdir": "cumque",
  "ShowState": "AddressBar",
  "VisibleIn": "ActivityDialog",
  "OnCentral": true,
  "OnSatellite": true,
  "OnTravel": false,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": false,
  "ShowInToolBar": true,
  "ShowInAddressBar": true,
  "ShowInStatusBar": false,
  "Icon": 934,
  "WaitToFinish": false,
  "ExecuteOnEvent": "LocalUpdate",
  "Path": "consequatur",
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
      "FieldLength": 116
    }
  }
}
```