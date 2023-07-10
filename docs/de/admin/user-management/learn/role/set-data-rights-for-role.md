---
uid: help-de-role-set-data-rights
title: Datenrechten für Rolle festlegen
description: Datenrechten für Rolle festlegen
author: Bergfrid Dias
so.date: 03.15.2023
keywords: Benutzerverwaltung, Rolle, Zugriff, Rechte
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
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

4. Klicken Sie auf das ![Symbol][img3] Pfeil neben dem zu ändernden Recht und wählen Sie das gewünschte Recht aus.

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

| Daten von | Erläuterung|
|---|---|
| Eigene | Selbst erstellt |
| Primärgruppe (A) | Von Ihrer Primärgruppe erstellt (Abteilung) |
| Persönliche Firma (E) | Von Firma eines externen Benutzers erstellt |
| Weitere Gruppen (A) | Von einer Benutzergruppe erstellt, zu der Sie gehören |
| Selbes Projekt (E) | In einem Projekt erstellt, zu dem ein externer Benutzer gehört |
| Weitere Mitarbeiter | Von weiteren Mitarbeitern innerhalb der Firma erstellt |
| Externer Benutzer | Von externen Benutzern (Audience-Benutzern) erstellt |
| Anonym | Von anonymen Benutzern erstellt |

* A = Mitarbeiter
* E = Extern

## Wie zeige ich Datenobjekte für externe Benutzer an?

Wenn externe Benutzer (Audience-Benutzer) Zugriff auf die Datenobjekte (Firmen, Projekte, Dokumente usw.) erhalten sollen, reicht es nicht aus, den externen Benutzern Leserechte (oder mehr) zu erteilen. Die Datenobjekte müssen außerdem in SuperOffice veröffentlicht werden.

## Zugriffsrechte für Berichte

Alle SuperOffice CRM-Benutzer haben Zugriff auf die Ansicht Berichte, während die einzelnen Berichte, auf die Sie Zugriff haben, von den Rechten gemäß den Folgeaufgaben, Dokumenten, Verkäufen und Aktivitätslisten haben. In der Praxis bedeutet dies, dass Sie keine Berichte für Inhalte erstellen können, für die Sie keine Berechtigung zum Anzeigen haben.

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png
