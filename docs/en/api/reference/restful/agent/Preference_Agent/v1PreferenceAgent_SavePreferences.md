---
title: POST Agents/Preference/SavePreferences
uid: v1PreferenceAgent_SavePreferences
generated: true
---

# POST Agents/Preference/SavePreferences

```http
POST /api/v1/Agents/Preference/SavePreferences
```

Save this set of preferences.


Note this method DOES NOT look at level/targetId - it only saves on behalf of the CURRENT USER.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Preference/SavePreferences?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

Preferences 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Preferences | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Preference/SavePreferences
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Preferences": [
    {
      "Level": "Database",
      "RawValue": "cum",
      "Specification": null,
      "DisplayValue": "iure",
      "DisplayTooltip": "exercitationem",
      "DisplayType": "Bool",
      "TabOrder": null,
      "TargetId": 127,
      "PrefDescId": 35,
      "TableName": "Hackett-Erdman",
      "UserPreferenceId": 657
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```