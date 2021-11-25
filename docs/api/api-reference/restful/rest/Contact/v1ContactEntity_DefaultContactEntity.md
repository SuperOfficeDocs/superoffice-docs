---
title: GET Contact/default
id: v1ContactEntity_DefaultContactEntity
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.






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

The Contact Service. The service implements all services working with the Contact object



Carrier object for ContactEntity.
Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 20 Jun 2012 18:25:50 G6T

{
  "ContactId": 686,
  "Name": "Lang Inc and Sons",
  "Department": "",
  "OrgNr": "475841",
  "Number1": "1018721",
  "Number2": "751761",
  "UpdatedDate": "2012-06-20T18:25:50.2196247+02:00",
  "CreatedDate": "2003-09-02T18:25:50.2196247+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "dolores",
      "Description": "Customizable mobile ability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 899
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "dolores",
      "Description": "Customizable mobile ability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 899
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 163,
      "Name": "Bergstrom, Prohaska and Champlin",
      "ToolTip": "Sunt eos est optio nulla.",
      "Deleted": true,
      "Rank": 678,
      "Type": "accusamus",
      "ColorBlock": 714,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "2007-04-18T18:25:50.2346247+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "culpa",
      "Hidden": true,
      "FullName": "Rory Rowe III",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 880
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "doloribus",
      "StrippedValue": "minima",
      "Description": "Mandatory national model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "minima",
      "Description": "Mandatory national model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "doloribus",
      "StrippedValue": "aut",
      "Description": "Extended transitional toolset",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "aut",
      "Description": "Extended transitional toolset",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "impedit",
      "StrippedValue": "et",
      "Description": "Universal object-oriented protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 789
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "et",
      "Description": "Universal object-oriented protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 789
        }
      }
    }
  ],
  "Description": "Multi-channelled actuating migration",
  "UpdatedBy": {
    "AssociateId": 739,
    "Name": "Moen-Durgan",
    "PersonId": 619,
    "Rank": 471,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 669,
    "FullName": "Nora Windler",
    "FormalName": "Klocko-Gibson",
    "Deleted": true,
    "EjUserId": 690,
    "UserName": "Tillman, Paucek and Johnson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 919
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 254,
    "Name": "Goodwin Inc and Sons",
    "PersonId": 127,
    "Rank": 536,
    "Tooltip": "aliquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 473,
    "FullName": "Florida Rohan",
    "FormalName": "Leuschke-Corkery",
    "Deleted": false,
    "EjUserId": 819,
    "UserName": "Corwin, Runolfsdottir and Hane",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engineer scalable vortals"
        },
        "FieldType": "System.Int32",
        "FieldLength": 944
      }
    }
  },
  "Associate": {
    "AssociateId": 318,
    "Name": "Johns-Kiehn",
    "PersonId": 701,
    "Rank": 219,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 544,
    "FullName": "Garrick Quigley",
    "FormalName": "Yundt, Tromp and Schmitt",
    "Deleted": false,
    "EjUserId": 585,
    "UserName": "Lesch-Von",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 156
      }
    }
  },
  "Business": {
    "Id": 927,
    "Value": "sed",
    "Tooltip": "accusantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 223
      }
    }
  },
  "Category": {
    "Id": 832,
    "Value": "repudiandae",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 276
      }
    }
  },
  "Country": {
    "CountryId": 843,
    "Name": "Bednar, Hodkiewicz and Hane",
    "CurrencyId": 258,
    "EnglishName": "Crooks Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Streamlined foreground Graphic Interface",
    "OrgNrText": "672697",
    "InterAreaPrefix": "perspiciatis",
    "DialInPrefix": "aut",
    "ZipPrefix": "perferendis",
    "DomainName": "Stokes-Cummings",
    "AddressLayoutId": 398,
    "DomesticAddressLayoutId": 728,
    "ForeignAddressLayoutId": 159,
    "Rank": 960,
    "Tooltip": "rerum",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 703
      }
    }
  },
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 100,
      "Mrmrs": "error",
      "Firstname": "Sadye",
      "Lastname": "Deckow",
      "MiddleName": "Dooley, Hintz and Ullrich",
      "Title": "neque",
      "Description": "Upgradable assymetric installation",
      "Email": "isac.grady@wunsch.biz",
      "FullName": "Eli Carter II",
      "DirectPhone": "(017)838-4648 x755",
      "FormalName": "Kuhlman, Turner and Zemlak",
      "CountryId": 25,
      "ContactId": 807,
      "ContactName": "Kris-Heidenreich",
      "Retired": 783,
      "Rank": 337,
      "ActiveInterests": 944,
      "ContactDepartment": "",
      "ContactCountryId": 231,
      "ContactOrgNr": "1333088",
      "FaxPhone": "505.636.0140",
      "MobilePhone": "(185)402-7161",
      "ContactPhone": "(280)634-0760",
      "AssociateName": "Considine, Hayes and Runte",
      "AssociateId": 65,
      "UsePersonAddress": false,
      "ContactFax": "porro",
      "Kanafname": "autem",
      "Kanalname": "porro",
      "Post1": "quia",
      "Post2": "consectetur",
      "Post3": "quo",
      "EmailName": "harvey@considine.us",
      "ContactFullName": "Maude Prosacco",
      "ActiveErpLinks": 653,
      "TicketPriorityId": 428,
      "SupportLanguageId": 596,
      "SupportAssociateId": 179,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 308
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "soluta",
  "Xstop": true,
  "ActiveInterests": 373,
  "GroupId": 360,
  "ActiveStatusMonitorId": 454,
  "SupportAssociate": {
    "AssociateId": 885,
    "Name": "Rohan-Mertz",
    "PersonId": 574,
    "Rank": 683,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 187,
    "FullName": "Federico Rice",
    "FormalName": "Walter, Bechtelar and Aufderhar",
    "Deleted": true,
    "EjUserId": 249,
    "UserName": "Grant, Gleichner and Morar",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 19
      }
    }
  },
  "TicketPriority": {
    "Id": 680,
    "Value": "sed",
    "Tooltip": "saepe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 837
      }
    }
  },
  "CustomerLanguage": {
    "Id": 542,
    "Value": "quia",
    "Tooltip": "voluptate",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 73
      }
    }
  },
  "Deleted": 975,
  "DbiAgentId": 318,
  "DbiLastSyncronized": "2005-06-20T18:25:50.2395945+02:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "2003-09-28T18:25:50.2395945+02:00",
  "SupportPerson": {
    "Position": "quia",
    "PersonId": 555,
    "Mrmrs": "laborum",
    "Firstname": "Oceane",
    "Lastname": "Thiel",
    "MiddleName": "Gutkowski LLC",
    "Title": "non",
    "Description": "Grass-roots fault-tolerant open architecture",
    "Email": "telly@boscolakin.info",
    "FullName": "Dangelo Hyatt Jr.",
    "DirectPhone": "573-837-6416",
    "FormalName": "O'Keefe-O'Connell",
    "CountryId": 69,
    "ContactId": 664,
    "ContactName": "Schuppe, Hermiston and Spencer",
    "Retired": 59,
    "Rank": 677,
    "ActiveInterests": 602,
    "ContactDepartment": "",
    "ContactCountryId": 681,
    "ContactOrgNr": "555430",
    "FaxPhone": "1-673-811-3107 x3264",
    "MobilePhone": "287-270-7837 x58503",
    "ContactPhone": "1-420-066-7342 x8514",
    "AssociateName": "Buckridge LLC",
    "AssociateId": 858,
    "UsePersonAddress": true,
    "ContactFax": "necessitatibus",
    "Kanafname": "ea",
    "Kanalname": "quo",
    "Post1": "alias",
    "Post2": "animi",
    "Post3": "illum",
    "EmailName": "makenna@schmeler.biz",
    "ContactFullName": "Ardith McClure",
    "ActiveErpLinks": 43,
    "TicketPriorityId": 445,
    "SupportLanguageId": 754,
    "SupportAssociateId": 529,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 958
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 23802.73,
    "Wgs84Longitude": 13849.145999999999,
    "LocalizedAddress": [
      [
        {
          "Name": "Prosacco-Powlowski",
          "Value": "pariatur",
          "Tooltip": "et",
          "Label": "modi",
          "ValueLength": 866,
          "AddressType": "voluptas",
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
              "FieldLength": 127
            }
          }
        }
      ],
      [
        {
          "Name": "Casper, Kub and Dicki",
          "Value": "maxime",
          "Tooltip": "dignissimos",
          "Label": "eum",
          "ValueLength": 621,
          "AddressType": "consequuntur",
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
              "FieldLength": 429
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "consectetur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 180
      }
    }
  },
  "Source": 214,
  "ActiveErpLinks": 895,
  "BounceEmails": [
    "maurine@blickgusikowski.us",
    "eden_wilkinson@walker.ca"
  ],
  "Domains": [
    "accusantium",
    "possimus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1581829891",
    "SuperOffice:2": "1230927126"
  },
  "ExtraFields": {
    "ExtraFields1": "excepturi",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "ipsa"
  },
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
      "FieldLength": 751
    }
  }
}
```