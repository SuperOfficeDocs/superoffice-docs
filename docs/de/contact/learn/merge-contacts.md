---
uid: help-de-contact-merge
title: Personen zusammenführen
description: Personen zusammenführen
author: SuperOffice RnD
date: 06.29.2022
keywords: Firma
topic: howto
language: de
---

# Personen zusammenführen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Wenn eine natürliche Person als zwei verschiedene Kontakte in SuperOffice CRM erfasst wurde, können Sie diese Personen zusammenführen. Wenn die Person zum Beispiel unter zwei verschiedenen Namen bei derselben Firma erfasst war ("Jonathan Clark" und "Jonathon Clarke") oder wenn die Person sowohl bei ihrem alten als auch bei ihrem neuen Arbeitgeber erfasst war.

Die Projektzugehörigkeit und die Aktivitäten werden zur neuen Person verschoben; die Quellperson kann entweder gelöscht oder als ausgeschieden gekennzeichnet werden.

1. Öffnen Sie mit einem der folgenden Schritte das Dialogfeld **Personen zusammenführen**:
    * Gehen Sie in die Anzeige Firma: Wechseln Sie zur Bereichsregisterkarte **Personen**, wählen Sie eine oder zwei zusammenzuführende Personen aus, klicken Sie mit der rechten Maustaste darauf und wählen Sie **Personen verwalten** und **Personen zusammenführen**.
    * In der Ansicht Person: Gehen Sie zur gewünschten Person, klicken Sie auf das ![Symbol][img1] der Schaltfläche **Aufgabe** in der Personenkarte und wählen Sie **Personen verwalten** und **Personen zusammenführen** aus.

2. Wenn Sie nur eine Person ausgewählt haben, wählen Sie unter **An** eine andere Person aus (beginnen Sie mit der Eingabe, um nach einer Person zu suchen). Die beiden Personen, die zusammengeführt werden sollen, werden nun unter **Von** und **An** angezeigt.

    > [!TIP]
    > Um die Personen **Von** und **An** umzuschalten, klicken Sie auf die Schaltfläche ![Symbol][img2].

3. Wählen Sie unter **Aktion an \[contact/company\] nach dem Zusammenführen** eine der folgenden Optionen aus:
    * **Löschen...**: Bei Auswahl dieser Option wird die Quellperson nach dem Zusammenführen gelöscht.
        Wenn Sie zum Beispiel dieselbe Person zweimal unter derselben Firma erfasst haben.
    * **Als ausgeschiedenen Mitarbeiter kennzeichnen**: Bei Auswahl dieser Option wird die Quellperson nach dem Zusammenführen als ausgeschiedener Mitarbeiter gekennzeichnet.
        Wenn eine Person zum Beispiel Jobs gewechselt hat, aber immer noch unter der alten Firma erfasst bleiben soll.

4. Wählen Sie unter **Aktion für alle vorhandenen Aktivitäten und Verkäufe** eine der folgenden Optionen:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

5. Klicken Sie auf **Zusammenführen**. Die Personen werden zusammengeführt und die Projektzugehörigkeiten und Zugehörigkeiten statischer Selektionen werden verschoben.

> [!NOTE]
> Sie können keine Personen (SuperOffice-Benutzer) in Ihrer eigenen Firma zusammenführen, aber Sie können eine Person von einer anderen Firma mit einer Person in Ihrer eigenen Firma zusammenführen.

## Verwandte Themen

* [Firmen zusammenführen][1]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/info-ball.png
