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
      "CompanyName": "Johns, Reynolds and Purdy",
      "SerialNr": "1010000006",
      "OwnerName": "Ortiz-Littel",
      "OwnerDescription": "Robust attitude-oriented pricing structure",
      "NextCheckDate": "2010-11-25T15:05:43.0046329+01:00",
      "MaintenanceDate": "2003-04-30T15:05:43.0046329+02:00",
      "AdminWarningDate": "2021-06-06T15:05:43.0046329+02:00",
      "ExpiryDate": "2016-06-29T15:05:43.0046329+02:00",
      "GraceDate": "2016-07-15T15:05:43.0046329+02:00",
      "ExtraFlags": 578,
      "ExtraInfo": "porro",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "iure",
      "DeploymentType": 273,
      "ProductType": "odio",
      "ProductDescription": "Configurable local strategy",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "officia"
    },
    "Current": {
      "CompanyName": "Goodwin-Keeling",
      "SerialNr": "1010000006",
      "OwnerName": "Cole Inc and Sons",
      "OwnerDescription": "Centralized 24/7 architecture",
      "NextCheckDate": "2009-07-30T15:05:43.0046329+02:00",
      "MaintenanceDate": "2015-11-22T15:05:43.0046329+01:00",
      "AdminWarningDate": "2020-05-22T15:05:43.0046329+02:00",
      "ExpiryDate": "2014-08-13T15:05:43.0046329+02:00",
      "GraceDate": "2001-02-20T15:05:43.0046329+01:00",
      "ExtraFlags": 836,
      "ExtraInfo": "aperiam",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "qui",
      "DeploymentType": 294,
      "ProductType": "saepe",
      "ProductDescription": "Robust fresh-thinking challenge",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "qui"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 350,
        "NumberOfLicensesFree": 979,
        "NumberOfLicensesAdded": 633,
        "NumberOfLicensesNewTotal": 134,
        "NumberOfLicensesNewFree": 686,
        "NumberOfLicensesTotal": 413
      }
    ],
    "AccumulatedNextCheckDate": "1995-07-08T15:05:43.0046329+02:00"
  },
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": {
      "CompanyName": "Johns, Reynolds and Purdy",
      "SerialNr": "1010000006",
      "OwnerName": "Ortiz-Littel",
      "OwnerDescription": "Robust attitude-oriented pricing structure",
      "NextCheckDate": "2010-11-25T15:05:43.0046329+01:00",
      "MaintenanceDate": "2003-04-30T15:05:43.0046329+02:00",
      "AdminWarningDate": "2021-06-06T15:05:43.0046329+02:00",
      "ExpiryDate": "2016-06-29T15:05:43.0046329+02:00",
      "GraceDate": "2016-07-15T15:05:43.0046329+02:00",
      "ExtraFlags": 578,
      "ExtraInfo": "porro",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "iure",
      "DeploymentType": 273,
      "ProductType": "odio",
      "ProductDescription": "Configurable local strategy",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "officia"
    },
    "Current": {
      "CompanyName": "Goodwin-Keeling",
      "SerialNr": "1010000006",
      "OwnerName": "Cole Inc and Sons",
      "OwnerDescription": "Centralized 24/7 architecture",
      "NextCheckDate": "2009-07-30T15:05:43.0046329+02:00",
      "MaintenanceDate": "2015-11-22T15:05:43.0046329+01:00",
      "AdminWarningDate": "2020-05-22T15:05:43.0046329+02:00",
      "ExpiryDate": "2014-08-13T15:05:43.0046329+02:00",
      "GraceDate": "2001-02-20T15:05:43.0046329+01:00",
      "ExtraFlags": 836,
      "ExtraInfo": "aperiam",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "qui",
      "DeploymentType": 294,
      "ProductType": "saepe",
      "ProductDescription": "Robust fresh-thinking challenge",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "qui"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 350,
        "NumberOfLicensesFree": 979,
        "NumberOfLicensesAdded": 633,
        "NumberOfLicensesNewTotal": 134,
        "NumberOfLicensesNewFree": 686,
        "NumberOfLicensesTotal": 413
      }
    ],
    "AccumulatedNextCheckDate": "1995-07-08T15:05:43.0046329+02:00"
  }
]
```