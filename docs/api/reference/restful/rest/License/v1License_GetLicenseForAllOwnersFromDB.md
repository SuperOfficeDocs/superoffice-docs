---
title: GET License
id: v1License_GetLicenseForAllOwnersFromDB
---

# GET License

```http
GET /api/v1/License
```

Get all licenses, with usage, from all module owners as they are stored in the database








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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
GET /api/v1/License
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": {
      "CompanyName": "Trantow, Bruen and Hahn",
      "SerialNr": "1010000006",
      "OwnerName": "VonRueden Inc and Sons",
      "OwnerDescription": "Total content-based policy",
      "NextCheckDate": "2021-01-15T18:25:51.366118+01:00",
      "MaintenanceDate": "2013-01-11T18:25:51.366118+01:00",
      "AdminWarningDate": "1996-01-09T18:25:51.366118+01:00",
      "ExpiryDate": "2011-08-20T18:25:51.366118+02:00",
      "GraceDate": "2001-05-04T18:25:51.366118+02:00",
      "ExtraFlags": 237,
      "ExtraInfo": "fugit",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "et",
      "DeploymentType": 119,
      "ProductType": "odio",
      "ProductDescription": "Grass-roots responsive task-force",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "distinctio"
    },
    "Current": {
      "CompanyName": "Boehm, Rempel and Kessler",
      "SerialNr": "1010000006",
      "OwnerName": "Ebert, Lueilwitz and O'Conner",
      "OwnerDescription": "Fundamental national software",
      "NextCheckDate": "2020-03-12T18:25:51.366118+01:00",
      "MaintenanceDate": "2001-07-09T18:25:51.366118+02:00",
      "AdminWarningDate": "2020-08-02T18:25:51.366118+02:00",
      "ExpiryDate": "2013-01-30T18:25:51.366118+01:00",
      "GraceDate": "2018-04-26T18:25:51.366118+02:00",
      "ExtraFlags": 984,
      "ExtraInfo": "dicta",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "error",
      "DeploymentType": 322,
      "ProductType": "corporis",
      "ProductDescription": "Focused homogeneous array",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "blanditiis"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 761,
        "NumberOfLicensesFree": 513,
        "NumberOfLicensesAdded": 257,
        "NumberOfLicensesNewTotal": 103,
        "NumberOfLicensesNewFree": 563,
        "NumberOfLicensesTotal": 969
      }
    ],
    "AccumulatedNextCheckDate": "2017-08-25T18:25:51.366118+02:00"
  },
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": {
      "CompanyName": "Trantow, Bruen and Hahn",
      "SerialNr": "1010000006",
      "OwnerName": "VonRueden Inc and Sons",
      "OwnerDescription": "Total content-based policy",
      "NextCheckDate": "2021-01-15T18:25:51.366118+01:00",
      "MaintenanceDate": "2013-01-11T18:25:51.366118+01:00",
      "AdminWarningDate": "1996-01-09T18:25:51.366118+01:00",
      "ExpiryDate": "2011-08-20T18:25:51.366118+02:00",
      "GraceDate": "2001-05-04T18:25:51.366118+02:00",
      "ExtraFlags": 237,
      "ExtraInfo": "fugit",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "et",
      "DeploymentType": 119,
      "ProductType": "odio",
      "ProductDescription": "Grass-roots responsive task-force",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "distinctio"
    },
    "Current": {
      "CompanyName": "Boehm, Rempel and Kessler",
      "SerialNr": "1010000006",
      "OwnerName": "Ebert, Lueilwitz and O'Conner",
      "OwnerDescription": "Fundamental national software",
      "NextCheckDate": "2020-03-12T18:25:51.366118+01:00",
      "MaintenanceDate": "2001-07-09T18:25:51.366118+02:00",
      "AdminWarningDate": "2020-08-02T18:25:51.366118+02:00",
      "ExpiryDate": "2013-01-30T18:25:51.366118+01:00",
      "GraceDate": "2018-04-26T18:25:51.366118+02:00",
      "ExtraFlags": 984,
      "ExtraInfo": "dicta",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "error",
      "DeploymentType": 322,
      "ProductType": "corporis",
      "ProductDescription": "Focused homogeneous array",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "blanditiis"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 761,
        "NumberOfLicensesFree": 513,
        "NumberOfLicensesAdded": 257,
        "NumberOfLicensesNewTotal": 103,
        "NumberOfLicensesNewFree": 563,
        "NumberOfLicensesTotal": 969
      }
    ],
    "AccumulatedNextCheckDate": "2017-08-25T18:25:51.366118+02:00"
  }
]
```