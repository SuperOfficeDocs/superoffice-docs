---
title: SOProtocol and web panels - mobile
uid: so_protocol_webpanel_mobile
description: SoProtocol and web panels - mobile
author: Bergfrid Dias
so.date: 01.14.2022
keywords: soprotocol
so.topic: reference
so.client: mobile 
---

# SOProtocol and web panels - mobile

SuperOffice Mobile has some SOProtocol support that you can use in web panels. However, for now, these are unofficial capabilities and can change at any time.

> [!NOTE]
> Cross-origin communication is not supported.

## Tasks

```html
<a href="superoffice://person?person_id=198&amp;call&amp;callnumber=93466021">Call person</a>
<a href="superoffice://contact?contact_id=2&amp;call&amp;callnumber=93466021">Call contact</a>
<a href="superoffice:appointment?appointment_id=24&amp;accept">Accept appointment</a>
<a href="superoffice:appointment?appointment_id=24&amp;reject">Reject appointment</a>
<a href="superoffice://diaryXxx?noscreen=$%&amp;/().,asdas%C3%B8kdas">Invalid link</a>
```

## Open an entity screen

```html
<a href="superoffice://person?person_id=198">Person</a>
<a href="superoffice://contact?contact_id=2">Contact</a>
<a href="superoffice://project?project_id=2">Project</a>
<a href="superoffice://appointment?appointment_id=2">Appointment</a>
<a href="superoffice://document?document_id=200">Document</a>
<a href="superoffice://sale?sale_id=123">Sale</a>
```

## Diary home

```html
<a href="superoffice://diaryhome">Diary (no subscreen)</a>
<a href="superoffice://diaryhome.checklist">Diary Checklist</a>
<a href="superoffice://diaryhome.upcoming">Diary Upcoming</a>
<a href="superoffice://diaryhome.week">Diary Week</a>
<a href="superoffice://diaryhome.day">Diary Day</a>
<a href="superoffice://diaryhome.month">Diary Month</a>
<a href="superoffice://diaryhome.year">Diary Year (invalid subscreen)</a>
```

## Contact home

```html
<a href="superoffice://contacthome">Contact</a>
<a href="superoffice://contacthome.search">Contact Search</a>
<a href="superoffice://contacthome.favorite">Contact Favorites</a>
<a href="superoffice://contacthome.colleague">Contact Colleagues</a>
<a href="superoffice://contacthome.projectmember">Contact Project</a>
<a href="superoffice://contacthome.selectionmember">Contact Selection</a>
```

## Project home

```html
<a href="superoffice://projecthome">Project</a>
<a href="superoffice://projecthome.search">Project Search</a>
<a href="superoffice://projecthome.favorite">Project Favorites</a>
<a href="superoffice://projecthome.myopen">Project My Open</a>
```

## Other home screens

```html
<a href="superoffice://salehome">Sale</a>
<a href="superoffice://imagehome">Image</a>
<a href="superoffice://invitations">Notifications</a>
```

## mailto

```html
<a href="mailto:pocket@superoffice.com">mailto:pocket@superoffice.com</a>
<a href="mailto:pocket@superoffice.com?cc=pocket2@superoffice.com">mailto:pocket@superoffice.com?cc=pocket2@superoffice.com</a>
<a href="mailto:pocket@superoffice.com&amp;cc=pocket2@superoffice.com">mailto:pocket@superoffice.com&amp;cc=pocket2@superoffice.com</a>
<a href="mailto:pocket@superoffice.com;pocket2@superoffice.com?subject=Custom%20mailto%20subject&amp;body=Hi,%0AIn%20this%20article%20you%20will%20find%20samples%20about%20how%20to%20use%20MailTo%20in%20HTML">mailto:pocket@superoffice.com;pocket2@superoffice.com?subject=Custom mailto subject&amp;body=Hi,%0AIn this article you will find samples about how to use MailTo in HTML</a>
```

<!-- Referenced links -->
