---
title: POST Agents/List/CreateDefaultExtAppEntity
uid: v1ListAgent_CreateDefaultExtAppEntity
generated: true
---

# POST Agents/List/CreateDefaultExtAppEntity

```http
POST /api/v1/Agents/List/CreateDefaultExtAppEntity
```

Set default values into a new ExtAppEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ExtAppEntity

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/CreateDefaultExtAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ExtAppId": 779,
  "Name": "Fay Inc and Sons",
  "Tooltip": "maiores",
  "Deleted": true,
  "Rank": 706,
  "Filename": "sunt",
  "Parameters": "maiores",
  "Workdir": "quia",
  "ShowState": "AddressBar",
  "VisibleIn": "ActivityDialog",
  "OnCentral": true,
  "OnSatellite": true,
  "OnTravel": false,
  "OnSalesMarketingPocket": true,
  "ShowInMenuBar": true,
  "ShowInToolBar": true,
  "ShowInAddressBar": false,
  "ShowInStatusBar": false,
  "Icon": 217,
  "WaitToFinish": true,
  "ExecuteOnEvent": "LocalUpdate",
  "Path": "iure",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 392
    }
  }
}
```