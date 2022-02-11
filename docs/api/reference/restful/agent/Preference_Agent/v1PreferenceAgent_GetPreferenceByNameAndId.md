---
title: POST Agents/Preference/GetPreferenceByNameAndId
id: v1PreferenceAgent_GetPreferenceByNameAndId
---

# POST Agents/Preference/GetPreferenceByNameAndId

```http
POST /api/v1/Agents/Preference/GetPreferenceByNameAndId
```

Get a preference by name and owner id.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Preference/GetPreferenceByNameAndId?$select=name,department,category/id
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

PrefSection, PrefKey, PrefLevel, OwnerId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PrefSection | string |  |
| PrefKey | string |  |
| PrefLevel | string |  |
| OwnerId | int32 |  |


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
POST /api/v1/Agents/Preference/GetPreferenceByNameAndId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PrefSection": "facilis",
  "PrefKey": "est",
  "PrefLevel": "Database",
  "OwnerId": 158
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Level": "Database",
  "RawValue": "tempore",
  "Specification": {
    "Section": "quam",
    "Key": "ab",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 603
      }
    }
  },
  "DisplayValue": "doloribus",
  "DisplayTooltip": "dolorem",
  "DisplayType": "Bool",
  "TabOrder": {
    "TabOrderId": 372,
    "TabName": "Cummings LLC",
    "Order": "incidunt",
    "AssociateId": 893,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 681
      }
    }
  },
  "TargetId": 412,
  "PrefDescId": 402,
  "TableName": "Carroll, McKenzie and Bailey",
  "UserPreferenceId": 316,
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
      "FieldLength": 425
    }
  }
}
```