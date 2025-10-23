---
uid: help-de-users
title: Benutzer
description: Lernen Sie, wie man neue Benutzer hinzufügt, die richtigen Benutzerrollen und -gruppen zuordnet und den Benutzern beim Setup und den WebTools hilft.
keywords: Ansicht Benutzer, Benutzer, Mitarbeiter, unsere Firmen
author: SuperOffice Product and Engineering
date: 02.21.2023
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/admin/user-management/learn/screen/index
---

# Benutzer

Als Administrator sind Sie für das Hinzufügen und Verwalten Ihrer Benutzer verantwortlich. In diesem Bereich lernen Sie, wie man neue Benutzer hinzufügt, die richtigen Benutzerrollen und -gruppen zuordnet und den Benutzern beim Setup und den WebTools hilft.

## Benutzer-Typen

* **Mitarbeiter**: SuperOffice CRM-Benutzer (in Ihrer Firma)

* **Andere Benutzer**: Anonyme und Systembenutzer (nur Vor Ort)

* **Anonyme Benutzer**: Benutzer mit eingeschränkten Rechten, die durch die [Rolle für anonyme Benutzer][4] definiert werden. Anhand von anonymen Benutzern kann z.B. Zugriff auf Webseiten erteilt werden. Auf diese Weise können Vertriebsmitarbeiter z.B. wichtige Informationen über SuperOffice CRM auf einer Website zur Verfügung stellen, für die keine Anmeldung erforderlich ist. Kunden erhalten so leicht Zugriff auf die Informationen.

* **Systembenutzer**: [!include[Access rights](includes/def-system-user.md)]

    Der Systembenutzer versteht sich als Ergänzung und kann verwendet werden, um Prozessen zum Beispiel zum Replizieren von Kalendern vollständigen Zugriff auf die SuperOffice-Datenbank zu erteilen.

## Mitarbeiter

**Mitarbeiter** sind SuperOffice-Benutzer in Ihrer Firma (oder einer zugehörigen Firma wie einem Tochterunternehmen).

Auf der Registerkarte **Mitarbeiter** der Ansicht **Benutzer** können Sie Benutzer des Typs Mitarbeiter hinzufügen und ihnen Rollen, Gruppen und Lizenzen hinzufügen, vorhandene Benutzer bearbeiten und Benutzer löschen.

Damit eine Person als SuperOffice CRM-Benutzer erfasst werden kann, muss sie bei einer im Listenfeld **Firma** der Ansicht Benutzer angezeigten Firma registriert sein. Damit eine Firma im Listenfeld **Firma** der Ansicht Benutzer aufgeführt wird, muss sie als Firma in der Firmenliste auf der Registerkarte **Unsere Firmen** aufgeführt sein.

> [!NOTE]
> In der Ansicht Benutzer können Sie festlegen, welche Lizenzen Sie den verschiedenen Benutzern zuteilen wollen. Um neue Systemlizenzen hinzuzufügen oder für ein oder mehrere Module die Anzahl der Lizenzen erhöhen/reduzieren möchten, wenden Sie sich für [Lizenzinformationen aktualisieren][6] an SuperOffice.

## <a id="screen"></a>Ansicht Benutzer

In der Ansicht Benutzer können Sie verschiedene Benutzertypen hinzufügen und bearbeiten.

![Übersicht über die Ansicht Benutzer in Einstellungen und Verwaltung -screenshot][img3]

[**Unsere Firmen:**][2] Damit eine Person als SuperOffice CRM-Benutzer erfasst werden kann, muss diese Person bei einer Firma in der Liste **Firma** auf der Ansicht Benutzer angezeigt werden. Damit eine Firma in der Liste **Firma** auf der Ansicht Benutzer angezeigt wird, muss die Firma in der Liste Firma in der Registerkarte **Unsere Firma** angezeigt werden.

> [!NOTE]
> Änderungen, die Sie in der Ansicht Benutzer vornehmen, werden erst wirksam, wenn Sie unten in der Ansicht auf **Speichern** klicken und im daraufhin angezeigten Dialogfeld bestätigen, dass Sie die Änderungen speichern möchten. Wenn Sie auf **Abbrechen** klicken, gehen alle in dieser Ansicht vorgenommenen Änderungen seit Ihrer letzten Speicherung verloren.

### <a id="associates"></a>Die Mitarbeiterliste

Standardmäßig enthält die Liste auf der Registerkarte **Mitarbeiter** die folgenden Spalten:

| Spalte | Beschreibung |
|---|---|
| Benutzer-ID | Der Benutzername, der dem Mitarbeiter zugewiesen wurde |
| Vorname | Der Vorname des Benutzers |
| Nachname | Der Nachname des Benutzers. |
| Primärgruppe | Die Primärgruppe des Benutzers |
| Rolle | Die [Rolle][7] die dem Benutzer zugewiesen wurde. Die Rolle bestimmt die Zugriffsrechte des Benutzers in SuperOffice CRM. |
| Benutzerplan | Der Benutzerplan, der dem Benutzer zugewiesen wurde |
| Zugehörigkeit: Firma | Der Name der Organisation, zu der der Benutzer gehört (definiert als Datenbankbesitzer). |

> [!TIP]
> Sie können auswählen, welche Spalten in der Liste angezeigt werden sollen. Klicken Sie einfach mit der rechten Maustaste auf eine Spaltenüberschrift und wählen Sie die relevanten Spalten in der Spaltenliste aus. Um die Reihenfolge der Spalten zu ändern, klicken und ziehen Sie eine Spaltenüberschrift.

#### Benutzerinformationen

Ganz rechts im Fenster finden Sie detaillierte Informationen über den Benutzer, der in der Liste der Mitarbeiter ausgewählt wurde.

Der vollständige Name, die E-Mail-Adresse und die Zugehörigkeit: Firma werden oben angezeigt. Unten in diesem Bereich können Sie den Benutzer mit der Schaltfläche **Anmelden möglich** in SuperOffice aktivieren/deaktivieren. Klicken Sie auf die Schaltfläche **Aufgabe**, um auf Funktionen wie **Benutzer verschieben** zuzugreifen und Begrüßungs-E-Mails und E-Mails zum Zurücksetzen von Passwörtern zu senden.

In der Übersicht Benutzer gibt es verschiedene Registerkarten:

* **Details** - Hauptübersicht der Benutzerinformationen wie **Benutzer-ID**, **Rolle**, **Benutzerplan**, **Primärgruppe** und **Servicekategorien**.
* **Lizenzen** - Zusatzinformationen zur Lizenz wie **Konfigurierbare Aktivitäten**, die dem Benutzer die Option geben, Folgeaufgabe, Dokumente und Selektionen **sichtbar zu machen**.
* **Mehr** - Die Registerkarte zeigt an, ob Zusatzfelder für Personen vorhanden sind.

### <a id="other-users"></a>Andere Benutzer (vor Ort)

Auf der Registerkarte **Andere Benutzer** auf der Ansicht Benutzer können Login-Rechte für anonyme Benutzer und Systembenutzer bearbeiten und hinzufügen.

### <a id="our-companies"></a>Unsere Firmen

Die Firmenliste auf der Registerkarte **Unsere Firma** in der Ansicht Benutzer soll folgendes angeben:

* Wer kann als Benutzer von SuperOffice CRM definiert werden? Damit eine Person als SuperOffice CRM-Benutzer erfasst werden kann, muss sie bei einer im Listenfeld **Firma** der Ansicht Benutzer angezeigten Firma registriert sein. Damit eine Firma im Listenfeld **Firma** der Ansicht Benutzer aufgeführt wird, muss sie als Firma in der Firmenliste auf der Registerkarte **Unsere Firmen** aufgeführt sein.

* Die Firmen, die als Besitzer eines Satelliten definiert werden können.

#### Spalten in der Firmenliste

| Spalte | Beschreibung |
|---|---|
| Name der Firma | Name der Firma |
| Abteilung | Der Name der Abteilung in der Firma. |
| Ort | Wo sich die Firma befindet. |
| Mitarbeiter | Wie viele Mitarbeiter wurden für die Firma erstellt? |
| Aktiver Satellit | Ob das Unternehmen als aktiver Satellit aufgezeichnet wurde. |

### Benutzerlizenzen

Auf der Registerkarte **Benutzerlizenzen** in der Ansicht Benutzer erhalten Sie einen Überblick, wie viele Benutzerlizenzen verwendet werden und welche Benutzer die verschiedenen Lizenzen verwenden.

* Klicken Sie in der Liste **Benutzerlizenzen** auf eine Lizenz, um eine Liste der Benutzer anzuzeigen, die derzeit diese Lizenz verwenden.

* Halten Sie den Mauszeiger über einen Lizenznamen, um detaillierte Informationen zur Lizenz anzuzeigen.

### Benutzergruppen

Auf der Registerkarte **Benutzergruppen** in der Ansicht Benutzer können Sie sich einen Überblick über Benutzer und Benutzergruppen verschaffen. Klicken Sie auf einen Gruppennamen in der Liste **Verfügbare Gruppen**, um eine Liste der Benutzer anzuzeigen, die momentan dieser Gruppe zugeordnet sind.

## Zugehörige Inhalte

* [Ihre Rollen verwalten][1]
* [Neuen Benutzer hinzufügen][2]
* [Benutzerpläne für aktive Benutzer ändern][3]
* [WebTools für Ihre Benutzer installieren][7]

<!-- Referenced links -->
[1]: role/index.md
[2]: add-associate.md
[3]: ../../license/change-user-plan.md
[4]: role/edit-rights-for-anonymous-users.md
[6]: ../../license/learn/activate.md
[7]: ../../../../../integrations/webtools/install.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/admin/admin-users-overview.png
