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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Rice Inc and Sons"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "seize robust solutions",
  "CanBeActivated": true,
  "New": {
    "CompanyName": "Gerhold Group",
    "SerialNr": "1010000006",
    "OwnerName": "Veum Inc and Sons",
    "OwnerDescription": "Down-sized maximized extranet",
    "NextCheckDate": "2010-07-21T18:28:49.2351232+02:00",
    "MaintenanceDate": "2007-01-14T18:28:49.2351232+01:00",
    "AdminWarningDate": "2015-10-19T18:28:49.2351232+02:00",
    "ExpiryDate": "2017-04-12T18:28:49.2351232+02:00",
    "GraceDate": "2021-04-09T18:28:49.2351232+02:00",
    "ExtraFlags": 773,
    "ExtraInfo": "debitis",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "eum",
    "DeploymentType": 139,
    "ProductType": "molestias",
    "ProductDescription": "Cross-group incremental customer loyalty",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "alias"
  },
  "Current": {
    "CompanyName": "Keeling-Kreiger",
    "SerialNr": "1010000006",
    "OwnerName": "Harris-Ward",
    "OwnerDescription": "Compatible full-range infrastructure",
    "NextCheckDate": "2009-07-23T18:28:49.2351232+02:00",
    "MaintenanceDate": "2021-05-16T18:28:49.2351232+02:00",
    "AdminWarningDate": "1996-03-20T18:28:49.2351232+01:00",
    "ExpiryDate": "2010-11-12T18:28:49.2351232+01:00",
    "GraceDate": "1998-06-13T18:28:49.2351232+02:00",
    "ExtraFlags": 79,
    "ExtraInfo": "fuga",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "architecto",
    "DeploymentType": 237,
    "ProductType": "quaerat",
    "ProductDescription": "Switchable contextually-based portal",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "sequi"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 437,
      "NumberOfLicensesFree": 646,
      "NumberOfLicensesAdded": 144,
      "NumberOfLicensesNewTotal": 243,
      "NumberOfLicensesNewFree": 908,
      "NumberOfLicensesTotal": 134
    }
  ],
  "AccumulatedNextCheckDate": "2013-02-14T18:28:49.2361225+01:00"
}
```