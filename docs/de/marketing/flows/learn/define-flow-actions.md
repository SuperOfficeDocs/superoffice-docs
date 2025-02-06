---
uid: help-de-flow-actions
title: Flow-Aktionen definieren
description: Flow-Aktionen definieren
keywords: Marketing, Flow, Flow-Aktion, Teilnehmer aktualisieren, Nachricht senden, Skript ausführen
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Flow-Aktionen definieren

## Verfügbare Aktionen

* [Nachricht senden](#send)
* [Teilnehmer aktualisieren](#update)
* [Aktivität erstellen](#create)
* [Interne Aktionen](#internal)

> [!NOTE]
> Wenn Sie Flow-Aktionen hinzufügen oder aktualisieren, beachten Sie, dass auch Formulare und verfolgte Links Aktionen haben. Sie sollten sicherstellen, dass keine doppelten oder widersprüchlichen Aktionen vorhanden sind. Wir empfehlen, alle Aktionen an einem Ort einzubeziehen, entweder im Formular oder im Flow.

## <a id="send"></a>Nachricht senden

Dinge, die zu beachten sind:

* Wie oft sollten wir neue Informationen senden?
* Sollte die nächste E-Mail basierend auf dem Engagement des Persons, beim Ausfüllen eines Formulars oder beim Klicken auf einen überwachten Link versendet werden?
* Sollten alle Persone denselben Inhalt erhalten?

### E-Mail senden (Kampagne)

Ein E-Mail-Schritt wird verwendet, um eine E-Mail an einen aktiven Flow-Teilnehmer zu senden. Sie können eine bereits vorbereitete E-Mail auswählen oder eine neue hinzufügen.

1. Ziehen Sie das **E-Mail senden**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.

    > [!NOTE]
    > Wenn Sie einen E-Mail-Schritt hinzufügen, müssen Sie die E-Mail-Einstellungen angeben, bevor Sie den Flow starten. Sie sehen ein Warnsymbol (wie im Screenshot unten), wenn diese Einstellungen fehlen. Sie können den Flow dennoch speichern! Entwerfen Sie den Flow einfach weiter und kehren Sie später zu den E-Mail-Einstellungen zurück.

1. Wählen Sie eine der Optionen:

    * Neue E-Mail für diesen Schritt erstellen. Geben Sie einen Namen ein und klicken Sie auf **Erstellen**. Dies öffnet den Kampagne-Assistenten im **Vorlagen**-Schritt.
    * Vorhandene E-Mail für diesen Schritt auswählen. Klicken Sie, um Flow-Inhalte auszuwählen.

1. Geben Sie den **Betreff** der E-Mail ein. Kontaktvariablen (Merge-Tags) sind verfügbar.

1. Fügen Sie optional einen oder mehrere Anhänge hinzu (max. 25 MB insgesamt).

![E-Mail-Schritt zum Flow hinzufügen -screenshot][img1]

> [!NOTE]
> Das Erstellen einer neuen E-Mail als Flow-Inhalt ist nur innerhalb der Flow-UI möglich.

### SMS senden

Ein SMS-Schritt wird verwendet, um eine SMS an einen aktiven Flow-Teilnehmer zu senden.

Flow-Teilnehmer ohne registrierte Telefonnummer können entweder den Schritt überspringen (zum nächsten Schritt weitergehen) oder den Flow verlassen, abhängig von den Schritteinstellungen.

1. Ziehen Sie das **SMS senden**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.

1. Geben Sie den Absender und den SMS-Text ein. Kontaktvariablen (Merge-Tags) sind verfügbar.

1. Wählen Sie optional **Flow verlassen, wenn keine Mobiltelefonnummer registriert ist** und wählen Sie, wie Kontakte behandelt werden sollen, die die SMS nicht erhalten können.

> [!TIP]
> Wenn Sie nur eine SMS senden möchten, achten Sie auf den Zähler in der unteren rechten Ecke. Wenn die Anzahl der Zeichen 160 überschreitet, wird die Nachricht als mehrere SMS-Segmente gesendet und zusätzliche Kosten können anfallen. Wir empfehlen, die Nachricht kurz und informativ zu halten.

## <a id="update"></a>Teilnehmer aktualisieren

* Person aktualisieren
* Zur Selektion/Projekt hinzufügen
* Aus Selektion/Projekt entfernen

### Person aktualisieren

Verwenden Sie diesen Schritt, um relevante Daten zu einem Person oder dessen Firma zu aktualisieren, bevor der Teilnehmer zum nächsten Schritt im Flow übergeht.

1. Ziehen Sie das **Person aktualisieren**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
1. Wählen Sie ein Feld zur Aktualisierung in der **Feld**-Spalte. Sie können den Namen auch in das Feld eingeben. Während Sie jeden Buchstaben eingeben, zeigt die Liste unten relevante Übereinstimmungen.
1. Wählen Sie eine Aktion in der **Aktion**-Spalte. Die [verfügbaren Aktionen][11] hängen von der Art des Feldes ab, das Sie im vorherigen Schritt ausgewählt haben.
1. Geben Sie gegebenenfalls neue Werte an.
1. Um zusätzliche Felder zu aktualisieren, klicken Sie auf **Hinzufügen** und wiederholen Sie die Schritte 2-4.
1. Stellen Sie sicher, dass alle Felder, die Sie aktualisieren möchten - und nur diese - ein Häkchen haben. Sie können auf das rote X klicken, um überflüssige Zeilen zu entfernen.

![Persondaten im Flow aktualisieren -screenshot][img2]

Dies funktioniert ähnlich wie das [Massenabgleich][11].

### Zur Selektion/Projekt hinzufügen

Behalten Sie den Überblick über diejenigen, die sich angemeldet oder engagiert haben, oder verfolgen und folgen Sie später nach. Der Person wird als Mitglied der angegebenen Selektion und/oder des Projekts hinzugefügt.

1. Ziehen Sie das **Zur Selektion und/oder zum Projekt hinzufügen**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
1. Fügen Sie den Person zur statischen Selektion hinzu: Wählen Sie eine statische Person-Selektion aus der Liste oder klicken Sie auf **Neu**, um eine neue zu erstellen.
1. Fügen Sie den Person als Projektmitglied hinzu: Wählen Sie ein Projekt aus der Liste.

> [!TIP]
> Beginnen Sie mit der Eingabe, um eine Liste zu durchsuchen.

### Aus Selektion/Projekt entfernen

Der Person wird als Mitglied aus der angegebenen Selektion und/oder dem Projekt entfernt.

Dieser Schritt ähnelt dem Schritt **Zur Selektion und/oder zum Projekt hinzufügen**.

## <a id="create"></a>Aktivität erstellen

Der Flow kann automatisch eine Folgeaufgabe, Anfrage und/oder einen Verkauf beim Person gemäß den Einstellungen erstellen. Durch die Verknüpfung von CRM-Aktivitäten und Benachrichtigungen kann Ihre Organisation die Lücke zwischen Marketing und Vertrieb schließen. Das Erstellen von Aktivitäten ermöglicht es Ihnen auch, sich auf engagierte Persone zu konzentrieren.

### Folgeaufgabe erstellen

Beispiel: Richten Sie eine kostenlose Beratung zum ersten verfügbaren Zeitpunkt im Kalender unseres Kontakts ein. Sie werden im **Benachrichtigungs**-Panel benachrichtigt.

1. Ziehen Sie das **Folgeaufgabe erstellen**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
1. Geben Sie einen Titel ein.
1. Wählen Sie einen Folgeaufgabestyp aus.
1. Geben Sie ein Fälligkeitsdatum für eine Aufgabe an oder reservieren Sie die erste verfügbare Zeit für ein Meeting.
1. Zuweisen an: Wählen Sie aus, wer den Teilnehmer nachverfolgen soll: "Unser Kontakt" oder "Unser Service-Kontakt", oder ein spezifisch benannter Mitarbeiter.
1. Geben Sie optional weitere Informationen ein. Weitere Details finden Sie in der [Liste der Schritt-Einstellungen][1] und [wie man eine Folgeaufgabe erstellt][12].

### Anfrage erstellen

1. Ziehen Sie das **Anfrage erstellen**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
1. Geben Sie einen beschreibenden **Titel** ein.
1. Wählen Sie einen [Anfragetyp][14], der sich auf Standardwerte und verfügbare Status und Prioritäten auswirkt.
1. Wählen Sie [Status][15], [Kategorie][16] und [Priorität][17].
1. **Eigentümer:**
    * Um die Anfrage einer bestimmten Person zuzuweisen, wählen Sie den gewünschten Namen aus.
    * **Automatisch zugewiesen:** Wenn Sie diese Option auswählen, weist das System die Anfrage gemäß den geltenden Zuweisungsregeln zu.
    * **Nicht zugewiesen:** Sie können sich auch dafür entscheiden, die Anfrage nicht zuzuweisen. Die Mitglieder der relevanten Kategorie sind dann für die Bearbeitung der Anfrage verantwortlich.
1. Geben Sie die tatsächliche Nachricht ein, die Sie der Anfrage hinzufügen möchten.

Weitere Details finden Sie in der [Liste der Schritt-Einstellungen][1] und [wie man eine Anfrage erstellt][13].

### Verkauf erstellen

Wenn der Person diesen Schritt erreicht, ist der Person reif und hat Anzeichen für eine Verkaufschance gezeigt.

1. Ziehen Sie das **Verkauf erstellen**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
1. Geben Sie einen beschreibenden **Titel** ein.
1. Wählen Sie einen Verkaufstyp aus, der sich auf Standardwerte und verfügbare Stufen auswirkt.
1. Geben Sie die erforderlichen Informationen in die anderen Felder ein.
1. Eigentümer: Wählen Sie aus, wer diesem Lead nachverfolgen soll: "Unser Kontakt" oder "Unser Service-Kontakt", oder ein spezifisch benannter Mitarbeiter.

    > [!NOTE]
    > Fügen Sie auch eine Folgeaufgabe hinzu, um den Eigentümer des Verkaufs über diese neue Gelegenheit zu informieren.

Weitere Details finden Sie in der [Liste der Schritt-Einstellungen][1] und [wie man einen Verkauf erstellt][18].

## <a id="internal"></a>Interne Aktionen

### Skript ausführen

Führen Sie benutzerdefinierte Geschäftslogik aus, indem Sie ein CRMScript als Teil des Flows auslösen.

1. Ziehen Sie das **Skript ausführen**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
1. Wählen Sie ein [CRMScript][20] aus der Liste.

> [!NOTE]
> Der Teilnehmer wird sofort nach dem Auslösen des Skripts zum nächsten Schritt übergehen, ohne auf das Ergebnis zu warten.

### Per E-Mail benachrichtigen

Senden Sie eine Benachrichtigungs-E-Mail an eine bestimmte Person als Teil des Ablaufs.

1. Ziehen Sie das Feld **Per E-Mail benachrichtigen** aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
1. Geben Sie den Empfänger (**An:**).
1. Geben Sie den **Betreff** der E-Mail ein.
1. Geben Sie die Nachricht ein, die Sie senden möchten.

Kontaktvariablen (Merge-Tags) sind verfügbar.

### Per SMS benachrichtigen

Senden Sie eine Benachrichtigungs-SMS an eine bestimmte Person als Teil des Ablaufs.

1. Ziehen Sie das Feld **Per SMS benachrichtigen** aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagrammm fallen.
2. Geben Sie den Empfänger (**An:**).
3. Geben Sie die Nachricht ein, die Sie senden möchten. Kontaktvariablen (Merge-Tags) sind verfügbar.

Wenn bei den ausgewählten Kontakten keine Mobiltelefonnummer angegeben ist, wird keine SMS empfangen.

## Flow-Aktion vs. Formular-Aktion

Mehrere Aktionstypen sind sowohl als Formularaktion als auch als Flow-Schritt möglich.

Eine [Formular-Aktion][6] könnte:

* Person zur Selektion und/oder zum Projekt hinzufügen
* Interesse am Person hinzufügen
* Standardkategorie und Geschäft für neue Persone und Firmen festlegen
* Eine Anfrage erstellen
* Eine Formularantwort-Mail an den Person senden

## Flow-Aktion vs. Link-Aktion

Eine [Link-Aktion][7] könnte:

* Person zur Selektion und/oder zum Projekt hinzufügen
* Interessen aktualisieren
* Einen Wert zu einem [Zusatzfeld][19] beim Person hinzufügen
* Eine Anfrage erstellen
* Eine Folgeaufgabe erstellen

<!-- Referenced links -->
[1]: step-settings.md
[6]: ../../forms/learn/define-form-actions.md
[7]: ../../tracked-links/learn/define-link-actions.md
[11]: ../../../learn/basics/bulk-update.md
[12]: ../../../diary/learn/create-follow-up.md
[13]: ../../../request/learn/create.md
[14]: ../../../request/admin/type/index.md
[15]: ../../../request/admin/status/index.md
[16]: ../../../request/admin/category/index.md
[17]: ../../../request/admin/priority/index.md
[18]: ../../../sale/learn/create.md
[19]: ../../../custom-objects/learn/extra-field.md
[20]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img2]: ../../../../media/loc/en/marketing/flow-update-contact.png
