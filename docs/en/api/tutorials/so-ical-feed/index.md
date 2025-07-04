---
uid: tutorial-so-ical-feed
title: Tutorial - SuperOffice iCal Feed
description: In this tutorial, you'll learn how to build a simple website that lets you log in to SuperOffice and get a unique URL that you can use to read your calendar without logging in each time.
keywords: iCal feed
date: 03.22.2022
version: 10
content_type: tutorial
language: en
redirect_from: /en/diary/tutorials/so-ical-feed/index
---

# Tutorial - SuperOffice iCal Feed

## Step 1: Introduction

Having calendar data in SuperOffice is nice, but there are lots of other places that your calendar shows up. Your phone has a calendar, and while SuperOffice Pocket is nice, it may not be available on your type of phone, or you may want to display the calendar on your desktop using a calendar widget.

![Calendar -screenshot][img1]

The iCal standard is a way to publish calendar data on the internet. This standard lets us publish your calendar in a way that lets Apple, Google, and others read your appointments.

> [!CAUTION]
> The unique URL should not be easy to guess so that others cannot access your calendar without your permission.

### Security considerations

To avoid sending the username + password around the web, we will instead use good old **security by obscurity**. A better name for this is a *nonce* or a *cookie*. If you know the secret word, you are allowed in. If you don't know the right word, you don't get anything.

We can't rely on user input because other systems on the internet will be accessing the calendar on our behalf. We are not going to be around to type in the username + password every time Google wants to check our calendar.

Instead, we will use a system user to read the appointments - this avoids relying on a username + password coded into the URL.

To avoid giving everyone access to your calendar, we use a **unique random identifier** (a GUID) to identify you. This ID can be used to check that the request came from someone who knows the GUID (is allowed to read the calendar). So the GUID is a proxy for the username + password, with the added benefit of not expiring (like a session ticket tends to do) and not changing, even if the user's password changes.

So protect the iCal GUID like it was your password, and you'll be OK.

As an added precaution, we set up the GUID system so that only one GUID is valid at a time. If you log in again, we generate a new GUID and overwrite the old one, so that old logins no longer work.

So if someone steals your iCal link, just make a new one and the old one will stop working.

## Step 2: Logging in

Our website will start with a simple web form: Username and Password.

![Log in dialog -screenshot][img2]

We will take this and log in to NetServer. If the login is successful, we generate a random GUID and store it as a foreign-key on the user's associate record.

[!code-csharp[CS](includes/ical-login.cs)]

The `Util.GetFkDevice` is a helper that creates a foreign-key app and device record for us if necessary.

If the login is successful, we store the unique ID needed to log in and send the browser to the *Result.aspx* page.

## Step 3: Result page

The result page shows us the link that we can give to other systems for reading the calendar.

![Result page -screenshot][img3]

This page checks that the ID and GUID match. If they match, we construct the link to the iCal page.

We don't have the user's login info here, so we can't log in as the user. Instead, we log in as a system user (login info is read from the config file *AppSettings*).

[!code-csharp[CS](includes/ical-result-aspx.cs)]

The system user bypasses the sentry security restrictions and is therefore allowed to read and publish the user's private appointments. This is not so important here but is more important on the next page, the iCal Results.

## Step 4: iCal results

[!include[Content: iCal results](includes/steps/ical-results.md)]

## Step 5: Integrate external calendar events

[!include[Content: integrating external calendar events](includes/steps/integrate.md)]

## Step 6: Summary

You have now learned how to build a simple website that lets you log in to SuperOffice and get a unique URL that you can use to read your calendar without logging in each time.

* Log in
* Result page
* Step Three
* iCal Results
* Integrate external calendar events

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image001.gif
[img2]: media/image002.gif
[img3]: media/image003.gif
