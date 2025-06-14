---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=613
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 699,
  "Name": "Abshire-Dach",
  "Department": "",
  "OrgNr": "885702",
  "Number1": "1602737",
  "Number2": "715047",
  "UpdatedDate": "2010-12-12T17:54:02.8514704+01:00",
  "CreatedDate": "2020-07-17T17:54:02.8514704+02:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "asperiores",
      "Description": "Team-oriented holistic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 4
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "asperiores",
      "Description": "Team-oriented holistic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 4
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 300,
      "Name": "Denesik, Toy and Kirlin",
      "ToolTip": "Iure error quidem ut saepe ut fuga.",
      "Deleted": false,
      "Rank": 60,
      "Type": "vel",
      "ColorBlock": 188,
      "IconHint": "aliquid",
      "Selected": false,
      "LastChanged": "2003-09-15T17:54:02.8514704+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Helena Kulas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "quia",
      "Description": "Sharable even-keeled service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "quia",
      "Description": "Sharable even-keeled service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "possimus",
      "StrippedValue": "maxime",
      "Description": "Profound transitional instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "maxime",
      "Description": "Profound transitional instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iusto",
      "StrippedValue": "quis",
      "Description": "Innovative fresh-thinking policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 310
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "quis",
      "Description": "Innovative fresh-thinking policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 310
        }
      }
    }
  ],
  "Description": "Re-contextualized bottom-line alliance",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laborum",
      "PersonId": 878,
      "Mrmrs": "temporibus",
      "Firstname": "Crystel",
      "Lastname": "Batz",
      "MiddleName": "Ondricka-Dickens",
      "Title": "voluptate",
      "Description": "Progressive 24 hour extranet",
      "Email": "mohamed@abernathy.us",
      "FullName": "Elody Jerde",
      "DirectPhone": "682.442.2302 x91293",
      "FormalName": "Wyman LLC",
      "CountryId": 843,
      "ContactId": 660,
      "ContactName": "Mayert, Raynor and Greenholt",
      "Retired": 43,
      "Rank": 600,
      "ActiveInterests": 608,
      "ContactDepartment": "",
      "ContactCountryId": 668,
      "ContactOrgNr": "1737016",
      "FaxPhone": "718-640-9404 x49364",
      "MobilePhone": "(483)405-7236 x383",
      "ContactPhone": "351-028-0519 x477",
      "AssociateName": "Zboncak, Sipes and Cole",
      "AssociateId": 24,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "dolores",
      "Kanalname": "sint",
      "Post1": "natus",
      "Post2": "consequatur",
      "Post3": "sed",
      "EmailName": "reagan@welchgreenfelder.info",
      "ContactFullName": "Elisa Murazik",
      "ActiveErpLinks": 579,
      "TicketPriorityId": 68,
      "SupportLanguageId": 583,
      "SupportAssociateId": 811,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1176110",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 394
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "neque",
  "Xstop": true,
  "ActiveInterests": 992,
  "GroupId": 76,
  "ActiveStatusMonitorId": 627,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 261,
  "DbiAgentId": 159,
  "DbiLastSyncronized": "2005-11-17T17:54:02.8514704+01:00",
  "DbiKey": "nihil",
  "DbiLastModified": "2017-06-01T17:54:02.8514704+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 465,
  "ActiveErpLinks": 408,
  "BounceEmails": [
    "alva@toycollier.us",
    "antwan.greenfelder@haucktoy.biz"
  ],
  "Domains": [
    "minima",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Erwin Kunde",
    "SuperOffice:2": "Armani Marks"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "corrupti",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 824
    }
  }
}
```