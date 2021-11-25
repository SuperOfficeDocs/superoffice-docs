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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "FileContent": "cumque"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": {
    "CompanyName": "Jerde Group",
    "SerialNr": "1010000006",
    "OwnerName": "Rolfson, Rutherford and Lindgren",
    "OwnerDescription": "Synchronised non-volatile firmware",
    "NextCheckDate": "2001-04-07T18:28:49.2421182+02:00",
    "MaintenanceDate": "2013-10-30T18:28:49.2421182+01:00",
    "AdminWarningDate": "2016-08-18T18:28:49.2421182+02:00",
    "ExpiryDate": "2007-02-25T18:28:49.2421182+01:00",
    "GraceDate": "2020-04-15T18:28:49.2421182+02:00",
    "ExtraFlags": 488,
    "ExtraInfo": "minus",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "itaque",
    "DeploymentType": 621,
    "ProductType": "tenetur",
    "ProductDescription": "Expanded national service-desk",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "error"
  },
  "Current": {
    "CompanyName": "Shields LLC",
    "SerialNr": "1010000006",
    "OwnerName": "Lakin, Littel and Weimann",
    "OwnerDescription": "Upgradable 4th generation instruction set",
    "NextCheckDate": "2002-11-27T18:28:49.2421182+01:00",
    "MaintenanceDate": "2008-06-01T18:28:49.2421182+02:00",
    "AdminWarningDate": "2004-02-07T18:28:49.2421182+01:00",
    "ExpiryDate": "2018-12-29T18:28:49.2421182+01:00",
    "GraceDate": "2016-05-10T18:28:49.2421182+02:00",
    "ExtraFlags": 447,
    "ExtraInfo": "rerum",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "dignissimos",
    "DeploymentType": 756,
    "ProductType": "excepturi",
    "ProductDescription": "Monitored fault-tolerant hierarchy",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "et"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 461,
      "NumberOfLicensesFree": 624,
      "NumberOfLicensesAdded": 242,
      "NumberOfLicensesNewTotal": 923,
      "NumberOfLicensesNewFree": 151,
      "NumberOfLicensesTotal": 982
    }
  ],
  "AccumulatedNextCheckDate": "2006-10-11T18:28:49.2431188+02:00"
}
```