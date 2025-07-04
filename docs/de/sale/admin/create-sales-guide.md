---
uid: help-de-sales-guide-create
title: Neuen Verkaufsleitfaden erstellen
description: Erfahren Sie, wie Sie einen Verkaufsleitfaden in SuperOffice erstellen.
keywords: Verkaufsleitfaden erstellen, neuer Verkaufsleitfaden, Verkaufsleitfaden, Leitfaden, Vertriebsprozess, Workflow, Verkauf
author: SuperOffice RnD
date: 02.11.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/sale/learn/sales-guide/create
---

# Neuen Verkaufsleitfaden erstellen

[!include[Must be admin](../../learn/includes/req-admin.md)]

In Einstellungen und Verwaltung definieren Sie, welche Verkaufstypen einen Verkaufsleitfaden erhalten und welche Stufen und Aktivitäten diese enthalten. Das Erscheinungsbild eines Verkaufsleitfadens kann daher variieren.

Der beste Weg, Ihren eigenen Workflow zu definieren, ist, zunächst die Best Practices in Ihrem Vertriebsprozess zu besprechen und festzulegen. Sie können mehrere Verkaufstypen mit Leitfäden einrichten, wenn Ihr Unternehmen mehr als einen Vertriebsprozess nutzt. Beispielsweise können Sie einen Verkaufstyp mit Leitfaden für Interessenten, bestehende Kunden oder für langfristige Verkaufsprozesse mit vielen Stufen und Aktivitäten definieren.

Diese Anleitung zeigt Ihnen, wie Sie einen Verkaufsleitfaden von Grund auf neu erstellen.

1. Definieren Sie [Stufen](#create-stages), die in den Verkaufsleitfaden aufgenommen werden sollen.
2. Definieren Sie den [Verkaufstyp](#create-type) (mit den zugehörigen Stufen), mit dem der Verkaufsleitfaden verknüpft wird.
3. Designen Sie den [Verkaufsleitfaden](#create-guide).

## <a id="create-stages"></a>Stufen für den Verkaufsleitfaden erstellen

Ein Verkaufsleitfaden muss mit einem Verkaufstyp verknüpft werden, der wiederum aus mehreren Stufen besteht. [Wie man eine Stufe erstellt][2].

Ein Verkaufsleitfaden für Neukunden kann beispielsweise die Stufen **Interessephase**, **Angebot** und **Vertragsunterzeichnung** enthalten.

Fahren Sie mit dem nächsten Schritt fort, um die Stufen mit einem Verkaufstyp zu verknüpfen.

## <a id="create-type"></a>Verkaufstyp für den Verkaufsleitfaden erstellen

Ein Verkaufsleitfaden muss mit einem Verkaufstyp verknüpft werden. [Wie man einen Verkaufstyp erstellt][3].

Beispiele für Verkaufstypen: "Verkauf an neuen Kunden", "Verkauf an bestehenden Kunden" und "Cross-Sale-Verkauf an bestehenden Kunden".

1. Aktivieren Sie die Option **Dieser Verkaufstyp ist mit einem Leitfaden verknüpft**.
1. Wählen Sie mindestens zwei Stufen aus.
1. Fahren Sie mit dem nächsten Schritt fort, um den Verkaufsleitfaden zu erstellen.

## <a id="create-guide"></a>Verkaufsleitfaden erstellen

Nachdem Sie die Stufen definiert und einen Verkaufstyp für den Verkaufsleitfaden festgelegt haben, können Sie den Verkaufsleitfaden selbst gestalten, indem Sie Folgeaufgaben und/oder Dokumente für jede Stufe hinzufügen.

1. Klicken Sie im Navigator auf <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow**.

2. Wählen Sie die Registerkarte **Verkaufsleitfaden**.

3. Wählen Sie im Listenfeld oben den Verkaufstyp aus, für den Sie einen Verkaufsleitfaden erstellen möchten. Die für diesen Verkaufstyp ausgewählten Stufen werden unten angezeigt.

    * Wenn der Verkaufstyp nicht für einen Verkaufsleitfaden eingerichtet ist, klicken Sie auf **Hier klicken, um Leitfaden zu aktivieren**.

    * Wenn für den Verkaufstyp keine Stufen definiert sind, klicken Sie auf **Hier klicken, um Stufen hinzuzufügen**. Sie können den Verkaufstyp auch bearbeiten, indem Sie oben auf die Schaltfläche **Bearbeiten** klicken.

4. Wählen Sie die gewünschte Stufe in der Liste aus. Die Details zur Stufe werden unten angezeigt.

5. [Fügen Sie eine oder mehrere Folgeaufgaben hinzu](#add-fo-stage).

    Sie müssen nicht für jede Stufe ein Dokument hinzufügen, sollten jedoch mindestens eine Folgeaufgabe pro Stufe definieren.

6. [Fügen Sie ein oder mehrere Dokumente hinzu](#add-doc-stage).

7. Wiederholen Sie die Schritte 4-6 für jede Stufe, der Sie Folgeaufgaben und Dokumente hinzufügen möchten.

Die Änderungen werden automatisch gespeichert. Der Verkaufsleitfaden wird nun in SuperOffice CRM angezeigt, wenn ein Verkauf mit dem in Schritt B ausgewählten Verkaufstyp erstellt wird.

## <a id="add-fo-stage"></a>Folgeaufgabe für eine Stufe hinzufügen

1. Wählen Sie den gewünschten Verkaufstyp und die Stufe wie oben beschrieben aus.

2. Klicken Sie unter **Vorgeschlagene Folgeaufgaben in Stufe** auf **Hinzufügen**.

3. Geben Sie im Dialogfeld **Vorgeschlagene Folgeaufgabe** den Namen der Folgeaufgabe in das Feld **Name** ein. Verwenden Sie eine aussagekräftige Bezeichnung.

4. Geben Sie im Feld **Zweck dieser Folgeaufgabe** den Text ein, der als QuickInfo für die Folgeaufgabe in der Registerkarte **Verkaufsleitfaden** in SuperOffice CRM verwendet werden soll.

    > [!NOTE]
    > Einige der unten aufgeführten Optionen sind aus logischen Gründen nicht relevant für die erste Folgeaufgabe eines Verkaufsleitfadens.

5. Aktivieren Sie die Option **Diese Folgeaufgabe automatisch vorschlagen**, wenn SuperOffice CRM diese Folgeaufgabe vorschlagen soll, sobald die vorherige Folgeaufgabe (in dieser oder der vorherigen Stufe) als abgeschlossen gekennzeichnet wird.

6. Wählen Sie in der Liste **Typ der Folgeaufgabe** einen Typ aus.

7. Geben Sie im Feld **Startdatum** an, wie viele Tage zwischen der vorherigen und dieser Folgeaufgabe liegen sollen.

8. Geben Sie im Feld **Dauer** an, wie lange die Folgeaufgabe dauern soll. Das Format hierfür ist *0h 00m*.

9. Geben Sie im Feld **Standardtext in Folgeaufgabe** eine Beschreibung für die Folgeaufgabe ein.

    > [!TIP]
    > Der Benutzer kann diese Informationen bei Bedarf anpassen.

10. Klicken Sie auf **Speichern**.

11. Wiederholen Sie diesen Vorgang für weitere Folgeaufgaben in dieser oder anderen Stufen.

### Beispiel für eine Folgeaufgabe

**Verkaufstyp**: Verkauf an neuen Kunden
**Stufe**: Interessephase
**Name** der Folgeaufgabe: Interessephase
**Zweck dieser Folgeaufgabe**: Identifizieren der Bedürfnisse des potenziellen Kunden und Bewerten, ob das Produkt diesen Bedürfnissen gerecht wird
**Typ der Folgeaufgabe**: Kundengespräch
**Dauer**: 1 Stunde
**Standardtext**:

Agenda für Interessephase:

\- Informationen zum Geschäftsfeld und zum Unternehmen des Kunden
\- Bedürfnisse, Wünsche und Probleme
\- Präsentation der Firma
\- Sonstiges

## <a id="add-doc-stage"></a>Dokument für eine Stufe hinzufügen

1. Wählen Sie den gewünschten Verkaufstyp und die Stufe wie oben beschrieben aus.

2. Klicken Sie unter **Vorgeschlagene Dokumente in Stufe** auf **Hinzufügen**.

3. Geben Sie im Dialogfeld **Vorgeschlagenes Dokument** den Namen des Dokuments in das Feld **Name** ein. Verwenden Sie eine aussagekräftige Bezeichnung.

4. Geben Sie im Feld **Zweck dieses Dokuments** den Text ein, der als QuickInfo für das Dokument auf der Registerkarte **Verkaufsleitfaden** verwendet werden soll.

5. Wählen Sie die gewünschte [Vorlage][4] im Feld **Vorlage** aus.

6. Geben Sie im Feld **Standardbetreff** den Betreff für das Dokument ein.

7. Geben Sie im Feld **Unser Zeichen** eine Referenz an, beispielsweise eine [Vorlagenvariable][1] für eine Verkaufsnummer, einen Verkaufstitel oder ein anderes mit dem Verkauf verknüpftes Feld.

8. Klicken Sie auf **Speichern**.

9. Wiederholen Sie diesen Vorgang für weitere Dokumente in dieser oder anderen Stufen.

### Beispiel für ein Dokument

**Verkaufstyp**: Verkauf an neuen Kunden
**Stufe**: Interessephase
**Name** des Dokuments: Terminbestätigung
**Zweck dieses Verkaufsschrittes**: Versenden einer E-Mail an alle Teilnehmer des Interessephases, in der das Datum und die Uhrzeit des Gesprächs bestätigt werden.
**Vorlage**: E-Mail
**Standardbetreff**: Terminbestätigung (Interessephase)

<!-- Referenced links -->
[1]: ../../document/templates/variables/for-sales.md
[4]: ../../document/templates/learn/index.md
[2]: sale-stage.md
[3]: sale-type.md
