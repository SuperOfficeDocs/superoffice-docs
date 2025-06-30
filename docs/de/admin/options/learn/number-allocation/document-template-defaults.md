---
uid: help-de-document-template-defaults
title: Standardwerte für neue Dokumentvorlagen
description: Standardwerte für neue Dokumentvorlagen
author: Bergfrid Dias
date: 03.24.2023
keywords: Nummer, Zähler
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Standardwerte für neue Dokumentvorlagen

Bei Bedarf können Sie Standardwerte für neue Dokumentvorlagen festlegen. Das bedeutet, dass der Wert im Feld **Unser Zeichen** in dem Dialogfeld Dokument bei jeder Verwendung genau dieser Vorlage um 1 erhöht wird. Wenn Sie das Kontrollkästchen **Automatisch einen neuen Zähler für neue Dokumentvorlagen erstellen** nicht aktivieren, wird derselbe Zähler für alle Dokumentvorlagen verwendet, so dass der Wert im Feld **Unser Zeichen** sich jedes Mal um 1 erhöht, wenn eine der Vorlagen verwendet wird.

> [!NOTE]
> Ob das Feld **Unser Zeichen** im Dialogfeld Dokument als Zähler fungiert, hängt davon ab, ob die {snum} Vorlagenvariabel in der betreffenden Vorlage festgelegt wurde. Dies wird in der Ansicht Listen festgelegt: Klicken Sie auf **Dokumentvorlage**, doppelklicken Sie dann auf die Dokumentvorlage unter **Objekte** und bearbeiten das Feld **Unser Zeichen (Standard)** im Dialogfeld **Listenobjekt bearbeiten**.

## Festlegen, dass neue Dokumentvorlagen ihre eigenen Zähler haben

1. [!include[Go to Options](../includes/open-options.md)]

2. Wählen Sie die Registerkarte **Nummernzuweisung**.

3. Aktivieren Sie im unteren Bereich der Registerkarte das Kontrollkästchen **Automatisch einen neuen Zähler für neue Dokumentvorlagen erstellen**.

4. Klicken Sie auf **Standards**.

5. Aktivieren Sie die Option **Eindeutig**, wenn Sie möchten, dass die Werte im Feld **Unser Zeichen** eindeutig sind. Dies ist nützlich, wenn SuperOffice CRM-Benutzer selbst Werte zuweisen.

6. Aktivieren Sie **Leerzeichen erlaubt**, um leere Zählerfelder zuzulassen. Dies ist nützlich, wenn die Zählerwerte eindeutig sein müssen. Für leere Felder gilt nämlich die Einschränkung der Eindeutigkeit nicht.

7. Aktivieren Sie die Option **Schreibgeschützt**, wenn Sie nicht möchten, dass die SuperOffice CRM-Benutzer selbst Werte in das Feld **Unser Zeichen** eingeben können.

8. Aktivieren Sie **Zuweisen**, um die automatische Zählerfunktion zu verwenden. Das System vergibt dann automatisch die Werte im Feld **Unser Zeichen**.

    [Sehen Sie sich die Ergebnisse verschiedener Kombinationen dieser Werte an][1].

9. Geben Sie den Wert, bei dem der Zähler beginnen soll, im Feld **Nächste Nummer** ein.

10. Klicken Sie auf **Speichern**.

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
