---
title: ValidateSaleEntity
id: v1SaleAgent_ValidateSaleEntity
---

# ValidateSaleEntity

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
    "SaleText": "veritatis",
    "Person": {},
    "Currency": {},
    "Competitor": {},
    "Credited": {},
    "Rating": {},
    "Reason": {},
    "Source": {},
    "Status": "Lost",
    "Saledate": "2000-09-25T14:58:05.1816228+02:00",
    "Amount": 1761.308,
    "SaleId": 286,
    "Earning": 16513.046,
    "EarningPercent": 28547.606,
    "Heading": "omnis",
    "Number": "854550",
    "Probability": 712,
    "CreatedDate": "1994-10-27T14:58:05.1816228+02:00",
    "UpdatedDate": "2002-10-06T14:58:05.1816228+02:00",
    "Completed": "Completed",
    "ActiveLinks": 10,
    "Links": [
      {},
      {}
    ],
    "NextDueDate": "2000-12-04T14:58:05.1816228+01:00",
    "Postit": "accusamus",
    "SaleType": {},
    "ReasonSold": {},
    "ReasonStalled": {},
    "ReopenDate": "1996-11-03T14:58:05.1816228+01:00",
    "SaleStakeholders": [
      {},
      {}
    ],
    "ActiveErpLinks": 37,
    "UserDefinedFields": {
      "SuperOffice:1": "Boris Swaniawski",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "rerum",
      "ExtraFields2": "vel"
    },
    "CustomFields": {
      "CustomFields1": "voluptatem",
      "CustomFields2": "qui"
    },
    "PublishEventDate": "2013-12-21T14:58:05.1816228+01:00",
    "PublishTo": "2020-08-08T14:58:05.1816228+02:00",
    "PublishFrom": "2011-01-14T14:58:05.1816228+01:00",
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
  "1": "voluptatem",
  "2": "id"
}
```