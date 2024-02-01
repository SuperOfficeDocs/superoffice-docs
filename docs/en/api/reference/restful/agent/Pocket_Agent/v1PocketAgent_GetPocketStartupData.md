---
title: POST Agents/Pocket/GetPocketStartupData
uid: v1PocketAgent_GetPocketStartupData
generated: true
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Tables": [
    "occaecati",
    "quia"
  ],
  "CurrentClientTime": "2015-04-23T23:03:56.5871204+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TableRights": [
    "sint",
    "odit"
  ],
  "PhoneLocaleTimeZoneData": null,
  "BaseLocaleTimeZoneData": null,
  "OverdueSalesCount": 135,
  "NotificationsCount": 381,
  "SystemWebPanels": [
    {
      "WebPanelId": 776,
      "Name": "Kuhn Group",
      "Tooltip": "eos",
      "Deleted": true,
      "Rank": 358,
      "UrlEncoding": "ANSI",
      "VisibleIn": "ActivityDialog",
      "OnCentral": false,
      "OnSatellite": false,
      "OnTravel": true,
      "OnSalesMarketingWeb": false,
      "OnSalesMarketingPocket": false,
      "ShowInMenuBar": true,
      "ShowInToolBar": false,
      "ShowInAddressBar": true,
      "ShowInStatusBar": true,
      "WindowName": "Hamill, Spencer and Schroeder",
      "Url": "http://www.example.com/",
      "ProgId": "iure",
      "Icon": 284,
      "AlwaysReloadOnShow": false,
      "NeverReloadOnCurrentChange": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 70
        }
      }
    }
  ],
  "PocketPreferences": [
    {
      "Level": "Database",
      "RawValue": "ut",
      "Specification": null,
      "DisplayValue": "harum",
      "DisplayTooltip": "commodi",
      "DisplayType": "Bool",
      "TabOrder": null,
      "TargetId": 801,
      "PrefDescId": 400,
      "TableName": "Dibbert, Windler and Padberg",
      "UserPreferenceId": 352,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "IsPushNotificationEnabled": true,
  "CustomData": "id",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 649
    }
  }
}
```