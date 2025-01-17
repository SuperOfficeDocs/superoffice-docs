---
uid: help-de-sales-guide-create
title: Neuen Verkaufsleitfaden erstellen
description: Wie man einen Projektleitfaden in SuperOffice erstellt
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Verkauf, Leitfaden
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Neuen Verkaufsleitfaden erstellen

[!include[Must be admin](../../../learn/includes/req-admin.md)]

In dieser Vorgehensweise wird beschrieben, wie Sie einen Verkaufsleitfaden komplett neu erstellen können.

1. Definieren Sie [Stufen](#create-stages), die in den Verkaufsleitfäden aufgenommen werden sollen.
2. Definieren Sie den [Vertriebstyp](#create-type) (mit den zugehörigen Stufen), mit dem der Verkaufsleitfaden verknüpft werden soll.
3. Designen Sie [Verkaufsleitfäden](#create-guide).

## <a id="create-stages" />Stufen für den Verkaufsleitfaden erstellen

Der Verkaufsleitfaden muss mit einem Verkaufstyp verknüpft werden, der wiederum aus mehreren Stufen besteht. [Wie man eine Stufe erstellt][2].

Ein Verkaufsleitfaden für Verkäufe an neue Kunden kann zum Beispiel die Stufen "Interessephase", "Angebot" und "Vertragsunterzeichnung" enthalten.

Im nächsten Schritt können Sie die Stufen mit einem Verkaufstyp verknüpfen.

## <a id="create-type" />Verkaufstyp für den Verkaufsleitfaden erstellen

Der Verkaufsleitfaden muss mit einem Verkaufstyp verknüpft werden. [Wie man einen Verkaufstyp erstellt][3].

Mögliche Verkaufstypen sind z. B.: "Verkauf an neuen Kunden", "Verkauf an bestehenden Kunden" und "Cross-Sale-Verkauf an bestehenden Kunden".

1. Aktivieren Sie **Dieser Verkaufstyp ist mit einem Leitfaden verknüpft**.
1. Wählen Sie zumindest zwei Stufen aus.
1. Im nächsten Schritt können Sie den Verkaufsleitfaden erstellen.

## <a id="create-guide" />Verkaufsleitfaden erstellen

Nachdem Sie die Stufen erstellt und einen Verkaufstyp für den Verkaufsleitfaden angegeben haben, können Sie den eigentlichen Verkaufsleitfaden gestalten, indem Sie Folgeaufgaben und/oder Dokumente für jede Stufe hinzufügen.

1. Klicken auf die Schaltfläche **Workflow** im Navigator (![Symbol][img1]).

2. Wählen Sie die Registerkarte **Verkaufsleitfaden**.

3. Wählen Sie in der Liste oben den Verkaufstyp aus, für den Sie einen Verkaufsleitfaden erstellen möchten. Die für diesen Verkaufstyp ausgewählten Stufen werden unten angezeigt.

    * Wenn für diesen Verkaufstyp kein Verkaufsleitfaden definiert ist, müssen Sie unten in der Ansicht auf **Hier klicken, um Leitfaden zu aktivieren** klicken.

    * Wenn für den Verkaufstyp keine Stufen festgelegt sind, müssen Sie unten in der Ansicht auf **Hier klicken, um Stufen hinzuzufügen** klicken. Sie können den Verkaufstyp auch bearbeiten, indem Sie oben auf die Schaltfläche **Bearbeiten** klicken.

4. Wählen Sie die gewünschte Stufe in der Liste aus. Die Einzelheiten zu dieser Stufe werden unten in der Ansicht angezeigt.

5. [Einen oder mehrere Folgeaufgaben für die ausgewählte Stufe hinzufügen](#add-fo-stage).

    Sie müssen für die einzelnen Stufen nicht unbedingt ein Dokument hinzufügen, Sie sollten jedoch mindestens eine Folgeaufgabe pro Stufe hinzufügen.

6. [Ein oder mehrere Dokumente](#add-doc-stage) für die ausgewählte Stufe hinzufügen.

7. Wiederholen Sie die Schritte 4 bis 6 für jede Stufe, der Sie Folgeaufgaben und Dokumente hinzufügen möchten.

Die Änderungen werden automatisch gespeichert. Der betreffende Verkaufsleitfaden wird in SuperOffice CRM angezeigt, wenn ein Verkauf mit dem Verkaufstyp, der in Schritt B ausgewählt wurde, erstellt wird.

## <a id="add-fo-stage" />Folgeaufgabe für eine Stufe hinzufügen

1. Wählen Sie den gewünschten Verkaufstyp und die Stufe wie oben beschrieben aus.

2. Klicken Sie unter **Vorgeschlagene Folgeaufgaben in Stufe** auf **Hinzufügen**.

3. Geben Sie im Dialogfeld **Vorgeschlagene Folgeaufgabe** den Namen der Folgeaufgabe in das Feld **Name** ein. Es sollte sich dabei um einen aussagekräftigen Namen der Folgeaufgabe handeln.

4. Geben Sie im Feld **Zweck dieser Folgeaufgabe** den Text ein, der als QuickInfo für die Folgeaufgabe auf der Registerkarte **Verkaufsleitfaden** in SuperOffice CRM verwendet werden soll.

    > [!NOTE]
    > Einige der unten aufgeführten Optionen sind aus logischen Gründen nicht relevant für die erste Folgeaufgabe eines Verkaufsleitfadens.

5. Aktivieren Sie die Option **Diese Folge Aufgabe automatisch vorschlagen**, wenn Sie möchten, dass SuperOffice CRM diese Folgeaufgabe vorschlägt, sobald die vorherige Folgeaufgabe (in dieser oder in der vorherigen Stufe) als abgeschlossen gekennzeichnet wird.

6. Wählen Sie in der Liste **Typ der Folgeaufgabe** einen Typ für die Folgeaufgabe aus.

7. Geben Sie im Feld **Startdatum** an, wie viele Tage zwischen der vorherigen Folgeaufgabe und dieser Folgeaufgabe liegen sollen.

8. Geben Sie im Feld **Dauer** an, wie lange die Folgeaufgabe dauern soll. Das Format hierfür ist *0 h 00 m*.

9. Geben Sie in das Feld **Standardtext in Folgeaufgabe** eine Beschreibung für die Folgeaufgabe ein.

    > [!TIP]
    > Der Benutzer kann die obigen Informationen bei Bedarf ändern.

10. Klicken Sie auf **Speichern**.

11. Wiederholen Sie diesen Vorgang, wenn Sie weitere Folgeaufgaben zu dieser oder zu einer anderen Stufe hinzufügen möchten.

### Beispiel für eine Folgeaufgabe

**Verkaufstyp**: Verkauf an neuen Kunden
**Stufe**: Interessephase
**Name** der Folgeaufgabe: Interessephase
**Zweck dieser Folgeaufgabe**: Identifizieren der Bedürfnisse des potenziellen Kunden und Bewerten, ob das Produkt diesen Bedürfnissen gerecht wird
**Typ der Folgeaufgabe**: Kundengespräch
**Dauer**: 1 Stunde
**Standardtext**:

Agenda für Erstgespräch:

\- Informationen zum Geschäftsfeld und zum Unternehmen des Kunden
\- Bedürfnisse, Wünsche und Probleme
\- Präsentation der Firma
\- Sonstiges

## <a id="add-doc-stage" />Dokument für eine Stufe hinzufügen

1. Wählen Sie den gewünschten Verkaufstyp und die Stufe wie oben beschrieben aus.

2. Klicken Sie unter **Vorgeschlagene Dokumente in Stufe** auf **Hinzufügen**.

3. Geben Sie im Dialogfeld **Vorgeschlagenes Dokument** den Namen des Dokuments in das Feld **Name** ein. Es sollte sich dabei um eine aussagekräftige Bezeichnung des Dokuments handeln.

4. Geben Sie im Feld **Zweck dieses Dokuments** den Text ein, der als QuickInfo für das Dokument auf der Registerkarte **Verkaufsleitfaden** verwendet werden soll.

5. Wählen Sie die gewünschte Vorlage im Feld **Vorlage** aus (siehe auch [Dokument - Vorlage][4]).

6. Wählen Sie den im Dokument zu verwendenden Betreff im Feld **Standardbetreff** aus.

7. Geben Sie Ihr Zeichen in das Feld **Unser Zeichen** ein. Zum Beispiel eine [Vorlagenvariable][1] für eine Verkaufsnummer, einen Verkaufstitel oder ein anderes Feld angeben, das mit dem Verkauf verknüpft ist.

8. Klicken Sie auf **Speichern**.

9. Wiederholen Sie diesen Vorgang, wenn Sie weitere Dokumente zu dieser oder zu einer anderen Stufe hinzufügen möchten.

### Beispiel für ein Dokument

**Verkaufstyp**: Verkauf an neuen Kunden
**Stufe**: Interessephase
**Name** des Dokuments: Terminbestätigung
**Zweck dieses Verkaufsschrittes**: Versenden einer E-Mail an alle Teilnehmer des Erstgesprächs, in der das Datum und die Uhrzeit des Gesprächs bestätigt werden.
**Vorlage**: E-Mail
**Standardbetreff**: Terminbestätigung (Erstgespräch)

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/for-sales.html
[2]: ../../../admin/lists/learn/sale-stage.md
[3]: ../../../admin/lists/learn/sale-type.md
[4]: ../../../admin/lists/learn/document-template.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
