---
title: POST Preference/{section}/{key}
uid: v1Preference_SetPrefValue_POST
generated: true
---

# POST Preference/{section}/{key}

```http
POST /api/v1/Preference/{section}/{key}
```

Sets the preference value for specific section + key.


Calls the Preference agent service SetPreference or SetPreferenceEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| section | string | The name of the preference section. **Required** |
| key | string | The name of the preference key. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: pref 

The preference definition 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Level | String | Preference level, using the standard enumerated type. Undefined is returned for preferences that do not have a current setting. |
| RawValue | String | Preference value |
| Specification | PreferenceSpec | Preference specification, consisting of the section name and key name |
| DisplayValue | String | Display value, populated when asked for. Suitable for binding display-datasource in lists, etc. Formatted using CultureDataFormatter. |
| DisplayTooltip | String | Display tooltip, populated when asked for. Suitable for binding display-datasource in lists, etc. Formatted using CultureDataFormatter. |
| DisplayType | String | Display type, populated when asked for. |
| TabOrder | TabOrder | Carrier object for TabOrder. Services for the TabOrder Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPreferenceAgent">Preference Agent</see>. |
| TargetId | Integer | The id of the target row. The table it points at is specified by the preference type. |
| PrefDescId | Integer | The id of the prefdesc this preference is connected to |
| TableName | String | For DisplayType=PrefDescValueType.ListTableRef, TableName will contain the name of the table which the value reference to. |
| UserPreferenceId | Integer | The id of the user preference |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Preference/{section}/{key}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Level": "Database",
  "RawValue": "qui",
  "Specification": null,
  "DisplayValue": "explicabo",
  "DisplayTooltip": "quisquam",
  "DisplayType": "Bool",
  "TabOrder": null,
  "TargetId": 207,
  "PrefDescId": 497,
  "TableName": "Hane-Rosenbaum",
  "UserPreferenceId": 186
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```