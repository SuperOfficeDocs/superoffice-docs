---
title: POST Agents/EMail/GetPersonEntitiesFromEmailAddress
id: v1EMailAgent_GetPersonEntitiesFromEmailAddress
---

# POST Agents/EMail/GetPersonEntitiesFromEmailAddress

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
```

Get all persons and contacts with the given email address



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress?$select=name,department,category/id
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

EmailAddress 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "skye.kiehn@erdman.us"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 961,
    "Firstname": "Yadira",
    "MiddleName": "Gutkowski-Ritchie",
    "Lastname": "Nicolas",
    "Mrmrs": "consequuntur",
    "Title": "dignissimos",
    "UpdatedDate": "1996-08-07T18:28:49.0999287+02:00",
    "CreatedDate": "2008-11-17T18:28:49.0999287+01:00",
    "BirthDate": "2019-12-22T18:28:49.0999287+01:00",
    "CreatedBy": {
      "AssociateId": 700,
      "Name": "Witting, Denesik and Hintz",
      "PersonId": 780,
      "Rank": 540,
      "Tooltip": "sequi",
      "Type": "AnonymousAssociate",
      "GroupIdx": 422,
      "FullName": "Mr. Charlotte Strosin",
      "FormalName": "Hermiston-Gaylord",
      "Deleted": true,
      "EjUserId": 964,
      "UserName": "Parisian Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    },
    "Emails": [
      {
        "Value": "fuga",
        "StrippedValue": "qui",
        "Description": "Quality-focused multi-tasking installation",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 76
          }
        }
      },
      {
        "Value": "fuga",
        "StrippedValue": "qui",
        "Description": "Quality-focused multi-tasking installation",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 76
          }
        }
      }
    ],
    "Description": "Public-key full-range orchestration",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "ducimus",
        "StrippedValue": "minima",
        "Description": "Phased high-level collaboration",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 626
          }
        }
      },
      {
        "Value": "ducimus",
        "StrippedValue": "minima",
        "Description": "Phased high-level collaboration",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 626
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "aut",
        "StrippedValue": "quia",
        "Description": "Re-contextualized full-range definition",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "syndicate magnetic models"
            },
            "FieldType": "System.String",
            "FieldLength": 352
          }
        }
      },
      {
        "Value": "aut",
        "StrippedValue": "quia",
        "Description": "Re-contextualized full-range definition",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "syndicate magnetic models"
            },
            "FieldType": "System.String",
            "FieldLength": 352
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "facere",
        "StrippedValue": "accusamus",
        "Description": "Face to face local strategy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "transition B2C communities"
            },
            "FieldType": "System.Int32",
            "FieldLength": 496
          }
        }
      },
      {
        "Value": "facere",
        "StrippedValue": "accusamus",
        "Description": "Face to face local strategy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "transition B2C communities"
            },
            "FieldType": "System.Int32",
            "FieldLength": 496
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "labore",
        "StrippedValue": "quasi",
        "Description": "Proactive analyzing capacity",
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
      {
        "Value": "labore",
        "StrippedValue": "quasi",
        "Description": "Proactive analyzing capacity",
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
      }
    ],
    "OtherPhones": [
      {
        "Value": "esse",
        "StrippedValue": "deserunt",
        "Description": "Organic explicit policy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 708
          }
        }
      },
      {
        "Value": "esse",
        "StrippedValue": "deserunt",
        "Description": "Organic explicit policy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 708
          }
        }
      }
    ],
    "Position": {
      "Id": 908,
      "Value": "consequatur",
      "Tooltip": "placeat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    },
    "UpdatedBy": {
      "AssociateId": 499,
      "Name": "Ryan, Bergstrom and Swaniawski",
      "PersonId": 645,
      "Rank": 369,
      "Tooltip": "expedita",
      "Type": "AnonymousAssociate",
      "GroupIdx": 1001,
      "FullName": "Sarah Braun",
      "FormalName": "Cremin-Nitzsche",
      "Deleted": false,
      "EjUserId": 563,
      "UserName": "Maggio-West",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 334
        }
      }
    },
    "Contact": {
      "ContactId": 973,
      "Name": "Aufderhar, Hamill and Turner",
      "OrgNr": "1137754",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "quo",
      "DirectPhone": "168-855-6830 x7640",
      "AssociateId": 590,
      "CountryId": 198,
      "EmailAddress": "emiliano_howe@nolan.biz",
      "Kananame": "inventore",
      "EmailAddressName": "edgardo@bernier.info",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Jolie Kozey",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "facilis",
      "FullName": "Tanya Haley",
      "IsOwnerContact": false,
      "ActiveErpLinks": 526,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    },
    "Country": {
      "CountryId": 561,
      "Name": "Haley Group",
      "CurrencyId": 646,
      "EnglishName": "Rau Inc and Sons",
      "TwoLetterISOCountry": "Sokovia",
      "ThreeLetterISOCountry": "Sokovia",
      "ImageDescription": "Implemented incremental circuit",
      "OrgNrText": "577260",
      "InterAreaPrefix": "nostrum",
      "DialInPrefix": "at",
      "ZipPrefix": "optio",
      "DomainName": "Schuppe, Wiegand and Nader",
      "AddressLayoutId": 645,
      "DomesticAddressLayoutId": 554,
      "ForeignAddressLayoutId": 115,
      "Rank": 407,
      "Tooltip": "sunt",
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    },
    "Interests": [
      {
        "Id": 502,
        "Name": "Wisozk LLC",
        "ToolTip": "Consequuntur quia deserunt eos.",
        "Deleted": false,
        "Rank": 765,
        "Type": "dolor",
        "ColorBlock": 323,
        "IconHint": "commodi",
        "Selected": false,
        "LastChanged": "2001-01-03T18:28:49.101961+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "labore",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Bill Legros",
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
      }
    ],
    "PersonNumber": "1873783",
    "FullName": "Llewellyn Borer",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": true,
    "Urls": [
      {
        "Value": "sunt",
        "StrippedValue": "tempora",
        "Description": "Sharable national structure",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 212
          }
        }
      },
      {
        "Value": "sunt",
        "StrippedValue": "tempora",
        "Description": "Sharable national structure",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 212
          }
        }
      }
    ],
    "FormalName": "Bernier Group",
    "Address": {
      "Wgs84Latitude": 20154.754,
      "Wgs84Longitude": 7778.588,
      "LocalizedAddress": [
        [
          {
            "Name": "Toy-Lowe",
            "Value": "nisi",
            "Tooltip": "voluptatem",
            "Label": "voluptas",
            "ValueLength": 505,
            "AddressType": "dolorem",
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
                "FieldLength": 284
              }
            }
          }
        ],
        [
          {
            "Name": "Barrows, Jast and VonRueden",
            "Value": "saepe",
            "Tooltip": "delectus",
            "Label": "est",
            "ValueLength": 271,
            "AddressType": "error",
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
                "FieldLength": 613
              }
            }
          }
        ]
      ],
      "Street": {},
      "Postal": {},
      "Formatted": "quae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 387
        }
      }
    },
    "Post3": "nam",
    "Post2": "excepturi",
    "Post1": "at",
    "Kanalname": "sit",
    "Kanafname": "non",
    "CorrespondingAssociate": {
      "AssociateId": 617,
      "Name": "Nitzsche, Botsford and Okuneva",
      "PersonId": 507,
      "Rank": 383,
      "Tooltip": "deserunt",
      "Type": "AnonymousAssociate",
      "GroupIdx": 299,
      "FullName": "Sydni Leffler",
      "FormalName": "Kshlerin Inc and Sons",
      "Deleted": true,
      "EjUserId": 696,
      "UserName": "Walker Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    },
    "Category": {
      "Id": 739,
      "Value": "numquam",
      "Tooltip": "sint",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    },
    "Business": {
      "Id": 675,
      "Value": "odit",
      "Tooltip": "soluta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 815
        }
      }
    },
    "Associate": {
      "AssociateId": 89,
      "Name": "Romaguera-Ledner",
      "PersonId": 384,
      "Rank": 899,
      "Tooltip": "aspernatur",
      "Type": "AnonymousAssociate",
      "GroupIdx": 552,
      "FullName": "Dr. Leonora Brekke",
      "FormalName": "Kassulke-Runolfsson",
      "Deleted": false,
      "EjUserId": 85,
      "UserName": "Kirlin, Bogan and Cruickshank",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    },
    "Salutation": "ullam",
    "ActiveInterests": 16,
    "SupportAssociate": {
      "AssociateId": 576,
      "Name": "Bruen LLC",
      "PersonId": 447,
      "Rank": 119,
      "Tooltip": "non",
      "Type": "AnonymousAssociate",
      "GroupIdx": 319,
      "FullName": "Dr. Kirsten Fadel",
      "FormalName": "Spencer Inc and Sons",
      "Deleted": true,
      "EjUserId": 502,
      "UserName": "Veum-Reynolds",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    },
    "TicketPriority": {
      "Id": 208,
      "Value": "soluta",
      "Tooltip": "voluptas",
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
    "CustomerLanguage": {
      "Id": 758,
      "Value": "velit",
      "Tooltip": "corrupti",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 768
        }
      }
    },
    "DbiAgentId": 672,
    "DbiKey": "molestias",
    "DbiLastModified": "1996-03-22T18:28:49.1049619+01:00",
    "DbiLastSyncronized": "2006-10-18T18:28:49.1049619+02:00",
    "SentInfo": 9,
    "ShowContactTickets": 397,
    "UserInfo": {
      "Deleted": false,
      "UserInfoId": 427,
      "UserName": "Brakus, Spencer and Okuneva",
      "PersonId": 175,
      "Rank": 52,
      "Tooltip": "voluptates",
      "UserGroupId": 449,
      "EjUserId": 533,
      "UserType": "AnonymousAssociate",
      "GrantedLicenses": [
        "sequi",
        "tenetur"
      ],
      "CanLogon": true,
      "RoleName": "Bruen-Stoltenberg",
      "RoleTooltip": "perferendis",
      "UserGroupName": "Hermann-Swaniawski",
      "UserGroupTooltip": "enim",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    },
    "ChatEmails": [
      {
        "Value": "provident",
        "StrippedValue": "totam",
        "Description": "Ameliorated incremental benchmark",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 221
          }
        }
      },
      {
        "Value": "provident",
        "StrippedValue": "totam",
        "Description": "Ameliorated incremental benchmark",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 221
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "quas",
        "StrippedValue": "porro",
        "Description": "Face to face incremental methodology",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 897
          }
        }
      },
      {
        "Value": "quas",
        "StrippedValue": "porro",
        "Description": "Face to face incremental methodology",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 897
          }
        }
      }
    ],
    "Source": 535,
    "ActiveErpLinks": 87,
    "ShipmentTypes": [
      {
        "Id": 415,
        "Name": "Rogahn Group",
        "ToolTip": "Et quia hic facilis ut eos laborum.",
        "Deleted": true,
        "Rank": 687,
        "Type": "iusto",
        "ColorBlock": 117,
        "IconHint": "iste",
        "Selected": false,
        "LastChanged": "2009-12-27T18:28:49.1049619+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "sequi",
        "Hidden": false,
        "FullName": "Bethany Weissnat",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 998
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 16,
        "Comment": "eum",
        "Registered": "2000-10-18T18:28:49.1049619+02:00",
        "RegisteredAssociateId": 168,
        "Updated": "2014-09-04T18:28:49.1049619+02:00",
        "UpdatedAssociateId": 652,
        "LegalBaseId": 829,
        "LegalBaseKey": "recusandae",
        "LegalBaseName": "Cummings-Braun",
        "ConsentPurposeId": 914,
        "ConsentPurposeKey": "fuga",
        "ConsentPurposeName": "Marquardt Group",
        "ConsentSourceId": 340,
        "ConsentSourceKey": "est",
        "ConsentSourceName": "Cole, Johnson and Schroeder",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "aggregate clicks-and-mortar paradigms"
            },
            "FieldType": "System.String",
            "FieldLength": 85
          }
        }
      }
    ],
    "BounceEmails": [
      "francisco_cronin@whitebednar.name",
      "casimer_lehner@bechtelar.name"
    ],
    "ActiveStatusMonitorId": 490,
    "UserDefinedFields": {
      "SuperOffice:1": "Humberto Dare",
      "SuperOffice:2": "167572911"
    },
    "ExtraFields": {
      "ExtraFields1": "aliquid",
      "ExtraFields2": "delectus"
    },
    "CustomFields": {
      "CustomFields1": "dolorum",
      "CustomFields2": "officiis"
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
        "FieldLength": 469
      }
    }
  }
]
```