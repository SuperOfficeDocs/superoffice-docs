---
uid: zapier-crm-tips-datetime
title: Formatting date and time
description: Guide for formatting date and time
author: Philip Yates
so.date: 8.9.2023
keywords: Zapier
so.topic: howto
language: en
so.client: Zapier
---

# Formatting date and time

Dates and times in SuperOffice are in a standard ISO format 'yyyy-mm-ddThh:mm:ssZ' where the Z indicates the UTC time zone.

If this format does not suit you then you can use a Zapier Formatter helper step to change the value into something suitable. 

![Action/Search][img1]

For example a formatter can convert the appointment start date value into an American style  '06/19/2019' date, if that is what you need.

![Select Formatter by Zapier Action][img2]

To nudge a time, this [help section explains](https://help.zapier.com/hc/en-us/articles/8496275717261#adjusting-dates-and-times) the expressions you can use.

You can adjust a date value by appending a space and + or - the desired number of hours and minutes.

![Start Date & Time][img3]

[img1]:media/add-step.png
[img2]:media/select-formatter.png
[img3]:media/start-dt.png