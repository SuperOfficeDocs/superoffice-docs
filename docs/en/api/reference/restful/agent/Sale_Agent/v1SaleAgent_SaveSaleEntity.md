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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "est",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2006-06-28T03:41:53.9963385+02:00",
  "Amount": 26062.344,
  "SaleId": 662,
  "Earning": 30509.489999999998,
  "EarningPercent": 23006.694,
  "Heading": "incidunt",
  "Number": "1024677",
  "Probability": 783,
  "CreatedDate": "2006-01-23T03:41:53.9963385+01:00",
  "UpdatedDate": "1999-11-23T03:41:53.9963385+01:00",
  "Completed": "Completed",
  "ActiveLinks": 183,
  "Links": [
    {
      "EntityName": "Johnson, Konopelski and Huels",
      "Id": 248,
      "Description": "Persistent zero defect conglomeration",
      "ExtraInfo": "quibusdam",
      "LinkId": 865
    },
    {
      "EntityName": "Johnson, Konopelski and Huels",
      "Id": 248,
      "Description": "Persistent zero defect conglomeration",
      "ExtraInfo": "quibusdam",
      "LinkId": 865
    }
  ],
  "NextDueDate": "2019-06-15T03:41:53.9963385+02:00",
  "Postit": "et",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2020-01-21T03:41:53.9963385+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Wilkinson, Hegmann and Kulas",
      "Comment": "illo",
      "StakeholderRoleId": 872,
      "CountryId": 600,
      "PersonId": 42,
      "EmailDescription": "geo@fayhermiston.uk",
      "EmailId": 587,
      "EmailAddress": "wilma_wisozk@predovic.ca",
      "PhoneId": 272,
      "ContactName": "Monahan LLC",
      "ContactId": 240,
      "SaleId": 595,
      "Mrmrs": "nesciunt",
      "Firstname": "Evie",
      "MiddleName": "Goldner LLC",
      "Lastname": "Littel",
      "SaleStakeholderId": 117,
      "Rank": 914,
      "Phone": "645-891-5184 x58812"
    }
  ],
  "ActiveErpLinks": 621,
  "UserDefinedFields": {
    "SuperOffice:1": "Adolfo Heidenreich IV",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "alias"
  },
  "PublishEventDate": "2022-05-29T03:41:53.9963385+02:00",
  "PublishTo": "2013-08-02T03:41:53.9963385+02:00",
  "PublishFrom": "2004-09-10T03:41:53.9963385+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 618,
      "Visibility": "All",
      "DisplayValue": "delectus"
    },
    {
      "VisibleId": 618,
      "Visibility": "All",
      "DisplayValue": "delectus"
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
  "SaleText": "est",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2018-05-13T03:41:53.9963385+02:00",
  "Amount": 8004.236,
  "SaleId": 806,
  "Earning": 10564.714,
  "EarningPercent": 15228.106,
  "Heading": "et",
  "Number": "88845",
  "Probability": 283,
  "CreatedDate": "2021-06-29T03:41:53.9963385+02:00",
  "UpdatedDate": "2010-06-30T03:41:53.9963385+02:00",
  "Completed": "Completed",
  "ActiveLinks": 792,
  "Links": [
    {
      "EntityName": "Ebert-Schneider",
      "Id": 307,
      "Description": "Centralized next generation forecast",
      "ExtraInfo": "ut",
      "LinkId": 413,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "NextDueDate": "2012-11-12T03:41:53.9963385+01:00",
  "Postit": "cupiditate",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2021-02-24T03:41:53.9963385+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Cremin Group",
      "Comment": "est",
      "StakeholderRoleId": 752,
      "CountryId": 787,
      "PersonId": 30,
      "EmailDescription": "osvaldo.bauch@green.name",
      "EmailId": 438,
      "EmailAddress": "myrl.ziemann@moorehyatt.com",
      "PhoneId": 659,
      "ContactName": "Jewess, Marks and Wilkinson",
      "ContactId": 125,
      "SaleId": 100,
      "Mrmrs": "laudantium",
      "Firstname": "Corene",
      "MiddleName": "Hudson LLC",
      "Lastname": "Gottlieb",
      "SaleStakeholderId": 460,
      "Rank": 901,
      "Phone": "1-668-048-5560",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "ActiveErpLinks": 103,
  "UserDefinedFields": {
    "SuperOffice:1": "Judge Okuneva",
    "SuperOffice:2": "345290035"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2024-06-29T03:41:53.9963385+02:00",
  "PublishTo": "2023-12-04T03:41:53.9963385+01:00",
  "PublishFrom": "2010-04-09T03:41:53.9963385+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 997,
      "Visibility": "All",
      "DisplayValue": "in",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    },
    {
      "VisibleId": 997,
      "Visibility": "All",
      "DisplayValue": "in",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 637
    }
  }
}
```