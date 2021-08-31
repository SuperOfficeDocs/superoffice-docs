---
title: CreateDefaultPersonEntity
id: v1PersonAgent_CreateDefaultPersonEntity
---

# CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Set default values into a new PersonEntity.

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



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as Date |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 798,
  "Firstname": "Herbert",
  "MiddleName": "Mitchell Inc and Sons",
  "Lastname": "Gleichner",
  "Mrmrs": "rerum",
  "Title": "debitis",
  "UpdatedDate": "2002-03-22T14:58:04.6214601+01:00",
  "CreatedDate": "2005-08-23T14:58:04.6214601+02:00",
  "BirthDate": "2013-07-09T14:58:04.6214601+02:00",
  "CreatedBy": {
    "AssociateId": 857,
    "Name": "Eichmann, Fritsch and Reinger",
    "PersonId": 154,
    "Rank": 867,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Wallace West II",
    "FormalName": "Kuhn Inc and Sons",
    "Deleted": true,
    "EjUserId": 974,
    "UserName": "Blick, Osinski and Powlowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 208
      }
    }
  },
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "est",
      "Description": "Innovative multi-tasking toolset",
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
    {
      "Value": "omnis",
      "StrippedValue": "est",
      "Description": "Innovative multi-tasking toolset",
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
    }
  ],
  "Description": "Managed regional service-desk",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "voluptatem",
      "Description": "Function-based empowering matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "voluptatem",
      "Description": "Function-based empowering matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "occaecati",
      "Description": "Streamlined multimedia ability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 904
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "occaecati",
      "Description": "Streamlined multimedia ability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 904
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "reiciendis",
      "Description": "Self-enabling 24 hour contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "reiciendis",
      "Description": "Self-enabling 24 hour contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "corporis",
      "StrippedValue": "reiciendis",
      "Description": "Reverse-engineered solution-oriented strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "reiciendis",
      "Description": "Reverse-engineered solution-oriented strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "consectetur",
      "Description": "Reverse-engineered global Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engage open-source vortals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "consectetur",
      "Description": "Reverse-engineered global Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engage open-source vortals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "Position": {
    "Id": 16,
    "Value": "provident",
    "Tooltip": "ipsam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 168
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 660,
    "Name": "Buckridge Group",
    "PersonId": 895,
    "Rank": 183,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 424,
    "FullName": "Abdul Will",
    "FormalName": "Monahan, Friesen and Schiller",
    "Deleted": false,
    "EjUserId": 551,
    "UserName": "Luettgen LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize out-of-the-box supply-chains"
        },
        "FieldType": "System.Int32",
        "FieldLength": 263
      }
    }
  },
  "Contact": {
    "ContactId": 696,
    "Name": "Beier, Heidenreich and Deckow",
    "OrgNr": "717598",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cupiditate",
    "DirectPhone": "313-065-0483",
    "AssociateId": 525,
    "CountryId": 813,
    "EmailAddress": "franz_durgan@abbott.com",
    "Kananame": "ducimus",
    "EmailAddressName": "kristy@lehnerokeefe.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Heloise Moen",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "velit",
    "FullName": "Misael Heller",
    "IsOwnerContact": true,
    "ActiveErpLinks": 792,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 929
      }
    }
  },
  "Country": {
    "CountryId": 418,
    "Name": "D'Amore, Collier and Gibson",
    "CurrencyId": 986,
    "EnglishName": "Hammes-Bahringer",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Profit-focused 5th generation framework",
    "OrgNrText": "1424142",
    "InterAreaPrefix": "aut",
    "DialInPrefix": "dolorem",
    "ZipPrefix": "veniam",
    "DomainName": "Kunze Group",
    "AddressLayoutId": 314,
    "DomesticAddressLayoutId": 613,
    "ForeignAddressLayoutId": 488,
    "Rank": 643,
    "Tooltip": "ratione",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 776
      }
    }
  },
  "Interests": [
    {
      "Id": 35,
      "Name": "Jenkins LLC",
      "ToolTip": "Libero velit earum.",
      "Deleted": true,
      "Rank": 963,
      "Type": "eum",
      "ColorBlock": 779,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2015-07-31T14:58:04.6234638+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "quidem",
      "Hidden": false,
      "FullName": "Ryleigh Leannon DDS",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    }
  ],
  "PersonNumber": "227007",
  "FullName": "Noel Steuber",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "ut",
      "Description": "Compatible real-time capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "ut",
      "Description": "Compatible real-time capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    }
  ],
  "FormalName": "Cremin, Harris and Fahey",
  "Address": {
    "Wgs84Latitude": 2062.172,
    "Wgs84Longitude": 4315.518,
    "LocalizedAddress": [
      [
        {
          "Name": "Ankunding LLC",
          "Value": "quos",
          "Tooltip": "rerum",
          "Label": "facere",
          "ValueLength": 903,
          "AddressType": "et",
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
              "FieldLength": 357
            }
          }
        }
      ],
      [
        {
          "Name": "Haley Inc and Sons",
          "Value": "esse",
          "Tooltip": "quod",
          "Label": "sed",
          "ValueLength": 328,
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
              "FieldLength": 866
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 582
      }
    }
  },
  "Post3": "accusamus",
  "Post2": "eos",
  "Post1": "eum",
  "Kanalname": "aperiam",
  "Kanafname": "reiciendis",
  "CorrespondingAssociate": {
    "AssociateId": 911,
    "Name": "Stanton, Grimes and Mertz",
    "PersonId": 840,
    "Rank": 83,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 488,
    "FullName": "Chadrick Beer",
    "FormalName": "Huels Inc and Sons",
    "Deleted": false,
    "EjUserId": 17,
    "UserName": "Wilderman-Hackett",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 549
      }
    }
  },
  "Category": {
    "Id": 568,
    "Value": "autem",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 33
      }
    }
  },
  "Business": {
    "Id": 91,
    "Value": "dignissimos",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 645
      }
    }
  },
  "Associate": {
    "AssociateId": 96,
    "Name": "Powlowski Inc and Sons",
    "PersonId": 781,
    "Rank": 298,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 563,
    "FullName": "Miss Lowell Connelly",
    "FormalName": "Beatty, Glover and Doyle",
    "Deleted": true,
    "EjUserId": 91,
    "UserName": "Ferry, Walsh and Johnston",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 797
      }
    }
  },
  "Salutation": "aut",
  "ActiveInterests": 274,
  "SupportAssociate": {
    "AssociateId": 979,
    "Name": "Konopelski LLC",
    "PersonId": 392,
    "Rank": 853,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 112,
    "FullName": "Danielle Ryan",
    "FormalName": "Keebler, King and Nader",
    "Deleted": false,
    "EjUserId": 220,
    "UserName": "Carter, Walsh and Champlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 275
      }
    }
  },
  "TicketPriority": {
    "Id": 63,
    "Value": "cum",
    "Tooltip": "illum",
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
  "CustomerLanguage": {
    "Id": 170,
    "Value": "et",
    "Tooltip": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 180
      }
    }
  },
  "DbiAgentId": 14,
  "DbiKey": "optio",
  "DbiLastModified": "2005-05-07T14:58:04.6264595+02:00",
  "DbiLastSyncronized": "2006-11-04T14:58:04.6264595+01:00",
  "SentInfo": 989,
  "ShowContactTickets": 178,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 278,
    "UserName": "Becker Group",
    "PersonId": 659,
    "Rank": 759,
    "Tooltip": "in",
    "UserGroupId": 418,
    "EjUserId": 313,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "quo",
      "corrupti"
    ],
    "CanLogon": false,
    "RoleName": "Goyette, Breitenberg and Denesik",
    "RoleTooltip": "earum",
    "UserGroupName": "Wilderman Inc and Sons",
    "UserGroupTooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 247
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "dolorum",
      "StrippedValue": "minus",
      "Description": "Customer-focused zero tolerance intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "minus",
      "Description": "Customer-focused zero tolerance intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "autem",
      "StrippedValue": "nam",
      "Description": "Future-proofed responsive moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 883
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "nam",
      "Description": "Future-proofed responsive moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 883
        }
      }
    }
  ],
  "Source": 993,
  "ActiveErpLinks": 19,
  "ShipmentTypes": [
    {
      "Id": 338,
      "Name": "Brakus Group",
      "ToolTip": "Repudiandae modi.",
      "Deleted": true,
      "Rank": 953,
      "Type": "quo",
      "ColorBlock": 693,
      "IconHint": "atque",
      "Selected": true,
      "LastChanged": "2002-11-08T14:58:04.6264595+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "voluptatibus",
      "Hidden": true,
      "FullName": "Dallin Hoeger",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 346
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 564,
      "Comment": "maiores",
      "Registered": "1999-07-28T14:58:04.6264595+02:00",
      "RegisteredAssociateId": 632,
      "Updated": "2000-10-31T14:58:04.6264595+01:00",
      "UpdatedAssociateId": 397,
      "LegalBaseId": 998,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Stehr-Wolff",
      "ConsentPurposeId": 620,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Wiza, Graham and Hackett",
      "ConsentSourceId": 314,
      "ConsentSourceKey": "exercitationem",
      "ConsentSourceName": "Littel-Adams",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    }
  ],
  "BounceEmails": [
    "mozelle@thiel.co.uk",
    "angelica.borer@schimmeloconner.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "10967482",
    "SuperOffice:2": "Jude Lakin"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "fuga"
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
      "FieldLength": 755
    }
  }
}
```