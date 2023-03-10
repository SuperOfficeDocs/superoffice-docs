---
title: POST Agents/Pocket/GetPocketStartupData
uid: v1PocketAgent_GetPocketStartupData
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
| PhoneLocaleTimeZoneData | TableRight |  |
| BaseLocaleTimeZoneData | TableRight |  |
| OverdueSalesCount | int32 | Number of overdued sales for current user |
| NotificationsCount | int32 | Number of new invitations |
| SystemWebPanels | array | Web panels defined in Admin client, set to be shown in Pocket client |
| PocketPreferences | array | All Pocket specific preferences, including WebPanels defined by the user in Pocket |
| IsPushNotificationEnabled | bool | Is push notification configured and enabled in Netserver |
| CustomData | string | Custom data for Pocket, in JSON format |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Pocket/GetPocketStartupData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Tables": [
    "aut",
    "pariatur"
  ],
  "CurrentClientTime": "2016-08-29T12:15:19.75874+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TableRights": [
    "necessitatibus",
    "qui"
  ],
  "PhoneLocaleTimeZoneData": null,
  "BaseLocaleTimeZoneData": null,
  "OverdueSalesCount": 808,
  "NotificationsCount": 718,
  "SystemWebPanels": [
    {
      "WebPanelId": 588,
      "Name": "Hansen-VonRueden",
      "Tooltip": "provident",
      "Deleted": false,
      "Rank": 602,
      "UrlEncoding": "ANSI",
      "VisibleIn": "ActivityDialog",
      "OnCentral": true,
      "OnSatellite": false,
      "OnTravel": true,
      "OnSalesMarketingWeb": false,
      "OnSalesMarketingPocket": true,
      "ShowInMenuBar": true,
      "ShowInToolBar": false,
      "ShowInAddressBar": false,
      "ShowInStatusBar": true,
      "WindowName": "Romaguera-Yost",
      "Url": "http://www.example.com/",
      "ProgId": "sit",
      "Icon": 280,
      "AlwaysReloadOnShow": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    }
  ],
  "PocketPreferences": [
    {
      "Level": "Database",
      "RawValue": "quo",
      "Specification": null,
      "DisplayValue": "quia",
      "DisplayTooltip": "aut",
      "DisplayType": "Bool",
      "TabOrder": null,
      "TargetId": 532,
      "PrefDescId": 82,
      "TableName": "Lemke-Baumbach",
      "UserPreferenceId": 553,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    }
  ],
  "IsPushNotificationEnabled": false,
  "CustomData": "est",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 620
    }
  }
}
```