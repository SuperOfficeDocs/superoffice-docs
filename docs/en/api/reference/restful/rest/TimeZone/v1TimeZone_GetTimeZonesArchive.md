---
title: GET TimeZone
uid: v1TimeZone_GetTimeZonesArchive
---

# GET TimeZone

```http
GET /api/v1/TimeZone
```

List of timezones


Use with SO-TIMEZONE header to specify times.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |   |
| $filter | string |   |
| $orderBy | string |   |
| $entities | string |   |
| $top | int32 |   |
| $skip | int32 |   |
| $mode | string |   |
| $options | string |   |
| $context | string |   |
| $format | string |   |

```http
GET /api/v1/TimeZone?$select=name,department,category/id
GET /api/v1/TimeZone?$filter=name begins 'S'
GET /api/v1/TimeZone?$orderBy=name asc
GET /api/v1/TimeZone?$entities=corporis
GET /api/v1/TimeZone?$top=793
GET /api/v1/TimeZone?$skip=299
GET /api/v1/TimeZone?$mode=FULL
GET /api/v1/TimeZone?$options=GrandTotal=true
GET /api/v1/TimeZone?$context=quas
GET /api/v1/TimeZone?$format=JSON
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ODataSlimResponse

| Property Name | Type |  Description |
|----------------|------|--------------|
| odata.metadata | string |  |
| odata.nextLink | string |  |
| value | array |  |

## Sample request

```http!
GET /api/v1/TimeZone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "non",
  "value": [
    {
      "PrimaryKey": 9889,
      "EntityName": "sale",
      "saleId": 9889,
      "contactId": 3591,
      "name": "Brakus LLC"
    },
    {
      "PrimaryKey": 9418,
      "EntityName": "sale",
      "saleId": 9418,
      "contactId": 3561,
      "name": "Fahey, Rowe and Vandervort"
    }
  ]
}
```