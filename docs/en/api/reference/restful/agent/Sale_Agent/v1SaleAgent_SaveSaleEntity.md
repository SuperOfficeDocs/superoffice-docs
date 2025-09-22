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
  "SaleText": "et",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2001-03-28T11:24:48.5626385+02:00",
  "Amount": 16071.152,
  "SaleId": 193,
  "Earning": 6130.1039999999994,
  "EarningPercent": 26830.174,
  "Heading": "corrupti",
  "Number": "862452",
  "Probability": 566,
  "CreatedDate": "2013-12-16T11:24:48.5626385+01:00",
  "UpdatedDate": "2003-08-23T11:24:48.5626385+02:00",
  "Completed": "Completed",
  "ActiveLinks": 818,
  "Links": [
    {
      "EntityName": "Howell Inc and Sons",
      "Id": 242,
      "Description": "Quality-focused logistical info-mediaries",
      "ExtraInfo": "cumque",
      "LinkId": 805
    },
    {
      "EntityName": "Howell Inc and Sons",
      "Id": 242,
      "Description": "Quality-focused logistical info-mediaries",
      "ExtraInfo": "cumque",
      "LinkId": 805
    }
  ],
  "NextDueDate": "1999-10-28T11:24:48.5626385+02:00",
  "Postit": "eius",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2010-02-18T11:24:48.5626385+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Mills, Cartwright and Kozey",
      "Comment": "itaque",
      "StakeholderRoleId": 281,
      "CountryId": 911,
      "PersonId": 848,
      "EmailDescription": "juston.murphy@shields.co.uk",
      "EmailId": 209,
      "EmailAddress": "shyann_kulas@kovacekhackett.ca",
      "PhoneId": 744,
      "ContactName": "Hegmann Group",
      "ContactId": 994,
      "SaleId": 118,
      "Mrmrs": "aut",
      "Firstname": "Cheyanne",
      "MiddleName": "Tillman Inc and Sons",
      "Lastname": "Hills",
      "SaleStakeholderId": 909,
      "Rank": 131,
      "Phone": "1-428-742-9582"
    }
  ],
  "ActiveErpLinks": 608,
  "UserDefinedFields": {
    "SuperOffice:1": "Uriel Lynch",
    "SuperOffice:2": "Michelle Boyer"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "laudantium",
    "CustomFields2": "enim"
  },
  "PublishEventDate": "2012-02-01T11:24:48.5626385+01:00",
  "PublishTo": "2007-02-12T11:24:48.5626385+01:00",
  "PublishFrom": "1999-03-03T11:24:48.5626385+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 984,
      "Visibility": "All",
      "DisplayValue": "asperiores"
    },
    {
      "VisibleId": 984,
      "Visibility": "All",
      "DisplayValue": "asperiores"
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
  "SaleText": "laudantium",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2025-01-29T11:24:48.5782627+01:00",
  "Amount": 6340.0819999999994,
  "SaleId": 938,
  "Earning": 6628.41,
  "EarningPercent": 5600.458,
  "Heading": "eos",
  "Number": "1343635",
  "Probability": 631,
  "CreatedDate": "2015-05-19T11:24:48.5782627+02:00",
  "UpdatedDate": "2020-09-18T11:24:48.5782627+02:00",
  "Completed": "Completed",
  "ActiveLinks": 84,
  "Links": [
    {
      "EntityName": "Parisian-Dibbert",
      "Id": 757,
      "Description": "Fundamental scalable adapter",
      "ExtraInfo": "sit",
      "LinkId": 376,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 635
        }
      }
    }
  ],
  "NextDueDate": "2023-07-13T11:24:48.5782627+02:00",
  "Postit": "ut",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2024-01-02T11:24:48.5782627+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Schoen-Reichert",
      "Comment": "dolore",
      "StakeholderRoleId": 812,
      "CountryId": 294,
      "PersonId": 787,
      "EmailDescription": "zula_kunze@stiedemannmccullough.biz",
      "EmailId": 949,
      "EmailAddress": "mercedes.daniel@mueller.co.uk",
      "PhoneId": 658,
      "ContactName": "Hamill, Jaskolski and Gislason",
      "ContactId": 55,
      "SaleId": 835,
      "Mrmrs": "debitis",
      "Firstname": "Deion",
      "MiddleName": "Hilpert, Carter and Beatty",
      "Lastname": "Walter",
      "SaleStakeholderId": 294,
      "Rank": 499,
      "Phone": "1-032-641-0258",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    }
  ],
  "ActiveErpLinks": 950,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "2036446241"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "repellendus"
  },
  "PublishEventDate": "2021-10-03T11:24:48.5782627+02:00",
  "PublishTo": "2021-07-11T11:24:48.5782627+02:00",
  "PublishFrom": "2012-02-06T11:24:48.5782627+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 37,
      "Visibility": "All",
      "DisplayValue": "est",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    },
    {
      "VisibleId": 37,
      "Visibility": "All",
      "DisplayValue": "est",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 191
    }
  }
}
```