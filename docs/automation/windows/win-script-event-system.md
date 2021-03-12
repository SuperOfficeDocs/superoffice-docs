---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: win_script_event_system       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Win Script and Event system -  Aborting a Save sequence # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Conrad Weyns
so.date: 10.28.2019
keywords:
so.topic: article              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Win Script and Event system: Aborting a Save sequence

8.5 R07 should be out soon. You will then be able to abort a Save Model sequence on the Current system.

## From an internal script's On\*BeforeSave message like this example

```vb
Sub OnCurrentContactBeforeSave
  result = somessagebox( "Continue saving contact?", CurrentContact.Name, vbYesNo )
  If result = 3 Then
    Call Err.Raise(vbObjectError + 10, "", "")
    somessagebox "Should never get here"
  End If 
End Sub
```

## From an EventServer subscription like this c# example

```vb
public int CurrentContactBeforeSave()
{
  if ( CanSaveContact() );
    return 0;
  else
    return 999; // Some dummy error code > 0
}
```

## Validation

Probably too little too late but still...

Many of you are using VB Scripting to Validate - for good or bad. (Does not matter what we say, you will try and find a way).

Often this validation is very processor-heavy. Then things like keyboard input in Name fields start to crawl or worse.

Now you can use the `BeforeSave` events not only for setting fields but also as a singular validation point.

Invoke message boxes and/or use the `ValidationMessage` property to disable the **Save** button and we will abort the save sequence giving the user a chance to put things right and click **Save** again.

This works well for all main entities that are current.
