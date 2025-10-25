---
uid: help-de-users
title: Benutzer
description: Lernen Sie, wie man neue Benutzer hinzufügt, die richtigen Benutzerrollen und -gruppen zuordnet und den Benutzern beim Setup und den WebTools hilft.
keywords: Ansicht Benutzer, Benutzer, Mitarbeiter, unsere Firmen, Anzeigestatus, Verfügung gestellt
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
redirect_from: 
  - /de/admin/user-management/learn/index
  - /de/admin/user-management/learn/screen/index
  - /de/admin/user-management/learn/visibility
  - /de/admin/user-management/learn/associates-filter-group
language: de
---

# Benutzer

Als Administrator sind Sie dafür verantwortlich, Ihre Benutzer hinzuzufügen und zu verwalten.

SuperOffice CRM verwendet ein rollen‑ und gruppenbasiertes Zugriffssystem. Das bedeutet, dass **jeder SuperOffice‑Benutzer eine Rolle hat und einer primären Gruppe angehört** (diese Einstellungen sind Pflicht).

Das folgende Diagramm zeigt ein Modell, wie das Zugriffssystem in SuperOffice CRM funktioniert.

![Diagramm zeigt das Zugriffssystem][img1]

Eine [Rolle][6] hat eine Menge von Daten‑ und [funktionalen Rechten][7], und eine Gruppenzuordnung gewährt Zugriff auf Datenobjekte, verschiedene SuperOffice‑Listen und hilft dabei, Systemeinstellungen effizienter zu setzen.

Das System erlaubt Ihnen, den Zugriff auf Firmen, Persone, Projekte, Projektmitglieder, Selektionen, Verkäufe, Stakeholder (im Verkauf), Folgeaufgaben, Dokumente (einschließlich E‑Mails und Mailings), Beziehungen (Person und Firma), und Dashboards zu konfigurieren. All diese unterschiedlichen Arten von Datensätzen werden **Datenobjekte** genannt.

Jedes Datenobjekt gehört einem Benutzer, der Sie selbst (a), Benutzer in Ihrer primären Gruppe (b), Benutzer Ihrer anderen Gruppen (c), andere Mitarbeiter, mit denen Sie nicht über eine Ihrer Gruppen verbunden sind (d), externe Benutzer (e), und anonyme Benutzer (f) sein kann.

![Die Benutzer‑Rollen‑Ansicht, Datenrechte‑Tab ‑screenshot][img2]

Die Eigentümerschaft der verschiedenen Datenobjekte wird in verschiedenen Feldern festgelegt. Zum Beispiel legt im Firmen­satz das Feld **Unser Kontakt** den Eigentümer des Datensatzes fest. Bei Follow‑ups ist es das Feld **Owner**, im Projekt **Verantwortlich**, und so weiter.

## <a id="visible"></a>Sichtbarkeit

Ob Sie bestimmte Dokumente, Verkäufe, Wiedervorlagen und Selektionen anzeigen können, hängt nicht nur von der Ihnen zugeordneten Rolle ab. Bestimmte Informationen sind möglicherweise nicht für Sie zugänglich. In den Dialogfeldern Dokumente und Folgeaufgaben und in den Ansicht Verkauf und Selektion gibt es ein Listenfeld namens **Sichtbar für**. In der Ansicht Verkauf können Sie beispielsweise auswählen, ob der Verkauf für jeden sichtbar ist, nur für die primäre Gruppe, der der Besitzer angehört, oder nur für den Eigentümer.

Hierfür ist die Lizenz **Vertrauliche Aktivitäten** erforderlich.

Um diese Lizenz festzulegen, müssen Sie den gewünschten Benutzer suchen, auf die Registerkarte **Lizenzen** und dann das Kontrollkästchen für **Vertrauliche Aktivitäten** anklicken.

## Benutzer-Typen

* **Mitarbeiter**: SuperOffice CRM-Benutzer (in Ihrer Firma)

* **Andere Benutzer**: Anonyme und Systembenutzer (nur Vor Ort)

* **Anonyme Benutzer**: Benutzer mit eingeschränkten Rechten, die durch die [Rolle für anonyme Benutzer][4] definiert werden. Anhand von anonymen Benutzern kann z.B. Zugriff auf Webseiten erteilt werden. Auf diese Weise können Vertriebsmitarbeiter z.B. wichtige Informationen über SuperOffice CRM auf einer Website zur Verfügung stellen, für die keine Anmeldung erforderlich ist. Kunden erhalten so leicht Zugriff auf die Informationen.

* **Systembenutzer**: Der Systembenutzer versteht sich als Ergänzung und kann verwendet werden, um Prozessen zum Beispiel zum Replizieren von Kalendern vollständigen Zugriff auf die SuperOffice-Datenbank zu erteilen.

## Mitarbeiter

**Mitarbeiter** sind SuperOffice-Benutzer in Ihrer Firma (oder einer zugehörigen Firma wie einem Tochterunternehmen).

Auf der Registerkarte **Mitarbeiter** der Ansicht **Benutzer** können Sie Benutzer des Typs Mitarbeiter hinzufügen und ihnen Rollen, Gruppen und Lizenzen hinzufügen, vorhandene Benutzer bearbeiten und Benutzer löschen.

Damit eine Person als SuperOffice CRM-Benutzer erfasst werden kann, muss sie bei einer im Listenfeld **Firma** der Ansicht Benutzer angezeigten Firma registriert sein. Damit eine Firma im Listenfeld **Firma** der Ansicht Benutzer aufgeführt wird, muss sie als Firma in der Firmenliste auf der Registerkarte **Unsere Firmen** aufgeführt sein.

> [!NOTE]
> In der Ansicht Benutzer können Sie festlegen, welche Lizenzen Sie den verschiedenen Benutzern zuteilen wollen. Um neue Systemlizenzen hinzuzufügen oder für ein oder mehrere Module die Anzahl der Lizenzen erhöhen/reduzieren möchten, wenden Sie sich für [Lizenzinformationen aktualisieren][16] an SuperOffice.

## Benutzergruppen

Eine **Gruppe** wird dem Benutzer zugewiesen und gewährt Zugriff auf Datenobjekte (4 im vorherigen Diagramm). Ein Benutzer muss eine **primäre Gruppe** haben und kann mehrere **andere Gruppen** haben.

![Diagramm für Gruppenmitgliedschaft][img5]

In diesem Beispiel hat Benutzer A Marketing als andere Gruppe und Benutzer B hat Marketing als primäre Gruppe. In diesem Fall, wenn Benutzer A Daten sehen möchte, die von Benutzer B erstellt wurden, muss in der Rolle von Benutzer A die Rechte „Lesen" neben allen Datenobjekten in der Spalte *Andere Gruppe* vorhanden sein. Dies liegt daran, dass die Marketing‑Gruppe die andere Gruppe für Benutzer A ist und sie mit Datensätzen verknüpft, die Benutzer B erstellt.

Eine Gruppe kann auch Zugriff auf Listenelemente (5 im Diagramm) in SuperOffice CRM gewähren. Dies ist nur relevant, wenn Sie die Einstellung **Gruppierung und Filterung** (a) für Ihre Listen verwenden. Ist diese Einstellung nicht aktiviert, haben alle Benutzer Zugriff auf alle Listen in SuperOffice CRM. Gruppierung und Filterung sind besonders nützlich, wenn viele Benutzer mit verschiedenen Verantwortlichkeiten Zugriff auf das System haben. Auf diese Weise können Sie vermeiden, dass bestimmte Benutzer auf Informationen zugreifen, die sie nicht sehen sollten.

![Gruppierung und Filterung nach Benutzergruppe für Dokumentvorlagen‑Liste –screenshot][img6]

Beispielsweise wenn Sie ein bestimmtes Listenelement nur für bestimmte Benutzer sichtbar machen möchten, gehen Sie zur Liste, die diese Elemente enthält (a), wählen das Element aus (b) und setzen im Feld „Sichtbar für Benutzergruppen" ein Häkchen bei den Benutzergruppen, die das Listenelement sehen sollen (c).

![Präferenz‑Ebene Auswahl Gruppe für Follow‑up –screenshot][img7]

Wenn Sie Ihre Benutzer in Gruppen organisiert haben, ist das auch praktisch, wenn Sie SuperOffice‑Einstellungen personalisieren möchten, die wir [Präferenzen][15] (6) nennen. Jede Präferenz kann für einen einzelnen Benutzer, eine Benutzergruppe oder das gesamte System eingestellt werden.

![Präferenzen für Vertriebs‑Gruppe –screenshot][img8]

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
| Rolle | Die [Rolle][6] die dem Benutzer zugewiesen wurde. Die Rolle bestimmt die Zugriffsrechte des Benutzers in SuperOffice CRM. |
| Benutzerplan | Der Benutzerplan, der dem Benutzer zugewiesen wurde |
| Zugehörigkeit: Firma | Der Name der Organisation, zu der der Benutzer gehört (definiert als Datenbankbesitzer). |

> [!TIP]
> Sie können auswählen, welche Spalten in der Liste angezeigt werden sollen. Klicken Sie einfach mit der rechten Maustaste auf eine Spaltenüberschrift und wählen Sie die relevanten Spalten in der Spaltenliste aus. Um die Reihenfolge der Spalten zu ändern, klicken und ziehen Sie eine Spaltenüberschrift.

* **Suche nach Benutzern:** Mit dieser dynamischen Suchfunktion können Sie bestimmte Benutzer schnell nach Namen oder Benutzer-ID suchen oder alle Benutzer suchen, die zu bestimmten Rollen, Gruppen oder Benutzerplänen gehören. Geben Sie einfach Text in das Suchfeld ein, um die Liste mit den entsprechenden Benutzern zu aktualisieren.

* **Nur Benutzer anzeigen, die sich anmelden können:** Mit dieser Option werden nur Benutzer angezeigt, die aktiv sind (nicht deaktiviert wurden).

#### Liste filtern <i class="ph ph-funnel" aria-hidden="true"></i>

Sie können die Liste der Benutzer nach einem der Spaltenköpfe filtern.

> [!NOTE]
> Klicken Sie mit der rechten Maustaste auf eine Spalte, um weitere Spalten hinzuzufügen, nach denen gefiltert werden soll.

1. Gehen Sie zur Registerkarte **Mitarbeiter**.
1. Klicken Sie mit der rechten Maustaste auf eine Spaltenüberschrift oder klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> in der Ecke oben rechts in der Liste.
1. Wählen Sie **Filter aktivieren**.
1. Klicken Sie auf **OK**. Es werden Filter-Schaltflächen zu jeder Spaltenkopfzeile hinzugefügt.
1. Klicken Sie in der zu filternden Spalte auf <i class="ph ph-funnel" aria-label="Filter icon"></i>.
1. Wählen Sie die entsprechenden Werte in der Liste aus. Bei einer langen Liste verwenden Sie die Suchfunktion.
1. Klicken Sie auf **Filter**.
1. Gehen Sie wie in Schritt 5-7 erläutert vor, um nach weiteren Spalten zu filtern.

#### Gruppieren der Liste

Sie können die Liste der Benutzer nach Rolle, Benutzerplan, Primärgruppe und ähnlichem gruppieren. Darüber hinaus können Sie auf mehreren Ebenen gruppieren.

> [!NOTE]
> Klicken Sie mit der rechten Maustaste auf eine Spalte, um weitere Spalten hinzuzufügen, nach denen gruppiert werden soll (siehe auch [Ansichten anpassen][14]).

1. Gehen Sie zur Registerkarte **Mitarbeiter**.
1. Klicken Sie mit der rechten Maustaste auf eine Spaltenüberschrift oder klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> in der Ecke oben rechts in der Liste.
1. Wählen Sie **Gruppierung aktivieren**.
1. Klicken Sie auf **OK**.
1. Klicken Sie bei dem Wert, nach dem Sie gruppieren möchten, auf den Spaltenkopf und ziehen Sie ihn in den Bereich über den Spalten ("Ziehen Sie einen Spaltenkopf ..."). Die Liste wird nun nach diesem Wert gruppiert.
1. Um nach weiteren Werten zu gruppieren, klicken Sie auf einen anderen Spaltenkopf und ziehen ihn in denselben Bereich.
1. Klicken Sie auf die Gruppenwerte und ziehen Sie sie, um die Reihenfolge der Gruppierungsebenen zu ändern.
1. Klicken Sie auf einen Gruppenwert, um die Sortierreihenfolge zu ändern.

> [!NOTE]
> Wenn Sie zu einer anderen Registerkarte wechseln, wird das Gruppieren zurückgesetzt.

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

## Verwandte Inhalte

* [Ihre Rollen verwalten][6]
* [Neuen Benutzer hinzufügen][2]
* [Benutzergruppen erstellen][3]
* [Benutzerpläne für aktive Benutzer ändern][17]

<!-- Referenced links -->
[2]: add-associate.md
[3]: user-groups.md
[4]: onsite/other-users.md#rights
[6]: role/index.md
[7]: role/functional-rights.md
[14]: ../adjusting-views.md
[15]: ../preferences/learn/index.md
[16]: ../license/activate.md
[17]: ../license/change-user-plan.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/access-right-system.png
[img2]: ../../../media/loc/en/admin/user-access-level.png
[img3]: ../../../media/loc/en/admin/admin-users-overview.png
[img5]: ../../../media/loc/en/admin/groups.png
[img6]: ../../../media/loc/en/admin/lists-grouping.png
[img7]: ../../../media/loc/en/admin/follow-up-type.png
[img8]: ../../../media/loc/en/admin/sales-group.png
