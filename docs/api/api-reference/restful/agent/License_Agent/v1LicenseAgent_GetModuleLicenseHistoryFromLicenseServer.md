---
title: POST Agents/License/GetModuleLicenseHistoryFromLicenseServer
id: v1LicenseAgent_GetModuleLicenseHistoryFromLicenseServer
---

# POST Agents/License/GetModuleLicenseHistoryFromLicenseServer

```http
POST /api/v1/Agents/License/GetModuleLicenseHistoryFromLicenseServer
```

Get details about a license from the license server.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetModuleLicenseHistoryFromLicenseServer?$select=name,department,category/id
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

LicenseInfo, ModuleLicense 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LicenseInfo |  |  |
| ModuleLicense |  |  |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
POST /api/v1/Agents/License/GetModuleLicenseHistoryFromLicenseServer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "LicenseInfo": {
    "Reason": "",
    "CanBeActivated": true,
    "New": {},
    "Current": {},
    "ExtendedModuleLicenses": [
      {},
      {}
    ],
    "AccumulatedNextCheckDate": "1999-01-24T18:28:49.2361225+01:00"
  },
  "ModuleLicense": {
    "New": {},
    "Current": {},
    "NumberOfLicensesInUse": 961,
    "NumberOfLicensesFree": 213,
    "NumberOfLicensesAdded": 295,
    "NumberOfLicensesNewTotal": 78,
    "NumberOfLicensesNewFree": 609,
    "NumberOfLicensesTotal": 284
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"voluptatibus"
```