---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=598
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 705,
  "Name": "Halvorson, Buckridge and Davis",
  "Department": "",
  "OrgNr": "619898",
  "Number1": "513840",
  "Number2": "602689",
  "UpdatedDate": "2022-07-28T15:29:21.1128185+02:00",
  "CreatedDate": "2014-06-01T15:29:21.1128185+02:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "fugit",
      "Description": "Monitored 6th generation initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 936
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "fugit",
      "Description": "Monitored 6th generation initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 936
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 460,
      "Name": "Gerlach Inc and Sons",
      "ToolTip": "Odio ea dolor ea nisi.",
      "Deleted": true,
      "Rank": 805,
      "Type": "sit",
      "ColorBlock": 94,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "1999-04-20T15:29:21.1133182+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "repellat",
      "Hidden": true,
      "FullName": "Ms. Kavon Eden Wisoky",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 337
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "ex",
      "Description": "Proactive explicit parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "ex",
      "Description": "Proactive explicit parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "et",
      "Description": "Customizable explicit projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "et",
      "Description": "Customizable explicit projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eligendi",
      "StrippedValue": "cum",
      "Description": "Organized static secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "cum",
      "Description": "Organized static secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "Description": "Synergized encompassing encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "id",
      "PersonId": 545,
      "Mrmrs": "est",
      "Firstname": "Gregoria",
      "Lastname": "Torphy",
      "MiddleName": "Mayert, Goyette and Waters",
      "Title": "nam",
      "Description": "Open-architected methodical frame",
      "Email": "delilah@veum.ca",
      "FullName": "Kaela Jerde",
      "DirectPhone": "(814)198-5763 x8308",
      "FormalName": "Maggio, Dach and Klocko",
      "CountryId": 763,
      "ContactId": 748,
      "ContactName": "Abshire-Rogahn",
      "Retired": 1002,
      "Rank": 429,
      "ActiveInterests": 482,
      "ContactDepartment": "",
      "ContactCountryId": 59,
      "ContactOrgNr": "893838",
      "FaxPhone": "637.247.0987",
      "MobilePhone": "005-034-8604 x6776",
      "ContactPhone": "895-977-8480",
      "AssociateName": "O'Keefe, Rodriguez and Schultz",
      "AssociateId": 140,
      "UsePersonAddress": false,
      "ContactFax": "impedit",
      "Kanafname": "nemo",
      "Kanalname": "sequi",
      "Post1": "ut",
      "Post2": "et",
      "Post3": "excepturi",
      "EmailName": "heather@schuppe.co.uk",
      "ContactFullName": "Modesta Hodkiewicz IV",
      "ActiveErpLinks": 385,
      "TicketPriorityId": 542,
      "SupportLanguageId": 573,
      "SupportAssociateId": 249,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 610
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "molestias",
  "Xstop": false,
  "ActiveInterests": 718,
  "GroupId": 763,
  "ActiveStatusMonitorId": 729,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 9,
  "DbiAgentId": 586,
  "DbiLastSyncronized": "1999-12-15T15:29:21.117318+01:00",
  "DbiKey": "nesciunt",
  "DbiLastModified": "2013-03-13T15:29:21.1178182+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 291,
  "ActiveErpLinks": 101,
  "BounceEmails": [
    "otto@keeling.info",
    "maiya.gaylord@fisher.us"
  ],
  "Domains": [
    "sunt",
    "quas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Colleen Kunde",
    "SuperOffice:2": "1207237315"
  },
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "nesciunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 653
    }
  }
}
```