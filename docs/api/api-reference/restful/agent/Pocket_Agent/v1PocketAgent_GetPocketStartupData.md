---
title: GetPocketStartupData
id: v1PocketAgent_GetPocketStartupData
---

# GetPocketStartupData

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
    "sint"
  ],
  "CurrentClientTime": "1998-11-16T14:58:04.8244624+01:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TableRights": [
    "repellat",
    "quo"
  ],
  "PhoneLocaleTimeZoneData": {
    "TZLocationID": 654,
    "Name": "Crona Inc and Sons",
    "TZLocationCode": "officia",
    "TZLocationCities": "ipsum",
    "IsoNumber": 735,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 985,
        "StartMonth": 3,
        "EndDay": 937,
        "EndMonth": 827,
        "TZOffset": 55,
        "StartRulePattern": "architecto",
        "EndRulePattern": "hic"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 316,
        "StartMonth": 482,
        "EndDay": 185,
        "EndMonth": 122,
        "TZOffset": 394,
        "StartRulePattern": "facere",
        "EndRulePattern": "aliquam"
      }
    }
  },
  "BaseLocaleTimeZoneData": {
    "TZLocationID": 957,
    "Name": "Upton, Wolf and Tillman",
    "TZLocationCode": "placeat",
    "TZLocationCities": "ea",
    "IsoNumber": 84,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 334,
        "StartMonth": 521,
        "EndDay": 889,
        "EndMonth": 806,
        "TZOffset": 896,
        "StartRulePattern": "sint",
        "EndRulePattern": "aspernatur"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 44,
        "StartMonth": 712,
        "EndDay": 18,
        "EndMonth": 151,
        "TZOffset": 141,
        "StartRulePattern": "nobis",
        "EndRulePattern": "provident"
      }
    }
  },
  "OverdueSalesCount": 533,
  "NotificationsCount": 774,
  "SystemWebPanels": [
    {
      "WebPanelId": 899,
      "Name": "Leuschke-Harber",
      "Tooltip": "praesentium",
      "Deleted": false,
      "Rank": 11,
      "UrlEncoding": "ANSI",
      "VisibleIn": "ActivityDialog",
      "OnCentral": true,
      "OnSatellite": true,
      "OnTravel": false,
      "OnSalesMarketingWeb": false,
      "OnSalesMarketingPocket": true,
      "ShowInMenuBar": true,
      "ShowInToolBar": true,
      "ShowInAddressBar": false,
      "ShowInStatusBar": true,
      "WindowName": "Kozey-Steuber",
      "Url": "http://www.example.com/",
      "ProgId": "suscipit",
      "Icon": 548,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 744
        }
      }
    }
  ],
  "PocketPreferences": [
    {
      "Level": "Database",
      "RawValue": "numquam",
      "Specification": {},
      "DisplayValue": "et",
      "DisplayTooltip": "sapiente",
      "DisplayType": "Bool",
      "TabOrder": {},
      "TargetId": 558,
      "PrefDescId": 147,
      "TableName": "Schinner-Ullrich",
      "UserPreferenceId": 286,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 441
        }
      }
    }
  ],
  "IsPushNotificationEnabled": true,
  "CustomData": "et",
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
      "FieldLength": 42
    }
  }
}
```