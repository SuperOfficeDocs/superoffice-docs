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
    "CompanyName": "King Inc and Sons",
    "SerialNr": "1010000006",
    "OwnerName": "Runolfsson LLC",
    "OwnerDescription": "Organized content-based throughput",
    "NextCheckDate": "2005-10-15T18:25:51.368118+02:00",
    "MaintenanceDate": "2021-06-29T18:25:51.368118+02:00",
    "AdminWarningDate": "2005-08-04T18:25:51.368118+02:00",
    "ExpiryDate": "2019-06-26T18:25:51.368118+02:00",
    "GraceDate": "2020-07-17T18:25:51.368118+02:00",
    "ExtraFlags": 47,
    "ExtraInfo": "alias",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "inventore",
    "DeploymentType": 438,
    "ProductType": "voluptate",
    "ProductDescription": "User-friendly tertiary standardization",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "omnis"
  },
  "Current": {
    "CompanyName": "Kozey Group",
    "SerialNr": "1010000006",
    "OwnerName": "Lockman, Auer and Altenwerth",
    "OwnerDescription": "Mandatory directional help-desk",
    "NextCheckDate": "2019-12-07T18:25:51.3691181+01:00",
    "MaintenanceDate": "2021-08-21T18:25:51.3691181+02:00",
    "AdminWarningDate": "2001-02-15T18:25:51.3691181+01:00",
    "ExpiryDate": "2019-09-23T18:25:51.3691181+02:00",
    "GraceDate": "2011-05-20T18:25:51.3691181+02:00",
    "ExtraFlags": 419,
    "ExtraInfo": "id",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "non",
    "DeploymentType": 666,
    "ProductType": "repudiandae",
    "ProductDescription": "Robust reciprocal internet solution",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "ad"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 706,
      "NumberOfLicensesFree": 502,
      "NumberOfLicensesAdded": 271,
      "NumberOfLicensesNewTotal": 371,
      "NumberOfLicensesNewFree": 902,
      "NumberOfLicensesTotal": 873
    }
  ],
  "AccumulatedNextCheckDate": "2015-01-30T18:25:51.3691181+01:00"
}
```