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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SaleEntity": {
    "Appointment": {},
    "Associate": {},
    "UpdatedBy": {},
    "CreatedBy": {},
    "Contact": {},
    "Project": {},
    "SaleText": "quis",
    "Person": {},
    "Currency": {},
    "Competitor": {},
    "Credited": {},
    "Rating": {},
    "Reason": {},
    "Source": {},
    "Status": "Lost",
    "Saledate": "2007-09-28T18:28:50.1714118+02:00",
    "Amount": 614.264,
    "SaleId": 373,
    "Earning": 17832.46,
    "EarningPercent": 24570.559999999998,
    "Heading": "dolorem",
    "Number": "680228",
    "Probability": 816,
    "CreatedDate": "1998-11-16T18:28:50.1714118+01:00",
    "UpdatedDate": "1999-10-18T18:28:50.1714118+02:00",
    "Completed": "Completed",
    "ActiveLinks": 403,
    "Links": [
      {},
      {}
    ],
    "NextDueDate": "2006-04-05T18:28:50.1714118+02:00",
    "Postit": "quidem",
    "SaleType": {},
    "ReasonSold": {},
    "ReasonStalled": {},
    "ReopenDate": "2009-05-27T18:28:50.1714118+02:00",
    "SaleStakeholders": [
      {},
      {}
    ],
    "ActiveErpLinks": 484,
    "UserDefinedFields": {
      "SuperOffice:1": "Dr. Burdette Goyette",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "sequi",
      "ExtraFields2": "vel"
    },
    "CustomFields": {
      "CustomFields1": "molestiae",
      "CustomFields2": "at"
    },
    "PublishEventDate": "2005-12-29T18:28:50.1724114+01:00",
    "PublishTo": "1999-08-18T18:28:50.1724114+02:00",
    "PublishFrom": "2004-10-30T18:28:50.1724114+02:00",
    "IsPublished": false,
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
  "1": "illum",
  "2": "dolor"
}
```