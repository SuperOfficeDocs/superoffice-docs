---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 897
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 130,
  "Name": "Hoeger-Jacobi",
  "Department": "implement open-source ROI",
  "OrgNr": "1113524",
  "Number1": "1444915",
  "Number2": "1358450",
  "UpdatedDate": "1997-07-01T11:16:08.9284649+02:00",
  "CreatedDate": "2009-05-21T11:16:08.9284649+02:00",
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "distinctio",
      "Description": "Visionary fresh-thinking architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "distinctio",
      "Description": "Visionary fresh-thinking architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 293,
      "Name": "Koepp LLC",
      "ToolTip": "Sit sunt molestias rerum officia soluta.",
      "Deleted": false,
      "Rank": 360,
      "Type": "ipsa",
      "ColorBlock": 107,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2006-03-23T11:16:08.9284649+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "a",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Mrs. Friedrich Vandervort",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "omnis",
      "Description": "Front-line eco-centric complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "omnis",
      "Description": "Front-line eco-centric complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "temporibus",
      "StrippedValue": "eligendi",
      "Description": "Stand-alone exuding core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "eligendi",
      "Description": "Stand-alone exuding core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "totam",
      "StrippedValue": "nihil",
      "Description": "Vision-oriented full-range system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "nihil",
      "Description": "Vision-oriented full-range system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "Description": "Enhanced eco-centric knowledge base",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 545,
      "Mrmrs": "iure",
      "Firstname": "Lenna",
      "Lastname": "Herzog",
      "MiddleName": "Feeney Inc and Sons",
      "Title": "qui",
      "Description": "Persevering radical flexibility",
      "Email": "jacinto.mcclure@kinghilpert.co.uk",
      "FullName": "Jessy Micaela Towne DDS",
      "DirectPhone": "1-332-865-0222 x207",
      "FormalName": "Kerluke LLC",
      "CountryId": 144,
      "ContactId": 269,
      "ContactName": "Stark Group",
      "Retired": 879,
      "Rank": 920,
      "ActiveInterests": 87,
      "ContactDepartment": "",
      "ContactCountryId": 171,
      "ContactOrgNr": "1251288",
      "FaxPhone": "233-586-8092 x52802",
      "MobilePhone": "(285)411-9324 x350",
      "ContactPhone": "559-547-7304",
      "AssociateName": "Dicki-Bednar",
      "AssociateId": 939,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "id",
      "Kanalname": "reiciendis",
      "Post1": "cum",
      "Post2": "nihil",
      "Post3": "enim",
      "EmailName": "dasia@west.uk",
      "ContactFullName": "Louie Nader",
      "ActiveErpLinks": 511,
      "TicketPriorityId": 597,
      "SupportLanguageId": 502,
      "SupportAssociateId": 321,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 240
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nam",
  "Xstop": false,
  "ActiveInterests": 567,
  "GroupId": 525,
  "ActiveStatusMonitorId": 292,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 252,
  "DbiAgentId": 164,
  "DbiLastSyncronized": "2016-11-13T11:16:08.9284649+01:00",
  "DbiKey": "in",
  "DbiLastModified": "2017-08-07T11:16:08.9284649+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 167,
  "ActiveErpLinks": 525,
  "BounceEmails": [
    "fleta.klein@metzturcotte.name",
    "shanon@kulasosinski.us"
  ],
  "Domains": [
    "ut",
    "tempora"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Nya Gutmann",
    "SuperOffice:2": "Jamel McClure"
  },
  "ExtraFields": {
    "ExtraFields1": "excepturi",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "esse"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 869
    }
  }
}
```