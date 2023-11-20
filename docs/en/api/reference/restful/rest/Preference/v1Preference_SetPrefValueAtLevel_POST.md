---
title: POST Preference/{section}/{key}/{prefLevel}
uid: v1Preference_SetPrefValueAtLevel_POST
generated: true
---

# POST Preference/{section}/{key}/{prefLevel}

```http
POST /api/v1/Preference/{section}/{key}/{prefLevel}
```

Sets the preference value for specific section + key.


Calls the Preference agent service SetPreference or SetPreferenceEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| section | string | The name of the preference section. **Required** |
| key | string | The name of the preference key. **Required** |
| prefLevel | Enum: Undefined, HardDefault, SystemWide, Database, Group, Individual, PC | The level the preference is defined at. 0 or Undefined = the level closest to the user. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| value | string | **Required** The preference value as a string |

```http
POST /api/v1/Preference/{section}/{key}/{prefLevel}?value=consequatur
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Preference/{section}/{key}/{prefLevel}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```