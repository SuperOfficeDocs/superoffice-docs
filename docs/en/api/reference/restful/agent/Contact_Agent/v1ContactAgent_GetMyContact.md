---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 791,
  "Name": "Durgan-Muller",
  "Department": "",
  "OrgNr": "1396439",
  "Number1": "211707",
  "Number2": "837640",
  "UpdatedDate": "2014-06-07T11:06:34.1601668+02:00",
  "CreatedDate": "2011-05-10T11:06:34.1601668+02:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "ab",
      "Description": "Business-focused bandwidth-monitored orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "ab",
      "Description": "Business-focused bandwidth-monitored orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 755,
      "Name": "Walter-Ziemann",
      "ToolTip": "Molestias non et non quis ullam.",
      "Deleted": false,
      "Rank": 709,
      "Type": "corporis",
      "ColorBlock": 960,
      "IconHint": "magnam",
      "Selected": false,
      "LastChanged": "2003-03-26T11:06:34.1601668+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "minima",
      "Hidden": false,
      "FullName": "Wilbert Schulist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "qui",
      "Description": "Ameliorated multi-tasking utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "qui",
      "Description": "Ameliorated multi-tasking utilisation",
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
  "Phones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "amet",
      "Description": "Enterprise-wide value-added protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "amet",
      "Description": "Enterprise-wide value-added protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "ut",
      "Description": "Pre-emptive mission-critical product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "ut",
      "Description": "Pre-emptive mission-critical product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "Description": "Future-proofed solution-oriented encryption",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "commodi",
      "PersonId": 915,
      "Mrmrs": "sit",
      "Firstname": "Verner",
      "Lastname": "Bernier",
      "MiddleName": "Klocko-Murazik",
      "Title": "quo",
      "Description": "Enhanced needs-based customer loyalty",
      "Email": "natalia@balistreri.co.uk",
      "FullName": "Dr. Syble Luis Douglas DVM",
      "DirectPhone": "401-032-6414 x36430",
      "FormalName": "Hintz Group",
      "CountryId": 496,
      "ContactId": 705,
      "ContactName": "Goyette, Mills and Greenholt",
      "Retired": 296,
      "Rank": 599,
      "ActiveInterests": 280,
      "ContactDepartment": "",
      "ContactCountryId": 400,
      "ContactOrgNr": "839088",
      "FaxPhone": "1-175-393-5695 x665",
      "MobilePhone": "629.940.4949 x850",
      "ContactPhone": "886.016.8661 x857",
      "AssociateName": "Kuhic Group",
      "AssociateId": 772,
      "UsePersonAddress": false,
      "ContactFax": "culpa",
      "Kanafname": "rerum",
      "Kanalname": "hic",
      "Post1": "nesciunt",
      "Post2": "suscipit",
      "Post3": "voluptatibus",
      "EmailName": "edwin_romaguera@nolan.uk",
      "ContactFullName": "Alycia Spinka",
      "ActiveErpLinks": 938,
      "TicketPriorityId": 972,
      "SupportLanguageId": 440,
      "SupportAssociateId": 70,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 320
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "officiis",
  "Xstop": true,
  "ActiveInterests": 735,
  "GroupId": 999,
  "ActiveStatusMonitorId": 70,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 647,
  "DbiAgentId": 920,
  "DbiLastSyncronized": "2000-08-01T11:06:34.175828+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2004-11-01T11:06:34.175828+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 643,
  "ActiveErpLinks": 413,
  "BounceEmails": [
    "martine_thiel@hane.ca",
    "joannie@gutkowskibednar.uk"
  ],
  "Domains": [
    "ullam",
    "numquam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1110368435",
    "SuperOffice:2": "1559683967"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 83
    }
  }
}
```