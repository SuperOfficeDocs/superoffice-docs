---
title: POST Agents/License/GetUserAndInstallationLicenceStatus
uid: v1LicenseAgent_GetUserAndInstallationLicenceStatus
generated: true
content_type: reference
---

# POST Agents/License/GetUserAndInstallationLicenceStatus

```http
POST /api/v1/Agents/License/GetUserAndInstallationLicenceStatus
```

Get status values for user licenses and installation license that can be used for feedback to the user.


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetUserAndInstallationLicenceStatus?$select=name,department,category/id
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

AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: UserAndInstallationLicenceStatus

| Property Name | Type |  Description |
|----------------|------|--------------|
| AdminWarningDate | date-time | Installations license admin warning date |
| ExpiryDate | date-time | Installations license expiry date |
| GraceDate | date-time | Installations license grace date |
| CompanyName | string | Database company name |
| SerialNr | string | Database serial number |
| UserLicenses | array | The users module licenses names |

## Sample request

```http!
POST /api/v1/Agents/License/GetUserAndInstallationLicenceStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 482
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AdminWarningDate": "2004-08-01T02:30:47.366331+02:00",
  "ExpiryDate": "2021-02-23T02:30:47.366331+01:00",
  "GraceDate": "2016-06-09T02:30:47.366331+02:00",
  "CompanyName": "Waelchi Inc and Sons",
  "SerialNr": "1010000006",
  "UserLicenses": [
    "voluptatibus",
    "pariatur"
  ]
}
```