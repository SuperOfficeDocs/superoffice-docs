---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Mohr-Ferry",
  "PersonFirstname": "Elza",
  "PersonLastname": "Sipes",
  "EmailAddress": "mallie_yundt@nikolaus.info",
  "PhoneNumber": "899568"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 872,
  "Firstname": "Kyler",
  "MiddleName": "McClure, Braun and Treutel",
  "Lastname": "Rohan",
  "Mrmrs": "ea",
  "Title": "eos",
  "UpdatedDate": "2005-09-22T14:28:22.1647656+02:00",
  "CreatedDate": "2015-08-20T14:28:22.1647656+02:00",
  "BirthDate": "2017-09-15T14:28:22.1647656+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "nemo",
      "StrippedValue": "dolore",
      "Description": "Secured holistic orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "dolore",
      "Description": "Secured holistic orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    }
  ],
  "Description": "Synergistic homogeneous groupware",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "voluptas",
      "Description": "Front-line multi-state success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 660
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "voluptas",
      "Description": "Front-line multi-state success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 660
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "accusantium",
      "Description": "Fully-configurable mobile neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "accusantium",
      "Description": "Fully-configurable mobile neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "totam",
      "StrippedValue": "atque",
      "Description": "Focused bi-directional hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "atque",
      "Description": "Focused bi-directional hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "perspiciatis",
      "Description": "Enterprise-wide static archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "perspiciatis",
      "Description": "Enterprise-wide static archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "facilis",
      "StrippedValue": "architecto",
      "Description": "Polarised discrete capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 876
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "architecto",
      "Description": "Polarised discrete capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 876
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
      "Id": 911,
      "Name": "Bashirian Inc and Sons",
      "ToolTip": "Dolor officiis id quod est.",
      "Deleted": true,
      "Rank": 577,
      "Type": "modi",
      "ColorBlock": 151,
      "IconHint": "ratione",
      "Selected": false,
      "LastChanged": "2000-12-23T14:28:22.1647656+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quibusdam",
      "StyleHint": "assumenda",
      "Hidden": false,
      "FullName": "Dr. Darryl Tatyana Wisoky",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    }
  ],
  "PersonNumber": "679957",
  "FullName": "Abraham Zack McGlynn DDS",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "eos",
      "Description": "Streamlined fault-tolerant standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "eos",
      "Description": "Streamlined fault-tolerant standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "FormalName": "Waters, Purdy and Herman",
  "Address": null,
  "Post3": "est",
  "Post2": "magnam",
  "Post1": "exercitationem",
  "Kanalname": "ullam",
  "Kanafname": "quidem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sunt",
  "ActiveInterests": 899,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 868,
  "DbiKey": "aut",
  "DbiLastModified": "2025-01-10T14:28:22.1647656+01:00",
  "DbiLastSyncronized": "2019-09-13T14:28:22.1647656+02:00",
  "SentInfo": 757,
  "ShowContactTickets": 440,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "exercitationem",
      "StrippedValue": "animi",
      "Description": "Self-enabling zero tolerance implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "animi",
      "Description": "Self-enabling zero tolerance implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "suscipit",
      "Description": "Compatible mission-critical framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "suscipit",
      "Description": "Compatible mission-critical framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "Source": 406,
  "ActiveErpLinks": 555,
  "ShipmentTypes": [
    {
      "Id": 856,
      "Name": "Wisozk-Gerhold",
      "ToolTip": "Nam doloremque odio et.",
      "Deleted": false,
      "Rank": 53,
      "Type": "omnis",
      "ColorBlock": 510,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2012-04-02T14:28:22.1647656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "harum",
      "StyleHint": "odio",
      "Hidden": true,
      "FullName": "Ms. Enoch Abshire MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 209,
      "Comment": "nulla",
      "Registered": "2003-09-11T14:28:22.1647656+02:00",
      "RegisteredAssociateId": 313,
      "Updated": "2022-03-21T14:28:22.1647656+01:00",
      "UpdatedAssociateId": 130,
      "LegalBaseId": 855,
      "LegalBaseKey": "vel",
      "LegalBaseName": "Boyle, Bogan and Smitham",
      "ConsentPurposeId": 894,
      "ConsentPurposeKey": "sunt",
      "ConsentPurposeName": "Jenkins Inc and Sons",
      "ConsentSourceId": 431,
      "ConsentSourceKey": "quas",
      "ConsentSourceName": "Murray, Paucek and Krajcik",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 428
        }
      }
    }
  ],
  "BounceEmails": [
    "matilda@hermistonnikolaus.name",
    "joanne@reynolds.co.uk"
  ],
  "ActiveStatusMonitorId": 20,
  "CreatedByFormId": 633,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1860538052"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "possimus"
  },
  "CustomFields": {
    "CustomFields1": "exercitationem",
    "CustomFields2": "quidem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 145
    }
  }
}
```