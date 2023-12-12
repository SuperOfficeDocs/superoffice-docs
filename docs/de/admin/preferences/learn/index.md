---
uid: help-de-preferences
title: Voreinstellungen
description: "Administratoren können Einstellungen für verschiedene Funktionen im System für bestimmte Benutzer, Benutzergruppen oder für das gesamte SuperOffice CRM festlegen (Globale Einstellungen)."
author: Bergfrid Dias
so.date: 03.21.2023
keywords: Einstellungen, Einstellungen
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Voreinstellungen

In der Ansicht Einstellungen können Sie Einstellungen für das gesamte System (global), eine Datenbank, eine Benutzergruppe oder einen einzelnen Benutzer festlegen. Einstellungen, die nur auf globaler (System) Ebene vorgenommen werden können, befinden sich in der Registerkarte **[Globale Einstellungen][1]**.

Im Menü [Individuelle Einstellungen][4] in der oberen Leiste in **Persönliche Einstellungen** > **Einstellungen** können Benutzer die Optionen für die einzelnen Einstellungen bearbeitet werden. Die für den Benutzer verfügbaren Einstellungen hängen von den Einstellungen in Einstellungen und Verwaltung ab.

Zudem können Sie Videokonferenzen auf der Registerkarte [Videokonferenzen][8] und die Dokumentbibliothek auf der Registerkarte [Dokumentbibliothek][9] konfigurieren.

## <a id="levels" />Ebenen für Einstellungsoptionen

Sie können Einstellungsoptionen für vier verschiedene Ebenen festlegen:

| Ebene | Beschreibung |
|---|---|
| System | Globale Einstellungen für alle Benutzer im System, einschließlich aller Satelliten, Gruppen und Einzelbenutzer |
| Datenbank | Einstellungen, die nur für eine bestimmte Datenbank und alle mit dieser Datenbank verbundenen Gruppen und Benutzer gelten |
| Gruppe | Einstellungen für alle Benutzer in einer bestimmten Gruppe |
| Benutzer | Verknüpfte Einstellungen mit jedem individuellen Benutzer. |

Sie können verschiedene Werte für verschiedene Ebenen festlegen. Legen Sie beispielsweise eine Option für einen Benutzer und eine andere Option für die Benutzergruppe fest, zu der die Person gehört. Die unterste Ebene gilt immer.

> [!NOTE]
> Es stehen nicht alle Ebenen für alle Einstellungen zur Verfügung. Wenn eine oder mehrere Optionen deaktiviert sind, können Sie diese nicht für die Einstellung auswählen.

Sie können im Feld **Aktive Einstellungen** gemäß der betreffenden Stufe festlegen, welche Optionen in der Liste angezeigt werden soll. Welche Ebenen angezeigt werden, hängt davon ab, welche Ebenen Sie am unteren Rand des Feldes aktivieren. Sie können mit den Kontrollkästchen festlegen, dass alle oder nur eine oder zwei Ebenen angezeigt werden.

> [!NOTE]
> Die Optionen für die Systemebene werden immer angezeigt.

## <a id="global" />Globale Einstellungen (für das gesamte System)

Manche [Einstellungen][1] können nur global vorgenommen werden:

* Statistik
* Funktionen
* E-Mail
* Gruppierte Listen
* Marketing
* Mobile CRM
* Verkauf
* Benutzereinstellungen für SuperOffice Service
* System
* SMS-Konfiguration
* Richtlinie für Customer Centre-Passwörter

### Globale Einstellungen ändern

Gehen Sie zum Bearbeiten dieser Einstellungen auf das ![Symbol][img1] **Einstellungen** und wählen die Registerkarte **Globale Einstellungen** aus.

* Die verschiedenen Einstellungen sind in Bereiche unterteilt.
* Zeigen Sie mit dem Mauszeiger auf eine Einstellung, um zusätzliche Informationen anzuzeigen.
* Klicken Sie auf **Speichern**, um die Änderungen zu implementieren.

## <a id="preferences-tab" />Registerkarte Einstellungen

Auf der Registerkarte **Einstellungen** können Sie Einstellungen für verschiedene Komponenten von SuperOffice CRM festlegen, wie beispielsweise die Anzahl der Objekte, die in der Verlaufsliste angezeigt werden, den Standardtyp bei neuem Besprechungen sowie die Standardwährung in der Ansicht Verkauf.

Oben in der Registerkarte **Einstellungen** können Sie die gewünschte Einstellungsgruppe auswählen. Der Rest der Registerkarte **Einstellungen** ist in drei Hauptabschnitte unterteilt: eine Liste aller Einstellungen, ein Beschreibungsfeld, in dem die Beschreibung der aktuell ausgewählten Einstellung erläutert wird, und ein Feld, in dem die für diese Einstellung festgelegte Einstellungen angezeigt werden.

### Liste der Einstellungen

Auf der linken Seite finden Sie die Liste **Einstellungen**, die alle für die aktive Gruppe definierten Einstellungen enthält.

**Einstellungsgruppen:**

* Kontaktperson
* Standardwerte
* Kalender
* E-Mail
* Dialogfeld Filter
* Volltextsuche
* Funktionen
* Gruppierte Listen
* In-App-Kommunikation
* Marketing
* Benachrichtigungen per E-Mail + Popup + SMS
* Anfrage
* Verkauf
* Sortierung
* System
* QuickInfo
* Grafische Effekte
* Webserver
* Web Services

> [!NOTE]
> Einstellungen mit aktiven individuellen Einstellungen werden in Fettschrift angezeigt.

### Aktive Einstellungen

Das Feld **Aktive Einstellungen** zeigt die festgelegten Einstellungen für die aktuell ausgewählte Voreinstellung in der Liste **Einstellungen** und die jeweiligen Ebenen und Werte. Hier können Sie vorhandene Einstellungen bearbeiten und löschen sowie neue hinzufügen.

Das Feld besteht aus drei Spalten:

| Spalte | Beschreibung |
|---|---|
| Wer | Zeigt an, für wen oder was die Einstellung gilt (den Namen des Systems, der Datenbank, der Gruppe oder des Benutzers). Wenn es sich hier um einen individuellen Benutzer handelt, wird eine QuickInfo zu diesem Benutzer angezeigt, wenn Sie den Mauszeiger über den Initialen des Benutzers positionieren. |
| Ebene | Zeigt an, auf welcher [Stufe die Einstellung zutrifft](#levels) (System, Datenbank, Gruppe oder Benutzer). |
| Wert | Zeigt den für die Einstellung festgelegten Wert an. |

Der Inhalt dieser Spalten wird im Dialogfeld **Einstellung** festgelegt. [Wie man Einstellungsoptionen hinzufügt][3].

Sie können die Zeilen in den Spalten sortieren, indem Sie auf die einzelnen Spaltenüberschriften klicken. Klicken Sie einmal auf den Spaltenüberschrift, wenn Sie den Inhalt in umgekehrter Reihenfolge sortieren möchten.

<!-- Referenced links -->
[1]: global-preferences/system.md
[3]: update-preferences.md
[4]: update-preferences.md#personal
[8]: video-meetings/index.md
[9]: document-library/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-preferences-active.png
