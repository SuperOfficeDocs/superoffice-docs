---
title: GetLicenseForAllOwnersFromDB
id: v1LicenseAgent_GetLicenseForAllOwnersFromDB
---

# GetLicenseForAllOwnersFromDB

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
      "CompanyName": "Wolff Group",
      "SerialNr": "1010000006",
      "OwnerName": "Schulist Group",
      "OwnerDescription": "Sharable multi-state concept",
      "NextCheckDate": "2006-05-15T14:58:04.3234438+02:00",
      "MaintenanceDate": "1999-11-11T14:58:04.3234438+01:00",
      "AdminWarningDate": "2000-05-20T14:58:04.3234438+02:00",
      "ExpiryDate": "2001-11-03T14:58:04.3234438+01:00",
      "GraceDate": "2014-07-09T14:58:04.3234438+02:00",
      "ExtraFlags": 177,
      "ExtraInfo": "delectus",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "omnis",
      "DeploymentType": 43,
      "ProductType": "perferendis",
      "ProductDescription": "Stand-alone next generation database",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "et"
    },
    "Current": {
      "CompanyName": "Kuvalis, Kuphal and Herman",
      "SerialNr": "1010000006",
      "OwnerName": "Shields, Hintz and Anderson",
      "OwnerDescription": "Optional client-driven frame",
      "NextCheckDate": "1999-09-23T14:58:04.3234438+02:00",
      "MaintenanceDate": "2000-06-08T14:58:04.3234438+02:00",
      "AdminWarningDate": "2004-08-06T14:58:04.3234438+02:00",
      "ExpiryDate": "1994-08-16T14:58:04.3234438+02:00",
      "GraceDate": "2006-04-04T14:58:04.3234438+02:00",
      "ExtraFlags": 211,
      "ExtraInfo": "dolores",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "qui",
      "DeploymentType": 256,
      "ProductType": "tempore",
      "ProductDescription": "Expanded didactic moderator",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "eaque"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 155,
        "NumberOfLicensesFree": 130,
        "NumberOfLicensesAdded": 11,
        "NumberOfLicensesNewTotal": 835,
        "NumberOfLicensesNewFree": 863,
        "NumberOfLicensesTotal": 824
      }
    ],
    "AccumulatedNextCheckDate": "2017-08-05T14:58:04.3234438+02:00"
  },
  {
    "Reason": "",
    "CanBeActivated": true,
    "New": {
      "CompanyName": "Wolff Group",
      "SerialNr": "1010000006",
      "OwnerName": "Schulist Group",
      "OwnerDescription": "Sharable multi-state concept",
      "NextCheckDate": "2006-05-15T14:58:04.3234438+02:00",
      "MaintenanceDate": "1999-11-11T14:58:04.3234438+01:00",
      "AdminWarningDate": "2000-05-20T14:58:04.3234438+02:00",
      "ExpiryDate": "2001-11-03T14:58:04.3234438+01:00",
      "GraceDate": "2014-07-09T14:58:04.3234438+02:00",
      "ExtraFlags": 177,
      "ExtraInfo": "delectus",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "omnis",
      "DeploymentType": 43,
      "ProductType": "perferendis",
      "ProductDescription": "Stand-alone next generation database",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "et"
    },
    "Current": {
      "CompanyName": "Kuvalis, Kuphal and Herman",
      "SerialNr": "1010000006",
      "OwnerName": "Shields, Hintz and Anderson",
      "OwnerDescription": "Optional client-driven frame",
      "NextCheckDate": "1999-09-23T14:58:04.3234438+02:00",
      "MaintenanceDate": "2000-06-08T14:58:04.3234438+02:00",
      "AdminWarningDate": "2004-08-06T14:58:04.3234438+02:00",
      "ExpiryDate": "1994-08-16T14:58:04.3234438+02:00",
      "GraceDate": "2006-04-04T14:58:04.3234438+02:00",
      "ExtraFlags": 211,
      "ExtraInfo": "dolores",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "qui",
      "DeploymentType": 256,
      "ProductType": "tempore",
      "ProductDescription": "Expanded didactic moderator",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "eaque"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 155,
        "NumberOfLicensesFree": 130,
        "NumberOfLicensesAdded": 11,
        "NumberOfLicensesNewTotal": 835,
        "NumberOfLicensesNewFree": 863,
        "NumberOfLicensesTotal": 824
      }
    ],
    "AccumulatedNextCheckDate": "2017-08-05T14:58:04.3234438+02:00"
  }
]
```