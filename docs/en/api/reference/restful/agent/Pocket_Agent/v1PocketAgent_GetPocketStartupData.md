---
title: POST Agents/Pocket/GetPocketStartupData
uid: v1PocketAgent_GetPocketStartupData
generated: true
content_type: reference
---

# POST Agents/Pocket/GetPocketStartupData

```http
POST /api/v1/Agents/Pocket/GetPocketStartupData
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Pocket/GetPocketStartupData?$select=name,department,category/id
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

Tables, CurrentClientTime 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Tables | Array |  |
| CurrentClientTime | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PocketStartupData

| Property Name | Type |  Description |
|----------------|------|--------------|
| TableRights | array | List of tablerights for logged in user, in the same order as the Tables array parameter |
| PhoneLocaleTimeZoneData | TimeZoneData |  |
| BaseLocaleTimeZoneData | TimeZoneData |  |
| OverdueSalesCount | int32 | Number of overdued sales for current user |
| NotificationsCount | int32 | Number of new invitations |
| SystemWebPanels | array | Web panels defined in Admin client, set to be shown in Pocket client |
| PocketPreferences | array | All Pocket specific preferences, including WebPanels defined by the user in Pocket |
| IsPushNotificationEnabled | bool | Is push notification configured and enabled in Netserver |
| CustomData | string | Custom data for Pocket, in JSON format |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Pocket/GetPocketStartupData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Tables": [
    "quis",
    "cupiditate"
  ],
  "CurrentClientTime": "2020-09-18T03:46:55.1288689+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TableRights": [
    "eum",
    "et"
  ],
  "PhoneLocaleTimeZoneData": null,
  "BaseLocaleTimeZoneData": null,
  "OverdueSalesCount": 820,
  "NotificationsCount": 620,
  "SystemWebPanels": [
    {
      "WebPanelId": 720,
      "Name": "Gottlieb-Farrell",
      "Tooltip": "illum",
      "Deleted": false,
      "Rank": 300,
      "UrlEncoding": "ANSI",
      "VisibleIn": "ActivityDialog",
      "OnCentral": false,
      "OnSatellite": true,
      "OnTravel": false,
      "OnSalesMarketingWeb": false,
      "OnSalesMarketingPocket": false,
      "ShowInMenuBar": true,
      "ShowInToolBar": false,
      "ShowInAddressBar": false,
      "ShowInStatusBar": true,
      "WindowName": "Denesik, Barrows and Hessel",
      "Url": "http://www.example.com/",
      "ProgId": "eius",
      "Icon": 752,
      "AlwaysReloadOnShow": true,
      "NeverReloadOnCurrentChange": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    }
  ],
  "PocketPreferences": [
    {
      "Level": "Database",
      "RawValue": "totam",
      "Specification": null,
      "DisplayValue": "hic",
      "DisplayTooltip": "explicabo",
      "DisplayType": "Bool",
      "TabOrder": null,
      "TargetId": 754,
      "PrefDescId": 751,
      "TableName": "Harvey-Luettgen",
      "UserPreferenceId": 993,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "IsPushNotificationEnabled": false,
  "CustomData": "quis",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 572
    }
  }
}
```