---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
content_type: reference
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 46,
  "Name": "Hauck Group",
  "Department": "",
  "OrgNr": "131677",
  "Number1": "1276850",
  "Number2": "1259007",
  "UpdatedDate": "2013-02-13T02:30:46.9757163+01:00",
  "CreatedDate": "2006-03-06T02:30:46.9757163+01:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "quas",
      "Description": "Face to face 4th generation customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quas",
      "Description": "Face to face 4th generation customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 864,
      "Name": "Abbott, Kuhic and Smith",
      "ToolTip": "Eos reprehenderit alias voluptas occaecati et.",
      "Deleted": false,
      "Rank": 885,
      "Type": "enim",
      "ColorBlock": 458,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2021-01-23T02:30:46.9757163+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "sit",
      "Hidden": true,
      "FullName": "Evangeline Greenfelder MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Diverse incremental protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 541
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Diverse incremental protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 541
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "odit",
      "StrippedValue": "et",
      "Description": "Public-key local local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "et",
      "Description": "Public-key local local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "error",
      "StrippedValue": "occaecati",
      "Description": "Synchronised actuating instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 874
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "occaecati",
      "Description": "Synchronised actuating instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 874
        }
      }
    }
  ],
  "Description": "Open-source bi-directional standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsum",
      "PersonId": 168,
      "Mrmrs": "cumque",
      "Firstname": "Soledad",
      "Lastname": "Konopelski",
      "MiddleName": "Mueller, Bergstrom and Schimmel",
      "Title": "quia",
      "Description": "Inverse holistic forecast",
      "Email": "yvonne.keebler@metz.com",
      "FullName": "Greg Aditya Schulist DDS",
      "DirectPhone": "594-883-8383 x60910",
      "FormalName": "Gibson Inc and Sons",
      "CountryId": 317,
      "ContactId": 863,
      "ContactName": "Weissnat, Goldner and Satterfield",
      "Retired": 793,
      "Rank": 92,
      "ActiveInterests": 978,
      "ContactDepartment": "",
      "ContactCountryId": 283,
      "ContactOrgNr": "1745902",
      "FaxPhone": "163-667-1363 x5615",
      "MobilePhone": "(811)842-7908 x654",
      "ContactPhone": "301.610.7962",
      "AssociateName": "Bartoletti Group",
      "AssociateId": 652,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "fugiat",
      "Kanalname": "rerum",
      "Post1": "possimus",
      "Post2": "eligendi",
      "Post3": "vero",
      "EmailName": "leo.pagac@macejkovic.us",
      "ContactFullName": "Saige Gibson",
      "ActiveErpLinks": 180,
      "TicketPriorityId": 622,
      "SupportLanguageId": 823,
      "SupportAssociateId": 976,
      "CategoryName": "VIP Customer",
      "PersonNumber": "573898",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "officia",
  "Xstop": true,
  "ActiveInterests": 618,
  "GroupId": 916,
  "ActiveStatusMonitorId": 285,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 904,
  "DbiAgentId": 779,
  "DbiLastSyncronized": "2019-06-16T02:30:46.9757163+02:00",
  "DbiKey": "optio",
  "DbiLastModified": "2021-02-25T02:30:46.9757163+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 616,
  "ActiveErpLinks": 54,
  "BounceEmails": [
    "ludwig@yundt.us",
    "emerson@deckow.name"
  ],
  "Domains": [
    "est",
    "temporibus"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "215734437",
    "SuperOffice:2": "Mr. Raymond Roob V"
  },
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "sequi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 589
    }
  }
}
```