---
uid: help-de-screen-designer-edit-layout
title: Hauptkartenlayout bearbeiten
description: "In dieser Anleitung lernen Sie, wie Sie ein Layout bearbeiten können."
keywords: Ansichtsdesigner, Layout, Feld, Registerkarten-Layout
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: howto
language: de
audience: settings
audience_tooltip: Settings and maintenance
---

# Layout bearbeiten – Hauptkarten

Wenn Sie die Option [Neues Layout hinzufügen][4] ausgeführt haben, müssen Sie es gemäß den Anforderungen der zugewiesenen Benutzergruppe(n) anpassen. Wenn Sie ein Layout für das Verkaufsteam anpassen, sollten Sie die Bedürfnissen des Teams an das Layout und die Formatierung von Registerkarten, Feldern, Elementen und Spalten auf der Hauptkarte genau kennen. Welche Daten müssen zuerst und am einfachsten zu finden sein? Werden alle Felder und Registerkarten benötigt? Wie sollten die Felder logisch angeordnet werden?

Personalisieren Sie das Layout für die Hauptkarten und Archive, um den Informationsanforderungen Ihrer Organisation zu erfüllen. Wenn Sie das Layout auf einer Hauptkarte bearbeiten, können Sie Felder hinzufügen und entfernen oder die Reihenfolge an die Anforderungen Ihres Teams anpassen. Zunächst müssen Sie wissen, welche Informationen für das Team am wichtigsten sind.

Sehen Sie sich dieses Video an, um herauszufinden, wie Sie mit dem Ansichtsdesigner Ihre Anzeigen in SuperOffice CRM konfigurieren, oder folgen Sie der Schritt-für-Schritt-Anleitung unten (Videolänge - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## Schritte

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Klicken Sie auf **Hauptkarten**.

4. Wählen Sie in der Liste links ein Layout aus.

5. Klicken Sie unter der Vorschau auf **Layout bearbeiten**.

6. Bearbeiten Sie wie unten beschrieben im Fenster **Kartenlayout bearbeiten** das Layout.

7. Klicken Sie danach auf eine der folgenden Schaltflächen:

    * **Entwurf speichern**: Klicken Sie auf diese Schaltfläche, wenn das Layout noch nicht ganz fertiggestellt ist.
    * **Speichern + Veröffentlichen**: Klicken Sie auf diese Schaltfläche, wenn Sie das Layout für die ausgewählten Benutzergruppen veröffentlichen wollen.
    * **Abbrechen**: Klicken Sie auf die diese Schaltfläche, damit Sie [alle Änderungen verwerfen](#undo-changes) können.
<!-- markdownlint-restore -->

## Vorhandene Felder im Layout bearbeiten

1. Wählen Sie die zu bearbeitende Registerkarte aus.

2. Sie können vorhandene Felder bearbeiten:

    * Verschieben Sie Felder, indem Sie links neben einer Feldbezeichnung auf ![Symbol][img4] klicken und das Feld an eine neue Position ziehen. Zum Hinzufügen eines neuen Felds siehe [Felder](#fields).

    * Löschen Sie Felder, indem Sie den Mauszeiger über ein Feld bewegen und auf ![Symbol][img2] klicken. Gelöschte Felder können vom Bereich **Felder** aus wieder hinzugefügt werden. Obligatorische Felder können nicht gelöscht werden, d. h. die Schaltfläche **Löschen** wird für solche Felder nicht angezeigt. Siehe [Felder](#fields).

    * Die Feldformatierung (z. B. das Schriftformat) und andere Einstellungen bearbeiten Sie, indem Sie auf das Feld klicken. Im linken Teil des Fensters öffnet sich der Bereich **Einstellungen**. Siehe [Einstellungen](#settings).

3. Vom Bereich **Registerkarten-Layout** die [Spaltenanzahl in einer Registerkarte ändern](#columns).

4. Speichern Sie die Änderungen wie oben erläutert.

![Entfernen, verschieben und fügen Sie verschiedene Felder im Layout hinzu -screenshot][img3]

## Neuen Inhalt zu einem Layout hinzufügen

1. Wählen Sie die zu bearbeitende Registerkarte aus oder klicken Sie auf ![Symbol][img5] **Hinzufügen**, damit Sie eine [neue Registerkarte hinzufügen](#tabs) können.

2. Wählen Sie zum Bearbeiten des Layouts einen der folgenden Bereiche aus:

    * **Felder**: Ziehen Sie [Felder](#fields) aus der Liste in das Layout. Felder können in den Spalten und in der Kopf- und Fußzeile positioniert werden.

    * **Elemente**: Ziehen Sie verschiedene Elemente wie Bezeichnungen, Trennelemente, Links und Schaltflächen in das Layout.

    * **Einstellungen**: Klicken Sie im Layout auf ein Feld oder Element, um die betreffenden Einstellungen zu bearbeiten. Welche Einstellungen verfügbar sind, hängt vom ausgewähltem Objekt ab. Siehe [Einstellungen](#settings).

    * **Registerkarten-Layout**: [Wählen Sie die Anzahl der Spalten aus, die in einer Registerkarte angezeigt werden sollen](#columns).

3. Klicken Sie nach der Anpassung der Ansicht Layout auf eine der folgenden Schaltflächen:

    * **Entwurf speichern**: Klicken Sie auf diese Schaltfläche, wenn das Layout noch nicht ganz fertiggestellt ist.
    * **Speichern + Veröffentlichen**: Klicken Sie auf diese Schaltfläche, wenn Sie das Layout für die ausgewählten Benutzergruppen veröffentlichen wollen.
    * **Abbrechen**: Wenn Sie auf diese Schaltfläche klicken, werden alle Änderungen verworfen.

Kästchen mit gestrichelten Linien im Layout geben an, wo Sie ein Feld positionieren können:

![Kästchen mit gestrichelten Linien -screenshot][img6]

Im Folgenden finden Sie detailliertere Informationen zu den verschiedenen Bereichen und Funktionen.

## <a id="fields"></a>Felder

Im Bereich **Felder** finden Sie alle verfügbaren Datenfelder für das ausgewählte Ansichtslayout. Suchen Sie bestimmte Felder mithilfe der Filterfunktion.

* Ziehen Sie ein Feld aus der Liste in einen gestrichelten Bereich auf der ausgewählten Registerkarte.
* Um sicherzustellen, dass ein Feld unabhängig von der ausgewählten Registerkarte immer angezeigt wird, stellen Sie das Feld in die Kopf- oder Fußzeile.
* Bei Bedarf können Sie dasselbe Feld an mehreren Stellen im Ansichtslayout platzieren.
* Verschieben Sie Felder, indem Sie links neben einer Feldbezeichnung auf ![Symbol][img4] klicken und das Feld an eine neue Position ziehen. Wenn ein Feld in eine andere Registerkarte verschoben werden soll, ziehen Sie das Feld zum Öffnen der Registerkarte in deren Kopfzeile und legen das Feld dann in der geöffneten Registerkarte ab.
* Löschen Sie Felder, indem Sie den Mauszeiger über ein Feld bewegen und auf ![Symbol][img2] klicken. Obligatorische Felder können nicht gelöscht werden, d. h. die Schaltfläche **Löschen** wird für solche Felder nicht angezeigt.

**Einschränkungen:**

* Obligatorische Felder können nicht gelöscht werden. Dies wird in der Ansicht [Felder][3] festgelegt.
* Einige Registerkarten wie **ERP** und **Notiz** können nicht bearbeitet werden, weil sie bestimmte Funktionen haben.

## Elemente

Im Bereich **Elemente** können Sie verschiedene Elemente, die keine Daten enthalten, wie Bezeichnungen, Trennelemente, Links und Schaltflächen hinzufügen.

## <a id="settings"></a>Einstellungen

Sie können Felder hervorheben, indem Sie die Schrift in Fettdruck ändern und die Schriftgröße vergrößern. Mit einer kleineren Schrift haben Sie Platz für mehr Felder. Sparen Sie Platz auf der Ansicht, indem Sie Bezeichnungen ausblenden.

Klicken Sie im Layout auf ein Feld oder Element, wenn Sie dessen Einstellungen bearbeiten wollen. Welche Einstellungen verfügbar sind, hängt vom Typ des Feldes bzw. Elements ab.

## <a id="columns"></a>Registerkarten-Layout

Standardmäßig ist eine Registerkarte in 2 Spalten unterteilt, aber Sie können ganz nach Bedarf 1-4 Spalten verwenden. Benutzer mit breiten Anzeigen bevorzugen möglicherweise mehr Spalten, um mehr Daten anzeigen und sortieren zu können.

**Einschränkungen:**

* Beim Ändern des Layouts von 2-4 Spalten in 1 Spalte werden alle Felder in 1 Spalte verschoben.
* Wenn Sie 4 Spalten wählen, sind manche Felder möglicherweise nicht gut zu sehen. In diesem Fall können Sie die Bezeichnungen einiger Felder ausblenden (siehe [Einstellungen](#settings)).
* Für manche Registerkarten, wie z. B. **ERP** und **Notiz**, gibt es keine Spaltenkonfiguration, weil sie bestimmte Funktionen haben.
* Wenn ein Benutzer nicht die Anzeigegröße für alle Spalten hat, werden sie übereinandergestapelt.

## <a id="tabs"></a>Registerkarten

Sie können weitere Registerkarten für zusätzliche Felder hinzufügen oder nicht benötigte Registerkarten entfernen.

**So entfernen Sie eine Registerkarte:**

1. Wählen Sie die Registerkarte aus und klicken Sie auf **Aufgabe** > **Registerkarte entfernen**.
2. Klicken Sie im angezeigten Dialogfeld auf **OK**.

**So fügen Sie eine neue Registerkarte hinzu:**

1. Klicken Sie auf das ![Symbol][img5] **Hinzufügen**. Der Bereich **Registerkarten-Layout** wird auf der linken Seite geöffnet.
2. Ersetzen Sie in **Registerkartentitel** den Text **Neue Registerkarte** durch den neuen Namen für die Registerkarte.
3. Sie können auch auf das ![Symbol][img1] klicken, damit Sie die [Registerkarte Name in anderen Sprachen hinzufügen][2] können.
4. Wählen Sie die Spaltenanzahl für die neue Registerkarte aus.

> [!TIP]
> Wählen Sie die Registerkarte und dann **Registerkarten-Layout** aus, wenn Sie die Registerkarte später umbenennen möchten.

**Einschränkungen:**

* Die Standardregisterkarten lassen sich nicht umbenennen.
* Sie können keine Registerkarte entfernen, die obligatorische Felder enthält. Obligatorische Felder müssen zuerst auf eine andere Registerkarte verschoben werden.
* Wenn nur noch eine Registerkarte übrig ist, können Sie sie nicht löschen.

## <a id="undo-changes"></a>Änderungen rückgängig machen

Wenn Sie wieder eine frühere Version der Ansicht nutzen möchten, stehen über die Schaltfläche **Aufgabe** folgende Optionen zur Verfügung:

* **Auf werkseitige Einstellung zurücksetzen**: Mit dieser Option werden alle Änderungen verworfen und das Ansichtslayout auf das von SuperOffice bereitgestellte Standardlayout zurückgesetzt.
* **Entwurf verwerfen**: Alle Änderungen werden verworfen und die veröffentlichte Version des Ansichtslayouts wird wiederhergestellt.

<!-- Referenced links -->
[2]: ../../../globalization-and-localization/learn/translate-fields.md
[3]: ../../../custom-objects/learn/udef.md
[4]: add-layout.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../../common/icons/delete-circle-red.png
[img4]: ../../../../media/icons/criteria-move.png
[img5]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png
[img6]: ../../../../media/loc/en/ui/screendesigner-field-place.png
