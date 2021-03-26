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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FileContent": "ducimus"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": true,
  "New": {
    "CompanyName": "Fahey, Ankunding and Botsford",
    "SerialNr": "1010000006",
    "OwnerName": "Schimmel-O'Keefe",
    "OwnerDescription": "Down-sized impactful leverage",
    "NextCheckDate": "2006-09-16T16:48:29.7409242+02:00",
    "MaintenanceDate": "2013-06-21T16:48:29.7409242+02:00",
    "AdminWarningDate": "2007-10-12T16:48:29.7409242+02:00",
    "ExpiryDate": "1999-11-29T16:48:29.7409242+01:00",
    "GraceDate": "2015-07-14T16:48:29.7409242+02:00",
    "ExtraFlags": 814,
    "ExtraInfo": "consectetur",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "laudantium",
    "DeploymentType": 338,
    "ProductType": "iusto",
    "ProductDescription": "Progressive client-server Graphic Interface",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "dolor"
  },
  "Current": {
    "CompanyName": "McGlynn, Grady and O'Connell",
    "SerialNr": "1010000006",
    "OwnerName": "Predovic Inc and Sons",
    "OwnerDescription": "Organized background toolset",
    "NextCheckDate": "2007-03-18T16:48:29.7419313+01:00",
    "MaintenanceDate": "2006-05-12T16:48:29.7419313+02:00",
    "AdminWarningDate": "2004-06-19T16:48:29.7419313+02:00",
    "ExpiryDate": "2009-12-01T16:48:29.7419313+01:00",
    "GraceDate": "2020-07-29T16:48:29.7419313+02:00",
    "ExtraFlags": 578,
    "ExtraInfo": "nostrum",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "iste",
    "DeploymentType": 320,
    "ProductType": "qui",
    "ProductDescription": "Enhanced bandwidth-monitored time-frame",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "qui"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 792,
      "NumberOfLicensesFree": 343,
      "NumberOfLicensesAdded": 912,
      "NumberOfLicensesNewTotal": 30,
      "NumberOfLicensesNewFree": 250,
      "NumberOfLicensesTotal": 477
    }
  ],
  "AccumulatedNextCheckDate": "2012-12-07T16:48:29.7419313+01:00"
}
```