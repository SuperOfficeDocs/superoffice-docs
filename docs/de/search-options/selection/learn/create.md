---
uid: help-de-selection-create
title: Selektion erstellen
description: Arbeiten mit dynamischen und statischen Selektionen
keywords: Selektion erstellen, neue Selektion als Selektion speichern, Selektion
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from:
  - /de/sale/saint/learn/using-status-monitors-in-dynamic-selections
  - /de/search-options/selection/learn/create/copy
  - /de/search-options/selection/learn/create/index
  - /de/search-options/selection/learn/create/tutorial
---

# Selektionen erstellen

Sie beginnen mit einer Reihe von Kriterien von der Ansicht **Suchen**, indem Sie eine typische Suchanfrage verwenden oder Ihre eigenen Kriterien hinzufügen. Von dort aus können Sie das Ergebnis als dynamische oder statische Selektion speichern. Der Unterschied zwischen den beiden besteht darin, dass eine Selektion die Anzahl der Mitglieder (dynamisch) ständig aktualisiert oder die Mitglieder mit einer Momentaufnahme der heutigen festgelegten Mitglieder (statisch) eingefroren werden.

## Schritte

1. Klicken Sie auf **Neu** auf der oberen Leiste und wählen Sie **Selektion**.

1. In der Ansicht Suche klicken Sie auf die Option **Suchen**, die für den Datentyp relevant ist, den Sie in Ihrer Selektion verwenden möchten. Sie können auch auf **Typische Suchanfragen** klicken, um vordefinierte Suchanfragen zu verwenden.

1. [Geben Sie Ihre Suchkriterien][9] auf der Registerkarte **Kriterien** ein.

1. Klicken Sie auf **Suchen**. Auf der Registerkarte **Ergebnisse** werden die Daten angezeigt, die den Kriterien entsprechen.

1. Um die Ergebnisse in einer Selektion zu speichern, klicken Sie auf **Als Selektion speichern**. Wenn dies nicht der Fall ist, grenzen Sie die Suchkriterien ein.

1. Wählen Sie im Dialogfeld **Als Selektion speichern** den Typ aus:

    * **Dynamische Selektion:** Dieser Selektionstyp wird ständig automatisch um Mitglieder ergänzt, die den Selektionskriterien entsprechen.
    * **Statische Selektion:** Dieser Selektionstyp enthält nur die Mitglieder, die Sie manuell hinzugefügt haben.
    * **Zu bestehender statischer Selektion hinzufügen:** Speichern Sie das Ergebnis in einer bestehenden Selektion. Sie können später manuell Mitglieder zur Selektion hinzufügen oder entfernen.

1. Klicken Sie auf **Speichern**.

1. Geben Sie in der Zeile mit dem Text *Selektionsname* den Namen der neuen Selektion ein. Die Eingabe in dieses Feld ist obligatorisch.

1. Im Feld **Selektion ist** können Sie die Selektion bei Bedarf in einem anderen Selektionstyp umwandeln.

1. **Details auswählen:**

    * Im Feld **Eigentümer** wird automatisch der angemeldete Benutzer angezeigt.

        Nachdem eine neue Selektion gespeichert wurde, können Sie den Eigentümer durch [Selektion bearbeiten][6] ändern. Dies bedeutet, dass Sie die Selektion einem anderen Benutzer zuweisen.

    * Wählen Sie im Feld **Kategorie** den gewünschten Selektionstyp aus. Diese wurden in Einstellungen und Verwaltung definiert.

    * Wählen Sie im Feld **Sichtbar für** aus, ob die Selektion für alle sichtbar sein soll, privat ist (nur für die als Eigentümer definierte Person sichtbar ist) oder für alle Personen in der Benutzergruppe des Eigentümers sichtbar ist.

1. Fügen Sie im Feld **Beschreibung** ggf. eine Beschreibung der Selektion hinzu.

1. Wenn Sie die Definition der wichtigsten Daten für die Selektion beendet haben, klicken Sie auf **Speichern**.

## <a id="copy"></a>Selektion kopieren

Mit der Aufgabe **Selektion kopieren** können Sie auf einfache und schnelle Weise eine genaue Kopie einer Selektion erstellen.

Wenn Sie auf diese Schaltfläche klicken, wird eine Kopie der Selektion erstellt. Neben dem Selektionsnamen erscheint der Text (Kopie). Wenn Sie also beispielsweise die Selektion mit dem Namen *Meine statische Selektion* kopieren, erhält die Kopie den Namen *Meine statische Selektion (Kopie)*.

1. [!include[Start](includes/steps-start-task.md)]

1. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="die Schaltfläche Aufgabe"></i> und wählen Sie **Selektion kopieren** aus. Dies erstellt eine Kopie der Selektion.

1. Geben Sie der neuen Selektion einen neuen Namen.

## Tipps

* Wenn Sie versuchen, eine Selektion mit einem bereits vergebenen Namen zu speichern, wird das [Dialogfeld Duplikate][8] angezeigt. Darin wird genauso vorgegangen wie bei Firmen.

* Klicken Sie auf <i class="ph ph-star" aria-label="Star icon"></i>, um die Selektion zu [Ihren Favoriten][7] hinzuzufügen.

* Klicken Sie auf <i class="ph ph-gear" aria-label="Gear"></i> rechts neben den Spaltenkopfzeilen. Hier können Sie Datensätze gruppieren und filtern sowie Spalten hinzufügen/entfernen. Diese Einstellungen können für die aktive Selektion gespeichert werden, indem Sie **Spalten nur für die aktuelle Selektion speichern** auswählen.

* Markieren Sie **Abgeschlossen**, um anzugeben, dass die Selektion inaktiv ist. Wenn Sie die Selektion aktivieren möchten, heben Sie die Markierung dieser Option auf.

* Mit aktiviertem **SAINT** (erfordert Sales-Premium oder Service-Premium) können Sie [Statusangaben][14] als Kriterien für die Erstellung dynamischer Selektion verwenden. Dies ermöglicht Ihnen einen Überblick über Firmen, Personen oder Projekte, die bestimmten Statuskriterien entsprechen. Die SAINT-Kriterien finden Sie unter **Zähler (SAINT)** in der [Kriterienliste][9] in der Ansicht **Suchen**.

## Verwandte Inhalte

* [Selektionen kombinieren][3]
* [Selektion aktualisieren][6]
* [Aufgaben in der Ansicht Selektion ausführen][5]

<!-- Referenced links -->
[3]: combine.md
[7]: ../../../learn/basics/fav.md
[8]: ../../../learn/basics/duplicates.md
[5]: howto/index.md
[6]: update.md
[9]: ../../learn/search-criteria.md
[14]: ../../../saint/learn/index.md
