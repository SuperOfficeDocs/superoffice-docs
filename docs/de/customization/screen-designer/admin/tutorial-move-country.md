---
uid: help-de-tutorial-country-before-address
title: Tutorial - Land nach vorne verschieben
description: In diesem Tutorial lernen Sie, wie Sie das Länderfeld auf einem Firmen- oder Personbildschirm verschieben.
keywords: länderfeld, ansichtsdesigner
date: 06.27.2025
version: 10.4
content_type: tutorial
audience: admin
language: de
---

# Tutorial - Land nach vorne verschieben

## Schritt 1: Zweck

In SuperOffice werden Adressen basierend auf Land und Region formatiert. Um die Benutzer dazu zu ermutigen, zuerst das Land auszuwählen, werden wir dieses Feld an den Anfang des **Firmen**-Bildschirms verschieben.

Am Ende sollte es etwa so aussehen:

![Firmenkarte -screenshot][img1]

[!include[Anforderung](../../../includes/req-dev-tools.md)]

## Schritt 2: Öffnen Sie den Ansichtsdesigner

1. Gehen Sie zu **Einstellungen und Verwaltung**.
1. Wählen Sie **Ansichtsdesigner** aus dem Navigator.

![Ansichtsdesigner -screenshot][img2]

## Schritt 3: Layout im Bearbeitungsmodus öffnen

1. Wählen Sie oben **Firma**.
1. Wählen Sie direkt darunter die Registerkarte **Hauptkarten**.
1. Wählen Sie das Standardlayout aus der Liste.
1. Klicken Sie unten auf **Layout bearbeiten**.

![Firmenlayout im Bearbeitungsmodus -screenshot][img3]

## Schritt 4: Felder aktualisieren

1. Wählen Sie im Vorschaubereich die Registerkarte **Firma**.
1. Klicken Sie, um das Feld **Land** auszuwählen.
1. Greifen Sie das **=** links neben dem Feldlabel, ziehen Sie es nach oben und lassen Sie es in der neuen Position fallen.

![Firmenlayout im Bearbeitungsmodus -screenshot][img4]

## Schritt 5: Speichern, veröffentlichen und Ergebnisse testen

1. Klicken Sie auf **Speichern + Veröffentlichen**.
1. Melden Sie sich in einem anderen Browser-Tab von SuperOffice ab. Dann melden Sie sich wieder an.
1. Gehen Sie zum **Firmen**-Bildschirm, um das Ergebnis zu sehen.

Sie könnten dies auch für den **Person**-Bildschirm machen.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/tutorial-country-result.png
[img2]: ../../../../media/loc/en/customization/open-screen-designer.png
[img3]: ../../../../media/loc/en/customization/tutorial-country-layout-before.png
[img4]: ../../../../media/loc/en/customization/tutorial-country-layout-after.png
