---
uid: help-en-template-variables
title: Template variables
description: Template variables
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Template variables (CRM)

> [!TIP]
> Here you can find some examples of how template variables can enrich your mailings and documents: [Template variables - examples](Template_variables_examples.md)

The topics below give an overview of different template variables in SuperOffice CRM, which you can use when you create template documents.

## How to use template variables

The following sections list the different template variables, which you can use when creating template documents.

Here is a brief overview of how to use the variables in the templates:

* In documents of file type .doc in Office 2003 and older, you need to use angled brackets – &lt; &gt; – around variables instead of curly brackets – { } –.

<!-- -->

* The whole variable must be formatted using the same font and font size, and you must only use lowercase letters. However, if the **Use case-sensitive template variables** preference is enabled, the template variable can be formatted.
* You can mix normal text and variables in the template document: For example, you can enter template variables which retrieve a company’s name and address, type in standard text for the body of the letter and enter the variable for our contact to conclude the letter.
* You can also use fill characters in the template document (see below).
* The date and time in template variables are controlled by the PC's system clock.

> [!TIP]
> When you have created a new template document, you have to add it using the **Lists** screen in Settings and maintenance in order to use it in SuperOffice CRM.

## Fill characters

Sometimes you have to use fill characters in templates so that a field’s contents or formatting will not be changed or deleted if the content of a field is shorter than the length specified by the field variable.

Use the variable padd# to specify the fill character to use. Replace the \# character with the ANSI code of the character you wish to use as a fill character. You will usually find a list of ANSI codes in the manual for the program you are creating templates for.

SuperOffice CRM has default values for fill characters for the most commonly used word-processing and spreadsheet applications. A soft hyphen is usually used because it does not display on the screen or a printout. For applications where the set-up is unknown, SuperOffice CRM uses {padd32}, which is the ANSI code for a space.

> [!TIP]
> Microsoft Word uses {padd31} as a fill character.

If you do not want to use fill characters, use the template variable {padd0}.

> [!NOTE]
> This only works for document formats that are sequential, for example, Notepad and AmiPro templates without graphics.

When you use {padd0} you can write all the template variables without blank characters between the name of the template variable and the closing variable delimiter (}).

## Variables from the company card

> [!NOTE]
> Address variables from the company card are so called "smart" template variables. This means that the system selects address data in a specific order. The variables in **bold text** below (such as **addr** and **city**) are smart template variables.

<!-- Fix reuse ID=a1 -->

When you use address variables from the company card, the system will select address data in the following order:

1. If the **Use as postal address** option is active for a contact in the company, the contact's address data will be used.
2. If the above option is not active, the company's address data will be used.
3. If the company's postal address is empty, the company street address will be used.

| Variable | Description |
|---|---|
| addr | Postal address line 1. If this is empty, street address line 1. |
| busi | Business. |
| cate | Category. |
| ccid | Company’s country code. |
| cf01-10 | User-defined field 1-10 of the decimal number type. |
| cicn | Country name in English. |
| city | Postal town. |
| cl01-60 | User-defined field 1-60 of the whole number type. |
| cnt? | Country if different from the sender’s country. |
| cntr | Country. |
| cnty | County (for UK addresses). |
| code | Code. |
| cont | Our contact. |
| cozg | Line feed for internal post in Germany. |
| cozi | Postcode including country prefix (e.g. N-0163 for a postcode in Norway). Prefix is not used for Germany. |
| cozn | Line feed for Australian and UK treatment of counties and postcodes. |
| cphi | Company's phone number, ID (hidden, unique ID). |
| cpho | Company’s phone number. |
| cpht | Company's phone number with inter-area and international prefix. |
| cs01-49 | User-defined field 1-49 of the text type. |
| cspi | Main contact, ID |
| cspn | Main contact, full name |
| cszc | Postal town, state/province and zipcode (for American, Canadian and Australian addresses, e.g. Bedford, MA 01730). |
| cuid | Company ID (hidden, unique ID). |
| cwwi | The company's primary web address, ID (hidden, unique ID). |
| cwww | The company's primary web address. |
| czip | County and postcode (for UK addresses). |
| dept | Department. |
| faxi | Fax number, ID (hidden, unique ID). |
| faxn | Fax number. The contact’s direct number, if available. Otherwise the company’s fax number. |
| faxs | Fax number. The contact’s direct number, if available. Otherwise the company’s fax number. Without spaces. |
| maii | The company's primary e-mail address, ID (hidden, unique ID). |
| mail | The company’s primary e-mail address. |
| name | The company’s name. |
| ndep | The company’s name and department |
| numb | Number. |
| orgn | The company’s organisation number. |
| padr | Postal address, line 1. |
| pad2 | Postal address, line 2. |
| pad3 | Postal address, line 3. |
| phoi | Phone number, ID (hidden, unique ID). |
| phon | Phone number. The contact’s direct number, if available. Otherwise the company’s phone number. |
| sadr | Street address/office address, address line 1. |
| sams | First address line, including Mail Stop (for American addresses). |
| scit | Postal town for street address (for German addresses). |
| ssta | State/province for street address (for American, Canadian and Australian addresses). |
| stat | State/province (for American, Canadian and Australian addresses). (See also cszc.) |
| szip | Postcode for street address (for German addresses). |
| zici | Postcode and postal town (e.g. 0572 OSLO). |
| zino | Postcode prefix. |
| zipc | Postcode. (See also cszc.) |
| zipp | Postcode for street address. |

## Variables for a selected contact

| Variable | Description |
|---|---|
| abdt | Date of birth. |
| acha | The contact's chat address |
| achi | The contact's chat address, ID (hidden, unique ID). |
| achp | The contact's chat address protocol |
| acid | Contact’s country code. |
| acit | Postal town. (See also acsz.) |
| acnt | County (for UK addresses). |
| acsz | Postal town, state/province and postcode (e.g. Bedford, MA 01730). |
| act? | Country (if different from the sender’s country). |
| actg | Line feed for internal post in Germany. |
| actr | Country. |
| adep | Department. |
| af01-10 | User-defined field 1-10 of the decimal number type. |
| al01-60 | User-defined field 1-60 of the whole number type. |
| amai | The contact’s primary e-mail address. |
| amid | The contact's primary e-mail address, ID (hidden, unique ID). |
| anum | Number recorded for the contact. |
| apad | Postal address, line 1. |
| apa2 | Postal address, line 2. |
| apa3 | Postal address, line 3. |
| aphi | The contact's phone number, ID (hidden, unique ID). |
| apho | The contact’s phone number. |
| apli | Support language ID |
| aret | Is the contact a former employee? True or False. |
| as01-49 | User-defined field 1-49 of the text type. |
| asal | Academic title (salutation). |
| asci | Support contact, ID |
| ascn | Support contact, full name |
| asmu | URL for subscription management |
| aspr | Support priority |
| asta | State/province. (See also acsz.) |
| atei | The contact's primary e-mail address, ID (hidden, unique ID). |
| atem | The contact's primary e-mail address. If no e-mail address is recorded for the contact, the company's e-mail address is used. |
| atfa | Direct fax (Attention Fax). |
| atfi | Direct fax, ID (hidden, unique ID). |
| atfn | First name. |
| ati. | First name (first letter followed by stop). |
| atid | Selected contact's unique ID (person_id). |
| atin | First name (first letter). |
| atln | Last name. |
| atm? | Middle name (if middle name preference is set). |
| atmn | Middle name. |
| atmr | Mr/Ms field. |
| atms | Mail Stop (for American addresses). |
| atpc | Mobile phone (Attention Phone Cellular). |
| atpi | Mobile phone, ID (hidden, unique ID). |
| atph | Home telephone (Attention Phone Home). |
| atpj | Home telephone, ID (hidden, unique ID). |
| atpk | Pager, ID (hidden, unique ID). |
| atpl | Other phone with inter-area and international prefix. |
| atpm | Mobile phone with inter-area and international prefix. |
| atpo | Position. |
| atpp | Pager (Attention Phone Pager). |
| atpt | Home telephone with inter-area and international prefix. |
| atti | Title. |
| attl | The contact's login name if he/she has login rights (Attention). |
| attn | The contact's full name. |
| avoa | The contact's VOIP address. |
| avoi | The contact's VOIP address, ID (hidden, unique ID). |
| avos | The sender's VOIP service (description). |
| awwi | The contact's primary web address, ID (hidden, unique ID). |
| awww | The contact's primary web address. |
| azip | Postcode. (See also acsz.) |

## Variables for international addresses

| Variable | Description |
|---|---|
| fad1 | Line 1 in international addresses. |
| fad2 | Line 2 in international addresses. |
| fad3 | Line 3 in international addresses. |
| fad4 | Line 4 in international addresses. |
| fad5 | Line 5 in international addresses. |
| fad6 | Line 6 in international addresses. |
| fad7 | Line 7 in international addresses. |
| fad8 | Line 8 in international addresses. |
| fad9 | Line 9 in international addresses. |
| fada | Line 10 in international addresses. |
| fadb | Line 11 in international addresses. |
| fadc | Line 12 in international addresses. |
| fadd | Line 13 in international addresses. |
| fade | Line 14 in international addresses. |
| fadf | Line 15 in international addresses. |
| fadg | Line 16 in international addresses. |
| fadh | Line 17 in international addresses. |
| fadi | Line 18 in international addresses. |
| fadj | Line 19 in international addresses. |
| fadk | Line 20 in international addresses. |
| fadl | Line 21 in international addresses. |
| fadm | Line 22 in international addresses. |
| fadn | Line 23 in international addresses. |
| fado | Line 24 in international addresses. |

## Variables from the Document dialog or from the system

| Variable | Description |
|---|---|
| apid | Appointment ID. |
| atti | Title of the contact the document will be sent to. |
| attn | Selected contact in the **Document** dialog or text that is specified in the **Company** field for a recipient of the document. |
| date | Date in long format, e.g. 10 December 2004. |
| desc | Description of the created document. |
| df01-10 | User-defined field 1-10 of the decimal number type. |
| dl01-60 | User-defined field 1-60 of the whole number type. |
| doid | Document ID (hidden, unique ID). |
| dope | Document, end date for publishing. |
| dops | Document, start date for publishing. |
| ds01-49 | User-defined field 1-49 of the text type. |
| dsug | Suggested document ID for the document ("SuggestedDocument Id"). Set to 0 when the document is not part of a sale/project guide. |
| file | Name of the document, without the path (e.g. SUPER001.DOC). |
| head | The heading for the created document. |
| lanc | The ISO language code: "nb-NO", "en", "de-DE" etc. |
| lang | The language being used in SuperOffice CRM. |
| lanx | The SuperOffice language code: "NO", "US" "GE" etc. |
| ltim | Time in long format, e.g. 12:10:05. |
| oref | Our reference. |
| pltf | Platform: Windows or web. |
| ptha | SOARC path (from **SuperOffice.ini**). |
| pthi | Path to the folder where **SuperOffice.ini** is located. |
| pthp | Path to the folder where SuperOffice CRM is installed. |
| salu | Salutation as entered, or created automatically from the contact (Mr/Ms and last name). |
| sdat | Date in short format, e.g. 10.12.04. |
| ser# | SuperOffice CRM's serial number. |
| snum | Ascending serial number (different for every template). |
| time | Time in short format, e.g. 12:10. |
| ver# | SuperOffice CRM's version number. |
| vern | NetServer full name "Netserver 7.1 (Debug) 7.1.200.300". |
| yref | Your reference. |

> [!NOTE]
> The short and long date formats will be determined by your computer’s settings. You can edit the settings in Control Panel in Windows.

## Variables from the project card

| Variable | Description |
|---|---|
| pend | The project's end date, formatted 02.11.2011 (system format). |
| pgui | Is the project guided? "Yes" or "No" (translated). |
| pf01-10 | User-defined field 1-10 of the decimal number type. |
| pl01-60 | User-defined field 1-60 of the whole number type. |
| plea | Project manager. |
| pmid | The project's next milestone appointment, ID. |
| pmil | The project's next milestone date, formatted 02.11.2011 (system format). |
| pnam | Project name. |
| pnum | Project number. |
| popa | Project, event date. |
| pope | Project, end date for publishing. |
| pops | Project, start date for publishing. |
| prid | Project ID (hidden, unique ID). |
| ps01-49 | User-defined field 1-49 of the text type. |
| psta | Project status. |
| ptyp | Project type. |
| pwwi | The project's primary web address, ID (hidden, unique ID). |
| pwww | The project's primary web address. |

## Variables for the sender (contact card)

| Variable | Description |
|---|---|
| alid | Sender’s user name (User ID of the selected diary owner). |
| atit | Sender’s title. |
| auac | The sender's academic title |
| aubd | Date of birth. |
| auca | The sender's chat address |
| aucd | The sender's chat address, ID (hidden, unique ID). |
| auci | Postal town. (See also aucs.) |
| aucn | Country. |
| aucp | The sender's chat address protocol. |
| aucs | Postal town, state/province and zipcode (for American, Canadian and Australian addresses, e.g. Bedford, MA 01730). |
| aucy | County (for UK addresses). |
| audf | Direct fax number. |
| audi | Direct fax number with inter-area and international prefix. |
| audl | Direct phone number with inter-area and international prefix. |
| audp | Direct phone number. |
| auem | E-mail. |
| auid | Sender’s unique ID (person_id of the selected diary owner). |
| aumr | Mr/Ms for sender |
| aums | Mail Stop (for American addresses). |
| aunm | Number recorded for the document's owner. |
| aup1 | Sender’s postal address, line 1. |
| aup2 | Sender’s postal address, line 2. |
| aup3 | Sender’s postal address, line 3. |
| aupc | Mobile phone. |
| auph | Home telephone. |
| aupl | Home telephone with inter-area and international prefix. |
| aupm | Mobile phone with inter-area and international prefix. |
| aupo | Position. |
| aupp | Other phone (was "Pager" before 7.0). |
| aupt | Other phone with inter-area and international prefix. |
| aust | State/province (for American, Canadian and Australian addresses). (See also aucs.) |
| auth | Sender’s first name and last name. |
| auvo | The sender's VOIP address. |
| auvi | The sender's VOIP address, ID (hidden, unique ID). |
| auvs | The sender's VOIP service (description). |
| auwi | The sender's primary web address, ID (hidden, unique ID). |
| auww | The sender's primary web address. |
| auzi | Postcode. (See also aucs.) |
| uf01-10 | User-defined field 1-10 of the decimal number type. |
| ul01-60 | User-defined field 1-60 of the whole number type. |
| us01-49 | User-defined field 1-49 of the text type. |
| usid | Current user's unique ID (associate_id of the logged in user). |

## Variables from the sender’s own company card

| Variable | Description |
|---|---|
| ocid | Country code for sender’s company card. |
| ocit | Own organisation’s postal town. |
| ocnr | Own organisation’s country. |
| ocnt | Own organisation’s county (for UK addresses). |
| ocsz | Own organisation’s postal town, state/province and zipcode (for American, Canadian and Australian addresses). |
| oczi | Own organisation’s county and postcode (for UK addresses). |
| odep | The department the sender belongs to. |
| oema | Own organisation’s primary e-mail address. |
| of01-10 | User-defined field 1-10 of the decimal number type. |
| ofax | Own organisation’s primary fax number. |
| ol01-60 | User-defined field 1-60 of the whole number type. |
| onam | Name of own organisation. |
| oorg | Organisation number. |
| opad | Own organisation’s postal address, line 1. |
| opa2 | Own organisation’s postal address, line 2. |
| opa3 | Own organisation’s postal address, line 3. |
| ophi | Own organization's primary telephone number with inter-area and international prefix. |
| opho | Own organisation’s primary telephone number. |
| os01-49 | User-defined field 1-49 of the text type. |
| osad | Own organisation’s street address. |
| osct | Postal town for own organisation’s street address. |
| osta | Own organisation’s state/province (for American, Canadian and Australian addresses). |
| oszi | Postcode for own organisation’s street address. |
| owid | Own organisation's ID (hidden, unique ID). |
| owww | Own organisation’s primary web address. |
| ozip | Own organisation’s postcode. |

## Variables for sales

| Variable | Description |
|---|---|
| saam | Sale amount. |
| saau | Sale owner (associate), full name. |
| saca | Associate who made the sale, full name |
| sacu | Sale currency. |
| saco | Competitor, sale. |
| sacr | Sale credited to. |
| sada | Sale date, formatted 02.11.2011 (system format). |
| sadu | Sale next due date, formatted 02.11.2011 (system format). |
| said | Sales ID (hidden, unique ID). |
| sanu | Sales number. |
| sape | Sale, end date for publishing. |
| sapr | Probability, sale. |
| saps | Sale, start date for publishing. |
| sare | Reason (sold, lost or stalled). |
| saso | Sale source. |
| sast | Sale stage. |
| sati | Title of the sale. |
| satu | Sale status (stage) ("Open", "Sold", "Lost" or "Stalled"). |
| saty | Sale type. |
| sf01-10 | User-defined field 1-10 of the decimal number type. |
| sgui | Is the sale guided? "Yes" or "No" (translated). |
| sl01-60 | User-defined field 1-60 of the whole number type. |
| ss01-49 | User-defined field 1-49 of the text type. |
| sste | Are Stakeholders enabled on this sale? "Yes" or "No" (translated). |

## Variables for selections

| Variable | Description |
|---|---|
| mbrs | Selected list from selection. (Space-separated list of comma-separated companies and contacts from a selection). |
| slid | Selection ID. |
| snam | The selection name. |

## Variables for appointments

| Variable | Description |
|---|---|
| bafp | A list of persons invited to a meeting. Used in invitation e-mails. |
| baid | Appointment ID. |
| bape | Appointment, end date for publishing. |
| baps | Appointment, start date for publishing. |
| bcon | The appointment's company, name. |
| bcrd | The appointment's creation date, in PC's local time, formatted YYYYMMdd. |
| bcrt | The appointment's creation time, in PC's local time, formatted HHmmss. |
| bdlg | The "superoffice:invitations" link to the invitation dialog. |
| bdll | The "Use this link to open the Invitation dialog in SuperOffice CRM" link displayed for registered contacts. Blank if recipient is not a registered contact. |
| beda | The appointment's end date, formatted as YYYYMMdd. |
| bema | The appointment's owner, e-mail address. |
| beti | The appointment's end time, formatted as HHmmss. |
| bfre | Free/busy time. |
| biid | ID of the person invited to the follow-up. |
| binf | The appointment's description. |
| binl | First line of the appointment's description. |
| binv | Name of the person invited to the follow-up. |
| blab | Date or deadline. Translated name of an appointment or task. |
| bloc | Appointment location. |
| bmil | Is the appointment a milestone appointment? Translated "Yes" or "No". |
| bold | The appointment's old start date, formatted as YYYYMMdd. |
| bolt | The appointment's old start time, formatted as HHmmss. |
| bown | The appointment's owner, name. |
| bper | The appointment's contact, name. |
| bprd | The appointment's priority as a number. 1 = low, 2 = medium, 3 = high. |
| bpri | The appointment's priority as text. |
| bpro | The appointment's project, name. |
| brec | The appointment's tooltip for repeating appointments. |
| bred | The end date for the appointment's repeating pattern, formatted as YYYYMMdd. |
| brei | Translated text: "This appointment is part of a repeating pattern:". Empty if this is not a repeating pattern. |
| brel | Translated text "See below in this message for a list of the repeating appointments." Empty if this is not a repeating pattern. |
| brid | ID of the appointment's recurrence rule. |
| brph | Changes in the recurrence rule and/or participants for appointments. Used when sending e-mail to participants to notify them of changes to an appointment they are invited to. |
| brsd | The start date for the appointment's repeating pattern, formatted as YYYYMMdd. |
| bsda | The appointment's start date, formatted as YYYYMMdd. |
| bsta | The appointment's status (in English): "TENTATIVE", "CONFIRMED" or "CANCELLED". |
| bsti | The appointment's start time, formatted as HHmmss. |
| bsug | Suggested appointment ID for the appointment ("SuggestedAppointment Id"). Set to 0 when the appointment is not part of a sale/project guide. |
| btim | The appointment's date and time, e.g. 30.03.2005 (16:00)-(17:00). |
| btod | Today's date in UTC, formatted as YYYYMMdd. |
| btot | Current time in UTC, formatted as HHmmss. |
| btyp | Activity type. |
| btza | The appointment's start date, converted into the PC's local time. Formatted as YYYYMMdd. |
| btzb | The appointment's start time, converted into the PC's local time. Formatted as HHmmss. |
| btzd | The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200 |
| btze | The appointment's end time, converted into the PC's local time. Formatted as YYYYMMdd. |
| btzf | The appointment's end time, converted into the PC's local time. Formatted as HHmmss. |
| btzk | The time zone key, from the appointment's start date. (AR-CN means the Argentina-Corrientes time zone -0300.) |
| btzl | The time zone ID of the appointment. |
| btzn | The appointment's date and time converted to UTC if time zones are enabled. For example, 30.03.2005 (17:00)-(18:00). |
| btzm | Time zone formatted as Norway (GMT +1:00) if time zones are enabled. |
| btzs | The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200. |
| btzt | Time zone information, for the PC's local time. Formatted as (GMT+01.00) or (GMT-04.00). |
| btzv | The appointment's start date converted to UTC if time zones are enabled. Formatted as YYYYMMdd. |
| btzw | The appointment's start time converted to UTC if time zones are enabled. Formatted as HHmmss. |
| btzx | The appointment's end date converted to UTC if time zones are enabled. Formatted as YYYYMMdd. |
| btzy | The appointment's end time converted to UTC if time zones are enabled. Formatted as HHmmss. |
| bunt | The end date for the appointment's repeating pattern, formatted as "UNTIL=YYYYMMdd;". |
| bupc | The number of times the appointment has been updated. (Counter from version 6 onwards only). |
| bupd | Update date for the appointment, formatted as YYYYMMdd. |
| bupt | Update time for the appointment, formatted as HHmmss. |
| burl | Link to video meeting. |
| tf01-10 | User-defined field 1-10 of the decimal number type. |
| tl01-60 | User-defined field 1-60 of the whole number type. |
| ts01-49 | User-defined field 1-49 of the text type. |

## Variables for appointments corresponding to the iCal standard

| Variable | Description |
|---|---|
| bate | Formatted list of people invited to an appointment, created for iCal.<br />ATTENDEE;RSVP=TRUE;CN="First Invited":MAILTO:;PARTSTAT=ACCEPTED<br />ATTENDEE;RSVP=TRUE;CN="Test Testesen":MAILTO:test@superoffice.com;PARTSTAT=TENTATIVE |
| bpat | The main feature of the appointment's repeating pattern, formatted like the Daily pattern "FREQ=DAILY;", for example. |
| bprt | The priority of the appointment, converted to iCal format: our 1 = iCal 9, our 2 = iCal 5 (default), our 3 = iCal 1. |
| brul | The entire appointment's repeating pattern, formatted as "RRULE:" + bpat + bsub + bunt. |
| bsub | The secondary feature of the appointment's repeating pattern, formatted as the sub-pattern Daily Workday "BYDAY=MO,TU,WE,TH,FR;", for example. |
| bsun | The start of the week for the appointment's repeating pattern, formatted as "WKST=SU" or "WKST=MO". |
| btzr | The time zone rule for standard time, for the PC's local time. Formatted as RRULE:FREQ=YEARLY;WKST=MO;INTERVAL=1;BYMONTH=3;BYDAY=4SU |
| btzu | The time zone rule for summer time, for the PC's local time. Formatted as RRULE:FREQ=YEARLY;WKST=MO;INTERVAL=1;BYMONTH=10;BYDAY=4SU |
| buid | Unique ID created for iCal. SerialnoDfollowupIdDinvitedId (where D is a separator). For example, 1010000014D345D971. Only for follow-ups with several participants. |

## Variables for integration with web applications

| Variable | Description |
|---|---|
| usec | Encrypted login information for NetServer. |
| usem | Current user's primary e-mail address. |
| user | Current user ID. |
| usfn | Current user's first name. |
| usid | Current user's unique ID (associate_id of the logged in user). |
| usln | Current user's last name. |
| usmn | Current user's middle name. |

## Variables for Quote alternative

| Variable | Description |
|---|---|
qaf1 | Extra field 1. |
| qaf2 | Extra field 2. |
| qaf3 | Extra field 3. |
| qaf4 | Extra field 4. |
| qaf5 | Extra field 5. |
| qaky | ERP Quote alternative key. |
| qanm | Name. |

## Variables for Quote info

| Variable | Description |
|---|---|
| qabi | Version approved by (ID). |
| qaby | Version approved by (Full name). |
| qadt | Version approval reg date. |
| qarb | Version approval reg by (Full name). |
| qari | Version approval reg by (ID). |
| qatx | Version approved text. |
| qcom | Quote Comment. |
| qda1 | Version delivery address line 1, formatted. |
| qda2 | Version delivery address line 2, formatted. |
| qda3 | Version delivery address line 3, formatted. |
| qda4 | Version delivery address line 4, formatted. |
| qda5 | Version delivery address line 5, formatted. |
| qda6 | Version delivery address line 6, formatted. |
| qda7 | Version delivery address line 7, formatted. |
| qda8 | Version delivery address line 8, formatted. |
| qda9 | Version delivery address line 9, formatted. |
| qdci | Version delivery country ID. |
| qdcn | Version delivery country name. |
| qdek | Version delivery terms key (ID). |
| qdev | Version delivery terms (Display text). |
| qdtk | Version delivery type key (ID). |
| qdtv | Version delivery type (Display text). |
| qexp | Version expiry date. |
| qia1 | Version invoice address line 1, formatted. |
| qia2 | Version invoice address line 2, formatted. |
| qia3 | Version invoice address line 3, formatted. |
| qia4 | Version invoice address line 4, formatted. |
| qia5 | Version invoice address line 5, formatted. |
| qia6 | Version invoice address line 6, formatted. |
| qia7 | Version invoice address line 7, formatted. |
| qia8 | Version invoice address line 8, formatted. |
| qia9 | Version invoice address line 9, formatted. |
| qici | Version invoice country ID. |
| qicn | Version invoice country name. |
| qkey | Quote ERP quote key. |
| qnum | Version number. |
| qord | Quote ERP order key. |
| qpek | Version payment terms key (ID). |
| qpev | Version payment terms (Display text). |
| qpon | Quote PO Number. |
| qptk | Version payment type key (ID). |
| qptv | Version payment type (Display text). |
| qver | Version rank. |
| qvf1 | Version extra field 1. |
| qvf2 | Version extra field 2. |
| qvf3 | Version extra field 3. |
| qvf4 | Version extra field 4. |
| qvf5 | Version extra field 5. |
| qvid | Version ID. |
| qvky | Version ERP Key. |

## Variables for Quote line

| Variable | Description |
|---|---|
| qlca | Product category. |
| qlda | Discount amount. |
| qldc | Description. |
| qldp | Discount percent. |
| qlf1 | Extra field 1. |
| qlf2 | Extra field 2. |
| qlf3 | Extra field 3. |
| qlf4 | Extra field 4. |
| qlf5 | Extra field 5. |
| qlfa | Product family. |
| qlit | Item number. |
| qlky | ERP Quote Line key. |
| qllp | Unit list price. |
| qlmp | Unit minimum price. |
| qlnm | Name. |
| qlpc | Code. |
| qlpk | ERP Product key. |
| qlpu | Price unit. |
| qlqa | Quantity. |
| qlqd | Quantity delivered. |
| qlqu | Quantity unit. |
| qlre | Reason. |
| qlsc | Supplier code. |
| qlst | Subtotal. |
| qlsu | Supplier. |
| qltp | Total price. |
| qlty | Product type. |
| qlur | URL. |
| qlva | VAT. |
| qlvi | VAT info. |

## Variables for quote lines with subscription

| Variable | Description |
|---|---|
|qsqa | Subscription quantity (Blank if not subscription). |
| qsub | Is subscription? ("Yes" or blank). |
| qsun | Subscription unit (Blank if not subscription). |

## Variables for SuperOffice Service

These are variables for SuperOffice Service data used in SuperOffice CRM. [Click here to see template variables for SuperOffice Service and SuperOffice Marketing](../../Service/topics/Template_variables.md).

| Variable | Description |
|---|---|
| diid | Current diary owner
| tiid | Current request ID |
| csbu | BaseUrl e.g: `http://systemtest.superoffice.com/scripts/ticket.fcgi` |
| csiu | CgiUrlInternal e.g: `http://systemtest.superoffice.com` |
| csbn | CgiBin e.g: `/scripts` |
| csre | RegistryExtension e.g: `.fcgi` |
