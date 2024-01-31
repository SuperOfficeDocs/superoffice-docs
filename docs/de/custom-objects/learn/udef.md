---
uid: help-de-udef
title: Benutzerdefinierte Felder
description: Benutzerdefinierte Felder
keywords: udef, benutzerdefiniertes Feld
author: Bergfrid Dias
so.date: 01.30.2024
so.version: 10
so.topic: concept
so.audience: user
so.audience.tooltip: SuperOffice CRM
language: de
---

# Benutzerdefinierte Felder

Ein *benutzerdefiniertes* Feld (udef) ist ein anzupassendes Feld, das Sie einer standard SuperOffice-Datenbanktabelle hinzufügen. Sie können die folgenden Entitäten erweitern:

* Firma
* Person
* Dokumente
* Folgeaufgabe
* Projekt
* Verkauf

Benutzerdefinierte Felder werden in Einstellungen und Verwaltung im Ansicht **Felder** verwaltet. In der Anwendung sind benutzerdefinierte Felder im **Mehr**-Tab der Entität sichtbar, zu der sie hinzugefügt wurden. Zum Beispiel wird ein benutzerdefiniertes Feld in einer Firma im **Mehr**-Tab im Ansicht Firma angezeigt.

> [!NOTE]
> Jeder kann die in einem benutzerdefinierten Feld gespeicherten Daten **aktualisieren**. Nur ein Administrator kann ein benutzerdefiniertes Feld hinzufügen (oder entfernen). Sie benötigen eine Development Tools-Lizenz, um das Layout des **Mehr**-Tabs anzupassen und Seiten-1-Felder zu verwenden.

## <a id="field-types" />Feldtypen

* **Nummer**: ganze Zahl, unbegrenzte Ziffernanzahl
* **Kurztext**: Text mit maximal 39 Zeichen. Geben Sie im Feld **Textlänge**, das bei Auswahl dieser Option aktiviert ist, die maximale Zeichenanzahl ein, die Benutzer in dieses Feld eingeben dürfen.
* **Langtext**: Text mit maximal 199 Zeichen. Geben Sie im Feld **Textlänge**, das bei Auswahl dieser Option aktiviert ist, die maximale Zeichenanzahl ein, die Benutzer in dieses Feld eingeben dürfen.
* **Datum**: Datum zwischen 01.01.1970 und 19.01.2038.
* **Unbegrenztes Datum**: jedes Datum.
* **Kontrollkästchen**: ein Kontrollkästchen.
* **Liste**: ein Listenfeld. Wählen Sie in dem Feld unten eine Liste aus dem System.
* **Dezimal**: eine Zahl mit Dezimalstellen.

## <a id="limit" />Maximale Feldanzahl

Die folgenden Einschränkungen gelten für die Anzahl der benutzerdefinierten Felder, die Sie auf den einzelnen Registerkarten Firma, Person, Projekt und Verkauf festlegen können.

* **Nummer**, **Datum**, **Kontrollkästchen** und **Liste**: Insgesamt maximal 60.
* **Kurzer Text** und **Unbegrenztes Datum**: Insgesamt maximal 40.
* **Langer Text**: Insgesamt maximal 9.
* **Dezimal**: Insgesamt maximal 10.

> [!NOTE]
> Vier der benutzerdefinierten Felder in jeder Gruppe müssen indiziert werden.

## <a id="index" />Indizierte Felder

Die Indexierung ist gut für die Benutzererfahrung und die Leistung. Die ersten 4 Felder jeder Datentyp sind für Indizes reserviert.

Sie müssen das Kontrollkästchen aktivieren, wenn Sie das Feld erstellen, um die Indexierung zu ermöglichen. Sie können bis zu 4 Felder in jeder der 4 Datentypen (Long, Double, String[40], String[200]) für jede Entität markieren. Zum Beispiel können Sie 4 Zahlen und 4 Dezimalstellen für einen Kontakt indizieren, jedoch können Sie nicht gleichzeitig auch ein Datum indizieren - weil alle Long-Indizeslots von den Zahlen belegt sind.

Wenn Sie sich entscheiden, überhaupt nicht zu indizieren, verschwenden Sie im Grunde genommen 16 Felder! Damit wird die maximale Anzahl der benutzerdefinierten Felder auf 103 reduziert.

## <a id="page-1" />Seite 1-Felder

Unter den benutzerdefinierten Feldern, die in den Registerkarten **Mehr** in SuperOffice CRM angezeigt werden, können Sie *drei* auswählen, die als Seite 1-Felder fungieren (so genannt, weil sie auf der "ersten Seite" in ihren jeweiligen Ansichten angezeigt werden).

**Stellen:**

* Die Registerkarte **Firma** in der Ansicht Firma
* Auf der Registerkarte **Person** auf der Personenkarte
* Die Registerkarte **Projekt** in der Ansicht Projekt
* Die Registerkarte **Verkauf** in der Ansicht Verkauf
* Die Registerkarte **Details** in der Ansicht Dokument

> [!NOTE]
> Seite-1-Feld erfordert die Lizenz für Development Tools und ist nicht verfügbar, wenn Ihre Organisation ein anderes Layout über [Ansichtsdesigner][8] verwendet.

## Beispiele

### Benutzerdefinierte Felder für Firmen

Ihre Firma verkauft Software und Benutzersupport-Dienstleistungen. Die Benutzersupport-Abteilung muss darüber Bescheid wissen, über wie viele Mitarbeiter und PCs die jeweiligen Kunden verfügen. Außerdem müssen Sie wissen, welchen Wartungsvertrag die Kunden aufweisen und wann diese ablaufen.

Sie können diese Felder dann der Ansicht Firma hinzufügen:

| Feldname | Typ | Beschreibung |
|---|---|---|
| Anzahl an PCs | Nummer | Ein Nummernfeld, in dem Sie die Anzahl an PCs erfassen können. |
| Anzahl der Mitarbeiter | Nummer | Ein Nummernfeld, in dem Sie die Anzahl der Mitarbeiter erfassen können. |
| Wartungsvertrag | Liste | Eine Auflistung der verschiedenen Arten von Wartungsverträgen, die Sie anbieten. Die Liste muss [in der Ansicht Listen erstellt][3] sein. |
| Der Vertrag läuft ab | Datum | Ein Datumsfeld, in dem Sie das Ablaufdatum des Vertrags erfassen können. |
| Anwendung A; Anwendung B; Anwendung C | Kontrollkästchen | Drei Kontrollkästchen, womit Sie die Anwendungen kennzeichnen können, die der Kunde erworben hat. |

> [!NOTE]
> Die hinzugefügten Felder werden in der Registerkarte **Mehr** in der Ansicht Firma angezeigt. Um sie auf der Firmenkarte anzuzeigen, [geben Sie sie als *Felder auf Seite 1*][1] an.

### Benutzerdefinierte Felder für Verkäufe

Bei der Erstellung eines Verkaufs kann es hilfreich sein, die verkauften Produkte und deren Anzahl anzugeben.

Sie können dann die folgenden Felder zur Ansicht Verkauf hinzufügen:

| Feldname | Typ | Beschreibung |
|---|---|---|
| Produkt | Langer Text | Ein Textfeld, in das Sie den Namen des verkauften Produkts eingeben können. |
| Menge | Nummer | Ein Nummernfeld, in dem Sie die Anzahl der verkauften Einheiten erfassen können. |

> [!TIP]
> Hier können Sie auch ein Listenfeld verwenden, wenn Sie eine Liste der zu verkaufenden Produkte erstellt haben.

### Benutzerdefinierte Felder für Projekte

Sie möchten, dass das Budget zu einem Projekt für die Projektmitglieder gut sichtbar ist.

Sie können diese Felder dann der Ansicht Projekt hinzufügen:

| Feldname | Typ | Beschreibung | Anmerkungen |
|---|---|---|---|
| Budget | Dezimal | Ein Nummernfeld, in das Sie eine Summe eingeben können. | [Wählen Sie das auf Seite 1 anzuzeigende Feld aus][1]. |

## Verwandte Themen

* [Benutzerdefinierte Felder hinzufügen][2]

<!-- Referenced links -->
[1]: ../admin/edit-udef-layout.md#page-1
[2]: ../admin/add-udef.md
[3]: ../../admin/lists/learn/adding-user-defined-lists.md
[8]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->