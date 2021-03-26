---
title: POST Agents/License/GetLicenseFromDB
id: v1LicenseAgent_GetLicenseFromDB
---

# POST Agents/License/GetLicenseFromDB

```http
POST /api/v1/Agents/License/GetLicenseFromDB
```

Get license, with usage, as it is stored in the database for one particular module owner.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetLicenseFromDB?$select=name,department,category/id
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
POST /api/v1/Agents/License/GetLicenseFromDB
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Koss LLC"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Erdman Group",
    "SerialNr": "1010000006",
    "OwnerName": "Gulgowski, Kuhic and Ankunding",
    "OwnerDescription": "Phased maximized open architecture",
    "NextCheckDate": "2002-07-30T16:48:29.7329238+02:00",
    "MaintenanceDate": "2005-04-15T16:48:29.7329238+02:00",
    "AdminWarningDate": "2020-10-19T16:48:29.7329238+02:00",
    "ExpiryDate": "1999-06-17T16:48:29.7329238+02:00",
    "GraceDate": "2004-09-01T16:48:29.7329238+02:00",
    "ExtraFlags": 543,
    "ExtraInfo": "blanditiis",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "pariatur",
    "DeploymentType": 120,
    "ProductType": "qui",
    "ProductDescription": "Operative maximized workforce",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "provident"
  },
  "Current": {
    "CompanyName": "Hermann-Hickle",
    "SerialNr": "1010000006",
    "OwnerName": "Hayes, Moore and O'Kon",
    "OwnerDescription": "Decentralized scalable info-mediaries",
    "NextCheckDate": "2020-05-06T16:48:29.733924+02:00",
    "MaintenanceDate": "1997-06-04T16:48:29.733924+02:00",
    "AdminWarningDate": "1998-03-19T16:48:29.733924+01:00",
    "ExpiryDate": "2015-11-12T16:48:29.733924+01:00",
    "GraceDate": "2005-05-02T16:48:29.733924+02:00",
    "ExtraFlags": 677,
    "ExtraInfo": "facilis",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "aut",
    "DeploymentType": 262,
    "ProductType": "aut",
    "ProductDescription": "Open-architected multimedia framework",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "id"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 824,
      "NumberOfLicensesFree": 441,
      "NumberOfLicensesAdded": 204,
      "NumberOfLicensesNewTotal": 304,
      "NumberOfLicensesNewFree": 85,
      "NumberOfLicensesTotal": 482
    }
  ],
  "AccumulatedNextCheckDate": "2016-05-20T16:48:29.733924+02:00"
}
```