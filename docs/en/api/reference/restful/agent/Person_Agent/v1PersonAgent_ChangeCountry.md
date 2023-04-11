---
title: POST Agents/Person/ChangeCountry
uid: v1PersonAgent_ChangeCountry
---

# POST Agents/Person/ChangeCountry

```http
POST /api/v1/Agents/Person/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format for this entity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ChangeCountry?$select=name,department,category/id
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

PersonEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity | PersonEntity |  |
| ToCountryId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": null,
  "ToCountryId": 27
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 960,
  "Firstname": "Sven",
  "MiddleName": "Sanford, Gutkowski and Raynor",
  "Lastname": "Schultz",
  "Mrmrs": "molestiae",
  "Title": "doloremque",
  "UpdatedDate": "2000-10-22T15:29:22.2787691+02:00",
  "CreatedDate": "2017-07-29T15:29:22.2787691+02:00",
  "BirthDate": "2013-01-25T15:29:22.2787691+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "praesentium",
      "StrippedValue": "consequuntur",
      "Description": "User-centric object-oriented groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "consequuntur",
      "Description": "User-centric object-oriented groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    }
  ],
  "Description": "Persevering composite approach",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "est",
      "StrippedValue": "consequatur",
      "Description": "Optional intermediate methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "consequatur",
      "Description": "Optional intermediate methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "doloribus",
      "StrippedValue": "maxime",
      "Description": "Balanced neutral workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "maxime",
      "Description": "Balanced neutral workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "quia",
      "Description": "Optional 5th generation definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 403
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "quia",
      "Description": "Optional 5th generation definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 403
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ullam",
      "StrippedValue": "dicta",
      "Description": "De-engineered 6th generation capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 913
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "dicta",
      "Description": "De-engineered 6th generation capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 913
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "est",
      "StrippedValue": "natus",
      "Description": "Cross-platform upward-trending service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 775
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "natus",
      "Description": "Cross-platform upward-trending service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 775
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 517,
      "Name": "Rohan Group",
      "ToolTip": "A corrupti.",
      "Deleted": true,
      "Rank": 356,
      "Type": "aut",
      "ColorBlock": 889,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2018-12-14T15:29:22.2812682+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "unde",
      "Hidden": true,
      "FullName": "Mrs. Abraham Zulauf",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "PersonNumber": "1588548",
  "FullName": "German Brakus",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "quae",
      "Description": "Intuitive responsive access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quae",
      "Description": "Intuitive responsive access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    }
  ],
  "FormalName": "O'Keefe Inc and Sons",
  "Address": null,
  "Post3": "debitis",
  "Post2": "ut",
  "Post1": "eum",
  "Kanalname": "nihil",
  "Kanafname": "tempora",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aut",
  "ActiveInterests": 206,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 824,
  "DbiKey": "beatae",
  "DbiLastModified": "2015-12-22T15:29:22.2842689+01:00",
  "DbiLastSyncronized": "2017-11-08T15:29:22.2842689+01:00",
  "SentInfo": 168,
  "ShowContactTickets": 552,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "modi",
      "StrippedValue": "dolores",
      "Description": "Automated zero defect software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "dolores",
      "Description": "Automated zero defect software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nulla",
      "StrippedValue": "molestias",
      "Description": "Total local portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 543
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "molestias",
      "Description": "Total local portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 543
        }
      }
    }
  ],
  "Source": 941,
  "ActiveErpLinks": 420,
  "ShipmentTypes": [
    {
      "Id": 294,
      "Name": "Stark, Strosin and Schultz",
      "ToolTip": "Ex perferendis officia dolorem.",
      "Deleted": true,
      "Rank": 187,
      "Type": "perspiciatis",
      "ColorBlock": 879,
      "IconHint": "nemo",
      "Selected": true,
      "LastChanged": "2018-02-15T15:29:22.2847688+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempore",
      "StyleHint": "maiores",
      "Hidden": false,
      "FullName": "Dr. Jackson Nikolaus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 972
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 33,
      "Comment": "dolore",
      "Registered": "2017-12-06T15:29:22.2847688+01:00",
      "RegisteredAssociateId": 48,
      "Updated": "1997-06-10T15:29:22.2847688+02:00",
      "UpdatedAssociateId": 493,
      "LegalBaseId": 219,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Windler, Kautzer and Kris",
      "ConsentPurposeId": 280,
      "ConsentPurposeKey": "voluptas",
      "ConsentPurposeName": "Wintheiser LLC",
      "ConsentSourceId": 957,
      "ConsentSourceKey": "libero",
      "ConsentSourceName": "Grimes-Mohr",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
        }
      }
    }
  ],
  "BounceEmails": [
    "adriana@jacobi.com",
    "marina_runolfsdottir@schmitt.uk"
  ],
  "ActiveStatusMonitorId": 140,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Darien Kuvalis V",
    "SuperOffice:2": "Margarett Predovic"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "beatae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 242
    }
  }
}
```