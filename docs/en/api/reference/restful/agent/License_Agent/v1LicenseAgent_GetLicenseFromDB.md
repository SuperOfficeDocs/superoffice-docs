---
title: POST Agents/License/GetLicenseFromDB
uid: v1LicenseAgent_GetLicenseFromDB
generated: true
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
| OwnerName | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TimeZoneData

| Property Name | Type |  Description |
|----------------|------|--------------|
| Reason | string |  |
| CanBeActivated | bool |  |
| New | TimeZoneData |  |
| Current | TimeZoneData |  |
| ExtendedModuleLicenses | array |  |
| AccumulatedNextCheckDate | date-time |  |

## Sample request

```http!
POST /api/v1/Agents/License/GetLicenseFromDB
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OwnerName": "Brown, Bogisich and Dibbert"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Reason": "",
  "CanBeActivated": false,
  "New": null,
  "Current": null,
  "ExtendedModuleLicenses": [
    {
      "New": null,
      "Current": null,
      "NumberOfLicensesInUse": 56,
      "NumberOfLicensesFree": 709,
      "NumberOfLicensesAdded": 514,
      "NumberOfLicensesNewTotal": 518,
      "NumberOfLicensesNewFree": 594,
      "NumberOfLicensesTotal": 524
    }
  ],
  "AccumulatedNextCheckDate": "1997-12-26T13:38:13.6396102+01:00"
}
```