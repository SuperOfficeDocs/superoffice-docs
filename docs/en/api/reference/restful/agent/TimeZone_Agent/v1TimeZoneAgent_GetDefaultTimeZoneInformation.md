---
title: POST Agents/TimeZone/GetDefaultTimeZoneInformation
uid: v1TimeZoneAgent_GetDefaultTimeZoneInformation
generated: true
---

# POST Agents/TimeZone/GetDefaultTimeZoneInformation

```http
POST /api/v1/Agents/TimeZone/GetDefaultTimeZoneInformation
```

Get information about the current, preferred timezone for the current user.


If no such preference has been set, returns the correct fallback (and UserPreferenceId is 0)






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/TimeZone/GetDefaultTimeZoneInformation?$select=name,department,category/id
```


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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreferredTimeZone

| Property Name | Type |  Description |
|----------------|------|--------------|
| PreferenceId | int32 | Primary key of userpreference row that specifies the TZLocationId, if set; 0 if the data are from a fallback (but still valid) |
| TZLocationId | int32 | Primary key |
| LocationCode | string | Code, such as CA-NT, identifying the timezone location in the imported data. Unique, NOT equal to the culture codes of Windows |
| Description | string | Description of the time zone |
| Country | string | Name of the country of the time zone |
| Bias | int32 | number of minutes bias relative to UTC time |

## Sample request

```http!
POST /api/v1/Agents/TimeZone/GetDefaultTimeZoneInformation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PreferenceId": 322,
  "TZLocationId": 216,
  "LocationCode": "qui",
  "Description": "Inverse interactive methodology",
  "Country": "Sokovia",
  "Bias": 960
}
```