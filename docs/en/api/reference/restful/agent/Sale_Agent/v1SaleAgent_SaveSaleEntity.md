---
title: POST Agents/Sale/SaveSaleEntity
uid: v1SaleAgent_SaveSaleEntity
generated: true
---

# POST Agents/Sale/SaveSaleEntity

```http
POST /api/v1/Agents/Sale/SaveSaleEntity
```

Updates the existing SaleEntity or creates a new SaleEntity if the id parameter is empty








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

The SaleEntity to be saved. 

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
| Appointment | Appointment | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate | Associate | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency | Currency | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor | Competitor | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited | Credited | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating | Rating | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason | Reason | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source | Source | The sale source  <para>Use MDO List name "source" to get list items.</para> |
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
| SaleType | SaleType | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold | ReasonSold | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled | ReasonStalled | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "SaleText": "voluptatem",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2021-01-12T23:03:56.8726175+01:00",
  "Amount": 19133.07,
  "SaleId": 862,
  "Earning": 27168.646,
  "EarningPercent": 11630.274,
  "Heading": "quaerat",
  "Number": "825900",
  "Probability": 549,
  "CreatedDate": "2022-03-26T23:03:56.8726175+01:00",
  "UpdatedDate": "2018-01-05T23:03:56.8726175+01:00",
  "Completed": "Completed",
  "ActiveLinks": 116,
  "Links": [
    {
      "EntityName": "Purdy-Thiel",
      "Id": 981,
      "Description": "Robust mobile website",
      "ExtraInfo": "temporibus",
      "LinkId": 891
    },
    {
      "EntityName": "Purdy-Thiel",
      "Id": 981,
      "Description": "Robust mobile website",
      "ExtraInfo": "temporibus",
      "LinkId": 891
    }
  ],
  "NextDueDate": "2023-09-17T23:03:56.8731188+02:00",
  "Postit": "doloremque",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "1999-01-18T23:03:56.8731188+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kulas-Rohan",
      "Comment": "et",
      "StakeholderRoleId": 29,
      "CountryId": 995,
      "PersonId": 122,
      "EmailDescription": "fiona_pacocha@blanda.name",
      "EmailId": 838,
      "EmailAddress": "earlene@conroymorar.name",
      "PhoneId": 196,
      "ContactName": "Hansen LLC",
      "ContactId": 355,
      "SaleId": 890,
      "Mrmrs": "qui",
      "Firstname": "Jermaine",
      "MiddleName": "White LLC",
      "Lastname": "Rau",
      "SaleStakeholderId": 695,
      "Rank": 525,
      "Phone": "1-274-770-5916 x6052"
    }
  ],
  "ActiveErpLinks": 390,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Mr. Adelle Russel Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "consequuntur",
    "CustomFields2": "quaerat"
  },
  "PublishEventDate": "1998-07-03T23:03:56.8741173+02:00",
  "PublishTo": "2012-12-06T23:03:56.8741173+01:00",
  "PublishFrom": "2000-05-22T23:03:56.8741173+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 439,
      "Visibility": "All",
      "DisplayValue": "aut"
    },
    {
      "VisibleId": 439,
      "Visibility": "All",
      "DisplayValue": "aut"
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
  "SaleText": "consequatur",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2019-01-16T23:03:56.8861164+01:00",
  "Amount": 19198.884,
  "SaleId": 106,
  "Earning": 16622.736,
  "EarningPercent": 23787.059999999998,
  "Heading": "rerum",
  "Number": "1709175",
  "Probability": 923,
  "CreatedDate": "1998-08-21T23:03:56.8861164+02:00",
  "UpdatedDate": "2023-10-13T23:03:56.8861164+02:00",
  "Completed": "Completed",
  "ActiveLinks": 672,
  "Links": [
    {
      "EntityName": "Wilkinson, Powlowski and Treutel",
      "Id": 368,
      "Description": "Versatile client-server definition",
      "ExtraInfo": "et",
      "LinkId": 823,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "NextDueDate": "2001-03-09T23:03:56.8861164+01:00",
  "Postit": "tempora",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2015-08-04T23:03:56.8871178+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Moore, Lemke and Rohan",
      "Comment": "debitis",
      "StakeholderRoleId": 63,
      "CountryId": 172,
      "PersonId": 630,
      "EmailDescription": "clark@stokesklocko.co.uk",
      "EmailId": 366,
      "EmailAddress": "jaida@marquardt.info",
      "PhoneId": 526,
      "ContactName": "Beer, McLaughlin and Klocko",
      "ContactId": 759,
      "SaleId": 506,
      "Mrmrs": "explicabo",
      "Firstname": "Al",
      "MiddleName": "Wuckert, Lowe and Casper",
      "Lastname": "Cartwright",
      "SaleStakeholderId": 737,
      "Rank": 290,
      "Phone": "407.068.0986",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    }
  ],
  "ActiveErpLinks": 350,
  "UserDefinedFields": {
    "SuperOffice:1": "304116754",
    "SuperOffice:2": "Mrs. Wava Cruz Ward III"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "ipsam"
  },
  "PublishEventDate": "2005-10-02T23:03:56.8881167+02:00",
  "PublishTo": "2000-03-02T23:03:56.8881167+01:00",
  "PublishFrom": "2004-08-24T23:03:56.8881167+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 742,
      "Visibility": "All",
      "DisplayValue": "reiciendis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    },
    {
      "VisibleId": 742,
      "Visibility": "All",
      "DisplayValue": "reiciendis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 821
    }
  }
}
```