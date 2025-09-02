---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is 0.








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

## Request Body: projectEntity 

The ProjectEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 253,
  "Name": "Schiller, Christiansen and Bergnaum",
  "ProjectNumber": "493221",
  "ProjectMembers": [
    {
      "ProjectmemberId": 321,
      "ContactId": 297,
      "ProjectId": 133,
      "ContactName": "DuBuque, Welch and Champlin",
      "ContactDepartment": "",
      "ProjectName": "Gusikowski, Beer and Gislason",
      "EmailId": 129,
      "EmailAddress": "kelsi_rice@block.co.uk",
      "CountryId": 848,
      "Firstname": "Jacklyn",
      "MiddleName": "Franecki-Rogahn",
      "Lastname": "Hintz",
      "PersonId": 325,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Turcotte, Flatley and Schulist",
      "Phone": "155-546-7644 x533",
      "PhoneId": 711,
      "ProjectMemberTypeId": 714,
      "EmailAddressName": "carmelo@volkman.com",
      "Comment": "ut",
      "FullName": "Lora Nitzsche III"
    }
  ],
  "Urls": [
    {
      "Value": "adipisci",
      "StrippedValue": "eaque",
      "Description": "Expanded 24 hour system engine"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "eaque",
      "Description": "Expanded 24 hour system engine"
    }
  ],
  "CreatedDate": "2002-03-06T03:46:55.1444933+01:00",
  "UpdatedDate": "2014-08-14T03:46:55.1444933+02:00",
  "Description": "Centralized dedicated portal",
  "Postit": "id",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Cross-group asynchronous complexity",
  "ActiveStatusMonitorId": 730,
  "Links": [
    {
      "EntityName": "Lubowitz LLC",
      "Id": 842,
      "Description": "Reverse-engineered 6th generation contingency",
      "ExtraInfo": "aperiam",
      "LinkId": 268
    },
    {
      "EntityName": "Lubowitz LLC",
      "Id": 842,
      "Description": "Reverse-engineered 6th generation contingency",
      "ExtraInfo": "aperiam",
      "LinkId": 268
    }
  ],
  "ActiveLinks": 569,
  "Completed": false,
  "NextMilestoneDate": "1999-02-04T03:46:55.1444933+01:00",
  "NmdAppointmentId": 708,
  "EndDate": "1999-07-21T03:46:55.1444933+02:00",
  "ActiveErpLinks": 82,
  "UserDefinedFields": {
    "SuperOffice:1": "Lia Zemlak",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "laboriosam"
  },
  "CustomFields": {
    "CustomFields1": "blanditiis",
    "CustomFields2": "laudantium"
  },
  "PublishEventDate": "2022-08-15T03:46:55.1444933+02:00",
  "PublishTo": "2001-11-08T03:46:55.1444933+01:00",
  "PublishFrom": "1998-12-03T03:46:55.1444933+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 523,
  "Name": "Casper LLC",
  "ProjectNumber": "943396",
  "ProjectMembers": [
    {
      "ProjectmemberId": 904,
      "ContactId": 772,
      "ProjectId": 392,
      "ContactName": "Leuschke, Labadie and Sporer",
      "ContactDepartment": "",
      "ProjectName": "Heaney-Trantow",
      "EmailId": 60,
      "EmailAddress": "deshaun@hettinger.uk",
      "CountryId": 961,
      "Firstname": "Orlando",
      "MiddleName": "Williamson Inc and Sons",
      "Lastname": "Hoeger",
      "PersonId": 802,
      "Mrmrs": "a",
      "ProjectMemberTypeName": "Hoppe Group",
      "Phone": "(490)877-6678",
      "PhoneId": 425,
      "ProjectMemberTypeId": 274,
      "EmailAddressName": "lessie@ohara.info",
      "Comment": "quae",
      "FullName": "Brady Pouros",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 858
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "repudiandae",
      "StrippedValue": "dolorem",
      "Description": "Assimilated multimedia initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "dolorem",
      "Description": "Assimilated multimedia initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    }
  ],
  "CreatedDate": "2008-01-24T03:46:55.1444933+01:00",
  "UpdatedDate": "2025-03-05T03:46:55.1444933+01:00",
  "Description": "Monitored disintermediate superstructure",
  "Postit": "facere",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Ameliorated analyzing firmware",
  "ActiveStatusMonitorId": 578,
  "Links": [
    {
      "EntityName": "Johnson-Schneider",
      "Id": 52,
      "Description": "Grass-roots secondary array",
      "ExtraInfo": "et",
      "LinkId": 779,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 475
        }
      }
    }
  ],
  "ActiveLinks": 109,
  "Completed": false,
  "NextMilestoneDate": "1999-01-12T03:46:55.1444933+01:00",
  "NmdAppointmentId": 133,
  "EndDate": "2018-05-29T03:46:55.1444933+02:00",
  "ActiveErpLinks": 177,
  "UserDefinedFields": {
    "SuperOffice:1": "886019027",
    "SuperOffice:2": "Abby Ullrich Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "voluptas"
  },
  "PublishEventDate": "2013-10-30T03:46:55.1444933+01:00",
  "PublishTo": "2010-11-26T03:46:55.1444933+01:00",
  "PublishFrom": "2018-08-24T03:46:55.1444933+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 631
    }
  }
}
```