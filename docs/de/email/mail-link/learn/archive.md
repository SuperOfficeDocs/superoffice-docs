---
uid: help-de-mail-link-archive
title: E-Mails in SuperOffice archivieren
description: E-Mails in SuperOffice archivieren
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail-Link
topic: howto
language: de
---

# E-Mail archivieren

Wenn Sie in der Mail-Client-Symbolleiste auf die Schaltfläche **E-Mail archivieren** klicken, wird ein Menü mit Optionen zur Archivierung angezeigt.

> [!NOTE]
> Diese Schaltfläche wird auch im E-Mail-Fenster angezeigt, wenn Sie eine E-Mail öffnen, die Sie erhalten haben.

**Optionen:**

* [E-Mails nach Firmen/Personen archivieren][2]
* [E-Mails als Aktivitäten archivieren][1]
* [Anhänge archivieren][3]
* [E-Mails als Anfragen archivieren][4]

Für all die verschiedenen Archivierungsoptionen können Sie die Option **Warnen, wenn eine E-Mail größer als (in KB) ist** im [Bereich **Allgemeine Einstellungen**][5] des Dialogfelds **SuperOffice CRM-Optionen** auswählen. Wenn Sie also versuchen, eine E-Mail mit einem Anhang zu archivieren, der die angegebene Beschränkung überschreitet, werden Sie in einem Dialogfeld darüber informiert und gefragt, ob Sie sie trotzdem archivieren möchten.

## Unterschiede zwischen Outlook, Notes und SuperOffice CRM

Sie können E-Mails auf verschiedene Arten erstellen, d.h. [von Outlook][6] und [von SuperOffice CRM][8]. Wenn das Dialogfeld **Dokument** angezeigt wird, wird die E-Mail als SuperOffice-Dokument behandelt und archiviert. Wenn das Dialogfeld **Dokument** nicht angezeigt wird, wird die E-Mail anhand der Einstellungen im Dialogfeld **SuperOffice CRM-Optionen** archiviert.

Das Dialogfeld **Dokument** wird automatisch geöffnet, wenn Sie:

* Klicken Sie auf die Schaltfläche **Schreiben** in SuperOffice CRM.

* Klicken Sie auf Pfeil nach unten rechts neben der Schaltfläche **Neue E-Mail** in der Microsoft Outlook-Werkzeugleiste und wählen Sie eine der Vorlagen im Untermenü **SuperOffice-Mitteilung** aus.

Das Dialogfeld **Dokument** wird nicht automatisch geöffnet, wenn Sie:

* Die Schaltfläche **Neue E-Mail-Adresse** im E-Mail-Client anklicken. Die E-Mails werden jedoch archiviert, wenn die Option **E-Mail standardmäßig archivieren bei: vom E-Mail-Client erstellt** im Dialogfeld **SuperOffice CRM-Optionen** ausgewählt wurde.

* Klicken Sie auf die Schaltfläche **E-Mail** in SuperOffice CRM. Die E-Mails werden jedoch archiviert, wenn die Option **E-Mail standardmäßig archivieren bei: vom SuperOffice CRM erstellt** im Dialogfeld **SuperOffice CRM-Optionen** ausgewählt wurde.

* Wenn Sie eine E-Mail über die Schaltfläche **E-Mail** in SuperOffice CRM erstellen, können Sie standardmäßig eine vordefinierte E-Mail-Textvorlage verwenden, wenn die Option **SuperOffice-E-Mail-Text verwenden** im Dialogfeld **SuperOffice CRM-Optionen** ausgewählt wurde.

> [!NOTE]
> Dies gilt auch, wenn Sie in SuperOffice CRM auf eine E-Mail-Adresse klicken, eine E-Mail über die Bereichsregisterkarte **Personen** senden oder eine E-Mail über die Registerkarte **Aktivitäten** beantworten/weiterleiten.

## E-Mail wurde bereits in SuperOffice CRM archiviert

Wenn eine E-Mail von einem Benutzer archiviert wird, wird sie in SuperOffice CRM mit einer eindeutigen ID versehen. Wenn also das nächste Mal jemand versucht, dieselbe E-Mail zu archivieren, wird eine Warnung angezeigt, die darauf hinweist. Auf diese Weise können Duplikate in der Datenbank vermieden werden.

Wenn Sie eine bereits archivierte E-Mail öffnen, wird das ![Symbol][img1] der Schaltfläche **E-Mail archivieren** Grün mit einem weißen Häkchen angezeigt. Wenn Sie den Mauszeiger über die Schaltfläche bewegen, wird ein Infofeld angezeigt, aus der hervorgeht, wann und von wem die E-Mail archiviert wurde. Dies setzt voraus, dass Sie im Dialogfeld **SuperOffice CRM-Optionen** die **Option Beim Öffnen** einer E-Mail auf Duplikate prüfen ausgewählt haben.

## Zugehörige Inhalte

* [Archivoptionen][9]
* [Allgemeine Einstellungen][5]

<!-- Referenced links -->
[1]: archive-as-activity.md
[2]: archive-on-contact.md
[3]: archive-attachment.md
[4]: archive-as-request.md
[5]: settings/general.md
[9]: settings/default.md
[6]: create-in-outlook.md
[8]: create-in-superoffice.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/mail-link/already-archived.png
