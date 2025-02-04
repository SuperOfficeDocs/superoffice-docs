---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
generated: true
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=922
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 679,
  "Firstname": "Whitney",
  "MiddleName": "Lindgren, O'Connell and Will",
  "Lastname": "O'Conner",
  "Mrmrs": "molestiae",
  "Title": "eos",
  "UpdatedDate": "2017-05-24T13:13:23.4301408+02:00",
  "CreatedDate": "2022-11-01T13:13:23.4301408+01:00",
  "BirthDate": "2018-11-09T13:13:23.4301408+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "ex",
      "Description": "Up-sized client-driven utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "ex",
      "Description": "Up-sized client-driven utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "Description": "Function-based real-time throughput",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "qui",
      "Description": "Total interactive instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 12
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "qui",
      "Description": "Total interactive instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 12
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "corporis",
      "Description": "Proactive explicit flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "corporis",
      "Description": "Proactive explicit flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "totam",
      "StrippedValue": "modi",
      "Description": "Streamlined attitude-oriented methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 250
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "modi",
      "Description": "Streamlined attitude-oriented methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 250
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "inventore",
      "Description": "Intuitive even-keeled system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "inventore",
      "Description": "Intuitive even-keeled system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "illo",
      "StrippedValue": "deserunt",
      "Description": "Implemented disintermediate definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "deserunt",
      "Description": "Implemented disintermediate definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
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
      "Id": 547,
      "Name": "Stracke, Wuckert and Brown",
      "ToolTip": "Quia iusto dolores tempore et a alias consequuntur.",
      "Deleted": false,
      "Rank": 217,
      "Type": "cumque",
      "ColorBlock": 979,
      "IconHint": "nostrum",
      "Selected": false,
      "LastChanged": "2010-02-17T13:13:23.4301408+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eius",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Efrain Ruecker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    }
  ],
  "PersonNumber": "828311",
  "FullName": "Janis Schowalter",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Configurable analyzing customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Configurable analyzing customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    }
  ],
  "FormalName": "Hansen, Jewess and Jacobson",
  "Address": null,
  "Post3": "odit",
  "Post2": "architecto",
  "Post1": "fugiat",
  "Kanalname": "est",
  "Kanafname": "non",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sit",
  "ActiveInterests": 686,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 701,
  "DbiKey": "quam",
  "DbiLastModified": "2022-09-12T13:13:23.4457016+02:00",
  "DbiLastSyncronized": "1998-11-26T13:13:23.4457016+01:00",
  "SentInfo": 177,
  "ShowContactTickets": 174,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "illum",
      "StrippedValue": "maxime",
      "Description": "Devolved object-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "maxime",
      "Description": "Devolved object-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Reactive homogeneous website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Reactive homogeneous website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    }
  ],
  "Source": 310,
  "ActiveErpLinks": 345,
  "ShipmentTypes": [
    {
      "Id": 983,
      "Name": "Halvorson LLC",
      "ToolTip": "Error quia alias nostrum similique quidem vel.",
      "Deleted": false,
      "Rank": 282,
      "Type": "eveniet",
      "ColorBlock": 374,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "1999-08-08T13:13:23.4457016+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nostrum",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Clark Barrows",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 133,
      "Comment": "atque",
      "Registered": "2001-12-19T13:13:23.4457016+01:00",
      "RegisteredAssociateId": 378,
      "Updated": "2009-06-23T13:13:23.4457016+02:00",
      "UpdatedAssociateId": 481,
      "LegalBaseId": 73,
      "LegalBaseKey": "deserunt",
      "LegalBaseName": "Thiel, Raynor and Toy",
      "ConsentPurposeId": 207,
      "ConsentPurposeKey": "accusamus",
      "ConsentPurposeName": "Moen-Reichert",
      "ConsentSourceId": 943,
      "ConsentSourceKey": "iste",
      "ConsentSourceName": "Carter Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    }
  ],
  "BounceEmails": [
    "kaci_wehner@reilly.uk",
    "aniyah_huel@ortizcrooks.com"
  ],
  "ActiveStatusMonitorId": 918,
  "CreatedByFormId": 478,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Prof. Lucious Nikko King I"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "saepe"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 930
    }
  }
}
```