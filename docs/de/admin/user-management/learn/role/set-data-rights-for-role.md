---
uid: help-de-role-set-data-rights
title: Datenrechten für Rolle festlegen
description: Datenrechten für Rolle festlegen
keywords: Benutzerverwaltung, Rolle, Zugriff, Rechte
author: Bergfrid Dias
date: 03.27.2025
version: 10.5
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Datenrechte für eine Rolle festlegen

[!include[Requirement](../includes/note-anon-req.md)]

Sie können Rechte für [Datenobjekte][2] festlegen, die davon abhängen, wer Eigentümer des Objekts ist. Alle Benutzer, die zu dieser [Rolle][2] gehören, werden je nach den hier vorgenommenen Einstellungen Rechte zugeordnet.

## Schritte

1. [!include[Open Roles](includes/open-roles.md)]

2. Wählen Sie die Registerkarte **Mitarbeiter** oder die Registerkarte **Extern** (vor Ort) aus.

    [Wie man die Rolle für anonyme Benutzer bearbeitet.][1]

3. Wählen Sie die gewünschte Rolle in der Liste **Rollen**. Die Rechte für die ausgewählte Rolle werden auf der Registerkarte **Datenrechte** angezeigt.

4. Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben dem zu ändernden Recht und wählen Sie das gewünschte Recht aus.

    | Name | Rechte | QuickInfo |
    |---|---|---|
    | Keine | Keine Rechte | |
    | Lesen | Leserechte | R |
    | Erstellen | Rechte zum Lesen und Erstellen | EL |
    | Abgleichen | Rechte zum Lesen, Erstellen und Abgleichen | LEA |
    | Löschen | Rechte zum Lesen, Erstellen, Abgleichen und Löschen | ELALÖ |

    **E** = Erstellen, **L** = Lesen, **A** = Abgleichen, **LÖ** = Löschen

    Die Änderungen werden automatisch gespeichert.

## Welche Bedeutung haben die verschiedenen Spalten unter Daten von?

| **Daten von** | **Dashboards und Dokumente** | **Verkäufe und Folgeaufgaben** | **Projekte** | **Firma und Person** |
|---|---|---|---|---|
| Eigene | Von Ihnen erstellt | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | Sie sind "Verantwortlicher" |
| Primärgruppe (A) | Von Ihrer Primärgruppe (Abteilung) erstellt | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" ist ein Mitarbeiter Ihrer Primärgruppe |
| Persönliche Firma (E)<br />nur ONSITE | Von der Firma eines externen Benutzers erstellt | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" gilt |
| Weitere Gruppen (A) | Von einer Benutzergruppe erstellt, der Sie angehören | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" ist ein Mitarbeiter einer Gruppe, der Sie angehören |
| Selbes Projekt (E)<br />nur ONSITE | In einem Projekt erstellt, dem ein externer Benutzer angehört | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" gilt |
| Weitere Mitarbeiter | Von anderen Mitarbeitern innerhalb der Firma erstellt | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" ist ein Mitarbeiter, mit dem Sie keine Gruppe teilen |
| Externer Benutzer | Von externen Benutzern (Audience-Benutzern) erstellt | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" gilt |
| Anonym | Von anonymen Benutzern erstellt | Nicht zutreffend | Nicht zutreffend | Nicht zutreffend |

**A** = Mitarbeiter, **E** = extern

Im **Personen**-karte wird das Feld **Verantwortliche** immer von der zugehörigen **Firma** übernommen.

## Wie zeige ich Datenobjekte für externe Benutzer an?

Wenn externe Benutzer (Audience-Benutzer) Zugriff auf die Datenobjekte (Firmen, Projekte, Dokumente usw.) erhalten sollen, reicht es nicht aus, den externen Benutzern Leserechte (oder mehr) zu erteilen. Die Datenobjekte müssen außerdem in SuperOffice veröffentlicht werden.

## Vervandt

* [Datenrechte][3]

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md
[3]: functional-rights.md
