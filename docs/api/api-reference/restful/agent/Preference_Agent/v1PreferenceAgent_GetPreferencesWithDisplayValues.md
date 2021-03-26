---
title: POST Agents/Preference/GetPreferencesWithDisplayValues
id: v1PreferenceAgent_GetPreferencesWithDisplayValues
---

# POST Agents/Preference/GetPreferencesWithDisplayValues

```http
POST /api/v1/Agents/Preference/GetPreferencesWithDisplayValues
```

Get one or more preferences based on a set of specifications&lt;br/&gt;The PrefDisplayValue and PrefDisplaytooltip are populated, at some additional processing cost.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Preference/GetPreferencesWithDisplayValues?$select=name,department,category/id
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

Specifications 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Specifications | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/Preference/GetPreferencesWithDisplayValues
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Specifications": [
    {
      "Section": "nemo",
      "Key": "quas"
    },
    {
      "Section": "nemo",
      "Key": "quas"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Level": "Database",
    "RawValue": "quos",
    "Specification": {
      "Section": "eum",
      "Key": "totam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate robust content"
          },
          "FieldType": "System.String",
          "FieldLength": 908
        }
      }
    },
    "DisplayValue": "nesciunt",
    "DisplayTooltip": "id",
    "DisplayType": "Bool",
    "TabOrder": {
      "TabOrderId": 697,
      "TabName": "Reynolds Inc and Sons",
      "Order": "ipsum",
      "AssociateId": 658,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    },
    "TargetId": 797,
    "PrefDescId": 494,
    "TableName": "Collins-Nolan",
    "UserPreferenceId": 556,
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
        "FieldLength": 701
      }
    }
  }
]
```