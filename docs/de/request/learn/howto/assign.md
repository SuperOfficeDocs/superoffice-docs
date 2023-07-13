---
uid: help-de-request-assign
title: Zuordnungsmethoden
description: Zuordnungsmethoden für Anfragen
author: Hanne Gunnarsson
so.date: 02.14.2023
keywords: Anfrage
so.topic: concept
so.audience: person
so.audience.tooltip: SuperOffice Service
language: de
---

# Automatische Zuordnungsmethoden für Anfragen

Damit für eine Anfrage zuständig zu sein, muss Ihr Name im Feld **Eigentümer** der Anfrage eingetragen sein. Dies kann zum Beispiel manuell erfolgen, wenn die Option [Anfrage wurde erstellt][2] angezeigt wird. Anfragen können jedoch auch automatisch zugeordnet werden. Solche Zuordnungen hängen von der Kategorie der Anfrage und der für diese Kategorie festgelegten Zuordnungsmethode ab.

## Zuordnungsmethoden

| Methode | Beschreibung |
|---|---|
| Gleichmäßige Zuordnung | Die Anfragen werden den Mitgliedern der Kategorie gleichmäßig zugeordnet. |
| Gewichtete Zuordnung | Die Anfragen werden auf Basis der für die Mitglieder der Kategorie festgelegten [Gewichtung][3] zugeordnet. |
| An Benutzer mit den wenigsten unbearbeiteten Anfragen | Neue Anfragen werden dem Mitglied der Kategorie zugeteilt, das die wenigsten unbearbeiteten Anfragen hat. |
| Keine Zuordnung | Die Anfragen werden keinen bestimmten Bearbeitern zugeordnet, sondern mit **Nicht zugeordnet** gekennzeichnet und in einer Warteschlange gespeichert. |

[!include[Get next request in queue](includes/howto-get-next-request.md)]

### Zuordnungsmethode für Kategorie festlegen

Ein Bearbeiter, der über Rechte für die Verwaltung von Kategorien verfügt, kann die Zuordnungsmethode für die Kategorien festlegen:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Wählen Sie **Anfragen** > **Kategorien** aus.
1. Wählen Sie die gewünschte Kategorie aus.
1. Wählen Sie die Registerkarte **Zuordnungsmethode**.
1. Wählen Sie die entsprechenden Optionen aus.
1. Klicken Sie auf **OK**.

## Beispiel

Angenommen, Ihre Firma hat für jede Abteilung der Firma eine Kategorie erstellt: Benutzersupport, Verkäufe, Buchhaltung usw. Und Sie haben auch festgelegt, dass alle an <support@company.com> gesendeten E-Mails, automatisch der Kategorie „Benutzersupport“ zugeordnet werden sollen. Alle Mitarbeiter der Abteilung Kundensupport sind Mitglieder dieser Kategorie. Für diese Kategorie wurde die Methode **Gleichmäßige Zuordnung** festgelegt. Das bedeutet, dass alle Mitglieder der Kategorie die gleiche Anzahl an Anfragen erhalten und dass jedes Mitglied kontinuierlich neue Anfragen in der Ansicht **Eigene unbearbeitete Anfragen** erhält. Wenn alternativ die Methode **Keine Zuordnung** ausgewählt worden wäre, hätten die Mitglieder eigenständig die Ansicht **Nicht zugeordnete Anfragen** aufrufen müssen, um sie die [Eigentümerschaft der neuen Anfragen übernehmen][4] können.

## Was möchten Sie jetzt tun?

* [Anfrage verarbeiten][1]
* [Anfrage erstellen][2]
* [Anfrage annehmen][4]
* [Anderen Bearbeiter um Hilfe bitten (Übergeben)][5]

<!-- Referenced links -->
[1]: ../index.md
[2]: create.md
[3]: ../category/create.md
[4]: accept.md
[5]: transfer.md

<!-- Referenced images -->
