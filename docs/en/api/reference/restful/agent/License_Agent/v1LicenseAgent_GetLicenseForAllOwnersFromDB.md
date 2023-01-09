---
title: POST Agents/License/GetLicenseForAllOwnersFromDB
uid: v1LicenseAgent_GetLicenseForAllOwnersFromDB
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
| New | TableRight |  |
| Current | TableRight |  |
| ExtendedModuleLicenses | array |  |
| AccumulatedNextCheckDate | date-time |  |

## Sample request

```http!
POST /api/v1/Agents/License/GetLicenseForAllOwnersFromDB
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Reason": "",
    "CanBeActivated": false,
    "New": null,
    "Current": null,
    "ExtendedModuleLicenses": [
      {
        "New": null,
        "Current": null,
        "NumberOfLicensesInUse": 90,
        "NumberOfLicensesFree": 902,
        "NumberOfLicensesAdded": 127,
        "NumberOfLicensesNewTotal": 107,
        "NumberOfLicensesNewFree": 503,
        "NumberOfLicensesTotal": 709
      }
    ],
    "AccumulatedNextCheckDate": "2005-06-08T17:37:18.1242409+02:00"
  },
  {
    "Reason": "",
    "CanBeActivated": false,
    "New": null,
    "Current": null,
    "ExtendedModuleLicenses": [
      {
        "New": null,
        "Current": null,
        "NumberOfLicensesInUse": 90,
        "NumberOfLicensesFree": 902,
        "NumberOfLicensesAdded": 127,
        "NumberOfLicensesNewTotal": 107,
        "NumberOfLicensesNewFree": 503,
        "NumberOfLicensesTotal": 709
      }
    ],
    "AccumulatedNextCheckDate": "2005-06-08T17:37:18.1242409+02:00"
  }
]
```