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
  "CanBeActivated": true,
  "New": {
    "CompanyName": "Olson, Huel and Leannon",
    "SerialNr": "1010000006",
    "OwnerName": "Green, Yost and Turcotte",
    "OwnerDescription": "Distributed tangible toolset",
    "NextCheckDate": "2017-03-30T09:40:59.9340519+02:00",
    "MaintenanceDate": "2000-03-25T09:40:59.9340519+01:00",
    "AdminWarningDate": "2013-09-03T09:40:59.9340519+02:00",
    "ExpiryDate": "2003-10-07T09:40:59.9340519+02:00",
    "GraceDate": "2020-10-11T09:40:59.9340519+02:00",
    "ExtraFlags": 698,
    "ExtraInfo": "odio",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "beatae",
    "DeploymentType": 731,
    "ProductType": "quis",
    "ProductDescription": "Extended intangible architecture",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "dolores"
  },
  "Current": {
    "CompanyName": "Bergnaum, Jerde and Koch",
    "SerialNr": "1010000006",
    "OwnerName": "Willms Group",
    "OwnerDescription": "Innovative optimizing approach",
    "NextCheckDate": "2020-12-25T09:40:59.9340519+01:00",
    "MaintenanceDate": "2009-09-20T09:40:59.9340519+02:00",
    "AdminWarningDate": "1998-04-06T09:40:59.9340519+02:00",
    "ExpiryDate": "1999-01-15T09:40:59.9340519+01:00",
    "GraceDate": "2007-01-07T09:40:59.9340519+01:00",
    "ExtraFlags": 141,
    "ExtraInfo": "ex",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "voluptatum",
    "DeploymentType": 325,
    "ProductType": "quia",
    "ProductDescription": "Profit-focused reciprocal extranet",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "vel"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 24,
      "NumberOfLicensesFree": 247,
      "NumberOfLicensesAdded": 202,
      "NumberOfLicensesNewTotal": 206,
      "NumberOfLicensesNewFree": 91,
      "NumberOfLicensesTotal": 770
    }
  ],
  "AccumulatedNextCheckDate": "2011-09-29T09:40:59.9340519+02:00"
}
```