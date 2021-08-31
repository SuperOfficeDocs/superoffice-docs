---
title: AddLicenseFromFile
id: v1LicenseAgent_AddLicenseFromFile
---

# AddLicenseFromFile

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
  "FileContent": "vel"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": true,
  "New": {
    "CompanyName": "Ritchie, Reinger and Rice",
    "SerialNr": "1010000006",
    "OwnerName": "Corkery LLC",
    "OwnerDescription": "Triple-buffered multi-tasking algorithm",
    "NextCheckDate": "1997-08-21T14:58:04.3354599+02:00",
    "MaintenanceDate": "2006-05-04T14:58:04.3354599+02:00",
    "AdminWarningDate": "2003-02-15T14:58:04.3354599+01:00",
    "ExpiryDate": "2005-01-16T14:58:04.3354599+01:00",
    "GraceDate": "2008-02-27T14:58:04.3354599+01:00",
    "ExtraFlags": 430,
    "ExtraInfo": "rerum",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "est",
    "DeploymentType": 159,
    "ProductType": "doloremque",
    "ProductDescription": "Multi-tiered system-worthy capability",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "reprehenderit"
  },
  "Current": {
    "CompanyName": "Wintheiser-Muller",
    "SerialNr": "1010000006",
    "OwnerName": "Feeney-Friesen",
    "OwnerDescription": "Public-key 24/7 help-desk",
    "NextCheckDate": "1994-12-31T14:58:04.3354599+01:00",
    "MaintenanceDate": "2005-06-30T14:58:04.3354599+02:00",
    "AdminWarningDate": "1994-06-07T14:58:04.3354599+02:00",
    "ExpiryDate": "2016-09-21T14:58:04.3354599+02:00",
    "GraceDate": "2003-10-14T14:58:04.3354599+02:00",
    "ExtraFlags": 113,
    "ExtraInfo": "ducimus",
    "LicenseUrl": "http://www.example.com/",
    "LicenseVersion": "quia",
    "DeploymentType": 254,
    "ProductType": "esse",
    "ProductDescription": "Compatible human-resource budgetary management",
    "ModuleLicenses": [
      {},
      {}
    ],
    "PublicKey": {},
    "Signature": "molestiae"
  },
  "ExtendedModuleLicenses": [
    {
      "New": {},
      "Current": {},
      "NumberOfLicensesInUse": 134,
      "NumberOfLicensesFree": 711,
      "NumberOfLicensesAdded": 244,
      "NumberOfLicensesNewTotal": 860,
      "NumberOfLicensesNewFree": 952,
      "NumberOfLicensesTotal": 918
    }
  ],
  "AccumulatedNextCheckDate": "2014-11-22T14:58:04.3354599+01:00"
}
```