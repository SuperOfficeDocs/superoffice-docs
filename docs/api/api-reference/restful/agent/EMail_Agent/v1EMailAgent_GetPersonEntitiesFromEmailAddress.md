---
title: GetPersonEntitiesFromEmailAddress
id: v1EMailAgent_GetPersonEntitiesFromEmailAddress
---

# GetPersonEntitiesFromEmailAddress

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "abigail@dachhilpert.uk"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 605,
    "Firstname": "Eladio",
    "MiddleName": "Little-Klocko",
    "Lastname": "Schoen",
    "Mrmrs": "voluptatem",
    "Title": "qui",
    "UpdatedDate": "2000-07-27T14:58:04.1904604+02:00",
    "CreatedDate": "1998-04-29T14:58:04.1904604+02:00",
    "BirthDate": "2021-03-21T14:58:04.1904604+01:00",
    "CreatedBy": {
      "AssociateId": 491,
      "Name": "Lakin LLC",
      "PersonId": 166,
      "Rank": 700,
      "Tooltip": "et",
      "Type": "AnonymousAssociate",
      "GroupIdx": 224,
      "FullName": "Mr. Monty Goodwin",
      "FormalName": "Doyle, Skiles and Becker",
      "Deleted": false,
      "EjUserId": 445,
      "UserName": "Medhurst LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    },
    "Emails": [
      {
        "Value": "dolorum",
        "StrippedValue": "ea",
        "Description": "Persevering didactic infrastructure",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "synthesize front-end models"
            },
            "FieldType": "System.String",
            "FieldLength": 159
          }
        }
      },
      {
        "Value": "dolorum",
        "StrippedValue": "ea",
        "Description": "Persevering didactic infrastructure",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "synthesize front-end models"
            },
            "FieldType": "System.String",
            "FieldLength": 159
          }
        }
      }
    ],
    "Description": "Focused secondary approach",
    "IsAssociate": true,
    "PrivatePhones": [
      {
        "Value": "qui",
        "StrippedValue": "dolores",
        "Description": "Stand-alone even-keeled Graphic Interface",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 897
          }
        }
      },
      {
        "Value": "qui",
        "StrippedValue": "dolores",
        "Description": "Stand-alone even-keeled Graphic Interface",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 897
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "inventore",
        "StrippedValue": "laboriosam",
        "Description": "Synchronised intermediate customer loyalty",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 773
          }
        }
      },
      {
        "Value": "inventore",
        "StrippedValue": "laboriosam",
        "Description": "Synchronised intermediate customer loyalty",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 773
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "non",
        "StrippedValue": "soluta",
        "Description": "Exclusive empowering system engine",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 438
          }
        }
      },
      {
        "Value": "non",
        "StrippedValue": "soluta",
        "Description": "Exclusive empowering system engine",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 438
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "adipisci",
        "StrippedValue": "enim",
        "Description": "Virtual responsive process improvement",
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
        "Value": "adipisci",
        "StrippedValue": "enim",
        "Description": "Virtual responsive process improvement",
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
    "OtherPhones": [
      {
        "Value": "odio",
        "StrippedValue": "expedita",
        "Description": "Innovative secondary methodology",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "aggregate vertical mindshare"
            },
            "FieldType": "System.Int32",
            "FieldLength": 4
          }
        }
      },
      {
        "Value": "odio",
        "StrippedValue": "expedita",
        "Description": "Innovative secondary methodology",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "aggregate vertical mindshare"
            },
            "FieldType": "System.Int32",
            "FieldLength": 4
          }
        }
      }
    ],
    "Position": {
      "Id": 491,
      "Value": "sunt",
      "Tooltip": "aliquam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    },
    "UpdatedBy": {
      "AssociateId": 61,
      "Name": "Flatley, Littel and Mayert",
      "PersonId": 451,
      "Rank": 905,
      "Tooltip": "perferendis",
      "Type": "AnonymousAssociate",
      "GroupIdx": 515,
      "FullName": "Connor Effertz",
      "FormalName": "White-Brown",
      "Deleted": false,
      "EjUserId": 926,
      "UserName": "Farrell-Wintheiser",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    },
    "Contact": {
      "ContactId": 659,
      "Name": "Treutel, Crist and Roberts",
      "OrgNr": "1673202",
      "Department": "synergize plug-and-play platforms",
      "URL": "http://www.example.com/",
      "City": "doloremque",
      "DirectPhone": "220.782.2841 x147",
      "AssociateId": 494,
      "CountryId": 53,
      "EmailAddress": "devyn@feilboyle.info",
      "Kananame": "repellat",
      "EmailAddressName": "cary_wiegand@schoen.info",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Lyla Harber",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "sint",
      "FullName": "Lucas Nienow",
      "IsOwnerContact": false,
      "ActiveErpLinks": 198,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 15
        }
      }
    },
    "Country": {
      "CountryId": 299,
      "Name": "Feil Inc and Sons",
      "CurrencyId": 314,
      "EnglishName": "Lakin, Bartell and Waters",
      "TwoLetterISOCountry": "Sokovia",
      "ThreeLetterISOCountry": "Sokovia",
      "ImageDescription": "Self-enabling 24/7 extranet",
      "OrgNrText": "818330",
      "InterAreaPrefix": "quis",
      "DialInPrefix": "quia",
      "ZipPrefix": "nemo",
      "DomainName": "Schinner LLC",
      "AddressLayoutId": 112,
      "DomesticAddressLayoutId": 134,
      "ForeignAddressLayoutId": 146,
      "Rank": 624,
      "Tooltip": "magnam",
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    },
    "Interests": [
      {
        "Id": 867,
        "Name": "Ratke-Wehner",
        "ToolTip": "Asperiores ullam vel porro.",
        "Deleted": false,
        "Rank": 369,
        "Type": "autem",
        "ColorBlock": 979,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2005-01-24T14:58:04.193468+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rem",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Wellington Cummings Jr.",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 740
          }
        }
      }
    ],
    "PersonNumber": "1057979",
    "FullName": "Peter Volkman",
    "NoMailing": false,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {
        "Value": "aut",
        "StrippedValue": "beatae",
        "Description": "Adaptive optimizing interface",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 634
          }
        }
      },
      {
        "Value": "aut",
        "StrippedValue": "beatae",
        "Description": "Adaptive optimizing interface",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 634
          }
        }
      }
    ],
    "FormalName": "Kling, Predovic and Rodriguez",
    "Address": {
      "Wgs84Latitude": 4071.066,
      "Wgs84Longitude": 11398.358,
      "LocalizedAddress": [
        [
          {
            "Name": "McKenzie, Windler and Hand",
            "Value": "repellendus",
            "Tooltip": "nobis",
            "Label": "in",
            "ValueLength": 520,
            "AddressType": "sit",
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
                "FieldLength": 466
              }
            }
          }
        ],
        [
          {
            "Name": "Johnston LLC",
            "Value": "qui",
            "Tooltip": "ea",
            "Label": "ratione",
            "ValueLength": 87,
            "AddressType": "enim",
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
                "FieldLength": 341
              }
            }
          }
        ]
      ],
      "Street": {},
      "Postal": {},
      "Formatted": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 218
        }
      }
    },
    "Post3": "consequatur",
    "Post2": "laudantium",
    "Post1": "tempore",
    "Kanalname": "deleniti",
    "Kanafname": "minima",
    "CorrespondingAssociate": {
      "AssociateId": 899,
      "Name": "Huels, DuBuque and Lang",
      "PersonId": 509,
      "Rank": 546,
      "Tooltip": "rerum",
      "Type": "AnonymousAssociate",
      "GroupIdx": 510,
      "FullName": "Celestino Gusikowski DDS",
      "FormalName": "Trantow-Haley",
      "Deleted": false,
      "EjUserId": 635,
      "UserName": "Sauer Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    },
    "Category": {
      "Id": 942,
      "Value": "voluptatum",
      "Tooltip": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    },
    "Business": {
      "Id": 581,
      "Value": "eum",
      "Tooltip": "laboriosam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 709
        }
      }
    },
    "Associate": {
      "AssociateId": 213,
      "Name": "Mante, Rath and Bosco",
      "PersonId": 779,
      "Rank": 978,
      "Tooltip": "perspiciatis",
      "Type": "AnonymousAssociate",
      "GroupIdx": 117,
      "FullName": "Antoinette Cruickshank",
      "FormalName": "Lynch LLC",
      "Deleted": false,
      "EjUserId": 410,
      "UserName": "Quigley, Bauch and Breitenberg",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 34
        }
      }
    },
    "Salutation": "debitis",
    "ActiveInterests": 294,
    "SupportAssociate": {
      "AssociateId": 39,
      "Name": "Feeney LLC",
      "PersonId": 831,
      "Rank": 615,
      "Tooltip": "tempora",
      "Type": "AnonymousAssociate",
      "GroupIdx": 701,
      "FullName": "Zack Littel",
      "FormalName": "Cummings LLC",
      "Deleted": false,
      "EjUserId": 699,
      "UserName": "Feil, Rice and Kuphal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 172
        }
      }
    },
    "TicketPriority": {
      "Id": 729,
      "Value": "qui",
      "Tooltip": "maxime",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    },
    "CustomerLanguage": {
      "Id": 900,
      "Value": "qui",
      "Tooltip": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    },
    "DbiAgentId": 989,
    "DbiKey": "dolores",
    "DbiLastModified": "2019-06-08T14:58:04.1964605+02:00",
    "DbiLastSyncronized": "1998-06-12T14:58:04.1964605+02:00",
    "SentInfo": 684,
    "ShowContactTickets": 257,
    "UserInfo": {
      "Deleted": true,
      "UserInfoId": 724,
      "UserName": "Lueilwitz-Lesch",
      "PersonId": 61,
      "Rank": 247,
      "Tooltip": "distinctio",
      "UserGroupId": 887,
      "EjUserId": 828,
      "UserType": "AnonymousAssociate",
      "GrantedLicenses": [
        "tenetur",
        "veritatis"
      ],
      "CanLogon": true,
      "RoleName": "Glover Group",
      "RoleTooltip": "commodi",
      "UserGroupName": "Beer LLC",
      "UserGroupTooltip": "ducimus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 647
        }
      }
    },
    "ChatEmails": [
      {
        "Value": "est",
        "StrippedValue": "voluptate",
        "Description": "Right-sized discrete open system",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 833
          }
        }
      },
      {
        "Value": "est",
        "StrippedValue": "voluptate",
        "Description": "Right-sized discrete open system",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 833
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "error",
        "StrippedValue": "id",
        "Description": "Organic radical monitoring",
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
      {
        "Value": "error",
        "StrippedValue": "id",
        "Description": "Organic radical monitoring",
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
      }
    ],
    "Source": 786,
    "ActiveErpLinks": 200,
    "ShipmentTypes": [
      {
        "Id": 975,
        "Name": "McClure-Donnelly",
        "ToolTip": "Laborum et suscipit voluptatibus labore.",
        "Deleted": true,
        "Rank": 4,
        "Type": "unde",
        "ColorBlock": 560,
        "IconHint": "mollitia",
        "Selected": false,
        "LastChanged": "2009-11-08T14:58:04.1964605+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempora",
        "StyleHint": "placeat",
        "Hidden": false,
        "FullName": "Jameson Pouros",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 586
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 128,
        "Comment": "officiis",
        "Registered": "2009-09-29T14:58:04.1964605+02:00",
        "RegisteredAssociateId": 360,
        "Updated": "2002-02-25T14:58:04.1964605+01:00",
        "UpdatedAssociateId": 500,
        "LegalBaseId": 965,
        "LegalBaseKey": "consectetur",
        "LegalBaseName": "Pouros-Hane",
        "ConsentPurposeId": 234,
        "ConsentPurposeKey": "minus",
        "ConsentPurposeName": "Brakus Group",
        "ConsentSourceId": 604,
        "ConsentSourceKey": "ratione",
        "ConsentSourceName": "Witting Inc and Sons",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 41
          }
        }
      }
    ],
    "BounceEmails": [
      "steve_kuvalis@ziemearmstrong.name",
      "cody@bradtke.com"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "Hellen Konopelski",
      "SuperOffice:2": "Dawn Roberts"
    },
    "ExtraFields": {
      "ExtraFields1": "architecto",
      "ExtraFields2": "nam"
    },
    "CustomFields": {
      "CustomFields1": "voluptatem",
      "CustomFields2": "fugiat"
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
        "FieldLength": 188
      }
    }
  }
]
```