---
title: POST SaleStakeholder
uid: v1SaleStakeholder_PostSaleStakeholder
generated: true
---

# POST SaleStakeholder

```http
POST /api/v1/SaleStakeholder
```

Creates a new SaleStakeholder


Calls the Sale agent service SaveSaleStakeholder.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/SaleStakeholder?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/SaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Treutel Group",
  "Comment": "autem",
  "StakeholderRoleId": 743,
  "CountryId": 717,
  "PersonId": 596,
  "EmailDescription": "gwendolyn_boyle@ratke.info",
  "EmailId": 280,
  "EmailAddress": "rosina@swaniawski.ca",
  "PhoneId": 75,
  "ContactName": "Dickens, Schuster and Botsford",
  "ContactId": 246,
  "SaleId": 263,
  "Mrmrs": "voluptatum",
  "Firstname": "Cordie",
  "MiddleName": "Russel, Sipes and Kuhn",
  "Lastname": "Langosh",
  "SaleStakeholderId": 237,
  "Rank": 846,
  "Phone": "712.549.2732 x401"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Mann LLC",
  "Comment": "eum",
  "StakeholderRoleId": 381,
  "CountryId": 888,
  "PersonId": 213,
  "EmailDescription": "tess@tremblaycronin.uk",
  "EmailId": 160,
  "EmailAddress": "randi_hoppe@olson.uk",
  "PhoneId": 689,
  "ContactName": "Baumbach-O'Conner",
  "ContactId": 147,
  "SaleId": 230,
  "Mrmrs": "minima",
  "Firstname": "Dallas",
  "MiddleName": "Abernathy, Christiansen and Schuster",
  "Lastname": "Ullrich",
  "SaleStakeholderId": 662,
  "Rank": 636,
  "Phone": "1-606-254-0967 x493",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 241
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```