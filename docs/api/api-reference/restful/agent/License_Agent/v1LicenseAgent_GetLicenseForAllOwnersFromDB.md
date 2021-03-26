---
title: POST Agents/License/GetLicenseForAllOwnersFromDB
id: v1LicenseAgent_GetLicenseForAllOwnersFromDB
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
POST /api/v1/Agents/License/GetLicenseForAllOwnersFromDB
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
      "CompanyName": "Bosco-Bartell",
      "SerialNr": "1010000006",
      "OwnerName": "Hegmann-Ruecker",
      "OwnerDescription": "Extended maximized knowledge user",
      "NextCheckDate": "1995-01-22T16:48:29.7289147+01:00",
      "MaintenanceDate": "1995-01-08T16:48:29.7289147+01:00",
      "AdminWarningDate": "1997-06-21T16:48:29.7289147+02:00",
      "ExpiryDate": "1996-01-22T16:48:29.7289147+01:00",
      "GraceDate": "2015-05-21T16:48:29.7289147+02:00",
      "ExtraFlags": 811,
      "ExtraInfo": "fuga",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "debitis",
      "DeploymentType": 249,
      "ProductType": "sed",
      "ProductDescription": "Enterprise-wide incremental application",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "qui"
    },
    "Current": {
      "CompanyName": "Terry LLC",
      "SerialNr": "1010000006",
      "OwnerName": "West Group",
      "OwnerDescription": "Fully-configurable solution-oriented parallelism",
      "NextCheckDate": "2011-06-13T16:48:29.7299247+02:00",
      "MaintenanceDate": "2006-06-14T16:48:29.7299247+02:00",
      "AdminWarningDate": "2013-05-03T16:48:29.7299247+02:00",
      "ExpiryDate": "2008-08-23T16:48:29.7299247+02:00",
      "GraceDate": "2005-01-07T16:48:29.7299247+01:00",
      "ExtraFlags": 604,
      "ExtraInfo": "incidunt",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "totam",
      "DeploymentType": 138,
      "ProductType": "cum",
      "ProductDescription": "Fundamental global algorithm",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "veritatis"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 503,
        "NumberOfLicensesFree": 451,
        "NumberOfLicensesAdded": 856,
        "NumberOfLicensesNewTotal": 513,
        "NumberOfLicensesNewFree": 313,
        "NumberOfLicensesTotal": 138
      }
    ],
    "AccumulatedNextCheckDate": "1995-06-29T16:48:29.7299247+02:00"
  },
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": {
      "CompanyName": "Bosco-Bartell",
      "SerialNr": "1010000006",
      "OwnerName": "Hegmann-Ruecker",
      "OwnerDescription": "Extended maximized knowledge user",
      "NextCheckDate": "1995-01-22T16:48:29.7289147+01:00",
      "MaintenanceDate": "1995-01-08T16:48:29.7289147+01:00",
      "AdminWarningDate": "1997-06-21T16:48:29.7289147+02:00",
      "ExpiryDate": "1996-01-22T16:48:29.7289147+01:00",
      "GraceDate": "2015-05-21T16:48:29.7289147+02:00",
      "ExtraFlags": 811,
      "ExtraInfo": "fuga",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "debitis",
      "DeploymentType": 249,
      "ProductType": "sed",
      "ProductDescription": "Enterprise-wide incremental application",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "qui"
    },
    "Current": {
      "CompanyName": "Terry LLC",
      "SerialNr": "1010000006",
      "OwnerName": "West Group",
      "OwnerDescription": "Fully-configurable solution-oriented parallelism",
      "NextCheckDate": "2011-06-13T16:48:29.7299247+02:00",
      "MaintenanceDate": "2006-06-14T16:48:29.7299247+02:00",
      "AdminWarningDate": "2013-05-03T16:48:29.7299247+02:00",
      "ExpiryDate": "2008-08-23T16:48:29.7299247+02:00",
      "GraceDate": "2005-01-07T16:48:29.7299247+01:00",
      "ExtraFlags": 604,
      "ExtraInfo": "incidunt",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "totam",
      "DeploymentType": 138,
      "ProductType": "cum",
      "ProductDescription": "Fundamental global algorithm",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "veritatis"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 503,
        "NumberOfLicensesFree": 451,
        "NumberOfLicensesAdded": 856,
        "NumberOfLicensesNewTotal": 513,
        "NumberOfLicensesNewFree": 313,
        "NumberOfLicensesTotal": 138
      }
    ],
    "AccumulatedNextCheckDate": "1995-06-29T16:48:29.7299247+02:00"
  }
]
```