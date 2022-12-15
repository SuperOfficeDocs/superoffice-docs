---
uid: help-en-time-zones
title: Time zones
description: Time zones
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: concept
language: en
---

# Time zones

SuperOffice CRM supports follow-ups in different time zones. Time zones are enabled if there is a list box for selecting a time zone at the bottom left of the diary (flag and country).

> [!NOTE]
> Use of time zones must be enabled per country in SuperOffice Settings and maintenance (under **Options** > **Time zones**). In addition, you can go to **Preferences** to show the time zone selector and set the default time zone. More help on how to set up time zones can also be found there.

## How do time zones work in SuperOffice CRM?

Time zone functionality can be useful if your organization has offices in several countries with different time zones and you need to plan meetings or telephone conferences with people in a country with a different time zone from yours. The appointment is then created in the time zone for the selected country.

For example, if your head office is in Norway and you want to hold a meeting with people in your Finnish and US subsidiaries, you can set up a meeting using Norwegian time and then check what time that is in Finland and the USA. In this way, you can avoid setting up an appointment that would take place, for example, late at night in the USA. For the people you invite to the appointment, the appointment is displayed using the time zone they have specified in their own SuperOffice CRM, even though you will have set up the appointment using Norwegian time.

This function supports summer time.

> [!NOTE]
> Appointments you created before you enabled time zones are kept in the default time zone for your SuperOffice database.

## How do you select time zones?

Time zones are displayed in a list box in the [Diary][1] and in the dialog for follow-ups. [!include[See Appointment dialog](../../includes/see-apt-dialog.md)] The default time zone for your SuperOffice database is displayed at the top, using this icon: ![icon][img1].

The time zone list is sorted by country. At the top of the list is the name of the selected country and its flag. You can get to the time zone list in several different ways:

* Use the field at the top with the selected country and flag as a search field. You can search in the time zone field in the same way as in the [FastSearcher][2] fields, and you can search for both countries and cities, assuming the city is included in the time zone data. If, for example, you don't know the time zone for Canberra, you can search for Canberra and bring up the relevant Australian time zone in the list.

* By searching for a number of hours to find the correct time zone. For example, if you enter +3, all time zones that are three hours after the time zone specified in SuperOffice CRM will be displayed.

> [!NOTE]
> Names of regions in the time zone selector will always be in English, while country names are dependent on the language settings in SuperOffice CRM. Don't forget this when searching for countries and regions.

## Handy hints on time zones

* If you hover the mouse pointer over the time zone list, a tooltip comes up, containing details of which cities (in the relevant country) are in the time zone you have selected.

* If you in the Diary hover the mouse pointer over an appointment created in a different time zone from the default for your SuperOffice database, a tooltip is displayed containing information about the time of the appointment in your time zone and in the time zone of the person who created it.

<!-- Referenced links -->
[1]: ../../diary/learn/index.md
[2]: ../../search-options/learn/using-fastsearcher.md

<!-- Referenced images -->
[img1]: ../../../media/icons/time-zone-local.bmp
