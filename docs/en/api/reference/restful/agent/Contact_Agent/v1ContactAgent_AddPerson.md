---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
content_type: reference
---

# POST Agents/Contact/AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
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

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| NewPersonEntity | PersonEntity |  |

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 713,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 434,
  "Firstname": "Jeremy",
  "MiddleName": "Anderson-Robel",
  "Lastname": "Kunde",
  "Mrmrs": "laborum",
  "Title": "recusandae",
  "UpdatedDate": "2008-01-28T03:40:46.4681198+01:00",
  "CreatedDate": "2006-08-09T03:40:46.4681198+02:00",
  "BirthDate": "2013-03-17T03:40:46.4681198+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "non",
      "Description": "Open-architected full-range throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 294
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "non",
      "Description": "Open-architected full-range throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 294
        }
      }
    }
  ],
  "Description": "Compatible static internet solution",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "similique",
      "StrippedValue": "aut",
      "Description": "Programmable human-resource portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "aut",
      "Description": "Programmable human-resource portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nulla",
      "StrippedValue": "qui",
      "Description": "Fully-configurable optimizing analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 390
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "qui",
      "Description": "Fully-configurable optimizing analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 390
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "odit",
      "StrippedValue": "deleniti",
      "Description": "Stand-alone zero defect hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "deleniti",
      "Description": "Stand-alone zero defect hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "dolore",
      "Description": "Pre-emptive actuating synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 458
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "dolore",
      "Description": "Pre-emptive actuating synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 458
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "minus",
      "StrippedValue": "molestiae",
      "Description": "De-engineered object-oriented hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "molestiae",
      "Description": "De-engineered object-oriented hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
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
      "Id": 761,
      "Name": "Cronin, Nitzsche and Green",
      "ToolTip": "Architecto consequatur excepturi dicta repellat iusto minima.",
      "Deleted": true,
      "Rank": 759,
      "Type": "eaque",
      "ColorBlock": 514,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2008-08-24T03:40:46.4681198+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Mr. Marcella Sporer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    }
  ],
  "PersonNumber": "717525",
  "FullName": "Domenica Beer",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "consequatur",
      "Description": "Cloned uniform task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "consequatur",
      "Description": "Cloned uniform task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    }
  ],
  "FormalName": "Greenfelder, Pollich and Heaney",
  "Address": null,
  "Post3": "deserunt",
  "Post2": "veritatis",
  "Post1": "dolores",
  "Kanalname": "quis",
  "Kanafname": "architecto",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 761,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 424,
  "DbiKey": "dolor",
  "DbiLastModified": "2013-04-07T03:40:46.4681198+02:00",
  "DbiLastSyncronized": "2023-01-16T03:40:46.4681198+01:00",
  "SentInfo": 691,
  "ShowContactTickets": 806,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "non",
      "StrippedValue": "facilis",
      "Description": "Persistent responsive capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "facilis",
      "Description": "Persistent responsive capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eos",
      "StrippedValue": "enim",
      "Description": "Proactive global matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "enim",
      "Description": "Proactive global matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    }
  ],
  "Source": 720,
  "ActiveErpLinks": 111,
  "ShipmentTypes": [
    {
      "Id": 622,
      "Name": "Powlowski Inc and Sons",
      "ToolTip": "Et corporis omnis fugit laudantium veniam.",
      "Deleted": true,
      "Rank": 377,
      "Type": "doloribus",
      "ColorBlock": 432,
      "IconHint": "atque",
      "Selected": false,
      "LastChanged": "2017-12-31T03:40:46.4681198+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illo",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Krista Kozey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 334
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 532,
      "Comment": "est",
      "Registered": "2024-07-25T03:40:46.4681198+02:00",
      "RegisteredAssociateId": 517,
      "Updated": "2007-02-08T03:40:46.4681198+01:00",
      "UpdatedAssociateId": 192,
      "LegalBaseId": 950,
      "LegalBaseKey": "exercitationem",
      "LegalBaseName": "Torp-Ebert",
      "ConsentPurposeId": 51,
      "ConsentPurposeKey": "exercitationem",
      "ConsentPurposeName": "Goyette LLC",
      "ConsentSourceId": 718,
      "ConsentSourceKey": "at",
      "ConsentSourceName": "Konopelski, Nienow and Romaguera",
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
  "BounceEmails": [
    "ferne@dickens.co.uk",
    "mervin_luettgen@mayert.info"
  ],
  "ActiveStatusMonitorId": 670,
  "CreatedByFormId": 608,
  "UtmParameters": null,
  "LeadstatusId": 552,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Olga Tiffany Toy PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "tenetur",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 626
    }
  }
}
```