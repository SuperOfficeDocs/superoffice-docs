---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com

# Mandatory fields.
title: variables_for_appointments       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Variables for appointments  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference       # article, howto, reference, concept, guide
# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Variables for appointments

| Variable | Description |
|----------|-------------|
| baid | Appointment ID |
| bape | Appointment, end date for publishing |
| baps | Appointment, start date for publishing |
| bcon | The appointment's company, name |
| bcrd | The appointment's creation date, in PC's local time, formatted YYYYMMdd |
| bcrt | The appointment's creation time, in PC's local time, formatted HHmmss |
| bdlg | The "superoffice:invitations" link to the invitation dialog |
| bdll | The "Use this link to open the Invitation dialog in SuperOffice CRM" link displayed for registered contacts. Blank if recipient is not a registered contact |
| beda | The appointment's end date, formatted as YYYYMMdd |
| bema | The appointment's owner, e-mail address |
| beti | The appointment's end time, formatted as HHmmss |
| bfre | Free/busy time |
| biid | ID of the person invited to the follow-up |
| binf | The appointment's description |
| binl | First line of the appointment's description |
| binv | Name of the person invited to the follow-up |
| blab | Date or deadline. Translated name of an appointment or task |
| bloc | Appointment location |
| bmil | Is the appointment a milestone appointment? Translated "Yes" or "No" |
| bold | The appointment's old start date, formatted as YYYYMMdd |
| bolt | The appointment's old start time, formatted as HHmmss |
| bown | The appointment's owner, name |
| bper | The appointment's contact, name |
| bprd | The appointment's priority as a number. 1 = low, 2 = medium, 3 = high |
| bpri | The appointment's priority as text |
| bpro | The appointment's project, name |
| brec | The appointment's tooltip for repeating appointments |
| bred | The end date for the appointment's repeating pattern, formatted as YYYYMMdd |
| brei | Translated text: "This appointment is part of a repeating pattern:". Empty is this is not a repeating pattern |
| brel | Translated text "See below in this message for a list of the repeating appointments." Empty is this is not a repeating pattern |
| brid | ID of the appointment's recurrence rule |
| brph | Changes in the recurrence rule and/or participants for appointments. Used when sending email to participants to notify them of changes to an appointment they are invited to |
| brsd | The start date for the appointment's repeating pattern, formatted as YYYYMMdd |
| bsda | The appointment's start date, formatted as YYYYMMdd |
| bsta | The appointment's status (in English): "TENTATIVE", "CONFIRMED" or "CANCELLED" |
| bsti | The appointment's start time, formatted as HHmmss |
| bsug | Suggested appointment ID for the appointment ("SuggestedAppointment Id"). Set to 0 when the appointment is not part of a sale/project guide |
| btim | The appointment's date and time, e.g. 30.03.2005 (16:00)-(17:00) |
| btod | Today's date in UTC, formatted as YYYYMMdd |
| btot | Current time in UTC, formatted as HHmmss |
| btyp | Activity type |
| btza | The appointment's start date, converted into the PC's local time. Formatted as YYYYMMdd |
| btzb | The appointment's start time, converted into the PC's local time. Formatted as HHmmss |
| btzd | The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200 |
| btze | The appointment's end time, converted into the PC's local time. Formatted as YYYYMMdd |
| btzf | The appointment's end time, converted into the PC's local time. Formatted as HHmmss |
| btzk | The time zone key, from the appointment's start date. (AR-CN means the Argentina-Corrientes time zone -0300.) | | btzl | The time zone ID of the appointment |
| btzn | The appointment's date and time converted to UTC if time zones are enabled. For example, 30.03.2005 (17:00)-(18:00) |
| btzm | Time zone formatted as Norway (GMT +1:00) if time zones are enabled |
| btzs | The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200 |
| btzt | Time zone information, for the PC's local time. Formatted as (GMT+01.00) or (GMT-04.00) |
| btzv | The appointment's start date converted to UTC if time zones are enabled. Formatted as YYYYMMdd |
| btzw | The appointment's start time converted to UTC if time zones are enabled. Formatted as HHmmss |
| btzx | The appointment's end date converted to UTC if time zones are enabled. Formatted as YYYYMMdd |
| btzy | The appointment's end time converted to UTC if time zones are enabled. Formatted as HHmmss |
| buid | Unique ID created for iCal. SerialnoDfollowupIdDinvitedId (where D is a separator). For example, 1010000014D345D971. Only for follow-ups with several participants |
| bunt | The end date for the appointment's repeating pattern, formatted as "UNTIL=YYYYMMdd;" |
| bupc | The number of times the appointment has been updated. (Counter from version 6 onwards only) |
| bupd | Update date for the appointment, formatted as YYYYMMdd |
| bupt | Update time for the appointment, formatted as HHmmss |
| tf01-10 | User-defined field 1-10 of the decimal number type |
| tl01-60 | User-defined field 1-60 of the whole number type |
| ts01-49 | User-defined field 1-49 of the text type |
