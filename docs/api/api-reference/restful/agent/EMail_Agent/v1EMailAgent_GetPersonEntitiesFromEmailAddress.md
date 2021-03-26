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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "ruth@dickens.info"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 846,
    "Firstname": "Corrine",
    "MiddleName": "Koelpin, Daugherty and Kessler",
    "Lastname": "Maggio",
    "Mrmrs": "amet",
    "Title": "pariatur",
    "UpdatedDate": "2012-05-16T16:48:29.5719242+02:00",
    "CreatedDate": "2005-06-18T16:48:29.5719242+02:00",
    "BirthDate": "2006-03-28T16:48:29.5719242+02:00",
    "CreatedBy": {
      "AssociateId": 54,
      "Name": "Donnelly-Reichel",
      "PersonId": 455,
      "Rank": 910,
      "Tooltip": "vero",
      "Type": "AnonymousAssociate",
      "GroupIdx": 72,
      "FullName": "Geovany Zulauf",
      "FormalName": "Yost-Brekke",
      "Deleted": true,
      "EjUserId": 994,
      "UserName": "Hand, Bradtke and Barrows",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    },
    "Emails": [
      {
        "Value": "commodi",
        "StrippedValue": "ea",
        "Description": "Fully-configurable 5th generation parallelism",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 220
          }
        }
      },
      {
        "Value": "commodi",
        "StrippedValue": "ea",
        "Description": "Fully-configurable 5th generation parallelism",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 220
          }
        }
      }
    ],
    "Description": "Programmable asynchronous throughput",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "et",
        "StrippedValue": "dolorum",
        "Description": "Secured grid-enabled time-frame",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 860
          }
        }
      },
      {
        "Value": "et",
        "StrippedValue": "dolorum",
        "Description": "Secured grid-enabled time-frame",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 860
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "magnam",
        "StrippedValue": "voluptatem",
        "Description": "Upgradable solution-oriented product",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 716
          }
        }
      },
      {
        "Value": "magnam",
        "StrippedValue": "voluptatem",
        "Description": "Upgradable solution-oriented product",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 716
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "omnis",
        "StrippedValue": "expedita",
        "Description": "Object-based multi-state benchmark",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 845
          }
        }
      },
      {
        "Value": "omnis",
        "StrippedValue": "expedita",
        "Description": "Object-based multi-state benchmark",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 845
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "fugit",
        "StrippedValue": "nam",
        "Description": "Reduced bottom-line hierarchy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 632
          }
        }
      },
      {
        "Value": "fugit",
        "StrippedValue": "nam",
        "Description": "Reduced bottom-line hierarchy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 632
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "molestias",
        "StrippedValue": "ipsa",
        "Description": "Up-sized upward-trending functionalities",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 339
          }
        }
      },
      {
        "Value": "molestias",
        "StrippedValue": "ipsa",
        "Description": "Up-sized upward-trending functionalities",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 339
          }
        }
      }
    ],
    "Position": {
      "Id": 272,
      "Value": "sequi",
      "Tooltip": "eos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 189
        }
      }
    },
    "UpdatedBy": {
      "AssociateId": 33,
      "Name": "Pollich, Bernhard and Hartmann",
      "PersonId": 904,
      "Rank": 272,
      "Tooltip": "et",
      "Type": "AnonymousAssociate",
      "GroupIdx": 978,
      "FullName": "Luz Gleason",
      "FormalName": "Greenfelder Inc and Sons",
      "Deleted": true,
      "EjUserId": 738,
      "UserName": "Kunze Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 845
        }
      }
    },
    "Contact": {
      "ContactId": 114,
      "Name": "Walsh-Auer",
      "OrgNr": "700885",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "animi",
      "DirectPhone": "(736)052-2348 x567",
      "AssociateId": 533,
      "CountryId": 959,
      "EmailAddress": "kelly@pfefferdibbert.ca",
      "Kananame": "tempora",
      "EmailAddressName": "patrick@cremin.info",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Oda Orn",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "voluptatum",
      "FullName": "Nina Rau",
      "IsOwnerContact": false,
      "ActiveErpLinks": 187,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    },
    "Country": {
      "CountryId": 221,
      "Name": "Okuneva-Huel",
      "CurrencyId": 62,
      "EnglishName": "Muller Inc and Sons",
      "TwoLetterISOCountry": "Sokovia",
      "ThreeLetterISOCountry": "Sokovia",
      "ImageDescription": "Distributed fresh-thinking support",
      "OrgNrText": "667699",
      "InterAreaPrefix": "incidunt",
      "DialInPrefix": "nesciunt",
      "ZipPrefix": "dolorem",
      "DomainName": "Harvey, Steuber and Blanda",
      "AddressLayoutId": 42,
      "DomesticAddressLayoutId": 56,
      "ForeignAddressLayoutId": 184,
      "Rank": 713,
      "Tooltip": "accusantium",
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    },
    "Interests": [
      {
        "Id": 273,
        "Name": "Bradtke-Rosenbaum",
        "ToolTip": "Iste neque perspiciatis in aliquam.",
        "Deleted": false,
        "Rank": 991,
        "Type": "perspiciatis",
        "ColorBlock": 486,
        "IconHint": "accusantium",
        "Selected": false,
        "LastChanged": "2017-11-26T16:48:29.5749265+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "excepturi",
        "StyleHint": "exercitationem",
        "Hidden": false,
        "FullName": "Serenity Harber",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "visualize impactful ROI"
            },
            "FieldType": "System.Int32",
            "FieldLength": 806
          }
        }
      }
    ],
    "PersonNumber": "1756095",
    "FullName": "Gregorio Considine",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {
        "Value": "illum",
        "StrippedValue": "et",
        "Description": "Persevering client-driven frame",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 520
          }
        }
      },
      {
        "Value": "illum",
        "StrippedValue": "et",
        "Description": "Persevering client-driven frame",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 520
          }
        }
      }
    ],
    "FormalName": "Stoltenberg Group",
    "Address": {
      "Wgs84Latitude": 3889.294,
      "Wgs84Longitude": 15087.076,
      "LocalizedAddress": [
        [
          {
            "Name": "Olson-Ernser",
            "Value": "praesentium",
            "Tooltip": "totam",
            "Label": "aut",
            "ValueLength": 791,
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
                "FieldType": "System.String",
                "FieldLength": 726
              }
            }
          }
        ],
        [
          {
            "Name": "Krajcik LLC",
            "Value": "quis",
            "Tooltip": "esse",
            "Label": "non",
            "ValueLength": 45,
            "AddressType": "soluta",
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
                "FieldLength": 485
              }
            }
          }
        ]
      ],
      "Street": {},
      "Postal": {},
      "Formatted": "ipsum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    },
    "Post3": "et",
    "Post2": "est",
    "Post1": "at",
    "Kanalname": "libero",
    "Kanafname": "eos",
    "CorrespondingAssociate": {
      "AssociateId": 821,
      "Name": "Abernathy-Corkery",
      "PersonId": 374,
      "Rank": 63,
      "Tooltip": "quod",
      "Type": "AnonymousAssociate",
      "GroupIdx": 426,
      "FullName": "Eladio Stamm",
      "FormalName": "Yundt-Lowe",
      "Deleted": false,
      "EjUserId": 253,
      "UserName": "Jerde, Huel and Prohaska",
      "TableRight": {},
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
    },
    "Category": {
      "Id": 591,
      "Value": "non",
      "Tooltip": "aperiam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    },
    "Business": {
      "Id": 42,
      "Value": "quo",
      "Tooltip": "maiores",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 927
        }
      }
    },
    "Associate": {
      "AssociateId": 635,
      "Name": "Wilderman, Armstrong and Price",
      "PersonId": 959,
      "Rank": 211,
      "Tooltip": "et",
      "Type": "AnonymousAssociate",
      "GroupIdx": 746,
      "FullName": "Ms. Alicia Windler",
      "FormalName": "Kovacek, Feest and Lehner",
      "Deleted": true,
      "EjUserId": 390,
      "UserName": "Hermann, Bauch and Harvey",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 143
        }
      }
    },
    "Salutation": "non",
    "ActiveInterests": 805,
    "SupportAssociate": {
      "AssociateId": 996,
      "Name": "Harris LLC",
      "PersonId": 537,
      "Rank": 576,
      "Tooltip": "magnam",
      "Type": "AnonymousAssociate",
      "GroupIdx": 280,
      "FullName": "Leatha Berge Sr.",
      "FormalName": "Gleichner-Swaniawski",
      "Deleted": true,
      "EjUserId": 515,
      "UserName": "Beer, Homenick and Lesch",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 679
        }
      }
    },
    "TicketPriority": {
      "Id": 753,
      "Value": "ea",
      "Tooltip": "ab",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    },
    "CustomerLanguage": {
      "Id": 708,
      "Value": "ut",
      "Tooltip": "sed",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    },
    "DbiAgentId": 755,
    "DbiKey": "ut",
    "DbiLastModified": "2009-07-30T16:48:29.5779302+02:00",
    "DbiLastSyncronized": "1994-07-30T16:48:29.5779302+02:00",
    "SentInfo": 937,
    "ShowContactTickets": 916,
    "UserInfo": {
      "Deleted": true,
      "UserInfoId": 241,
      "UserName": "Monahan, O'Reilly and Kulas",
      "PersonId": 942,
      "Rank": 624,
      "Tooltip": "minima",
      "UserGroupId": 540,
      "EjUserId": 747,
      "UserType": "AnonymousAssociate",
      "GrantedLicenses": [
        "deleniti",
        "reiciendis"
      ],
      "CanLogon": true,
      "RoleName": "Greenfelder-Thiel",
      "RoleTooltip": "voluptas",
      "UserGroupName": "DuBuque, Jones and Gerlach",
      "UserGroupTooltip": "recusandae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 468
        }
      }
    },
    "ChatEmails": [
      {
        "Value": "maxime",
        "StrippedValue": "adipisci",
        "Description": "Open-architected multimedia conglomeration",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 926
          }
        }
      },
      {
        "Value": "maxime",
        "StrippedValue": "adipisci",
        "Description": "Open-architected multimedia conglomeration",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 926
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "et",
        "StrippedValue": "voluptate",
        "Description": "Extended systematic database",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 37
          }
        }
      },
      {
        "Value": "et",
        "StrippedValue": "voluptate",
        "Description": "Extended systematic database",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 37
          }
        }
      }
    ],
    "Source": 690,
    "ActiveErpLinks": 476,
    "ShipmentTypes": [
      {
        "Id": 969,
        "Name": "Ferry-Feest",
        "ToolTip": "Est blanditiis tenetur.",
        "Deleted": false,
        "Rank": 280,
        "Type": "nihil",
        "ColorBlock": 597,
        "IconHint": "laudantium",
        "Selected": false,
        "LastChanged": "2011-08-07T16:48:29.5779302+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sequi",
        "StyleHint": "voluptas",
        "Hidden": true,
        "FullName": "Wilber Stanton",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 108
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 332,
        "Comment": "nam",
        "Registered": "2019-09-03T16:48:29.5789307+02:00",
        "RegisteredAssociateId": 410,
        "Updated": "2015-01-14T16:48:29.5789307+01:00",
        "UpdatedAssociateId": 110,
        "LegalBaseId": 412,
        "LegalBaseKey": "iure",
        "LegalBaseName": "Little Group",
        "ConsentPurposeId": 944,
        "ConsentPurposeKey": "corrupti",
        "ConsentPurposeName": "Pagac, Waters and Schinner",
        "ConsentSourceId": 664,
        "ConsentSourceKey": "doloribus",
        "ConsentSourceName": "Blanda, Nader and Ward",
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
      }
    ],
    "BounceEmails": [
      "dora_kohler@greenholthickle.com",
      "fiona.hintz@carroll.info"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "Gerson Kiehn I"
    },
    "ExtraFields": {
      "ExtraFields1": "dolor",
      "ExtraFields2": "est"
    },
    "CustomFields": {
      "CustomFields1": "deleniti",
      "CustomFields2": "deserunt"
    },
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "grow cross-media channels"
        },
        "FieldType": "System.String",
        "FieldLength": 494
      }
    }
  }
]
```