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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 801,
  "Name": "Lemke Group",
  "ProjectNumber": "285343",
  "ProjectMembers": [
    {
      "ProjectmemberId": 161,
      "ContactId": 851,
      "ProjectId": 773,
      "ContactName": "Quitzon Group",
      "ContactDepartment": "",
      "ProjectName": "Schimmel-Bode",
      "EmailId": 138,
      "EmailAddress": "karina.beatty@lemke.info",
      "CountryId": 87,
      "Firstname": "Arnold",
      "MiddleName": "Sawayn, Pfeffer and O'Keefe",
      "Lastname": "Steuber",
      "PersonId": 902,
      "Mrmrs": "vitae",
      "ProjectMemberTypeName": "Koelpin, Friesen and Collins",
      "Phone": "005.295.4811",
      "PhoneId": 989,
      "ProjectMemberTypeId": 259,
      "EmailAddressName": "skye_blanda@bashirian.info",
      "Comment": "dignissimos",
      "FullName": "Miss Stanton Walsh IV"
    }
  ],
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "sit",
      "Description": "Programmable incremental collaboration"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "sit",
      "Description": "Programmable incremental collaboration"
    }
  ],
  "CreatedDate": "2018-09-19T04:02:02.1284666+02:00",
  "UpdatedDate": "2018-07-28T04:02:02.1284666+02:00",
  "Description": "Digitized didactic moderator",
  "Postit": "magni",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Intuitive background data-warehouse",
  "ActiveStatusMonitorId": 293,
  "Links": [
    {
      "EntityName": "Grady, Christiansen and Boyle",
      "Id": 596,
      "Description": "Public-key motivating array",
      "ExtraInfo": "officiis",
      "LinkId": 914
    },
    {
      "EntityName": "Grady, Christiansen and Boyle",
      "Id": 596,
      "Description": "Public-key motivating array",
      "ExtraInfo": "officiis",
      "LinkId": 914
    }
  ],
  "ActiveLinks": 463,
  "Completed": false,
  "NextMilestoneDate": "2009-12-15T04:02:02.1284666+01:00",
  "NmdAppointmentId": 863,
  "EndDate": "2002-01-12T04:02:02.1284666+01:00",
  "ActiveErpLinks": 621,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dr. Jo Cecile Weissnat Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "necessitatibus",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "tenetur"
  },
  "PublishEventDate": "2004-01-02T04:02:02.1284666+01:00",
  "PublishTo": "1997-06-13T04:02:02.1284666+02:00",
  "PublishFrom": "2016-02-08T04:02:02.1284666+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 569,
  "Name": "Lesch LLC",
  "ProjectNumber": "394877",
  "ProjectMembers": [
    {
      "ProjectmemberId": 75,
      "ContactId": 677,
      "ProjectId": 155,
      "ContactName": "Hintz-Hayes",
      "ContactDepartment": "",
      "ProjectName": "Hermann-Ernser",
      "EmailId": 738,
      "EmailAddress": "telly_breitenberg@mcclure.biz",
      "CountryId": 998,
      "Firstname": "Giles",
      "MiddleName": "Fisher LLC",
      "Lastname": "Schaefer",
      "PersonId": 718,
      "Mrmrs": "facilis",
      "ProjectMemberTypeName": "Anderson, Murray and Dietrich",
      "Phone": "617-496-6426 x043",
      "PhoneId": 542,
      "ProjectMemberTypeId": 853,
      "EmailAddressName": "joelle@heathcotekunde.name",
      "Comment": "consequatur",
      "FullName": "Gilda Ritchie PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "porro",
      "StrippedValue": "voluptates",
      "Description": "Optional tertiary functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "voluptates",
      "Description": "Optional tertiary functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    }
  ],
  "CreatedDate": "2000-08-03T04:02:02.1440899+02:00",
  "UpdatedDate": "2021-11-08T04:02:02.1440899+01:00",
  "Description": "Re-engineered user-facing hardware",
  "Postit": "est",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Synergized encompassing moderator",
  "ActiveStatusMonitorId": 278,
  "Links": [
    {
      "EntityName": "McDermott LLC",
      "Id": 482,
      "Description": "Extended bifurcated implementation",
      "ExtraInfo": "ratione",
      "LinkId": 651,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    }
  ],
  "ActiveLinks": 193,
  "Completed": false,
  "NextMilestoneDate": "1998-01-11T04:02:02.1440899+01:00",
  "NmdAppointmentId": 627,
  "EndDate": "2012-09-09T04:02:02.1440899+02:00",
  "ActiveErpLinks": 703,
  "UserDefinedFields": {
    "SuperOffice:1": "1373636120",
    "SuperOffice:2": "350124040"
  },
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "atque",
    "CustomFields2": "placeat"
  },
  "PublishEventDate": "2005-12-05T04:02:02.1440899+01:00",
  "PublishTo": "2020-09-10T04:02:02.1440899+02:00",
  "PublishFrom": "2004-02-15T04:02:02.1440899+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 405
    }
  }
}
```