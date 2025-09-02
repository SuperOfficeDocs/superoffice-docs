---
title: POST Agents/Sale/SaveSaleEntity
uid: v1SaleAgent_SaveSaleEntity
generated: true
content_type: reference
---

# POST Agents/Sale/SaveSaleEntity

```http
POST /api/v1/Agents/Sale/SaveSaleEntity
```

Updates the existing SaleEntity or creates a new SaleEntity if the id parameter is 0.








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

## Request Body: saleEntity 

The SaleEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment | Appointment | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate | Associate | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | String | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency | Currency | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor | Competitor | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited | Credited | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating | Rating | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason | Reason | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source | Source | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | String | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | String | (expected / lost / won) sales date |
| Amount | Number | Total sale amount |
| SaleId | Integer | Primary key |
| Earning | Number | Earning on sale |
| EarningPercent | Number | Earning as percent of total |
| Heading | String | Sale heading (short description?) |
| Number | String | Alphanumeric user field |
| Probability | Integer | Actual probability, may differ from the one in the list |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated  in UTC. |
| Completed | String | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | Integer | Number of active links to sale, document, appointment. |
| Links | Array | List of all elements linked to the sale. |
| NextDueDate | String | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType | SaleType | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold | ReasonSold | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled | ReasonStalled | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | String | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | Array |  |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SaleEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment | Appointment | Simple read-only appointment data.  Carrier object for Appointment. Services for the Appointment Carrier is available from the Appointment Agent. |
| Associate | Associate | The sale owner  Use MDO List name "associate" to get list items. |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  Use MDO List name "contact" to get list items. |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  Use MDO List name "project" to get list items. |
| SaleText | string | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  Use MDO List name "person" to get list items. |
| Currency | Currency | The currency the sale object was sold in  Use MDO List name "currency" to get list items. |
| Competitor | Competitor | List of all possible competitors.   Use MDO List name "comptr" to get list items. |
| Credited | Credited | List of who is to be credited for the sale.  Use MDO List name "credited" to get list items. |
| Rating | Rating | The sale rating  Use MDO List name "prob" to get list items. |
| Reason | Reason | The sale reason  Use MDO List name "reason" to get list items. |
| Source | Source | The sale source  Use MDO List name "source" to get list items. |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType | SaleType | Use MDO List name "saletype" to get list items. |
| ReasonSold | ReasonSold | Use MDO List name "reasonsold" to get list items. |
| ReasonStalled | ReasonStalled | Use MDO List name "reasonstalled" to get list items. |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Sale/SaveSaleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "maiores",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2002-09-27T03:46:55.2538645+02:00",
  "Amount": 8386.5839999999989,
  "SaleId": 564,
  "Earning": 26338.136,
  "EarningPercent": 22865.664,
  "Heading": "unde",
  "Number": "767804",
  "Probability": 721,
  "CreatedDate": "2000-04-10T03:46:55.2538645+02:00",
  "UpdatedDate": "2024-02-02T03:46:55.2538645+01:00",
  "Completed": "Completed",
  "ActiveLinks": 692,
  "Links": [
    {
      "EntityName": "Ziemann-Moen",
      "Id": 78,
      "Description": "Re-engineered grid-enabled migration",
      "ExtraInfo": "voluptatem",
      "LinkId": 815
    },
    {
      "EntityName": "Ziemann-Moen",
      "Id": 78,
      "Description": "Re-engineered grid-enabled migration",
      "ExtraInfo": "voluptatem",
      "LinkId": 815
    }
  ],
  "NextDueDate": "2023-06-30T03:46:55.2538645+02:00",
  "Postit": "sit",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2007-12-05T03:46:55.2538645+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kerluke Group",
      "Comment": "unde",
      "StakeholderRoleId": 656,
      "CountryId": 469,
      "PersonId": 724,
      "EmailDescription": "derrick.crona@greenholt.uk",
      "EmailId": 882,
      "EmailAddress": "annamae.purdy@schustervonrueden.co.uk",
      "PhoneId": 134,
      "ContactName": "Kuhn, Tillman and Cronin",
      "ContactId": 261,
      "SaleId": 403,
      "Mrmrs": "eaque",
      "Firstname": "Brown",
      "MiddleName": "Lehner, McKenzie and Legros",
      "Lastname": "Davis",
      "SaleStakeholderId": 435,
      "Rank": 557,
      "Phone": "964-498-5722"
    }
  ],
  "ActiveErpLinks": 502,
  "UserDefinedFields": {
    "SuperOffice:1": "1369531858",
    "SuperOffice:2": "Zoila Doyle"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "corporis"
  },
  "PublishEventDate": "2008-03-04T03:46:55.2538645+01:00",
  "PublishTo": "2000-10-07T03:46:55.2538645+02:00",
  "PublishFrom": "2021-07-25T03:46:55.2538645+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 59,
      "Visibility": "All",
      "DisplayValue": "et"
    },
    {
      "VisibleId": 59,
      "Visibility": "All",
      "DisplayValue": "et"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "mollitia",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2023-04-24T03:46:55.2538645+02:00",
  "Amount": 14767.408,
  "SaleId": 37,
  "Earning": 7787.99,
  "EarningPercent": 5086.482,
  "Heading": "sunt",
  "Number": "355760",
  "Probability": 992,
  "CreatedDate": "2010-04-14T03:46:55.2538645+02:00",
  "UpdatedDate": "2006-01-26T03:46:55.2538645+01:00",
  "Completed": "Completed",
  "ActiveLinks": 119,
  "Links": [
    {
      "EntityName": "McGlynn Group",
      "Id": 648,
      "Description": "Diverse multi-tasking model",
      "ExtraInfo": "exercitationem",
      "LinkId": 377,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "NextDueDate": "2008-04-21T03:46:55.2538645+02:00",
  "Postit": "velit",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2019-12-02T03:46:55.2538645+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Wuckert, Doyle and Littel",
      "Comment": "quo",
      "StakeholderRoleId": 972,
      "CountryId": 1001,
      "PersonId": 133,
      "EmailDescription": "modesta@wiegandbaumbach.name",
      "EmailId": 520,
      "EmailAddress": "fatima_mann@schadenlemke.ca",
      "PhoneId": 901,
      "ContactName": "Marks-Boyer",
      "ContactId": 432,
      "SaleId": 909,
      "Mrmrs": "est",
      "Firstname": "Waldo",
      "MiddleName": "Jenkins-Hickle",
      "Lastname": "Harris",
      "SaleStakeholderId": 550,
      "Rank": 58,
      "Phone": "1-790-980-7273",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    }
  ],
  "ActiveErpLinks": 544,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Naomi Trisha Tromp",
    "SuperOffice:2": "Prof. Aniya Nicolas"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "iste"
  },
  "PublishEventDate": "2000-02-08T03:46:55.2538645+01:00",
  "PublishTo": "2006-03-28T03:46:55.2538645+02:00",
  "PublishFrom": "2004-11-19T03:46:55.2538645+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 644,
      "Visibility": "All",
      "DisplayValue": "voluptatum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    },
    {
      "VisibleId": 644,
      "Visibility": "All",
      "DisplayValue": "voluptatum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 341
    }
  }
}
```