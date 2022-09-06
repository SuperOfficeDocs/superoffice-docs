---
title: PUT Sale/{id}
uid: v1SaleEntity_PutSaleEntity
---

# PUT Sale/{id}

```http
PUT /api/v1/Sale/{id}
```

Updates the existing SaleEntity

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity id to update. **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Sale/{id}?$select=name,department,category/id
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

The SaleEntity to be saved.

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
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
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
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

## Response

SaleEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity updated. |
| 412 | Update stopped because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
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
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Sale/{id}
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
  "SaleText": "nesciunt",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2019-01-09T11:10:53.4241463+01:00",
  "Amount": 26626.464,
  "SaleId": 571,
  "Earning": 23492.464,
  "EarningPercent": 20139.084,
  "Heading": "doloremque",
  "Number": "678826",
  "Probability": 802,
  "CreatedDate": "1997-05-21T11:10:53.4241463+02:00",
  "UpdatedDate": "2006-11-12T11:10:53.4241463+01:00",
  "Completed": "Completed",
  "ActiveLinks": 726,
  "Links": [
    {
      "EntityName": "Hartmann-O'Connell",
      "Id": 760,
      "Description": "Cross-group client-driven alliance",
      "ExtraInfo": "sit",
      "LinkId": 726
    },
    {
      "EntityName": "Hartmann-O'Connell",
      "Id": 760,
      "Description": "Cross-group client-driven alliance",
      "ExtraInfo": "sit",
      "LinkId": 726
    }
  ],
  "NextDueDate": "2010-05-27T11:10:53.4241463+02:00",
  "Postit": "quos",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2017-10-01T11:10:53.4241463+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Graham, Johns and Krajcik",
      "Comment": "rerum",
      "StakeholderRoleId": 144,
      "CountryId": 597,
      "PersonId": 106,
      "EmailDescription": "weldon_romaguera@medhurst.co.uk",
      "EmailId": 520,
      "EmailAddress": "eldridge.connelly@nicolas.us",
      "PhoneId": 875,
      "ContactName": "Langosh-Crist",
      "ContactId": 698,
      "SaleId": 723,
      "Mrmrs": "beatae",
      "Firstname": "Kamryn",
      "MiddleName": "Parker, Shanahan and Toy",
      "Lastname": "Kautzer",
      "SaleStakeholderId": 685,
      "Rank": 830,
      "Phone": "921.008.3855 x354"
    }
  ],
  "ActiveErpLinks": 912,
  "UserDefinedFields": {
    "SuperOffice:1": "260203148",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "sapiente"
  },
  "PublishEventDate": "2017-03-30T11:10:53.425174+02:00",
  "PublishTo": "1997-09-01T11:10:53.425174+02:00",
  "PublishFrom": "2005-03-20T11:10:53.425174+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 49,
      "Visibility": "All",
      "DisplayValue": "saepe"
    },
    {
      "VisibleId": 49,
      "Visibility": "All",
      "DisplayValue": "saepe"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 SaleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "aut",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2014-03-02T11:10:53.4371738+01:00",
  "Amount": 3362.7819999999997,
  "SaleId": 4,
  "Earning": 3970.778,
  "EarningPercent": 7208.2,
  "Heading": "sit",
  "Number": "1081315",
  "Probability": 899,
  "CreatedDate": "2019-10-11T11:10:53.439174+02:00",
  "UpdatedDate": "2011-11-18T11:10:53.439174+01:00",
  "Completed": "Completed",
  "ActiveLinks": 923,
  "Links": [
    {
      "EntityName": "Simonis LLC",
      "Id": 677,
      "Description": "Multi-tiered logistical projection",
      "ExtraInfo": "ut",
      "LinkId": 773,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 654
        }
      }
    }
  ],
  "NextDueDate": "2012-07-31T11:10:53.439174+02:00",
  "Postit": "vel",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2009-02-23T11:10:53.439174+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kuhic LLC",
      "Comment": "quibusdam",
      "StakeholderRoleId": 125,
      "CountryId": 726,
      "PersonId": 878,
      "EmailDescription": "tobin@feestvonrueden.uk",
      "EmailId": 205,
      "EmailAddress": "polly@gusikowski.ca",
      "PhoneId": 141,
      "ContactName": "McKenzie Group",
      "ContactId": 138,
      "SaleId": 972,
      "Mrmrs": "iure",
      "Firstname": "Adolf",
      "MiddleName": "Kuhlman LLC",
      "Lastname": "Von",
      "SaleStakeholderId": 622,
      "Rank": 523,
      "Phone": "(626)511-6426 x27670",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 424
        }
      }
    }
  ],
  "ActiveErpLinks": 976,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Shania Edwin Rohan I"
  },
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "quis"
  },
  "PublishEventDate": "2010-10-28T11:10:53.440174+02:00",
  "PublishTo": "2021-05-27T11:10:53.440174+02:00",
  "PublishFrom": "2021-10-01T11:10:53.440174+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 906,
      "Visibility": "All",
      "DisplayValue": "nulla",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    },
    {
      "VisibleId": 906,
      "Visibility": "All",
      "DisplayValue": "nulla",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 100
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
