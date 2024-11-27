<!-- markdownlint-disable-file MD041 -->
| Property Name | Tag | Description |
|---------------|-----|-------------|
| AppointmentId | baid | Unique ID for the appointment |
| AssociateOwnerName | bown | Name of owner associate            If this is a child booking, we want to look to the mother appointment's owner |
| ContactName | bcon | Name of associated contact |
| CreationDate | bcrd | Date when the appointment was created |
| CreationTime | bcrt | Time when the appointment was created |
| DaylightStandardTimeOffsetLocalTime | btzs | The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200 |
| Description | binf | A description of the appointment |
| DescriptionLine | binl | The first line of the appointment description |
| EMail | bema | The appointment's owner's emailaddress |
| EndDate | beda | End date for the appointment |
| EndDateLocalTime | btze | The appointment's end date, converted into the PC's local time. Formatted as YYYYMMdd. |
| EndDateUTC | btzx | The appointment's end date converted to UTC if time zones are enabled. Formatted as YYYYMMdd. |
| EndTime | beti | The appointment's endtime, formatted HHmmss |
| EndTimeLocalTime | btzf | The appointment's end time, converted into the PC's local time. Formatted as HHmmss. |
| EndTimeUTC | btzy | The appointment's end time converted to UTC if time zones are enabled. Formatted as HHmmss. |
| FreeBusy | bfre | Free/Busy time |
| ICalId | buid | Unique id made for iCal. SerialnoDappointmentIdDinvitedIdDupdated. Where D is a separator |
| ICalPriority | bprt | The appointment's priority converted to iCal format our 1 = iCal 9, our 2 = iCal 5, our 3 = iCal 9 |
| InvitationClickText | bdll | Not in use. Return empty string |
| InvitationFormattedList | bate | Formatted list of invited ??, made for iCal |
| InvitationUrl | bdlg | Not in use. Return empty string |
| InvitedList | bafp | Formatted list of invited persons, humanly readable |
| InviteeId | biid | Person ID for this row's invitee |
| InviteeName | binv | The name of this rows invited person |
| IsMilestone | bmil | Is the appointment a milestone appointment. Translated "Yes" or "No". |
| JoinMeetingUrl | burl |  |
| Location | bloc | The appoinment's location |
| MainRepeatingPattern | bpat | The main feature of the appointments repeating pattern, formatted like the Daily pattern "FREQ=DAILY;" for example |
| NorwayTime | btzm | Time zone formatted as Norway (GMT +1:00) if time zones are enabled. |
| Obsolete1 | bapa | Not in use. Return empty string |
| OffsetLocalTime | btzt | Time zone information, for the PC's local time. Formatted (GMT+01.00) or (GMT-04.00). |
| OldStartDate | bold | The appointments old start date, formatted as yyMMdd |
| OldStartTime | bolt | The appointments old start time, formatted as HHmmss |
| PersonName | bper | Name of associated person |
| Priority | bpri | The appointment's priority in clear text |
| PriorityId | bprd | The appointment's priority by number, 1 = low, 2 = medium, 3 = high |
| ProjectName | bpro | Name of associated project |
| PublishEndDate | bape | Appointment, end date for publication            Not in use |
| PublishStartDate | baps | Appointment, start date for publication            Not in use |
| RecurrenceParticipantChanges | brph | Changes in recurrence and/or participants for appointments.  Used when sending e-mail to participants on booking changes. (Only SIX.web)	// New in SIX.web 29.5.2007 sent to INK for last update of help |
| RepeatingAppointmentId | brid | Appointment ID for any repeating appointments |
| RepeatingEndDate | bred | The end date for the appointment's repeating pattern, formatted as short date |
| RepeatingPattern | brul | The entire appointment's repeating pattern, formatted as "RRULE:" + bpat + bsub + bunt |
| RepeatingPatternEnd | bunt | The end date for the appointment's repeating pattern, formatted as "UNTIL=YYYYMMddTHHmmss;" |
| RepeatingPatternText | brei | The text "This appointment is part of a repeating pattern:" |
| RepeatingPatternText2 | brel | The text "See below in this message for a list of the repeating appointments." |
| RepeatingStartDate | brsd | The start date for the appointment's repeating pattern, formatted as YYYYMMdd |
| RepeatingTooltip | brec | The appointment's tooltip for repeating appointments |
| RepeatingWeekstart | bsun | The start of the week for the appointment's repeating pattern,formatted as "WKST=SU" or "WKST=MO" |
| StartDate | bsda | Start date of the appointment |
| StartDateLabel | blab | Date or deadline if this is a task or an appointment |
| StartDateLocalTime | btza | The appointment's start date, converted into the PC's local time. Formatted as YYYYMMdd. |
| StartDateTimeAndDuration | btim | The appointment's date and time. E.g. 30.03.2005 (16:00)-(17:00). |
| StartDateUTC | btzv | The appointment's start date converted to UTC if time zones are enabled. Formatted as YYYYMMdd. |
| StartTime | bsti | The appointment's starttime, formatted HHmmss |
| StartTimeLocalTime | btzb | The appointment's start time, converted into the PC's local time. Formatted as HHmmss. |
| StartTimeUTC | btzw | The appointment's start time converted to UTC if time zones are enabled. Formatted as HHmmss. |
| State | bsta | The state of the appointment: "TENTATIVE", "CONFIRMED" eller "CANCELLED". |
| SubRepeatingPattern | bsub | The secondary feature of the appointment's repeating pattern, formatted as the sub-pattern Daily Workday "BYDAY=MO,TU,WE,TH,FR;", for example. |
| SuggestedAppointmentId | bsug | The appointment's SuggestedAppointment ID. 0 when appointment is not part of a sale/project guide. |
| TimeZoneId | btzl | The time zone ID of the appointment. |
| TimeZoneKey | btzk | The time zone key, from the appointment's start date. (AR-CN means the Argentina-Corrientes time zone -0300.) |
| TimeZoneRuleStandardTime | btzr | The time zone rule for standard time, for the PC's local time. Formatted as RRULE:FREQ=YEARLY;WKST=MO;INTERVAL=1;BYMONTH=3;BYDAY=4SU |
| TimeZoneRuleSummerTime | btzu | The time zone rule for summer time, for the PC's local time. Formatted as RRULE:FREQ=YEARLY;WKST=MO;INTERVAL=1;BYMONTH=10;BYDAY=4SU |
| TimeZoneSummerOffsetLocalTime | btzd | The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200 |
| Type | btyp | Activity type |
| UpdatedCount | bupc | How many times the appointment has been updated |
| UpdatedDate | bupd | The last date the appointment was updated |
| UpdatedTime | bupt | The last time the appointment was updated |
| UTCTime | btzn | The appointment's date and time converted to UTC if time zones are enabled. For example, 30.03.2005 (17:00)-(18:00). |

## User Defined Fields

The following user defined fields are available for this template variable.

| Property Name | Tag | Description |
|---------------|-----|-------------|
| UserDefinedFieldDecimal1 | tf01 | Userdefined field 1 of type decimal |
| UserDefinedFieldDecimal2 | tf02 | Userdefined field 2 of type decimal |
| UserDefinedFieldDecimal3 | tf03 | Userdefined field 3 of type decimal |
| UserDefinedFieldDecimal4 | tf04 | Userdefined field 4 of type decimal |
| UserDefinedFieldDecimal5 | tf05 | Userdefined field 5 of type decimal |
| UserDefinedFieldDecimal6 | tf06 | Userdefined field 6 of type decimal |
| UserDefinedFieldDecimal7 | tf07 | Userdefined field 7 of type decimal |
| UserDefinedFieldDecimal8 | tf08 | Userdefined field 8 of type decimal |
| UserDefinedFieldDecimal9 | tf09 | Userdefined field 9 of type decimal |
| UserDefinedFieldDecimal10 | tf10 | Userdefined field 10 of type decimal |
| UserDefinedFieldInt1 | tl01 | User defined field 1 of type integer |
| UserDefinedFieldInt2 | tl02 | User defined field 2 of type integer |
| UserDefinedFieldInt3 | tl03 | User defined field 3 of type integer |
| UserDefinedFieldInt4 | tl04 | User defined field 4 of type integer |
| UserDefinedFieldInt5 | tl05 | User defined field 5 of type integer |
| UserDefinedFieldInt6 | tl06 | User defined field 6 of type integer |
| UserDefinedFieldInt7 | tl07 | User defined field 7 of type integer |
| UserDefinedFieldInt8 | tl08 | User defined field 8 of type integer |
| UserDefinedFieldInt9 | tl09 | User defined field 9 of type integer |
| UserDefinedFieldInt10 | tl10 | User defined field 10 of type integer |
| UserDefinedFieldInt11 | tl11 | User defined field 11 of type integer |
| UserDefinedFieldInt12 | tl12 | User defined field 12 of type integer |
| UserDefinedFieldInt13 | tl13 | User defined field 13 of type integer |
| UserDefinedFieldInt14 | tl14 | User defined field 14 of type integer |
| UserDefinedFieldInt15 | tl15 | User defined field 15 of type integer |
| UserDefinedFieldInt16 | tl16 | User defined field 16 of type integer |
| UserDefinedFieldInt17 | tl17 | User defined field 17 of type integer |
| UserDefinedFieldInt18 | tl18 | User defined field 18 of type integer |
| UserDefinedFieldInt19 | tl19 | User defined field 19 of type integer |
| UserDefinedFieldInt20 | tl20 | User defined field 20 of type integer |
| UserDefinedFieldInt21 | tl21 | User defined field 21 of type integer |
| UserDefinedFieldInt22 | tl22 | User defined field 22 of type integer |
| UserDefinedFieldInt23 | tl23 | User defined field 23 of type integer |
| UserDefinedFieldInt24 | tl24 | User defined field 24 of type integer |
| UserDefinedFieldInt25 | tl25 | User defined field 25 of type integer |
| UserDefinedFieldInt26 | tl26 | User defined field 26 of type integer |
| UserDefinedFieldInt27 | tl27 | User defined field 27 of type integer |
| UserDefinedFieldInt28 | tl28 | User defined field 28 of type integer |
| UserDefinedFieldInt29 | tl29 | User defined field 29 of type integer |
| UserDefinedFieldInt30 | tl30 | User defined field 30 of type integer |
| UserDefinedFieldInt31 | tl31 | User defined field 31 of type integer |
| UserDefinedFieldInt32 | tl32 | User defined field 32 of type integer |
| UserDefinedFieldInt33 | tl33 | User defined field 33 of type integer |
| UserDefinedFieldInt34 | tl34 | User defined field 34 of type integer |
| UserDefinedFieldInt35 | tl35 | User defined field 35 of type integer |
| UserDefinedFieldInt36 | tl36 | User defined field 36 of type integer |
| UserDefinedFieldInt37 | tl37 | User defined field 37 of type integer |
| UserDefinedFieldInt38 | tl38 | User defined field 38 of type integer |
| UserDefinedFieldInt39 | tl39 | User defined field 39 of type integer |
| UserDefinedFieldInt40 | tl40 | User defined field 40 of type integer |
| UserDefinedFieldInt41 | tl41 | User defined field 41 of type integer |
| UserDefinedFieldInt42 | tl42 | User defined field 42 of type integer |
| UserDefinedFieldInt43 | tl43 | User defined field 43 of type integer |
| UserDefinedFieldInt44 | tl44 | User defined field 44 of type integer |
| UserDefinedFieldInt45 | tl45 | User defined field 45 of type integer |
| UserDefinedFieldInt46 | tl46 | User defined field 46 of type integer |
| UserDefinedFieldInt47 | tl47 | User defined field 47 of type integer |
| UserDefinedFieldInt48 | tl48 | User defined field 48 of type integer |
| UserDefinedFieldInt49 | tl49 | User defined field 49 of type integer |
| UserDefinedFieldInt50 | tl50 | User defined field 50 of type integer |
| UserDefinedFieldInt51 | tl51 | User defined field 51 of type integer |
| UserDefinedFieldInt52 | tl52 | User defined field 52 of type integer |
| UserDefinedFieldInt53 | tl53 | User defined field 53 of type integer |
| UserDefinedFieldInt54 | tl54 | User defined field 54 of type integer |
| UserDefinedFieldInt55 | tl55 | User defined field 55 of type integer |
| UserDefinedFieldInt56 | tl56 | User defined field 56 of type integer |
| UserDefinedFieldInt57 | tl57 | User defined field 57 of type integer |
| UserDefinedFieldInt58 | tl58 | User defined field 58 of type integer |
| UserDefinedFieldInt59 | tl59 | User defined field 59 of type integer |
| UserDefinedFieldInt60 | tl60 | User defined field 60 of type integer |
| UserDefinedFieldString1 | ts01 | User defined field 1 of type string |
| UserDefinedFieldString2 | ts02 | User defined field 2 of type string |
| UserDefinedFieldString3 | ts03 | User defined field 3 of type string |
| UserDefinedFieldString4 | ts04 | User defined field 4 of type string |
| UserDefinedFieldString5 | ts05 | User defined field 5 of type string |
| UserDefinedFieldString6 | ts06 | User defined field 6 of type string |
| UserDefinedFieldString7 | ts07 | User defined field 7 of type string |
| UserDefinedFieldString8 | ts08 | User defined field 8 of type string |
| UserDefinedFieldString9 | ts09 | User defined field 9 of type string |
| UserDefinedFieldString10 | ts10 | User defined field 10 of type string |
| UserDefinedFieldString11 | ts11 | User defined field 11 of type string |
| UserDefinedFieldString12 | ts12 | User defined field 12 of type string |
| UserDefinedFieldString13 | ts13 | User defined field 13 of type string |
| UserDefinedFieldString14 | ts14 | User defined field 14 of type string |
| UserDefinedFieldString15 | ts15 | User defined field 15 of type string |
| UserDefinedFieldString16 | ts16 | User defined field 16 of type string |
| UserDefinedFieldString17 | ts17 | User defined field 17 of type string |
| UserDefinedFieldString18 | ts18 | User defined field 18 of type string |
| UserDefinedFieldString19 | ts19 | User defined field 19 of type string |
| UserDefinedFieldString20 | ts20 | User defined field 20 of type string |
| UserDefinedFieldString21 | ts21 | User defined field 21 of type string |
| UserDefinedFieldString22 | ts22 | User defined field 22 of type string |
| UserDefinedFieldString23 | ts23 | User defined field 23 of type string |
| UserDefinedFieldString24 | ts24 | User defined field 24 of type string |
| UserDefinedFieldString25 | ts25 | User defined field 25 of type string |
| UserDefinedFieldString26 | ts26 | User defined field 26 of type string |
| UserDefinedFieldString27 | ts27 | User defined field 27 of type string |
| UserDefinedFieldString28 | ts28 | User defined field 28 of type string |
| UserDefinedFieldString29 | ts29 | User defined field 29 of type string |
| UserDefinedFieldString30 | ts30 | User defined field 30 of type string |
| UserDefinedFieldString31 | ts31 | User defined field 31 of type string |
| UserDefinedFieldString32 | ts32 | User defined field 32 of type string |
| UserDefinedFieldString33 | ts33 | User defined field 33 of type string |
| UserDefinedFieldString34 | ts34 | User defined field 34 of type string |
| UserDefinedFieldString35 | ts35 | User defined field 35 of type string |
| UserDefinedFieldString36 | ts36 | User defined field 36 of type string |
| UserDefinedFieldString37 | ts37 | User defined field 37 of type string |
| UserDefinedFieldString38 | ts38 | User defined field 38 of type string |
| UserDefinedFieldString39 | ts39 | User defined field 39 of type string |
| UserDefinedFieldString40 | ts40 | User defined field 40 of type string |
| UserDefinedFieldString41 | ts41 | User defined field 41 of type string |
| UserDefinedFieldString42 | ts42 | User defined field 42 of type string |
| UserDefinedFieldString43 | ts43 | User defined field 43 of type string |
| UserDefinedFieldString44 | ts44 | User defined field 44 of type string |
| UserDefinedFieldString45 | ts45 | User defined field 45 of type string |
| UserDefinedFieldString46 | ts46 | User defined field 46 of type string |
| UserDefinedFieldString47 | ts47 | User defined field 47 of type string |
| UserDefinedFieldString48 | ts48 | User defined field 48 of type string |
| UserDefinedFieldString49 | ts49 | User defined field 49 of type string |
