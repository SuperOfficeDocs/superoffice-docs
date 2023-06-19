---
uid: help-de-sync-configure-field-allocation
title: Feldzuordnung konfigurieren
description: Feldzuordnung konfigurieren
author: Bergfrid Dias
so.date: 03.29.2023
keywords: Angebot, Sync, Connector, ERP, Zuordnung
so.topic: howto
so.user: admin
language: de
---

# Feldzuordnung konfigurieren

Wenn Daten zwischen SuperOffice und ERP-Systemen synchronisiert werden, müssen Sie festlegen, welches SuperOffice-Feld zu welchem ERP-Feld gehört.

> [!NOTE]
> Wenn Sie eine ERP-Verbindung bearbeiten, müssen Sie diese zuerst deaktivieren.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Wählen Sie die ERP-Verbindung aus und klicken Sie unten auf die Schaltfläche **Zuordnungen**. Das Dialogfeld **Zuweisungen** zeigt die Registerkarten für die verfügbaren Aktoren im ERP-System an.

1. Wählen Sie die Registerkarte des Aktors, für den Sie Zuweisungen konfigurieren möchten.

1. Aktivieren Sie **ERP \[actor\]mit SuperOffice synchronisieren\[entity\]**.

1. Wählen Sie in der Liste unten die Synchronisationsrichtung aus und geben Sie an, welchem SuperOffice-Feld jedes einzelne ERP-Feld zugewiesen werden soll (synchronisiert mit). Sie können auch auswählen, ob die Felder in der Registerkarte **ERP** angezeigt und gesucht werden sollen.
    Die Liste besteht aus den folgenden Spalten:

    * **In Suche anzeigen**: Aktivieren Sie dieses Feld hier, damit es in den Suchergebnissen angezeigt wird.
    * **ERP-Feld**: Zeigt den Namen des Feldes im ERP-System an.
    * **Richtung**: Hier wählen Sie die Richtung(en) für die Synchronisation aus. Siehe unten die Tabelle der Symbole.

    * **SuperOffice-Feld**: Hier wählen Sie aus, welches SuperOffice-Feld Sie synchronisieren möchten. Einige Felder (wie Kunden- und Personen-IDs) können nicht synchronisiert werden. In diesen Fällen bleibt die Liste leer.
    * **In ERP-Registerkarte anzeigen**: Aktivieren Sie diese Option, wenn Sie möchten, dass dieses Feld in der Registerkarte **ERP** in SuperOffice CRM (Anzeige Firma, Person und Projekt) angezeigt wird.

        > [!NOTE]
        > Wenn Sie auswählen, dass dieses Feld mit einem SuperOffice-Feld synchronisiert wird, hat es keinen Sinn, das Feld in der Registerkarte **ERP** anzuzeigen.

1. Wiederholen Sie die Schritte 4 bis 6, um Feldzuweisungen für andere Aktoren zu konfigurieren.

1. Klicken Sie auf **Fertig**, um den Vorgang abzuschließen. Unter der Liste **ERP-Verbindungen** werden alle Felder angezeigt, die für die verschiedenen Aktoren synchronisiert sind.

1. Aktivieren Sie die Option **Aktiv** für die ERP-Verbindung, die Sie bearbeitet haben.

## Was bedeuten die Symbole?

| Symbol | Erläuterung |
|---|---|
| ![Symbol][img1] | Keine Synchronisation (SuperOffice-Feld ist ausgewählt). Ist dieses Feld obligatorisch, MÜSSEN Sie eine Richtung auswählen. |
| ![Symbol][img2] | Beidseitige Synchronisation. |
| ![Symbol][img3] | Von SuperOffice zu ERP-System synchronisieren. |
| ![Symbol][img4] | Von ERP-System zu SuperOffice synchronisieren. |
| ![Symbol][img5] | Keine Synchronisation (SuperOffice-Feld ist NICHT ausgewählt), oder: Das Feld kann nicht synchronisiert werden (zum Beispiel Kundenname). Dies kann auch durch schreibgeschützte Felder bedingt sein. Gehen Sie mit der Maus über das Symbol, um die Details anzusehen. |

> [!NOTE]
> Die Pfeile sind deaktiviert, bis Sie ein SuperOffice-Feld auswählen.

## Fehlerbehebung

Falls Sie unsachgemäße Einstellungen für die Feldzuweisungen definiert haben, erhalten Sie eine Fehlermeldung mit einer Beschreibung des Fehlers. Dies wäre beispielsweise der Fall, wenn für ein obligatorisches Feld keine Synchronisationsrichtung ausgewählt worden wäre. Sie müssen dann den Fehler beheben, bevor Sie die ERP-Verbindung aktivieren können.

## Zuordnen/Zuweisen von Listenobjekten

Wenn Sie Listen zugeordnet haben (beispielsweise Kategorie), müssen Sie auch [jeder Liste einzelne Objekte zuordnen][1].

<!-- Referenced links -->
[1]: sync-configure-list-mapping.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/sync-none.bmp
[img2]: ../../../../../media/icons/admin/sync-2-way.bmp
[img3]: ../../../../../media/icons/admin/sync-to-erp.bmp
[img4]: ../../../../../media/icons/admin/sync-to-so.bmp
[img5]: ../../../../../media/icons/admin/sync-deactivated.bmp
