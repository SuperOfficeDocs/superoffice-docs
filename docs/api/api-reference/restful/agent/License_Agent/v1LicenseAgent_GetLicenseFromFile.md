---
title: POST Agents/License/GetLicenseFromFile
id: v1LicenseAgent_GetLicenseFromFile
---

# POST Agents/License/GetLicenseFromFile

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
    "CompanyName": "Corwin-Gutmann",
    "SerialNr": "1010000006",
    "OwnerName": "King LLC",
    "OwnerDescription": "Multi-tiered 24 hour alliance",
    "NextCheckDate": "1999-07-19T16:48:29.7369242+02:00",
    "MaintenanceDate": "1997-09-22T16:48:29.7369242+02:00",
    "AdminWarningDate": "2002-03-17T16:48:29.7369242+01:00",
    "ExpiryDate": "2015-08-15T16:48:29.7369242+02:00",
    "GraceDate": "2019-01-24T16:48:29.7369242+01:00",
    "ExtraFlags": 49,
    "ExtraInfo": "ea",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "eaque",
    "DeploymentType": 858,
    "ProductType": "in",
    "ProductDescription": "Visionary disintermediate parallelism",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "qui"
  },
  "Current": {
    "CompanyName": "Reichert Inc and Sons",
    "SerialNr": "1010000006",
    "OwnerName": "Funk LLC",
    "OwnerDescription": "Networked bottom-line pricing structure",
    "NextCheckDate": "1994-12-10T16:48:29.7369242+01:00",
    "MaintenanceDate": "2009-04-11T16:48:29.7369242+02:00",
    "AdminWarningDate": "2019-03-01T16:48:29.7369242+01:00",
    "ExpiryDate": "2007-07-10T16:48:29.7369242+02:00",
    "GraceDate": "2010-03-23T16:48:29.7369242+01:00",
    "ExtraFlags": 398,
    "ExtraInfo": "est",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "fugit",
    "DeploymentType": 579,
    "ProductType": "ut",
    "ProductDescription": "User-centric uniform initiative",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "maxime"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 170,
      "NumberOfLicensesFree": 170,
      "NumberOfLicensesAdded": 166,
      "NumberOfLicensesNewTotal": 999,
      "NumberOfLicensesNewFree": 389,
      "NumberOfLicensesTotal": 880
    }
  ],
  "AccumulatedNextCheckDate": "2019-08-13T16:48:29.7369242+02:00"
}
```