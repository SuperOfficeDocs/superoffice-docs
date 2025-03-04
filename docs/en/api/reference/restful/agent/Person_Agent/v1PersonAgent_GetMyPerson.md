---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
generated: true
---

# POST Agents/Person/GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 427,
  "Firstname": "Nickolas",
  "MiddleName": "Konopelski, Tillman and Wunsch",
  "Lastname": "Ledner",
  "Mrmrs": "voluptatem",
  "Title": "fuga",
  "UpdatedDate": "2010-03-12T14:13:40.6565478+01:00",
  "CreatedDate": "1998-11-19T14:13:40.6565478+01:00",
  "BirthDate": "2020-08-07T14:13:40.6565478+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "placeat",
      "StrippedValue": "enim",
      "Description": "Compatible high-level interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 618
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "enim",
      "Description": "Compatible high-level interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 618
        }
      }
    }
  ],
  "Description": "Ergonomic needs-based attitude",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quo",
      "StrippedValue": "eos",
      "Description": "Stand-alone multi-tasking toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "eos",
      "Description": "Stand-alone multi-tasking toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corporis",
      "StrippedValue": "qui",
      "Description": "Centralized national service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "qui",
      "Description": "Centralized national service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 254
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sequi",
      "StrippedValue": "nam",
      "Description": "Assimilated context-sensitive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 363
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "nam",
      "Description": "Assimilated context-sensitive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 363
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "unde",
      "StrippedValue": "quod",
      "Description": "Persevering hybrid standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "quod",
      "Description": "Persevering hybrid standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "natus",
      "StrippedValue": "mollitia",
      "Description": "Implemented assymetric algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 574
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "mollitia",
      "Description": "Implemented assymetric algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 574
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
      "Id": 720,
      "Name": "Braun Group",
      "ToolTip": "Illum praesentium et.",
      "Deleted": false,
      "Rank": 710,
      "Type": "delectus",
      "ColorBlock": 60,
      "IconHint": "facilis",
      "Selected": false,
      "LastChanged": "2005-06-14T14:13:40.6565478+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quibusdam",
      "StyleHint": "totam",
      "Hidden": true,
      "FullName": "Modesto Zboncak",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 947
        }
      }
    }
  ],
  "PersonNumber": "1521962",
  "FullName": "Greyson Keeling",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "reiciendis",
      "Description": "Function-based optimizing product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 842
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "reiciendis",
      "Description": "Function-based optimizing product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 842
        }
      }
    }
  ],
  "FormalName": "Weissnat Inc and Sons",
  "Address": null,
  "Post3": "magnam",
  "Post2": "qui",
  "Post1": "minus",
  "Kanalname": "ipsam",
  "Kanafname": "hic",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "mollitia",
  "ActiveInterests": 558,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 349,
  "DbiKey": "quis",
  "DbiLastModified": "1998-09-20T14:13:40.6721693+02:00",
  "DbiLastSyncronized": "2011-02-27T14:13:40.6721693+01:00",
  "SentInfo": 692,
  "ShowContactTickets": 695,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ratione",
      "StrippedValue": "soluta",
      "Description": "Business-focused value-added approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "soluta",
      "Description": "Business-focused value-added approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "nihil",
      "Description": "Cross-platform 4th generation circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "nihil",
      "Description": "Cross-platform 4th generation circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    }
  ],
  "Source": 428,
  "ActiveErpLinks": 774,
  "ShipmentTypes": [
    {
      "Id": 841,
      "Name": "Schroeder-Bailey",
      "ToolTip": "Fugit repellat est dolorem harum a ut.",
      "Deleted": true,
      "Rank": 384,
      "Type": "consequatur",
      "ColorBlock": 463,
      "IconHint": "similique",
      "Selected": true,
      "LastChanged": "2024-05-04T14:13:40.6721693+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eaque",
      "StyleHint": "cumque",
      "Hidden": false,
      "FullName": "Dustin Williamson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 703
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 458,
      "Comment": "aut",
      "Registered": "2021-11-16T14:13:40.6721693+01:00",
      "RegisteredAssociateId": 675,
      "Updated": "2003-01-24T14:13:40.6721693+01:00",
      "UpdatedAssociateId": 797,
      "LegalBaseId": 94,
      "LegalBaseKey": "aperiam",
      "LegalBaseName": "Braun-Cummerata",
      "ConsentPurposeId": 898,
      "ConsentPurposeKey": "vel",
      "ConsentPurposeName": "Marquardt-Howell",
      "ConsentSourceId": 651,
      "ConsentSourceKey": "dolor",
      "ConsentSourceName": "Rodriguez-Okuneva",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1001
        }
      }
    }
  ],
  "BounceEmails": [
    "desmond_denesik@shanahan.biz",
    "dexter@haagmante.uk"
  ],
  "ActiveStatusMonitorId": 142,
  "CreatedByFormId": 174,
  "UserDefinedFields": {
    "SuperOffice:1": "Schuyler Towne",
    "SuperOffice:2": "Geovanni Schulist"
  },
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "maxime"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 212
    }
  }
}
```