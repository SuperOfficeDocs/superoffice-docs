---
title: POST Agents/Contact/CreateDefaultContactEntity
id: v1ContactAgent_CreateDefaultContactEntity
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.

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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 356,
  "Name": "Gerhold, Schimmel and Bednar",
  "Department": "",
  "OrgNr": "1120572",
  "Number1": "1149823",
  "Number2": "992750",
  "UpdatedDate": "2010-10-06T18:28:48.4306234+02:00",
  "CreatedDate": "2003-08-21T18:28:48.4306234+02:00",
  "Emails": [
    {
      "Value": "iste",
      "StrippedValue": "consequatur",
      "Description": "Upgradable bandwidth-monitored portal",
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
    {
      "Value": "iste",
      "StrippedValue": "consequatur",
      "Description": "Upgradable bandwidth-monitored portal",
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
    }
  ],
  "Interests": [
    {
      "Id": 66,
      "Name": "McKenzie-Rath",
      "ToolTip": "Odio ea magnam minima nam.",
      "Deleted": true,
      "Rank": 581,
      "Type": "ut",
      "ColorBlock": 91,
      "IconHint": "fugit",
      "Selected": false,
      "LastChanged": "1998-01-23T18:28:48.4306234+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "ducimus",
      "Hidden": true,
      "FullName": "Florencio Pagac",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "labore",
      "StrippedValue": "doloribus",
      "Description": "Decentralized bottom-line monitoring",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 92
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "doloribus",
      "Description": "Decentralized bottom-line monitoring",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 92
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "alias",
      "StrippedValue": "reiciendis",
      "Description": "Team-oriented bi-directional solution",
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
    {
      "Value": "alias",
      "StrippedValue": "reiciendis",
      "Description": "Team-oriented bi-directional solution",
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
    }
  ],
  "Faxes": [
    {
      "Value": "nostrum",
      "StrippedValue": "hic",
      "Description": "Multi-tiered optimal encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "hic",
      "Description": "Multi-tiered optimal encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "Description": "Compatible hybrid focus group",
  "UpdatedBy": {
    "AssociateId": 13,
    "Name": "Watsica Group",
    "PersonId": 453,
    "Rank": 746,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 86,
    "FullName": "Wilton Abbott",
    "FormalName": "Littel-Torphy",
    "Deleted": false,
    "EjUserId": 786,
    "UserName": "Tromp-Williamson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "aggregate open-source functionalities"
        },
        "FieldType": "System.String",
        "FieldLength": 182
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 667,
    "Name": "Gerlach, Veum and Morissette",
    "PersonId": 640,
    "Rank": 871,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 179,
    "FullName": "Camryn Smith II",
    "FormalName": "Kuvalis, Kuphal and Reynolds",
    "Deleted": false,
    "EjUserId": 218,
    "UserName": "Hickle, Bode and Kessler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 108
      }
    }
  },
  "Associate": {
    "AssociateId": 730,
    "Name": "Leannon Group",
    "PersonId": 750,
    "Rank": 781,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 369,
    "FullName": "Lemuel O'Hara",
    "FormalName": "Stamm, Moen and Koss",
    "Deleted": false,
    "EjUserId": 125,
    "UserName": "Hickle, Prohaska and Dach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 931
      }
    }
  },
  "Business": {
    "Id": 430,
    "Value": "rem",
    "Tooltip": "quaerat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 815
      }
    }
  },
  "Category": {
    "Id": 658,
    "Value": "ea",
    "Tooltip": "magni",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 372
      }
    }
  },
  "Country": {
    "CountryId": 215,
    "Name": "Ruecker-Larkin",
    "CurrencyId": 476,
    "EnglishName": "Steuber, Funk and Baumbach",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Re-engineered 3rd generation artificial intelligence",
    "OrgNrText": "1256207",
    "InterAreaPrefix": "pariatur",
    "DialInPrefix": "facilis",
    "ZipPrefix": "ex",
    "DomainName": "Moen Group",
    "AddressLayoutId": 790,
    "DomesticAddressLayoutId": 34,
    "ForeignAddressLayoutId": 952,
    "Rank": 220,
    "Tooltip": "quasi",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 828
      }
    }
  },
  "Persons": [
    {
      "Position": "in",
      "PersonId": 169,
      "Mrmrs": "nihil",
      "Firstname": "Jevon",
      "Lastname": "Crona",
      "MiddleName": "Will Inc and Sons",
      "Title": "quo",
      "Description": "Fundamental eco-centric middleware",
      "Email": "garnett@veum.us",
      "FullName": "Maude Wiza",
      "DirectPhone": "(464)132-2041 x367",
      "FormalName": "Lynch, Donnelly and Boyle",
      "CountryId": 650,
      "ContactId": 825,
      "ContactName": "Hamill-Mosciski",
      "Retired": 900,
      "Rank": 728,
      "ActiveInterests": 865,
      "ContactDepartment": "",
      "ContactCountryId": 120,
      "ContactOrgNr": "1073338",
      "FaxPhone": "161.316.5756 x757",
      "MobilePhone": "244.335.1873",
      "ContactPhone": "877.201.4788",
      "AssociateName": "Kuhic, Johnson and Roob",
      "AssociateId": 812,
      "UsePersonAddress": false,
      "ContactFax": "eaque",
      "Kanafname": "est",
      "Kanalname": "temporibus",
      "Post1": "quos",
      "Post2": "autem",
      "Post3": "laudantium",
      "EmailName": "gina.skiles@gerhold.info",
      "ContactFullName": "Lamont Ledner",
      "ActiveErpLinks": 377,
      "TicketPriorityId": 840,
      "SupportLanguageId": 893,
      "SupportAssociateId": 200,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 775,
  "GroupId": 569,
  "ActiveStatusMonitorId": 495,
  "SupportAssociate": {
    "AssociateId": 117,
    "Name": "Greenfelder Group",
    "PersonId": 229,
    "Rank": 447,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 758,
    "FullName": "Louie Cruickshank",
    "FormalName": "Volkman-Powlowski",
    "Deleted": false,
    "EjUserId": 447,
    "UserName": "Jacobi-Skiles",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 310
      }
    }
  },
  "TicketPriority": {
    "Id": 689,
    "Value": "molestiae",
    "Tooltip": "quas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 767
      }
    }
  },
  "CustomerLanguage": {
    "Id": 165,
    "Value": "similique",
    "Tooltip": "commodi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 342
      }
    }
  },
  "Deleted": 444,
  "DbiAgentId": 711,
  "DbiLastSyncronized": "2011-01-18T18:28:48.4346233+01:00",
  "DbiKey": "magni",
  "DbiLastModified": "2004-09-24T18:28:48.4346233+02:00",
  "SupportPerson": {
    "Position": "aspernatur",
    "PersonId": 478,
    "Mrmrs": "dolorem",
    "Firstname": "Maeve",
    "Lastname": "Emmerich",
    "MiddleName": "Herman-Pacocha",
    "Title": "ullam",
    "Description": "Compatible human-resource analyzer",
    "Email": "ozella@hyatthahn.com",
    "FullName": "Douglas Boehm IV",
    "DirectPhone": "140-286-0223",
    "FormalName": "Stiedemann, Carroll and Breitenberg",
    "CountryId": 945,
    "ContactId": 171,
    "ContactName": "Smith Group",
    "Retired": 783,
    "Rank": 268,
    "ActiveInterests": 219,
    "ContactDepartment": "",
    "ContactCountryId": 982,
    "ContactOrgNr": "968928",
    "FaxPhone": "1-741-736-1454 x167",
    "MobilePhone": "(715)582-2388",
    "ContactPhone": "266-820-2711 x705",
    "AssociateName": "Corkery-Zboncak",
    "AssociateId": 580,
    "UsePersonAddress": true,
    "ContactFax": "sunt",
    "Kanafname": "accusantium",
    "Kanalname": "rem",
    "Post1": "facilis",
    "Post2": "repellat",
    "Post3": "magnam",
    "EmailName": "joelle@hoppe.co.uk",
    "ContactFullName": "Leta Jacobi",
    "ActiveErpLinks": 410,
    "TicketPriorityId": 820,
    "SupportLanguageId": 898,
    "SupportAssociateId": 599,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 69
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 6819.584,
    "Wgs84Longitude": 24460.87,
    "LocalizedAddress": [
      [
        {
          "Name": "Ratke Inc and Sons",
          "Value": "dolorem",
          "Tooltip": "ut",
          "Label": "corporis",
          "ValueLength": 870,
          "AddressType": "assumenda",
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
              "FieldLength": 816
            }
          }
        }
      ],
      [
        {
          "Name": "Greenholt Inc and Sons",
          "Value": "sapiente",
          "Tooltip": "dolore",
          "Label": "dolor",
          "ValueLength": 430,
          "AddressType": "quos",
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
              "FieldLength": 540
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
        "FieldType": "System.String",
        "FieldLength": 793
      }
    }
  },
  "Source": 51,
  "ActiveErpLinks": 747,
  "BounceEmails": [
    "lucienne_spencer@harrisosinski.us",
    "theresia_mitchell@ebert.com"
  ],
  "Domains": [
    "quibusdam",
    "necessitatibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "876395589"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "eius"
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
      "FieldLength": 84
    }
  }
}
```