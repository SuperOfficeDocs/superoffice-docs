---
title: POST Agents/License/AddLicenseFromFile
id: v1LicenseAgent_AddLicenseFromFile
---

# POST Agents/License/AddLicenseFromFile

```http
POST /api/v1/Agents/License/AddLicenseFromFile
```

Load and activate a new license from file/string if the new license is valid.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/AddLicenseFromFile?$select=name,department,category/id
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

FileContent 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FileContent | string |  |


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
POST /api/v1/Agents/License/AddLicenseFromFile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "FileContent": "et"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Lynch-Hartmann",
    "SerialNr": "1010000006",
    "OwnerName": "Auer Group",
    "OwnerDescription": "Function-based hybrid functionalities",
    "NextCheckDate": "2005-09-20T18:28:49.2461256+02:00",
    "MaintenanceDate": "2015-11-15T18:28:49.2461256+01:00",
    "AdminWarningDate": "1996-09-23T18:28:49.2461256+02:00",
    "ExpiryDate": "2012-08-02T18:28:49.2461256+02:00",
    "GraceDate": "2000-05-26T18:28:49.2461256+02:00",
    "ExtraFlags": 578,
    "ExtraInfo": "et",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "quia",
    "DeploymentType": 880,
    "ProductType": "molestias",
    "ProductDescription": "Synchronised attitude-oriented open system",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "maiores"
  },
  "Current": {
    "CompanyName": "Farrell Inc and Sons",
    "SerialNr": "1010000006",
    "OwnerName": "Schmitt, Halvorson and Dietrich",
    "OwnerDescription": "Inverse zero administration leverage",
    "NextCheckDate": "1995-12-08T18:28:49.2461256+01:00",
    "MaintenanceDate": "2003-10-07T18:28:49.2461256+02:00",
    "AdminWarningDate": "2016-10-10T18:28:49.2461256+02:00",
    "ExpiryDate": "2019-11-06T18:28:49.2461256+01:00",
    "GraceDate": "2004-04-08T18:28:49.2461256+02:00",
    "ExtraFlags": 969,
    "ExtraInfo": "odit",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "ut",
    "DeploymentType": 984,
    "ProductType": "quidem",
    "ProductDescription": "Extended scalable flexibility",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "porro"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 888,
      "NumberOfLicensesFree": 707,
      "NumberOfLicensesAdded": 228,
      "NumberOfLicensesNewTotal": 625,
      "NumberOfLicensesNewFree": 893,
      "NumberOfLicensesTotal": 749
    }
  ],
  "AccumulatedNextCheckDate": "2017-10-12T18:28:49.2461256+02:00"
}
```