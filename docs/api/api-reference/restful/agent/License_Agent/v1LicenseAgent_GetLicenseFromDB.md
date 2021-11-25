---
title: POST Agents/License/GetLicenseFromDB
id: v1LicenseAgent_GetLicenseFromDB
---

# POST Agents/License/GetLicenseFromDB

```http
POST /api/v1/Agents/License/GetLicenseFromDB
```

Get license, with usage, as it is stored in the database for one particular module owner.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetLicenseFromDB?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

OwnerName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerName | string |  |


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
POST /api/v1/Agents/License/GetLicenseFromDB
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Treutel, Rodriguez and Thiel"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": true,
  "New": {
    "CompanyName": "Gaylord LLC",
    "SerialNr": "1010000006",
    "OwnerName": "Franecki LLC",
    "OwnerDescription": "Mandatory system-worthy architecture",
    "NextCheckDate": "2020-10-08T18:28:49.2371222+02:00",
    "MaintenanceDate": "2021-05-18T18:28:49.2371222+02:00",
    "AdminWarningDate": "2020-11-08T18:28:49.2371222+01:00",
    "ExpiryDate": "1995-01-30T18:28:49.2371222+01:00",
    "GraceDate": "2004-03-06T18:28:49.2371222+01:00",
    "ExtraFlags": 483,
    "ExtraInfo": "laudantium",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "aperiam",
    "DeploymentType": 760,
    "ProductType": "in",
    "ProductDescription": "Exclusive incremental moratorium",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "sequi"
  },
  "Current": {
    "CompanyName": "Jaskolski-Mills",
    "SerialNr": "1010000006",
    "OwnerName": "Lubowitz Group",
    "OwnerDescription": "Front-line national hierarchy",
    "NextCheckDate": "2018-05-09T18:28:49.2371222+02:00",
    "MaintenanceDate": "2009-01-31T18:28:49.2371222+01:00",
    "AdminWarningDate": "2011-10-10T18:28:49.2371222+02:00",
    "ExpiryDate": "2011-10-03T18:28:49.2371222+02:00",
    "GraceDate": "2011-11-08T18:28:49.2371222+01:00",
    "ExtraFlags": 368,
    "ExtraInfo": "quia",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "aspernatur",
    "DeploymentType": 814,
    "ProductType": "rem",
    "ProductDescription": "Phased homogeneous infrastructure",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "veniam"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 347,
      "NumberOfLicensesFree": 450,
      "NumberOfLicensesAdded": 999,
      "NumberOfLicensesNewTotal": 953,
      "NumberOfLicensesNewFree": 481,
      "NumberOfLicensesTotal": 386
    }
  ],
  "AccumulatedNextCheckDate": "2016-12-10T18:28:49.2371222+01:00"
}
```