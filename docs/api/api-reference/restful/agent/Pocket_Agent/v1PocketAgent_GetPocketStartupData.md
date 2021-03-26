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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Tables": [
    "atque",
    "eaque"
  ],
  "CurrentClientTime": "1995-07-16T16:48:30.2259345+02:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TableRights": [
    "voluptatem",
    "quos"
  ],
  "PhoneLocaleTimeZoneData": {
    "TZLocationID": 845,
    "Name": "Barrows, Gerhold and Sauer",
    "TZLocationCode": "qui",
    "TZLocationCities": "voluptas",
    "IsoNumber": 72,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 579,
        "StartMonth": 971,
        "EndDay": 468,
        "EndMonth": 876,
        "TZOffset": 156,
        "StartRulePattern": "neque",
        "EndRulePattern": "dolor"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 316,
        "StartMonth": 880,
        "EndDay": 996,
        "EndMonth": 873,
        "TZOffset": 617,
        "StartRulePattern": "et",
        "EndRulePattern": "omnis"
      }
    }
  },
  "BaseLocaleTimeZoneData": {
    "TZLocationID": 721,
    "Name": "Fadel Group",
    "TZLocationCode": "excepturi",
    "TZLocationCities": "modi",
    "IsoNumber": 73,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 822,
        "StartMonth": 855,
        "EndDay": 890,
        "EndMonth": 706,
        "TZOffset": 993,
        "StartRulePattern": "accusamus",
        "EndRulePattern": "dolores"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 303,
        "StartMonth": 879,
        "EndDay": 242,
        "EndMonth": 370,
        "TZOffset": 158,
        "StartRulePattern": "ut",
        "EndRulePattern": "laborum"
      }
    }
  },
  "OverdueSalesCount": 850,
  "NotificationsCount": 984,
  "SystemWebPanels": [
    {
      "WebPanelId": 414,
      "Name": "Heidenreich Inc and Sons",
      "Tooltip": "quod",
      "Deleted": true,
      "Rank": 846,
      "UrlEncoding": "ANSI",
      "VisibleIn": "ActivityDialog",
      "OnCentral": false,
      "OnSatellite": true,
      "OnTravel": false,
      "OnSalesMarketingWeb": false,
      "OnSalesMarketingPocket": true,
      "ShowInMenuBar": true,
      "ShowInToolBar": true,
      "ShowInAddressBar": false,
      "ShowInStatusBar": false,
      "WindowName": "Abbott, Keebler and Botsford",
      "Url": "http://www.example.com/",
      "ProgId": "ad",
      "Icon": 538,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "whiteboard out-of-the-box e-business"
          },
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    }
  ],
  "PocketPreferences": [
    {
      "Level": "Database",
      "RawValue": "autem",
      "Specification": {},
      "DisplayValue": "nihil",
      "DisplayTooltip": "magnam",
      "DisplayType": "Bool",
      "TabOrder": {},
      "TargetId": 26,
      "PrefDescId": 318,
      "TableName": "Hegmann, Swift and Hackett",
      "UserPreferenceId": 848,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "IsPushNotificationEnabled": false,
  "CustomData": "voluptatibus",
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
      "FieldLength": 393
    }
  }
}
```