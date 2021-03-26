---
title: PUT Project/{id}
id: v1ProjectEntity_PutProjectEntity
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
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |


## Response: object

The Project Service. The service implements all services working with the Project object



ProjectEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 469,
  "Name": "Reichert, Streich and Beatty",
  "ProjectNumber": "1773033",
  "ProjectMembers": [
    {
      "ProjectmemberId": 85,
      "ContactId": 565,
      "ProjectId": 785,
      "ContactName": "D'Amore-Lesch",
      "ContactDepartment": "",
      "ProjectName": "Herman-Nader",
      "EmailId": 130,
      "EmailAddress": "sydni@cronin.com",
      "CountryId": 698,
      "Firstname": "Paula",
      "MiddleName": "Abernathy Inc and Sons",
      "Lastname": "Kozey",
      "PersonId": 664,
      "Mrmrs": "ex",
      "ProjectMemberTypeName": "Shields LLC",
      "Phone": "1-033-072-7541 x24704",
      "PhoneId": 102,
      "ProjectMemberTypeId": 257,
      "EmailAddressName": "elouise_ledner@gerhold.info",
      "Comment": "dicta",
      "FullName": "Miss Rebeca Labadie"
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "animi",
      "Description": "Reactive real-time protocol"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "animi",
      "Description": "Reactive real-time protocol"
    }
  ],
  "CreatedDate": "2015-08-27T09:40:59.462663+02:00",
  "UpdatedDate": "1998-01-28T09:40:59.462663+01:00",
  "Description": "Ameliorated maximized concept",
  "Postit": "sit",
  "CreatedBy": {
    "AssociateId": 551,
    "Name": "Keebler-Dare",
    "PersonId": 683,
    "Rank": 100,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 390,
    "FullName": "Carter Nitzsche",
    "FormalName": "Baumbach Inc and Sons",
    "Deleted": false,
    "EjUserId": 940,
    "UserName": "Pagac, Sipes and Ondricka"
  },
  "UpdatedBy": {
    "AssociateId": 359,
    "Name": "Satterfield-Hauck",
    "PersonId": 444,
    "Rank": 516,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 966,
    "FullName": "Marquise Gibson",
    "FormalName": "O'Kon-Welch",
    "Deleted": false,
    "EjUserId": 721,
    "UserName": "Tillman Inc and Sons"
  },
  "Associate": {
    "AssociateId": 53,
    "Name": "Lindgren, Cartwright and Legros",
    "PersonId": 161,
    "Rank": 621,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 929,
    "FullName": "Shea Bradtke DVM",
    "FormalName": "Heaney-O'Kon",
    "Deleted": false,
    "EjUserId": 58,
    "UserName": "Klein-Tromp"
  },
  "ProjectStatus": {
    "Id": 511,
    "Value": "sit",
    "Tooltip": "similique"
  },
  "ProjectType": {
    "Id": 761,
    "Value": "tenetur",
    "Tooltip": "hic"
  },
  "HasImage": true,
  "ImageDescription": "Front-line next generation core",
  "ActiveStatusMonitorId": 219,
  "Links": [
    {
      "EntityName": "Herman, Spinka and O'Hara",
      "Id": 283,
      "Description": "Mandatory object-oriented installation",
      "ExtraInfo": "ut",
      "LinkId": 670
    },
    {
      "EntityName": "Herman, Spinka and O'Hara",
      "Id": 283,
      "Description": "Mandatory object-oriented installation",
      "ExtraInfo": "ut",
      "LinkId": 670
    }
  ],
  "ActiveLinks": 548,
  "Completed": false,
  "NextMilestoneDate": "2019-07-05T09:40:59.4646627+02:00",
  "NmdAppointmentId": 401,
  "EndDate": "1998-08-01T09:40:59.4646627+02:00",
  "ActiveErpLinks": 626,
  "UserDefinedFields": {
    "SuperOffice:1": "1802580322",
    "SuperOffice:2": "Jazmyn Bechtelar"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "ducimus"
  },
  "CustomFields": {
    "CustomFields1": "odio",
    "CustomFields2": "veniam"
  },
  "PublishEventDate": "2016-10-28T09:40:59.4646627+02:00",
  "PublishTo": "2017-10-17T09:40:59.4646627+02:00",
  "PublishFrom": "2000-11-08T09:40:59.4646627+01:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 431,
  "Name": "Will-Rosenbaum",
  "ProjectNumber": "1288707",
  "ProjectMembers": [
    {
      "ProjectmemberId": 877,
      "ContactId": 101,
      "ProjectId": 889,
      "ContactName": "Smitham Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Ryan-Anderson",
      "EmailId": 197,
      "EmailAddress": "jonathan@hickle.info",
      "CountryId": 744,
      "Firstname": "Everardo",
      "MiddleName": "Brekke, Schamberger and Williamson",
      "Lastname": "Hilpert",
      "PersonId": 987,
      "Mrmrs": "provident",
      "ProjectMemberTypeName": "Leannon-Stanton",
      "Phone": "(383)675-4682 x4612",
      "PhoneId": 273,
      "ProjectMemberTypeId": 540,
      "EmailAddressName": "katheryn.dickinson@collier.info",
      "Comment": "non",
      "FullName": "Rubie Toy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "quam",
      "Description": "Persistent 3rd generation definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "quam",
      "Description": "Persistent 3rd generation definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    }
  ],
  "CreatedDate": "2004-07-13T09:40:59.4696629+02:00",
  "UpdatedDate": "2020-08-31T09:40:59.4696629+02:00",
  "Description": "Robust analyzing paradigm",
  "Postit": "natus",
  "CreatedBy": {
    "AssociateId": 104,
    "Name": "O'Keefe Group",
    "PersonId": 214,
    "Rank": 803,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 982,
    "FullName": "Otha Mertz",
    "FormalName": "Frami-Mohr",
    "Deleted": false,
    "EjUserId": 509,
    "UserName": "Carter, Hodkiewicz and Ledner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 688
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 726,
    "Name": "Grant Inc and Sons",
    "PersonId": 586,
    "Rank": 142,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 157,
    "FullName": "Rosanna Mayert",
    "FormalName": "Simonis, Christiansen and Botsford",
    "Deleted": true,
    "EjUserId": 550,
    "UserName": "Stark Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 567
      }
    }
  },
  "Associate": {
    "AssociateId": 31,
    "Name": "Davis-Marvin",
    "PersonId": 946,
    "Rank": 694,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 433,
    "FullName": "Opal Huels IV",
    "FormalName": "Stehr-Ward",
    "Deleted": true,
    "EjUserId": 103,
    "UserName": "Ward, Treutel and Grant",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 417
      }
    }
  },
  "ProjectStatus": {
    "Id": 665,
    "Value": "rerum",
    "Tooltip": "officiis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 510
      }
    }
  },
  "ProjectType": {
    "Id": 562,
    "Value": "non",
    "Tooltip": "consequuntur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 957
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Total 24 hour model",
  "ActiveStatusMonitorId": 999,
  "Links": [
    {
      "EntityName": "Goldner, Hagenes and Goodwin",
      "Id": 638,
      "Description": "Customer-focused encompassing task-force",
      "ExtraInfo": "vitae",
      "LinkId": 279,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    }
  ],
  "ActiveLinks": 302,
  "Completed": false,
  "NextMilestoneDate": "2010-12-04T09:40:59.4706626+01:00",
  "NmdAppointmentId": 431,
  "EndDate": "2017-08-09T09:40:59.4706626+02:00",
  "ActiveErpLinks": 295,
  "UserDefinedFields": {
    "SuperOffice:1": "Maximo Terry",
    "SuperOffice:2": "Bertrand Windler"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "error",
    "CustomFields2": "eum"
  },
  "PublishEventDate": "1994-06-16T09:40:59.4716625+02:00",
  "PublishTo": "2016-09-16T09:40:59.4716625+02:00",
  "PublishFrom": "2004-01-25T09:40:59.4716625+01:00",
  "IsPublished": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 763
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```