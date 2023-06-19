---
uid: help-de-udef-add
title: Felder hinzufügen
description: Felder hinzufügen
author: SuperOffice RnD
so.date: 02.23.2023
keywords: udef, Benutzerdefiniert, benutzerdefiniertes Feld
so.topic: howto
so.user: admin
so.user.tooltip: Settings and maintenance
language: de
---

# Benutzerdefiniertes Feld hinzufügen

Sehen Sie sich dieses Video an, um zu lernen, wie Sie Ihre eigenen Zusatzfelder in SuperOffice CRM erstellen können (Videolänge - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Schritte

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Klicken Sie unter der Liste **Felder** auf die Schaltfläche **Hinzufügen**.

1. Geben Sie den gewünschten Namen im Feld **Name** ein.

1. Wählen Sie im Listenfeld **Typ** den [Feldtyp][6] aus, den Sie hinzufügen möchten (zum Beispiel Zahl, Text oder Datum).

1. Geben Sie im Feld **Standardwert** den Wert ein, der standardmäßig in dieses Feld eingetragen werden soll.

1. Geben Sie im Feld **QuickInfo** eine kurze Beschreibung ein, die eingeblendet wird, wenn der Mauszeiger über dem Feld platziert wird. Dabei könnte es sich um eine Beschreibung mit Informationen für die Benutzer handeln, die dieses Feld verwenden.

1. Das Feld **Prog ID** enthält eine Standard-ID für dieses Feld. Die Prog ID kann von unseren Partnern für eine bessere Verbindung mit den Partneranwendungen überschrieben werden. Sie können, anstatt ihren Code zu ändern, einen sinnvolleren Namen oder eine bestimmte ID für ein benutzerdefiniertes Feld (UDEF) eingeben.

1. Aktivieren Sie die Option **Obligatorisch**, wenn eine Eingabe in dieses Feld obligatorisch sein soll.

    > [!NOTE]
    > Dies gilt nicht für den Feldtyp **Kontrollkästchen**.

1. Aktivieren Sie die Option **Bezeichn. ausbl.**, wenn Sie nicht möchten, dass der Name des Felds angezeigt wird.

1. Aktivieren Sie die Option **Schreibgeschützt**, wenn Sie eine Eingabe im Feld nicht zulassen möchten.

    > [!NOTE]
    > Sie können das Kontrollkästchen **Schreibgeschützt** nicht aktivieren, wenn Sie **Obligatorisch** aktiviert haben. Diese beiden Optionen schließen sich gegenseitig aus.

1. Aktivieren Sie die Option **Indiziert**, wenn eine Suche nach diesem Feld möglich sein soll.

1. Wenn Sie die gewünschten Einstellungen vorgenommen haben, klicken Sie auf **Speichern**. Das Dialogfeld wird geschlossen und das neue Feld wird in der Liste **Felder** und im Raster angezeigt.

    > [!TIP]
    > Im unteren Teil rechts befindet sich im Dialogfeld **Felder** der **Vorlagenvariablenname**, gefolgt von einem Code (ID), mit dem die in diesem Feld die Information wiederverwenden können, wie zum Beispiel als [Vorlagenvariablen][2] in Dokumenten und E-Mails.

1. [Passen Sie die Position des Feldes an][3].

1. Klicken Sie auf **Veröffentlichen**, wenn das Feld für SuperOffice CRM-Benutzer verfügbar sein soll. Nicht veröffentlichte Felder ![Symbol][img1] und Felder mit nicht veröffentlichten Änderungen ![Symbol][img2] werden in der Liste **Felder** in Fettschrift angezeigt.

## Warum ist eine Indexierung sinnvoll?

Wenn Sie **Indiziert** auswählen, können Sie diese Felder mithilfe von **Suchen** schneller suchen. Felder ohne Indexierung können auch gesucht werden, die Suche dauert jedoch länger. Sie sollten nur Felder indizieren, die häufig gesucht werden und häufig verwendete Daten enthalten.

## Fehlerbehebung

### Ich kann kein neues Feld erstellen

Wenn Sie kein neues Feld erstellen dürfen, kann das daran liegen, dass Sie bereits die maximale Anzahl zulässiger Felder dieses Typs erreicht haben (siehe [Maximal zulässige Feldanzahl][1]). Sie müssen dann ein vorhandenes Feld löschen, bevor Sie ein neues einfügen können.

Vier von jedem Feldtyp (Kurzer Text, Langer Text, Nummer, Dezimalzahl) sind suchbar. Wenn Sie zum Beispiel keine Felder als suchbar markieren, können Sie nur sechs Dezimal-Felder angeben.

## Verwandte Themen

* [Felder platzieren][3]
* [Felder bearbeiten][4]
* [TAB-Reihenfolge der Felder bearbeiten][5]
* [Maximale Feldanzahl][1]
* [Ansichtsdesigner][7]

<!-- Referenced links -->
[1]: limitations.md
[2]: ../../../document/learn/template-variables.md
[3]: move.md
[4]: edit.md
[5]: change-tab-order.md
[6]: index.md#field-types
[7]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced links -->
[img1]: ../../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../../media/icons/admin/fields-unpublish-changed.png
