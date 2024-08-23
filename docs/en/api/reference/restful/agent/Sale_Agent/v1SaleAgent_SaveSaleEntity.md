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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "rerum",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "1997-12-25T13:28:23.6479929+01:00",
  "Amount": 20574.71,
  "SaleId": 711,
  "Earning": 23000.426,
  "EarningPercent": 9019.652,
  "Heading": "quisquam",
  "Number": "460260",
  "Probability": 331,
  "CreatedDate": "2016-03-11T13:28:23.6479929+01:00",
  "UpdatedDate": "2009-07-26T13:28:23.6479929+02:00",
  "Completed": "Completed",
  "ActiveLinks": 772,
  "Links": [
    {
      "EntityName": "Kuhlman-Anderson",
      "Id": 104,
      "Description": "Right-sized grid-enabled attitude",
      "ExtraInfo": "et",
      "LinkId": 554
    },
    {
      "EntityName": "Kuhlman-Anderson",
      "Id": 104,
      "Description": "Right-sized grid-enabled attitude",
      "ExtraInfo": "et",
      "LinkId": 554
    }
  ],
  "NextDueDate": "2006-12-02T13:28:23.6479929+01:00",
  "Postit": "nihil",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "1999-09-06T13:28:23.6479929+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Schaden Group",
      "Comment": "suscipit",
      "StakeholderRoleId": 146,
      "CountryId": 280,
      "PersonId": 667,
      "EmailDescription": "romaine.nader@funk.ca",
      "EmailId": 650,
      "EmailAddress": "leola.huels@rolfsonjacobson.co.uk",
      "PhoneId": 496,
      "ContactName": "Hyatt LLC",
      "ContactId": 867,
      "SaleId": 911,
      "Mrmrs": "omnis",
      "Firstname": "Danny",
      "MiddleName": "Weimann, Hessel and Jewess",
      "Lastname": "Kihn",
      "SaleStakeholderId": 964,
      "Rank": 394,
      "Phone": "289.997.5923 x96318"
    }
  ],
  "ActiveErpLinks": 726,
  "UserDefinedFields": {
    "SuperOffice:1": "Nathanael Dibbert",
    "SuperOffice:2": "159891015"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "laudantium"
  },
  "PublishEventDate": "2017-12-15T13:28:23.6479929+01:00",
  "PublishTo": "2011-12-02T13:28:23.6479929+01:00",
  "PublishFrom": "2003-01-15T13:28:23.6479929+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 322,
      "Visibility": "All",
      "DisplayValue": "sunt"
    },
    {
      "VisibleId": 322,
      "Visibility": "All",
      "DisplayValue": "sunt"
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
  "SaleText": "suscipit",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2023-03-13T13:28:23.6636125+01:00",
  "Amount": 4948.586,
  "SaleId": 772,
  "Earning": 21825.176,
  "EarningPercent": 26657.804,
  "Heading": "rerum",
  "Number": "772632",
  "Probability": 264,
  "CreatedDate": "2018-07-14T13:28:23.6636125+02:00",
  "UpdatedDate": "2017-10-17T13:28:23.6636125+02:00",
  "Completed": "Completed",
  "ActiveLinks": 994,
  "Links": [
    {
      "EntityName": "Dibbert-Balistreri",
      "Id": 573,
      "Description": "Public-key foreground circuit",
      "ExtraInfo": "nesciunt",
      "LinkId": 229,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    }
  ],
  "NextDueDate": "2016-09-06T13:28:23.6636125+02:00",
  "Postit": "sit",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2011-09-06T13:28:23.6636125+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Rutherford-Ritchie",
      "Comment": "non",
      "StakeholderRoleId": 381,
      "CountryId": 777,
      "PersonId": 32,
      "EmailDescription": "autumn@parisian.name",
      "EmailId": 838,
      "EmailAddress": "abigayle.gottlieb@franeckikris.name",
      "PhoneId": 61,
      "ContactName": "Tromp, West and Parker",
      "ContactId": 739,
      "SaleId": 524,
      "Mrmrs": "nihil",
      "Firstname": "Emanuel",
      "MiddleName": "Block Inc and Sons",
      "Lastname": "Thiel",
      "SaleStakeholderId": 213,
      "Rank": 45,
      "Phone": "(653)288-8620",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "ActiveErpLinks": 226,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "repellat",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "corrupti",
    "CustomFields2": "similique"
  },
  "PublishEventDate": "1997-11-12T13:28:23.6636125+01:00",
  "PublishTo": "2010-11-14T13:28:23.6636125+01:00",
  "PublishFrom": "2016-10-25T13:28:23.6636125+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 278,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    },
    {
      "VisibleId": 278,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 363
    }
  }
}
```