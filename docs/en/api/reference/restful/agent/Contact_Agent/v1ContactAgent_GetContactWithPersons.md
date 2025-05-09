---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 623
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 368,
  "Name": "Turner, Bogisich and Cummings",
  "Department": "",
  "OrgNr": "548741",
  "Number1": "1336717",
  "Number2": "1818088",
  "UpdatedDate": "2010-02-13T16:32:38.461545+01:00",
  "CreatedDate": "2016-12-15T16:32:38.461545+01:00",
  "Emails": [
    {
      "Value": "distinctio",
      "StrippedValue": "earum",
      "Description": "Realigned holistic groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 795
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "earum",
      "Description": "Realigned holistic groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 795
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 857,
      "Name": "Bogisich Group",
      "ToolTip": "Qui error aut consequatur sint nobis nam.",
      "Deleted": true,
      "Rank": 877,
      "Type": "sint",
      "ColorBlock": 444,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "2011-03-22T16:32:38.461545+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "aperiam",
      "Hidden": false,
      "FullName": "Mr. Hilda Forrest Koss",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 502
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "a",
      "StrippedValue": "numquam",
      "Description": "Grass-roots bandwidth-monitored hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 142
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "numquam",
      "Description": "Grass-roots bandwidth-monitored hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 142
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "fugiat",
      "StrippedValue": "qui",
      "Description": "Persistent high-level analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "qui",
      "Description": "Persistent high-level analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "culpa",
      "StrippedValue": "itaque",
      "Description": "Multi-channelled 24/7 framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 552
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "itaque",
      "Description": "Multi-channelled 24/7 framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 552
        }
      }
    }
  ],
  "Description": "Multi-tiered optimal intranet",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "in",
      "PersonId": 922,
      "Mrmrs": "sequi",
      "Firstname": "Reilly",
      "Lastname": "Shields",
      "MiddleName": "Gottlieb LLC",
      "Title": "voluptas",
      "Description": "Triple-buffered object-oriented secured line",
      "Email": "hallie@grant.uk",
      "FullName": "Dr. Brady Kattie Bogan II",
      "DirectPhone": "043.369.6305 x9855",
      "FormalName": "Maggio Inc and Sons",
      "CountryId": 843,
      "ContactId": 792,
      "ContactName": "Wiza, Collier and Weber",
      "Retired": 464,
      "Rank": 268,
      "ActiveInterests": 529,
      "ContactDepartment": "",
      "ContactCountryId": 135,
      "ContactOrgNr": "1024391",
      "FaxPhone": "685.356.9683 x9419",
      "MobilePhone": "(225)804-9164",
      "ContactPhone": "1-699-923-0380 x58871",
      "AssociateName": "Tremblay LLC",
      "AssociateId": 141,
      "UsePersonAddress": false,
      "ContactFax": "accusamus",
      "Kanafname": "eos",
      "Kanalname": "qui",
      "Post1": "ut",
      "Post2": "magnam",
      "Post3": "distinctio",
      "EmailName": "orin@larsonstark.biz",
      "ContactFullName": "Maude Macejkovic",
      "ActiveErpLinks": 342,
      "TicketPriorityId": 973,
      "SupportLanguageId": 842,
      "SupportAssociateId": 902,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1166500",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "mollitia",
  "Xstop": false,
  "ActiveInterests": 434,
  "GroupId": 944,
  "ActiveStatusMonitorId": 214,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 530,
  "DbiAgentId": 176,
  "DbiLastSyncronized": "2015-07-09T16:32:38.461545+02:00",
  "DbiKey": "laudantium",
  "DbiLastModified": "2025-02-07T16:32:38.461545+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 645,
  "ActiveErpLinks": 150,
  "BounceEmails": [
    "reed@feestcorkery.uk",
    "jeremy_bode@schaden.name"
  ],
  "Domains": [
    "doloremque",
    "culpa"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Natasha Tromp",
    "SuperOffice:2": "1945541626"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quod"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 974
    }
  }
}
```