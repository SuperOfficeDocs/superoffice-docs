---
title: GET Sale/default
id: v1SaleEntity_DefaultSaleEntity
---

# GET Sale/default

```http
GET /api/v1/Sale/default
```

Set default values into a new SaleEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Sale agent service CreateDefaultSaleEntity.






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

Partial SaleEntity class associating the generated SaleEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
GET /api/v1/Sale/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 26 Oct 2007 15:05:42 G10T

{
  "Appointment": {
    "AppointmentId": 387,
    "StartDate": "1995-03-29T15:05:42.583635+02:00",
    "EndDate": "2010-03-07T15:05:42.583635+01:00",
    "Type": "BookingForChecklist",
    "Task": "quod",
    "AssociateFullName": "Osvaldo Ullrich",
    "ContactName": "Swaniawski LLC",
    "Description": "Open-architected systematic encoding",
    "PersonFullName": "Benjamin Smitham",
    "PersonId": 885,
    "ContactId": 672,
    "ProjectId": 519,
    "ProjectName": "Ratke, Quitzon and Champlin",
    "IsPublished": true,
    "AssociateId": 666,
    "ColorIndex": 462,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 950,
    "PriorityName": "Ankunding, Rohan and Ratke",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "1994-11-05T15:05:42.583635+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2021-08-21T15:05:42.583635+02:00",
    "RecurringEndDate": "1995-06-20T15:05:42.583635+02:00",
    "MotherId": 887,
    "AssignedBy": 910,
    "AssignedByFullName": "Kathleen Romaguera DDS",
    "RejectReason": "",
    "Location": "impedit",
    "AlarmLeadTime": "est",
    "SaleId": 76,
    "SaleName": "Collins-Connelly",
    "AssociateName": "Quitzon LLC",
    "CreatedDate": "2003-07-29T15:05:42.584635+02:00",
    "CreatedBy": "perspiciatis",
    "CreatedByFullName": "Weldon Davis",
    "CreatedByAssociateId": 351,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 435
      }
    }
  },
  "Associate": {
    "AssociateId": 846,
    "Name": "Ondricka LLC",
    "PersonId": 761,
    "Rank": 860,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 107,
    "FullName": "Jessie Abshire",
    "FormalName": "Altenwerth LLC",
    "Deleted": true,
    "EjUserId": 844,
    "UserName": "Ziemann, Mante and Pagac",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synergize compelling experiences"
        },
        "FieldType": "System.Int32",
        "FieldLength": 202
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 811,
    "Name": "Spencer LLC",
    "PersonId": 277,
    "Rank": 132,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 379,
    "FullName": "Carrie Boyer",
    "FormalName": "Lueilwitz-Koepp",
    "Deleted": true,
    "EjUserId": 920,
    "UserName": "D'Amore, Towne and Nienow",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 867
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 167,
    "Name": "Kutch, Bosco and Schmeler",
    "PersonId": 926,
    "Rank": 849,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 538,
    "FullName": "Morgan Balistreri",
    "FormalName": "Beatty, Huels and Koepp",
    "Deleted": false,
    "EjUserId": 834,
    "UserName": "Gislason-Strosin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 118
      }
    }
  },
  "Contact": {
    "ContactId": 839,
    "Name": "D'Amore LLC",
    "OrgNr": "1696785",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dignissimos",
    "DirectPhone": "1-753-260-5801 x74722",
    "AssociateId": 457,
    "CountryId": 876,
    "EmailAddress": "stella@schoen.info",
    "Kananame": "aut",
    "EmailAddressName": "cory@parisianbrekke.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mrs. Bryon Marvin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ipsum",
    "FullName": "Parker Feest",
    "IsOwnerContact": true,
    "ActiveErpLinks": 769,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 342
      }
    }
  },
  "Project": {
    "ProjectId": 472,
    "Name": "Green, Jacobi and Wisoky",
    "Description": "Advanced actuating hardware",
    "URL": "http://www.example.com/",
    "Type": "sunt",
    "AssociateId": 826,
    "AssociateFullName": "Ellsworth McCullough",
    "TypeId": 820,
    "Updated": "2013-08-31T15:05:42.5866353+02:00",
    "StatusId": 248,
    "Status": "accusamus",
    "TextId": 730,
    "PublishTo": "2014-06-06T15:05:42.5866353+02:00",
    "PublishFrom": "2002-07-31T15:05:42.5866353+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "627491",
    "ActiveErpLinks": 359,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 41
      }
    }
  },
  "SaleText": "ut",
  "Person": {
    "Position": "libero",
    "PersonId": 632,
    "Mrmrs": "vitae",
    "Firstname": "Earnestine",
    "Lastname": "Connelly",
    "MiddleName": "Zieme Group",
    "Title": "atque",
    "Description": "Business-focused modular conglomeration",
    "Email": "hayley@leannon.ca",
    "FullName": "Miss Devante West",
    "DirectPhone": "1-533-505-8058",
    "FormalName": "Ebert-Wintheiser",
    "CountryId": 850,
    "ContactId": 566,
    "ContactName": "Klocko, O'Hara and Dibbert",
    "Retired": 284,
    "Rank": 660,
    "ActiveInterests": 146,
    "ContactDepartment": "",
    "ContactCountryId": 248,
    "ContactOrgNr": "1414485",
    "FaxPhone": "875.701.1485",
    "MobilePhone": "871.552.7653",
    "ContactPhone": "751-054-4016 x440",
    "AssociateName": "Baumbach Inc and Sons",
    "AssociateId": 515,
    "UsePersonAddress": true,
    "ContactFax": "voluptatem",
    "Kanafname": "dolores",
    "Kanalname": "libero",
    "Post1": "qui",
    "Post2": "similique",
    "Post3": "commodi",
    "EmailName": "vida@kulas.biz",
    "ContactFullName": "Jaren Quitzon",
    "ActiveErpLinks": 67,
    "TicketPriorityId": 884,
    "SupportLanguageId": 444,
    "SupportAssociateId": 473,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 383
      }
    }
  },
  "Currency": {
    "Id": 536,
    "Value": "consequatur",
    "Tooltip": "possimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 351
      }
    }
  },
  "Competitor": {
    "Id": 455,
    "Value": "occaecati",
    "Tooltip": "eveniet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 580
      }
    }
  },
  "Credited": {
    "Id": 689,
    "Value": "nesciunt",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 253
      }
    }
  },
  "Rating": {
    "Id": 791,
    "Value": "quibusdam",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 993
      }
    }
  },
  "Reason": {
    "Id": 999,
    "Value": "sed",
    "Tooltip": "maxime",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 210
      }
    }
  },
  "Source": {
    "Id": 957,
    "Value": "dolorem",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 621
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2008-11-30T15:05:42.5886348+01:00",
  "Amount": 24949.773999999998,
  "SaleId": 805,
  "Earning": 990.34399999999994,
  "EarningPercent": 20991.532,
  "Heading": "sapiente",
  "Number": "589728",
  "Probability": 232,
  "CreatedDate": "1999-05-10T15:05:42.5886348+02:00",
  "UpdatedDate": "2007-10-26T15:05:42.5886348+02:00",
  "Completed": "Completed",
  "ActiveLinks": 867,
  "Links": [
    {
      "EntityName": "Schiller, Wisoky and Hirthe",
      "Id": 44,
      "Description": "Right-sized systemic hierarchy",
      "ExtraInfo": "ex",
      "LinkId": 646,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "drive vertical applications"
          },
          "FieldType": "System.Int32",
          "FieldLength": 206
        }
      }
    }
  ],
  "NextDueDate": "2010-11-27T15:05:42.5886348+01:00",
  "Postit": "similique",
  "SaleType": {
    "Id": 196,
    "Value": "non",
    "Tooltip": "repellendus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 54
      }
    }
  },
  "ReasonSold": {
    "Id": 395,
    "Value": "quo",
    "Tooltip": "ratione",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 679
      }
    }
  },
  "ReasonStalled": {
    "Id": 854,
    "Value": "voluptatem",
    "Tooltip": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 193
      }
    }
  },
  "ReopenDate": "1994-05-15T15:05:42.5886348+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Swift, Monahan and Bruen",
      "Comment": "ullam",
      "StakeholderRoleId": 678,
      "CountryId": 599,
      "PersonId": 442,
      "EmailDescription": "deshawn_monahan@balistreriwindler.com",
      "EmailId": 26,
      "EmailAddress": "lillian.thiel@ledner.ca",
      "PhoneId": 478,
      "ContactName": "Connelly, Miller and Anderson",
      "ContactId": 595,
      "SaleId": 259,
      "Mrmrs": "dolor",
      "Firstname": "Otis",
      "MiddleName": "Mante-Abernathy",
      "Lastname": "Koss",
      "SaleStakeholderId": 266,
      "Rank": 536,
      "Phone": "376-564-1885 x7700",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 201
        }
      }
    }
  ],
  "ActiveErpLinks": 851,
  "UserDefinedFields": {
    "SuperOffice:1": "Gilberto Herman DVM",
    "SuperOffice:2": "Jaclyn Sauer"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "saepe"
  },
  "PublishEventDate": "2000-03-13T15:05:42.589635+01:00",
  "PublishTo": "2014-06-12T15:05:42.589635+02:00",
  "PublishFrom": "1995-09-22T15:05:42.589635+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 22,
      "Visibility": "All",
      "DisplayValue": "omnis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    },
    {
      "VisibleId": 22,
      "Visibility": "All",
      "DisplayValue": "omnis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 560
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
      "FieldLength": 177
    }
  }
}
```