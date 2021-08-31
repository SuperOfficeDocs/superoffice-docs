---
title: GET License/{ownerName}
id: v1License_GetLicenseFromDB
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Reason | string |  |
| CanBeActivated | bool |  |
| New |  |  |
| Current |  |  |
| ExtendedModuleLicenses | array |  |
| AccumulatedNextCheckDate | date-time |  |

## Sample Request

```http!
GET /api/v1/License/{ownerName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Kreiger-Gulgowski",
    "SerialNr": "1010000006",
    "OwnerName": "Boyle LLC",
    "OwnerDescription": "Implemented 24 hour middleware",
    "NextCheckDate": "2017-10-19T15:05:43.0066629+02:00",
    "MaintenanceDate": "2009-06-12T15:05:43.0066629+02:00",
    "AdminWarningDate": "2005-05-28T15:05:43.0066629+02:00",
    "ExpiryDate": "2000-03-25T15:05:43.0066629+01:00",
    "GraceDate": "1995-04-20T15:05:43.0066629+02:00",
    "ExtraFlags": 841,
    "ExtraInfo": "qui",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "qui",
    "DeploymentType": 142,
    "ProductType": "ipsa",
    "ProductDescription": "Multi-tiered systematic parallelism",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "cum"
  },
  "Current": {
    "CompanyName": "Ledner, Hayes and Steuber",
    "SerialNr": "1010000006",
    "OwnerName": "Carroll, Bode and Rosenbaum",
    "OwnerDescription": "Organized mission-critical infrastructure",
    "NextCheckDate": "2011-06-21T15:05:43.0066629+02:00",
    "MaintenanceDate": "2011-09-16T15:05:43.0066629+02:00",
    "AdminWarningDate": "2017-11-06T15:05:43.0066629+01:00",
    "ExpiryDate": "2016-12-25T15:05:43.0066629+01:00",
    "GraceDate": "2020-07-18T15:05:43.0066629+02:00",
    "ExtraFlags": 863,
    "ExtraInfo": "voluptas",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "omnis",
    "DeploymentType": 446,
    "ProductType": "iure",
    "ProductDescription": "Up-sized actuating policy",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "voluptate"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 998,
      "NumberOfLicensesFree": 449,
      "NumberOfLicensesAdded": 387,
      "NumberOfLicensesNewTotal": 264,
      "NumberOfLicensesNewFree": 673,
      "NumberOfLicensesTotal": 544
    }
  ],
  "AccumulatedNextCheckDate": "2008-07-15T15:05:43.0066629+02:00"
}
```