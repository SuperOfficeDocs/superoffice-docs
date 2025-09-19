---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
content_type: reference
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ProjectEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 531,
  "Name": "Crooks-Koelpin",
  "ProjectNumber": "483304",
  "ProjectMembers": [
    {
      "ProjectmemberId": 273,
      "ContactId": 552,
      "ProjectId": 27,
      "ContactName": "Kunde, Hagenes and Lueilwitz",
      "ContactDepartment": "",
      "ProjectName": "Frami-Bartell",
      "EmailId": 158,
      "EmailAddress": "candice_fritsch@marquardthackett.co.uk",
      "CountryId": 144,
      "Firstname": "Roberto",
      "MiddleName": "Hickle, Kuhn and Feest",
      "Lastname": "Rice",
      "PersonId": 658,
      "Mrmrs": "nisi",
      "ProjectMemberTypeName": "Harvey-Yundt",
      "Phone": "1-935-750-1382",
      "PhoneId": 703,
      "ProjectMemberTypeId": 520,
      "EmailAddressName": "esta@thiel.biz",
      "Comment": "est",
      "FullName": "Ms. Vita Brennon Stokes II",
      "Registered": "2002-01-09T03:41:58.8555101+01:00",
      "Updated": "2000-09-06T03:41:58.8555101+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "maxime",
      "Description": "Switchable human-resource system engine"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "maxime",
      "Description": "Switchable human-resource system engine"
    }
  ],
  "CreatedDate": "2000-09-11T03:41:58.8555101+02:00",
  "UpdatedDate": "2013-01-31T03:41:58.8555101+01:00",
  "Description": "Cross-group 6th generation conglomeration",
  "Postit": "sint",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Programmable fault-tolerant methodology",
  "ActiveStatusMonitorId": 503,
  "Links": [
    {
      "EntityName": "Luettgen, Zemlak and Dach",
      "Id": 907,
      "Description": "Down-sized maximized complexity",
      "ExtraInfo": "sint",
      "LinkId": 261
    },
    {
      "EntityName": "Luettgen, Zemlak and Dach",
      "Id": 907,
      "Description": "Down-sized maximized complexity",
      "ExtraInfo": "sint",
      "LinkId": 261
    }
  ],
  "ActiveLinks": 970,
  "Completed": false,
  "NextMilestoneDate": "2007-10-04T03:41:58.8555101+02:00",
  "NmdAppointmentId": 526,
  "EndDate": "2016-02-27T03:41:58.8555101+01:00",
  "ActiveErpLinks": 604,
  "UserDefinedFields": {
    "SuperOffice:1": "Derrick Mayer PhD",
    "SuperOffice:2": "361942057"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2017-08-22T03:41:58.8555101+02:00",
  "PublishTo": "2010-10-02T03:41:58.8555101+02:00",
  "PublishFrom": "2020-11-09T03:41:58.8555101+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 350,
  "Name": "Block LLC",
  "ProjectNumber": "436671",
  "ProjectMembers": [
    {
      "ProjectmemberId": 377,
      "ContactId": 546,
      "ProjectId": 635,
      "ContactName": "Leffler, Murazik and Haley",
      "ContactDepartment": "",
      "ProjectName": "Frami-Weimann",
      "EmailId": 541,
      "EmailAddress": "alverta.schmeler@glover.uk",
      "CountryId": 26,
      "Firstname": "Cicero",
      "MiddleName": "Douglas LLC",
      "Lastname": "O'Kon",
      "PersonId": 884,
      "Mrmrs": "atque",
      "ProjectMemberTypeName": "DuBuque Inc and Sons",
      "Phone": "771.751.1183",
      "PhoneId": 113,
      "ProjectMemberTypeId": 574,
      "EmailAddressName": "lennie.damore@torp.name",
      "Comment": "velit",
      "FullName": "Ismael Brekke",
      "Registered": "2006-06-30T03:41:58.8555101+02:00",
      "Updated": "2020-02-12T03:41:58.8555101+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 952
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "maxime",
      "Description": "Monitored discrete Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 730
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "maxime",
      "Description": "Monitored discrete Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 730
        }
      }
    }
  ],
  "CreatedDate": "1998-07-30T03:41:58.8555101+02:00",
  "UpdatedDate": "2004-06-30T03:41:58.8555101+02:00",
  "Description": "Future-proofed human-resource standardization",
  "Postit": "voluptatem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Universal encompassing pricing structure",
  "ActiveStatusMonitorId": 261,
  "Links": [
    {
      "EntityName": "Emard Inc and Sons",
      "Id": 612,
      "Description": "Focused tangible policy",
      "ExtraInfo": "nihil",
      "LinkId": 538,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 509
        }
      }
    }
  ],
  "ActiveLinks": 211,
  "Completed": false,
  "NextMilestoneDate": "2018-01-26T03:41:58.8711341+01:00",
  "NmdAppointmentId": 557,
  "EndDate": "2003-11-24T03:41:58.8711341+01:00",
  "ActiveErpLinks": 523,
  "UserDefinedFields": {
    "SuperOffice:1": "Macie Hardy Becker PhD",
    "SuperOffice:2": "2132200955"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "enim"
  },
  "PublishEventDate": "2004-07-31T03:41:58.886754+02:00",
  "PublishTo": "2008-12-08T03:41:58.886754+01:00",
  "PublishFrom": "2011-07-15T03:41:58.886754+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 618
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```