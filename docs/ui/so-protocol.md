---
title: so_protocol
description: SOProtocol
author:
so.date:
keywords:
so.topic:
---

# SOProtocol

**SOProtocol** is a standard for defining URL short-cuts to SuperOffice entities. It lets you control the user interface without scripting and send users directly to the entry in question.

SOProtocol URLs have a navigation part and a content part.

```html
superoffice:where.where...?what=id&what=id&...
```

For example, to go to the contact with contact_id=2:

```html
superoffice:contact.main?contact_id=2
```

> [!TIP]
> You can get a URL that reflects the current state of the application by selecting **Copy shortcut** either from the hamburger menu, the **Task** menu in dialogs for follow-ups and documents, or by right-clicking an item in a section tab,

For example:

```html
person.main.activityarchive?diaryowner_id=5&person_id=1&contact_id=1&appointment_id=90&sale_id=1&document_id=2
```

## Navigation points (where)

Entity-specific sub-modes are listed for the screen or dialog they apply to. Generic sub-modes are listed in the table.

* Company (contact)
  * Interest
  * PersonArchive
  * RelationArchive
  * ProjectArchive
  * ActivityArchive
* Contact (person)
  * Interest
* Diary
  * Day
  * Week
  * Month
  * ReferenceView
* Sale
* Project
  * MemberArchive
  * ActivityArchive
* Selection
  * Task
* Inbox (mail)
* Appointment (dialog)
* Document (dialog)
* Invitations (dialog)

| Sub-mode | Contact | Project | Person | Selection |
|:---------|:-------:|:-------:|:------:|:---------:|
| Main     | x       | x       | x      | x         |
| Udef     | x       | x       | x      |           |
| WWW      | x       | x       |        |           |
| Info     | x       | x       | x      |           |

### Examples

* To go to the contact screen, `superoffice:contact`

* To go to the *day* view of the diary: `superoffice:diary.day`

## Query strings (what)

The **query string** is what comes behind the question mark (?) in the URL. Separate the whats with an ampersand `&`.

You can use the primary keys to specify what to open:

* contact_id
* person_id
* appointment_id
* sale_id
* project_id
* selection_id
* document_id

For example, to go to sale 42:

```html
superoffice:sale?sale_id=42
```

To go to a specific company card, set the active archive, and open an appointment:

```html
superoffice:contact.main.activityarchive.appointment?contact_id=2&appointment_id=1
```

### Preserving context

It is good practice to add the serial number of the database ID to the URL to prevent users from getting lost when different databases are involved.

```html
db_id=12345
```

## Page control and cache

| Mode     | Description                              |
|:---------|:-----------------------------------------|
| Activate | Forces the application window to the top |
| Flush    | Forces refresh of all caches (Shift+F5)  |
| Refresh  | Forces refresh of all caches (F5)        |
| Reload   | Reloads selected caches                  |

### Examples

* To refresh the client: `superoffice:refresh?db_id=1010000006` or `superoffice:flush?db_id=1010000006`

* To bring the window to the front:

```html
superoffice:contact.personarchive.main.activate?db_id=98765&contact_id=5
```

## Using SOProtocol in CRMScript

In CRMScript, you can use `setNavigateTo()` and `getNavigateTo()` of the [EventData][1] object to work with SOProtocol URLs.

```crmscript
EventData ed = getEventData();
ed.setNavigateTo("soprotocol:sale.document?document_id=0");
```

## SOProtocol and web panels

### Go to web panel

Let's say we've added a [web panel][2] with window name *erpinfo* to the Contact card, To reference it:

```html
superoffice:contact.www.erpinfo?contact_id=2
```

If we'd instead placed the web panel in the Contact archive, we must omit the *.www* sub-mode:

```html
superoffice:contact.erpinfo?contact_id=2
```

### Open dialogs from links

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
[1]: eventdata.md
[2]: web-panels.md
[3]: https://github.com/SuperOffice/DevNet/tree/master/CrossMessaging
