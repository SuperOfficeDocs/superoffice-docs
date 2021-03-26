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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 14 Aug 2009 09:40:59 G8T

{
  "Appointment": {
    "AppointmentId": 364,
    "StartDate": "2011-10-14T09:40:59.537663+02:00",
    "EndDate": "2005-06-05T09:40:59.537663+02:00",
    "Type": "BookingForChecklist",
    "Task": "molestiae",
    "AssociateFullName": "Reyes Krajcik",
    "ContactName": "Corwin, Harber and Ritchie",
    "Description": "Customer-focused stable core",
    "PersonFullName": "Stanford Homenick",
    "PersonId": 96,
    "ContactId": 585,
    "ProjectId": 473,
    "ProjectName": "Hoppe LLC",
    "IsPublished": true,
    "AssociateId": 698,
    "ColorIndex": 356,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 609,
    "PriorityName": "Cummings Inc and Sons",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "2020-04-22T09:40:59.5386628+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1998-07-05T09:40:59.5386628+02:00",
    "RecurringEndDate": "2002-09-12T09:40:59.5386628+02:00",
    "MotherId": 641,
    "AssignedBy": 758,
    "AssignedByFullName": "Herminia Senger",
    "RejectReason": "",
    "Location": "necessitatibus",
    "AlarmLeadTime": "consectetur",
    "SaleId": 542,
    "SaleName": "Farrell Inc and Sons",
    "AssociateName": "Macejkovic-Lakin",
    "CreatedDate": "1994-02-25T09:40:59.5386628+01:00",
    "CreatedBy": "quisquam",
    "CreatedByFullName": "Kade Fritsch",
    "CreatedByAssociateId": 763,
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
        "FieldLength": 568
      }
    }
  },
  "Associate": {
    "AssociateId": 433,
    "Name": "Nader-Murazik",
    "PersonId": 21,
    "Rank": 717,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 341,
    "FullName": "Leonardo Goodwin",
    "FormalName": "Schamberger, Langosh and Buckridge",
    "Deleted": true,
    "EjUserId": 859,
    "UserName": "Heaney Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 707
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 107,
    "Name": "Spinka-Treutel",
    "PersonId": 70,
    "Rank": 719,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 624,
    "FullName": "Litzy Durgan",
    "FormalName": "Collier-Friesen",
    "Deleted": false,
    "EjUserId": 652,
    "UserName": "Brown, Powlowski and Mante",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 356
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 205,
    "Name": "Ernser, Hilll and Robel",
    "PersonId": 431,
    "Rank": 519,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 472,
    "FullName": "Donald Bruen",
    "FormalName": "Wilderman Inc and Sons",
    "Deleted": true,
    "EjUserId": 609,
    "UserName": "Dicki-Huels",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synergize e-business e-tailers"
        },
        "FieldType": "System.String",
        "FieldLength": 11
      }
    }
  },
  "Contact": {
    "ContactId": 538,
    "Name": "Medhurst LLC",
    "OrgNr": "1226912",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "(408)717-6370 x64258",
    "AssociateId": 165,
    "CountryId": 809,
    "EmailAddress": "brayan_macejkovic@larkin.co.uk",
    "Kananame": "debitis",
    "EmailAddressName": "kayli@heaneystanton.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Breanne Hodkiewicz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "perspiciatis",
    "FullName": "Emelie Paucek",
    "IsOwnerContact": false,
    "ActiveErpLinks": 532,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 748
      }
    }
  },
  "Project": {
    "ProjectId": 956,
    "Name": "Lockman-Purdy",
    "Description": "Universal zero administration local area network",
    "URL": "http://www.example.com/",
    "Type": "ea",
    "AssociateId": 593,
    "AssociateFullName": "Oren Fritsch",
    "TypeId": 904,
    "Updated": "2014-05-11T09:40:59.5406625+02:00",
    "StatusId": 824,
    "Status": "nobis",
    "TextId": 896,
    "PublishTo": "1993-11-17T09:40:59.5406625+01:00",
    "PublishFrom": "2020-12-03T09:40:59.5406625+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1411378",
    "ActiveErpLinks": 264,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 766
      }
    }
  },
  "SaleText": "perspiciatis",
  "Person": {
    "Position": "ab",
    "PersonId": 175,
    "Mrmrs": "et",
    "Firstname": "Ada",
    "Lastname": "Trantow",
    "MiddleName": "Thiel-Weissnat",
    "Title": "est",
    "Description": "Seamless next generation process improvement",
    "Email": "hanna.wolf@granthilpert.co.uk",
    "FullName": "Irving Ankunding",
    "DirectPhone": "(381)246-0460 x8372",
    "FormalName": "Armstrong Inc and Sons",
    "CountryId": 47,
    "ContactId": 739,
    "ContactName": "Cronin, Kuhn and Kuhn",
    "Retired": 405,
    "Rank": 850,
    "ActiveInterests": 791,
    "ContactDepartment": "",
    "ContactCountryId": 261,
    "ContactOrgNr": "695680",
    "FaxPhone": "482-446-5306 x104",
    "MobilePhone": "010-038-6624 x836",
    "ContactPhone": "647-765-4447 x623",
    "AssociateName": "Rice-Ankunding",
    "AssociateId": 5,
    "UsePersonAddress": true,
    "ContactFax": "aut",
    "Kanafname": "harum",
    "Kanalname": "ut",
    "Post1": "veritatis",
    "Post2": "assumenda",
    "Post3": "quibusdam",
    "EmailName": "briana_ebert@kosswill.us",
    "ContactFullName": "Reed Walter",
    "ActiveErpLinks": 633,
    "TicketPriorityId": 665,
    "SupportLanguageId": 225,
    "SupportAssociateId": 295,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 973
      }
    }
  },
  "Currency": {
    "Id": 245,
    "Value": "et",
    "Tooltip": "dolor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate real-time interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 893
      }
    }
  },
  "Competitor": {
    "Id": 736,
    "Value": "cumque",
    "Tooltip": "mollitia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 266
      }
    }
  },
  "Credited": {
    "Id": 58,
    "Value": "aspernatur",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 944
      }
    }
  },
  "Rating": {
    "Id": 253,
    "Value": "eligendi",
    "Tooltip": "iure",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 188
      }
    }
  },
  "Reason": {
    "Id": 530,
    "Value": "quia",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 809
      }
    }
  },
  "Source": {
    "Id": 966,
    "Value": "optio",
    "Tooltip": "commodi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 790
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2017-01-14T09:40:59.5436911+01:00",
  "Amount": 23031.766,
  "SaleId": 552,
  "Earning": 5230.646,
  "EarningPercent": 12347.96,
  "Heading": "quia",
  "Number": "326607",
  "Probability": 938,
  "CreatedDate": "2009-04-28T09:40:59.5436911+02:00",
  "UpdatedDate": "2009-08-14T09:40:59.5436911+02:00",
  "Completed": "Completed",
  "ActiveLinks": 828,
  "Links": [
    {
      "EntityName": "Orn LLC",
      "Id": 145,
      "Description": "Profit-focused 4th generation function",
      "ExtraInfo": "at",
      "LinkId": 324,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 521
        }
      }
    }
  ],
  "NextDueDate": "2017-06-01T09:40:59.5436911+02:00",
  "Postit": "sunt",
  "SaleType": {
    "Id": 203,
    "Value": "mollitia",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 799
      }
    }
  },
  "ReasonSold": {
    "Id": 378,
    "Value": "minus",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 592
      }
    }
  },
  "ReasonStalled": {
    "Id": 697,
    "Value": "error",
    "Tooltip": "facere",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 230
      }
    }
  },
  "ReopenDate": "2016-10-01T09:40:59.5436911+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Hettinger Group",
      "Comment": "similique",
      "StakeholderRoleId": 848,
      "CountryId": 235,
      "PersonId": 940,
      "EmailDescription": "cornelius_pollich@jewess.biz",
      "EmailId": 800,
      "EmailAddress": "laverna_koelpin@hilpertward.uk",
      "PhoneId": 45,
      "ContactName": "Ondricka-Reynolds",
      "ContactId": 581,
      "SaleId": 749,
      "Mrmrs": "placeat",
      "Firstname": "Chesley",
      "MiddleName": "Keeling-Marvin",
      "Lastname": "Mertz",
      "SaleStakeholderId": 166,
      "Rank": 411,
      "Phone": "1-575-804-1601",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 702
        }
      }
    }
  ],
  "ActiveErpLinks": 801,
  "UserDefinedFields": {
    "SuperOffice:1": "Juanita Hamill",
    "SuperOffice:2": "441639433"
  },
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "vitae"
  },
  "PublishEventDate": "2015-08-25T09:40:59.5446912+02:00",
  "PublishTo": "2010-08-16T09:40:59.5446912+02:00",
  "PublishFrom": "2016-01-29T09:40:59.5446912+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 863,
      "Visibility": "All",
      "DisplayValue": "doloremque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "VisibleId": 863,
      "Visibility": "All",
      "DisplayValue": "doloremque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 981
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
      "FieldLength": 482
    }
  }
}
```