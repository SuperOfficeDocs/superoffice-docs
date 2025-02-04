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
  "ProjectId": 498,
  "Name": "Bosco Group",
  "ProjectNumber": "373139",
  "ProjectMembers": [
    {
      "ProjectmemberId": 291,
      "ContactId": 552,
      "ProjectId": 8,
      "ContactName": "Kuhn-Harvey",
      "ContactDepartment": "",
      "ProjectName": "Lehner Group",
      "EmailId": 147,
      "EmailAddress": "anastasia.cartwright@gleichner.co.uk",
      "CountryId": 942,
      "Firstname": "Marquise",
      "MiddleName": "Strosin Group",
      "Lastname": "Kessler",
      "PersonId": 420,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Hills-Koss",
      "Phone": "203-003-4126 x32833",
      "PhoneId": 506,
      "ProjectMemberTypeId": 442,
      "EmailAddressName": "brendan@turner.com",
      "Comment": "magni",
      "FullName": "Dr. Alexzander Krajcik DVM"
    }
  ],
  "Urls": [
    {
      "Value": "tempora",
      "StrippedValue": "maxime",
      "Description": "Object-based modular flexibility"
    },
    {
      "Value": "tempora",
      "StrippedValue": "maxime",
      "Description": "Object-based modular flexibility"
    }
  ],
  "CreatedDate": "2007-10-20T13:13:23.6175382+02:00",
  "UpdatedDate": "2012-02-20T13:13:23.6175382+01:00",
  "Description": "Synergistic local implementation",
  "Postit": "aut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Function-based secondary budgetary management",
  "ActiveStatusMonitorId": 627,
  "Links": [
    {
      "EntityName": "Boyer Group",
      "Id": 574,
      "Description": "Future-proofed next generation adapter",
      "ExtraInfo": "facere",
      "LinkId": 801
    },
    {
      "EntityName": "Boyer Group",
      "Id": 574,
      "Description": "Future-proofed next generation adapter",
      "ExtraInfo": "facere",
      "LinkId": 801
    }
  ],
  "ActiveLinks": 772,
  "Completed": false,
  "NextMilestoneDate": "2012-04-24T13:13:23.6175382+02:00",
  "NmdAppointmentId": 623,
  "EndDate": "2004-12-03T13:13:23.6175382+01:00",
  "ActiveErpLinks": 371,
  "UserDefinedFields": {
    "SuperOffice:1": "Concepcion Reynolds",
    "SuperOffice:2": "Noemy Runte IV"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "eveniet",
    "CustomFields2": "nam"
  },
  "PublishEventDate": "2021-05-07T13:13:23.6175382+02:00",
  "PublishTo": "1998-05-24T13:13:23.6175382+02:00",
  "PublishFrom": "1999-12-27T13:13:23.6175382+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 132,
  "Name": "Osinski, Braun and Schmidt",
  "ProjectNumber": "529155",
  "ProjectMembers": [
    {
      "ProjectmemberId": 33,
      "ContactId": 473,
      "ProjectId": 448,
      "ContactName": "Herzog-Anderson",
      "ContactDepartment": "",
      "ProjectName": "Nikolaus-Bode",
      "EmailId": 317,
      "EmailAddress": "magali@lindgren.com",
      "CountryId": 594,
      "Firstname": "Zion",
      "MiddleName": "Reichert Inc and Sons",
      "Lastname": "Ernser",
      "PersonId": 235,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Stehr LLC",
      "Phone": "592.866.2519",
      "PhoneId": 286,
      "ProjectMemberTypeId": 945,
      "EmailAddressName": "deonte@gradysauer.co.uk",
      "Comment": "quaerat",
      "FullName": "Kadin Donnelly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Adaptive full-range intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 802
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Adaptive full-range intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 802
        }
      }
    }
  ],
  "CreatedDate": "2004-05-14T13:13:23.6175382+02:00",
  "UpdatedDate": "2021-06-09T13:13:23.6175382+02:00",
  "Description": "Progressive client-server success",
  "Postit": "quos",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Programmable explicit policy",
  "ActiveStatusMonitorId": 484,
  "Links": [
    {
      "EntityName": "Kris LLC",
      "Id": 93,
      "Description": "Configurable multi-tasking website",
      "ExtraInfo": "similique",
      "LinkId": 299,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 392
        }
      }
    }
  ],
  "ActiveLinks": 915,
  "Completed": true,
  "NextMilestoneDate": "2014-04-05T13:13:23.6175382+02:00",
  "NmdAppointmentId": 996,
  "EndDate": "2020-09-18T13:13:23.6175382+02:00",
  "ActiveErpLinks": 849,
  "UserDefinedFields": {
    "SuperOffice:1": "Stacy Feest",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "ab"
  },
  "PublishEventDate": "2012-11-25T13:13:23.6175382+01:00",
  "PublishTo": "2000-02-27T13:13:23.6175382+01:00",
  "PublishFrom": "2009-04-02T13:13:23.6175382+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 677
    }
  }
}
```