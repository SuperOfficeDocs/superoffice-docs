---
title: POST Sale
uid: v1SaleEntity_PostSaleEntity
generated: true
---

# POST Sale

```http
POST /api/v1/Sale
```

Creates a new SaleEntity


Calls the Sale agent service SaveSaleEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Sale?$select=name,department,category/id
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

### Response body: SaleEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Sale
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
  "SaleText": "cum",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2001-04-11T12:01:33.0581965+02:00",
  "Amount": 303.998,
  "SaleId": 104,
  "Earning": 29885.824,
  "EarningPercent": 3958.2419999999997,
  "Heading": "laboriosam",
  "Number": "1513063",
  "Probability": 65,
  "CreatedDate": "2003-02-18T12:01:33.0581965+01:00",
  "UpdatedDate": "2000-08-26T12:01:33.0581965+02:00",
  "Completed": "Completed",
  "ActiveLinks": 73,
  "Links": [
    {
      "EntityName": "Effertz-Kulas",
      "Id": 323,
      "Description": "Right-sized tangible alliance",
      "ExtraInfo": "incidunt",
      "LinkId": 425
    },
    {
      "EntityName": "Effertz-Kulas",
      "Id": 323,
      "Description": "Right-sized tangible alliance",
      "ExtraInfo": "incidunt",
      "LinkId": 425
    }
  ],
  "NextDueDate": "2008-02-13T12:01:33.0581965+01:00",
  "Postit": "laudantium",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2024-11-11T12:01:33.0581965+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Brekke Group",
      "Comment": "aut",
      "StakeholderRoleId": 116,
      "CountryId": 945,
      "PersonId": 52,
      "EmailDescription": "laury@gaylordoconner.name",
      "EmailId": 742,
      "EmailAddress": "emmie@jacobi.co.uk",
      "PhoneId": 232,
      "ContactName": "Pfannerstill-Lowe",
      "ContactId": 697,
      "SaleId": 157,
      "Mrmrs": "sit",
      "Firstname": "Sydnie",
      "MiddleName": "Rowe, Feeney and Gleason",
      "Lastname": "Von",
      "SaleStakeholderId": 914,
      "Rank": 71,
      "Phone": "488-987-4082 x3835"
    }
  ],
  "ActiveErpLinks": 64,
  "UserDefinedFields": {
    "SuperOffice:1": "395227229",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2002-11-10T12:01:33.0581965+01:00",
  "PublishTo": "2011-08-11T12:01:33.0581965+02:00",
  "PublishFrom": "2017-10-14T12:01:33.0581965+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 615,
      "Visibility": "All",
      "DisplayValue": "et"
    },
    {
      "VisibleId": 615,
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
  "SaleText": "at",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2001-12-07T12:01:33.0581965+01:00",
  "Amount": 11495.511999999999,
  "SaleId": 780,
  "Earning": 27817.384,
  "EarningPercent": 13654.838,
  "Heading": "voluptas",
  "Number": "1066988",
  "Probability": 703,
  "CreatedDate": "2022-04-16T12:01:33.0581965+02:00",
  "UpdatedDate": "2000-10-23T12:01:33.0581965+02:00",
  "Completed": "Completed",
  "ActiveLinks": 273,
  "Links": [
    {
      "EntityName": "Schimmel-Conroy",
      "Id": 460,
      "Description": "User-centric holistic concept",
      "ExtraInfo": "omnis",
      "LinkId": 33,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 239
        }
      }
    }
  ],
  "NextDueDate": "2020-09-22T12:01:33.0581965+02:00",
  "Postit": "at",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2019-11-10T12:01:33.0581965+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Goldner-Legros",
      "Comment": "nisi",
      "StakeholderRoleId": 744,
      "CountryId": 496,
      "PersonId": 540,
      "EmailDescription": "edna@mohr.com",
      "EmailId": 697,
      "EmailAddress": "eloise@gulgowski.biz",
      "PhoneId": 989,
      "ContactName": "Hudson-Schoen",
      "ContactId": 418,
      "SaleId": 195,
      "Mrmrs": "enim",
      "Firstname": "Greta",
      "MiddleName": "Fisher Group",
      "Lastname": "Homenick",
      "SaleStakeholderId": 889,
      "Rank": 474,
      "Phone": "(097)287-5196 x71065",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    }
  ],
  "ActiveErpLinks": 388,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Mrs. Hunter West I"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "delectus",
    "CustomFields2": "fuga"
  },
  "PublishEventDate": "2020-08-28T12:01:33.0581965+02:00",
  "PublishTo": "2001-10-18T12:01:33.0581965+02:00",
  "PublishFrom": "2000-06-25T12:01:33.0581965+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 666,
      "Visibility": "All",
      "DisplayValue": "a",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
        }
      }
    },
    {
      "VisibleId": 666,
      "Visibility": "All",
      "DisplayValue": "a",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 181
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```