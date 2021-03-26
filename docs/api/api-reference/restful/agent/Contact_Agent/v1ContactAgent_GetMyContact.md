---
title: POST Agents/Contact/GetMyContact
id: v1ContactAgent_GetMyContact
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 840,
  "Name": "Daniel LLC",
  "Department": "",
  "OrgNr": "1030296",
  "Number1": "1183372",
  "Number2": "133053",
  "UpdatedDate": "1994-03-14T16:48:29.1298941+01:00",
  "CreatedDate": "2020-05-28T16:48:29.1298941+02:00",
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "dolor",
      "Description": "Re-contextualized local system engine",
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
    {
      "Value": "sint",
      "StrippedValue": "dolor",
      "Description": "Re-contextualized local system engine",
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
    }
  ],
  "Interests": [
    {
      "Id": 441,
      "Name": "Gulgowski, Rempel and Monahan",
      "ToolTip": "Adipisci et qui doloribus consequatur unde.",
      "Deleted": false,
      "Rank": 112,
      "Type": "perferendis",
      "ColorBlock": 339,
      "IconHint": "voluptates",
      "Selected": true,
      "LastChanged": "2002-01-25T16:48:29.1309249+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ad",
      "Hidden": true,
      "FullName": "Jalon Considine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 753
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "quia",
      "Description": "Team-oriented background open architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "quia",
      "Description": "Team-oriented background open architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quis",
      "StrippedValue": "libero",
      "Description": "Optimized intermediate matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 154
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "libero",
      "Description": "Optimized intermediate matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 154
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "blanditiis",
      "Description": "Face to face coherent parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "blanditiis",
      "Description": "Face to face coherent parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    }
  ],
  "Description": "Secured cohesive analyzer",
  "UpdatedBy": {
    "AssociateId": 84,
    "Name": "Kling, Barrows and Fadel",
    "PersonId": 517,
    "Rank": 125,
    "Tooltip": "quasi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 903,
    "FullName": "Thad VonRueden",
    "FormalName": "Lakin-Mraz",
    "Deleted": true,
    "EjUserId": 837,
    "UserName": "Hickle LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 495
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 135,
    "Name": "Dibbert Group",
    "PersonId": 251,
    "Rank": 578,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 661,
    "FullName": "Brian Mayer III",
    "FormalName": "Krajcik LLC",
    "Deleted": true,
    "EjUserId": 556,
    "UserName": "Gleichner-Schulist",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 915
      }
    }
  },
  "Associate": {
    "AssociateId": 961,
    "Name": "Pfannerstill LLC",
    "PersonId": 927,
    "Rank": 32,
    "Tooltip": "minus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Mrs. Gunner Hand",
    "FormalName": "Gutmann-Klein",
    "Deleted": false,
    "EjUserId": 374,
    "UserName": "Rohan-Kemmer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 473
      }
    }
  },
  "Business": {
    "Id": 873,
    "Value": "modi",
    "Tooltip": "blanditiis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 619
      }
    }
  },
  "Category": {
    "Id": 342,
    "Value": "aut",
    "Tooltip": "odit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 127
      }
    }
  },
  "Country": {
    "CountryId": 456,
    "Name": "Bosco-Fay",
    "CurrencyId": 135,
    "EnglishName": "Hermiston, Skiles and Kohler",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Compatible clear-thinking interface",
    "OrgNrText": "1685398",
    "InterAreaPrefix": "blanditiis",
    "DialInPrefix": "saepe",
    "ZipPrefix": "veritatis",
    "DomainName": "Padberg-Wolff",
    "AddressLayoutId": 70,
    "DomesticAddressLayoutId": 709,
    "ForeignAddressLayoutId": 51,
    "Rank": 376,
    "Tooltip": "velit",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 17
      }
    }
  },
  "Persons": [
    {
      "Position": "ducimus",
      "PersonId": 380,
      "Mrmrs": "ipsum",
      "Firstname": "Destany",
      "Lastname": "Windler",
      "MiddleName": "Thompson-Crona",
      "Title": "sunt",
      "Description": "Multi-channelled bi-directional toolset",
      "Email": "ubaldo@harvey.biz",
      "FullName": "Glen Bailey",
      "DirectPhone": "1-056-514-2073 x304",
      "FormalName": "Friesen, Boyle and Simonis",
      "CountryId": 798,
      "ContactId": 823,
      "ContactName": "Morar, Metz and Fisher",
      "Retired": 682,
      "Rank": 920,
      "ActiveInterests": 322,
      "ContactDepartment": "",
      "ContactCountryId": 569,
      "ContactOrgNr": "798722",
      "FaxPhone": "(031)062-8658 x8565",
      "MobilePhone": "320-778-5184",
      "ContactPhone": "1-067-065-4636",
      "AssociateName": "Nicolas-McCullough",
      "AssociateId": 844,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "harum",
      "Kanalname": "rem",
      "Post1": "porro",
      "Post2": "adipisci",
      "Post3": "animi",
      "EmailName": "marian@faheyeffertz.ca",
      "ContactFullName": "Daniela Gibson",
      "ActiveErpLinks": 802,
      "TicketPriorityId": 580,
      "SupportLanguageId": 224,
      "SupportAssociateId": 335,
      "CategoryName": "VIP Customer",
      "TableRight": {},
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
  ],
  "NoMailing": true,
  "Kananame": "quas",
  "Xstop": true,
  "ActiveInterests": 1001,
  "GroupId": 866,
  "ActiveStatusMonitorId": 363,
  "SupportAssociate": {
    "AssociateId": 149,
    "Name": "Kohler Group",
    "PersonId": 929,
    "Rank": 5,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 51,
    "FullName": "Mr. Roslyn Kunde",
    "FormalName": "Bartoletti Inc and Sons",
    "Deleted": false,
    "EjUserId": 587,
    "UserName": "Murray Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 856
      }
    }
  },
  "TicketPriority": {
    "Id": 237,
    "Value": "excepturi",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 80
      }
    }
  },
  "CustomerLanguage": {
    "Id": 939,
    "Value": "odio",
    "Tooltip": "quaerat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 285
      }
    }
  },
  "Deleted": 9,
  "DbiAgentId": 34,
  "DbiLastSyncronized": "2010-05-13T16:48:29.1349241+02:00",
  "DbiKey": "voluptas",
  "DbiLastModified": "2003-06-16T16:48:29.1349241+02:00",
  "SupportPerson": {
    "Position": "in",
    "PersonId": 415,
    "Mrmrs": "minus",
    "Firstname": "Gina",
    "Lastname": "Wolf",
    "MiddleName": "Koepp-Blanda",
    "Title": "consequuntur",
    "Description": "Function-based contextually-based implementation",
    "Email": "cynthia_johns@treutel.us",
    "FullName": "Joannie Toy",
    "DirectPhone": "1-083-420-7610 x2368",
    "FormalName": "Wolf-Fadel",
    "CountryId": 493,
    "ContactId": 688,
    "ContactName": "Sanford-Schumm",
    "Retired": 461,
    "Rank": 817,
    "ActiveInterests": 671,
    "ContactDepartment": "",
    "ContactCountryId": 590,
    "ContactOrgNr": "1164518",
    "FaxPhone": "(007)584-0540",
    "MobilePhone": "(424)836-2270 x774",
    "ContactPhone": "145.763.1208 x14000",
    "AssociateName": "Mohr, Wiza and McDermott",
    "AssociateId": 953,
    "UsePersonAddress": true,
    "ContactFax": "asperiores",
    "Kanafname": "sit",
    "Kanalname": "ullam",
    "Post1": "error",
    "Post2": "magnam",
    "Post3": "commodi",
    "EmailName": "noemy.ledner@skiles.com",
    "ContactFullName": "Jaren Renner DDS",
    "ActiveErpLinks": 687,
    "TicketPriorityId": 289,
    "SupportLanguageId": 163,
    "SupportAssociateId": 964,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 527
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 21555.652,
    "Wgs84Longitude": 20850.502,
    "LocalizedAddress": [
      [
        {
          "Name": "Price-Klein",
          "Value": "eos",
          "Tooltip": "omnis",
          "Label": "quod",
          "ValueLength": 998,
          "AddressType": "quis",
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
              "FieldLength": 920
            }
          }
        }
      ],
      [
        {
          "Name": "Bruen-Hegmann",
          "Value": "magni",
          "Tooltip": "voluptatem",
          "Label": "voluptas",
          "ValueLength": 603,
          "AddressType": "reprehenderit",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "synthesize transparent portals"
              },
              "FieldType": "System.String",
              "FieldLength": 531
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "voluptate",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 598
      }
    }
  },
  "Source": 317,
  "ActiveErpLinks": 48,
  "BounceEmails": [
    "leatha@reichel.ca",
    "zachariah@ullrichpowlowski.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Felton Abshire",
    "SuperOffice:2": "823866220"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "nihil"
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
      "FieldType": "System.String",
      "FieldLength": 967
    }
  }
}
```