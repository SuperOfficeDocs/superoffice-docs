---
title: POST Agents/Preference/CreateDefaultPreference
id: v1PreferenceAgent_CreateDefaultPreference
---

# POST Agents/Preference/CreateDefaultPreference

```http
POST /api/v1/Agents/Preference/CreateDefaultPreference
```

Set default values into a new Preference.

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


## Response: object

One preference item, which contains a specification (section/key), the raw string value, and the level at which this value was found.



Carrier object for Preference.
Services for the Preference Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPreferenceAgent">Preference Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Level | string | Preference level, using the standard enumerated type. Undefined is returned for preferences that do not have a current setting. |
| RawValue | string | Preference value |
| Specification |  | Preference specification, consisting of the section name and key name |
| DisplayValue | string | Display value, populated when asked for. Suitable for binding display-datasource in lists, etc. Formatted using CultureDataFormatter. |
| DisplayTooltip | string | Display tooltip, populated when asked for. Suitable for binding display-datasource in lists, etc. Formatted using CultureDataFormatter. |
| DisplayType | string | Display type, populated when asked for. |
| TabOrder |  | Carrier object for TabOrder. Services for the TabOrder Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPreferenceAgent">Preference Agent</see>. |
| TargetId | int32 | The id of the target row. The table it points at is specified by the preference type. |
| PrefDescId | int32 | The id of the prefdesc this preference is connected to |
| TableName | string | For DisplayType=PrefDescValueType.ListTableRef, TableName will contain the name of the table which the value reference to. |
| UserPreferenceId | int32 | The id of the user preference |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Preference/CreateDefaultPreference
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Level": "Database",
  "RawValue": "omnis",
  "Specification": {
    "Section": "non",
    "Key": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 85
      }
    }
  },
  "DisplayValue": "molestiae",
  "DisplayTooltip": "molestias",
  "DisplayType": "Bool",
  "TabOrder": {
    "TabOrderId": 672,
    "TabName": "Satterfield-Langworth",
    "Order": "officiis",
    "AssociateId": 914,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 605
      }
    }
  },
  "TargetId": 315,
  "PrefDescId": 873,
  "TableName": "O'Kon LLC",
  "UserPreferenceId": 487,
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
      "FieldLength": 363
    }
  }
}
```