---
uid: help-de-udef-add
title: Felder hinzufügen
description: Felder hinzufügen
keywords: udef, benutzerdefiniertes Feld, Feld-Eigenschaften
author: Bergfrid Dias
date: 09.06.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Benutzerdefiniertes Feld hinzufügen

Sehen Sie sich dieses Video an, um zu lernen, wie Sie Ihre eigenen Benutzerdefiniertes Felder in SuperOffice CRM erstellen können (Videolänge - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Schritte

1. [!include[Zu Felder gehen](includes/goto-tables.md)]

1. Klicken Sie unter der Liste **Felder** auf die Schaltfläche **Hinzufügen**.

1. Geben Sie einen **Namen** ein und wählen Sie einen [**Typ**][2] (zum Beispiel Zahl, Text oder Datum).

    Verwenden Sie ein [Sprachpräfix](#language), um den Namen in mehreren Sprachen anzugeben, wie folgt: `US:"Language";NO:"Språk"`

    ![UDEF-Feldname in mehreren Sprachen -screenshot][img3]

1. Setzen Sie optional andere [Feld-Eigenschaften](#properties), wie zum Beispiel, ob das Feld obligatorisch ist oder indiziert werden soll.

1. Wenn Sie fertig sind, klicken Sie auf **Speichern**. Das Dialogfeld wird geschlossen und das neue Feld wird in der Liste **Felder** und im Raster angezeigt.

1. [Optional können Sie die Position des Feldes anpassen][3]. Dies erfordert eine Lizenz für Development Tools!

1. Fahren Sie fort, Felder hinzuzufügen. Klicken Sie auf **Veröffentlichen**, wenn Sie fertig sind, um das Feld für SuperOffice-Benutzer verfügbar zu machen. Nicht veröffentlichte Felder ![Symbol][img1] und Felder mit nicht veröffentlichten Änderungen ![Symbol][img2] werden in Fettschrift in der Liste **Felder** angezeigt.

## <a id="properties"></a>Feld-Eigenschaften

| Eigenschaft | Beschreibung |
|---|---|
| Standardwert | Der Wert, der standardmäßig in dieses Feld eingetragen werden soll. |
| QuickInfo | Eine kurze Beschreibung, die angezeigt wird, wenn der Mauszeiger über dem Feld platziert wird. Zum Beispiel Informationen zur Verwendung. |
| Prog ID | Eine Standard-ID für dieses Feld. Das Format lautet **text:number**. Behalten Sie den Textteil bei Buchstaben a-z oder deren Großbuchstaben. Kann von SuperOffice-Partnern außer Kraft gesetzt werden. |
| Obligatorisch | Macht es obligatorisch, dieses Feld auszufüllen. Gilt nicht für den Feldtyp *Kontrollkästchen*. |
| Bezeichn. ausbl. | Wenn ausgewählt, wird der Name des Feldes nicht angezeigt. |
| Schreibgeschützt | Wenn ausgewählt, ist es nicht möglich, das Feld zu ändern. |
| Indiziert | Wenn ausgewählt, wird dieses Feld durchsuchbar und beschleunigt die **Suchen**. Nicht indizierte Felder können ebenfalls durchsucht werden, dies dauert jedoch länger. Indizieren Sie nur Felder, die häufig gesucht werden und häufig verwendete Daten enthalten. |

> [!NOTE]
> Sie können das Kontrollkästchen **Schreibgeschützt** nicht aktivieren, wenn Sie **Obligatorisch** aktiviert haben. Diese beiden Optionen schließen sich gegenseitig aus.

## <a id="language"></a>Sprachcodes

[!include[Sprachcodes](../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Wo werden die von mir erstellten Felder angezeigt?

* [Registerkarte Mehr (Firma)][16]
* [Registerkarte Mehr (Person)][17]
* [Registerkarte Mehr (Projekt)][13]
* [Registerkarte Mehr (Folgeaufgaben)][14]
* [Registerkarte Mehr (Dokument)][15]
* [Registerkarte Mehr (Verkauf)][19]

> [!TIP]
> Im unteren Teil rechts befindet sich im Dialogfeld **Felder** der **Vorlagenvariablenname**, gefolgt von einem Code (ID), mit dem die in diesem Feld die Information wiederverwenden können, wie zum Beispiel als [Vorlagenvariablen][12] in Dokumenten und E-Mails.

## Fehlerbehebung

### Ich kann kein neues Feld erstellen

Wenn Sie kein neues Feld erstellen dürfen, kann das daran liegen, dass Sie bereits die maximale Anzahl zulässiger Felder dieses Typs erreicht haben (siehe [Maximal zulässige Feldanzahl][1]). Sie müssen dann ein vorhandenes Feld löschen, bevor Sie ein neues einfügen können.

Vier von jedem Feldtyp (Kurzer Text, Langer Text, Nummer, Dezimalzahl) sind suchbar. Wenn Sie zum Beispiel keine Felder als suchbar markieren, können Sie nur sechs Dezimal-Felder angeben.

## Verwandte Themen

* [Felder platzieren][3]
* [Felder bearbeiten][4]
* [Ansichtsdesigner][11]

<!-- Referenced links -->
[1]: ../learn/udef.md#limit
[2]: ../learn/udef.md#field-types
[3]: edit-udef-layout.md
[4]: edit-udef.md
[11]: ../../ui/screen-designer/learn/index.md
[12]: ../../document/templates/learn/template-variables.md
[13]: ../../project/learn/index.md#more-tab
[14]: ../../diary/learn/follow-ups.md#more-tab
[15]: ../../document/learn/screen/index.md
[16]: ../../company/learn/create.md#more-tab
[17]: ../../contact/learn/create.md#more-tab
[19]: ../../sale/learn/index.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../media/icons/admin/fields-unpublish-changed.png
[img3]: ../../../media/loc/en/custom-objects/add-udef-multi-languages.png
