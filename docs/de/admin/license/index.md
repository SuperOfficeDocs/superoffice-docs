---
uid: help-de-licenses
title: SuperOffice und Lizenzen
description: CRM und Lizenzen
keywords: Lizenz, Benutzerplan, gemessene Dienstleistung, Datenbankbesitzer, Registerkarte Status
author: digitaldiina, xt1
date: 05.04.2026
version: 11.13
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
tier: starter
language: de
redirect_from:
  - /de/admin/license/learn/screen/index
  - /de/admin/license/learn/index
  - /de/learn/administration
---

# SuperOffice und Lizenzen

Zum Einloggen bei SuperOffice CRM von einem Web-Client benötigen Sie Login-Rechte für SuperOffice CRM und einen Essential- oder Premium-Benutzerplan.

## Lizenzinformationen anzeigen

1. Gehen Sie unter Einstellungen und Verwaltung zur Ansicht Lizenzen.
1. Wählen Sie die Registerkarte **SuperOffice** aus.
1. Die Liste zeigt die Lizenzen, die Sie [erworben und aktiviert][1] haben. Klicken Sie auf einen Lizenznamen, um weitere Informationen darüber anzuzeigen.

## Die Ansicht Lizenzen

### Die Registerkarte SuperOffice

Die Registerkarte **SuperOffice** zeigt Lizenzinformationen für Ihr SuperOffice-Abonnement an.

<!-- markdownlint-disable-file MD051 -->
#### [Modulbasierte Abonnements](#tab/module-based)

![SUPEROFFICE tab showing system licences and user licences for a module-based subscription -screenshot][img1]

#### [CRM Suite](#tab/crm-suite)

![SUPEROFFICE tab showing system licences and Core user licences for a CRM Suite subscription -screenshot][img3]

***

> [!NOTE]
> Wenn ein Add-on eines Drittanbieters installiert ist, werden hier mehrere Registerkarten angezeigt.

#### Besitzerinformationen

Oben finden Sie den Firmennamen (Ihre Firma/Organisation) und die Seriennummer. Wenn die Lizenz über eine zeitliche Begrenzung verfügt, wird deren Ablaufdatum unter der Seriennummer angegeben.

#### Lizenzliste

Die Liste unten zeigt an, welche Lizenzen belegt und wie viele Lizenzen verfügbar sind.

### Registerkarte Status

Aktualisierte Informationen zum System werden auf der Registerkarte **Status** in der Ansicht Lizenzen angezeigt.

<!-- markdownlint-disable-file MD051 -->
#### [Modulbasierte Abonnements](#tab/module-based-status)

![Status tab showing database information and Metered services button for a module-based subscription -screenshot][img2]

#### [CRM Suite](#tab/crm-suite-status)

![Status tab showing a plan limit warning with an Upgrade button for a CRM Suite subscription -screenshot][img4]

***

Die Ansicht **Status** ist in die folgenden Hauptbereiche unterteilt:

#### Datenbank

Zeigt den bei der Installation festgelegten Datenbankbesitzer, die Seriennummer, das Abonnement und den Datenbanktyp an. Sie können das nächste Ablaufdatum und den Namen des derzeit angemeldeten Benutzers sehen.

Wenn Ihre Organisation über ein **SuperOffice CRM Suite**-Abonnement verfügt, werden im Abschnitt **Datenbank** auch folgende Informationen angezeigt:

* **Plan:** der im Abonnement enthaltene Plan, zum Beispiel *Core*
* **Einschränkungen:** Ihre aktuelle Nutzung gegenüber den Plangrenzen, zum Beispiel *1 von 100 aktiven Projekten*

Plangrenzen verhindern, dass Ihre Organisation die in Ihrem aktuellen Plan enthaltene Kapazität überschreitet. Der Indikator **Einschränkungen** zeigt, wie nah Sie an einer Grenze sind:

| Nutzung | Indikator | Bedeutung |
|---|---|---|
| Unter 85 % | Anzahl in Schwarz angezeigt, zum Beispiel *1 von 100 aktiven Projekten* | Normal – keine Aktion erforderlich |
| 85 % oder mehr | <i class="ph ph-warning" aria-label="Warning"></i> Anzahl in Gelb angezeigt | Annäherung an die Grenze |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Anzahl in Rot angezeigt | Grenze erreicht – die Funktion ist eingeschränkt |

Wählen Sie den Indikator aus, um die Seite [SuperOffice CRM Suite][16] für weitere Informationen zu öffnen.

Wenn Sie Systemadministrator sind, erscheint neben dem Warn- oder Stoppindikator die Schaltfläche **Upgrade**. Wählen Sie sie aus, um ein Kontaktformular zu öffnen und mehr Kapazität oder ein Plan-Upgrade anzufordern.

#### Gemessene Dienstleistungen

> [!NOTE]
> Nur bei modulbasierten Abonnements verfügbar. Bei CRM Suite-Abonnements öffnet die Schaltfläche **Meine Apps** den SuperOffice App Store.

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

* [CRM Suite][16]
* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

## Verwandte Inhalte

* [SuperOffice-Benutzerpläne und Abonnements][4]
* [Lizenz kaufen und aktivieren][1]
* [Lizenzen in früheren Versionen von SuperOffice][7]
* [Systemereignisse][3]

<!-- Referenced links -->
[16]: crm-suite.md
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: https://help.superoffice.com/docs/11/de/admin/onsite/add-system-event.html
[4]: user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/licenses-online-superoffice-tab.png
[img2]: ../../../media/loc/en/admin/licenses-online-status-tab.png
[img3]: ../../../media/loc/en/admin/licenses-suite-superoffice-tab.png
[img4]: ../../../media/loc/en/admin/licenses-suite-core-with-upgrade.png
