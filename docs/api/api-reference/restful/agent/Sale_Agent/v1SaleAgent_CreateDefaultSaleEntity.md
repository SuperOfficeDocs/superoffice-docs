---
title: POST Agents/Sale/CreateDefaultSaleEntity
id: v1SaleAgent_CreateDefaultSaleEntity
---

# POST Agents/Sale/CreateDefaultSaleEntity

```http
POST /api/v1/Agents/Sale/CreateDefaultSaleEntity
```

Set default values into a new SaleEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Sale/CreateDefaultSaleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 786,
    "StartDate": "2013-12-11T16:48:30.5149395+01:00",
    "EndDate": "1994-06-12T16:48:30.5149395+02:00",
    "Type": "BookingForChecklist",
    "Task": "ut",
    "AssociateFullName": "Gretchen Bode",
    "ContactName": "Heathcote-Ledner",
    "Description": "Total assymetric hierarchy",
    "PersonFullName": "Emelie Fahey",
    "PersonId": 823,
    "ContactId": 670,
    "ProjectId": 849,
    "ProjectName": "Lockman Inc and Sons",
    "IsPublished": false,
    "AssociateId": 230,
    "ColorIndex": 146,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 995,
    "PriorityName": "Kautzer-Leuschke",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2000-01-03T16:48:30.5149395+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2005-07-11T16:48:30.5149395+02:00",
    "RecurringEndDate": "1994-04-05T16:48:30.5149395+02:00",
    "MotherId": 449,
    "AssignedBy": 857,
    "AssignedByFullName": "Ariel Tromp",
    "RejectReason": "",
    "Location": "qui",
    "AlarmLeadTime": "porro",
    "SaleId": 936,
    "SaleName": "Jaskolski-Doyle",
    "AssociateName": "Rice, Halvorson and Conroy",
    "CreatedDate": "2011-08-05T16:48:30.5149395+02:00",
    "CreatedBy": "praesentium",
    "CreatedByFullName": "Laney Stamm",
    "CreatedByAssociateId": 116,
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
        "FieldLength": 963
      }
    }
  },
  "Associate": {
    "AssociateId": 26,
    "Name": "Hilpert Inc and Sons",
    "PersonId": 699,
    "Rank": 747,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 247,
    "FullName": "Miss Taya Conn",
    "FormalName": "Mitchell, Nienow and Marks",
    "Deleted": true,
    "EjUserId": 176,
    "UserName": "Hoppe, Leuschke and Lakin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 921
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 966,
    "Name": "Prosacco, O'Conner and Tillman",
    "PersonId": 664,
    "Rank": 693,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 509,
    "FullName": "Dr. Lorena Powlowski",
    "FormalName": "Bahringer Group",
    "Deleted": false,
    "EjUserId": 455,
    "UserName": "Lakin LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 82
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 642,
    "Name": "Stoltenberg-Raynor",
    "PersonId": 797,
    "Rank": 483,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 544,
    "FullName": "Modesto Fritsch",
    "FormalName": "Will-Hoeger",
    "Deleted": true,
    "EjUserId": 65,
    "UserName": "Hayes Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 674
      }
    }
  },
  "Contact": {
    "ContactId": 273,
    "Name": "Schroeder, Klein and Davis",
    "OrgNr": "1209488",
    "Department": "incubate proactive initiatives",
    "URL": "http://www.example.com/",
    "City": "ducimus",
    "DirectPhone": "1-578-855-1301 x1035",
    "AssociateId": 425,
    "CountryId": 834,
    "EmailAddress": "chaya.beahan@osinskidach.us",
    "Kananame": "ipsam",
    "EmailAddressName": "lempi@huels.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Janet Kub",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quisquam",
    "FullName": "Ryan Littel",
    "IsOwnerContact": false,
    "ActiveErpLinks": 805,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 817
      }
    }
  },
  "Project": {
    "ProjectId": 359,
    "Name": "Rohan, Bradtke and Zemlak",
    "Description": "Visionary foreground collaboration",
    "URL": "http://www.example.com/",
    "Type": "nobis",
    "AssociateId": 649,
    "AssociateFullName": "Delpha Erdman",
    "TypeId": 523,
    "Updated": "2001-11-10T16:48:30.5199405+01:00",
    "StatusId": 613,
    "Status": "aut",
    "TextId": 42,
    "PublishTo": "2019-08-08T16:48:30.5199405+02:00",
    "PublishFrom": "2016-12-27T16:48:30.5199405+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "729669",
    "ActiveErpLinks": 311,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 869
      }
    }
  },
  "SaleText": "earum",
  "Person": {
    "Position": "et",
    "PersonId": 54,
    "Mrmrs": "et",
    "Firstname": "Eleanore",
    "Lastname": "Schimmel",
    "MiddleName": "Murazik Inc and Sons",
    "Title": "et",
    "Description": "Public-key discrete middleware",
    "Email": "alayna.dickinson@eichmann.info",
    "FullName": "Nikolas Fritsch PhD",
    "DirectPhone": "(485)016-8615 x7250",
    "FormalName": "Tremblay-McGlynn",
    "CountryId": 135,
    "ContactId": 813,
    "ContactName": "Pollich, Thiel and Kreiger",
    "Retired": 446,
    "Rank": 677,
    "ActiveInterests": 220,
    "ContactDepartment": "",
    "ContactCountryId": 359,
    "ContactOrgNr": "1593420",
    "FaxPhone": "631.565.4582",
    "MobilePhone": "(433)761-5755 x38853",
    "ContactPhone": "1-388-502-4184",
    "AssociateName": "Parisian-Grant",
    "AssociateId": 56,
    "UsePersonAddress": false,
    "ContactFax": "harum",
    "Kanafname": "voluptate",
    "Kanalname": "quae",
    "Post1": "et",
    "Post2": "optio",
    "Post3": "ut",
    "EmailName": "daphnee.carter@hahn.biz",
    "ContactFullName": "Miss Sam Cremin",
    "ActiveErpLinks": 956,
    "TicketPriorityId": 283,
    "SupportLanguageId": 985,
    "SupportAssociateId": 258,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 562
      }
    }
  },
  "Currency": {
    "Id": 121,
    "Value": "ullam",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 457
      }
    }
  },
  "Competitor": {
    "Id": 383,
    "Value": "quia",
    "Tooltip": "non",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 541
      }
    }
  },
  "Credited": {
    "Id": 369,
    "Value": "aut",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 114
      }
    }
  },
  "Rating": {
    "Id": 766,
    "Value": "et",
    "Tooltip": "porro",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 620
      }
    }
  },
  "Reason": {
    "Id": 193,
    "Value": "autem",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 728
      }
    }
  },
  "Source": {
    "Id": 742,
    "Value": "accusantium",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "maximize integrated bandwidth"
        },
        "FieldType": "System.Int32",
        "FieldLength": 791
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2015-04-10T16:48:30.5219394+02:00",
  "Amount": 29017.706,
  "SaleId": 239,
  "Earning": 9477.216,
  "EarningPercent": 23216.672,
  "Heading": "velit",
  "Number": "1037069",
  "Probability": 409,
  "CreatedDate": "2007-01-02T16:48:30.5219394+01:00",
  "UpdatedDate": "2013-11-01T16:48:30.5219394+01:00",
  "Completed": "Completed",
  "ActiveLinks": 398,
  "Links": [
    {
      "EntityName": "Jacobson, Hickle and Gislason",
      "Id": 615,
      "Description": "Distributed content-based conglomeration",
      "ExtraInfo": "dicta",
      "LinkId": 374,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 105
        }
      }
    }
  ],
  "NextDueDate": "2006-09-02T16:48:30.5219394+02:00",
  "Postit": "quia",
  "SaleType": {
    "Id": 830,
    "Value": "qui",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 216
      }
    }
  },
  "ReasonSold": {
    "Id": 505,
    "Value": "distinctio",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 211
      }
    }
  },
  "ReasonStalled": {
    "Id": 413,
    "Value": "tempore",
    "Tooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 932
      }
    }
  },
  "ReopenDate": "2007-05-11T16:48:30.5219394+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Lebsack, Carter and Goyette",
      "Comment": "in",
      "StakeholderRoleId": 443,
      "CountryId": 351,
      "PersonId": 669,
      "EmailDescription": "marianna.howell@wuckertrippin.us",
      "EmailId": 525,
      "EmailAddress": "delta_schulist@trantowcartwright.ca",
      "PhoneId": 450,
      "ContactName": "Runolfsson Group",
      "ContactId": 127,
      "SaleId": 577,
      "Mrmrs": "consequatur",
      "Firstname": "Brain",
      "MiddleName": "Homenick, Nolan and Franecki",
      "Lastname": "Brekke",
      "SaleStakeholderId": 682,
      "Rank": 27,
      "Phone": "(441)005-3615 x65082",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    }
  ],
  "ActiveErpLinks": 584,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Alaina Kris",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "rem",
    "ExtraFields2": "fugiat"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "hic"
  },
  "PublishEventDate": "2006-02-15T16:48:30.5719252+01:00",
  "PublishTo": "2010-10-09T16:48:30.5719252+02:00",
  "PublishFrom": "2004-03-30T16:48:30.5719252+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 11,
      "Visibility": "All",
      "DisplayValue": "excepturi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 159
        }
      }
    },
    {
      "VisibleId": 11,
      "Visibility": "All",
      "DisplayValue": "excepturi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 159
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
      "FieldLength": 910
    }
  }
}
```