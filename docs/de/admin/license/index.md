---
uid: help-de-licenses
title: SuperOffice und Lizenzen
description: CRM und Lizenzen
keywords: Lizenz, Benutzerplan, gemessene Dienstleistung, Datenbankbesitzer, Registerkarte Status
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
redirect_from: 
  - /de/admin/license/learn/screen/index
  - /de/admin/license/learn/index
---

# SuperOffice und Lizenzen

Zum Einloggen bei SuperOffice CRM von einem Web-Client benötigen Sie Login-Rechte für SuperOffice CRM und einen Essential- oder Premium-Benutzerplan.

## Lizenzinformationen anzeigen

1. Gehen Sie unter Einstellungen und Verwaltung zur Ansicht Lizenzen.
1. Wählen Sie die Registerkarte **SuperOffice** aus.
1. Die Liste zeigt die Lizenzen, die Sie [erworben und aktiviert][1] haben. Klicken Sie auf einen Lizenznamen, um weitere Informationen darüber anzuzeigen.

## Die Ansicht Lizenzen

### Die Registerkarte SuperOffice

In der Registerkarte **SuperOffice** können Sie in der Ansicht Lizenzen die Lizenzinformationen für Ihre SuperOffice CRM-Version und die dazugehörigen Module anzeigen und aktualisieren.

> [!NOTE]
> Wenn ein Add-on eines Drittanbieters installiert ist, werden hier mehrere Registerkarten angezeigt.

#### Besitzerinformationen

Oben finden Sie den Firmennamen (Ihre Firma/Organisation) und die Seriennummer. Wenn die Lizenz über eine zeitliche Begrenzung verfügt, wird deren Ablaufdatum unter der Seriennummer angegeben.

#### Lizenzliste

Die Liste unten zeigt an, welche Lizenzen belegt und wie viele Lizenzen verfügbar sind. Klicken Sie auf einen Lizenznamen, um Informationen über eine Lizenz anzuzeigen.

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

### Standortlizenzen und Benutzerlizenzen (Windows - Legacy)

Lizenzen für SuperOffice CRM für Windows (letzte Version [SuperOffice G8 8.5 R17][6]) werden für eine bestimmte Anzahl von Benutzern erworben.

## <a id="dev"></a>Hinter den Kulissen – das Lizenzsystem

Das Lizenzsystem verfügt über eigene Datenbanktabellen:

* [ModuleOwner][11] – ein Lizenzanbieter
  * In der Regel nur eine Zeile (SuperOffice).
  * Enthält globale Ablaufdaten.

* [ModuleLicense][12] – eine Zeile pro Lizenz
  * Es gibt mehr Lizenzen, als im GUI sichtbar sind – einige sind ausgeblendet.
  * Verschiedene Typen: System, Standort, Benutzer; ein-/ausschaltbar oder mit definierter Anzahl.
  * Sichtbare Lizenzen (wie Benutzerpläne) werden in der Admin-Oberfläche angezeigt. Benutzerpläne haben `ExtraFlags = 1`.
  * Versteckte Lizenzen (z. B. **user**-Anmeldung oder **web**-Clientlizenz) sind nicht sichtbar, werden aber im Code geprüft.

| Lizenztyp | ModuleLicense.Type | Beschreibung |
|---|---|---|
| **Systemlizenzen** | 1 | Definieren, welche Funktionen systemweit verfügbar sind. <br />Beispiel: Die **saint**-Lizenz ist vorhanden, wenn Sales Intelligence aktiviert ist. Diese Lizenz ist verborgen (nicht auf der Preisliste) und wird implizit aktiviert. Der SuperOffice-Client prüft dies und aktiviert SAINT-Funktionen entsprechend. |
| **Standortlizenzen** | 2 | Heute kaum noch verwendet. Ursprünglich für Satellitenlösungen genutzt, bei denen Lizenzen standortbasiert vergeben wurden. |
| **Benutzerlizenzen** | 3 | Lizenzen, die einzelnen Benutzern zugewiesen werden. Die Anzahl der Zuweisungen darf die verfügbare Anzahl nicht überschreiten. <br />Einige Benutzerlizenzen sind ausgeblendet, um die Benutzeroberfläche zu vereinfachen. Diese werden über Benutzerpläne aktiviert. <br />Benutzerpläne haben `ModuleLicense.ExtraFlags = 1` und definieren implizite Lizenzen im Feld `ExtraInfo`, z. B.:<br>`"set=user,web,chat-cal"` weist automatisch die Lizenzen **user**, **web** und **chat-cal** zu. |

### Zuweisung von Benutzerlizenzen

[LicenseAssocLink][13] – weist eine bestimmte `moduleLicense`-Zeile einem bestimmten Benutzer zu. So wird „Max“ Benutzer und Windows-Client-Benutzer – das ergibt zwei Einträge.

Die Summe der zugewiesenen Lizenzen darf den in `moduleLicense` definierten Wert nicht überschreiten. Ein neues Lizenzpaket von SuperLicense wird abgelehnt, wenn bereits zu viele Lizenzen vergeben wurden.

### Lizenzsignierung

Lizenzen werden mit öffentlichen/privaten Schlüsseln signiert.

Der private Schlüssel ist streng geschützt. Ohne ihn kann kein funktionierender Lizenzcode-Generator erstellt werden.

Jede `moduleLicense`-Zeile wird signiert und alle Einträge werden mit einem Hash versehen, um Manipulationen zu erschweren.

**Zusammenfassung:** Wenn du sie änderst, funktionieren sie nicht mehr. Nur SoAdmin und NetServer können sie bearbeiten.
Hacker können DLLs manipulieren, aber keinen funktionierenden Keycode-Generator für unmodifizierten Code erstellen.

### Benutzer zählen

Es gibt zwei Ansätze:

#### 1: Lizenz abrufen und Anzahl user/web-Lizenzen auslesen

Benutzer benötigen sowohl **user**- als auch **web**-Lizenzen, um sich bei SuperOffice Web anzumelden. Diese Zahl ist die Obergrenze, nicht die Anzahl der tatsächlich verwendeten Lizenzen.

Manche Kunden verfügen über viele Lizenzen, weil sie per Nutzung zahlen (SCIM). Zähle in solchen Fällen die aktiven Benutzer – nicht die verfügbaren Lizenzen.

#### 2: Lizenz abrufen und Anzahl aktiver ExtraFlags = 1-Lizenzen summieren

Benutzerpläne sind das, wofür der Kunde bezahlt. Sie enthalten mehrere implizite, versteckte Lizenzen.

Dasselbe gilt bei SCIM: Zähle die genutzten Benutzerpläne, nicht die Gesamtanzahl.

## Verwandte Inhalte

* [SuperOffice-Benutzerpläne und Abonnements][4]
* [Lizenz kaufen und aktivieren][1]
* [Lizenzen in früheren Versionen von SuperOffice][7]
* [Systemereignisse][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: ../onsite/add-system-events.md
[4]: user-plans.md
[6]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm
[11]: ../../database/tables/ModuleOwner.md
[12]: ../../database/tables/ModuleLicense.md
[13]: ../../database/tables/LicenseAssocLink.md
