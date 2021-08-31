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
Last-Modified: Mon, 15 Mar 2021 15:05:41 G3T

{
  "ContactId": 820,
  "Name": "Shanahan, Davis and Gaylord",
  "Department": "",
  "OrgNr": "1379607",
  "Number1": "245485",
  "Number2": "727260",
  "UpdatedDate": "2021-03-15T15:05:41.8460054+01:00",
  "CreatedDate": "2000-10-21T15:05:41.8460054+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "perspiciatis",
      "Description": "Operative 6th generation time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "perspiciatis",
      "Description": "Operative 6th generation time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 741,
      "Name": "Schuster LLC",
      "ToolTip": "Perspiciatis facilis vero.",
      "Deleted": false,
      "Rank": 355,
      "Type": "occaecati",
      "ColorBlock": 345,
      "IconHint": "quidem",
      "Selected": true,
      "LastChanged": "2001-10-07T15:05:41.8460054+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Miss Lilian Sauer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tempora",
      "StrippedValue": "exercitationem",
      "Description": "Open-architected dedicated success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "exercitationem",
      "Description": "Open-architected dedicated success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "neque",
      "StrippedValue": "aut",
      "Description": "Advanced discrete instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "aut",
      "Description": "Advanced discrete instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Balanced assymetric workforce",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 719
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Balanced assymetric workforce",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 719
        }
      }
    }
  ],
  "Description": "Future-proofed asynchronous implementation",
  "UpdatedBy": {
    "AssociateId": 802,
    "Name": "Lakin LLC",
    "PersonId": 293,
    "Rank": 676,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 246,
    "FullName": "Marty Murphy",
    "FormalName": "Kuhn-Prohaska",
    "Deleted": false,
    "EjUserId": 269,
    "UserName": "Bradtke Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 204
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 811,
    "Name": "Labadie Inc and Sons",
    "PersonId": 692,
    "Rank": 831,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 220,
    "FullName": "Adan Larson V",
    "FormalName": "Pfeffer-Lockman",
    "Deleted": false,
    "EjUserId": 847,
    "UserName": "Hettinger, Kirlin and Huel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 451
      }
    }
  },
  "Associate": {
    "AssociateId": 57,
    "Name": "Kuhn, Bradtke and Smitham",
    "PersonId": 177,
    "Rank": 178,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 499,
    "FullName": "Harvey Mante",
    "FormalName": "Wyman-Homenick",
    "Deleted": true,
    "EjUserId": 694,
    "UserName": "Paucek Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 362
      }
    }
  },
  "Business": {
    "Id": 543,
    "Value": "ex",
    "Tooltip": "natus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 770
      }
    }
  },
  "Category": {
    "Id": 313,
    "Value": "sed",
    "Tooltip": "fugiat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix bricks-and-clicks paradigms"
        },
        "FieldType": "System.String",
        "FieldLength": 433
      }
    }
  },
  "Country": {
    "CountryId": 225,
    "Name": "Kohler, Anderson and Powlowski",
    "CurrencyId": 935,
    "EnglishName": "Runolfsdottir, Hamill and McDermott",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Business-focused 24/7 info-mediaries",
    "OrgNrText": "973062",
    "InterAreaPrefix": "tenetur",
    "DialInPrefix": "repudiandae",
    "ZipPrefix": "aperiam",
    "DomainName": "Bernhard, Simonis and Gislason",
    "AddressLayoutId": 847,
    "DomesticAddressLayoutId": 862,
    "ForeignAddressLayoutId": 901,
    "Rank": 585,
    "Tooltip": "nobis",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 854
      }
    }
  },
  "Persons": [
    {
      "Position": "et",
      "PersonId": 868,
      "Mrmrs": "dolores",
      "Firstname": "Letha",
      "Lastname": "Kilback",
      "MiddleName": "Bogan, Breitenberg and Walsh",
      "Title": "consequatur",
      "Description": "Virtual zero defect flexibility",
      "Email": "lucious@johnstonvon.biz",
      "FullName": "Roslyn Bins",
      "DirectPhone": "(148)674-2422",
      "FormalName": "Gerlach-Romaguera",
      "CountryId": 421,
      "ContactId": 354,
      "ContactName": "Rodriguez-Crona",
      "Retired": 922,
      "Rank": 664,
      "ActiveInterests": 896,
      "ContactDepartment": "",
      "ContactCountryId": 819,
      "ContactOrgNr": "584859",
      "FaxPhone": "488.280.5338 x732",
      "MobilePhone": "746.677.7805",
      "ContactPhone": "(583)156-4420 x34834",
      "AssociateName": "Harvey, Yost and Jones",
      "AssociateId": 520,
      "UsePersonAddress": true,
      "ContactFax": "perspiciatis",
      "Kanafname": "autem",
      "Kanalname": "dolores",
      "Post1": "ex",
      "Post2": "iste",
      "Post3": "commodi",
      "EmailName": "emmie@dach.info",
      "ContactFullName": "Dorris Waelchi Jr.",
      "ActiveErpLinks": 363,
      "TicketPriorityId": 461,
      "SupportLanguageId": 970,
      "SupportAssociateId": 760,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "illo",
  "Xstop": false,
  "ActiveInterests": 727,
  "GroupId": 387,
  "ActiveStatusMonitorId": 630,
  "SupportAssociate": {
    "AssociateId": 809,
    "Name": "Mante, Zieme and Brown",
    "PersonId": 583,
    "Rank": 459,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 70,
    "FullName": "Jonas Braun",
    "FormalName": "Douglas Inc and Sons",
    "Deleted": true,
    "EjUserId": 820,
    "UserName": "Hammes LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 161
      }
    }
  },
  "TicketPriority": {
    "Id": 123,
    "Value": "dolor",
    "Tooltip": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 428
      }
    }
  },
  "CustomerLanguage": {
    "Id": 150,
    "Value": "minima",
    "Tooltip": "praesentium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 134
      }
    }
  },
  "Deleted": 229,
  "DbiAgentId": 863,
  "DbiLastSyncronized": "2002-12-22T15:05:41.8500054+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2009-07-09T15:05:41.8500054+02:00",
  "SupportPerson": {
    "Position": "explicabo",
    "PersonId": 909,
    "Mrmrs": "nemo",
    "Firstname": "Greg",
    "Lastname": "Mitchell",
    "MiddleName": "Reynolds, Wilderman and Koch",
    "Title": "quam",
    "Description": "Synergized responsive info-mediaries",
    "Email": "ward_wolff@wisokymurphy.us",
    "FullName": "Jairo Muller",
    "DirectPhone": "534.666.4664 x20484",
    "FormalName": "Abbott, Ankunding and Kertzmann",
    "CountryId": 903,
    "ContactId": 334,
    "ContactName": "Collins, Quitzon and Runte",
    "Retired": 889,
    "Rank": 899,
    "ActiveInterests": 846,
    "ContactDepartment": "",
    "ContactCountryId": 552,
    "ContactOrgNr": "1772792",
    "FaxPhone": "512.471.6307 x2653",
    "MobilePhone": "363-206-5726 x8775",
    "ContactPhone": "(153)287-1317",
    "AssociateName": "Larkin, Gibson and Wisozk",
    "AssociateId": 912,
    "UsePersonAddress": false,
    "ContactFax": "blanditiis",
    "Kanafname": "nihil",
    "Kanalname": "adipisci",
    "Post1": "dolorem",
    "Post2": "doloribus",
    "Post3": "veritatis",
    "EmailName": "seth.stamm@schmitt.us",
    "ContactFullName": "Jovani Senger",
    "ActiveErpLinks": 208,
    "TicketPriorityId": 393,
    "SupportLanguageId": 139,
    "SupportAssociateId": 440,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 888
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 11172.71,
    "Wgs84Longitude": 24893.362,
    "LocalizedAddress": [
      [
        {
          "Name": "Herzog, Maggio and Fay",
          "Value": "earum",
          "Tooltip": "error",
          "Label": "et",
          "ValueLength": 533,
          "AddressType": "tempore",
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
              "FieldLength": 322
            }
          }
        }
      ],
      [
        {
          "Name": "Mraz Group",
          "Value": "ducimus",
          "Tooltip": "ullam",
          "Label": "tempora",
          "ValueLength": 558,
          "AddressType": "laborum",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "implement B2B supply-chains"
              },
              "FieldType": "System.Int32",
              "FieldLength": 708
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "repellendus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 55
      }
    }
  },
  "Source": 721,
  "ActiveErpLinks": 799,
  "BounceEmails": [
    "forest.von@braundamore.co.uk",
    "bette@gorczany.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "quo"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "incubate end-to-end communities"
      },
      "FieldType": "System.Int32",
      "FieldLength": 428
    }
  }
}
```