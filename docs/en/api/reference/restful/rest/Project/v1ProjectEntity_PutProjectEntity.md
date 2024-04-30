---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 779,
  "Name": "Hand, Weimann and Keebler",
  "ProjectNumber": "1084958",
  "ProjectMembers": [
    {
      "ProjectmemberId": 745,
      "ContactId": 211,
      "ProjectId": 590,
      "ContactName": "Lowe, Blanda and Barrows",
      "ContactDepartment": "",
      "ProjectName": "Rodriguez Group",
      "EmailId": 567,
      "EmailAddress": "jeromy@mcdermott.biz",
      "CountryId": 948,
      "Firstname": "Haylee",
      "MiddleName": "Herman Inc and Sons",
      "Lastname": "Morissette",
      "PersonId": 815,
      "Mrmrs": "fugit",
      "ProjectMemberTypeName": "Wuckert-Jacobson",
      "Phone": "952.825.3265",
      "PhoneId": 942,
      "ProjectMemberTypeId": 273,
      "EmailAddressName": "brandt.schultz@lakinroob.co.uk",
      "Comment": "aut",
      "FullName": "Ms. Maya Freeman Jerde"
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "consectetur",
      "Description": "Exclusive impactful open architecture"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "consectetur",
      "Description": "Exclusive impactful open architecture"
    }
  ],
  "CreatedDate": "2002-07-24T11:44:42.1639363+02:00",
  "UpdatedDate": "2001-08-16T11:44:42.1639363+02:00",
  "Description": "Re-engineered coherent hardware",
  "Postit": "aspernatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Fully-configurable neutral circuit",
  "ActiveStatusMonitorId": 592,
  "Links": [
    {
      "EntityName": "Schoen Inc and Sons",
      "Id": 673,
      "Description": "Profound mission-critical projection",
      "ExtraInfo": "perspiciatis",
      "LinkId": 930
    },
    {
      "EntityName": "Schoen Inc and Sons",
      "Id": 673,
      "Description": "Profound mission-critical projection",
      "ExtraInfo": "perspiciatis",
      "LinkId": 930
    }
  ],
  "ActiveLinks": 395,
  "Completed": false,
  "NextMilestoneDate": "2012-02-12T11:44:42.1639363+01:00",
  "NmdAppointmentId": 732,
  "EndDate": "1998-01-22T11:44:42.1639363+01:00",
  "ActiveErpLinks": 134,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "956275405"
  },
  "ExtraFields": {
    "ExtraFields1": "vitae",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "sunt"
  },
  "PublishEventDate": "2006-03-27T11:44:42.1639363+02:00",
  "PublishTo": "2022-05-11T11:44:42.1639363+02:00",
  "PublishFrom": "2018-12-07T11:44:42.1639363+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 576,
  "Name": "Littel Inc and Sons",
  "ProjectNumber": "547508",
  "ProjectMembers": [
    {
      "ProjectmemberId": 928,
      "ContactId": 852,
      "ProjectId": 609,
      "ContactName": "Ebert Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Blanda Inc and Sons",
      "EmailId": 771,
      "EmailAddress": "raheem_douglas@walter.com",
      "CountryId": 38,
      "Firstname": "Trudie",
      "MiddleName": "Spinka-Carter",
      "Lastname": "Trantow",
      "PersonId": 756,
      "Mrmrs": "voluptatem",
      "ProjectMemberTypeName": "Ruecker-Swaniawski",
      "Phone": "462-622-4696",
      "PhoneId": 972,
      "ProjectMemberTypeId": 448,
      "EmailAddressName": "elissa.barrows@langwalter.biz",
      "Comment": "distinctio",
      "FullName": "Abigale Feeney",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 755
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "animi",
      "StrippedValue": "repellendus",
      "Description": "Digitized 4th generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 802
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "repellendus",
      "Description": "Digitized 4th generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 802
        }
      }
    }
  ],
  "CreatedDate": "2006-05-11T11:44:42.1639363+02:00",
  "UpdatedDate": "2010-10-02T11:44:42.1639363+02:00",
  "Description": "Front-line local array",
  "Postit": "ut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Profound bifurcated methodology",
  "ActiveStatusMonitorId": 523,
  "Links": [
    {
      "EntityName": "Heathcote-Daniel",
      "Id": 924,
      "Description": "Versatile 3rd generation monitoring",
      "ExtraInfo": "et",
      "LinkId": 859,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 204
        }
      }
    }
  ],
  "ActiveLinks": 460,
  "Completed": true,
  "NextMilestoneDate": "1997-02-15T11:44:42.1639363+01:00",
  "NmdAppointmentId": 747,
  "EndDate": "2010-09-06T11:44:42.1639363+02:00",
  "ActiveErpLinks": 742,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Christina Herta Lubowitz IV",
    "SuperOffice:2": "Eloy Lebsack"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "rem"
  },
  "PublishEventDate": "2014-05-17T11:44:42.1795559+02:00",
  "PublishTo": "2003-05-18T11:44:42.1795559+02:00",
  "PublishFrom": "2023-12-28T11:44:42.1795559+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 41
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```