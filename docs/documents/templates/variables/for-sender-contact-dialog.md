---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com

# Mandatory fields.
title: variables_for_sender_contact_dialog       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Variables for the sender (Contact dialog) # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference                # article, howto, reference, concept, guide
# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Variables for the sender (Contact dialog)

| Variable | Description |
|----------|-------------|
| alid | Sender’s user ID |
| atit | Sender’s title |
| auac | The sender's academic title |
| aubd | Date of birth |
| auca | The sender's chat address |
| aucd | The sender's chat address, ID (hidden, unique ID) |
| auci | Postal town. (See also [aucs][1].) |
| aucn | Country |
| aucp | The sender's chat address protocol |
| aucs | Postal town, state/province and zipcode (for American, Canadian and Australian addresses, e.g. Bedford, MA 01730) |
| aucy | County (for UK addresses) |
| audf | Direct fax number |
| audp | Direct phone number |
| auem | E-mail |
| auid | Sender’s contact ID (hidden, unique ID) |
| aumr | Mr/Ms for sender |
| aums | Mail Stop (for American addresses) |
| aunm | Number recorded for the document's owner |
| aup1 | Sender’s postal address, line 1 |
| aup2 | Sender’s postal address, line 2 |
| aup3 | Sender’s postal address, line 3 |
| aupc | Mobile phone |
| auph | Home telephone |
| aupo | Position |
| aupp | Other phone (was "Pager" before 7.0) |
| aust | State/province (for American, Canadian and Australian addresses). (See also [aucs][1].) |
| auth | Sender’s first name and last name |
| auvo | The sender's VOIP address |
| auvi | The sender's VOIP address, ID (hidden, unique ID) |
| auvs | The sender's VOIP service (description) |
| auwi | The sender's primary web address, ID (hidden, unique ID) |
| auww | The sender's primary web address |
| auzi | Postcode. (See also [aucs][1].) |
| uf01-10 | User-defined field 1-10 of the decimal number type |
| ul01-60 | User-defined field 1-60 of the whole number type |
| us01-49 | User-defined field 1-49 of the text type |

<!-- Referenced links -->
[1]: https://community.superoffice.com/Documentation/Help/EN/CRM/8.0/WebHelpAdmin/Template_variables.htm?rhtocid=2_1#aucs