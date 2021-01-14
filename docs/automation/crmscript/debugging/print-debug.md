---
title: Print debug
uid: crmscript_debug_print_debug
SortOrder: 30
---

## printDebug()

CRMScript has a global function for writing any string to a buffer.

The text will pop up in a separate window when loading a page. This means that `printDebug()` is  only for code resulting in a screen.

Here's how:

1. Enable debug: */bin/rms?action=debug*
2. Call `printDebug()` at appropriate places with suitable strings.
3. Run script.

The pop-up is not visible to regular users, but it will show up in your browser.

### Usage - custom screen

Call `printDebug()` in any of the scripts that will be run when creating the screen and its elements to display the text in a pop-up window.

### Usage - button-script

Button-scripts usually result in a redirect and not in a screen. Thus you will not get any messages from `printDebug()`.

However, you can use the following workaround to debug a button-script:

1. Temporarily deactivate the redirect.
2. You will be returned to the same screen, and now get the pop-up with any `printDebug()` messages in the buffer.
3. Enable the redirect when you are done.
