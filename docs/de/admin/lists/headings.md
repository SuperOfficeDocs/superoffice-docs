---
uid: help-de-list-headings
title: Listenüberschriften
description: Verwenden Sie Überschriften, um Elemente in langen Listen unter Einstellungen und Verwaltung zu gruppieren.
keywords: Überschrift, Liste organisieren
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Einstellungen und Verwaltung
index: true
redirect_from:
  - /de/admin/lists/learn/organize/index
  - /de/admin/lists/learn/organize/headings
  - /de/admin/lists/learn/organize/adding-headings
  - /de/admin/lists/learn/organize/headings-editing-and-deleting
  - /de/admin/lists/learn/organize/grouping-items-under-headings
language: de
---

# Listenüberschriften

Listenobjekte können auf zwei Ebenen angezeigt werden. Die übergeordnete Ebene wird als **Überschrift** des Objekts bezeichnet. Eine Überschrift enthält Objektgruppen, die unter dem ausgewählten Objekt in SuperOffice CRM angezeigt werden können. Dieselben Objekte können unter mehreren Überschriften angezeigt werden.

Die Liste **Überschriften** (unten rechts im Fenster **Listen**) zeigt an, unter welchen Überschriften die einzelnen Objekte angezeigt werden. Sie können auch die Registerkarte **Überschriften** öffnen, um zu sehen, welche Objekte unter einer bestimmten Überschrift erscheinen.

## Wann ist es sinnvoll, Überschriften in Listen zu verwenden?

Wenn eine Liste sehr lang ist (eine große Anzahl von Objekten enthält), können Sie Überschriften verwenden, um die Objekte logisch zu gruppieren. Zum Beispiel sind die Objekte in der Liste **Dokumentvorlagen** unter den Überschriften **Brief**, **Fax**, **E‑Mail** usw. gruppiert.

## Arbeiten mit Überschriften in Listen

Um Überschriften zu verwalten, öffnen Sie die Ansicht **Listen** und wählen Sie die gewünschte Liste aus dem Dropdown-Menü in der oberen linken Ecke.

> [!NOTE]
> Überschriften sind nur für Listen verfügbar, bei denen **Gruppieren und Filtern nach Benutzergruppe für diese Liste verwenden** aktiviert ist (Kontrollkästchen oben rechts).
>
> Die Gruppierungsfunktion ist bei bestimmten vordefinierten Listen (z. B. **Allgemein – Benutzergruppe**) nicht verfügbar. Wenn eine Liste nicht gruppiert werden kann, ist das Kontrollkästchen deaktiviert.

Es gibt zwei Möglichkeiten, Überschriften zuzuweisen:

* **In der Registerkarte Elemente**: Wählen Sie ein Listenobjekt aus und weisen Sie ihm eine oder mehrere Überschriften zu.
* **In der Registerkarte Überschriften**: Wählen Sie eine Überschrift aus und bestimmen Sie, welche Objekte unter ihr angezeigt werden sollen.

Sie können Überschriften auch bei Bedarf hinzufügen, bearbeiten oder löschen.

## <a id="add"></a>Überschrift hinzufügen

Bevor Sie eine Überschrift mit einem Objekt verknüpfen können, müssen Sie die erforderlichen Überschriften hinzufügen.

1. Gehen Sie zur Registerkarte **Überschriften**.

1. Klicken Sie unter der Liste **Überschriften** auf **Hinzufügen**, um eine neue Überschrift zu erstellen.

1. Geben Sie im Dialogfeld den Namen der Überschrift *(Pflichtfeld)* und eine Beschreibung *(optional)* ein.

    * Das Feld **Beschreibung** kann verwendet werden, um den Zweck der Überschrift zu erläutern und kann als Tooltip im Benutzerinterface erscheinen.

1. [!include[Save or cancel](includes/save-or-cancel.md)]

Die Überschrift wird der Liste **Überschriften** hinzugefügt. Wiederholen Sie den Vorgang, um weitere Überschriften hinzuzufügen.

Nachdem Sie die Überschriften hinzugefügt haben, können Sie [festlegen, unter welchen Überschriften die einzelnen Objekte angezeigt werden sollen](#group).

## <a id="group"></a>Objekte unter Überschriften gruppieren

Wenn Sie eine Liste mit zwei Ebenen verwenden möchten, müssen Sie für jedes Objekt in der Liste **Objekte** Überschriften auswählen. Alternativ können Sie auf der Registerkarte **Überschriften** festlegen, welche Objekte unter welcher Überschrift angezeigt werden sollen.

> [!NOTE]
> Die Liste muss eine bestimmte Mindestanzahl von Objekten enthalten, damit sie auf diese Weise angezeigt werden kann. Diese Zahl ist in den [Benutzereinstellungen][3] definiert.

### Überschriften für ein Listenobjekt auswählen

Alle Überschriften, die bereits für die ausgewählte Liste definiert sind, werden unten rechts im Bereich **Überschriften** angezeigt. Wenn dieser Bereich leer ist, müssen Sie [zuerst Überschriften hinzufügen](#add).

1. Wählen Sie das gewünschte Objekt in der Liste **Objekte** aus.

1. Aktivieren Sie das Kontrollkästchen neben der gewünschten Überschrift in der Liste **Überschriften**, um festzulegen, dass das ausgewählte Objekt unter dieser Überschrift angezeigt wird. Das Kontrollkästchen wird mit einem Häkchen (<i class="ph ph-check" aria-hidden="true"></i>) markiert.
    Die Änderungen werden automatisch gespeichert.

> [!TIP]
> Sie können einem Objekt mehrere Überschriften zuweisen.

### Listenobjekte für eine Überschrift auswählen

1. Wechseln Sie zur Registerkarte **Überschriften**.

1. Wählen Sie eine Überschrift in der Liste aus.

1. In der Liste **Objekte unter dieser Überschrift** aktivieren Sie die Kontrollkästchen neben den Objekten, die unter der ausgewählten Überschrift angezeigt werden sollen.

1. Wiederholen Sie diesen Vorgang für jede Überschrift.

    Die Änderungen werden automatisch gespeichert.

## <a id="update"></a>Überschriften bearbeiten

Doppelklicken Sie auf die gewünschte Überschrift in der Liste **Überschriften** und bearbeiten Sie die Informationen.

## Überschriften löschen

Markieren Sie die zu löschende Überschrift in der Liste **Überschriften** und klicken Sie auf **Löschen**.

> [!NOTE]
> Das Löschen einer Überschrift entfernt **nicht** die zugehörigen Listenobjekte. Sie können [gelöschte Überschriften wiederherstellen][2].

<!-- Referenzierte Links -->
[2]: restore.md
[3]: ../preferences/index.md
