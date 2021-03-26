---
title: POST Agents/License/GetLicenseFromLicenseServer
id: v1LicenseAgent_GetLicenseFromLicenseServer
---

# POST Agents/License/GetLicenseFromLicenseServer

```http
POST /api/v1/Agents/License/GetLicenseFromLicenseServer
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetLicenseFromLicenseServer?$select=name,department,category/id
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
POST /api/v1/Agents/License/GetLicenseFromLicenseServer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Quitzon Inc and Sons"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": true,
  "New": {
    "CompanyName": "Keeling-Jaskolski",
    "SerialNr": "1010000006",
    "OwnerName": "Dickinson LLC",
    "OwnerDescription": "Managed secondary task-force",
    "NextCheckDate": "2001-12-10T16:48:29.7299247+01:00",
    "MaintenanceDate": "2008-04-11T16:48:29.7299247+02:00",
    "AdminWarningDate": "2016-10-21T16:48:29.7299247+02:00",
    "ExpiryDate": "2012-06-26T16:48:29.7299247+02:00",
    "GraceDate": "2004-05-19T16:48:29.7299247+02:00",
    "ExtraFlags": 207,
    "ExtraInfo": "cum",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "sunt",
    "DeploymentType": 10,
    "ProductType": "quisquam",
    "ProductDescription": "Sharable dedicated workforce",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "maxime"
  },
  "Current": {
    "CompanyName": "Hodkiewicz, Rau and Kshlerin",
    "SerialNr": "1010000006",
    "OwnerName": "Sawayn, Corwin and Schaefer",
    "OwnerDescription": "Re-engineered grid-enabled website",
    "NextCheckDate": "2006-09-20T16:48:29.7309241+02:00",
    "MaintenanceDate": "2007-01-04T16:48:29.7309241+01:00",
    "AdminWarningDate": "2018-11-04T16:48:29.7309241+01:00",
    "ExpiryDate": "1994-07-12T16:48:29.7309241+02:00",
    "GraceDate": "2014-10-20T16:48:29.7309241+02:00",
    "ExtraFlags": 329,
    "ExtraInfo": "alias",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "quia",
    "DeploymentType": 809,
    "ProductType": "non",
    "ProductDescription": "Grass-roots well-modulated success",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "est"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 623,
      "NumberOfLicensesFree": 156,
      "NumberOfLicensesAdded": 184,
      "NumberOfLicensesNewTotal": 147,
      "NumberOfLicensesNewFree": 800,
      "NumberOfLicensesTotal": 432
    }
  ],
  "AccumulatedNextCheckDate": "2009-04-27T16:48:29.7309241+02:00"
}
```