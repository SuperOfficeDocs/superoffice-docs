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
  "SaleText": "consequuntur",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2023-12-17T12:01:28.2440639+01:00",
  "Amount": 8753.2619999999988,
  "SaleId": 745,
  "Earning": 19064.122,
  "EarningPercent": 4622.65,
  "Heading": "quisquam",
  "Number": "707391",
  "Probability": 196,
  "CreatedDate": "1997-10-13T12:01:28.2440639+02:00",
  "UpdatedDate": "2005-08-12T12:01:28.2440639+02:00",
  "Completed": "Completed",
  "ActiveLinks": 981,
  "Links": [
    {
      "EntityName": "Haley Inc and Sons",
      "Id": 359,
      "Description": "Extended clear-thinking architecture",
      "ExtraInfo": "maiores",
      "LinkId": 451
    },
    {
      "EntityName": "Haley Inc and Sons",
      "Id": 359,
      "Description": "Extended clear-thinking architecture",
      "ExtraInfo": "maiores",
      "LinkId": 451
    }
  ],
  "NextDueDate": "2006-01-31T12:01:28.2440639+01:00",
  "Postit": "facere",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2020-04-28T12:01:28.2440639+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Wolff, Haley and Turcotte",
      "Comment": "optio",
      "StakeholderRoleId": 207,
      "CountryId": 755,
      "PersonId": 748,
      "EmailDescription": "kristofer.klein@bernhard.us",
      "EmailId": 568,
      "EmailAddress": "orlo@hilll.com",
      "PhoneId": 888,
      "ContactName": "Kuhlman-Lebsack",
      "ContactId": 161,
      "SaleId": 763,
      "Mrmrs": "eius",
      "Firstname": "Luella",
      "MiddleName": "Mills LLC",
      "Lastname": "Leannon",
      "SaleStakeholderId": 112,
      "Rank": 272,
      "Phone": "423.466.3469"
    }
  ],
  "ActiveErpLinks": 803,
  "UserDefinedFields": {
    "SuperOffice:1": "Benton Weimann",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "ipsa"
  },
  "PublishEventDate": "2000-08-15T12:01:28.2440639+02:00",
  "PublishTo": "2010-12-29T12:01:28.2440639+01:00",
  "PublishFrom": "1999-09-24T12:01:28.2440639+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 367,
      "Visibility": "All",
      "DisplayValue": "distinctio"
    },
    {
      "VisibleId": 367,
      "Visibility": "All",
      "DisplayValue": "distinctio"
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
  "SaleText": "sit",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2005-09-18T12:01:28.2440639+02:00",
  "Amount": 8439.862,
  "SaleId": 678,
  "Earning": 2714.044,
  "EarningPercent": 12968.492,
  "Heading": "minus",
  "Number": "747228",
  "Probability": 789,
  "CreatedDate": "2020-11-15T12:01:28.2440639+01:00",
  "UpdatedDate": "2004-07-30T12:01:28.2440639+02:00",
  "Completed": "Completed",
  "ActiveLinks": 421,
  "Links": [
    {
      "EntityName": "Kling-Schaden",
      "Id": 217,
      "Description": "Triple-buffered tangible productivity",
      "ExtraInfo": "aut",
      "LinkId": 925,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 909
        }
      }
    }
  ],
  "NextDueDate": "2021-05-30T12:01:28.2440639+02:00",
  "Postit": "ipsam",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2011-02-19T12:01:28.2440639+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Lind, Jast and Wisoky",
      "Comment": "fuga",
      "StakeholderRoleId": 94,
      "CountryId": 876,
      "PersonId": 382,
      "EmailDescription": "jennie@quigleymorissette.co.uk",
      "EmailId": 153,
      "EmailAddress": "beatrice.daniel@weber.ca",
      "PhoneId": 920,
      "ContactName": "Bauch Inc and Sons",
      "ContactId": 479,
      "SaleId": 867,
      "Mrmrs": "consequatur",
      "Firstname": "Annamae",
      "MiddleName": "Medhurst Inc and Sons",
      "Lastname": "Gerhold",
      "SaleStakeholderId": 191,
      "Rank": 990,
      "Phone": "1-703-548-3512 x119",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "ActiveErpLinks": 568,
  "UserDefinedFields": {
    "SuperOffice:1": "Philip Lillie Kub Jr.",
    "SuperOffice:2": "Katrine Ryan"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "quibusdam"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "voluptatum"
  },
  "PublishEventDate": "2018-07-15T12:01:28.2440639+02:00",
  "PublishTo": "2023-08-29T12:01:28.2440639+02:00",
  "PublishFrom": "2011-05-07T12:01:28.2440639+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 279,
      "Visibility": "All",
      "DisplayValue": "doloribus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    },
    {
      "VisibleId": 279,
      "Visibility": "All",
      "DisplayValue": "doloribus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 488
    }
  }
}
```