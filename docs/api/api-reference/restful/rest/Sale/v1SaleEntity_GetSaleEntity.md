---
title: GET Sale/{id}
id: v1SaleEntity_GetSaleEntity
---

# GET Sale/{id}

```http
GET /api/v1/Sale/{id}
```

Gets a SaleEntity object.

Calls the Sale agent service GetSaleEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the SaleEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Sale/{id}?$select=name,department,category/id
GET /api/v1/Sale/{id}?fk=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity found. |
| 304 | SaleEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
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
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 SaleEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 04 Mar 1996 09:40:59 G3T

{
  "Appointment": {
    "AppointmentId": 512,
    "StartDate": "2010-09-18T09:40:59.6076628+02:00",
    "EndDate": "2004-11-18T09:40:59.6076628+01:00",
    "Type": "BookingForChecklist",
    "Task": "veritatis",
    "AssociateFullName": "Grady Nienow",
    "ContactName": "Wilderman Group",
    "Description": "Compatible assymetric matrix",
    "PersonFullName": "Paige Lueilwitz",
    "PersonId": 403,
    "ContactId": 806,
    "ProjectId": 7,
    "ProjectName": "Yundt-Pollich",
    "IsPublished": false,
    "AssociateId": 557,
    "ColorIndex": 476,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 630,
    "PriorityName": "Anderson, Herzog and Blick",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2006-03-10T09:40:59.6086925+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2010-01-27T09:40:59.6086925+01:00",
    "RecurringEndDate": "2001-03-01T09:40:59.6086925+01:00",
    "MotherId": 323,
    "AssignedBy": 69,
    "AssignedByFullName": "Fannie Parisian",
    "RejectReason": "",
    "Location": "et",
    "AlarmLeadTime": "et",
    "SaleId": 178,
    "SaleName": "McGlynn Group",
    "AssociateName": "Heaney LLC",
    "CreatedDate": "2012-05-08T09:40:59.6086925+02:00",
    "CreatedBy": "vitae",
    "CreatedByFullName": "Josue Baumbach",
    "CreatedByAssociateId": 519,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 929
      }
    }
  },
  "Associate": {
    "AssociateId": 815,
    "Name": "Johns Inc and Sons",
    "PersonId": 743,
    "Rank": 130,
    "Tooltip": "voluptates",
    "Type": "AnonymousAssociate",
    "GroupIdx": 950,
    "FullName": "Yessenia Kertzmann MD",
    "FormalName": "Bosco-Bartell",
    "Deleted": false,
    "EjUserId": 746,
    "UserName": "Hammes Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 10
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 802,
    "Name": "Streich Inc and Sons",
    "PersonId": 627,
    "Rank": 383,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 827,
    "FullName": "Berry Stamm",
    "FormalName": "Goyette, Keebler and Wyman",
    "Deleted": true,
    "EjUserId": 824,
    "UserName": "Graham Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 297
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 513,
    "Name": "Moen Inc and Sons",
    "PersonId": 796,
    "Rank": 45,
    "Tooltip": "minus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 1001,
    "FullName": "Mrs. Enoch Rutherford",
    "FormalName": "Kihn-Bradtke",
    "Deleted": false,
    "EjUserId": 336,
    "UserName": "Veum, Bergstrom and Weimann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 555
      }
    }
  },
  "Contact": {
    "ContactId": 231,
    "Name": "Windler, Klocko and Kessler",
    "OrgNr": "1179671",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "iure",
    "DirectPhone": "1-062-132-3500 x576",
    "AssociateId": 917,
    "CountryId": 92,
    "EmailAddress": "gerald@haleyrau.us",
    "Kananame": "corrupti",
    "EmailAddressName": "addison.lind@kuhiczemlak.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Andy Macejkovic V",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "harum",
    "FullName": "Mikayla Okuneva",
    "IsOwnerContact": false,
    "ActiveErpLinks": 140,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 887
      }
    }
  },
  "Project": {
    "ProjectId": 226,
    "Name": "Heller-Lemke",
    "Description": "User-centric full-range toolset",
    "URL": "http://www.example.com/",
    "Type": "veniam",
    "AssociateId": 148,
    "AssociateFullName": "Maryjane Breitenberg DVM",
    "TypeId": 743,
    "Updated": "1999-10-31T09:40:59.6106934+01:00",
    "StatusId": 160,
    "Status": "ratione",
    "TextId": 488,
    "PublishTo": "1999-12-05T09:40:59.6106934+01:00",
    "PublishFrom": "2016-06-06T09:40:59.6106934+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1150792",
    "ActiveErpLinks": 588,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 119
      }
    }
  },
  "SaleText": "maiores",
  "Person": {
    "Position": "quia",
    "PersonId": 142,
    "Mrmrs": "aliquam",
    "Firstname": "Velma",
    "Lastname": "Bayer",
    "MiddleName": "Dicki-Howell",
    "Title": "rem",
    "Description": "Integrated value-added open architecture",
    "Email": "terrell_wuckert@herzog.co.uk",
    "FullName": "Shanie Stehr II",
    "DirectPhone": "(241)126-8764 x1062",
    "FormalName": "Tremblay-Senger",
    "CountryId": 77,
    "ContactId": 739,
    "ContactName": "Ziemann, Ritchie and Kuhlman",
    "Retired": 139,
    "Rank": 232,
    "ActiveInterests": 627,
    "ContactDepartment": "",
    "ContactCountryId": 17,
    "ContactOrgNr": "841658",
    "FaxPhone": "067.781.3126",
    "MobilePhone": "(116)767-6137 x14658",
    "ContactPhone": "856-868-1027",
    "AssociateName": "Kling-Satterfield",
    "AssociateId": 472,
    "UsePersonAddress": false,
    "ContactFax": "consectetur",
    "Kanafname": "error",
    "Kanalname": "commodi",
    "Post1": "recusandae",
    "Post2": "exercitationem",
    "Post3": "voluptas",
    "EmailName": "wilma.blick@wintheiser.uk",
    "ContactFullName": "Jimmie Ritchie",
    "ActiveErpLinks": 135,
    "TicketPriorityId": 182,
    "SupportLanguageId": 39,
    "SupportAssociateId": 672,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 265
      }
    }
  },
  "Currency": {
    "Id": 376,
    "Value": "rerum",
    "Tooltip": "ad",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 665
      }
    }
  },
  "Competitor": {
    "Id": 441,
    "Value": "est",
    "Tooltip": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 113
      }
    }
  },
  "Credited": {
    "Id": 813,
    "Value": "quos",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 976
      }
    }
  },
  "Rating": {
    "Id": 387,
    "Value": "eligendi",
    "Tooltip": "magni",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 378
      }
    }
  },
  "Reason": {
    "Id": 684,
    "Value": "rerum",
    "Tooltip": "exercitationem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 859
      }
    }
  },
  "Source": {
    "Id": 856,
    "Value": "ipsam",
    "Tooltip": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 269
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2002-06-22T09:40:59.6126944+02:00",
  "Amount": 29600.629999999997,
  "SaleId": 503,
  "Earning": 21079.284,
  "EarningPercent": 25739.541999999998,
  "Heading": "dolorum",
  "Number": "1383346",
  "Probability": 439,
  "CreatedDate": "2006-03-07T09:40:59.6126944+01:00",
  "UpdatedDate": "1996-03-04T09:40:59.6126944+01:00",
  "Completed": "Completed",
  "ActiveLinks": 256,
  "Links": [
    {
      "EntityName": "Ullrich Group",
      "Id": 166,
      "Description": "Function-based secondary complexity",
      "ExtraInfo": "voluptatibus",
      "LinkId": 527,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    }
  ],
  "NextDueDate": "1999-01-05T09:40:59.6126944+01:00",
  "Postit": "nam",
  "SaleType": {
    "Id": 142,
    "Value": "voluptatem",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 863
      }
    }
  },
  "ReasonSold": {
    "Id": 676,
    "Value": "blanditiis",
    "Tooltip": "nemo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 228
      }
    }
  },
  "ReasonStalled": {
    "Id": 542,
    "Value": "quia",
    "Tooltip": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 977
      }
    }
  },
  "ReopenDate": "2005-12-24T09:40:59.6126944+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Windler-Rohan",
      "Comment": "dolorem",
      "StakeholderRoleId": 775,
      "CountryId": 410,
      "PersonId": 452,
      "EmailDescription": "gavin@reilly.uk",
      "EmailId": 146,
      "EmailAddress": "rafael@emmerichdare.name",
      "PhoneId": 597,
      "ContactName": "Glover-Hirthe",
      "ContactId": 493,
      "SaleId": 481,
      "Mrmrs": "est",
      "Firstname": "Jackeline",
      "MiddleName": "DuBuque-Brown",
      "Lastname": "Pfeffer",
      "SaleStakeholderId": 901,
      "Rank": 925,
      "Phone": "(578)406-3751",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 616
        }
      }
    }
  ],
  "ActiveErpLinks": 568,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "229135735"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "iure"
  },
  "PublishEventDate": "2007-01-06T09:40:59.6136921+01:00",
  "PublishTo": "2021-02-14T09:40:59.6136921+01:00",
  "PublishFrom": "2011-09-06T09:40:59.6136921+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 222,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    },
    {
      "VisibleId": 222,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    }
  ],
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
      "FieldType": "System.Int32",
      "FieldLength": 713
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```