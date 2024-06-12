---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

The ProjectEntity to be saved. 

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
  "ProjectId": 24,
  "Name": "Emard, Waelchi and Wisoky",
  "ProjectNumber": "1074309",
  "ProjectMembers": [
    {
      "ProjectmemberId": 706,
      "ContactId": 636,
      "ProjectId": 698,
      "ContactName": "D'Amore Group",
      "ContactDepartment": "",
      "ProjectName": "Parisian, Rempel and Wolf",
      "EmailId": 265,
      "EmailAddress": "daryl.mcdermott@stehr.co.uk",
      "CountryId": 336,
      "Firstname": "Dianna",
      "MiddleName": "Marks, Morar and Klocko",
      "Lastname": "Leuschke",
      "PersonId": 844,
      "Mrmrs": "quam",
      "ProjectMemberTypeName": "Farrell LLC",
      "Phone": "454.147.0057 x822",
      "PhoneId": 785,
      "ProjectMemberTypeId": 150,
      "EmailAddressName": "cleo_murphy@schmittritchie.com",
      "Comment": "qui",
      "FullName": "Mr. Diana Destany Berge III"
    }
  ],
  "Urls": [
    {
      "Value": "animi",
      "StrippedValue": "asperiores",
      "Description": "Reverse-engineered disintermediate conglomeration"
    },
    {
      "Value": "animi",
      "StrippedValue": "asperiores",
      "Description": "Reverse-engineered disintermediate conglomeration"
    }
  ],
  "CreatedDate": "2003-10-25T04:22:27.2997425+02:00",
  "UpdatedDate": "2004-10-31T04:22:27.2997425+01:00",
  "Description": "Profit-focused scalable encryption",
  "Postit": "harum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Extended dynamic project",
  "ActiveStatusMonitorId": 407,
  "Links": [
    {
      "EntityName": "Hauck, Wuckert and Skiles",
      "Id": 953,
      "Description": "Down-sized contextually-based intranet",
      "ExtraInfo": "voluptatum",
      "LinkId": 110
    },
    {
      "EntityName": "Hauck, Wuckert and Skiles",
      "Id": 953,
      "Description": "Down-sized contextually-based intranet",
      "ExtraInfo": "voluptatum",
      "LinkId": 110
    }
  ],
  "ActiveLinks": 860,
  "Completed": false,
  "NextMilestoneDate": "2014-05-17T04:22:27.3153732+02:00",
  "NmdAppointmentId": 201,
  "EndDate": "2010-06-19T04:22:27.3153732+02:00",
  "ActiveErpLinks": 803,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Prof. Vicenta Turner"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "maiores"
  },
  "PublishEventDate": "2017-05-22T04:22:27.3153732+02:00",
  "PublishTo": "2011-07-12T04:22:27.3153732+02:00",
  "PublishFrom": "2004-07-05T04:22:27.3153732+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 683,
  "Name": "Franecki, Hammes and Little",
  "ProjectNumber": "907605",
  "ProjectMembers": [
    {
      "ProjectmemberId": 661,
      "ContactId": 915,
      "ProjectId": 252,
      "ContactName": "Stokes LLC",
      "ContactDepartment": "",
      "ProjectName": "Moen Group",
      "EmailId": 217,
      "EmailAddress": "taylor@conroy.info",
      "CountryId": 695,
      "Firstname": "Adrain",
      "MiddleName": "Paucek Inc and Sons",
      "Lastname": "Moore",
      "PersonId": 787,
      "Mrmrs": "maxime",
      "ProjectMemberTypeName": "Fahey LLC",
      "Phone": "(324)336-1175",
      "PhoneId": 622,
      "ProjectMemberTypeId": 178,
      "EmailAddressName": "izaiah@schroedergerhold.name",
      "Comment": "omnis",
      "FullName": "Myrtis Pouros",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 551
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "veritatis",
      "StrippedValue": "rerum",
      "Description": "Reverse-engineered holistic time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "rerum",
      "Description": "Reverse-engineered holistic time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    }
  ],
  "CreatedDate": "2002-12-16T04:22:27.3153732+01:00",
  "UpdatedDate": "2012-03-05T04:22:27.3153732+01:00",
  "Description": "Advanced fresh-thinking protocol",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Right-sized even-keeled intranet",
  "ActiveStatusMonitorId": 840,
  "Links": [
    {
      "EntityName": "Kutch Group",
      "Id": 848,
      "Description": "Function-based high-level interface",
      "ExtraInfo": "repudiandae",
      "LinkId": 665,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 210
        }
      }
    }
  ],
  "ActiveLinks": 614,
  "Completed": true,
  "NextMilestoneDate": "2015-05-30T04:22:27.3153732+02:00",
  "NmdAppointmentId": 295,
  "EndDate": "2021-07-06T04:22:27.3153732+02:00",
  "ActiveErpLinks": 195,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Hildegard Jessica Hegmann",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "doloremque"
  },
  "PublishEventDate": "2013-08-13T04:22:27.3153732+02:00",
  "PublishTo": "2001-01-15T04:22:27.3153732+01:00",
  "PublishFrom": "2022-10-20T04:22:27.3153732+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 116
    }
  }
}
```