---
uid: help-de-import-from-gmail
title: Aus Gmail importieren
description: Aus Gmail importieren
keywords: Einstellungen und Verwaltung, Importieren
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /de/admin/import/learn/import-from-gmail
language: de
---

# Aus Gmail importieren

[!include[Back up database before import](includes/caution-backup-before-import.md)]

## Firmen/Personen von Gmail importieren

1. [!include[Open Import](includes/open-import.md)]

2. Klicken Sie auf das ![Symbol][img2] Gmail unter **Importquelle auswählen**.

3. Gewähren Sie Zugriff. Das angezeigte Dialogfeld hängt davon ab, ob Sie bereits bei Gmail angemeldet sind

    * Wenn das Dialogfeld **Berechtigungsanfrage** angezeigt wird, sind Sie bereits bei Gmail angemeldet. Klicken Sie auf **Zugriff gewähren**.

    * Wenn das Dialogfeld **Google-Kontos**angezeigt wird, sind Sie noch nicht bei Gmail angemeldet. Geben Sie den Nutzernamen und das Passwort ein und melden Sie sich bei Gmail an. Klicken Sie auf **Zugriff gewähren**.
        Ihre Gmail-Firmen werden in Einstellungen und Verwaltung angezeigt.

    > [!NOTE]
    > Die Firmen von Gmail werden noch nicht in die Datenbank von SuperOffice importiert. SuperOffice lädt lediglich die Firmenliste aus Gmail hoch, damit Sie die Importeinstellungen festlegen können.

## Importeinstellungen anpassen

[!include[Adjust for Gmail/Outlook](includes/adjust-email-only.md)]

### Fehlerbehebung

[!include[Contacts without icons](includes/troubleshoot-import.md)]

## Import abschließen

[!include[Step: complete the import](includes/import-complete.md)]

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../media/icons/admin/import-gmail-small.png
