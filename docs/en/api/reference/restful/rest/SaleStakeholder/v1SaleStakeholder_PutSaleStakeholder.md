---
title: PUT SaleStakeholder/{id}
uid: v1SaleStakeholder_PutSaleStakeholder
generated: true
---

# PUT SaleStakeholder/{id}

```http
PUT /api/v1/SaleStakeholder/{id}
```

Updates the existing SaleStakeholder






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleStakeholder id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/SaleStakeholder/{id}?$select=name,department,category/id
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

## Request Body: entity 

The SaleStakeholder to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | String | Stakeholder role name |
| Comment | String | Optional comment text |
| StakeholderRoleId | Integer | Stakeholde role list id - Primary key |
| CountryId | Integer | Country id - primary key |
| PersonId | Integer | Person id - Primary key |
| EmailDescription | String | E-mail description |
| EmailId | Integer | E-mail address id - Primary key |
| EmailAddress | String | E-mail address |
| PhoneId | Integer | Primary key |
| ContactName | String | Contact name |
| ContactId | Integer | Contact ID of person or contact who is the sale stakeholder |
| SaleId | Integer | Parent sale |
| Mrmrs | String | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| SaleStakeholderId | Integer | Primary key |
| Rank | Integer | Rank in list of stakeholders |
| Phone | String | Phone number |

## Response:

SaleStakeholder updated.

| Response | Description |
|----------------|-------------|
| 200 | SaleStakeholder updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: SaleStakeholderWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/SaleStakeholder/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Spencer LLC",
  "Comment": "ullam",
  "StakeholderRoleId": 559,
  "CountryId": 205,
  "PersonId": 141,
  "EmailDescription": "maria@kuvalis.info",
  "EmailId": 492,
  "EmailAddress": "coleman.heathcote@heidenreichkemmer.name",
  "PhoneId": 699,
  "ContactName": "Wunsch Group",
  "ContactId": 880,
  "SaleId": 207,
  "Mrmrs": "rerum",
  "Firstname": "Donald",
  "MiddleName": "Mann Inc and Sons",
  "Lastname": "Johns",
  "SaleStakeholderId": 67,
  "Rank": 254,
  "Phone": "(354)928-6577 x78431"
}
```

## Sample response

```http_
HTTP/1.1 200 SaleStakeholder updated.
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Walsh, Goyette and Bashirian",
  "Comment": "omnis",
  "StakeholderRoleId": 828,
  "CountryId": 520,
  "PersonId": 647,
  "EmailDescription": "karlee.pollich@purdy.name",
  "EmailId": 321,
  "EmailAddress": "dereck@oconnell.info",
  "PhoneId": 558,
  "ContactName": "Fay Group",
  "ContactId": 346,
  "SaleId": 956,
  "Mrmrs": "facere",
  "Firstname": "Spencer",
  "MiddleName": "Leannon LLC",
  "Lastname": "Conn",
  "SaleStakeholderId": 786,
  "Rank": 587,
  "Phone": "1-272-221-2647 x939",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 481
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```