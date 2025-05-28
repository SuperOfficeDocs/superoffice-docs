---
uid: help-de-mailing-settings
title: Einstellungen für Kampagnen festlegen
description: Einstellungen für Kampagnen festlegen
keywords: Marketing, Einstellungen
author: SuperOffice RnD
date: 02.12.2024
version: 10
topic: reference
language: de
envir: onsite
audience: person
audience_tooltip: SuperOffice Marketing
---

# Einstellungen für Kampagnen festlegen

> [!NOTE]
> Diese Funktion ist ausschließlich für Benutzer mit ausreichenden Benutzerberechtigungen verfügbar.

In der Ansicht **Kampagnen** können Sie auf die Schaltfläche **Einstellungen** (unten rechts) klicken, um Einstellungen für E-Mail und SMS aufzurufen.

## Die Registerkarte Einstellungen

Für E-Mail-Kampagnen stehen die folgenden Einstellungen zur Verfügung:

* **Max. Anzahl von E-Mails, die über SMTP-Verbindung gesendet werden für alle gleichzeitigen Threads**: Hier stellen Sie die maximale Anzahl E-Mails ein, die an die nachfolgend eingestellten SMTP-Threads verbreitet werden. Beachten Sie, dass hier eine große Zahl eine hohe Auslastung Ihres E-Mail-Servers bedeuten kann. Beispiel:

    **Max. Anzahl E-Mails ...**: 100

    **SMTP-Threads**: 5

    Ist der Versand von 1000 E-Mails geplant, richtet SuperOffice 5 Prozesse (Threads) auf dem SMTP-Server ein. Jedem Prozess werden 20 E-Mails (100 E-Mails/5 Threads) in einer Warteschlange zugewiesen.

    Sobald ein Prozess abgeschlossen wurde, wird ein neuer Prozess gestartet, und weitere 20 E-Mails werden zugewiesen.

* **SMTP-Threads**: Hier können Sie die Anzahl der gleichzeitigen Hintergrundprozesse eingeben, mit denen die E-Mails der Kampagne gesendet werden sollen. Durch Erhöhen der Zahl können Sie einen höheren Durchsatz erzielen. Es erhöht sich jedoch auch die Last des Servers und des E-Mail-Servers.

* **Standardabsender**: Die Absenderadresse der Standard-E-Mail des Systems. Diese Adresse wird normalerweise durch die Adressen ersetzt, die für die Postfächer eingegeben wurden. Hierbei muss es sich um eine E-Mail-Adresse handeln, die in SuperOffice Service importiert wurde. Zum Beispiel, `support@company.com`.

[!include[List of fields for mailings](../../learn/includes/mailing-smtp-fields.md)]

## Die Registerkarte SMS

Für SMS-Kampagnen stehen die folgenden Einstellungen zur Verfügung:

[!include[Settings for mailings - SMS](../../learn/includes/mailing-settings-sms.md)]

## SMS-Einstellungen testen

Zum Testen der Einstellungen geben Sie eine Mobilfunknummer und etwas Text ein und klicken dann auf **Testnachricht senden**.

Informationen über zusätzliche Module finden Sie unter [SMS][1].

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/global-preferences/sms.md

<!-- Referenced images -->
