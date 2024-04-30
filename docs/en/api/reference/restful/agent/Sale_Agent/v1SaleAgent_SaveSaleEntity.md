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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "libero",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2004-08-04T11:16:09.6473837+02:00",
  "Amount": 4302.982,
  "SaleId": 394,
  "Earning": 21464.766,
  "EarningPercent": 7440.116,
  "Heading": "molestias",
  "Number": "1721711",
  "Probability": 513,
  "CreatedDate": "2021-09-16T11:16:09.6473837+02:00",
  "UpdatedDate": "1999-03-29T11:16:09.6473837+02:00",
  "Completed": "Completed",
  "ActiveLinks": 108,
  "Links": [
    {
      "EntityName": "Hagenes-Moore",
      "Id": 742,
      "Description": "Devolved client-server standardization",
      "ExtraInfo": "et",
      "LinkId": 141
    },
    {
      "EntityName": "Hagenes-Moore",
      "Id": 742,
      "Description": "Devolved client-server standardization",
      "ExtraInfo": "et",
      "LinkId": 141
    }
  ],
  "NextDueDate": "2020-06-07T11:16:09.6473837+02:00",
  "Postit": "reiciendis",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2017-05-27T11:16:09.6473837+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Swaniawski, DuBuque and Boyle",
      "Comment": "quia",
      "StakeholderRoleId": 775,
      "CountryId": 295,
      "PersonId": 666,
      "EmailDescription": "christian_wintheiser@gutmann.biz",
      "EmailId": 186,
      "EmailAddress": "hunter_rutherford@runtetorphy.name",
      "PhoneId": 743,
      "ContactName": "Abshire, Botsford and Conroy",
      "ContactId": 822,
      "SaleId": 71,
      "Mrmrs": "saepe",
      "Firstname": "Jonathon",
      "MiddleName": "Balistreri, Fay and Will",
      "Lastname": "Wintheiser",
      "SaleStakeholderId": 330,
      "Rank": 310,
      "Phone": "(971)619-0939"
    }
  ],
  "ActiveErpLinks": 321,
  "UserDefinedFields": {
    "SuperOffice:1": "Trever Smitham",
    "SuperOffice:2": "Prof. Loyal Ethan Thompson MD"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "nemo"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2017-03-28T11:16:09.6473837+02:00",
  "PublishTo": "2021-08-10T11:16:09.6473837+02:00",
  "PublishFrom": "2019-08-05T11:16:09.6473837+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 270,
      "Visibility": "All",
      "DisplayValue": "ut"
    },
    {
      "VisibleId": 270,
      "Visibility": "All",
      "DisplayValue": "ut"
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
  "SaleText": "beatae",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2014-04-11T11:16:09.6637074+02:00",
  "Amount": 1027.952,
  "SaleId": 841,
  "Earning": 6631.544,
  "EarningPercent": 20145.352,
  "Heading": "ipsam",
  "Number": "289088",
  "Probability": 643,
  "CreatedDate": "1997-01-29T11:16:09.6637074+01:00",
  "UpdatedDate": "2022-06-29T11:16:09.6637074+02:00",
  "Completed": "Completed",
  "ActiveLinks": 949,
  "Links": [
    {
      "EntityName": "Konopelski, Dickinson and O'Connell",
      "Id": 55,
      "Description": "Multi-lateral fresh-thinking projection",
      "ExtraInfo": "vero",
      "LinkId": 321,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    }
  ],
  "NextDueDate": "2013-01-11T11:16:09.6637074+01:00",
  "Postit": "quo",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2006-03-08T11:16:09.6637074+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Quitzon, Schimmel and Keebler",
      "Comment": "placeat",
      "StakeholderRoleId": 682,
      "CountryId": 84,
      "PersonId": 614,
      "EmailDescription": "dennis@towne.ca",
      "EmailId": 819,
      "EmailAddress": "lura_macejkovic@rippin.uk",
      "PhoneId": 899,
      "ContactName": "Heidenreich-Upton",
      "ContactId": 991,
      "SaleId": 317,
      "Mrmrs": "dolorem",
      "Firstname": "Verner",
      "MiddleName": "Muller-Nader",
      "Lastname": "Deckow",
      "SaleStakeholderId": 466,
      "Rank": 964,
      "Phone": "1-631-870-6502 x45712",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "ActiveErpLinks": 712,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Guy Keshaun Kris II",
    "SuperOffice:2": "Lorine Gerlach"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "odio"
  },
  "PublishEventDate": "1997-01-27T11:16:09.6637074+01:00",
  "PublishTo": "2000-08-22T11:16:09.6637074+02:00",
  "PublishFrom": "2021-06-12T11:16:09.6637074+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 468,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 649
        }
      }
    },
    {
      "VisibleId": 468,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 649
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 186
    }
  }
}
```