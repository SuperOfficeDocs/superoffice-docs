---
title: GET Archive/{archiveProviderName}/$metadata
uid: v1Archive_GetArchiveMetadata
generated: true
content_type: reference
---

# GET Archive/{archiveProviderName}/$metadata

```http
GET /api/v1/Archive/{archiveProviderName}/$metadata
```

OData access to archive an provider


```

GET api/archives/contact/$metadata

```





| Path Part | Type | Description |
|-----------|------|-------------|
| archiveProviderName | string | Archive Provider name: FindContact, Person, Product, etc. **Required** |



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
GET /api/v1/Archive/{archiveProviderName}/$metadata
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
      "PrimaryKey": 1133,
      "EntityName": "sale",
      "saleId": 1133,
      "contactId": 1752,
      "name": "Harber, Runolfsdottir and Rutherford"
    },
    {
      "PrimaryKey": 1597,
      "EntityName": "sale",
      "saleId": 1597,
      "contactId": 9686,
      "name": "Becker, Feil and Harber"
    }
  ]
}
```