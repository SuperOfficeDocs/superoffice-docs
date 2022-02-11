---
title: POST Agents/Pocket/GetPocketStartupData
id: v1PocketAgent_GetPocketStartupData
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
| Tables | array |  |
| CurrentClientTime | date-time |  |


## Response: object

The Pocket Service. The service implements pocket specific stuff, like consolidated post-login stuff.



Carrier object for PocketStartupData.
Services for the PocketStartupData Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPocketAgent">Pocket Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TableRights | array | List of tablerights for logged in user, in the same order as the Tables array parameter |
| PhoneLocaleTimeZoneData |  |  |
| BaseLocaleTimeZoneData |  |  |
| OverdueSalesCount | int32 | Number of overdued sales for current user |
| NotificationsCount | int32 | Number of new invitations |
| SystemWebPanels | array | Web panels defined in Admin client, set to be shown in Pocket client |
| PocketPreferences | array | All Pocket specific preferences, including WebPanels defined by the user in Pocket |
| IsPushNotificationEnabled | bool | Is push notification configured and enabled in Netserver |
| CustomData | string | Custom data for Pocket, in JSON format |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Pocket/GetPocketStartupData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Tables": [
    "possimus",
    "architecto"
  ],
  "CurrentClientTime": "2016-06-30T18:28:49.748108+02:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TableRights": [
    "fugit",
    "ut"
  ],
  "PhoneLocaleTimeZoneData": {
    "TZLocationID": 469,
    "Name": "Wiza Group",
    "TZLocationCode": "animi",
    "TZLocationCities": "et",
    "IsoNumber": 74,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 606,
        "StartMonth": 245,
        "EndDay": 608,
        "EndMonth": 517,
        "TZOffset": 956,
        "StartRulePattern": "eum",
        "EndRulePattern": "aliquid"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 957,
        "StartMonth": 331,
        "EndDay": 346,
        "EndMonth": 652,
        "TZOffset": 239,
        "StartRulePattern": "laudantium",
        "EndRulePattern": "praesentium"
      }
    }
  },
  "BaseLocaleTimeZoneData": {
    "TZLocationID": 292,
    "Name": "DuBuque, Hessel and Hamill",
    "TZLocationCode": "non",
    "TZLocationCities": "atque",
    "IsoNumber": 16,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 312,
        "StartMonth": 969,
        "EndDay": 4,
        "EndMonth": 807,
        "TZOffset": 635,
        "StartRulePattern": "sed",
        "EndRulePattern": "molestias"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 360,
        "StartMonth": 440,
        "EndDay": 789,
        "EndMonth": 372,
        "TZOffset": 316,
        "StartRulePattern": "nesciunt",
        "EndRulePattern": "adipisci"
      }
    }
  },
  "OverdueSalesCount": 818,
  "NotificationsCount": 819,
  "SystemWebPanels": [
    {
      "WebPanelId": 702,
      "Name": "Crona-Conroy",
      "Tooltip": "vel",
      "Deleted": false,
      "Rank": 244,
      "UrlEncoding": "ANSI",
      "VisibleIn": "ActivityDialog",
      "OnCentral": false,
      "OnSatellite": false,
      "OnTravel": true,
      "OnSalesMarketingWeb": true,
      "OnSalesMarketingPocket": true,
      "ShowInMenuBar": true,
      "ShowInToolBar": false,
      "ShowInAddressBar": false,
      "ShowInStatusBar": false,
      "WindowName": "Carroll Inc and Sons",
      "Url": "http://www.example.com/",
      "ProgId": "amet",
      "Icon": 21,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 180
        }
      }
    }
  ],
  "PocketPreferences": [
    {
      "Level": "Database",
      "RawValue": "id",
      "Specification": {},
      "DisplayValue": "nam",
      "DisplayTooltip": "qui",
      "DisplayType": "Bool",
      "TabOrder": {},
      "TargetId": 862,
      "PrefDescId": 263,
      "TableName": "Lowe, Terry and Bednar",
      "UserPreferenceId": 616,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "IsPushNotificationEnabled": true,
  "CustomData": "sed",
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
      "FieldType": "System.Int32",
      "FieldLength": 535
    }
  }
}
```