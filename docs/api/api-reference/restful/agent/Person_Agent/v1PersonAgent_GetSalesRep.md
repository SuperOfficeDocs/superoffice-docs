---
title: POST Agents/Person/GetSalesRep
id: v1PersonAgent_GetSalesRep
---

# POST Agents/Person/GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.

If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | string |  |
| PersonFirstname | string |  |
| PersonLastname | string |  |
| EmailAddress | string |  |
| PhoneNumber | string |  |


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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Braun LLC",
  "PersonFirstname": "Brady",
  "PersonLastname": "Donnelly",
  "EmailAddress": "sylvester_reichel@pagac.uk",
  "PhoneNumber": "958200"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 481,
  "Firstname": "Dorthy",
  "MiddleName": "Beier-Kohler",
  "Lastname": "Hauck",
  "Mrmrs": "praesentium",
  "Title": "nihil",
  "UpdatedDate": "2011-05-31T18:28:49.6711322+02:00",
  "CreatedDate": "2006-12-30T18:28:49.6711322+01:00",
  "BirthDate": "1999-03-04T18:28:49.6711322+01:00",
  "CreatedBy": {
    "AssociateId": 716,
    "Name": "Nicolas Group",
    "PersonId": 302,
    "Rank": 246,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 138,
    "FullName": "Anastasia Herzog",
    "FormalName": "Hahn Group",
    "Deleted": true,
    "EjUserId": 809,
    "UserName": "Renner LLC",
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
  "Emails": [
    {
      "Value": "id",
      "StrippedValue": "magnam",
      "Description": "Front-line 4th generation moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "magnam",
      "Description": "Front-line 4th generation moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    }
  ],
  "Description": "Optional heuristic hardware",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "eos",
      "Description": "Compatible 24 hour array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "eos",
      "Description": "Compatible 24 hour array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "consectetur",
      "Description": "Realigned optimal policy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 56
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "consectetur",
      "Description": "Realigned optimal policy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 56
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "impedit",
      "StrippedValue": "voluptas",
      "Description": "Enterprise-wide 24 hour standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "voluptas",
      "Description": "Enterprise-wide 24 hour standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "illo",
      "StrippedValue": "non",
      "Description": "Diverse scalable implementation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "non",
      "Description": "Diverse scalable implementation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "magni",
      "StrippedValue": "aut",
      "Description": "De-engineered next generation middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "aut",
      "Description": "De-engineered next generation middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "Position": {
    "Id": 624,
    "Value": "omnis",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "aggregate 24/7 action-items"
        },
        "FieldType": "System.String",
        "FieldLength": 517
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 411,
    "Name": "Bernhard, Dickens and Lemke",
    "PersonId": 926,
    "Rank": 763,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 396,
    "FullName": "Wellington Herman",
    "FormalName": "Smith Inc and Sons",
    "Deleted": true,
    "EjUserId": 460,
    "UserName": "Gutkowski, Conroy and Keebler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 486
      }
    }
  },
  "Contact": {
    "ContactId": 701,
    "Name": "Heathcote, Ernser and Gaylord",
    "OrgNr": "1047112",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "explicabo",
    "DirectPhone": "1-084-550-0308 x420",
    "AssociateId": 911,
    "CountryId": 903,
    "EmailAddress": "courtney@harber.uk",
    "Kananame": "odio",
    "EmailAddressName": "nicholas@hettinger.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Watson Robel",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "magnam",
    "FullName": "Frankie Raynor",
    "IsOwnerContact": false,
    "ActiveErpLinks": 398,
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
  "Country": {
    "CountryId": 154,
    "Name": "Grimes-Hahn",
    "CurrencyId": 356,
    "EnglishName": "Jacobson Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Universal multimedia artificial intelligence",
    "OrgNrText": "1175776",
    "InterAreaPrefix": "fugiat",
    "DialInPrefix": "libero",
    "ZipPrefix": "voluptatum",
    "DomainName": "Mueller, Marvin and Leffler",
    "AddressLayoutId": 414,
    "DomesticAddressLayoutId": 661,
    "ForeignAddressLayoutId": 337,
    "Rank": 737,
    "Tooltip": "porro",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 929
      }
    }
  },
  "Interests": [
    {
      "Id": 912,
      "Name": "King Inc and Sons",
      "ToolTip": "Mollitia tenetur laborum illo sunt sed.",
      "Deleted": false,
      "Rank": 116,
      "Type": "rerum",
      "ColorBlock": 706,
      "IconHint": "unde",
      "Selected": false,
      "LastChanged": "2010-06-20T18:28:49.6731331+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "rerum",
      "Hidden": false,
      "FullName": "Ms. Tabitha Auer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    }
  ],
  "PersonNumber": "1006373",
  "FullName": "Golda Mosciski",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "occaecati",
      "StrippedValue": "officiis",
      "Description": "Customer-focused context-sensitive process improvement",
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
    {
      "Value": "occaecati",
      "StrippedValue": "officiis",
      "Description": "Customer-focused context-sensitive process improvement",
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
    }
  ],
  "FormalName": "Shanahan Inc and Sons",
  "Address": {
    "Wgs84Latitude": 10426.818,
    "Wgs84Longitude": 10508.302,
    "LocalizedAddress": [
      [
        {
          "Name": "Hyatt-Runolfsdottir",
          "Value": "quae",
          "Tooltip": "et",
          "Label": "corrupti",
          "ValueLength": 48,
          "AddressType": "corrupti",
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
              "FieldLength": 675
            }
          }
        }
      ],
      [
        {
          "Name": "Beer, Lakin and Altenwerth",
          "Value": "quibusdam",
          "Tooltip": "ullam",
          "Label": "omnis",
          "ValueLength": 335,
          "AddressType": "et",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "architect transparent eyeballs"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 419
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "veritatis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark global solutions"
        },
        "FieldType": "System.String",
        "FieldLength": 102
      }
    }
  },
  "Post3": "dolores",
  "Post2": "neque",
  "Post1": "dolorem",
  "Kanalname": "debitis",
  "Kanafname": "dolorem",
  "CorrespondingAssociate": {
    "AssociateId": 746,
    "Name": "Green-Batz",
    "PersonId": 589,
    "Rank": 394,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 481,
    "FullName": "Trystan Collins",
    "FormalName": "Koch, Mitchell and Kihn",
    "Deleted": false,
    "EjUserId": 435,
    "UserName": "Luettgen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 765
      }
    }
  },
  "Category": {
    "Id": 502,
    "Value": "officiis",
    "Tooltip": "ad",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 956
      }
    }
  },
  "Business": {
    "Id": 829,
    "Value": "voluptatem",
    "Tooltip": "eligendi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 226
      }
    }
  },
  "Associate": {
    "AssociateId": 219,
    "Name": "Abbott Inc and Sons",
    "PersonId": 704,
    "Rank": 673,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 800,
    "FullName": "Milo Green",
    "FormalName": "Renner-Senger",
    "Deleted": false,
    "EjUserId": 784,
    "UserName": "Reilly-DuBuque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 21
      }
    }
  },
  "Salutation": "odio",
  "ActiveInterests": 424,
  "SupportAssociate": {
    "AssociateId": 822,
    "Name": "Nolan, Mueller and Stracke",
    "PersonId": 76,
    "Rank": 461,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 622,
    "FullName": "Adela Hauck PhD",
    "FormalName": "Brekke-Feest",
    "Deleted": false,
    "EjUserId": 551,
    "UserName": "Wolff Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 20
      }
    }
  },
  "TicketPriority": {
    "Id": 682,
    "Value": "culpa",
    "Tooltip": "quasi",
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
  "CustomerLanguage": {
    "Id": 155,
    "Value": "vero",
    "Tooltip": "sequi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 163
      }
    }
  },
  "DbiAgentId": 264,
  "DbiKey": "accusamus",
  "DbiLastModified": "2004-07-23T18:28:49.6761371+02:00",
  "DbiLastSyncronized": "1999-01-16T18:28:49.6761371+01:00",
  "SentInfo": 313,
  "ShowContactTickets": 786,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 893,
    "UserName": "Spinka Group",
    "PersonId": 905,
    "Rank": 154,
    "Tooltip": "inventore",
    "UserGroupId": 781,
    "EjUserId": 639,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "omnis",
      "ab"
    ],
    "CanLogon": true,
    "RoleName": "Kuphal Inc and Sons",
    "RoleTooltip": "voluptatem",
    "UserGroupName": "Schiller-Volkman",
    "UserGroupTooltip": "culpa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 49
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "ut",
      "StrippedValue": "aut",
      "Description": "Fundamental solution-oriented definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "aut",
      "Description": "Fundamental solution-oriented definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "autem",
      "StrippedValue": "debitis",
      "Description": "Intuitive mission-critical encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "debitis",
      "Description": "Intuitive mission-critical encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "Source": 190,
  "ActiveErpLinks": 407,
  "ShipmentTypes": [
    {
      "Id": 777,
      "Name": "Harvey-Walter",
      "ToolTip": "Quia rerum impedit et minus aut.",
      "Deleted": false,
      "Rank": 791,
      "Type": "quidem",
      "ColorBlock": 221,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2013-11-27T18:28:49.6771378+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "non",
      "Hidden": true,
      "FullName": "Vivienne Von",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 424
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 81,
      "Comment": "velit",
      "Registered": "1998-11-04T18:28:49.6771378+01:00",
      "RegisteredAssociateId": 495,
      "Updated": "2012-07-02T18:28:49.6771378+02:00",
      "UpdatedAssociateId": 65,
      "LegalBaseId": 928,
      "LegalBaseKey": "quisquam",
      "LegalBaseName": "Nitzsche Group",
      "ConsentPurposeId": 965,
      "ConsentPurposeKey": "doloremque",
      "ConsentPurposeName": "Kilback-Pollich",
      "ConsentSourceId": 5,
      "ConsentSourceKey": "eveniet",
      "ConsentSourceName": "Morar-Koss",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 356
        }
      }
    }
  ],
  "BounceEmails": [
    "madie@carterklocko.info",
    "george_reilly@hicklehand.uk"
  ],
  "ActiveStatusMonitorId": 232,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Diana Mitchell"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "dicta"
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
      "FieldLength": 854
    }
  }
}
```