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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": {
      "CompanyName": "Oberbrunner Group",
      "SerialNr": "1010000006",
      "OwnerName": "Mann Group",
      "OwnerDescription": "Progressive dedicated adapter",
      "NextCheckDate": "2014-03-18T09:40:59.9300647+01:00",
      "MaintenanceDate": "2003-05-21T09:40:59.9300647+02:00",
      "AdminWarningDate": "2019-07-18T09:40:59.9300647+02:00",
      "ExpiryDate": "2015-05-25T09:40:59.9300647+02:00",
      "GraceDate": "2018-01-02T09:40:59.9300647+01:00",
      "ExtraFlags": 120,
      "ExtraInfo": "itaque",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "sunt",
      "DeploymentType": 191,
      "ProductType": "tempore",
      "ProductDescription": "Optimized well-modulated support",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "accusamus"
    },
    "Current": {
      "CompanyName": "Thompson, Hansen and Hoeger",
      "SerialNr": "1010000006",
      "OwnerName": "Swaniawski LLC",
      "OwnerDescription": "Stand-alone hybrid frame",
      "NextCheckDate": "2002-05-06T09:40:59.9300647+02:00",
      "MaintenanceDate": "2006-07-25T09:40:59.9300647+02:00",
      "AdminWarningDate": "1999-03-03T09:40:59.9300647+01:00",
      "ExpiryDate": "2011-09-27T09:40:59.9300647+02:00",
      "GraceDate": "2002-07-22T09:40:59.9300647+02:00",
      "ExtraFlags": 627,
      "ExtraInfo": "fugit",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "rerum",
      "DeploymentType": 59,
      "ProductType": "sint",
      "ProductDescription": "Total fresh-thinking instruction set",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "accusamus"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 601,
        "NumberOfLicensesFree": 106,
        "NumberOfLicensesAdded": 867,
        "NumberOfLicensesNewTotal": 116,
        "NumberOfLicensesNewFree": 335,
        "NumberOfLicensesTotal": 924
      }
    ],
    "AccumulatedNextCheckDate": "2000-10-02T09:40:59.9300647+02:00"
  },
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": {
      "CompanyName": "Oberbrunner Group",
      "SerialNr": "1010000006",
      "OwnerName": "Mann Group",
      "OwnerDescription": "Progressive dedicated adapter",
      "NextCheckDate": "2014-03-18T09:40:59.9300647+01:00",
      "MaintenanceDate": "2003-05-21T09:40:59.9300647+02:00",
      "AdminWarningDate": "2019-07-18T09:40:59.9300647+02:00",
      "ExpiryDate": "2015-05-25T09:40:59.9300647+02:00",
      "GraceDate": "2018-01-02T09:40:59.9300647+01:00",
      "ExtraFlags": 120,
      "ExtraInfo": "itaque",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "sunt",
      "DeploymentType": 191,
      "ProductType": "tempore",
      "ProductDescription": "Optimized well-modulated support",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "accusamus"
    },
    "Current": {
      "CompanyName": "Thompson, Hansen and Hoeger",
      "SerialNr": "1010000006",
      "OwnerName": "Swaniawski LLC",
      "OwnerDescription": "Stand-alone hybrid frame",
      "NextCheckDate": "2002-05-06T09:40:59.9300647+02:00",
      "MaintenanceDate": "2006-07-25T09:40:59.9300647+02:00",
      "AdminWarningDate": "1999-03-03T09:40:59.9300647+01:00",
      "ExpiryDate": "2011-09-27T09:40:59.9300647+02:00",
      "GraceDate": "2002-07-22T09:40:59.9300647+02:00",
      "ExtraFlags": 627,
      "ExtraInfo": "fugit",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "rerum",
      "DeploymentType": 59,
      "ProductType": "sint",
      "ProductDescription": "Total fresh-thinking instruction set",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "accusamus"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 601,
        "NumberOfLicensesFree": 106,
        "NumberOfLicensesAdded": 867,
        "NumberOfLicensesNewTotal": 116,
        "NumberOfLicensesNewFree": 335,
        "NumberOfLicensesTotal": 924
      }
    ],
    "AccumulatedNextCheckDate": "2000-10-02T09:40:59.9300647+02:00"
  }
]
```