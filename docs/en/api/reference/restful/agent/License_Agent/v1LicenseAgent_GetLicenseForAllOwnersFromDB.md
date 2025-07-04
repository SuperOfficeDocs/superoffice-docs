---
title: POST Agents/License/GetLicenseForAllOwnersFromDB
uid: v1LicenseAgent_GetLicenseForAllOwnersFromDB
generated: true
---

# POST Agents/License/GetLicenseForAllOwnersFromDB

```http
POST /api/v1/Agents/License/GetLicenseForAllOwnersFromDB
```

Get all licenses, with usage, from all module owners as they are stored in the database







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetLicenseForAllOwnersFromDB?$select=name,department,category/id
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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/License/GetLicenseForAllOwnersFromDB
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": null,
    "Current": null,
    "ExtendedModuleLicenses": [
      {
        "New": null,
        "Current": null,
        "NumberOfLicensesInUse": 908,
        "NumberOfLicensesFree": 319,
        "NumberOfLicensesAdded": 764,
        "NumberOfLicensesNewTotal": 239,
        "NumberOfLicensesNewFree": 296,
        "NumberOfLicensesTotal": 634
      }
    ],
    "AccumulatedNextCheckDate": "2008-06-10T03:45:23.498579+02:00"
  },
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": null,
    "Current": null,
    "ExtendedModuleLicenses": [
      {
        "New": null,
        "Current": null,
        "NumberOfLicensesInUse": 908,
        "NumberOfLicensesFree": 319,
        "NumberOfLicensesAdded": 764,
        "NumberOfLicensesNewTotal": 239,
        "NumberOfLicensesNewFree": 296,
        "NumberOfLicensesTotal": 634
      }
    ],
    "AccumulatedNextCheckDate": "2008-06-10T03:45:23.498579+02:00"
  }
]
```