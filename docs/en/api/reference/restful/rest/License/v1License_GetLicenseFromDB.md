---
title: GET License/{ownerName}
uid: v1License_GetLicenseFromDB
generated: true
---

# GET License/{ownerName}

```http
GET /api/v1/License/{ownerName}
```

Get license, with usage, as it is stored in the database for one particular module owner.






| Path Part | Type | Description |
|-----------|------|-------------|
| ownerName | string | Name of the module owner. **Required** |



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

### Response body: TimeZoneData

| Property Name | Type |  Description |
|----------------|------|--------------|
| Reason | string |  |
| CanBeActivated | bool |  |
| New | TimeZoneData |  |
| Current | TimeZoneData |  |
| ExtendedModuleLicenses | array |  |
| AccumulatedNextCheckDate | date-time |  |

## Sample request

```http!
GET /api/v1/License/{ownerName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": true,
  "New": null,
  "Current": null,
  "ExtendedModuleLicenses": [
    {
      "New": null,
      "Current": null,
      "NumberOfLicensesInUse": 864,
      "NumberOfLicensesFree": 232,
      "NumberOfLicensesAdded": 853,
      "NumberOfLicensesNewTotal": 788,
      "NumberOfLicensesNewFree": 316,
      "NumberOfLicensesTotal": 286
    }
  ],
  "AccumulatedNextCheckDate": "2001-07-15T03:45:28.8109239+02:00"
}
```