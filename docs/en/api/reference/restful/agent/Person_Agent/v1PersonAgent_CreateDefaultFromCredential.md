---
title: POST Agents/Person/CreateDefaultFromCredential
uid: v1PersonAgent_CreateDefaultFromCredential
generated: true
---

# POST Agents/Person/CreateDefaultFromCredential

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential
```

Creates a PersonEntity with default values based on the contactId and credentials.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential?$select=name,department,category/id
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

ContactId, CredentialType, CredentialValue, CredentialDisplayValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| CredentialType | String |  |
| CredentialValue | String |  |
| CredentialDisplayValue | String |  |

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
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 859,
  "CredentialType": "quam",
  "CredentialValue": "molestiae",
  "CredentialDisplayValue": "aut"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 467,
  "Firstname": "Howard",
  "MiddleName": "Davis, Howell and Parker",
  "Lastname": "Blanda",
  "Mrmrs": "facere",
  "Title": "voluptas",
  "UpdatedDate": "2008-03-05T12:57:34.5241124+01:00",
  "CreatedDate": "1998-07-13T12:57:34.5241124+02:00",
  "BirthDate": "2015-07-29T12:57:34.5241124+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aliquid",
      "StrippedValue": "adipisci",
      "Description": "Cross-group client-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "adipisci",
      "Description": "Cross-group client-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "Description": "Distributed demand-driven concept",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "natus",
      "Description": "Versatile real-time initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "natus",
      "Description": "Versatile real-time initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "sit",
      "Description": "Seamless user-facing local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "sit",
      "Description": "Seamless user-facing local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "placeat",
      "StrippedValue": "repudiandae",
      "Description": "Innovative grid-enabled policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 652
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "repudiandae",
      "Description": "Innovative grid-enabled policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 652
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Upgradable full-range methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Upgradable full-range methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "eveniet",
      "Description": "Versatile high-level installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "eveniet",
      "Description": "Versatile high-level installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 329
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
      "Id": 541,
      "Name": "O'Connell, Conroy and Nader",
      "ToolTip": "Inventore porro error.",
      "Deleted": false,
      "Rank": 304,
      "Type": "totam",
      "ColorBlock": 298,
      "IconHint": "accusamus",
      "Selected": false,
      "LastChanged": "2017-11-26T12:57:34.5241124+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quam",
      "StyleHint": "hic",
      "Hidden": false,
      "FullName": "Christophe Minerva Hudson III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "PersonNumber": "805423",
  "FullName": "Hilbert Mann DVM",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "est",
      "Description": "Triple-buffered dedicated success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "est",
      "Description": "Triple-buffered dedicated success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "FormalName": "Osinski Group",
  "Address": null,
  "Post3": "praesentium",
  "Post2": "ex",
  "Post1": "reprehenderit",
  "Kanalname": "accusamus",
  "Kanafname": "autem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "provident",
  "ActiveInterests": 355,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 99,
  "DbiKey": "fugiat",
  "DbiLastModified": "2022-05-02T12:57:34.5397338+02:00",
  "DbiLastSyncronized": "1999-04-29T12:57:34.5397338+02:00",
  "SentInfo": 509,
  "ShowContactTickets": 755,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ipsam",
      "StrippedValue": "doloremque",
      "Description": "Customer-focused uniform paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "doloremque",
      "Description": "Customer-focused uniform paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "eligendi",
      "Description": "Versatile didactic process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "eligendi",
      "Description": "Versatile didactic process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    }
  ],
  "Source": 947,
  "ActiveErpLinks": 305,
  "ShipmentTypes": [
    {
      "Id": 560,
      "Name": "Senger, Purdy and Hoppe",
      "ToolTip": "Aperiam adipisci.",
      "Deleted": false,
      "Rank": 49,
      "Type": "repudiandae",
      "ColorBlock": 401,
      "IconHint": "rem",
      "Selected": true,
      "LastChanged": "2005-11-17T12:57:34.5397338+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "corporis",
      "Hidden": true,
      "FullName": "Ms. Giovanny Gibson Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 758
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 192,
      "Comment": "doloribus",
      "Registered": "2016-01-20T12:57:34.5397338+01:00",
      "RegisteredAssociateId": 162,
      "Updated": "2019-07-28T12:57:34.5397338+02:00",
      "UpdatedAssociateId": 118,
      "LegalBaseId": 923,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Gerlach-Waters",
      "ConsentPurposeId": 488,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Kreiger, Nienow and Yundt",
      "ConsentSourceId": 770,
      "ConsentSourceKey": "commodi",
      "ConsentSourceName": "Glover, Schaefer and Price",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    }
  ],
  "BounceEmails": [
    "alize_emard@stehr.co.uk",
    "asa.cole@lakin.uk"
  ],
  "ActiveStatusMonitorId": 383,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1540449365"
  },
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "voluptatum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 962
    }
  }
}
```