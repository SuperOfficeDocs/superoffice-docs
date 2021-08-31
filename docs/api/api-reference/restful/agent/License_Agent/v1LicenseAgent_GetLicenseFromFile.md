---
title: GetLicenseFromFile
id: v1LicenseAgent_GetLicenseFromFile
---

# GetLicenseFromFile

```http
POST /api/v1/Agents/License/GetLicenseFromFile
```

Load a new license from file







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetLicenseFromFile?$select=name,department,category/id
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
POST /api/v1/Agents/License/GetLicenseFromFile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FileContent": "ut"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Morissette-McCullough",
    "SerialNr": "1010000006",
    "OwnerName": "Volkman, Predovic and Stracke",
    "OwnerDescription": "Future-proofed optimizing benchmark",
    "NextCheckDate": "2013-06-03T14:58:04.3304599+02:00",
    "MaintenanceDate": "1996-09-21T14:58:04.3304599+02:00",
    "AdminWarningDate": "2015-10-28T14:58:04.3304599+01:00",
    "ExpiryDate": "2003-04-12T14:58:04.3304599+02:00",
    "GraceDate": "2007-12-13T14:58:04.3304599+01:00",
    "ExtraFlags": 147,
    "ExtraInfo": "deserunt",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "ratione",
    "DeploymentType": 325,
    "ProductType": "et",
    "ProductDescription": "Customer-focused attitude-oriented open system",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "est"
  },
  "Current": {
    "CompanyName": "Rath, Glover and Nienow",
    "SerialNr": "1010000006",
    "OwnerName": "Zemlak, Crona and Armstrong",
    "OwnerDescription": "User-centric stable concept",
    "NextCheckDate": "2007-10-28T14:58:04.3314622+01:00",
    "MaintenanceDate": "2017-02-20T14:58:04.3314622+01:00",
    "AdminWarningDate": "2017-03-15T14:58:04.3314622+01:00",
    "ExpiryDate": "2016-06-17T14:58:04.3314622+02:00",
    "GraceDate": "2006-01-22T14:58:04.3314622+01:00",
    "ExtraFlags": 84,
    "ExtraInfo": "pariatur",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "voluptate",
    "DeploymentType": 681,
    "ProductType": "minima",
    "ProductDescription": "Persevering bifurcated knowledge user",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "illum"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 455,
      "NumberOfLicensesFree": 863,
      "NumberOfLicensesAdded": 219,
      "NumberOfLicensesNewTotal": 880,
      "NumberOfLicensesNewFree": 175,
      "NumberOfLicensesTotal": 361
    }
  ],
  "AccumulatedNextCheckDate": "2020-08-09T14:58:04.3314622+02:00"
}
```