---
uid: help-de-quote-template
title: Angebotsvorlagen und Merge fields
description: Angebotsvorlagen und Merge fields
keywords: Angebot, Angebotsvorlage, Vorlage, Angebotsdokument, Angebotsdetails, Merge field
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: concept
language: de
---

# Angebotsvorlagen und Merge fields

Diese Anleitung beschreibt die verschiedenen Arten von Angebotsvorlagen, die in SuperOffice CRM verfügbar sind, sowie Anweisungen zur Verwendung von Merge fields zur Anpassung von Angeboten und Auftragsbestätigungen. Diese Vorlagen umfassen das Hauptangebotsdokument, Angebotsdetails, Auftragsbestätigungen und zugehörige E-Mail-Vorlagen.

Ein Angebot besteht oft aus mehr als einem Produkt. Daher ist es notwendig, eine Angebotsdetails-Vorlage (und eine Auftragsbestätigungs-Vorlage) zu erstellen, in der jedes Produkt in einer Tabelle mit verschiedenen Gruppierungen (wie Alternativen) aufgeführt ist. Der Benutzer kann das Angebotsdokument nur in Word bearbeiten. Die Angebotsdetails und die Auftragsbestätigung werden als PDF generiert und können vom Benutzer nicht bearbeitet werden. Alle Angebotsvorlagen können auf die übliche Weise in den Einstellungen und Verwaltung bearbeitet werden.

## <a id="types"></a>Typ des Angebotsdokumentvorlagen

SuperOffice bietet verschiedene Vorlagen zur Erstellung von Angeboten. Diese Vorlagen sind in den Einstellungen und Verwaltung unter **Listen** zugänglich und anpassbar.

| Typ | Beschreibung | Format | Beispiel |
|---|---|---|---|
| Angebot | Hauptangebotsdokumentvorlage | .doc oder .docx | markiert in Gelb |
| Angebotsdetails | Vorlage für Angebotsdetails | .pdf | markiert in Lila |
| Auftragsbestätigung | Vorlage für Auftragsbestätigung | .pdf | markiert in Rosa |
| E-Mail-Vorlage | Vorlagen für Angebot- und Auftragsbestätigungs-E-Mails | | markiert in Orange |

![Angebot - Dokumentvorlage -screenshot][img1]

![Angebot - E-Mail-Vorlage -screenshot][img2]

### Angebotsdokument

Die **Angebot-Vorlage** ist eine Kombination aus dem Hauptangebotstext (Begleitbrief des Vertriebsmitarbeiters) und den Angebotsdetails. Das Angebotsdokument wird erstellt, wenn Sie [ein neues Angebot erstellen][7] oder ein bestehendes Angebot öffnen und **Klicken, um das Angebotsdokument zu erstellen** auswählen. Das Dokument wird im Format .doc oder .docx erstellt, was eine Nachbearbeitung ermöglicht. Es wird automatisch unter dem Tab **Aktivitäten** im Verkaufsdatensatz gespeichert. Es ist auch über den Link auf dem Tab **Angebot** verfügbar.

### Angebotsdetails

Die **Angebotsdetails-Vorlage** wird [automatisch zusammengeführt](#usage) in das Angebotsdokument an der Stelle, an der das Merge field `<<QuoteDetails>>` platziert ist. Um das Angebotsdetails-Dokument zu erstellen, klicken Sie auf **Senden** im Angebotsbildschirm. Dies öffnet einen Dialog, in dem Sie das gewünschte Layout auswählen und die Angebotsdetails-Vorlage auswählen können. Das Dokument wird im Format .pdf erstellt und kann nach der Erstellung nicht mehr bearbeitet werden.

![Angebotsdetails Layout -screenshot][img3]

### Auftragsbestätigung

Um ein **Auftragsbestätigungsdokument** zu erstellen, klicken Sie auf die Schaltfläche **Auftrag erteilen**. Dies öffnet einen Dialog, in dem Sie entweder **Auftragsbestätigung per E-Mail senden** auswählen oder das Dokument direkt erstellen können. Die Auftragsbestätigungs-Vorlage wird basierend auf dem Verkaufstyp ausgewählt und in den Einstellungen und Verwaltung unter **Listen** > **Sale – Type, Stages, Quote** festgelegt. Das Dokument wird im Format .pdf erstellt und kann nach der Erstellung nicht mehr bearbeitet werden.

![Vorlage für Auftragsbestätigung auswahlen -screenshot][img4]

### E-Mail-Vorlage für Angebot und Auftragsbestätigung

Beim Versenden von Angeboten oder Auftragsbestätigungen per E-Mail können Sie eine E-Mail-Textvorlage auswählen. Für Angebote klicken Sie auf die **Senden**-Schaltfläche und wählen die Vorlage aus der Liste **Angebotslayout** aus. Für Auftragsbestätigungen klicken Sie auf **Auftrag erteilen**, wählen **Auftragsbestätigung per E-Mail senden**, wählen die E-Mail-Textvorlage und die Sprache aus, und klicken dann auf **OK**, um zu senden.

![Angebot, E-Mail senden -screenshot][img5]

![Angebot, Auftragsbestätigung senden -screenshot][img6]

## Merge fields in Angebotsvorlagen

**Merge fields** in SuperOffice CRM-Angebotsvorlagen ermöglichen die dynamische Einfügung von Details wie Produktlinien und Alternativen. Im Gegensatz zu [Standard-Vorlagenvariablen][1] folgen Merge fields einer spezifischen Struktur oder Hierarchie, um eine korrekte Datenintegration sicherzustellen.

Sie können Angebots- und Auftragsbestätigungs-Vorlagen mit Merge fields in Microsoft Word anpassen. Merge fields ermöglichen das Einfügen spezifischer Angebotsinformationen in Vorlagen, während Standard-Vorlagenvariablen Kundendaten und andere Details abrufen.

### <a id="structure"></a>Struktur der Merge fields

Merge fields müssen einer hierarchischen Reihenfolge folgen: Angebot > Alternative > Gruppe > Zeile. Diese Struktur wird mit den **TableStart**- und **TableEnd**-Feldern definiert, die den Beginn und das Ende jedes Tabellenbereichs markieren:

```text
«TableStart:quote»
  «TableStart:alternative»
    «GroupBy:productFamilyKey»«TableStart:group»
      «TableStart:line»
      «TableEnd:line»
    «TableEnd:group»
  «TableEnd:alternative»
«TableEnd:quote»
```

* quote: Die äußerste Ebene, die das gesamte Angebot darstellt.
* alternative: Verschachtelt innerhalb des Angebots, verwendet für verschiedene Produktalternativen.
* group: Verschachtelt innerhalb der Alternative, verwendet zum Gruppieren von Produkten (optional).
* line: Verschachtelt innerhalb der Gruppe, die einzelne Produktlinien darstellt.

> [!NOTE]
> Jede Vorlage muss der Verschachtelungsreihenfolge entsprechen und immer mit der äußersten Ebene (quote) beginnen. Sie muss nicht bis ganz nach unten gehen, darf jedoch nicht mit Alternative oder etwas anderem als Angebot beginnen.

### <a id="usage"></a>Verwendung von Merge fields

Angebotsdetails umfassen detaillierte Informationen wie Zeilen, Preise und Produktnamen, die normalerweise in einer separaten Vorlage vom Angebotsdokument platziert werden. Wenn sowohl das Hauptdokument als auch die Angebotsdetails verwendet werden:

* Wenn das Feld `<<QuoteDetails>>` im Hauptdokument vorhanden ist, werden die Angebotsdetails an dieser Stelle eingefügt.
* Wenn das Feld `<<QuoteDetails>>` nicht vorhanden ist, werden die Angebotsdetails am Ende angehängt.

In beiden Fällen wird eine einzige PDF generiert und der E-Mail angehängt.

Tags für eine bestimmte Tabelle sind von der TableStart:-Tag dieser Tabelle bis zum Ende verfügbar.

**Beispiel:**

[Zeilenfelder][2] (wie *line/name*) können nur innerhalb der Zeilen-Tabelle (`«TableStart:line» «TableEnd:line»`) platziert werden, während Alternative-Felder sowohl innerhalb der Alternativen-Tabelle als auch in den darunter liegenden Tabellen (Gruppe und Zeile) platziert werden können.

![Angebotsdetails Beispiel, TableStart:line -screenshot][img7]

### Gruppierung und Sortierung

**Gruppierung:** Sie können Produkte in der Vorlage mit dem **GroupBy**-Tag gruppieren, mit einem Zeilen-Niveau-Suffix, wie `GroupBy:productFamilyKey`, um Produkte nach ihrer Familie zu gruppieren.

* Das GroupBy-Tag ist groß- und kleinschreibungssensitiv und kann überall im Dokument platziert werden. Zur Laufzeit verschwindet dieses Tag, ohne Text zu hinterlassen.
* Pro Vorlage ist nur ein GroupBy-Tag zulässig.

Wenn ein GroupBy-Tag vorhanden ist, verwenden Sie **TableStart** und **TableEnd**, um den Beginn und das Ende gruppenbezogener Abschnitte zu markieren. Das **group/groupField**-Tag enthält den Wert des Gruppenfeldes (zum Beispiel, produktFamilie). Der Abschnitt zwischen TableStart und TableEnd wird für jeden einzigartigen Wert des Gruppenfeldes wiederholt.

* Sie können mehrere Sets von TableStart- und TableEnd-Abschnitten haben. Beispielsweise möchten Sie möglicherweise eine Zusammenfassungstabelle mit Summen und separate Tabellen für die Zeilen in jeder Gruppe. In diesem Fall sollte die Zusammenfassungstabelle keinen inneren TableStart:line/TableEnd:line enthalten.

Innerhalb der Gruppe (zwischen TableStart und TableEnd) können Sie spezifische Felder für die Gruppe hinzufügen.

**Sortierung:** Standardmäßig werden Angebotszeilen in Rangfolge angezeigt, wie in den Angebotszeilenarchiven zu sehen. Wenn Gruppierung verwendet wird, werden Gruppen alphabetisch sortiert und die Zeilen innerhalb jeder Gruppe nach Rang.

Um die Reihenfolge der Angebotszeilen zu ändern, verwenden Sie das **OrderBy**-Tag mit einem Zeilen-Niveau-Suffix. Zum Beispiel sortiert `OrderBy:name` Produkte alphabetisch nach Name und `OrderBy:vatInfo` sortiert Produkte nach MwSt-Status. Nur eine Ebene der Sortierung wird unterstützt.

### <a id ="culture"></a>Formatierung von numerischen und Datumsdaten

Numerische und Datumsfelder können formatiert werden, um den ausgewählten Sprach-/Kultureinstellungen zu entsprechen (beeinflusst die Anzeigeordnung und Trennzeichen):

* **Numerische Felder:** Für Dezimalwerte können Sie die Anzahl der Dezimalstellen angeben (0, 2 oder 5). Zum Beispiel sorgt `line/totalPrice:2` für zwei Dezimalstellen. Das Dezimaltrennzeichen entspricht immer der gewählten Sprache/Kultur.

* **Datum- und Zeitfelder:** Verfügbare Formate umfassen ShortDate, ShortTime, ShortDateTime, LongDate, LongTime, und LongDateTime. Zum Beispiel `quote/sent:LongDateTime` für vollständiges Datum und Uhrzeit.

Wenn keine spezifische Formatierung eingestellt ist, wird der Standard für die ausgewählte Sprache verwendet.

Die tatsächliche Formatierung (Dezimaltrennzeichen, Tag/Monat Reihenfolge, usw.) spiegelt die ausgewählte Kultur des Benutzers wider, wie in den Dialogen **Angebot senden** und **Auftrag erteilen** angegeben. Für spezifische Formatierungsbedürfnisse können Sie das **Culture:** Feld in die Vorlage aufnehmen und einen [.NET Kulturcode][11] (wie `Culture:de-CH` für Deutsch) angeben, um die Wahl des Benutzers zu überschreiben. Dies bedeutet, dass ein solcher Kulturcode in eine spezielle Vorlage eingebaut werden sollte, die *Angebot für deutsche Kunden* oder ähnlich genannt wird.

> [!NOTE]
> Verwenden Sie nicht die Tabelle der Sprach- und Kulturbezeichner, Codes und ISO-Werte Methode des [C++ AppConfig-Objekts][12] als Referenz, da es geringe Unterschiede gibt.

Durch Befolgen dieser Richtlinien können Sie Merge fields effektiv nutzen, um detaillierte, maßgeschneiderte Angebots- und Auftragsbestätigungs-Vorlagen in SuperOffice CRM zu erstellen.

## Verwandte Inhalte

* [Angebotsvorlage aktualisieren][5]
* [Tutorial][6]
* [Referenz für Merge fields][3]
* [Vorlagenvariablenreferenz][4]
* [System.Globalization.CultureInfo][11]
* [Aspose][13] (verantwortlich für Dokumentenerstellung)

<!-- Referenced links -->
[1]: template-variables.md
[2]: ../merge-fields/line.md
[3]: ../merge-fields/index.md
[4]: ../variables/for-quote-line.md
[5]: ../admin/update-template.md
[6]: ../admin/update-template.md
[7]: ../../../quote/learn/create.md
[11]: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-5.0
[12]: https://docs.microsoft.com/en-us/previous-versions/commerce-server/ee825488(v=cs.20)
[13]: http://www.aspose.com

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/quote-list-document-template.png
[img2]: ../../../../media/loc/en/document/quote-list-email-template.png
[img3]: ../../../../media/loc/en/document/quote-layout.png
[img4]: ../../../../media/loc/en/document/quote-order-confirmation-template.png
[img5]: ../../../../media/loc/en/document/quote-send-email.png
[img6]: ../../../../media/loc/en/document/quote-send-confirmation.png
[img7]: ../../../../media/loc/en/document/tablestart-line.png
