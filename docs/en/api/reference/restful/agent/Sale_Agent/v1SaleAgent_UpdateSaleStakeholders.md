---
title: POST Agents/Sale/UpdateSaleStakeholders
uid: v1SaleAgent_UpdateSaleStakeholders
generated: true
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
| Stakeholders | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Sale/UpdateSaleStakeholders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Stakeholders": [
    {
      "StakeholderRoleName": "Grady, Tremblay and Yundt",
      "Comment": "nemo",
      "StakeholderRoleId": 279,
      "CountryId": 745,
      "PersonId": 808,
      "EmailDescription": "oral@keelingjones.ca",
      "EmailId": 922,
      "EmailAddress": "quinton.dooley@gusikowskimayert.ca",
      "PhoneId": 111,
      "ContactName": "Hane, Botsford and Braun",
      "ContactId": 393,
      "SaleId": 324,
      "Mrmrs": "tempora",
      "Firstname": "Zaria",
      "MiddleName": "McClure, Conn and Senger",
      "Lastname": "Mueller",
      "SaleStakeholderId": 911,
      "Rank": 349,
      "Phone": "1-873-649-4202 x0363"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "StakeholderRoleName": "Strosin-Schiller",
    "Comment": "illo",
    "StakeholderRoleId": 206,
    "CountryId": 227,
    "PersonId": 802,
    "EmailDescription": "carole@conroy.name",
    "EmailId": 576,
    "EmailAddress": "erick.bartell@kautzermcdermott.ca",
    "PhoneId": 272,
    "ContactName": "Herzog-Wisozk",
    "ContactId": 217,
    "SaleId": 893,
    "Mrmrs": "porro",
    "Firstname": "Madaline",
    "MiddleName": "Padberg, Armstrong and Koepp",
    "Lastname": "Price",
    "SaleStakeholderId": 103,
    "Rank": 402,
    "Phone": "(164)692-9178",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 779
      }
    }
  }
]
```