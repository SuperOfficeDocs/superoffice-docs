---
title: POST License
id: v1License_AddLicenseFromFile
---

# POST License

```http
POST /api/v1/License
```

Load and activate a new license from file/string if the new license is valid.








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `text/plain`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: fileContent  

Content of the license file as XML. 



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
POST /api/v1/License
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Yundt Inc and Sons",
    "SerialNr": "1010000006",
    "OwnerName": "Wolff Inc and Sons",
    "OwnerDescription": "Object-based dynamic migration",
    "NextCheckDate": "2016-11-05T18:25:51.3671178+01:00",
    "MaintenanceDate": "1996-12-26T18:25:51.3671178+01:00",
    "AdminWarningDate": "2010-12-25T18:25:51.3671178+01:00",
    "ExpiryDate": "2001-11-15T18:25:51.3671178+01:00",
    "GraceDate": "2013-01-30T18:25:51.3671178+01:00",
    "ExtraFlags": 63,
    "ExtraInfo": "ab",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "itaque",
    "DeploymentType": 185,
    "ProductType": "porro",
    "ProductDescription": "Realigned well-modulated internet solution",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "quaerat"
  },
  "Current": {
    "CompanyName": "Lindgren, Macejkovic and Botsford",
    "SerialNr": "1010000006",
    "OwnerName": "Hansen LLC",
    "OwnerDescription": "Advanced 6th generation function",
    "NextCheckDate": "1995-08-19T18:25:51.3671178+02:00",
    "MaintenanceDate": "2010-08-27T18:25:51.3671178+02:00",
    "AdminWarningDate": "2018-12-28T18:25:51.3671178+01:00",
    "ExpiryDate": "1997-07-20T18:25:51.3671178+02:00",
    "GraceDate": "2004-06-25T18:25:51.3671178+02:00",
    "ExtraFlags": 838,
    "ExtraInfo": "nostrum",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "impedit",
    "DeploymentType": 573,
    "ProductType": "ea",
    "ProductDescription": "Synchronised bifurcated utilisation",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "eveniet"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 424,
      "NumberOfLicensesFree": 273,
      "NumberOfLicensesAdded": 279,
      "NumberOfLicensesNewTotal": 654,
      "NumberOfLicensesNewFree": 25,
      "NumberOfLicensesTotal": 870
    }
  ],
  "AccumulatedNextCheckDate": "2000-02-07T18:25:51.3671178+01:00"
}
```