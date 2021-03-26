---
title: POST Agents/Sale/ValidateSaleEntity
id: v1SaleAgent_ValidateSaleEntity
---

# POST Agents/Sale/ValidateSaleEntity

```http
POST /api/v1/Agents/Sale/ValidateSaleEntity
```

Check that entity is ready for saving, return error messages by field.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/ValidateSaleEntity?$select=name,department,category/id
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

SaleEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleEntity |  | Partial SaleEntity class associating the generated SaleEntity with an interface. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Agents/Sale/ValidateSaleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleEntity": {
    "Appointment": {},
    "Associate": {},
    "UpdatedBy": {},
    "CreatedBy": {},
    "Contact": {},
    "Project": {},
    "SaleText": "totam",
    "Person": {},
    "Currency": {},
    "Competitor": {},
    "Credited": {},
    "Rating": {},
    "Reason": {},
    "Source": {},
    "Status": "Lost",
    "Saledate": "1997-02-24T16:48:30.6149402+01:00",
    "Amount": 14482.214,
    "SaleId": 120,
    "Earning": 26817.638,
    "EarningPercent": 18001.696,
    "Heading": "est",
    "Number": "867852",
    "Probability": 693,
    "CreatedDate": "2007-02-16T16:48:30.6149402+01:00",
    "UpdatedDate": "2001-12-12T16:48:30.6149402+01:00",
    "Completed": "Completed",
    "ActiveLinks": 314,
    "Links": [
      {},
      {}
    ],
    "NextDueDate": "2003-05-12T16:48:30.6149402+02:00",
    "Postit": "praesentium",
    "SaleType": {},
    "ReasonSold": {},
    "ReasonStalled": {},
    "ReopenDate": "1995-09-01T16:48:30.6149402+02:00",
    "SaleStakeholders": [
      {},
      {}
    ],
    "ActiveErpLinks": 211,
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "1934422900"
    },
    "ExtraFields": {
      "ExtraFields1": "quam",
      "ExtraFields2": "harum"
    },
    "CustomFields": {
      "CustomFields1": "omnis",
      "CustomFields2": "et"
    },
    "PublishEventDate": "2020-11-22T16:48:30.6149402+01:00",
    "PublishTo": "1999-07-16T16:48:30.6149402+02:00",
    "PublishFrom": "2012-08-14T16:48:30.6149402+02:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "illo",
  "2": "tempore"
}
```