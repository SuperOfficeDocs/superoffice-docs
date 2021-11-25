---
title: POST Agents/Person/CreateDefaultByContactId
id: v1PersonAgent_CreateDefaultByContactId
---

# POST Agents/Person/CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
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

## Request Body: request  

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |


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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 292
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 291,
  "Firstname": "Eva",
  "MiddleName": "Mills-Gorczany",
  "Lastname": "Lowe",
  "Mrmrs": "consequatur",
  "Title": "eaque",
  "UpdatedDate": "1998-03-03T18:28:49.7081369+01:00",
  "CreatedDate": "2002-01-05T18:28:49.7081369+01:00",
  "BirthDate": "2006-03-10T18:28:49.7081369+01:00",
  "CreatedBy": {
    "AssociateId": 3,
    "Name": "Tillman, Jaskolski and Hansen",
    "PersonId": 312,
    "Rank": 471,
    "Tooltip": "blanditiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 129,
    "FullName": "Chaim Rogahn III",
    "FormalName": "Hodkiewicz Group",
    "Deleted": false,
    "EjUserId": 513,
    "UserName": "Ernser, Pacocha and Glover",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 838
      }
    }
  },
  "Emails": [
    {
      "Value": "veniam",
      "StrippedValue": "ut",
      "Description": "Re-contextualized secondary software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "ut",
      "Description": "Re-contextualized secondary software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "Description": "Visionary zero tolerance focus group",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quam",
      "StrippedValue": "aut",
      "Description": "Self-enabling value-added projection",
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
    {
      "Value": "quam",
      "StrippedValue": "aut",
      "Description": "Self-enabling value-added projection",
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
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "laborum",
      "Description": "Exclusive object-oriented solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "laborum",
      "Description": "Exclusive object-oriented solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "rem",
      "StrippedValue": "et",
      "Description": "Adaptive content-based groupware",
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
    {
      "Value": "rem",
      "StrippedValue": "et",
      "Description": "Adaptive content-based groupware",
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
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "placeat",
      "Description": "Networked multi-state success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "placeat",
      "Description": "Networked multi-state success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "inventore",
      "StrippedValue": "sit",
      "Description": "Future-proofed non-volatile project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 661
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "sit",
      "Description": "Future-proofed non-volatile project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 661
        }
      }
    }
  ],
  "Position": {
    "Id": 145,
    "Value": "itaque",
    "Tooltip": "eveniet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 160
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 310,
    "Name": "Greenfelder, Howe and Kulas",
    "PersonId": 765,
    "Rank": 506,
    "Tooltip": "adipisci",
    "Type": "AnonymousAssociate",
    "GroupIdx": 477,
    "FullName": "Tania Pouros",
    "FormalName": "Grimes, Sporer and Orn",
    "Deleted": false,
    "EjUserId": 695,
    "UserName": "O'Keefe-Corwin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 291
      }
    }
  },
  "Contact": {
    "ContactId": 813,
    "Name": "Rosenbaum, West and Leffler",
    "OrgNr": "1661915",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptas",
    "DirectPhone": "(751)485-2227 x8402",
    "AssociateId": 655,
    "CountryId": 340,
    "EmailAddress": "madaline_mertz@bartolettikovacek.biz",
    "Kananame": "odio",
    "EmailAddressName": "tyshawn_beer@crona.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jaydon Skiles",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "non",
    "FullName": "Guillermo Fay",
    "IsOwnerContact": true,
    "ActiveErpLinks": 842,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 878
      }
    }
  },
  "Country": {
    "CountryId": 471,
    "Name": "Durgan Inc and Sons",
    "CurrencyId": 172,
    "EnglishName": "Schneider Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Open-architected actuating initiative",
    "OrgNrText": "1180960",
    "InterAreaPrefix": "quia",
    "DialInPrefix": "vel",
    "ZipPrefix": "aut",
    "DomainName": "Hand-Stiedemann",
    "AddressLayoutId": 936,
    "DomesticAddressLayoutId": 935,
    "ForeignAddressLayoutId": 20,
    "Rank": 204,
    "Tooltip": "et",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 126
      }
    }
  },
  "Interests": [
    {
      "Id": 71,
      "Name": "Wiza LLC",
      "ToolTip": "Ea voluptatem accusantium modi sapiente assumenda modi.",
      "Deleted": false,
      "Rank": 40,
      "Type": "inventore",
      "ColorBlock": 390,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "2015-09-10T18:28:49.7111094+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laborum",
      "StyleHint": "ad",
      "Hidden": true,
      "FullName": "Nyasia Abernathy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 767
        }
      }
    }
  ],
  "PersonNumber": "987213",
  "FullName": "Cole Jast",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "dolorem",
      "Description": "Realigned dynamic capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "dolorem",
      "Description": "Realigned dynamic capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    }
  ],
  "FormalName": "Ullrich, Treutel and Larkin",
  "Address": {
    "Wgs84Latitude": 13842.877999999999,
    "Wgs84Longitude": 25842.964,
    "LocalizedAddress": [
      [
        {
          "Name": "O'Kon-Hudson",
          "Value": "voluptatem",
          "Tooltip": "exercitationem",
          "Label": "blanditiis",
          "ValueLength": 3,
          "AddressType": "pariatur",
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
              "FieldLength": 809
            }
          }
        }
      ],
      [
        {
          "Name": "Rau-Wunsch",
          "Value": "molestiae",
          "Tooltip": "fugit",
          "Label": "reprehenderit",
          "ValueLength": 842,
          "AddressType": "vero",
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
              "FieldLength": 262
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 275
      }
    }
  },
  "Post3": "enim",
  "Post2": "et",
  "Post1": "nobis",
  "Kanalname": "aut",
  "Kanafname": "sunt",
  "CorrespondingAssociate": {
    "AssociateId": 68,
    "Name": "Spinka, Schaden and Rempel",
    "PersonId": 590,
    "Rank": 271,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 842,
    "FullName": "Clinton Yost",
    "FormalName": "Kreiger-Volkman",
    "Deleted": false,
    "EjUserId": 643,
    "UserName": "Jaskolski, Lebsack and Carroll",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 396
      }
    }
  },
  "Category": {
    "Id": 317,
    "Value": "nihil",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 584
      }
    }
  },
  "Business": {
    "Id": 534,
    "Value": "provident",
    "Tooltip": "beatae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enable magnetic systems"
        },
        "FieldType": "System.Int32",
        "FieldLength": 425
      }
    }
  },
  "Associate": {
    "AssociateId": 258,
    "Name": "Runte-Stroman",
    "PersonId": 368,
    "Rank": 66,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 136,
    "FullName": "Bette Dickinson",
    "FormalName": "Huel, Blanda and Harris",
    "Deleted": false,
    "EjUserId": 554,
    "UserName": "Graham-Willms",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 62
      }
    }
  },
  "Salutation": "est",
  "ActiveInterests": 377,
  "SupportAssociate": {
    "AssociateId": 974,
    "Name": "O'Kon LLC",
    "PersonId": 972,
    "Rank": 61,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 679,
    "FullName": "Alexane Cronin",
    "FormalName": "Hyatt, Schmitt and Jerde",
    "Deleted": true,
    "EjUserId": 125,
    "UserName": "Bins Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark intuitive e-tailers"
        },
        "FieldType": "System.Int32",
        "FieldLength": 132
      }
    }
  },
  "TicketPriority": {
    "Id": 550,
    "Value": "reprehenderit",
    "Tooltip": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 618
      }
    }
  },
  "CustomerLanguage": {
    "Id": 225,
    "Value": "et",
    "Tooltip": "architecto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 128
      }
    }
  },
  "DbiAgentId": 987,
  "DbiKey": "quo",
  "DbiLastModified": "1997-03-01T18:28:49.714143+01:00",
  "DbiLastSyncronized": "2003-06-25T18:28:49.714143+02:00",
  "SentInfo": 549,
  "ShowContactTickets": 532,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 160,
    "UserName": "Lubowitz-Stroman",
    "PersonId": 833,
    "Rank": 765,
    "Tooltip": "aut",
    "UserGroupId": 709,
    "EjUserId": 373,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "doloribus",
      "ut"
    ],
    "CanLogon": false,
    "RoleName": "Cruickshank, Farrell and Schroeder",
    "RoleTooltip": "id",
    "UserGroupName": "Lehner-Davis",
    "UserGroupTooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 635
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "autem",
      "StrippedValue": "voluptatum",
      "Description": "Enhanced demand-driven portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate frictionless portals"
          },
          "FieldType": "System.String",
          "FieldLength": 982
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "voluptatum",
      "Description": "Enhanced demand-driven portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate frictionless portals"
          },
          "FieldType": "System.String",
          "FieldLength": 982
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolores",
      "StrippedValue": "aut",
      "Description": "Synchronised attitude-oriented installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "aut",
      "Description": "Synchronised attitude-oriented installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    }
  ],
  "Source": 120,
  "ActiveErpLinks": 24,
  "ShipmentTypes": [
    {
      "Id": 688,
      "Name": "Kirlin, McKenzie and Lang",
      "ToolTip": "Id maxime.",
      "Deleted": false,
      "Rank": 128,
      "Type": "voluptatem",
      "ColorBlock": 722,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "1997-10-25T18:28:49.715143+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Malinda Tromp",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 528
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 659,
      "Comment": "illo",
      "Registered": "2019-02-05T18:28:49.715143+01:00",
      "RegisteredAssociateId": 243,
      "Updated": "2020-03-14T18:28:49.715143+01:00",
      "UpdatedAssociateId": 573,
      "LegalBaseId": 679,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Altenwerth Inc and Sons",
      "ConsentPurposeId": 580,
      "ConsentPurposeKey": "dolor",
      "ConsentPurposeName": "Cole, Becker and Rice",
      "ConsentSourceId": 222,
      "ConsentSourceKey": "omnis",
      "ConsentSourceName": "Hegmann LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 691
        }
      }
    }
  ],
  "BounceEmails": [
    "jovany@emmerichborer.biz",
    "crystal.yundt@johnson.info"
  ],
  "ActiveStatusMonitorId": 66,
  "UserDefinedFields": {
    "SuperOffice:1": "Sanford Tillman",
    "SuperOffice:2": "Giovani Gutmann"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "possimus"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "necessitatibus"
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
      "FieldLength": 490
    }
  }
}
```