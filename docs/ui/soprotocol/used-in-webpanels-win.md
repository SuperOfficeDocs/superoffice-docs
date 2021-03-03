---
title: so_protocol_webpanel_win
description: SoProtocol and web panels - win
author:
so.date:
keywords:
so.topic: reference
---

# SOProtocol and web panels

## Go to web panel

Let's say we've added a [web panel][2] with window name *erpinfo* to the Contact card, To reference it:

> [!NOTE]
> Does not work for the SuperOffice web application!

`superoffice:contact.www.erpinfo?contact_id=2`

If we'd instead placed the web panel in the Contact archive, we must omit the *.www* sub-mode:

`superoffice:contact.erpinfo?contact_id=2`

## Open dialogs from links

Webpages shown in web panels can also use SOProtocol links. For example, to display the **Appointment* dialog:

```html
<a href="superoffice:contact.appointment">Show appointment dialog</a>
```

However, this link also reloads the page, showing a blank page in addition to the dialog.

To get rid of the blank page, we can use the **target** attribute on the link and a hidden **iframe** to put the result of the click outside the user's view. The `<iframe>` tag specifies an inline frame, which embeds another document within the current HTML document.

```html
<a href="superoffice:contact.appointment" target="hiddenframe">Show Appointment dialog</a>
<iframe name="hiddenframe" style="display:none"></iframe>
```

You can now click the link - the **Appointment** dialog appears, and the web page remains unchanged.

> [!TIP]
> You can also issue an SoProtocol from a web panel use the [CrossMessaging API][3].

<!-- Referenced links -->
[2]: ../web-panels.md
[3]: https://github.com/SuperOffice/DevNet/tree/master/CrossMessaging
