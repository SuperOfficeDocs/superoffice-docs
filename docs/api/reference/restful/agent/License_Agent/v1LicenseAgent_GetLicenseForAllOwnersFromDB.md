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
    "CanBeActivated": false,
    "New": {
      "CompanyName": "Von Group",
      "SerialNr": "1010000006",
      "OwnerName": "Schmidt Group",
      "OwnerDescription": "Total actuating Graphic Interface",
      "NextCheckDate": "2007-09-12T18:28:49.2321247+02:00",
      "MaintenanceDate": "2008-11-02T18:28:49.2321247+01:00",
      "AdminWarningDate": "2016-12-24T18:28:49.2321247+01:00",
      "ExpiryDate": "1998-11-13T18:28:49.2321247+01:00",
      "GraceDate": "1996-11-27T18:28:49.2321247+01:00",
      "ExtraFlags": 273,
      "ExtraInfo": "tempora",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "aspernatur",
      "DeploymentType": 266,
      "ProductType": "ducimus",
      "ProductDescription": "Organized solution-oriented software",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "repellat"
    },
    "Current": {
      "CompanyName": "Zemlak, Ondricka and Johnston",
      "SerialNr": "1010000006",
      "OwnerName": "Turner-Labadie",
      "OwnerDescription": "De-engineered methodical portal",
      "NextCheckDate": "2003-05-04T18:28:49.2331227+02:00",
      "MaintenanceDate": "2004-02-13T18:28:49.2331227+01:00",
      "AdminWarningDate": "1996-04-29T18:28:49.2331227+02:00",
      "ExpiryDate": "2010-05-12T18:28:49.2331227+02:00",
      "GraceDate": "2017-01-02T18:28:49.2331227+01:00",
      "ExtraFlags": 946,
      "ExtraInfo": "dolore",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "dolore",
      "DeploymentType": 293,
      "ProductType": "facilis",
      "ProductDescription": "Vision-oriented zero tolerance pricing structure",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "similique"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 725,
        "NumberOfLicensesFree": 340,
        "NumberOfLicensesAdded": 153,
        "NumberOfLicensesNewTotal": 161,
        "NumberOfLicensesNewFree": 884,
        "NumberOfLicensesTotal": 881
      }
    ],
    "AccumulatedNextCheckDate": "1995-12-19T18:28:49.2331227+01:00"
  },
  {
    "Reason": "",
    "CanBeActivated": false,
    "New": {
      "CompanyName": "Von Group",
      "SerialNr": "1010000006",
      "OwnerName": "Schmidt Group",
      "OwnerDescription": "Total actuating Graphic Interface",
      "NextCheckDate": "2007-09-12T18:28:49.2321247+02:00",
      "MaintenanceDate": "2008-11-02T18:28:49.2321247+01:00",
      "AdminWarningDate": "2016-12-24T18:28:49.2321247+01:00",
      "ExpiryDate": "1998-11-13T18:28:49.2321247+01:00",
      "GraceDate": "1996-11-27T18:28:49.2321247+01:00",
      "ExtraFlags": 273,
      "ExtraInfo": "tempora",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "aspernatur",
      "DeploymentType": 266,
      "ProductType": "ducimus",
      "ProductDescription": "Organized solution-oriented software",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "repellat"
    },
    "Current": {
      "CompanyName": "Zemlak, Ondricka and Johnston",
      "SerialNr": "1010000006",
      "OwnerName": "Turner-Labadie",
      "OwnerDescription": "De-engineered methodical portal",
      "NextCheckDate": "2003-05-04T18:28:49.2331227+02:00",
      "MaintenanceDate": "2004-02-13T18:28:49.2331227+01:00",
      "AdminWarningDate": "1996-04-29T18:28:49.2331227+02:00",
      "ExpiryDate": "2010-05-12T18:28:49.2331227+02:00",
      "GraceDate": "2017-01-02T18:28:49.2331227+01:00",
      "ExtraFlags": 946,
      "ExtraInfo": "dolore",
      "LicenseUrl": "http://www.example.com/",
      "LicenseVersion": "dolore",
      "DeploymentType": 293,
      "ProductType": "facilis",
      "ProductDescription": "Vision-oriented zero tolerance pricing structure",
      "ModuleLicenses": [
        {},
        {}
      ],
      "PublicKey": {},
      "Signature": "similique"
    },
    "ExtendedModuleLicenses": [
      {
        "New": {},
        "Current": {},
        "NumberOfLicensesInUse": 725,
        "NumberOfLicensesFree": 340,
        "NumberOfLicensesAdded": 153,
        "NumberOfLicensesNewTotal": 161,
        "NumberOfLicensesNewFree": 884,
        "NumberOfLicensesTotal": 881
      }
    ],
    "AccumulatedNextCheckDate": "1995-12-19T18:28:49.2331227+01:00"
  }
]
```