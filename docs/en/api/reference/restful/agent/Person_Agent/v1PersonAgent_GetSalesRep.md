---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
generated: true
content_type: reference
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
| ContactName | String |  |
| PersonFirstname | String |  |
| PersonLastname | String |  |
| EmailAddress | String |  |
| PhoneNumber | String |  |

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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Schamberger, Parisian and Ferry",
  "PersonFirstname": "Julius",
  "PersonLastname": "O'Connell",
  "EmailAddress": "stacy@schmeler.ca",
  "PhoneNumber": "1640839"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 489,
  "Firstname": "Marta",
  "MiddleName": "Weber Group",
  "Lastname": "Cronin",
  "Mrmrs": "quia",
  "Title": "harum",
  "UpdatedDate": "2013-08-19T11:24:48.3282728+02:00",
  "CreatedDate": "2005-11-02T11:24:48.3282728+01:00",
  "BirthDate": "2006-07-11T11:24:48.3282728+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "eligendi",
      "Description": "Assimilated contextually-based installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 201
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "eligendi",
      "Description": "Assimilated contextually-based installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 201
        }
      }
    }
  ],
  "Description": "Customer-focused well-modulated internet solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "sit",
      "Description": "Expanded real-time conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "sit",
      "Description": "Expanded real-time conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Phased executive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Phased executive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "qui",
      "StrippedValue": "quis",
      "Description": "Profit-focused needs-based complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "quis",
      "Description": "Profit-focused needs-based complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "repellat",
      "StrippedValue": "accusantium",
      "Description": "Self-enabling client-driven monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "accusantium",
      "Description": "Self-enabling client-driven monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "porro",
      "Description": "Front-line uniform capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "porro",
      "Description": "Front-line uniform capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
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
      "Id": 575,
      "Name": "Spencer-Lowe",
      "ToolTip": "Assumenda vel qui laborum quia.",
      "Deleted": false,
      "Rank": 405,
      "Type": "qui",
      "ColorBlock": 905,
      "IconHint": "quaerat",
      "Selected": false,
      "LastChanged": "2025-02-13T11:24:48.3282728+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Loma Brakus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    }
  ],
  "PersonNumber": "1873983",
  "FullName": "Arvilla O'Conner",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Diverse static paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 679
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Diverse static paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 679
        }
      }
    }
  ],
  "FormalName": "Olson, Gislason and Luettgen",
  "Address": null,
  "Post3": "molestiae",
  "Post2": "ad",
  "Post1": "in",
  "Kanalname": "enim",
  "Kanafname": "iusto",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsa",
  "ActiveInterests": 138,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 9,
  "DbiKey": "vel",
  "DbiLastModified": "2022-01-17T11:24:48.3282728+01:00",
  "DbiLastSyncronized": "2016-11-29T11:24:48.3282728+01:00",
  "SentInfo": 789,
  "ShowContactTickets": 245,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusantium",
      "StrippedValue": "pariatur",
      "Description": "Networked methodical protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "pariatur",
      "Description": "Networked methodical protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "quibusdam",
      "Description": "Multi-channelled needs-based hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "quibusdam",
      "Description": "Multi-channelled needs-based hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    }
  ],
  "Source": 170,
  "ActiveErpLinks": 53,
  "ShipmentTypes": [
    {
      "Id": 532,
      "Name": "Kihn-Purdy",
      "ToolTip": "Consequatur quam ut unde.",
      "Deleted": false,
      "Rank": 97,
      "Type": "tenetur",
      "ColorBlock": 692,
      "IconHint": "ipsam",
      "Selected": true,
      "LastChanged": "2017-04-27T11:24:48.3282728+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "hic",
      "Hidden": false,
      "FullName": "Garry Jewess",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 128
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 312,
      "Comment": "voluptatem",
      "Registered": "2025-01-15T11:24:48.3282728+01:00",
      "RegisteredAssociateId": 131,
      "Updated": "2021-12-19T11:24:48.3282728+01:00",
      "UpdatedAssociateId": 220,
      "LegalBaseId": 955,
      "LegalBaseKey": "blanditiis",
      "LegalBaseName": "Osinski Inc and Sons",
      "ConsentPurposeId": 648,
      "ConsentPurposeKey": "illo",
      "ConsentPurposeName": "Ortiz LLC",
      "ConsentSourceId": 921,
      "ConsentSourceKey": "sed",
      "ConsentSourceName": "Greenfelder LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 517
        }
      }
    }
  ],
  "BounceEmails": [
    "lazaro_harber@dubuquemayert.us",
    "clinton_lubowitz@kerluke.co.uk"
  ],
  "ActiveStatusMonitorId": 66,
  "CreatedByFormId": 795,
  "UtmParameters": null,
  "LeadstatusId": 658,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Cleve Zachariah Dickinson",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "voluptatum",
    "CustomFields2": "pariatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 89
    }
  }
}
```