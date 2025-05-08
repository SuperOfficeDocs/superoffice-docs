---
uid: help-de-quote-send
title: Angebot senden
description: Erfahren Sie, wie Sie Angebote in SuperOffice CRM senden, genehmigen und versionieren.
keywords: Angebot senden, Angebot genehmigen, gesendetes Angebot bearbeiten, senden, veröffentlichen, Genehmigung, Angebotsversion, Registerkarte Anhänge, Angebot
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
topic: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Angebot senden

Nachdem Sie Produkte hinzugefügt und ein Angebotsdokument erstellt haben, können Sie das Angebot an den Kunden senden. Das Angebot wird als **Gesendet** markiert und kann nicht mehr bearbeitet werden.

## Angebot vorbereiten

1. Wechseln Sie zur Bereichsregisterkarte **Angebot** im Verkauf und klicken Sie auf **Öffnen**, um das Angebot zu bearbeiten.

1. Stellen Sie Folgendes sicher:

    * Alle erforderlichen Produktangaben sind ausgefüllt.
    * Das Angebotsdokument wurde erstellt.
    * Falls erforderlich, sind relevante Anhänge auf der Registerkarte **Anhänge** ausgewählt.
    * Die richtige Alternative ist als **favorisierte Alternative** markiert.
    * Es liegen keine [Warnungen oder Fehler][4] vor.

> [!NOTE]
> Sie können kein Angebot senden, wenn es Warnungen, Fehler oder eine Genehmigung erfordert. Die Schaltfläche **Senden** ist deaktiviert, bis alles behoben wurde.

## <a id="approve"></a>Genehmigung erforderlich?

Einige Angebote müssen vor dem Senden genehmigt werden, z. B. wenn die Einnahmen zu niedrig oder die Rabatte zu hoch sind. Genehmigungsregeln werden in Einstellungen und Verwaltung pro Verkaufstyp definiert (**Listen** > **Verkauf – Typen, Phasen, Angebot**).

* Erfordert ein Angebot Genehmigung, erhält es den Status **Genehmigung erforderlich**
* In der Dialogbox **Angebot bearbeiten** erscheint ein Banner mit Warnsymbolen

### So genehmigen Sie ein Angebot

1. Ein Benutzer mit Genehmigungsrechten öffnet das Angebot.

1. Klicken Sie auf **Genehmigen** oder **Ablehnen**.

1. Der Status wird zu **Genehmigt** (<i class="ph ph-check-square" aria-hidden="true"></i>) oder **Abgelehnt** (<i class="ph ph-x-square" aria-hidden="true"></i>).

## <a id="send"></a>So senden Sie das Angebot

1. Klicken Sie im Dialogfeld **Angebot bearbeiten** auf **Senden**.

    Das Dialogfeld **Ein Angebot veröffentlichen/senden** wird geöffnet.

    ![Dialogfeld Angebot senden -screenshot][img1]

2. Passen Sie im Feld **Gültig bis** bei Bedarf das Ablaufdatum an (Standard: 30 Tage).

3. Wählen Sie das **Angebotslayout** (Vorlage) und die **Sprache**.

4. Bei mehreren Alternativen können Sie **Nur bevorzugte Alternative verwenden** auswählen, um nur diese aufzunehmen. Ansonsten werden alle Alternativen in das Angebot einbezogen.

5. Im Abschnitt **Veröffentlichen** wählen Sie:

    * **Senden als E-Mail und als PDF archivieren** (eine E-Mail-Vorlage muss ausgewählt werden)
    * **Nur als PDF archivieren** (manuelles Versenden erforderlich)

6. (Optional) Aktivieren Sie **Folgeaufgabe erstellen**, geben Sie eine Notiz ein und wählen Sie ein Datum.

7. Klicken Sie auf **Vorschau**, um das Angebot als PDF zu prüfen.

8. Klicken Sie auf **OK**, um das Angebot zu senden und/oder zu archivieren.

    Beim Versand per E-Mail öffnet sich das Dialogfeld **Neue E-Mail**.

### Nach dem Senden

* Das Angebot erhält den Status **Gesendet**
* Die aktuelle Version ist gesperrt
* Der Status enthält das Ablaufdatum (*Gesendet (Gültig bis – 03.05.2025)*)
* Das Symbol wechselt von <i class="ph ph-pencil-simple" aria-label="Entwurf-Symbol"></i> zu einem Umschlag (<i class="ph ph-envelope" aria-label="Gesendet-Symbol"></i>)
* Die PDF-Datei wird in der Registerkarte **Aktivitäten** archiviert

    ![Angebotsregister nach Versand -screenshot][img2]

## <a id="versions"></a>Gesendetes Angebot bearbeiten

Ein gesendetes Angebot ist schreibgeschützt. Um es zu ändern (es zum Beispiel als Antwort auf eine Kundenanfrage), müssen Sie eine neue Version erstellen.

1. Klicken Sie auf **Öffnen** in der Registerkarte **Angebot**.
2. Klicken Sie im Dialogfeld **Angebot bearbeiten** auf **Bearbeiten**.
3. Eine neue Version mit Status **Entwurf** wird erstellt. Die vorherige Version wird archiviert (<i class="ph ph-folder-simple" aria-hidden="true"></i>).

Verwenden Sie das Dropdown-Menü **Version**, um zwischen den Versionen zu wechseln.

> [!TIP]
> Änderungen an der neuen Version wirken sich nicht auf das Original aus. Sie müssen die neue Version erneut senden.

## Verwandte Inhalte

* [Angebotsdokument erstellen][1]
* [Angebotsdokument ersetzen][2]
* [Auftrag erteilen][3]
* [Genehmigungsregeln konfigurieren][5] in Einstellungen und Verwaltung

<!-- Referenced links -->
[1]: create-quote-document.md
[2]: create-quote-document.md#replace
[3]: place-order.md
[4]: create.md#warning
[5]: ../../admin/sale-type.md#quote-fields

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/send-quote-dialog.png
[img2]: ../../../../media/loc/en/sale/sent-quote.png
