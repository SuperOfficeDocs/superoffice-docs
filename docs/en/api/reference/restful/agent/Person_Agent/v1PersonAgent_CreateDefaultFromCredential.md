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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
  "ContactId": 26,
  "CredentialType": "dolore",
  "CredentialValue": "velit",
  "CredentialDisplayValue": "voluptates"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 359,
  "Firstname": "Patricia",
  "MiddleName": "Stroman Group",
  "Lastname": "Kessler",
  "Mrmrs": "culpa",
  "Title": "porro",
  "UpdatedDate": "2000-05-30T13:28:23.2105886+02:00",
  "CreatedDate": "2019-07-25T13:28:23.2105886+02:00",
  "BirthDate": "2020-07-03T13:28:23.2105886+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ex",
      "StrippedValue": "dolorem",
      "Description": "Multi-tiered logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "dolorem",
      "Description": "Multi-tiered logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    }
  ],
  "Description": "Front-line tertiary superstructure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "molestiae",
      "Description": "Automated dedicated structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "molestiae",
      "Description": "Automated dedicated structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "eligendi",
      "Description": "Streamlined bi-directional workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "eligendi",
      "Description": "Streamlined bi-directional workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "sit",
      "Description": "Multi-tiered eco-centric functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "sit",
      "Description": "Multi-tiered eco-centric functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ea",
      "StrippedValue": "eaque",
      "Description": "Assimilated fault-tolerant methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 833
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "eaque",
      "Description": "Assimilated fault-tolerant methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 833
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quas",
      "StrippedValue": "quae",
      "Description": "Balanced coherent archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "quae",
      "Description": "Balanced coherent archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
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
      "Id": 847,
      "Name": "Hickle, Kozey and Hickle",
      "ToolTip": "Nulla quis id.",
      "Deleted": true,
      "Rank": 759,
      "Type": "placeat",
      "ColorBlock": 384,
      "IconHint": "consectetur",
      "Selected": true,
      "LastChanged": "2020-07-06T13:28:23.2105886+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sunt",
      "StyleHint": "corporis",
      "Hidden": false,
      "FullName": "Jeffry Conroy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "PersonNumber": "1685217",
  "FullName": "Dr. Richie Weimann PhD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "quam",
      "Description": "Team-oriented intermediate analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 930
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "quam",
      "Description": "Team-oriented intermediate analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 930
        }
      }
    }
  ],
  "FormalName": "Beier Inc and Sons",
  "Address": null,
  "Post3": "qui",
  "Post2": "atque",
  "Post1": "at",
  "Kanalname": "aut",
  "Kanafname": "voluptatem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "qui",
  "ActiveInterests": 573,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 511,
  "DbiKey": "sit",
  "DbiLastModified": "2011-02-09T13:28:23.2105886+01:00",
  "DbiLastSyncronized": "2000-12-07T13:28:23.2105886+01:00",
  "SentInfo": 970,
  "ShowContactTickets": 453,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ut",
      "StrippedValue": "iure",
      "Description": "Reactive 24/7 attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 861
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "iure",
      "Description": "Reactive 24/7 attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 861
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "illum",
      "StrippedValue": "nesciunt",
      "Description": "Customizable didactic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "nesciunt",
      "Description": "Customizable didactic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    }
  ],
  "Source": 949,
  "ActiveErpLinks": 314,
  "ShipmentTypes": [
    {
      "Id": 920,
      "Name": "Wintheiser Group",
      "ToolTip": "Nihil autem dolor aspernatur ipsa.",
      "Deleted": true,
      "Rank": 723,
      "Type": "quo",
      "ColorBlock": 108,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2013-11-27T13:28:23.2105886+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "rerum",
      "Hidden": false,
      "FullName": "Prof. Cydney Lacey Miller Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 459
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 927,
      "Comment": "est",
      "Registered": "2018-04-14T13:28:23.2105886+02:00",
      "RegisteredAssociateId": 214,
      "Updated": "2022-06-01T13:28:23.2105886+02:00",
      "UpdatedAssociateId": 995,
      "LegalBaseId": 875,
      "LegalBaseKey": "est",
      "LegalBaseName": "Hoeger-Kihn",
      "ConsentPurposeId": 635,
      "ConsentPurposeKey": "mollitia",
      "ConsentPurposeName": "Kulas Inc and Sons",
      "ConsentSourceId": 551,
      "ConsentSourceKey": "inventore",
      "ConsentSourceName": "Reynolds Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "BounceEmails": [
    "isaias@miller.uk",
    "noah.collier@pouros.us"
  ],
  "ActiveStatusMonitorId": 952,
  "CreatedByFormId": 13,
  "UserDefinedFields": {
    "SuperOffice:1": "243716658",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "magnam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 882
    }
  }
}
```