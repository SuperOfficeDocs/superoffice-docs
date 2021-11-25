---
title: POST Agents/Sale/UpdateSaleStakeholders
id: v1SaleAgent_UpdateSaleStakeholders
---

# POST Agents/Sale/UpdateSaleStakeholders

```http
POST /api/v1/Agents/Sale/UpdateSaleStakeholders
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/UpdateSaleStakeholders?$select=name,department,category/id
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

Stakeholders 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Stakeholders | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | string | Stakeholder role name |
| Comment | string | Optional comment text |
| StakeholderRoleId | int32 | Stakeholde role list id - Primary key |
| CountryId | int32 | Country id - primary key |
| PersonId | int32 | Person id - Primary key |
| EmailDescription | string | E-mail description |
| EmailId | int32 | E-mail address id - Primary key |
| EmailAddress | string | E-mail address |
| PhoneId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactId | int32 | Contact ID of person or contact who is the sale stakeholder |
| SaleId | int32 | Parent sale |
| Mrmrs | string | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| SaleStakeholderId | int32 | Primary key |
| Rank | int32 | Rank in list of stakeholders |
| Phone | string | Phone number |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/UpdateSaleStakeholders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Stakeholders": [
    {
      "StakeholderRoleName": "Mayer, Gerlach and Reynolds",
      "Comment": "amet",
      "StakeholderRoleId": 28,
      "CountryId": 304,
      "PersonId": 235,
      "EmailDescription": "tom_hermiston@sipes.biz",
      "EmailId": 252,
      "EmailAddress": "stewart@hayes.co.uk",
      "PhoneId": 1001,
      "ContactName": "Gislason, Abernathy and Friesen",
      "ContactId": 353,
      "SaleId": 912,
      "Mrmrs": "veniam",
      "Firstname": "Ilene",
      "MiddleName": "Weimann, Kunde and DuBuque",
      "Lastname": "Ullrich",
      "SaleStakeholderId": 141,
      "Rank": 598,
      "Phone": "1-781-628-6808"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "StakeholderRoleName": "Konopelski LLC",
    "Comment": "sed",
    "StakeholderRoleId": 831,
    "CountryId": 106,
    "PersonId": 656,
    "EmailDescription": "sidney_walsh@hand.us",
    "EmailId": 325,
    "EmailAddress": "brock@haagbalistreri.info",
    "PhoneId": 663,
    "ContactName": "Hagenes, McDermott and Hermann",
    "ContactId": 393,
    "SaleId": 166,
    "Mrmrs": "nam",
    "Firstname": "Marlene",
    "MiddleName": "Doyle-Kunde",
    "Lastname": "Renner",
    "SaleStakeholderId": 635,
    "Rank": 2,
    "Phone": "(320)633-4802",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 27
      }
    }
  }
]
```