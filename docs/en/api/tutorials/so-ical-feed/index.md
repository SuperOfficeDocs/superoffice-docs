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

<!-- markdownlint-disable-file MD013 -->
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

```csharp
protected void LoginSubmit_ServerClick(object sender, EventArgs e)
{
  SoSession sesh = SoSession.Authenticate(Username.Value, Password.Value);
  if (sesh.IsOpen)
  {
    string guid = Guid.NewGuid().ToString();
    int id = sesh.Principal.AssociateId;
    AssociateRow assoc = AssociateRow.GetFromIdxAssociateId(id);
    int fkDevId = Util.GetFkDevice("SO-iCal");
    assoc.ForeignKeyHelper.Set( fkDevId, "iCal",  guid );
    assoc.ForeignKeyHelper.Save();
    sesh.Close();
    string url = string.Format("Result.aspx?associd={0}&guid={1}", id, guid );
    Response.Redirect( url );
  }
  else
  {
    Result.InnerText = "Unable to log in to SuperOffice as " + Username.Value;
  }
  catch(Exception)
  {
    Result.InnerText = "Unable to log in to SuperOffice as " + Username.Value;
  }
}
```

The `Util.GetFkDevice` is a helper that creates a foreign-key app and device record for us if necessary.

If the login is successful, we store the unique ID needed to log in and send the browser to the *Result.aspx* page.

## Step 3: Result page

The result page shows us the link that we can give to other systems for reading the calendar.

![Result page -screenshot][img3]

This page checks that the ID and GUID match. If they match, we construct the link to the iCal page.

We don't have the user's login info here, so we can't log in as the user. Instead, we log in as a system user (login info is read from the config file *AppSettings*).

```csharp
int associd = 0;
int.TryParse(Request.QueryString["associd"], out associd);
string guid = Request.QueryString["guid"];
string souser = ConfigurationSettings.AppSettings["SOUser"];
string sopass = ConfigurationSettings.AppSettings["SOPass"];

using (SoSession sesh = SoSession.Authenticate(souser, sopass))
{
  AssociateRow assocRow = AssociateRow.GetFromIdxAssociateId(associd);
  if (assocRow.AssociateId == associd)
  {
    int fkDevId = Util.GetFkDevice("SO-iCal");
    if (guid == assocRow.ForeignKeyHelper.Get(fkDevId, "iCal"))
    {
      string tmpUri = Request.Url.AbsoluteUri;
      tmpUri = tmpUri.Replace("Result.aspx", "iCal.aspx");
      ResultInfo.InnerHtml = "**Success!** You can add the following link to Google Calendar: <br>" + "<a href=\"" + tmpUri + "\">" + tmpUri + "</a><br>\n" + "<p>Note that old links you may have created will stop working. Only one link is valid at a time.";
    }
  }
}
```

The system user bypasses the sentry security restrictions and is therefore allowed to read and publish the user's private appointments. This is not so important here but is more important on the next page, the iCal Results.

## Step 4: iCal results

The iCal page does the same login check as the Result page, but it reads the user's follow-ups and outputs the iCal. The search limits the number of follow-ups to about 2 months worth, weighted towards future/planned follow-up.

[!code-csharp[CS](includes/ical-write-results.cs?range=1-5)]

To output the follow-ups, we need to set a few things in the header:

[!code-csharp[CS](includes/ical-write-results.cs?range=7-12)]

The response itself has a header and then a list of follow-up details.

### Content header

[!code-csharp[CS](includes/ical-write-results.cs?range=14-21)]

### Per-appointment output

[!code-csharp[CS](includes/ical-write-results.cs?range=23-68)]

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

## Step 5: Integrate external calendar events

The non-XML format shown in the previous step is what Outlook, Google, and Apple's calendar can use to integrate external calendar events.

### Outlook

Outlook can load the iCal feed using the **internet calendar** account setting.

1. Under the TOOLS menu, open ACCOUNT SETTINGS. A dialog appears.

2. Go to the INTERNET CALENDARS tab and add a NEW calendar.

    ![Outlook -screenshot][img4]

    ![Outlook -screenshot][img5]

3. Outlook will download the follow-up once you have pasted in the link to `ical.aspx?associd=123&guid=1234-4567…`

4. The calendar shows up in the calendar view in Outlook – you just need to mark the checkbox for the calendar you added.

    ![Outlook -screenshot][img6]

### Google Calendar

So if you have a Google Phone, you can now get your SuperOffice calendar to show up on the phone. To do this we go via the Google Calendar web page.

1. Log in to the `http://calendar.google.com/` website.

2. Click on the ADD menu under OTHER CALENDARS: ADD BY URL

    ![Google -screenshot][img7]

    A simple dialog box appears (similar to the one in Outlook)

    ![Google -screenshot][img8]

3. Paste the ical.aspx?associd=123&guid=1234-4567…  link in here.

4. Google will read the follow-ups and layer them on top of your calendar. You can change the name and whether the calendar is shared by editing the settings. The resulting calendar looks like this:

    ![Google -screenshot][img9]

These follow-ups will now also appear on your Android phone calendar if you have enabled calendar sync on your device

![Google -screenshot][img10]

### Desktop Gadget

But what if you don't want to turn on your phone to check your SuperOffice calendar? What if you just want to glance at the desktop and see where you are supposed to be?

The **Windows Live Calendar Gadget** is just what you need.

1. Download the latest gadget from `http://wlcalendargadget.codeplex.com/`

2. Install the gadget and then right-click the desktop and choose GADGETS.

    ![Windows Live Calendar Gadget -screenshot][img11]

3. Add the Windows Live Calendar Gadget. It will appear somewhere on the desktop.

4. Adjust the settings on the calendar. You have to paste the iCal link into the textbox at the top of the calendar gadget settings dialog.

    ![Windows Live Calendar Gadget -screenshot][img12]

5. Click OK and the gadget will load the follow-ups from the URL and display them under the week or month.

    ![Windows Live Calendar Gadget -screenshot][img13]

    ![Windows Live Calendar Gadget -screenshot][img14]

6. Click on a follow-up for the full description of it.

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
[img4]: media/image004.jpg
[img5]: media/image005.jpg
[img6]: media/image006.gif
[img7]: media/image007.gif
[img8]: media/image008.gif
[img9]: media/image009.gif
[img10]: media/image010.jpg
[img11]: media/image011.jpg
[img12]: media/image012.jpg
[img13]: media/image013.gif
[img14]: media/image014.gif
