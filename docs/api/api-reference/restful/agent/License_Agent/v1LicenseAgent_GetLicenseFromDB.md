---
title: GetLicenseFromDB
id: v1LicenseAgent_GetLicenseFromDB
---

# GetLicenseFromDB

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Quigley-Auer"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "McLaughlin, Anderson and Crooks",
    "SerialNr": "1010000006",
    "OwnerName": "Roberts-Robel",
    "OwnerDescription": "Reverse-engineered 24 hour application",
    "NextCheckDate": "2007-04-28T14:58:04.3264629+02:00",
    "MaintenanceDate": "2019-09-12T14:58:04.3264629+02:00",
    "AdminWarningDate": "1999-10-04T14:58:04.3264629+02:00",
    "ExpiryDate": "2003-02-21T14:58:04.3264629+01:00",
    "GraceDate": "2019-07-05T14:58:04.3264629+02:00",
    "ExtraFlags": 75,
    "ExtraInfo": "quas",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "dolore",
    "DeploymentType": 55,
    "ProductType": "error",
    "ProductDescription": "Down-sized zero tolerance moratorium",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "libero"
  },
  "Current": {
    "CompanyName": "Witting, Luettgen and Cremin",
    "SerialNr": "1010000006",
    "OwnerName": "Hahn, Abshire and Schmeler",
    "OwnerDescription": "Phased multi-tasking analyzer",
    "NextCheckDate": "2014-09-18T14:58:04.3264629+02:00",
    "MaintenanceDate": "2011-08-25T14:58:04.3264629+02:00",
    "AdminWarningDate": "1995-06-20T14:58:04.3264629+02:00",
    "ExpiryDate": "1997-09-06T14:58:04.3264629+02:00",
    "GraceDate": "2010-06-08T14:58:04.3264629+02:00",
    "ExtraFlags": 349,
    "ExtraInfo": "qui",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "alias",
    "DeploymentType": 885,
    "ProductType": "aut",
    "ProductDescription": "Configurable optimal paradigm",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "doloremque"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 796,
      "NumberOfLicensesFree": 163,
      "NumberOfLicensesAdded": 924,
      "NumberOfLicensesNewTotal": 135,
      "NumberOfLicensesNewFree": 76,
      "NumberOfLicensesTotal": 758
    }
  ],
  "AccumulatedNextCheckDate": "2020-08-21T14:58:04.3274607+02:00"
}
```