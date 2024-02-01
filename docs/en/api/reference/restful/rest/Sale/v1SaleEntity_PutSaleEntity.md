---
title: PUT Sale/{id}
uid: v1SaleEntity_PutSaleEntity
generated: true
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

SaleEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity updated. |
| 412 | Update stopped because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: SaleEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Sale/{id}
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
  "SaleText": "quia",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "1996-09-13T23:04:04.6995057+02:00",
  "Amount": 27588.602,
  "SaleId": 58,
  "Earning": 673.81,
  "EarningPercent": 30659.922,
  "Heading": "vero",
  "Number": "1247356",
  "Probability": 96,
  "CreatedDate": "2010-08-22T23:04:04.7000099+02:00",
  "UpdatedDate": "2009-03-20T23:04:04.7000099+01:00",
  "Completed": "Completed",
  "ActiveLinks": 379,
  "Links": [
    {
      "EntityName": "Crooks-Toy",
      "Id": 505,
      "Description": "User-centric 3rd generation monitoring",
      "ExtraInfo": "labore",
      "LinkId": 988
    },
    {
      "EntityName": "Crooks-Toy",
      "Id": 505,
      "Description": "User-centric 3rd generation monitoring",
      "ExtraInfo": "labore",
      "LinkId": 988
    }
  ],
  "NextDueDate": "2007-11-24T23:04:04.7000099+01:00",
  "Postit": "optio",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2001-11-19T23:04:04.7000099+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Schaefer-Walter",
      "Comment": "sed",
      "StakeholderRoleId": 119,
      "CountryId": 512,
      "PersonId": 205,
      "EmailDescription": "anya@ruecker.name",
      "EmailId": 750,
      "EmailAddress": "angel@bergstrom.biz",
      "PhoneId": 693,
      "ContactName": "Walsh, Feeney and Strosin",
      "ContactId": 26,
      "SaleId": 346,
      "Mrmrs": "qui",
      "Firstname": "Dannie",
      "MiddleName": "Wunsch-Haley",
      "Lastname": "Hansen",
      "SaleStakeholderId": 454,
      "Rank": 953,
      "Phone": "143-368-2781"
    }
  ],
  "ActiveErpLinks": 754,
  "UserDefinedFields": {
    "SuperOffice:1": "Kaylin Gorczany",
    "SuperOffice:2": "Ms. Jed Margaretta Moen IV"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "cupiditate"
  },
  "PublishEventDate": "2014-08-29T23:04:04.7010098+02:00",
  "PublishTo": "2006-05-09T23:04:04.7010098+02:00",
  "PublishFrom": "2015-06-01T23:04:04.7010098+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 782,
      "Visibility": "All",
      "DisplayValue": "iure"
    },
    {
      "VisibleId": 782,
      "Visibility": "All",
      "DisplayValue": "iure"
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
  "SaleText": "consectetur",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "1999-05-14T23:04:04.71451+02:00",
  "Amount": 8562.088,
  "SaleId": 466,
  "Earning": 2500.932,
  "EarningPercent": 4381.3319999999994,
  "Heading": "libero",
  "Number": "1020140",
  "Probability": 821,
  "CreatedDate": "2010-06-11T23:04:04.71451+02:00",
  "UpdatedDate": "2014-07-30T23:04:04.71451+02:00",
  "Completed": "Completed",
  "ActiveLinks": 703,
  "Links": [
    {
      "EntityName": "Cremin Group",
      "Id": 668,
      "Description": "Networked stable service-desk",
      "ExtraInfo": "et",
      "LinkId": 550,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    }
  ],
  "NextDueDate": "2011-11-16T23:04:04.71451+01:00",
  "Postit": "eos",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2017-10-29T23:04:04.71451+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Konopelski-Littel",
      "Comment": "dicta",
      "StakeholderRoleId": 696,
      "CountryId": 676,
      "PersonId": 339,
      "EmailDescription": "krystel_keeling@stanton.biz",
      "EmailId": 848,
      "EmailAddress": "camren@jaskolski.biz",
      "PhoneId": 956,
      "ContactName": "Bashirian-Schneider",
      "ContactId": 713,
      "SaleId": 764,
      "Mrmrs": "omnis",
      "Firstname": "Kylee",
      "MiddleName": "Kessler, Rolfson and Osinski",
      "Lastname": "Conroy",
      "SaleStakeholderId": 418,
      "Rank": 531,
      "Phone": "622.699.5178 x7003",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    }
  ],
  "ActiveErpLinks": 745,
  "UserDefinedFields": {
    "SuperOffice:1": "Jevon Wisozk",
    "SuperOffice:2": "Markus McLaughlin"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "2021-01-14T23:04:04.7155101+01:00",
  "PublishTo": "1999-05-25T23:04:04.7155101+02:00",
  "PublishFrom": "2000-02-06T23:04:04.7155101+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 654,
      "Visibility": "All",
      "DisplayValue": "ex",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    },
    {
      "VisibleId": 654,
      "Visibility": "All",
      "DisplayValue": "ex",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 164
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```