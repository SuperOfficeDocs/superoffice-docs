---
uid: help-de-request-assign
title: Zuordnungsmethoden
description: Zuordnungsmethoden für Anfragen
keywords: Anfrage
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
so.date: 06.11.2024
so.version: 10
language: de
so.topic: concept
so.audience: person
so.audience.tooltip: SuperOffice Service
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

Lassen Sie uns diese Zuordnungsmethoden mit drei Benutzern und drei eingehenden Anfragen veranschaulichen.

![Request assignment methods -screenshot][img1]

### Gleichmäßig

Weist Anfragen gleichmäßig in einer Rundlauf-Weise unter den Kategorienmitgliedern zu.

![Request assignment methods, even -screenshot][img2]

### Gewichtet

Weist Anfragen basierend auf den spezifischen Gewichtungen für jedes Mitglied der Kategorie zu. Zum Beispiel, wenn Mitglied A ein Gewicht von 1 hat, Mitglied B ein Gewicht von 2 und Mitglied C ein Gewicht von 5, werden sie über 8 Anfragen proportional zugewiesen.

Anfragen werden probabilistisch basierend auf ihren Gewichtungen zugewiesen.

![Request assignment methods, weighted][img3]

| Anfrage | Zufallswert | Zugewiesen an |
|---|:-:|---|
| Erste Anfrage | 7 | Mitglied C |
| Zweite Anfrage | 2 | Mitglied B |
| Dritte Anfrage | 5 | Mitglied C |

![Request assignment methods, weighted -screenshot][img4]

### An Benutzer mit den wenigsten unbearbeiteten Anfragen

Weist neue Anfragen dem Mitglied mit den wenigsten aktiven Anfragen zu.

| Anfrage | Bedingung | Zugewiesen an |
|---|:-:|---|
| Erste Anfrage | Mitglieder B und C haben die wenigsten Anfragen | Mitglied C |
| Zweite Anfrage | Mitglied B hat die wenigsten Anfragen | Mitglied B |
| Dritte Anfrage | Alle Mitglieder haben die gleiche Anzahl an Anfragen | Mitglied B |

![Request assignment methods, user with fewest open requests -screenshot][img5]

### Keine Zuordnung

Weist keine Anfragen an bestimmte Mitglieder zu. Alle Anfragen werden standardmäßig in eine Warteschlange gestellt.

![Request assignment methods, do not assign -screenshot][img6]

[!include[Get next request in queue](includes/howto-get-next-request.md)]

## Zuordnungsmethode für Kategorie festlegen

Ein Bearbeiter, der über Rechte für die Verwaltung von Kategorien verfügt, kann die Zuordnungsmethode für die Kategorien festlegen:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Wählen Sie **Anfragen** > **Kategorien** aus.
1. Wählen Sie die gewünschte Kategorie aus.
1. Wählen Sie die Registerkarte **Zuordnungsmethode**.
1. Wählen Sie die entsprechenden Optionen aus.
1. Klicken Sie auf **OK**.

## Beispiel

<!-- markdownlint-disable-next-line MD034 -->
Angenommen, Ihre Firma hat für jede Abteilung der Firma eine Kategorie erstellt: Benutzersupport, Verkäufe, Buchhaltung usw. Und Sie haben auch festgelegt, dass alle an support@company.com gesendeten E-Mails, automatisch der Kategorie "Benutzersupport" zugeordnet werden sollen. Alle Mitarbeiter der Abteilung Kundensupport sind Mitglieder dieser Kategorie. Für diese Kategorie wurde die Methode **Gleichmäßige Zuordnung** festgelegt. Das bedeutet, dass alle Mitglieder der Kategorie die gleiche Anzahl an Anfragen erhalten und dass jedes Mitglied kontinuierlich neue Anfragen in der Ansicht **Eigene unbearbeitete Anfragen** erhält. Wenn alternativ die Methode **Keine Zuordnung** ausgewählt worden wäre, hätten die Mitglieder eigenständig die Ansicht **Nicht zugeordnete Anfragen** aufrufen müssen, um sie die [Eigentümerschaft der neuen Anfragen übernehmen][4] können.

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
[img1]: ../../../../media/loc/en/request/assign-requests.png
[img2]: ../../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../../media/loc/en/request/assign-requests-not.png
