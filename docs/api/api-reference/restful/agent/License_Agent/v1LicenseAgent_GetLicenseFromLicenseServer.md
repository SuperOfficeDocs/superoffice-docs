---
title: GetLicenseFromLicenseServer
id: v1LicenseAgent_GetLicenseFromLicenseServer
---

# GetLicenseFromLicenseServer

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "DuBuque, Zemlak and Wiegand"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Weissnat-Hahn",
    "SerialNr": "1010000006",
    "OwnerName": "Boyle Group",
    "OwnerDescription": "Right-sized static alliance",
    "NextCheckDate": "1995-10-30T14:58:04.3244317+01:00",
    "MaintenanceDate": "2004-12-22T14:58:04.3244317+01:00",
    "AdminWarningDate": "2011-01-09T14:58:04.3244317+01:00",
    "ExpiryDate": "1998-01-08T14:58:04.3244317+01:00",
    "GraceDate": "2007-01-27T14:58:04.3244317+01:00",
    "ExtraFlags": 468,
    "ExtraInfo": "occaecati",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "sunt",
    "DeploymentType": 982,
    "ProductType": "est",
    "ProductDescription": "Inverse discrete system engine",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "omnis"
  },
  "Current": {
    "CompanyName": "Dare, Murphy and Morar",
    "SerialNr": "1010000006",
    "OwnerName": "Zboncak Group",
    "OwnerDescription": "Advanced value-added intranet",
    "NextCheckDate": "2018-02-18T14:58:04.3244317+01:00",
    "MaintenanceDate": "1994-08-13T14:58:04.3244317+02:00",
    "AdminWarningDate": "2006-07-15T14:58:04.3244317+02:00",
    "ExpiryDate": "2018-08-07T14:58:04.3244317+02:00",
    "GraceDate": "2014-04-07T14:58:04.3244317+02:00",
    "ExtraFlags": 413,
    "ExtraInfo": "possimus",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "aliquid",
    "DeploymentType": 875,
    "ProductType": "tenetur",
    "ProductDescription": "Future-proofed transitional methodology",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "quisquam"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 858,
      "NumberOfLicensesFree": 532,
      "NumberOfLicensesAdded": 23,
      "NumberOfLicensesNewTotal": 340,
      "NumberOfLicensesNewFree": 678,
      "NumberOfLicensesTotal": 954
    }
  ],
  "AccumulatedNextCheckDate": "1995-08-07T14:58:04.3244317+02:00"
}
```