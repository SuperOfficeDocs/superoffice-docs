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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Simonis, Bode and Quitzon",
    "SerialNr": "1010000006",
    "OwnerName": "Gusikowski-Kovacek",
    "OwnerDescription": "Object-based regional firmware",
    "NextCheckDate": "2016-08-31T15:05:43.0056631+02:00",
    "MaintenanceDate": "2005-05-11T15:05:43.0056631+02:00",
    "AdminWarningDate": "2018-05-20T15:05:43.0056631+02:00",
    "ExpiryDate": "2018-01-01T15:05:43.0056631+01:00",
    "GraceDate": "2015-08-25T15:05:43.0056631+02:00",
    "ExtraFlags": 442,
    "ExtraInfo": "odio",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "et",
    "DeploymentType": 128,
    "ProductType": "porro",
    "ProductDescription": "Reactive needs-based hierarchy",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "at"
  },
  "Current": {
    "CompanyName": "Schaden Group",
    "SerialNr": "1010000006",
    "OwnerName": "Hermiston-Walker",
    "OwnerDescription": "Configurable leading edge intranet",
    "NextCheckDate": "1996-07-22T15:05:43.0056631+02:00",
    "MaintenanceDate": "1995-03-28T15:05:43.0056631+02:00",
    "AdminWarningDate": "2014-06-16T15:05:43.0056631+02:00",
    "ExpiryDate": "2010-07-29T15:05:43.0056631+02:00",
    "GraceDate": "1997-02-07T15:05:43.0056631+01:00",
    "ExtraFlags": 660,
    "ExtraInfo": "unde",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "quia",
    "DeploymentType": 184,
    "ProductType": "ullam",
    "ProductDescription": "Focused needs-based challenge",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "at"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 524,
      "NumberOfLicensesFree": 115,
      "NumberOfLicensesAdded": 372,
      "NumberOfLicensesNewTotal": 23,
      "NumberOfLicensesNewFree": 184,
      "NumberOfLicensesTotal": 855
    }
  ],
  "AccumulatedNextCheckDate": "2004-09-27T15:05:43.0056631+02:00"
}
```