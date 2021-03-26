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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Flatley-Lueilwitz",
    "SerialNr": "1010000006",
    "OwnerName": "Ritchie LLC",
    "OwnerDescription": "Phased attitude-oriented alliance",
    "NextCheckDate": "2000-08-05T09:40:59.9330649+02:00",
    "MaintenanceDate": "2011-05-12T09:40:59.9330649+02:00",
    "AdminWarningDate": "1999-08-27T09:40:59.9330649+02:00",
    "ExpiryDate": "2000-11-16T09:40:59.9330649+01:00",
    "GraceDate": "2013-04-18T09:40:59.9330649+02:00",
    "ExtraFlags": 647,
    "ExtraInfo": "soluta",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "corrupti",
    "DeploymentType": 122,
    "ProductType": "est",
    "ProductDescription": "Team-oriented transitional monitoring",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "nihil"
  },
  "Current": {
    "CompanyName": "Yundt Group",
    "SerialNr": "1010000006",
    "OwnerName": "Schiller Group",
    "OwnerDescription": "Enhanced stable hierarchy",
    "NextCheckDate": "2009-02-10T09:40:59.9330649+01:00",
    "MaintenanceDate": "2009-07-02T09:40:59.9330649+02:00",
    "AdminWarningDate": "2016-10-07T09:40:59.9330649+02:00",
    "ExpiryDate": "2003-01-30T09:40:59.9330649+01:00",
    "GraceDate": "1997-12-08T09:40:59.9330649+01:00",
    "ExtraFlags": 942,
    "ExtraInfo": "delectus",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "voluptatum",
    "DeploymentType": 169,
    "ProductType": "quia",
    "ProductDescription": "Polarised exuding portal",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "unde"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 839,
      "NumberOfLicensesFree": 631,
      "NumberOfLicensesAdded": 365,
      "NumberOfLicensesNewTotal": 648,
      "NumberOfLicensesNewFree": 461,
      "NumberOfLicensesTotal": 187
    }
  ],
  "AccumulatedNextCheckDate": "1995-11-23T09:40:59.9330649+01:00"
}
```