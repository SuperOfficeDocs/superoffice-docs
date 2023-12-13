<!-- markdownlint-disable-file MD041 -->
The iCal page does the same login check as the Result page, but it reads the user's follow-ups and outputs the iCal. The search limits the number of follow-ups to about 2 months worth, weighted towards future/planned follow-up.

[!code-csharp[CS](../ical-write-results.cs?range=1-5)]

To output the follow-ups, we need to set a few things in the header:

[!code-csharp[CS](../ical-write-results.cs?range=7-12)]

The response itself has a header and then a list of follow-up details.

### Content header

[!code-csharp[CS](../ical-write-results.cs?range=14-21)]

### Per-appointment output

[!code-csharp[CS](../ical-write-results.cs?range=23-68)]

Google is picky about the time-zone ID on the DTSTART/DTEND – it must be present.

This page results in output like this:

```text
BEGIN:VCALENDAR
PRODID:-//SuperOffice AS//SuperOffice Calendar 6//EN
VERSION:2.0
CALSCALE:GREGORIAN
METHOD:PUBLISH
X-WR-CALNAME:SO Christian
X-WR-CALDESC:Christian SuperOffice calendar
X-WR-TIMEZONE;VALUE=TEXT:Europe/Oslo
BEGIN:VEVENT
DTSTART;TZID=Europe/Oslo:20110209T123000
DTEND;TZID=Europe/Oslo:20110209T133000
DTSTAMP:20110209T083551Z
UID:appointmentid-3146920@localhost
CLASS:PUBLIC
CREATED:20110125T141334Z
LAST-MODIFIED:20110209T083551Z
SUMMARY:Meeting - IN: Discuss Expander Online Extensibility\n\n-Web...
CATEGORIES:Meeting - IN
DESCRIPTION:Meeting - IN / SuperOffice AS / Discuss Expander Online Extensibility\n\n- Web Services (currently limited availability)\n- NetServer Services Scripting\n- .merge/.config file modifications
SEQUENCE:0
STATUS:CONFIRMED
TRANSP:OPAQUE
END:VEVENT
BEGIN:VEVENT
DTSTART;TZID=Europe/Oslo:20110211T130000
DTEND;TZID=Europe/Oslo:20110211T140000
DTSTAMP:20110207T101132Z
UID:appointmentid-3154868@localhost
CLASS:PUBLIC
CREATED:20110203T110804Z
LAST-MODIFIED:20110207T101132Z
SUMMARY:Meeting - IN: (Almost) MAF-meeting – Configuration
...
END:VEVENT
END:VCALENDAR
```
