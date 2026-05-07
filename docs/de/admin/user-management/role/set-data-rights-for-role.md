---
uid: help-de-role-set-data-rights
title: Datenrechten für Rolle festlegen
description: Datenrechten für Rolle festlegen
keywords: Benutzerverwaltung, Rolle, Zugriff, Rechte
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /de/admin/user-management/learn/role/set-data-rights-for-role
language: de
---

# Datenrechte für eine Rolle festlegen

Sie können Rechte für Datenobjekte festlegen, die davon abhängen, wer Eigentümer des Objekts ist. Alle Benutzer, die zu dieser [Rolle][2] gehören, werden je nach den hier vorgenommenen Einstellungen Rechte zugeordnet.

## Schritte

1. [!include[Open Roles](../includes/open-roles.md)]

1. Wählen Sie die Registerkarte **Mitarbeiter** aus.

1. Wählen Sie die gewünschte Rolle in der Liste **Rollen**. Die Rechte für die ausgewählte Rolle werden auf der Registerkarte **Datenrechte** angezeigt.

1. Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben dem zu ändernden Recht und wählen Sie das gewünschte Recht aus.

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
| Weitere Gruppen (A) | Von einer Benutzergruppe erstellt, der Sie angehören | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" ist ein Mitarbeiter einer Gruppe, der Sie angehören |
| Weitere Mitarbeiter | Von anderen Mitarbeitern innerhalb der Firma erstellt | Das Feld *Eigentümer* gilt | Das Feld *Verantwortlich* gilt | "Verantwortlicher" ist ein Mitarbeiter, mit dem Sie keine Gruppe teilen |
| Anonym | Von anonymen Benutzern erstellt | Nicht zutreffend | Nicht zutreffend | Nicht zutreffend |

**A** = Mitarbeiter

Im **Personen**-karte wird das Feld **Verantwortliche** immer von der zugehörigen **Firma** übernommen.

## Verwandte Inhalte

* [Datenrechte][3]
* [Onsite-Datenrechte][4]

<!-- Referenced links -->

[2]: index.md
[3]: functional-rights.md
[4]: https://help.superoffice.com/docs/11/de/admin/user-management/role/set-data-rights-for-role.html
