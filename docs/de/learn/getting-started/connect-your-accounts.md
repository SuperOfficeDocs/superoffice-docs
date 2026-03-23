---
uid: help-de-connect-your-accounts
title: Konten verbinden
description: So verwenden Sie den Assistenten Benutzereinrichtung, um Ihr E-Mail-Konto und Ihre Dokumentenverwaltung mit SuperOffice CRM zu verbinden.
keywords: Benutzereinrichtung, E-Mail-Verbindung, Dokumentenverwaltung, WebTools, E-Mail verbinden, E-Mail-Konto, Assistent, persönliche Einstellungen
author: digitaldiina
date: 03.17.2026
version: 11.11
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Konten verbinden

*Verfügbar für neue Kunden ab 11.11, für alle Kunden ab 11.13.*

Als neuer Benutzer oder beim Einrichten eines neuen Computers sollten Sie Ihr E-Mail-Konto und Ihre Dokumentenverwaltung mit SuperOffice verbinden. Dies ermöglicht Ihnen:

* E-Mails zu senden und ausgehende Nachrichten in SuperOffice automatisch zu archivieren, sodass alle Kundenkommunikation für Ihre Kollegen verfügbar ist.
* Besprechungseinladungen an externe Empfänger zu senden und Einladungen von anderen zu empfangen.
* Dokumente direkt aus SuperOffice zu erstellen, öffnen und bearbeiten.

> [!TIP]
> Wenn Ihre Organisation Microsoft Entra ID verwendet, erkennt und verbindet SuperOffice Ihre Konten automatisch. Sie müssen den Assistenten nicht manuell durchlaufen.

## Den Assistenten öffnen

1. Klicken Sie auf <i class="ph ph-user-circle" aria-label="Persönliche Einstellungen"></i> **Persönliche Einstellungen** oben rechts.
1. Wählen Sie **Benutzereinrichtung**.

Der Assistent führt Sie durch drei Schritte.

## Schritt 1: Übersicht

Der erste Bildschirm fasst zusammen, womit der Assistent Ihnen helfen wird. Klicken Sie auf **Weiter**, um fortzufahren.

![SuperOffice Benutzereinrichtung - Übersicht über den ersten Bildschirm des Assistenten -screenshot][img1]

## Schritt 2: E-Mail-Konto verbinden

Klicken Sie auf **Verbinden**, und folgen Sie den Aufforderungen zur Validierung Ihrer Anmeldedaten.

![SuperOffice Benutzereinrichtung - E-Mail-Konto verbinden -screenshot][img2]

Durch die Verbindung Ihres E-Mail-Kontos können Sie E-Mails aus SuperOffice senden und ausgehende Nachrichten automatisch archivieren. Sie können auch Besprechungseinladungen senden und annehmen.

> [!NOTE]
> Um mit **eingehenden** E-Mails zu arbeiten und SuperOffice-Funktionen direkt in Ihrem E-Mail-Client nutzen zu können, installieren Sie nach Abschluss des Assistenten [SuperOffice für Outlook][3] (Microsoft 365) oder [SuperOffice Gmail Link][4] (Google Workspace).

## Schritt 3: Dokumentenverwaltung verbinden

Ihre Dokumentenverwaltung steuert, wie Sie Dokumente in SuperOffice erstellen, öffnen und bearbeiten.

Klicken Sie auf **WebTools herunterladen**, führen Sie das Installationsprogramm aus, und folgen Sie den Anweisungen auf dem Bildschirm. WebTools verbindet Ihren SuperOffice-Mandanten mit Ihren lokalen Office-Anwendungen.

![SuperOffice Benutzereinrichtung - WebTools für die Dokumentenverwaltung herunterladen -screenshot][img3]

> [!NOTE]
> Das Installationsprogramm wird automatisch für Ihr Betriebssystem ausgewählt. Wenn Sie WebTools direkt vom SuperOffice-Download-Service herunterladen, wählen Sie das richtige Installationsprogramm für Ihr Betriebssystem (Windows oder macOS) und Ihre Version.

### Weitere Optionen für die Dokumentenverwaltung

WebTools mit der SuperOffice-Dokumentenbibliothek ist die Standardeinstellung. Ihr Administrator hat möglicherweise eine andere Option konfiguriert:

| Option | Erfordert |
|---|---|
| SuperOffice-Dokumentenbibliothek (WebTools) | — |
| Microsoft 365 / SharePoint | Microsoft 365-Abonnement + [Administratoreinrichtung][5] |
| Google Workspace | Google Workspace-Abonnement + [Administratoreinrichtung][6] |

* **Microsoft 365 / SharePoint:** Speichert Dokumente in SharePoint Online. Sie können sie in SuperOffice CRM oder in SharePoint öffnen und über einen SharePoint-Link mit Personen teilen, die SuperOffice CRM nicht verwenden.

* **Google Workspace:** Speichert Dokumente in Google Workspace. Sie können Dokumente von jedem Computer aus öffnen, bearbeiten und speichern.

## Kalender synchronisieren

Die Kalendersynchronisierung ist nicht Teil des Assistenten. Wenn Sie Termine und Folgeaufgaben zwischen SuperOffice und Ihrem Outlook- oder Google-Kalender synchronisieren möchten, richten Sie [Synchronizer für SuperOffice][8] ein (verfügbar im App Store).

## Verwandte Inhalte

* [E-Mail, Dokumente und Kalender verbinden (Version 11.10 und früher)][1]
* [SuperOffice Inbox einrichten][2]
* [SuperOffice für Outlook installieren][3]
* [SuperOffice Gmail Link installieren][4]
* [WebTools installieren][7]

<!-- Referenced links -->
[1]: connect-email-doc/index.md
[2]: ../../email/inbox/learn/setup.md
[3]: ../../../../integrations/superoffice-for-outlook/index.md
[4]: ../../../../integrations/gmail-link/index.md
[5]: ../../../../integrations/sharepoint-documents/set-up.md
[6]: ../../../../integrations/g-suite/index.md
[7]: ../../../../integrations/webtools/install.md
[8]: https://appstore.superoffice.com/infobridge-software-b-v-/synchronizer-for-superoffice

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/superoffice-user-setup-1.png
[img2]: ../../../media/loc/en/learn/superoffice-user-setup-2-connect-email.png
[img3]: ../../../media/loc/en/learn/superoffice-user-setup-3-webtools.png
