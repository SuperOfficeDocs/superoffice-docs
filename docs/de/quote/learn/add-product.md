---
uid: help-de-quote-add-products
title: Produkte zum Angebot hinzufügen
description: Produkte zum Angebot hinzufügen
author: SuperOffice RnD
date: 07.04.2022
keywords: Angebot
topic: howto
language: de
---

# Produkte hinzufügen

Im Dialogfeld **Produkt hinzufügen/bearbeiten** können Sie ein Produkt hinzufügen und Menge, Rabatte sowie andere Produktinformationen festlegen.

## Ein Produkt hinzufügen

1. Öffnen Sie ein Angebot und klicken Sie unten in der Registerkarte **Produkte** (oder einer von Ihnen erstellten Alternative) auf **Hinzufügen**.

1. Doppelklicken Sie auf ein Produkt in dem Angebot.

1. Um eine bestimmten Preisliste zu durchsuchen, können Sie diese in der Liste neben dem Feld **Produktsuche** auswählen.

1. Geben Sie den Namen des Produkts oder den Produktcode in das Feld **Produktsuche** ein. Die Trefferliste wird automatisch aktualisiert. Sie können Produktnamen und Produktcodes komplett oder teilweise durchsuchen.

    > [!TIP]
    > Wenn die erweiterte Suche unterstützt wird, können Sie auf <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> im Suchfeld **Produktsuche** klicken und [mehrere Produkte gleichzeitig hinzufügen](#add-multiple).

1. Klicken Sie auf das Produkt, das Sie in die Liste aufnehmen möchten. Das Dialogfeld wird mit den Produktinformationen aktualisiert.

1. Fügen Sie bei Bedarf Produktmenge, Rabatt und Gesamtpreis hinzu. Für weitere Details siehe unten.

1. Lesen und bearbeiten Sie Produktinformationen in den Registerkarten **Beschreibung** und **Details**.

1. Klicken Sie auf **Speichern + neu**, um das Produkt zu speichern und ein neues Produkt hinzuzufügen.
    oder
    Klicken Sie auf **Speichern**, um das Produkt zu speichern und zum Angebot zurückzukehren.

## <a id="add-multiple"></a>Einem Angebot mehrere Produkte hinzufügen

1. Klicken Sie unten auf der Registerkarte **Produkte** im Dialogfeld **Angebot bearbeiten** auf **Hinzufügen**.

2. Geben Sie die ersten Zeichen eines Produktnamens in das Feld **Produktsuche** ein, um nach einem Produkt zu suchen. Klicken Sie auf <i class="ph ph-magnifying-glass" aria-label="Search icon"></i>, um mithilfe verschiedener Kriterien wie zum Beispiel Produktreihe, Produktgruppen/-kategorien, Name, Artikelnummer usw. nach Produkten zu suchen. Die Suche schließt alle aktiven Preislisten mit der entsprechenden Währung ein.

3. Nachdem Sie die Produkte gefunden haben, die Sie dem Angebot hinzufügen möchten, wählen Sie sie mit (**STRG+Klicken**) aus und klicken Sie dann auf **OK**. Die Produkte werden in der Registerkarte **Produkte** angezeigt (oder in der Registerkarte der Alternative, die Sie erstellt haben).

4. Doppelklicken Sie auf ein Produkt, um die Menge, Rabatte usw. zu ändern.

## Menge, Rabatte und Preise eines Produkts bearbeiten

Links im Dialogfeld **Produkt hinzufügen/bearbeiten** wird der Produktname/-code angezeigt. Hier können Sie auch Menge und Rabatte für das ausgewählte Produkt festlegen.

> [!TIP]
> Sie können weitere Informationen zu den verschiedenen Feldern (Feldname, bearbeitbares Feld und Berechnungen) anzeigen, indem Sie den Mauszeiger darauf positionieren.

* Zahlen, die schwarz angezeigt werden, können bearbeitet werden.
* Gesamtbetrag und Rabatte werden aktualisiert, während Sie die verschiedenen Felder bearbeiten.
* Ein Rabatt kann entweder als Prozentsatz, Rabattbetrag oder Gesamtbetrag angegeben werden.
  * Das Rabattfeld, das Sie bearbeitet haben, ist *unterstrichen*.
  * Die anderen Felder sind aktualisiert und entsprechen dem Rabatt, den Sie definiert haben.
  * Positionieren Sie den Mauszeiger über einem Rabattfeld, um Systemrabatte (wie zum Beispiel Mengenrabatte, die automatisch hinzugefügt werden) anzuzeigen.
* Wenn Sie Rabatte festgelegt haben, die vom System nicht toleriert werden, wird eine Warnung oder eine andere Mitteilung angezeigt.

## Registerkarte Bild

Hier wird ein Bild des Produktes dargestellt, wenn dies in Einstellungen und Verwaltung definiert wurde.

## Registerkarte Beschreibung

Hier werden detaillierte Produktinformationen angezeigt, wenn dies in Einstellungen und Verwaltung definiert wurde.

## Registerkarte Details

Hier werden ausführliche Preisberechnungen angezeigt. Der Inhalt dieser Registerkarte ist in Einstellungen und Verwaltung definiert.

## <a id="warning"></a>Warnungen und wie man damit umgeht

In Einstellungen und Verwaltung können verschiedene Regeln dafür erstellt werden, was erlaubt bzw. nicht erlaubt ist, wenn einem Angebot Produkte hinzugefügt werden. Je nach Definition dieser Regeln werden verschiedene Symbole/Warnungen angezeigt, wenn Sie einem Angebot Produkte hinzufügen. In einigen Fällen muss das [Angebot vor dem Senden genehmigen][1] werden.

> [!NOTE]
> Produkte werden einem Angebot hinzugefügt und dort gespeichert, auch wenn Warnungen und andere Nachrichten angezeigt werden. Sie können das Angebot jedoch nicht senden, solange es Fehler und Warnungen enthält. Sie müssen entweder den Fehler korrigieren oder das Angebot genehmigen lassen.

[!include[Table showing quote icons](includes/table-quote-icons.md)]

### Wo werden diese Warnungen und Meldungen angezeigt?

* Im Dialogfeld **Produkt hinzufügen/bearbeiten**
* Im Dialogfeld **Produkt bearbeiten**
* In den Produktzeilen in der Bereichsregisterkarte **Angebot** und der Registerkarte **Produkte** (und Alternativen) in einem Angebot

### Warum werden diese Warnungen und Meldungen angezeigt?

Warnungen und Meldungen werden beispielsweise aus folgenden Gründen angezeigt:

* Produkte nicht im Bereich
* Inaktive Preislisten
* Produktpreis ist unter Mindestpreis oder Kostenpreis
* Gesamtpreis ist Null oder im Minusbereich
* Gesamtrabatt ist zu hoch
* Gesamteinnahmen sind zu niedrig

<!-- Referenced links -->
[1]: approve.md
