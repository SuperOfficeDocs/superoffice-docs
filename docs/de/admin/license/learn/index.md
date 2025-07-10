---
uid: help-de-licenses
title: SuperOffice und Lizenzen
description: CRM und Lizenzen
keywords: Lizenz, Benutzerplan, gemessene Dienstleistung, Datenbankbesitzer, Registerkarte Status
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/admin/license/learn/screen/index
---

# SuperOffice und Lizenzen

Zum Einloggen bei SuperOffice CRM von einem Web-Client benötigen Sie Login-Rechte für SuperOffice CRM und einen Essential- oder Premium-Benutzerplan.

## Lizenzinformationen anzeigen

1. Gehen Sie unter Einstellungen und Verwaltung zur Ansicht Lizenzen.
1. Wählen Sie die Registerkarte **SuperOffice** aus.
1. Die Liste zeigt die Lizenzen, die Sie [erworben und aktiviert][1] haben. Klicken Sie auf einen Lizenznamen, um weitere Informationen darüber anzuzeigen.

[!include[Tip](includes/tip-user-licenses.md)]

## Die Ansicht Lizenzen

### Die Registerkarte SuperOffice

In der Registerkarte **SuperOffice** können Sie in der Ansicht Lizenzen die Lizenzinformationen für Ihre SuperOffice CRM-Version und die dazugehörigen Module anzeigen und aktualisieren.

> [!NOTE]
> Wenn ein Add-on eines Drittanbieters installiert ist, werden hier mehrere Registerkarten angezeigt.

#### Besitzerinformationen

Oben finden Sie den Firmennamen (Ihre Firma/Organisation) und die Seriennummer. Wenn die Lizenz über eine zeitliche Begrenzung verfügt, wird deren Ablaufdatum unter der Seriennummer angegeben.

Die Liste unten zeigt an, welche Lizenzen belegt und wie viele Lizenzen verfügbar sind. Klicken Sie auf einen Lizenznamen, um Informationen über eine Lizenz anzuzeigen.

#### Lizenzliste

### Registerkarte Status

Aktualisierte Informationen zum System werden auf der Registerkarte **Status** in der Ansicht Lizenzen angezeigt. Die Ansicht **Status** ist in die folgenden Hauptbereiche unterteilt:

#### Datenbank

Zeigt den bei der Installation festgelegten Datenbankbesitzer, die Seriennummer und den Datenbanktyp an. Außerdem wird angezeigt, ob es eine zentrale DB oder eine Satelliten-Datenbank ist. Sie können das nächste Ablaufdatum und den Namen des derzeit angemeldeten Benutzers sehen.

#### Gemessene Dienstleistungen

Klicken Sie auf diese Schaltfläche, um das Dashboard für Ihre gemessenen Dienstleistungen zu öffnen.

Gemessene Dienstleistungen werden in Rechnung gestellt, nachdem eine bestimmte Stufe/Anzahl überschritten wurde, wie zum Beispiel

* Belegter Speicherplatz
* Über Kampagnen gesendete E-Mails
* Anmeldungen beim Kundenzentrum
* Gestartete Chat-Sitzungen
* Formularübermittlungen

Administratoren können genau nachverfolgen, wie stark jede Dienstleistung pro Monat verwendet wird. Wenn Ihre Firma den Schwellenwert überschreitet, werden Ihnen diese Dienstleistungen automatisch mit Ihrer nächsten monatlichen Rechnung in Rechnung gestellt. Der Schwellenwert hängt von der Anzahl der Benutzer ab. Je mehr Benutzer Sie haben, desto höher ist der Schwellenwert.

#### Systembenachrichtigungen

Diese Liste zeigt Statusnachrichten vom System und hinzugefügte [Ereignisse][3] an. Meldungen über aktive Importe, SAINT- oder Volltextindizierung usw. sind ebenfalls enthalten. Wählen Sie eine Benachrichtigung in der Liste aus, um eine Beschreibung anzuzeigen. Sie können Ereignisse verfolgen, die im System aktiv sind.

Die Registerkarte **Systemereignisse** besteht aus zwei Bereichen:

* **Ereignisse**:
* **Beschreibung**: zeigt detaillierte Informationen über das aktuell unter **Ereignisse** ausgewählte Ereignis.

Unter **Systembenachrichtigungen** finden Sie folgende Spalten:

| Spalte | Beschreibung |
|---|---|
| Ereignis | Zeigt den Namen des Ereignisses an. |
| Status | Zeigt den Status des Ereignisses an. |
| Nachricht | Zeigt die Beschreibung des Ereignisses an. |
| Aktiviert | Zeigt an, wann das Ereignis gestartet wurde. |
| Aktiviert von | Zeigt an, wer das Ereignis initiierte (Benutzer-ID und Porträt). |
| Fertig gestellt | Zeigt an, wann das Ereignis voraussichtlich beendet ist. |
| Typ | Zeigt an, ob das Ereignis für das gesamte System gilt. |

## <a id="types"></a>Lizenztypen

### Systemlizenzen

| Lizenzen | Beschreibung |
|---|---|
| System | Sie legt fest, auf welche Systeme Sie zugreifen können. |
| SuperOffice Server | Erforderlich für die Anwendung von SuperOffice CRM. |
| Online Web Services | Erforderlich für den Zugriff auf SuperOffice CRM von einem Web-Client. |
| Sales Intelligence | Ermöglicht [SAINT-Statuskontrollen][2]. |
| Exchange Synchronizer | Ermöglicht die Verwendung von SuperOffice Synchronizer. |
| SuperOffice Expander Dienstleistung | Diese Lizenz ermöglicht u. a. anonymen und externen Benutzern die Nutzung von Funktionen über SuperOffice Audience oder über Anwendungen von Drittanbietern. |
| Kundenzentrum | Ermöglicht die Anwendung des Kundenzentrums. |
| Angebotsverwaltung des Vertriebs | Ermöglicht die Verwendung von Angeboten. |

### Standortlizenzen

Es gibt auch so genannte Standortlizenzen. Ein *Standort* in SuperOffice entspricht einer Datenbank oder Satelliten-Datenbank. Eine Standortlizenz gibt Folgendes an:

| Lizenzen | Beschreibung |
|---|---|
| Satellit | Die Anzahl der Satelliten-Datenbanken, die Ihr Unternehmen definieren kann. |
| Reporter Studio | Die maximale Anzahl von Standorten, an denen SuperOffice Reporter Studio verwendet werden kann. |
| Audience | Die maximale Anzahl an Standorten, an denen SuperOffice Audience verwendet werden kann. |

### Benutzerpläne

Schließlich gibt es noch Benutzerpläne für SuperOffice CRM, die für eine bestimmte Anzahl von Benutzern erworben werden. Dies betrifft u. a. folgende Produkte:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

Lesen Sie mehr über [SuperOffice-Benutzerpläne und Abonnements][6].

### Standortlizenzen und Benutzerlizenzen (Windows - Legacy)

Lizenzen für SuperOffice CRM für Windows (letzte Version [SuperOffice G8 8.5 R17][5]) werden für eine bestimmte Anzahl von Benutzern erworben.

Lesen Sie mehr über Lizenzen in [früheren Versionen von SuperOffice][7].

## Verwandte Themen

* [Lizenz kaufen und aktivieren][1]
* [Systemereignisse][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../../saint/learn/index.md
[3]: ../../learn/system-events.md
[5]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[6]: ../../../../en/admin/license/user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/DE/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm

<!-- Referenced images -->
